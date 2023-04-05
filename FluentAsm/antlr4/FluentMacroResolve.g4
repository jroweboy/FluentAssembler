
parser grammar FluentPreprocessor;

options {
    tokenVocab = FluentLexer;
}

module: PTEXT+ EOF;

// line : instruction | directive | label_def;


