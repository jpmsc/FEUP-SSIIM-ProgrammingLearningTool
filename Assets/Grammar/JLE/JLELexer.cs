//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from JLE.g4 by ANTLR 4.5.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public partial class JLELexer : Lexer {
	public const int
		ARGS=1, ARG=2, DIR=3, ANG=4, INT=5, IDENTIFIER=6, LEFTPAR=7, RIGHTPAR=8, 
		SEMICOLON=9, COMMA=10, NEWLINE=11, WS=12;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"ARGS", "ARG", "DIR", "ANG", "INT", "IDENTIFIER", "LEFTPAR", "RIGHTPAR", 
		"SEMICOLON", "COMMA", "NEWLINE", "WS"
	};


		public Compiler compiler = new Compiler();


	public JLELexer(ICharStream input)
		: base(input)
	{
		Interpreter = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, null, null, null, null, "'('", "')'", "';'", "','"
	};
	private static readonly string[] _SymbolicNames = {
		null, "ARGS", "ARG", "DIR", "ANG", "INT", "IDENTIFIER", "LEFTPAR", "RIGHTPAR", 
		"SEMICOLON", "COMMA", "NEWLINE", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "JLE.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	private static string _serializedATN = _serializeATN();
	private static string _serializeATN()
	{
	    StringBuilder sb = new StringBuilder();
	    sb.Append("\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x2\xE");
		sb.Append("^\b\x1\x4\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6");
		sb.Append("\x4\a\t\a\x4\b\t\b\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r");
		sb.Append("\t\r\x3\x2\x3\x2\x3\x2\x6\x2\x1F\n\x2\r\x2\xE\x2 \x3\x2\x3\x2");
		sb.Append("\x3\x2\x5\x2&\n\x2\x3\x3\x3\x3\x5\x3*\n\x3\x3\x4\x3\x4\x3\x4");
		sb.Append("\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4");
		sb.Append("\x3\x4\x5\x4:\n\x4\x3\x5\x3\x5\x3\x6\x5\x6?\n\x6\x3\x6\x6\x6");
		sb.Append("\x42\n\x6\r\x6\xE\x6\x43\x3\a\x6\aG\n\a\r\a\xE\aH\x3\b\x3\b");
		sb.Append("\x3\t\x3\t\x3\n\x3\n\x3\v\x3\v\x3\f\x5\fT\n\f\x3\f\x3\f\x3\r");
		sb.Append("\x6\rY\n\r\r\r\xE\rZ\x3\r\x3\r\x2\x2\xE\x3\x3\x5\x4\a\x5\t\x6");
		sb.Append("\v\a\r\b\xF\t\x11\n\x13\v\x15\f\x17\r\x19\xE\x3\x2\x4\x4\x2");
		sb.Append("\x43\\\x63|\x5\x2\v\f\xF\xF\"\"\x66\x2\x3\x3\x2\x2\x2\x2\x5");
		sb.Append("\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2");
		sb.Append("\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2");
		sb.Append("\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19");
		sb.Append("\x3\x2\x2\x2\x3%\x3\x2\x2\x2\x5)\x3\x2\x2\x2\a\x39\x3\x2\x2");
		sb.Append("\x2\t;\x3\x2\x2\x2\v>\x3\x2\x2\x2\r\x46\x3\x2\x2\x2\xFJ\x3\x2");
		sb.Append("\x2\x2\x11L\x3\x2\x2\x2\x13N\x3\x2\x2\x2\x15P\x3\x2\x2\x2\x17");
		sb.Append("S\x3\x2\x2\x2\x19X\x3\x2\x2\x2\x1B\x1C\x5\x5\x3\x2\x1C\x1D\x5");
		sb.Append("\x15\v\x2\x1D\x1F\x3\x2\x2\x2\x1E\x1B\x3\x2\x2\x2\x1F \x3\x2");
		sb.Append("\x2\x2 \x1E\x3\x2\x2\x2 !\x3\x2\x2\x2!\"\x3\x2\x2\x2\"#\x5\x5");
		sb.Append("\x3\x2#&\x3\x2\x2\x2$&\x5\x5\x3\x2%\x1E\x3\x2\x2\x2%$\x3\x2");
		sb.Append("\x2\x2&\x4\x3\x2\x2\x2\'*\x5\a\x4\x2(*\x5\t\x5\x2)\'\x3\x2\x2");
		sb.Append("\x2)(\x3\x2\x2\x2*\x6\x3\x2\x2\x2+,\aO\x2\x2,-\aQ\x2\x2-.\a");
		sb.Append("X\x2\x2./\a\x61\x2\x2/\x30\aH\x2\x2\x30\x31\aY\x2\x2\x31:\a");
		sb.Append("\x46\x2\x2\x32\x33\aO\x2\x2\x33\x34\aQ\x2\x2\x34\x35\aX\x2\x2");
		sb.Append("\x35\x36\a\x61\x2\x2\x36\x37\a\x44\x2\x2\x37\x38\aY\x2\x2\x38");
		sb.Append(":\a\x46\x2\x2\x39+\x3\x2\x2\x2\x39\x32\x3\x2\x2\x2:\b\x3\x2");
		sb.Append("\x2\x2;<\x5\v\x6\x2<\n\x3\x2\x2\x2=?\a/\x2\x2>=\x3\x2\x2\x2");
		sb.Append(">?\x3\x2\x2\x2?\x41\x3\x2\x2\x2@\x42\x4\x32;\x2\x41@\x3\x2\x2");
		sb.Append("\x2\x42\x43\x3\x2\x2\x2\x43\x41\x3\x2\x2\x2\x43\x44\x3\x2\x2");
		sb.Append("\x2\x44\f\x3\x2\x2\x2\x45G\t\x2\x2\x2\x46\x45\x3\x2\x2\x2GH");
		sb.Append("\x3\x2\x2\x2H\x46\x3\x2\x2\x2HI\x3\x2\x2\x2I\xE\x3\x2\x2\x2");
		sb.Append("JK\a*\x2\x2K\x10\x3\x2\x2\x2LM\a+\x2\x2M\x12\x3\x2\x2\x2NO\a");
		sb.Append("=\x2\x2O\x14\x3\x2\x2\x2PQ\a.\x2\x2Q\x16\x3\x2\x2\x2RT\a\xF");
		sb.Append("\x2\x2SR\x3\x2\x2\x2ST\x3\x2\x2\x2TU\x3\x2\x2\x2UV\a\f\x2\x2");
		sb.Append("V\x18\x3\x2\x2\x2WY\t\x3\x2\x2XW\x3\x2\x2\x2YZ\x3\x2\x2\x2Z");
		sb.Append("X\x3\x2\x2\x2Z[\x3\x2\x2\x2[\\\x3\x2\x2\x2\\]\b\r\x2\x2]\x1A");
		sb.Append("\x3\x2\x2\x2\f\x2 %)\x39>\x43HSZ\x3\b\x2\x2");
	    return sb.ToString();
	}

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
