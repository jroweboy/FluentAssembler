
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using FluentAsm.Assembly.ASM_6502.gen;

namespace FluentAsm.Assembly.ASM_6502;

public record struct ParserContext
{
}

public class ParserVisitor : Fluent6502BaseVisitor<Module>
{
    private Chunk CurChunk { get; set; }

    private Module Mod { get; set; }

    private string Input { get; }

    public ParserVisitor(uint? addr, string input, string name, string file, int line)
    {
        var isRelocatable = (addr == null);

        var chunk = new Chunk() { Name = $"Compile@{name} in {file}:{line}", Org = addr, };
        var Mod = new Module() { };
        Mod.Chunks.Add(chunk);
    }

    public override Module Visit(IParseTree tree)
    {
        base.Visit(tree);
        return Mod;
    }

    public override Module VisitLabel_def([NotNull] Fluent6502.Label_defContext context)
    {
        
        return base.VisitLabel_def(context);
    }
}