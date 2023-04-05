//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.12.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from FluentLexer.g4 by ANTLR 4.12.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.CLSCompliant(false)]
public partial class FluentLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		A=1, X=2, Y=3, ADC=4, AND=5, ASL=6, BCC=7, BCS=8, BEQ=9, BIT=10, BMI=11, 
		BNE=12, BPL=13, BRA=14, BRK=15, BVC=16, BVS=17, CLC=18, CLD=19, CLI=20, 
		CLV=21, CMP=22, CPX=23, CPY=24, DEC=25, DEX=26, DEY=27, EOR=28, INC=29, 
		INX=30, INY=31, JMP=32, JSR=33, LDA=34, LDY=35, LDX=36, LSR=37, NOP=38, 
		ORA=39, PHA=40, PHP=41, PLA=42, PLP=43, ROL=44, ROR=45, RTI=46, RTS=47, 
		SBC=48, SEC=49, SED=50, SEI=51, STA=52, STX=53, STY=54, TAX=55, TAY=56, 
		TSX=57, TXA=58, TXS=59, TYA=60, POUND=61, COLON=62, COMMA=63, LPAREN=64, 
		RPAREN=65, PLUS=66, MINUS=67, LT=68, GT=69, CARET=70, TILDE=71, EXCLM=72, 
		STAR=73, SLASH=74, AMP=75, PIPE=76, LSHFT=77, RSHFT=78, AT=79, WORD=80, 
		ALIGN=81, ASCII=82, ASSERT=83, BANK=84, BANKBYTES=85, BYTES=86, CHARMAP=87, 
		DBYTE=88, DWORD=89, HIBYTES=90, LOBYTES=91, DEFINE=92, IF=93, IFDEF=94, 
		ELIF=95, ELSE=96, ENDIF=97, DefSYMBOL=98, DefLPAREN=99, DefRPAREN=100, 
		DefCOMMA=101, DefTEXT=102, DefEOL=103, DirTEXT=104, DirEOL=105, DirWS=106, 
		STRING=107, CHAR=108, SYMBOL=109, INT=110, HEX=111, BINARY=112, MULTI_COMMENT=113, 
		COMMENT=114, WS=115;
	public const int
		DEFINETEXT=1, DIRECTIVE=2;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE", "DEFINETEXT", "DIRECTIVE"
	};

	public static readonly string[] ruleNames = {
		"A", "X", "Y", "ADC", "AND", "ASL", "BCC", "BCS", "BEQ", "BIT", "BMI", 
		"BNE", "BPL", "BRA", "BRK", "BVC", "BVS", "CLC", "CLD", "CLI", "CLV", 
		"CMP", "CPX", "CPY", "DEC", "DEX", "DEY", "EOR", "INC", "INX", "INY", 
		"JMP", "JSR", "LDA", "LDY", "LDX", "LSR", "NOP", "ORA", "PHA", "PHP", 
		"PLA", "PLP", "ROL", "ROR", "RTI", "RTS", "SBC", "SEC", "SED", "SEI", 
		"STA", "STX", "STY", "TAX", "TAY", "TSX", "TXA", "TXS", "TYA", "POUND", 
		"COLON", "COMMA", "LPAREN", "RPAREN", "PLUS", "MINUS", "LT", "GT", "CARET", 
		"TILDE", "EXCLM", "STAR", "SLASH", "AMP", "PIPE", "LSHFT", "RSHFT", "AT", 
		"WORD", "ALIGN", "ASCII", "ASSERT", "BANK", "BANKBYTES", "BYTES", "CHARMAP", 
		"DBYTE", "DWORD", "HIBYTES", "LOBYTES", "DEFINE", "IF", "IFDEF", "ELIF", 
		"ELSE", "ENDIF", "DefSYMBOL", "DefLPAREN", "DefRPAREN", "DefCOMMA", "DefTEXT", 
		"DefEOL", "DirTEXT", "DirEOL", "DirWS", "STRING", "CHAR", "SYMBOL", "INT", 
		"HEX", "BINARY", "MULTI_COMMENT", "COMMENT", "WS", "Digit", "HexDigit", 
		"BinaryDigit", "NotLineEnd", "EOL"
	};


	public FluentLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public FluentLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'a'", "'x'", "'y'", "'adc'", "'and'", "'asl'", "'bcc'", "'bcs'", 
		"'beq'", "'bit'", "'bmi'", "'bne'", "'bpl'", "'bra'", "'brk'", "'bvc'", 
		"'bvs'", "'clc'", "'cld'", "'cli'", "'clv'", "'cmp'", "'cpx'", "'cpy'", 
		"'dec'", "'dex'", "'dey'", "'eor'", "'inc'", "'inx'", "'iny'", "'jmp'", 
		"'jsr'", "'lda'", "'ldy'", "'ldx'", "'lsr'", "'nop'", "'ora'", "'pha'", 
		"'php'", "'pla'", "'plp'", "'rol'", "'ror'", "'rti'", "'rts'", "'sbc'", 
		"'sec'", "'sed'", "'sei'", "'sta'", "'stx'", "'sty'", "'tax'", "'tay'", 
		"'tsx'", "'txa'", "'txs'", "'tya'", "'#'", "':'", null, null, null, "'+'", 
		"'-'", "'<'", "'>'", "'^'", "'~'", "'!'", "'*'", "'/'", "'&'", "'|'", 
		"'<<'", "'>>'", "'@'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "A", "X", "Y", "ADC", "AND", "ASL", "BCC", "BCS", "BEQ", "BIT", 
		"BMI", "BNE", "BPL", "BRA", "BRK", "BVC", "BVS", "CLC", "CLD", "CLI", 
		"CLV", "CMP", "CPX", "CPY", "DEC", "DEX", "DEY", "EOR", "INC", "INX", 
		"INY", "JMP", "JSR", "LDA", "LDY", "LDX", "LSR", "NOP", "ORA", "PHA", 
		"PHP", "PLA", "PLP", "ROL", "ROR", "RTI", "RTS", "SBC", "SEC", "SED", 
		"SEI", "STA", "STX", "STY", "TAX", "TAY", "TSX", "TXA", "TXS", "TYA", 
		"POUND", "COLON", "COMMA", "LPAREN", "RPAREN", "PLUS", "MINUS", "LT", 
		"GT", "CARET", "TILDE", "EXCLM", "STAR", "SLASH", "AMP", "PIPE", "LSHFT", 
		"RSHFT", "AT", "WORD", "ALIGN", "ASCII", "ASSERT", "BANK", "BANKBYTES", 
		"BYTES", "CHARMAP", "DBYTE", "DWORD", "HIBYTES", "LOBYTES", "DEFINE", 
		"IF", "IFDEF", "ELIF", "ELSE", "ENDIF", "DefSYMBOL", "DefLPAREN", "DefRPAREN", 
		"DefCOMMA", "DefTEXT", "DefEOL", "DirTEXT", "DirEOL", "DirWS", "STRING", 
		"CHAR", "SYMBOL", "INT", "HEX", "BINARY", "MULTI_COMMENT", "COMMENT", 
		"WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "FluentLexer.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static FluentLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,115,840,6,-1,6,-1,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,
		7,5,2,6,7,6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,
		7,13,2,14,7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,
		7,20,2,21,7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,
		7,27,2,28,7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,
		7,34,2,35,7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,
		7,41,2,42,7,42,2,43,7,43,2,44,7,44,2,45,7,45,2,46,7,46,2,47,7,47,2,48,
		7,48,2,49,7,49,2,50,7,50,2,51,7,51,2,52,7,52,2,53,7,53,2,54,7,54,2,55,
		7,55,2,56,7,56,2,57,7,57,2,58,7,58,2,59,7,59,2,60,7,60,2,61,7,61,2,62,
		7,62,2,63,7,63,2,64,7,64,2,65,7,65,2,66,7,66,2,67,7,67,2,68,7,68,2,69,
		7,69,2,70,7,70,2,71,7,71,2,72,7,72,2,73,7,73,2,74,7,74,2,75,7,75,2,76,
		7,76,2,77,7,77,2,78,7,78,2,79,7,79,2,80,7,80,2,81,7,81,2,82,7,82,2,83,
		7,83,2,84,7,84,2,85,7,85,2,86,7,86,2,87,7,87,2,88,7,88,2,89,7,89,2,90,
		7,90,2,91,7,91,2,92,7,92,2,93,7,93,2,94,7,94,2,95,7,95,2,96,7,96,2,97,
		7,97,2,98,7,98,2,99,7,99,2,100,7,100,2,101,7,101,2,102,7,102,2,103,7,103,
		2,104,7,104,2,105,7,105,2,106,7,106,2,107,7,107,2,108,7,108,2,109,7,109,
		2,110,7,110,2,111,7,111,2,112,7,112,2,113,7,113,2,114,7,114,2,115,7,115,
		2,116,7,116,2,117,7,117,2,118,7,118,2,119,7,119,1,0,1,0,1,1,1,1,1,2,1,
		2,1,3,1,3,1,3,1,3,1,4,1,4,1,4,1,4,1,5,1,5,1,5,1,5,1,6,1,6,1,6,1,6,1,7,
		1,7,1,7,1,7,1,8,1,8,1,8,1,8,1,9,1,9,1,9,1,9,1,10,1,10,1,10,1,10,1,11,1,
		11,1,11,1,11,1,12,1,12,1,12,1,12,1,13,1,13,1,13,1,13,1,14,1,14,1,14,1,
		14,1,15,1,15,1,15,1,15,1,16,1,16,1,16,1,16,1,17,1,17,1,17,1,17,1,18,1,
		18,1,18,1,18,1,19,1,19,1,19,1,19,1,20,1,20,1,20,1,20,1,21,1,21,1,21,1,
		21,1,22,1,22,1,22,1,22,1,23,1,23,1,23,1,23,1,24,1,24,1,24,1,24,1,25,1,
		25,1,25,1,25,1,26,1,26,1,26,1,26,1,27,1,27,1,27,1,27,1,28,1,28,1,28,1,
		28,1,29,1,29,1,29,1,29,1,30,1,30,1,30,1,30,1,31,1,31,1,31,1,31,1,32,1,
		32,1,32,1,32,1,33,1,33,1,33,1,33,1,34,1,34,1,34,1,34,1,35,1,35,1,35,1,
		35,1,36,1,36,1,36,1,36,1,37,1,37,1,37,1,37,1,38,1,38,1,38,1,38,1,39,1,
		39,1,39,1,39,1,40,1,40,1,40,1,40,1,41,1,41,1,41,1,41,1,42,1,42,1,42,1,
		42,1,43,1,43,1,43,1,43,1,44,1,44,1,44,1,44,1,45,1,45,1,45,1,45,1,46,1,
		46,1,46,1,46,1,47,1,47,1,47,1,47,1,48,1,48,1,48,1,48,1,49,1,49,1,49,1,
		49,1,50,1,50,1,50,1,50,1,51,1,51,1,51,1,51,1,52,1,52,1,52,1,52,1,53,1,
		53,1,53,1,53,1,54,1,54,1,54,1,54,1,55,1,55,1,55,1,55,1,56,1,56,1,56,1,
		56,1,57,1,57,1,57,1,57,1,58,1,58,1,58,1,58,1,59,1,59,1,59,1,59,1,60,1,
		60,1,61,1,61,1,62,1,62,1,63,1,63,1,64,1,64,1,65,1,65,1,66,1,66,1,67,1,
		67,1,68,1,68,1,69,1,69,1,70,1,70,1,71,1,71,1,72,1,72,1,73,1,73,1,74,1,
		74,1,75,1,75,1,76,1,76,1,76,1,77,1,77,1,77,1,78,1,78,1,79,3,79,519,8,79,
		1,79,1,79,1,79,1,79,1,79,1,79,1,79,1,79,1,79,1,79,3,79,531,8,79,1,80,3,
		80,534,8,80,1,80,1,80,1,80,1,80,1,80,1,80,1,81,3,81,543,8,81,1,81,1,81,
		1,81,1,81,1,81,1,81,1,82,3,82,552,8,82,1,82,1,82,1,82,1,82,1,82,1,82,1,
		82,1,83,3,83,562,8,83,1,83,1,83,1,83,1,83,1,83,1,84,3,84,570,8,84,1,84,
		1,84,1,84,1,84,1,84,1,84,1,84,1,84,1,84,1,84,1,84,3,84,583,8,84,1,85,3,
		85,586,8,85,1,85,1,85,1,85,1,85,1,85,1,85,1,85,1,85,1,85,3,85,597,8,85,
		1,86,3,86,600,8,86,1,86,1,86,1,86,1,86,1,86,1,86,1,86,1,86,1,87,3,87,611,
		8,87,1,87,1,87,1,87,1,87,1,87,1,87,1,87,1,87,1,87,3,87,622,8,87,1,88,3,
		88,625,8,88,1,88,1,88,1,88,1,88,1,88,1,88,1,89,3,89,634,8,89,1,89,1,89,
		1,89,1,89,1,89,1,89,1,89,1,89,1,89,3,89,645,8,89,1,90,3,90,648,8,90,1,
		90,1,90,1,90,1,90,1,90,1,90,1,90,1,90,1,90,3,90,659,8,90,1,91,3,91,662,
		8,91,1,91,1,91,1,91,1,91,1,91,1,91,1,91,1,91,1,91,1,92,3,92,674,8,92,1,
		92,1,92,1,92,1,93,3,93,680,8,93,1,93,1,93,1,93,1,93,1,93,1,93,1,94,3,94,
		689,8,94,1,94,1,94,1,94,1,94,1,94,1,94,1,94,1,94,1,94,1,94,3,94,701,8,
		94,1,95,3,95,704,8,95,1,95,1,95,1,95,1,95,1,95,1,96,3,96,712,8,96,1,96,
		1,96,1,96,1,96,1,96,1,96,1,97,1,97,5,97,722,8,97,10,97,12,97,725,9,97,
		1,98,1,98,1,99,1,99,1,100,1,100,1,101,4,101,734,8,101,11,101,12,101,735,
		1,101,1,101,1,102,1,102,1,102,1,102,1,103,4,103,745,8,103,11,103,12,103,
		746,1,104,1,104,1,104,1,104,1,105,4,105,754,8,105,11,105,12,105,755,1,
		105,1,105,1,106,1,106,5,106,762,8,106,10,106,12,106,765,9,106,1,106,1,
		106,1,107,1,107,1,107,1,107,1,108,1,108,5,108,775,8,108,10,108,12,108,
		778,9,108,1,109,4,109,781,8,109,11,109,12,109,782,1,110,1,110,4,110,787,
		8,110,11,110,12,110,788,1,111,1,111,4,111,793,8,111,11,111,12,111,794,
		1,112,1,112,1,112,1,112,5,112,801,8,112,10,112,12,112,804,9,112,1,112,
		1,112,1,112,1,112,1,112,1,113,1,113,1,113,3,113,814,8,113,1,113,5,113,
		817,8,113,10,113,12,113,820,9,113,1,113,1,113,1,114,4,114,825,8,114,11,
		114,12,114,826,1,114,1,114,1,115,1,115,1,116,1,116,1,117,1,117,1,118,1,
		118,1,119,1,119,2,735,802,0,120,3,1,5,2,7,3,9,4,11,5,13,6,15,7,17,8,19,
		9,21,10,23,11,25,12,27,13,29,14,31,15,33,16,35,17,37,18,39,19,41,20,43,
		21,45,22,47,23,49,24,51,25,53,26,55,27,57,28,59,29,61,30,63,31,65,32,67,
		33,69,34,71,35,73,36,75,37,77,38,79,39,81,40,83,41,85,42,87,43,89,44,91,
		45,93,46,95,47,97,48,99,49,101,50,103,51,105,52,107,53,109,54,111,55,113,
		56,115,57,117,58,119,59,121,60,123,61,125,62,127,63,129,64,131,65,133,
		66,135,67,137,68,139,69,141,70,143,71,145,72,147,73,149,74,151,75,153,
		76,155,77,157,78,159,79,161,80,163,81,165,82,167,83,169,84,171,85,173,
		86,175,87,177,88,179,89,181,90,183,91,185,92,187,93,189,94,191,95,193,
		96,195,97,197,98,199,99,201,100,203,101,205,102,207,103,209,104,211,105,
		213,106,215,107,217,108,219,109,221,110,223,111,225,112,227,113,229,114,
		231,115,233,0,235,0,237,0,239,0,241,0,3,0,1,2,33,2,0,65,65,97,97,2,0,88,
		88,120,120,2,0,89,89,121,121,2,0,68,68,100,100,2,0,67,67,99,99,2,0,78,
		78,110,110,2,0,83,83,115,115,2,0,76,76,108,108,2,0,66,66,98,98,2,0,69,
		69,101,101,2,0,81,81,113,113,2,0,73,73,105,105,2,0,84,84,116,116,2,0,77,
		77,109,109,2,0,80,80,112,112,2,0,82,82,114,114,2,0,75,75,107,107,2,0,86,
		86,118,118,2,0,79,79,111,111,2,0,74,74,106,106,2,0,72,72,104,104,2,0,87,
		87,119,119,2,0,71,71,103,103,2,0,70,70,102,102,3,0,65,90,95,95,97,122,
		4,0,48,57,65,90,95,95,97,122,5,0,45,45,48,57,65,90,95,95,97,122,1,0,34,
		34,1,0,39,39,3,0,9,10,12,13,32,32,1,0,48,57,3,0,48,57,65,70,97,102,4,0,
		10,10,13,13,133,133,8232,8233,872,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,
		0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,
		0,0,0,0,21,1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,
		0,31,1,0,0,0,0,33,1,0,0,0,0,35,1,0,0,0,0,37,1,0,0,0,0,39,1,0,0,0,0,41,
		1,0,0,0,0,43,1,0,0,0,0,45,1,0,0,0,0,47,1,0,0,0,0,49,1,0,0,0,0,51,1,0,0,
		0,0,53,1,0,0,0,0,55,1,0,0,0,0,57,1,0,0,0,0,59,1,0,0,0,0,61,1,0,0,0,0,63,
		1,0,0,0,0,65,1,0,0,0,0,67,1,0,0,0,0,69,1,0,0,0,0,71,1,0,0,0,0,73,1,0,0,
		0,0,75,1,0,0,0,0,77,1,0,0,0,0,79,1,0,0,0,0,81,1,0,0,0,0,83,1,0,0,0,0,85,
		1,0,0,0,0,87,1,0,0,0,0,89,1,0,0,0,0,91,1,0,0,0,0,93,1,0,0,0,0,95,1,0,0,
		0,0,97,1,0,0,0,0,99,1,0,0,0,0,101,1,0,0,0,0,103,1,0,0,0,0,105,1,0,0,0,
		0,107,1,0,0,0,0,109,1,0,0,0,0,111,1,0,0,0,0,113,1,0,0,0,0,115,1,0,0,0,
		0,117,1,0,0,0,0,119,1,0,0,0,0,121,1,0,0,0,0,123,1,0,0,0,0,125,1,0,0,0,
		0,127,1,0,0,0,0,129,1,0,0,0,0,131,1,0,0,0,0,133,1,0,0,0,0,135,1,0,0,0,
		0,137,1,0,0,0,0,139,1,0,0,0,0,141,1,0,0,0,0,143,1,0,0,0,0,145,1,0,0,0,
		0,147,1,0,0,0,0,149,1,0,0,0,0,151,1,0,0,0,0,153,1,0,0,0,0,155,1,0,0,0,
		0,157,1,0,0,0,0,159,1,0,0,0,0,161,1,0,0,0,0,163,1,0,0,0,0,165,1,0,0,0,
		0,167,1,0,0,0,0,169,1,0,0,0,0,171,1,0,0,0,0,173,1,0,0,0,0,175,1,0,0,0,
		0,177,1,0,0,0,0,179,1,0,0,0,0,181,1,0,0,0,0,183,1,0,0,0,0,185,1,0,0,0,
		0,187,1,0,0,0,0,189,1,0,0,0,0,191,1,0,0,0,0,193,1,0,0,0,0,195,1,0,0,0,
		0,215,1,0,0,0,0,217,1,0,0,0,0,219,1,0,0,0,0,221,1,0,0,0,0,223,1,0,0,0,
		0,225,1,0,0,0,0,227,1,0,0,0,0,229,1,0,0,0,0,231,1,0,0,0,1,197,1,0,0,0,
		1,199,1,0,0,0,1,201,1,0,0,0,1,203,1,0,0,0,1,205,1,0,0,0,1,207,1,0,0,0,
		2,209,1,0,0,0,2,211,1,0,0,0,2,213,1,0,0,0,3,243,1,0,0,0,5,245,1,0,0,0,
		7,247,1,0,0,0,9,249,1,0,0,0,11,253,1,0,0,0,13,257,1,0,0,0,15,261,1,0,0,
		0,17,265,1,0,0,0,19,269,1,0,0,0,21,273,1,0,0,0,23,277,1,0,0,0,25,281,1,
		0,0,0,27,285,1,0,0,0,29,289,1,0,0,0,31,293,1,0,0,0,33,297,1,0,0,0,35,301,
		1,0,0,0,37,305,1,0,0,0,39,309,1,0,0,0,41,313,1,0,0,0,43,317,1,0,0,0,45,
		321,1,0,0,0,47,325,1,0,0,0,49,329,1,0,0,0,51,333,1,0,0,0,53,337,1,0,0,
		0,55,341,1,0,0,0,57,345,1,0,0,0,59,349,1,0,0,0,61,353,1,0,0,0,63,357,1,
		0,0,0,65,361,1,0,0,0,67,365,1,0,0,0,69,369,1,0,0,0,71,373,1,0,0,0,73,377,
		1,0,0,0,75,381,1,0,0,0,77,385,1,0,0,0,79,389,1,0,0,0,81,393,1,0,0,0,83,
		397,1,0,0,0,85,401,1,0,0,0,87,405,1,0,0,0,89,409,1,0,0,0,91,413,1,0,0,
		0,93,417,1,0,0,0,95,421,1,0,0,0,97,425,1,0,0,0,99,429,1,0,0,0,101,433,
		1,0,0,0,103,437,1,0,0,0,105,441,1,0,0,0,107,445,1,0,0,0,109,449,1,0,0,
		0,111,453,1,0,0,0,113,457,1,0,0,0,115,461,1,0,0,0,117,465,1,0,0,0,119,
		469,1,0,0,0,121,473,1,0,0,0,123,477,1,0,0,0,125,479,1,0,0,0,127,481,1,
		0,0,0,129,483,1,0,0,0,131,485,1,0,0,0,133,487,1,0,0,0,135,489,1,0,0,0,
		137,491,1,0,0,0,139,493,1,0,0,0,141,495,1,0,0,0,143,497,1,0,0,0,145,499,
		1,0,0,0,147,501,1,0,0,0,149,503,1,0,0,0,151,505,1,0,0,0,153,507,1,0,0,
		0,155,509,1,0,0,0,157,512,1,0,0,0,159,515,1,0,0,0,161,518,1,0,0,0,163,
		533,1,0,0,0,165,542,1,0,0,0,167,551,1,0,0,0,169,561,1,0,0,0,171,569,1,
		0,0,0,173,585,1,0,0,0,175,599,1,0,0,0,177,610,1,0,0,0,179,624,1,0,0,0,
		181,633,1,0,0,0,183,647,1,0,0,0,185,661,1,0,0,0,187,673,1,0,0,0,189,679,
		1,0,0,0,191,688,1,0,0,0,193,703,1,0,0,0,195,711,1,0,0,0,197,719,1,0,0,
		0,199,726,1,0,0,0,201,728,1,0,0,0,203,730,1,0,0,0,205,733,1,0,0,0,207,
		739,1,0,0,0,209,744,1,0,0,0,211,748,1,0,0,0,213,753,1,0,0,0,215,759,1,
		0,0,0,217,768,1,0,0,0,219,772,1,0,0,0,221,780,1,0,0,0,223,784,1,0,0,0,
		225,790,1,0,0,0,227,796,1,0,0,0,229,813,1,0,0,0,231,824,1,0,0,0,233,830,
		1,0,0,0,235,832,1,0,0,0,237,834,1,0,0,0,239,836,1,0,0,0,241,838,1,0,0,
		0,243,244,7,0,0,0,244,4,1,0,0,0,245,246,7,1,0,0,246,6,1,0,0,0,247,248,
		7,2,0,0,248,8,1,0,0,0,249,250,7,0,0,0,250,251,7,3,0,0,251,252,7,4,0,0,
		252,10,1,0,0,0,253,254,7,0,0,0,254,255,7,5,0,0,255,256,7,3,0,0,256,12,
		1,0,0,0,257,258,7,0,0,0,258,259,7,6,0,0,259,260,7,7,0,0,260,14,1,0,0,0,
		261,262,7,8,0,0,262,263,7,4,0,0,263,264,7,4,0,0,264,16,1,0,0,0,265,266,
		7,8,0,0,266,267,7,4,0,0,267,268,7,6,0,0,268,18,1,0,0,0,269,270,7,8,0,0,
		270,271,7,9,0,0,271,272,7,10,0,0,272,20,1,0,0,0,273,274,7,8,0,0,274,275,
		7,11,0,0,275,276,7,12,0,0,276,22,1,0,0,0,277,278,7,8,0,0,278,279,7,13,
		0,0,279,280,7,11,0,0,280,24,1,0,0,0,281,282,7,8,0,0,282,283,7,5,0,0,283,
		284,7,9,0,0,284,26,1,0,0,0,285,286,7,8,0,0,286,287,7,14,0,0,287,288,7,
		7,0,0,288,28,1,0,0,0,289,290,7,8,0,0,290,291,7,15,0,0,291,292,7,0,0,0,
		292,30,1,0,0,0,293,294,7,8,0,0,294,295,7,15,0,0,295,296,7,16,0,0,296,32,
		1,0,0,0,297,298,7,8,0,0,298,299,7,17,0,0,299,300,7,4,0,0,300,34,1,0,0,
		0,301,302,7,8,0,0,302,303,7,17,0,0,303,304,7,6,0,0,304,36,1,0,0,0,305,
		306,7,4,0,0,306,307,7,7,0,0,307,308,7,4,0,0,308,38,1,0,0,0,309,310,7,4,
		0,0,310,311,7,7,0,0,311,312,7,3,0,0,312,40,1,0,0,0,313,314,7,4,0,0,314,
		315,7,7,0,0,315,316,7,11,0,0,316,42,1,0,0,0,317,318,7,4,0,0,318,319,7,
		7,0,0,319,320,7,17,0,0,320,44,1,0,0,0,321,322,7,4,0,0,322,323,7,13,0,0,
		323,324,7,14,0,0,324,46,1,0,0,0,325,326,7,4,0,0,326,327,7,14,0,0,327,328,
		7,1,0,0,328,48,1,0,0,0,329,330,7,4,0,0,330,331,7,14,0,0,331,332,7,2,0,
		0,332,50,1,0,0,0,333,334,7,3,0,0,334,335,7,9,0,0,335,336,7,4,0,0,336,52,
		1,0,0,0,337,338,7,3,0,0,338,339,7,9,0,0,339,340,7,1,0,0,340,54,1,0,0,0,
		341,342,7,3,0,0,342,343,7,9,0,0,343,344,7,2,0,0,344,56,1,0,0,0,345,346,
		7,9,0,0,346,347,7,18,0,0,347,348,7,15,0,0,348,58,1,0,0,0,349,350,7,11,
		0,0,350,351,7,5,0,0,351,352,7,4,0,0,352,60,1,0,0,0,353,354,7,11,0,0,354,
		355,7,5,0,0,355,356,7,1,0,0,356,62,1,0,0,0,357,358,7,11,0,0,358,359,7,
		5,0,0,359,360,7,2,0,0,360,64,1,0,0,0,361,362,7,19,0,0,362,363,7,13,0,0,
		363,364,7,14,0,0,364,66,1,0,0,0,365,366,7,19,0,0,366,367,7,6,0,0,367,368,
		7,15,0,0,368,68,1,0,0,0,369,370,7,7,0,0,370,371,7,3,0,0,371,372,7,0,0,
		0,372,70,1,0,0,0,373,374,7,7,0,0,374,375,7,3,0,0,375,376,7,2,0,0,376,72,
		1,0,0,0,377,378,7,7,0,0,378,379,7,3,0,0,379,380,7,1,0,0,380,74,1,0,0,0,
		381,382,7,7,0,0,382,383,7,6,0,0,383,384,7,15,0,0,384,76,1,0,0,0,385,386,
		7,5,0,0,386,387,7,18,0,0,387,388,7,14,0,0,388,78,1,0,0,0,389,390,7,18,
		0,0,390,391,7,15,0,0,391,392,7,0,0,0,392,80,1,0,0,0,393,394,7,14,0,0,394,
		395,7,20,0,0,395,396,7,0,0,0,396,82,1,0,0,0,397,398,7,14,0,0,398,399,7,
		20,0,0,399,400,7,14,0,0,400,84,1,0,0,0,401,402,7,14,0,0,402,403,7,7,0,
		0,403,404,7,0,0,0,404,86,1,0,0,0,405,406,7,14,0,0,406,407,7,7,0,0,407,
		408,7,14,0,0,408,88,1,0,0,0,409,410,7,15,0,0,410,411,7,18,0,0,411,412,
		7,7,0,0,412,90,1,0,0,0,413,414,7,15,0,0,414,415,7,18,0,0,415,416,7,15,
		0,0,416,92,1,0,0,0,417,418,7,15,0,0,418,419,7,12,0,0,419,420,7,11,0,0,
		420,94,1,0,0,0,421,422,7,15,0,0,422,423,7,12,0,0,423,424,7,6,0,0,424,96,
		1,0,0,0,425,426,7,6,0,0,426,427,7,8,0,0,427,428,7,4,0,0,428,98,1,0,0,0,
		429,430,7,6,0,0,430,431,7,9,0,0,431,432,7,4,0,0,432,100,1,0,0,0,433,434,
		7,6,0,0,434,435,7,9,0,0,435,436,7,3,0,0,436,102,1,0,0,0,437,438,7,6,0,
		0,438,439,7,9,0,0,439,440,7,11,0,0,440,104,1,0,0,0,441,442,7,6,0,0,442,
		443,7,12,0,0,443,444,7,0,0,0,444,106,1,0,0,0,445,446,7,6,0,0,446,447,7,
		12,0,0,447,448,7,1,0,0,448,108,1,0,0,0,449,450,7,6,0,0,450,451,7,12,0,
		0,451,452,7,2,0,0,452,110,1,0,0,0,453,454,7,12,0,0,454,455,7,0,0,0,455,
		456,7,1,0,0,456,112,1,0,0,0,457,458,7,12,0,0,458,459,7,0,0,0,459,460,7,
		2,0,0,460,114,1,0,0,0,461,462,7,12,0,0,462,463,7,6,0,0,463,464,7,1,0,0,
		464,116,1,0,0,0,465,466,7,12,0,0,466,467,7,1,0,0,467,468,7,0,0,0,468,118,
		1,0,0,0,469,470,7,12,0,0,470,471,7,1,0,0,471,472,7,6,0,0,472,120,1,0,0,
		0,473,474,7,12,0,0,474,475,7,2,0,0,475,476,7,0,0,0,476,122,1,0,0,0,477,
		478,5,35,0,0,478,124,1,0,0,0,479,480,5,58,0,0,480,126,1,0,0,0,481,482,
		5,44,0,0,482,128,1,0,0,0,483,484,5,40,0,0,484,130,1,0,0,0,485,486,5,41,
		0,0,486,132,1,0,0,0,487,488,5,43,0,0,488,134,1,0,0,0,489,490,5,45,0,0,
		490,136,1,0,0,0,491,492,5,60,0,0,492,138,1,0,0,0,493,494,5,62,0,0,494,
		140,1,0,0,0,495,496,5,94,0,0,496,142,1,0,0,0,497,498,5,126,0,0,498,144,
		1,0,0,0,499,500,5,33,0,0,500,146,1,0,0,0,501,502,5,42,0,0,502,148,1,0,
		0,0,503,504,5,47,0,0,504,150,1,0,0,0,505,506,5,38,0,0,506,152,1,0,0,0,
		507,508,5,124,0,0,508,154,1,0,0,0,509,510,5,60,0,0,510,511,5,60,0,0,511,
		156,1,0,0,0,512,513,5,62,0,0,513,514,5,62,0,0,514,158,1,0,0,0,515,516,
		5,64,0,0,516,160,1,0,0,0,517,519,5,46,0,0,518,517,1,0,0,0,518,519,1,0,
		0,0,519,530,1,0,0,0,520,521,7,0,0,0,521,522,7,3,0,0,522,523,7,3,0,0,523,
		531,7,15,0,0,524,525,7,3,0,0,525,531,7,21,0,0,526,527,7,21,0,0,527,528,
		7,18,0,0,528,529,7,15,0,0,529,531,7,3,0,0,530,520,1,0,0,0,530,524,1,0,
		0,0,530,526,1,0,0,0,531,162,1,0,0,0,532,534,5,46,0,0,533,532,1,0,0,0,533,
		534,1,0,0,0,534,535,1,0,0,0,535,536,7,0,0,0,536,537,7,7,0,0,537,538,7,
		11,0,0,538,539,7,22,0,0,539,540,7,5,0,0,540,164,1,0,0,0,541,543,5,46,0,
		0,542,541,1,0,0,0,542,543,1,0,0,0,543,544,1,0,0,0,544,545,7,0,0,0,545,
		546,7,6,0,0,546,547,7,4,0,0,547,548,7,11,0,0,548,549,7,11,0,0,549,166,
		1,0,0,0,550,552,5,46,0,0,551,550,1,0,0,0,551,552,1,0,0,0,552,553,1,0,0,
		0,553,554,7,0,0,0,554,555,7,6,0,0,555,556,7,6,0,0,556,557,7,9,0,0,557,
		558,7,15,0,0,558,559,7,12,0,0,559,168,1,0,0,0,560,562,5,46,0,0,561,560,
		1,0,0,0,561,562,1,0,0,0,562,563,1,0,0,0,563,564,7,8,0,0,564,565,7,0,0,
		0,565,566,7,5,0,0,566,567,7,16,0,0,567,170,1,0,0,0,568,570,5,46,0,0,569,
		568,1,0,0,0,569,570,1,0,0,0,570,582,1,0,0,0,571,572,7,8,0,0,572,573,7,
		0,0,0,573,574,7,5,0,0,574,575,7,16,0,0,575,576,7,8,0,0,576,577,7,2,0,0,
		577,578,7,12,0,0,578,579,7,9,0,0,579,583,7,6,0,0,580,581,7,3,0,0,581,583,
		7,16,0,0,582,571,1,0,0,0,582,580,1,0,0,0,583,172,1,0,0,0,584,586,5,46,
		0,0,585,584,1,0,0,0,585,586,1,0,0,0,586,596,1,0,0,0,587,588,7,8,0,0,588,
		589,7,2,0,0,589,590,7,12,0,0,590,597,7,9,0,0,591,592,7,8,0,0,592,593,7,
		2,0,0,593,597,7,12,0,0,594,595,7,3,0,0,595,597,7,8,0,0,596,587,1,0,0,0,
		596,591,1,0,0,0,596,594,1,0,0,0,597,174,1,0,0,0,598,600,5,46,0,0,599,598,
		1,0,0,0,599,600,1,0,0,0,600,601,1,0,0,0,601,602,7,4,0,0,602,603,7,20,0,
		0,603,604,7,0,0,0,604,605,7,15,0,0,605,606,7,13,0,0,606,607,7,0,0,0,607,
		608,7,14,0,0,608,176,1,0,0,0,609,611,5,46,0,0,610,609,1,0,0,0,610,611,
		1,0,0,0,611,621,1,0,0,0,612,613,7,3,0,0,613,614,7,8,0,0,614,615,7,2,0,
		0,615,622,7,12,0,0,616,617,7,3,0,0,617,618,7,8,0,0,618,619,7,2,0,0,619,
		620,7,12,0,0,620,622,7,9,0,0,621,612,1,0,0,0,621,616,1,0,0,0,622,178,1,
		0,0,0,623,625,5,46,0,0,624,623,1,0,0,0,624,625,1,0,0,0,625,626,1,0,0,0,
		626,627,7,3,0,0,627,628,7,21,0,0,628,629,7,18,0,0,629,630,7,15,0,0,630,
		631,7,3,0,0,631,180,1,0,0,0,632,634,5,46,0,0,633,632,1,0,0,0,633,634,1,
		0,0,0,634,644,1,0,0,0,635,636,7,20,0,0,636,637,7,11,0,0,637,638,7,8,0,
		0,638,639,7,2,0,0,639,640,7,12,0,0,640,641,7,9,0,0,641,645,7,6,0,0,642,
		643,7,3,0,0,643,645,7,20,0,0,644,635,1,0,0,0,644,642,1,0,0,0,645,182,1,
		0,0,0,646,648,5,46,0,0,647,646,1,0,0,0,647,648,1,0,0,0,648,658,1,0,0,0,
		649,650,7,7,0,0,650,651,7,18,0,0,651,652,7,8,0,0,652,653,7,2,0,0,653,654,
		7,12,0,0,654,655,7,9,0,0,655,659,7,6,0,0,656,657,7,3,0,0,657,659,7,20,
		0,0,658,649,1,0,0,0,658,656,1,0,0,0,659,184,1,0,0,0,660,662,5,46,0,0,661,
		660,1,0,0,0,661,662,1,0,0,0,662,663,1,0,0,0,663,664,7,3,0,0,664,665,7,
		9,0,0,665,666,7,23,0,0,666,667,7,11,0,0,667,668,7,5,0,0,668,669,7,9,0,
		0,669,670,1,0,0,0,670,671,6,91,0,0,671,186,1,0,0,0,672,674,5,46,0,0,673,
		672,1,0,0,0,673,674,1,0,0,0,674,675,1,0,0,0,675,676,7,11,0,0,676,677,7,
		23,0,0,677,188,1,0,0,0,678,680,5,46,0,0,679,678,1,0,0,0,679,680,1,0,0,
		0,680,681,1,0,0,0,681,682,7,11,0,0,682,683,7,23,0,0,683,684,7,3,0,0,684,
		685,7,9,0,0,685,686,7,23,0,0,686,190,1,0,0,0,687,689,5,46,0,0,688,687,
		1,0,0,0,688,689,1,0,0,0,689,700,1,0,0,0,690,691,7,9,0,0,691,692,7,7,0,
		0,692,693,7,11,0,0,693,701,7,23,0,0,694,695,7,9,0,0,695,696,7,7,0,0,696,
		697,7,6,0,0,697,698,7,9,0,0,698,699,7,11,0,0,699,701,7,23,0,0,700,690,
		1,0,0,0,700,694,1,0,0,0,701,192,1,0,0,0,702,704,5,46,0,0,703,702,1,0,0,
		0,703,704,1,0,0,0,704,705,1,0,0,0,705,706,7,9,0,0,706,707,7,7,0,0,707,
		708,7,6,0,0,708,709,7,9,0,0,709,194,1,0,0,0,710,712,5,46,0,0,711,710,1,
		0,0,0,711,712,1,0,0,0,712,713,1,0,0,0,713,714,7,9,0,0,714,715,7,5,0,0,
		715,716,7,3,0,0,716,717,7,11,0,0,717,718,7,23,0,0,718,196,1,0,0,0,719,
		723,7,24,0,0,720,722,7,25,0,0,721,720,1,0,0,0,722,725,1,0,0,0,723,721,
		1,0,0,0,723,724,1,0,0,0,724,198,1,0,0,0,725,723,1,0,0,0,726,727,5,40,0,
		0,727,200,1,0,0,0,728,729,5,41,0,0,729,202,1,0,0,0,730,731,5,44,0,0,731,
		204,1,0,0,0,732,734,9,0,0,0,733,732,1,0,0,0,734,735,1,0,0,0,735,736,1,
		0,0,0,735,733,1,0,0,0,736,737,1,0,0,0,737,738,3,241,119,0,738,206,1,0,
		0,0,739,740,3,241,119,0,740,741,1,0,0,0,741,742,6,102,1,0,742,208,1,0,
		0,0,743,745,7,26,0,0,744,743,1,0,0,0,745,746,1,0,0,0,746,744,1,0,0,0,746,
		747,1,0,0,0,747,210,1,0,0,0,748,749,3,241,119,0,749,750,1,0,0,0,750,751,
		6,104,1,0,751,212,1,0,0,0,752,754,3,231,114,0,753,752,1,0,0,0,754,755,
		1,0,0,0,755,753,1,0,0,0,755,756,1,0,0,0,756,757,1,0,0,0,757,758,6,105,
		2,0,758,214,1,0,0,0,759,763,5,34,0,0,760,762,8,27,0,0,761,760,1,0,0,0,
		762,765,1,0,0,0,763,761,1,0,0,0,763,764,1,0,0,0,764,766,1,0,0,0,765,763,
		1,0,0,0,766,767,5,34,0,0,767,216,1,0,0,0,768,769,5,39,0,0,769,770,8,28,
		0,0,770,771,5,39,0,0,771,218,1,0,0,0,772,776,7,24,0,0,773,775,7,25,0,0,
		774,773,1,0,0,0,775,778,1,0,0,0,776,774,1,0,0,0,776,777,1,0,0,0,777,220,
		1,0,0,0,778,776,1,0,0,0,779,781,3,233,115,0,780,779,1,0,0,0,781,782,1,
		0,0,0,782,780,1,0,0,0,782,783,1,0,0,0,783,222,1,0,0,0,784,786,5,36,0,0,
		785,787,3,235,116,0,786,785,1,0,0,0,787,788,1,0,0,0,788,786,1,0,0,0,788,
		789,1,0,0,0,789,224,1,0,0,0,790,792,5,37,0,0,791,793,3,237,117,0,792,791,
		1,0,0,0,793,794,1,0,0,0,794,792,1,0,0,0,794,795,1,0,0,0,795,226,1,0,0,
		0,796,797,5,47,0,0,797,798,5,42,0,0,798,802,1,0,0,0,799,801,9,0,0,0,800,
		799,1,0,0,0,801,804,1,0,0,0,802,803,1,0,0,0,802,800,1,0,0,0,803,805,1,
		0,0,0,804,802,1,0,0,0,805,806,5,42,0,0,806,807,5,47,0,0,807,808,1,0,0,
		0,808,809,6,112,2,0,809,228,1,0,0,0,810,814,5,59,0,0,811,812,5,47,0,0,
		812,814,5,47,0,0,813,810,1,0,0,0,813,811,1,0,0,0,814,818,1,0,0,0,815,817,
		3,239,118,0,816,815,1,0,0,0,817,820,1,0,0,0,818,816,1,0,0,0,818,819,1,
		0,0,0,819,821,1,0,0,0,820,818,1,0,0,0,821,822,6,113,2,0,822,230,1,0,0,
		0,823,825,7,29,0,0,824,823,1,0,0,0,825,826,1,0,0,0,826,824,1,0,0,0,826,
		827,1,0,0,0,827,828,1,0,0,0,828,829,6,114,3,0,829,232,1,0,0,0,830,831,
		7,30,0,0,831,234,1,0,0,0,832,833,7,31,0,0,833,236,1,0,0,0,834,835,2,48,
		49,0,835,238,1,0,0,0,836,837,8,32,0,0,837,240,1,0,0,0,838,839,7,32,0,0,
		839,242,1,0,0,0,41,0,1,2,518,530,533,542,551,561,569,582,585,596,599,610,
		621,624,633,644,647,658,661,673,679,688,700,703,711,723,735,746,755,763,
		776,782,788,794,802,813,818,826,4,5,1,0,4,0,0,0,1,0,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
