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

label_def : AT? SYMBOL COLON | op_goto;

// Expressions

expr: number | pc | char | label | op_unary expr | expr op_binary expr | LPAREN expr RPAREN;

number : INT | HEX | BINARY;

pc: STAR;
char: CHAR;
label: AT? SYMBOL | op_goto;

// Directives (Preprocessor is handled before this)
directive: 
    dir_word
    | dir_align
    | dir_ascii
    | dir_assert
    | dir_bank
    | dir_bytes
    | dir_bankbyt
;

dir_word   : WORD expr (COMMA expr)*;
dir_align  : ALIGN expr;
dir_ascii  : ASCII STRING;
dir_assert : ASSERT expr (COMMA STRING)?;
dir_bank   : BANK;
dir_bytes  : BYTES expr (COMMA expr)*;
dir_bankbyt: BANKBYTES expr (COMMA expr)*;

// Math Operators

op_unary: PLUS | MINUS | LT | GT | CARET | TILDE | EXCLM;
op_binary: PLUS | MINUS | STAR | SLASH | AMP | PIPE | LSHFT | RSHFT;
op_goto: PLUS+ | MINUS+;

// Operation

operation: op_imp | op_acc | op_imm | op_rel | op_zab | op_zax | op_zay | op_ind | op_inx | op_iny;

op_imp : opcode_implied;
op_acc : opcode_accumlator A?;
op_imm : opcode_immediate  POUND expr;
op_rel : opcode_relative   expr;
op_zab : opcode_zp_abs     expr;
op_zax : opcode_zp_abs_x   expr COMMA X;
op_zay : opcode_zp_abs_y   expr COMMA Y;
op_ind : opcode_indirect   LPAREN expr RPAREN;
op_inx : opcode_indirect_x LPAREN expr COMMA X RPAREN;
op_iny : opcode_indirect_y LPAREN expr RPAREN COMMA Y;


opcode_implied    : BRK | CLC | CLD | CLI | CLV | DEX | DEY | INX | INY | NOP | PHA | PHP | PLA | PLP | RTI | RTS | SEC | SED | SEI | TAX | TAY | TSX | TXA | TXS | TYA;
opcode_accumlator : ASL | LSR | ROL | ROR;
opcode_immediate  : ADC | AND | CMP | CPX | CPY | EOR | LDA | LDX | LDY | ORA | SBC;
opcode_relative   : BCC | BCS | BEQ | BMI | BNE | BPL | BVC | BVS;

opcode_zp_abs     : ADC | AND | ASL | BIT | CMP | CPX | CPY | DEC | EOR | INC | JMP | JSR | LDA | LDX | LDY | LSR | ORA | ROL | ROR | SBC | STA | STX | STY;
opcode_zp_abs_x   : ADC | AND | ASL | CMP | DEC | EOR | INC | LDA | LDY | LSR | ORA | ROL | ROR | SBC | STA | STY;
opcode_zp_abs_y   : ADC | AND | CMP | EOR | LDA | LDX | ORA | SBC | STA | STX;

opcode_indirect   : JMP;
opcode_indirect_x : ADC | AND | CMP | EOR | LDA | ORA | SBC | STA;
opcode_indirect_y : ADC | AND | CMP | EOR | LDA | ORA | SBC | STA;
