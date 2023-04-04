using CommandLine;

Action<Options> RunOptions = (o) =>
{

};

Action<IEnumerable<Error>> HandleError = (errs) =>
{

};

Parser.Default.ParseArguments<Options>(args)
                  .WithParsed(RunOptions)
                  .WithNotParsed(HandleError);

internal record class Options
{
    [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
    public bool Verbose { get; set; }

    [Option('h', "help", Required = false, HelpText = "Output this help message.")]
    public bool DisplayHelp { get; set; }

    [Option('o', "output", Required = false, HelpText = "Filename for the output binary")]
    public bool Output { get; set; }

    [Value(0, MetaName = "Input file(s)", HelpText = "Input file to be processed.", Required = true)]
    public IEnumerable<string> Files { get; set; }
}
