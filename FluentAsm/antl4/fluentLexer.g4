
lexer grammar fluentLexer;

options { caseInsensitive=true; }

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

mode PREPROC;

PIFDEF : '.'? I F D E F;
PELSE  : '.'? E L S E;
PENDIF : '.'? E N D I F;
PTEXT  : [a-zA-Z0-9_-]+;
PEOL   : EOL -> popMode;
PWS    : WS+ -> channel(HIDDEN);

mode DEFAULT;

STRING: '"' ~["]* '"';

SYMBOL: [a-zA-Z_][a-zA-Z_0-9]*;

INT: Digit+;

HEX: '$' HexDigit+;

BINARY: '%' BinaryDigit+;

MULTI_COMMENT: '/*' .*? '*/' -> channel(HIDDEN);

COMMENT: (';' | '//') NotLineEnd* -> channel(HIDDEN);

WS: [ \t\u000C\r\n]+ -> skip;

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
TOKA: A;
TOKX: X;
TOKY: Y;

fragment Digit: [0-9];

fragment HexDigit: [0-9a-fA-F];

fragment BinaryDigit: '0' | '1';

fragment NotLineEnd: ~[\r\n\u0085\u2028\u2029];

fragment EOL: [\r\n\u0085\u2028\u2029];

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
