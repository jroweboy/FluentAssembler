using Antlr4.Runtime.Tree;
using Antlr4.Runtime;
using FluentAsm.Assembly.ASM_6502.gen;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Dfa;
using Antlr4.Runtime.Sharpen;
using System.Runtime.CompilerServices;

[assembly: CLSCompliant(false)]

namespace FluentAsm.Assembly.ASM_6502;

public class Assembler
{
    public Assembler(Options opts)
    {
        Option = opts;
    }

    Options Option { get; set; }

    IEnumerable<Module> Modules { get; init; } = new List<Module>();

    public Module Compile(uint? startAddr = null, string? input = null, [CallerMemberName] string name = "", [CallerFilePath] string file = "", [CallerLineNumber] int line = 0)
    {
        if (string.IsNullOrEmpty(input)) { return new Module() {  HasErrors = true }; }

        var lexer = new FluentLexer(new AntlrInputStream(input));
        var tokens = new CommonTokenStream(lexer);
        var parser = new Fluent6502(tokens) { 
            BuildParseTree = true
        };
        var errs = new ExceptionErrorListener();
        parser.AddErrorListener(errs);

        var context = parser.module();
        var visitor = new ParserVisitor(startAddr, input!, name, file, line);
        var results = visitor.Visit(context);

        Console.WriteLine(results);
        return results.Mod with { HasErrors = results.Mod.HasErrors || errs.HasErrors };
    }

    private static readonly Lazy<Assembler> lazy = new Lazy<Assembler>(() => new Assembler(new()));
    public static Assembler Instance { get { return lazy.Value; } }
}

class ExceptionErrorListener : BaseErrorListener
{
    public ExceptionErrorListener() { }

    public bool HasErrors { get; private set; } = false;

    public override void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
    {
        HasErrors = true;
        Console.WriteLine("SyntaxError");
    }

    public override void ReportAmbiguity(Parser recognizer, DFA dfa, int startIndex, int stopIndex, bool exact, BitSet ambigAlts, ATNConfigSet configs)
    {
        HasErrors = true;
        Console.WriteLine("ReportAmbiguity");
    }

    public override void ReportAttemptingFullContext(Parser recognizer, DFA dfa, int startIndex, int stopIndex, BitSet conflictingAlts, SimulatorState conflictState)
    {
        Console.WriteLine("ReportAttemptingFullContext");
    }

    public override void ReportContextSensitivity(Parser recognizer, DFA dfa, int startIndex, int stopIndex, int prediction, SimulatorState acceptState)
    {
        Console.WriteLine("ReportContextSensitivity");
    }
}