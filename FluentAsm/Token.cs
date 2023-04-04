using sly.lexer;

namespace FluentAsm.Assembly._6502;

public enum ExpressionToken
{
    #region directives 0 -> 49

    [Keyword("IF")] [Keyword("if")] IF = 1,

    [Keyword("ELSE")] [Keyword("else")] ELSE = 2,

    [Keyword("ENDIF")] [Keyword("endif")] ENDIF = 3,

    [Keyword("WHILE")] [Keyword("while")] WHILE = 4,

    [Keyword("NOT")] [Keyword("not")] NOT = 9,

    [Keyword("AND")] [Keyword("and")] AND = 10,

    [Keyword("OR")] [Keyword("or")] OR = 11,

    [Keyword("OUT")] [Keyword("out")] PRINT = 12,

    #endregion

    #region literals 50 -> 99

    [AlphaId] LABEL = 50,

    [String] STRING = 51,

    [Int] INT = 52,

    #endregion

    #region operators 100 -> 149

    [Sugar(">")] GREATER = 100,

    [Sugar("<")] LESSER = 101,

    [Sugar("==")] EQ = 102,

    [Sugar("!=")] NEQ = 103,

    [Sugar("+")] PLUS = 104,

    [Sugar("-")] MINUS = 105,

    [Sugar("*")] TIMES = 106,

    [Sugar("/")] DIVIDE = 107,

    [Sugar("$")] DOLLAR = 108,

    [Sugar("#")] POUND = 109,

    #endregion

    #region sugar 150 ->

    [Sugar("(")] LPAREN = 150,

    [Sugar(")")] RPAREN = 151,

    [Sugar(";")] SEMICOLON = 152,

    [Comment(";", "/*", "*/")] COMMENT = 153,

    EOF = 0,

    #endregion
}
