parser grammar fluent6502;

options {
    tokenVocab = fluentLexer;
}

module: line+ EOF;

line : comment | instruction | directive | label_def;

directive: DOT? preproc comment?;
   
instruction: label_def? operation comment?;

comment: COMMENT | MULTI_COMMENT;

label_def : AT? SYMBOL COLON | op_goto;

label: AT? SYMBOL | op_goto;

expr: number | pc | label | op_unary expr | expr op_binary expr | LPAREN expr RPAREN;

number : INT | HEX | BINARY;

// Directives and Preprocessor
preproc: pifdef | pelse | pendif;
pifdef: PIFDEF PTEXT+ PEOL;
pelse:  PELSE  PEOL;
pendif: PENDIF PEOL;

// Math Operators

pc: STAR;
op_unary: PLUS | MINUS | LT | GT | CARET | TILDE | EXCLM;
op_binary: PLUS | MINUS | STAR | SLASH | AMP | PIPE | LSHFT | RSHFT;
op_goto: PLUS+ | MINUS+;

// Operation

operation: op_imp | op_acc | op_imm | op_rel | op_zpa | op_zpx | op_zpy | op_abs | op_abx | op_aby | op_ind | op_inx | op_iny;

op_imp : opcode_imp;
op_acc : opcode_acc TOKA?;
op_imm : opcode_imm POUND expr;
op_rel : opcode_rel expr;
op_zpa : opcode_zpa expr;
op_zpx : opcode_zpx expr COMMA TOKX;
op_zpy : opcode_zpy expr COMMA TOKY;
op_abs : opcode_abs expr;
op_abx : opcode_abx expr COMMA TOKX;
op_aby : opcode_aby expr COMMA TOKY;
op_ind : opcode_ind LPAREN expr RPAREN;
op_inx : opcode_inx LPAREN expr COMMA TOKX RPAREN;
op_iny : opcode_iny LPAREN expr RPAREN COMMA TOKY;


opcode_imp : BRK | CLC | CLD | CLI | CLV | DEX | DEY | INX | INY | NOP | PHA | PHP | PLA | PLP | RTI | RTS | SEC | SED | SEI | TAX | TAY | TSX | TXA | TXS | TYA;
opcode_acc : ASL | LSR | ROL | ROR;
opcode_imm : ADC | AND | CMP | CPX | CPY | EOR | LDA | LDX | LDY | ORA | SBC;
opcode_rel : BCC | BCS | BEQ | BMI | BNE | BPL | BVC | BVS;
opcode_zpa : ADC | AND | ASL | BIT | CMP | CPX | CPY | DEC | EOR | INC | LDA | LDX | LDY | LSR | ORA | ROL | ROR | SBC | STA | STX | STY;
opcode_zpx : ADC | AND | ASL | CMP | DEC | EOR | INC | LDA | LDY | LSR | ORA | ROL | ROR | SBC | STA | STY;
opcode_zpy : LDX | STX;
opcode_abs : ADC | AND | ASL | BIT | CMP | CPX | CPY | DEC | EOR | INC | JMP | JSR | LDA | LDX | LDY | LSR | ORA | ROL | ROR | SBC | STA | STX | STY;
opcode_abx : ADC | AND | ASL | CMP | DEC | EOR | INC | LDA | LDY | LSR | ORA | ROL | ROR | SBC | STA;
opcode_aby : ADC | AND | CMP | EOR | LDA | LDX | ORA | SBC | STA;
opcode_ind : JMP;
opcode_inx : ADC | AND | CMP | EOR | LDA | ORA | SBC | STA;
opcode_iny : ADC | AND | CMP | EOR | LDA | ORA | SBC | STA;
