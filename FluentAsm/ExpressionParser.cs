using sly.lexer;
using sly.parser.generator;

namespace FluentAsm.Assembly._6502;

public class ExpressionParser
{

    [Production("Terminal: GREATER INT")]
    public byte TerminalByte(Token<ExpressionToken> intToken)
    {
        return intToken.IntValue;
    }

    [Production("Terminal: INT")]
    public int Primary(Token<ExpressionToken> intToken)
    {
        return intToken.IntValue;
    }

    [Production("Terminal: LPAREN [d] expression RPAREN [d]")]
    public int Group(int groupValue)
    {
        return groupValue;
    }
}
