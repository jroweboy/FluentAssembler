parser grammar Fluent6502;

@header {
namespace FluentAsm.Assembly.ASM_6502.gen;
}

options {
    tokenVocab = FluentLexer;
    language=CSharp;
}

module: line+ EOF;

line : comment | instruction | directive | label_def;

instruction: label_def? operation comment?;

comment: COMMENT | MULTI_COMMENT;

label_def : AT? SYMBOL COLON | opGoto;

// Expressions

expr: number | pc | char | label | opUnary expr | expr opBinary expr | LPAREN expr RPAREN;

number : INT | HEX | BINARY;

pc: STAR;
char: CHAR;
label: AT? SYMBOL | opGoto;

// Directives (Preprocessor is handled before this)
directive: 
    dirWord
    | dirAlign
    | dirAscii
    | dirAssert
    | dirBank
    | dirBytes
    | dirBankbyte
;

dirWord    : WORD expr (COMMA expr)*;
dirAlign   : ALIGN expr;
dirAscii   : ASCII STRING;
dirAssert  : ASSERT expr (COMMA STRING)?;
dirBank    : BANK;
dirBytes   : BYTES expr (COMMA expr)*;
dirBankbyte: BANKBYTES expr (COMMA expr)*;

// Math Operators

opUnary: PLUS | MINUS | LT | GT | CARET | TILDE | EXCLM;
opBinary: PLUS | MINUS | STAR | SLASH | AMP | PIPE | LSHFT | RSHFT;
opGoto: PLUS+ | MINUS+;

// Operation

operation: opImp | opAcc | opImm | opRel | opZab | opZax | opZay | opInd | opInx | opIny;

opImp : opcodeImplied;
opAcc : opcodeAccumlator A?;
opImm : opcodeImmediate  POUND expr;
opRel : opcodeRelative   expr;
opZab : opcodeZpAbs      expr;
opZax : opcodeZpAbsX     expr COMMA X;
opZay : opcodeZpAbsY     expr COMMA Y;
opInd : opcodeIndirect   LPAREN expr RPAREN;
opInx : opcodeIndirectX  LPAREN expr COMMA X RPAREN;
opIny : opcodeIndirectY  LPAREN expr RPAREN COMMA Y;


opcodeImplied   : BRK | CLC | CLD | CLI | CLV | DEX | DEY | INX | INY | NOP | PHA | PHP | PLA | PLP | RTI | RTS | SEC | SED | SEI | TAX | TAY | TSX | TXA | TXS | TYA;
opcodeAccumlator: ASL | LSR | ROL | ROR;
opcodeImmediate : ADC | AND | CMP | CPX | CPY | EOR | LDA | LDX | LDY | ORA | SBC;
opcodeRelative  : BCC | BCS | BEQ | BMI | BNE | BPL | BVC | BVS;

opcodeZpAbs     : ADC | AND | ASL | BIT | CMP | CPX | CPY | DEC | EOR | INC | JMP | JSR | LDA | LDX | LDY | LSR | ORA | ROL | ROR | SBC | STA | STX | STY;
opcodeZpAbsX    : ADC | AND | ASL | CMP | DEC | EOR | INC | LDA | LDY | LSR | ORA | ROL | ROR | SBC | STA | STY;
opcodeZpAbsY    : ADC | AND | CMP | EOR | LDA | LDX | ORA | SBC | STA | STX;

opcodeIndirect  : JMP;
opcodeIndirectX : ADC | AND | CMP | EOR | LDA | ORA | SBC | STA;
opcodeIndirectY : ADC | AND | CMP | EOR | LDA | ORA | SBC | STA;
