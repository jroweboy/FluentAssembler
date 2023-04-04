
lexer grammar FluentLexer;

options { caseInsensitive=true; }

A: 'a';
X: 'x';
Y: 'y';
ADC: 'adc';
AND: 'and';
ASL: 'asl';
BCC: 'bcc';
BCS: 'bcs';
BEQ: 'beq';
BIT: 'bit';
BMI: 'bmi';
BNE: 'bne';
BPL: 'bpl';
BRA: 'bra';
BRK: 'brk';
BVC: 'bvc';
BVS: 'bvs';
CLC: 'clc';
CLD: 'cld';
CLI: 'cli';
CLV: 'clv';
CMP: 'cmp';
CPX: 'cpx';
CPY: 'cpy';
DEC: 'dec';
DEX: 'dex';
DEY: 'dey';
EOR: 'eor';
INC: 'inc';
INX: 'inx';
INY: 'iny';
JMP: 'jmp';
JSR: 'jsr';
LDA: 'lda';
LDY: 'ldy';
LDX: 'ldx';
LSR: 'lsr';
NOP: 'nop';
ORA: 'ora';
PHA: 'pha';
PHP: 'php';
PLA: 'pla';
PLP: 'plp';
ROL: 'rol';
ROR: 'ror';
RTI: 'rti';
RTS: 'rts';
SBC: 'sbc';
SEC: 'sec';
SED: 'sed';
SEI: 'sei';
STA: 'sta';
STX: 'stx';
STY: 'sty';
TAX: 'tax';
TAY: 'tay';
TSX: 'tsx';
TXA: 'txa';
TXS: 'txs';
TYA: 'tya';


DOT: '.';
POUND: '#';
COLON: ':';
COMMA: ',';
LPAREN: '(';
RPAREN: ')';
PLUS: '+';
MINUS: '-';
LT: '<';
GT: '>';
CARET: '^';
TILDE: '~';
EXCLM: '!';
STAR: '*';
SLASH: '/';
AMP: '&';
PIPE: '|';
LSHFT: '<<';
RSHFT: '>>';
AT: '@';

mode DIRECTIVE;

// Control directives
ADDR  : '.addr';
DW    : '.dw';
WORD  : '.word';

// ALIGN : 'align' | '.align';
// ASCII : 'ascii' | '.ascii';
// ASSERT: 'assert' | '.assert';
// BANK  : 'bank';
// BANKBYTES: 'bankbytes' | 'dk';
// BYTES : 'byte' | 'byt' | 'db';
// CHARMAP: 'charmap';
// DBYTE : 'dbyt' | 'dbyte';
// DWORD : 'dword';
// HIBYTES: 'hibytes' | 'dh';

// macro directives

mode MACRO;

PDEFINE: 'define';
PIF    : 'if';
PIFDEF : 'ifdef';
PELIF  : 'elif' | 'elseif';
PELSE  : 'else';
PENDIF : 'endif';

// Helpers for directives and macros
// PDEFTEX: ()+;
PTEXT  : [a-z0-9_-]+;
PEOLPOP: EOL -> popMode;
PEOL   : EOL -> popMode;
PWS    : WS+ -> channel(HIDDEN);

mode default;

STRING: '"' ~["]* '"';

CHAR: '\'' ~['] '\'';

SYMBOL options { caseInsensitive=false; }: [a-zA-Z_][a-zA-Z_0-9]*;

INT: Digit+;

HEX: '$' HexDigit+;

BINARY: '%' BinaryDigit+;

MULTI_COMMENT: '/*' .*? '*/' -> channel(HIDDEN);

COMMENT: (';' | '//') NotLineEnd* -> channel(HIDDEN);

WS: [ \t\u000C\r\n]+ -> skip;

fragment Digit: [0-9];

fragment HexDigit: [0-9a-f];

fragment BinaryDigit: '0' | '1';

fragment NotLineEnd: ~[\r\n\u0085\u2028\u2029];

fragment EOL: [\r\n\u0085\u2028\u2029];
