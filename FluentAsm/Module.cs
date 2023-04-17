
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace FluentAsm.Assembly.ASM_6502;

public enum Operand
{
    Plus,
    Minus,
    Expression,
    Number,
    Symbol,
    Import,
}


public record class SourceInfo
{
    public string File { get; init; }
    public string Path { get; init; }
    public int Line { get; init; }
    public int Column { get; init; }

    // macro-expansion stack
    public SourceInfo? Parent { get; init; }
}

public record struct Expression
{
    public Expression() { }
    public Operand Op { get; init; }
    public IList<Expression> Args { get; init; } = new List<Expression>();
    public string? Str { get; init; }
    public int? Num { get; init; }

    public SourceInfo? Source { get; init; }
    public MetaInfo? Meta { get; init; }

    /** Extra information for 'num' values. */
    public record struct MetaInfo
    {
        /** Whether this is relative to the start of the chunk. */
        public bool? Relative { get; init; }
        /** Relative chunk the value is defined in. */
        public int? Chunk { get; init; }
        /** Org value of chunk, if known. */
        public int? Org { get; init; }
        /** Bank value of chunk, if known. */
        public int? Bank { get; init; }
        /** Offset value of chunk, if known. */
        public int? Offset { get; init; }
        /** Size hint for number. */
        public int? Size { get; init; }
    }
}

public record struct Symbol
{
    /** Name to export this symbol as, for importing into other objects. */
    public string? Export { get; set; }

    public bool IsAnonymous { get; set; }
    /** Value of the symbol. */
    public Expression? Expr { get; set; }
}

public record struct Segment
{
    /** Name of the segment, as used in .segment directives. */
    public string Name { get; set; }
    /** Bank for the segment. */
    public int? Bank { get; set; }
    /** Segment size in bytes. */
    public int? Size { get; set; }
    /** Offset of the segment in the rom image. */
    public int? Offset { get; set; }
    /** Memory location of the segment in the CPU. */
    public int? Memory { get; set; }
    /** Address size. */
    public int? Addressing { get; set; }
    /** Unallocated ranges (org), half-open [a, b). */
    public Range<(int, int)>? Free { get; set; }
}

public record struct Substitution
{
    public int Offset { get; set; }

    public int Size { get; set; }

    public Expression Expr { get; set; }
}

public enum OverwriteMode
{
    Allow,
    Forbid,
    Require,
}

public record struct Chunk
{
    public Chunk() { }
    public string? Name { get; set; }
    public IList<Segment> Segments { get; set; } = new List<Segment>();

    public uint? Org { get; set; }

    public IList<byte> Data { get; set; } = new List<byte>();

    public IList<Substitution> Subs { get; set; } = new List<Substitution>();

    public OverwriteMode Overwrite { get; set; } = OverwriteMode.Forbid;
}


public record struct Module
{
    public Module() { }

    public bool HasErrors { get; internal set; } = false;

    public IList<Chunk> Chunks { get; set; } = new List<Chunk>();

    public IList<Symbol> Symbols { get; set; } = new List<Symbol>();

    public IList<Segment> Segments { get; set; } = new List<Segment>();

}

/// Code from cdiggins https://stackoverflow.com/a/7302957
public record class UnionBase<A>
{
    dynamic? value;

    public UnionBase(A a) { value = a; }
    protected UnionBase(object x) { value = x; }

    protected T InternalMatch<T>(params Delegate[] ds)
    {
        var vt = value!.GetType();
        foreach (var d in ds)
        {
            var mi = d.Method;

            // These are always true if InternalMatch is used correctly.
            Debug.Assert(mi.GetParameters().Length == 1);
            Debug.Assert(typeof(T).IsAssignableFrom(mi.ReturnType));

            var pt = mi.GetParameters()[0].ParameterType;
            if (pt.IsAssignableFrom(vt))
                return (T)mi.Invoke(null, new object[] { value });
        }
        throw new Exception("No appropriate matching function was provided");
    }

    public T Match<T>(Func<A, T> fa) { return InternalMatch<T>(fa); }
}

public record class Union<A, B> : UnionBase<A>
{
    public Union(A a) : base(a) { }
    public Union(B b) : base(b) { }
    protected Union(object x) : base(x) { }
    public T Match<T>(Func<A, T> fa, Func<B, T> fb) { return InternalMatch<T>(fa, fb); }
}

/// Code from drharris https://stackoverflow.com/a/5343033
/// <summary>The Range class.</summary>
/// <typeparam name="T">Generic parameter.</typeparam>
public record struct Range<T> where T : IComparable<T>
{
    /// <summary>Minimum value of the range.</summary>
    public T Minimum { get; set; }

    /// <summary>Maximum value of the range.</summary>
    public T Maximum { get; set; }

    /// <summary>Presents the Range in readable format.</summary>
    /// <returns>String representation of the Range</returns>
    public override string ToString()
    {
        return string.Format("[{0} - {1}]", this.Minimum, this.Maximum);
    }

    /// <summary>Determines if the range is valid.</summary>
    /// <returns>True if range is valid, else false</returns>
    public bool IsValid()
    {
        return this.Minimum.CompareTo(this.Maximum) <= 0;
    }

    /// <summary>Determines if the provided value is inside the range.</summary>
    /// <param name="value">The value to test</param>
    /// <returns>True if the value is inside Range, else false</returns>
    public bool ContainsValue(T value)
    {
        return (this.Minimum.CompareTo(value) <= 0) && (value.CompareTo(this.Maximum) <= 0);
    }

    /// <summary>Determines if this Range is inside the bounds of another range.</summary>
    /// <param name="Range">The parent range to test on</param>
    /// <returns>True if range is inclusive, else false</returns>
    public bool IsInsideRange(Range<T> range)
    {
        return this.IsValid() && range.IsValid() && range.ContainsValue(this.Minimum) && range.ContainsValue(this.Maximum);
    }

    /// <summary>Determines if another range is inside the bounds of this range.</summary>
    /// <param name="Range">The child range to test</param>
    /// <returns>True if range is inside, else false</returns>
    public bool ContainsRange(Range<T> range)
    {
        return this.IsValid() && range.IsValid() && this.ContainsValue(range.Minimum) && this.ContainsValue(range.Maximum);
    }
}
