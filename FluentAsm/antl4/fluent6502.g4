
grammar fluent6502;

options { caseInsensitive=true; }

module: (line? EOL)+;

line : comment | instruction | directive | label;

directive : '.'? 
   
instruction : label? operation comment?;

comment : COMMENT | MULTI_LINECOMMENT;

label : SYMBOL ':' | [+-]+

expr : number | SYMBOL | OP_UNARY expr | expr OP_BINARY expr | expr | '(' expr ')';

number : INT | HEX | BINARY;

// Directives
mode PreProc ;

preproc : ifdef | else | endif ;
ifdef   : PIFDEF PTEXT+ PEOL   ;
else    : PELSE  PEOL          ;
endif   : PENDIF PEOL          ;

PIFDEF : '.'? I F D E F;
PELSE  : '.'? E L S E;
PENDIF : '.'? E N D I F;
PTEXT  : [a-zA-Z0-9_-]+ ;
PEOL   : '\r'? '\n'    -> popMode;
PWS    : WS+        -> channel(HIDDEN) ;


// Math Operators

OP_UNARY: '+' | '-' | '>' | '<' | '^' | '~' | '!';
OP_BINARY: '+' | '-' | '*' | '/' | '&' | '|' | '<<' | '>>';

// Operation

operation : op_imp | op_acc | op_imm | op_rel | op_zpa | op_zpx | op_zpy | op_abs | op_abx | op_aby | op_ind | op_inx | op_iny;

op_imp : opcode_imp;
op_acc : opcode_acc A?;
op_imm : opcode_imm '#' expr;
op_rel : opcode_rel expr;
op_zpa : opcode_zpa expr;
op_zpx : opcode_zpx expr ',' X;
op_zpy : opcode_zpy expr ',' Y;
op_abs : opcode_abs expr;
op_abx : opcode_abx expr ',' X;
op_aby : opcode_aby expr ',' Y;
op_ind : opcode_ind '(' expr ')';
op_inx : opcode_inx '(' expr ',' X ')';
op_iny : opcode_iny '(' expr ')' ',' Y;

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

// OPCODES

ADC: A D C;
AND: A N D;
ASL: A S L;
BCC: B C C;
BCS: B C S;
BEQ: B E Q;
BIT: B I T;
BMI: B M I;
BNE: B N E;
BPL: B P L;
BRA: B R A;
BRK: B R K;
BVC: B V C;
BVS: B V S;
CLC: C L C;
CLD: C L D;
CLI: C L I;
CLV: C L V;
CMP: C M P;
CPX: C P X;
CPY: C P Y;
DEC: D E C;
DEX: D E X;
DEY: D E Y;
EOR: E O R;
INC: I N C;
INX: I N X;
INY: I N Y;
JMP: J M P;
JSR: J S R;
LDA: L D A;
LDY: L D Y;
LDX: L D X;
LSR: L D R;
NOP: N O P;
ORA: O R A;
PHA: P H A;
PHP: P H P;
PLA: P L A;
PLP: P L P;
ROL: R O L;
ROR: R O R;
RTI: R T I;
RTS: R T S;
SBC: S B C;
SEC: S E C;
SED: S E D;
SEI: S E I;
STA: S T A;
STX: S T X;
STY: S T Y;
TAX: T A X;
TAY: T A Y;
TSX: T S X;
TXA: T X A;
TXS: T X S;
TYA: T Y A;

// LEXER

STRING : '"' ~["]* '"';

SYMBOL: [a-zA-Z_][a-zA-Z_0-9]*;

INT: Digit+;

HEX: '$' HexDigit+;

BINARY: '%' BinaryDigit+;

fragment Digit: [0-9];

fragment HexDigit: [0-9a-fA-F];

fragment BinaryDigit: '0' | '1';

fragment NotLineEnd: ~[\r\n\u0085\u2028\u2029];

fragment A:[aA];
fragment B:[bB];
fragment C:[cC];
fragment D:[dD];
fragment E:[eE];
fragment F:[fF];
fragment G:[gG];
fragment H:[hH];
fragment I:[iI];
fragment J:[jJ];
fragment K:[kK];
fragment L:[lL];
fragment M:[mM];
fragment N:[nN];
fragment O:[oO];
fragment P:[pP];
fragment Q:[qQ];
fragment R:[rR];
fragment S:[sS];
fragment T:[tT];
fragment U:[uU];
fragment V:[vV];
fragment W:[wW];
fragment X:[xX];
fragment Y:[yY];
fragment Z:[zZ];

MULTI_COMMENT: '/*' .*? '*/' -> channel(HIDDEN);

COMMENT: ';' | '//' NotLineEnd* -> channel(HIDDEN);

WS: [ \t\u000C\r\n]+ -> skip;
