using FluentAsm.Assembly.ASM_6502;

namespace FluentAsm.Test;

public class Tests
{

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AssemblerTestBasicRun()
    {
        var options = new Options() { Verbose = true };
        var asm = new Assembler(options);
        Assert.DoesNotThrow(() => asm.Compile(null, """
            lda #4
            sta $4
            """)
        );
    }
}