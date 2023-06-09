//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.12.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from FluentAsm/antlr4/Fluent6502.g4 by ANTLR 4.12.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


namespace FluentAsm.Assembly.ASM_6502.gen;

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="Fluent6502"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.CLSCompliant(false)]
public interface IFluent6502Visitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.module"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModule([NotNull] Fluent6502.ModuleContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLine([NotNull] Fluent6502.LineContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInstruction([NotNull] Fluent6502.InstructionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.comment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComment([NotNull] Fluent6502.CommentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.label_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLabel_def([NotNull] Fluent6502.Label_defContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpr([NotNull] Fluent6502.ExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumber([NotNull] Fluent6502.NumberContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.pc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPc([NotNull] Fluent6502.PcContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.char"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitChar([NotNull] Fluent6502.CharContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLabel([NotNull] Fluent6502.LabelContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDirective([NotNull] Fluent6502.DirectiveContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.dirWord"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDirWord([NotNull] Fluent6502.DirWordContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.dirAlign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDirAlign([NotNull] Fluent6502.DirAlignContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.dirAscii"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDirAscii([NotNull] Fluent6502.DirAsciiContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.dirAssert"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDirAssert([NotNull] Fluent6502.DirAssertContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.dirBank"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDirBank([NotNull] Fluent6502.DirBankContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.dirBytes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDirBytes([NotNull] Fluent6502.DirBytesContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.dirBankbyte"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDirBankbyte([NotNull] Fluent6502.DirBankbyteContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.opUnary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpUnary([NotNull] Fluent6502.OpUnaryContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.opBinary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpBinary([NotNull] Fluent6502.OpBinaryContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.opGoto"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpGoto([NotNull] Fluent6502.OpGotoContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperation([NotNull] Fluent6502.OperationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.opImp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpImp([NotNull] Fluent6502.OpImpContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.opAcc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpAcc([NotNull] Fluent6502.OpAccContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.opImm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpImm([NotNull] Fluent6502.OpImmContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.opRel"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpRel([NotNull] Fluent6502.OpRelContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.opZab"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpZab([NotNull] Fluent6502.OpZabContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.opZax"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpZax([NotNull] Fluent6502.OpZaxContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.opZay"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpZay([NotNull] Fluent6502.OpZayContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.opInd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpInd([NotNull] Fluent6502.OpIndContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.opInx"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpInx([NotNull] Fluent6502.OpInxContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.opIny"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpIny([NotNull] Fluent6502.OpInyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.opcodeImplied"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpcodeImplied([NotNull] Fluent6502.OpcodeImpliedContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.opcodeAccumlator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpcodeAccumlator([NotNull] Fluent6502.OpcodeAccumlatorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.opcodeImmediate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpcodeImmediate([NotNull] Fluent6502.OpcodeImmediateContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.opcodeRelative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpcodeRelative([NotNull] Fluent6502.OpcodeRelativeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.opcodeZpAbs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpcodeZpAbs([NotNull] Fluent6502.OpcodeZpAbsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.opcodeZpAbsX"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpcodeZpAbsX([NotNull] Fluent6502.OpcodeZpAbsXContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.opcodeZpAbsY"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpcodeZpAbsY([NotNull] Fluent6502.OpcodeZpAbsYContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.opcodeIndirect"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpcodeIndirect([NotNull] Fluent6502.OpcodeIndirectContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.opcodeIndirectX"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpcodeIndirectX([NotNull] Fluent6502.OpcodeIndirectXContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Fluent6502.opcodeIndirectY"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpcodeIndirectY([NotNull] Fluent6502.OpcodeIndirectYContext context);
}
