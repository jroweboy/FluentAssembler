﻿namespace FluentAsm;

public class Assembler
{


    private static readonly Lazy<Assembler> lazy = new Lazy<Assembler>(() => new Assembler());
    public static Assembler Instance { get { return lazy.Value; } }
}
