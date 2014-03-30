// $ANTLR 3.2 Sep 23, 2009 12:02:23 Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g 2012-04-12 15:42:55

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class C2CUDATranslatorLexer : Lexer {
    public const int T__68 = 68;
    public const int T__69 = 69;
    public const int T__66 = 66;
    public const int T__67 = 67;
    public const int T__29 = 29;
    public const int T__64 = 64;
    public const int T__28 = 28;
    public const int T__65 = 65;
    public const int T__27 = 27;
    public const int T__62 = 62;
    public const int RWORD = 8;
    public const int T__26 = 26;
    public const int T__63 = 63;
    public const int T__25 = 25;
    public const int T__24 = 24;
    public const int T__23 = 23;
    public const int T__22 = 22;
    public const int T__21 = 21;
    public const int T__20 = 20;
    public const int ID = 4;
    public const int T__61 = 61;
    public const int EOF = -1;
    public const int T__60 = 60;
    public const int T__55 = 55;
    public const int T__19 = 19;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int STRING_LITERAL = 11;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int T__59 = 59;
    public const int COMMENT = 16;
    public const int T__50 = 50;
    public const int ARRAY = 7;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int Keyword = 6;
    public const int T__46 = 46;
    public const int T__47 = 47;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int LINE_COMMENT = 15;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int CHARACTER_LITERAL = 12;
    public const int INT = 5;
    public const int PRINT = 10;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int T__33 = 33;
    public const int T__71 = 71;
    public const int WS = 13;
    public const int T__34 = 34;
    public const int T__72 = 72;
    public const int T__35 = 35;
    public const int T__36 = 36;
    public const int T__70 = 70;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int CHARS = 14;
    public const int T__76 = 76;
    public const int MAINS = 9;
    public const int T__75 = 75;
    public const int T__74 = 74;
    public const int T__73 = 73;
    public const int EscapeSequence = 17;
    public const int OctalEscape = 18;

    // delegates
    // delegators

    public C2CUDATranslatorLexer() 
    {
		InitializeCyclicDFAs();
    }
    public C2CUDATranslatorLexer(ICharStream input)
		: this(input, null) {
    }
    public C2CUDATranslatorLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g";} 
    }

    // $ANTLR start "T__19"
    public void mT__19() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__19;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:7:7: ( ';' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:7:9: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__19"

    // $ANTLR start "T__20"
    public void mT__20() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__20;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:8:7: ( '()' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:8:9: '()'
            {
            	Match("()"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__20"

    // $ANTLR start "T__21"
    public void mT__21() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__21;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:9:7: ( '(' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:9:9: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__21"

    // $ANTLR start "T__22"
    public void mT__22() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__22;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:10:7: ( 'int' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:10:9: 'int'
            {
            	Match("int"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__22"

    // $ANTLR start "T__23"
    public void mT__23() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__23;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:11:7: ( 'char' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:11:9: 'char'
            {
            	Match("char"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__23"

    // $ANTLR start "T__24"
    public void mT__24() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__24;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:12:7: ( '*' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:12:9: '*'
            {
            	Match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__24"

    // $ANTLR start "T__25"
    public void mT__25() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__25;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:13:7: ( '[]' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:13:9: '[]'
            {
            	Match("[]"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__25"

    // $ANTLR start "T__26"
    public void mT__26() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__26;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:14:7: ( ',' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:14:9: ','
            {
            	Match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__26"

    // $ANTLR start "T__27"
    public void mT__27() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__27;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:15:7: ( ')' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:15:9: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__27"

    // $ANTLR start "T__28"
    public void mT__28() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__28;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:16:7: ( '{' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:16:9: '{'
            {
            	Match('{'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__28"

    // $ANTLR start "T__29"
    public void mT__29() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__29;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:17:7: ( '}' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:17:9: '}'
            {
            	Match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__29"

    // $ANTLR start "T__30"
    public void mT__30() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__30;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:18:7: ( ');' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:18:9: ');'
            {
            	Match(");"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__30"

    // $ANTLR start "T__31"
    public void mT__31() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__31;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:19:7: ( '.' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:19:9: '.'
            {
            	Match('.'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__31"

    // $ANTLR start "T__32"
    public void mT__32() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__32;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:20:7: ( '+' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:20:9: '+'
            {
            	Match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__32"

    // $ANTLR start "T__33"
    public void mT__33() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__33;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:21:7: ( '-' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:21:9: '-'
            {
            	Match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__33"

    // $ANTLR start "T__34"
    public void mT__34() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__34;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:22:7: ( '/' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:22:9: '/'
            {
            	Match('/'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__34"

    // $ANTLR start "T__35"
    public void mT__35() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__35;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:23:7: ( '%' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:23:9: '%'
            {
            	Match('%'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__35"

    // $ANTLR start "T__36"
    public void mT__36() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__36;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:24:7: ( 'float' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:24:9: 'float'
            {
            	Match("float"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__36"

    // $ANTLR start "T__37"
    public void mT__37() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__37;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:25:7: ( 'bool' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:25:9: 'bool'
            {
            	Match("bool"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__37"

    // $ANTLR start "T__38"
    public void mT__38() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__38;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:26:7: ( 'kernel' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:26:9: 'kernel'
            {
            	Match("kernel"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__38"

    // $ANTLR start "T__39"
    public void mT__39() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__39;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:27:7: ( 'void' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:27:9: 'void'
            {
            	Match("void"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__39"

    // $ANTLR start "T__40"
    public void mT__40() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__40;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:28:7: ( 'double' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:28:9: 'double'
            {
            	Match("double"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__40"

    // $ANTLR start "T__41"
    public void mT__41() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__41;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:29:7: ( 'cudaDeviceProp' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:29:9: 'cudaDeviceProp'
            {
            	Match("cudaDeviceProp"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__41"

    // $ANTLR start "T__42"
    public void mT__42() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__42;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:30:7: ( 'size_t' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:30:9: 'size_t'
            {
            	Match("size_t"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__42"

    // $ANTLR start "T__43"
    public void mT__43() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__43;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:31:7: ( '#include' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:31:9: '#include'
            {
            	Match("#include"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__43"

    // $ANTLR start "T__44"
    public void mT__44() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__44;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:32:7: ( 'for' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:32:9: 'for'
            {
            	Match("for"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__44"

    // $ANTLR start "T__45"
    public void mT__45() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__45;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:33:7: ( '=' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:33:9: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__45"

    // $ANTLR start "T__46"
    public void mT__46() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__46;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:34:7: ( '-=' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:34:9: '-='
            {
            	Match("-="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__46"

    // $ANTLR start "T__47"
    public void mT__47() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__47;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:35:7: ( '+=' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:35:9: '+='
            {
            	Match("+="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__47"

    // $ANTLR start "T__48"
    public void mT__48() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__48;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:36:7: ( 'fprintf(' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:36:9: 'fprintf('
            {
            	Match("fprintf("); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__48"

    // $ANTLR start "T__49"
    public void mT__49() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__49;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:37:7: ( 'default' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:37:9: 'default'
            {
            	Match("default"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__49"

    // $ANTLR start "T__50"
    public void mT__50() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__50;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:38:7: ( ':' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:38:9: ':'
            {
            	Match(':'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__50"

    // $ANTLR start "T__51"
    public void mT__51() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__51;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:39:7: ( 'return' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:39:9: 'return'
            {
            	Match("return"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__51"

    // $ANTLR start "T__52"
    public void mT__52() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__52;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:40:7: ( 'while' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:40:9: 'while'
            {
            	Match("while"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__52"

    // $ANTLR start "T__53"
    public void mT__53() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__53;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:41:7: ( 'do' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:41:9: 'do'
            {
            	Match("do"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__53"

    // $ANTLR start "T__54"
    public void mT__54() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__54;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:42:7: ( 'if' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:42:9: 'if'
            {
            	Match("if"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__54"

    // $ANTLR start "T__55"
    public void mT__55() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__55;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:43:7: ( 'else' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:43:9: 'else'
            {
            	Match("else"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__55"

    // $ANTLR start "T__56"
    public void mT__56() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__56;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:44:7: ( 'switch' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:44:9: 'switch'
            {
            	Match("switch"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__56"

    // $ANTLR start "T__57"
    public void mT__57() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__57;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:45:7: ( '++' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:45:9: '++'
            {
            	Match("++"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__57"

    // $ANTLR start "T__58"
    public void mT__58() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__58;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:46:7: ( '--' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:46:9: '--'
            {
            	Match("--"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__58"

    // $ANTLR start "T__59"
    public void mT__59() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__59;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:47:7: ( '*=' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:47:9: '*='
            {
            	Match("*="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__59"

    // $ANTLR start "T__60"
    public void mT__60() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__60;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:48:7: ( '==' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:48:9: '=='
            {
            	Match("=="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__60"

    // $ANTLR start "T__61"
    public void mT__61() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__61;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:49:7: ( '!=' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:49:9: '!='
            {
            	Match("!="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__61"

    // $ANTLR start "T__62"
    public void mT__62() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__62;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:50:7: ( '<' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:50:9: '<'
            {
            	Match('<'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__62"

    // $ANTLR start "T__63"
    public void mT__63() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__63;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:51:7: ( '>' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:51:9: '>'
            {
            	Match('>'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__63"

    // $ANTLR start "T__64"
    public void mT__64() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__64;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:52:7: ( '<=' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:52:9: '<='
            {
            	Match("<="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__64"

    // $ANTLR start "T__65"
    public void mT__65() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__65;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:53:7: ( '>=' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:53:9: '>='
            {
            	Match(">="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__65"

    // $ANTLR start "T__66"
    public void mT__66() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__66;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:54:7: ( '&&' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:54:9: '&&'
            {
            	Match("&&"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__66"

    // $ANTLR start "T__67"
    public void mT__67() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__67;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:55:7: ( '||' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:55:9: '||'
            {
            	Match("||"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__67"

    // $ANTLR start "T__68"
    public void mT__68() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__68;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:56:7: ( '[' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:56:9: '['
            {
            	Match('['); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__68"

    // $ANTLR start "T__69"
    public void mT__69() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__69;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:57:7: ( ']' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:57:9: ']'
            {
            	Match(']'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__69"

    // $ANTLR start "T__70"
    public void mT__70() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__70;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:58:7: ( 'kernel(' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:58:9: 'kernel('
            {
            	Match("kernel("); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__70"

    // $ANTLR start "T__71"
    public void mT__71() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__71;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:59:7: ( '();' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:59:9: '();'
            {
            	Match("();"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__71"

    // $ANTLR start "T__72"
    public void mT__72() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__72;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:60:7: ( 'local' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:60:9: 'local'
            {
            	Match("local"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__72"

    // $ANTLR start "T__73"
    public void mT__73() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__73;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:61:7: ( '#pragma kernel_start' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:61:9: '#pragma kernel_start'
            {
            	Match("#pragma kernel_start"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__73"

    // $ANTLR start "T__74"
    public void mT__74() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__74;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:62:7: ( '#pragma kernel_end' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:62:9: '#pragma kernel_end'
            {
            	Match("#pragma kernel_end"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__74"

    // $ANTLR start "T__75"
    public void mT__75() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__75;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:63:7: ( 'printf(' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:63:9: 'printf('
            {
            	Match("printf("); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__75"

    // $ANTLR start "T__76"
    public void mT__76() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__76;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:64:7: ( ']]' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:64:9: ']]'
            {
            	Match("]]"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__76"

    // $ANTLR start "MAINS"
    public void mMAINS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MAINS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1347:6: ( 'main' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1348:11: 'main'
            {
            	Match("main"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MAINS"

    // $ANTLR start "RWORD"
    public void mRWORD() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RWORD;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1351:7: ( '#define' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1352:2: '#define'
            {
            	Match("#define"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RWORD"

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1355:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )* | ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )* ( '=' ) ( ( INT )+ ) )
            int alt4 = 2;
            alt4 = dfa4.Predict(input);
            switch (alt4) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1355:9: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )*
                    {
                    	if ( input.LA(1) == '&' || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1355:37: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )*
                    	do 
                    	{
                    	    int alt1 = 2;
                    	    int LA1_0 = input.LA(1);

                    	    if ( (LA1_0 == '.' || (LA1_0 >= '0' && LA1_0 <= '9') || (LA1_0 >= 'A' && LA1_0 <= 'Z') || LA1_0 == '_' || (LA1_0 >= 'a' && LA1_0 <= 'z')) )
                    	    {
                    	        alt1 = 1;
                    	    }


                    	    switch (alt1) 
                    		{
                    			case 1 :
                    			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:
                    			    {
                    			    	if ( input.LA(1) == '.' || (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
                    			    	{
                    			    	    input.Consume();

                    			    	}
                    			    	else 
                    			    	{
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop1;
                    	    }
                    	} while (true);

                    	loop1:
                    		;	// Stops C# compiler whining that label 'loop1' has no statements


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1357:3: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )* ( '=' ) ( ( INT )+ )
                    {
                    	if ( input.LA(1) == '&' || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1357:31: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )*
                    	do 
                    	{
                    	    int alt2 = 2;
                    	    int LA2_0 = input.LA(1);

                    	    if ( (LA2_0 == '.' || (LA2_0 >= '0' && LA2_0 <= '9') || (LA2_0 >= 'A' && LA2_0 <= 'Z') || LA2_0 == '_' || (LA2_0 >= 'a' && LA2_0 <= 'z')) )
                    	    {
                    	        alt2 = 1;
                    	    }


                    	    switch (alt2) 
                    		{
                    			case 1 :
                    			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:
                    			    {
                    			    	if ( input.LA(1) == '.' || (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
                    			    	{
                    			    	    input.Consume();

                    			    	}
                    			    	else 
                    			    	{
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop2;
                    	    }
                    	} while (true);

                    	loop2:
                    		;	// Stops C# compiler whining that label 'loop2' has no statements

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1357:69: ( '=' )
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1357:70: '='
                    	{
                    		Match('='); 

                    	}

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1357:75: ( ( INT )+ )
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1357:76: ( INT )+
                    	{
                    		// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1357:76: ( INT )+
                    		int cnt3 = 0;
                    		do 
                    		{
                    		    int alt3 = 2;
                    		    int LA3_0 = input.LA(1);

                    		    if ( (LA3_0 == '-' || (LA3_0 >= '0' && LA3_0 <= '9')) )
                    		    {
                    		        alt3 = 1;
                    		    }


                    		    switch (alt3) 
                    			{
                    				case 1 :
                    				    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1357:77: INT
                    				    {
                    				    	mINT(); 

                    				    }
                    				    break;

                    				default:
                    				    if ( cnt3 >= 1 ) goto loop3;
                    			            EarlyExitException eee3 =
                    			                new EarlyExitException(3, input);
                    			            throw eee3;
                    		    }
                    		    cnt3++;
                    		} while (true);

                    		loop3:
                    			;	// Stops C# compiler whining that label 'loop3' has no statements


                    	}


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ID"

    // $ANTLR start "ARRAY"
    public void mARRAY() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ARRAY;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1363:7: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )* ( '[' ( INT | ID | ARRAY ) ( ( ' ' )* ( '+' | '-' | '/' | '*' ) ( ' ' )* ( INT | ID | ARRAY ) )* ']' )+ | ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )* ( '[' ']' )+ )
            int alt14 = 2;
            alt14 = dfa14.Predict(input);
            switch (alt14) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1364:4: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )* ( '[' ( INT | ID | ARRAY ) ( ( ' ' )* ( '+' | '-' | '/' | '*' ) ( ' ' )* ( INT | ID | ARRAY ) )* ']' )+
                    {
                    	if ( input.LA(1) == '&' || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1364:32: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )*
                    	do 
                    	{
                    	    int alt5 = 2;
                    	    int LA5_0 = input.LA(1);

                    	    if ( (LA5_0 == '.' || (LA5_0 >= '0' && LA5_0 <= '9') || (LA5_0 >= 'A' && LA5_0 <= 'Z') || LA5_0 == '_' || (LA5_0 >= 'a' && LA5_0 <= 'z')) )
                    	    {
                    	        alt5 = 1;
                    	    }


                    	    switch (alt5) 
                    		{
                    			case 1 :
                    			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:
                    			    {
                    			    	if ( input.LA(1) == '.' || (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
                    			    	{
                    			    	    input.Consume();

                    			    	}
                    			    	else 
                    			    	{
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop5;
                    	    }
                    	} while (true);

                    	loop5:
                    		;	// Stops C# compiler whining that label 'loop5' has no statements

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1364:70: ( '[' ( INT | ID | ARRAY ) ( ( ' ' )* ( '+' | '-' | '/' | '*' ) ( ' ' )* ( INT | ID | ARRAY ) )* ']' )+
                    	int cnt11 = 0;
                    	do 
                    	{
                    	    int alt11 = 2;
                    	    int LA11_0 = input.LA(1);

                    	    if ( (LA11_0 == '[') )
                    	    {
                    	        alt11 = 1;
                    	    }


                    	    switch (alt11) 
                    		{
                    			case 1 :
                    			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1364:71: '[' ( INT | ID | ARRAY ) ( ( ' ' )* ( '+' | '-' | '/' | '*' ) ( ' ' )* ( INT | ID | ARRAY ) )* ']'
                    			    {
                    			    	Match('['); 
                    			    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1364:75: ( INT | ID | ARRAY )
                    			    	int alt6 = 3;
                    			    	alt6 = dfa6.Predict(input);
                    			    	switch (alt6) 
                    			    	{
                    			    	    case 1 :
                    			    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1364:76: INT
                    			    	        {
                    			    	        	mINT(); 

                    			    	        }
                    			    	        break;
                    			    	    case 2 :
                    			    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1364:80: ID
                    			    	        {
                    			    	        	mID(); 

                    			    	        }
                    			    	        break;
                    			    	    case 3 :
                    			    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1364:83: ARRAY
                    			    	        {
                    			    	        	mARRAY(); 

                    			    	        }
                    			    	        break;

                    			    	}

                    			    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1364:90: ( ( ' ' )* ( '+' | '-' | '/' | '*' ) ( ' ' )* ( INT | ID | ARRAY ) )*
                    			    	do 
                    			    	{
                    			    	    int alt10 = 2;
                    			    	    int LA10_0 = input.LA(1);

                    			    	    if ( (LA10_0 == ' ' || (LA10_0 >= '*' && LA10_0 <= '+') || LA10_0 == '-' || LA10_0 == '/') )
                    			    	    {
                    			    	        alt10 = 1;
                    			    	    }


                    			    	    switch (alt10) 
                    			    		{
                    			    			case 1 :
                    			    			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1364:91: ( ' ' )* ( '+' | '-' | '/' | '*' ) ( ' ' )* ( INT | ID | ARRAY )
                    			    			    {
                    			    			    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1364:91: ( ' ' )*
                    			    			    	do 
                    			    			    	{
                    			    			    	    int alt7 = 2;
                    			    			    	    int LA7_0 = input.LA(1);

                    			    			    	    if ( (LA7_0 == ' ') )
                    			    			    	    {
                    			    			    	        alt7 = 1;
                    			    			    	    }


                    			    			    	    switch (alt7) 
                    			    			    		{
                    			    			    			case 1 :
                    			    			    			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1364:92: ' '
                    			    			    			    {
                    			    			    			    	Match(' '); 

                    			    			    			    }
                    			    			    			    break;

                    			    			    			default:
                    			    			    			    goto loop7;
                    			    			    	    }
                    			    			    	} while (true);

                    			    			    	loop7:
                    			    			    		;	// Stops C# compiler whining that label 'loop7' has no statements

                    			    			    	if ( (input.LA(1) >= '*' && input.LA(1) <= '+') || input.LA(1) == '-' || input.LA(1) == '/' ) 
                    			    			    	{
                    			    			    	    input.Consume();

                    			    			    	}
                    			    			    	else 
                    			    			    	{
                    			    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    			    	    Recover(mse);
                    			    			    	    throw mse;}

                    			    			    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1364:116: ( ' ' )*
                    			    			    	do 
                    			    			    	{
                    			    			    	    int alt8 = 2;
                    			    			    	    int LA8_0 = input.LA(1);

                    			    			    	    if ( (LA8_0 == ' ') )
                    			    			    	    {
                    			    			    	        alt8 = 1;
                    			    			    	    }


                    			    			    	    switch (alt8) 
                    			    			    		{
                    			    			    			case 1 :
                    			    			    			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1364:117: ' '
                    			    			    			    {
                    			    			    			    	Match(' '); 

                    			    			    			    }
                    			    			    			    break;

                    			    			    			default:
                    			    			    			    goto loop8;
                    			    			    	    }
                    			    			    	} while (true);

                    			    			    	loop8:
                    			    			    		;	// Stops C# compiler whining that label 'loop8' has no statements

                    			    			    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1364:123: ( INT | ID | ARRAY )
                    			    			    	int alt9 = 3;
                    			    			    	alt9 = dfa9.Predict(input);
                    			    			    	switch (alt9) 
                    			    			    	{
                    			    			    	    case 1 :
                    			    			    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1364:124: INT
                    			    			    	        {
                    			    			    	        	mINT(); 

                    			    			    	        }
                    			    			    	        break;
                    			    			    	    case 2 :
                    			    			    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1364:128: ID
                    			    			    	        {
                    			    			    	        	mID(); 

                    			    			    	        }
                    			    			    	        break;
                    			    			    	    case 3 :
                    			    			    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1364:131: ARRAY
                    			    			    	        {
                    			    			    	        	mARRAY(); 

                    			    			    	        }
                    			    			    	        break;

                    			    			    	}


                    			    			    }
                    			    			    break;

                    			    			default:
                    			    			    goto loop10;
                    			    	    }
                    			    	} while (true);

                    			    	loop10:
                    			    		;	// Stops C# compiler whining that label 'loop10' has no statements

                    			    	Match(']'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt11 >= 1 ) goto loop11;
                    		            EarlyExitException eee11 =
                    		                new EarlyExitException(11, input);
                    		            throw eee11;
                    	    }
                    	    cnt11++;
                    	} while (true);

                    	loop11:
                    		;	// Stops C# compiler whining that label 'loop11' has no statements


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1365:6: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )* ( '[' ']' )+
                    {
                    	if ( input.LA(1) == '&' || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1365:34: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )*
                    	do 
                    	{
                    	    int alt12 = 2;
                    	    int LA12_0 = input.LA(1);

                    	    if ( (LA12_0 == '.' || (LA12_0 >= '0' && LA12_0 <= '9') || (LA12_0 >= 'A' && LA12_0 <= 'Z') || LA12_0 == '_' || (LA12_0 >= 'a' && LA12_0 <= 'z')) )
                    	    {
                    	        alt12 = 1;
                    	    }


                    	    switch (alt12) 
                    		{
                    			case 1 :
                    			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:
                    			    {
                    			    	if ( input.LA(1) == '.' || (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
                    			    	{
                    			    	    input.Consume();

                    			    	}
                    			    	else 
                    			    	{
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop12;
                    	    }
                    	} while (true);

                    	loop12:
                    		;	// Stops C# compiler whining that label 'loop12' has no statements

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1365:72: ( '[' ']' )+
                    	int cnt13 = 0;
                    	do 
                    	{
                    	    int alt13 = 2;
                    	    int LA13_0 = input.LA(1);

                    	    if ( (LA13_0 == '[') )
                    	    {
                    	        alt13 = 1;
                    	    }


                    	    switch (alt13) 
                    		{
                    			case 1 :
                    			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1365:73: '[' ']'
                    			    {
                    			    	Match('['); 
                    			    	Match(']'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt13 >= 1 ) goto loop13;
                    		            EarlyExitException eee13 =
                    		                new EarlyExitException(13, input);
                    		            throw eee13;
                    	    }
                    	    cnt13++;
                    	} while (true);

                    	loop13:
                    		;	// Stops C# compiler whining that label 'loop13' has no statements


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ARRAY"

    // $ANTLR start "Keyword"
    public void mKeyword() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Keyword;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1372:9: ( '<stdio.h>' | '<conio.h>' | '<string.h>' )
            int alt15 = 3;
            int LA15_0 = input.LA(1);

            if ( (LA15_0 == '<') )
            {
                int LA15_1 = input.LA(2);

                if ( (LA15_1 == 's') )
                {
                    int LA15_2 = input.LA(3);

                    if ( (LA15_2 == 't') )
                    {
                        int LA15_4 = input.LA(4);

                        if ( (LA15_4 == 'd') )
                        {
                            alt15 = 1;
                        }
                        else if ( (LA15_4 == 'r') )
                        {
                            alt15 = 3;
                        }
                        else 
                        {
                            NoViableAltException nvae_d15s4 =
                                new NoViableAltException("", 15, 4, input);

                            throw nvae_d15s4;
                        }
                    }
                    else 
                    {
                        NoViableAltException nvae_d15s2 =
                            new NoViableAltException("", 15, 2, input);

                        throw nvae_d15s2;
                    }
                }
                else if ( (LA15_1 == 'c') )
                {
                    alt15 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d15s1 =
                        new NoViableAltException("", 15, 1, input);

                    throw nvae_d15s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d15s0 =
                    new NoViableAltException("", 15, 0, input);

                throw nvae_d15s0;
            }
            switch (alt15) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1373:4: '<stdio.h>'
                    {
                    	Match("<stdio.h>"); 


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1374:4: '<conio.h>'
                    {
                    	Match("<conio.h>"); 


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1375:4: '<string.h>'
                    {
                    	Match("<string.h>"); 


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Keyword"

    // $ANTLR start "INT"
    public void mINT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1378:5: ( ( '-' )? ( '0' .. '9' )+ )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1378:7: ( '-' )? ( '0' .. '9' )+
            {
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1378:7: ( '-' )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( (LA16_0 == '-') )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1378:8: '-'
            	        {
            	        	Match('-'); 

            	        }
            	        break;

            	}

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1378:13: ( '0' .. '9' )+
            	int cnt17 = 0;
            	do 
            	{
            	    int alt17 = 2;
            	    int LA17_0 = input.LA(1);

            	    if ( ((LA17_0 >= '0' && LA17_0 <= '9')) )
            	    {
            	        alt17 = 1;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1378:14: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt17 >= 1 ) goto loop17;
            		            EarlyExitException eee17 =
            		                new EarlyExitException(17, input);
            		            throw eee17;
            	    }
            	    cnt17++;
            	} while (true);

            	loop17:
            		;	// Stops C# compiler whining that label 'loop17' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INT"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1381:5: ( ( ' ' | '\\t' | '\\r' | '\\n' )+ )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1381:9: ( ' ' | '\\t' | '\\r' | '\\n' )+
            {
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1381:9: ( ' ' | '\\t' | '\\r' | '\\n' )+
            	int cnt18 = 0;
            	do 
            	{
            	    int alt18 = 2;
            	    int LA18_0 = input.LA(1);

            	    if ( ((LA18_0 >= '\t' && LA18_0 <= '\n') || LA18_0 == '\r' || LA18_0 == ' ') )
            	    {
            	        alt18 = 1;
            	    }


            	    switch (alt18) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:
            			    {
            			    	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ' ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt18 >= 1 ) goto loop18;
            		            EarlyExitException eee18 =
            		                new EarlyExitException(18, input);
            		            throw eee18;
            	    }
            	    cnt18++;
            	} while (true);

            	loop18:
            		;	// Stops C# compiler whining that label 'loop18' has no statements

            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    // $ANTLR start "CHARS"
    public void mCHARS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CHARS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1385:1: ( ( '#' | '$' | '<' | '>' | ',' | '{' | '}' | '(' | ')' | '/' | '*' | '[' | ']' ) ( '#' | '$' | '<' | '>' | '.' | ',' | '{' | '}' | '(' | ')' | '/' | '*' | '[' | ']' )* )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1386:1: ( '#' | '$' | '<' | '>' | ',' | '{' | '}' | '(' | ')' | '/' | '*' | '[' | ']' ) ( '#' | '$' | '<' | '>' | '.' | ',' | '{' | '}' | '(' | ')' | '/' | '*' | '[' | ']' )*
            {
            	if ( (input.LA(1) >= '#' && input.LA(1) <= '$') || (input.LA(1) >= '(' && input.LA(1) <= '*') || input.LA(1) == ',' || input.LA(1) == '/' || input.LA(1) == '<' || input.LA(1) == '>' || input.LA(1) == '[' || input.LA(1) == ']' || input.LA(1) == '{' || input.LA(1) == '}' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1386:55: ( '#' | '$' | '<' | '>' | '.' | ',' | '{' | '}' | '(' | ')' | '/' | '*' | '[' | ']' )*
            	do 
            	{
            	    int alt19 = 2;
            	    int LA19_0 = input.LA(1);

            	    if ( ((LA19_0 >= '#' && LA19_0 <= '$') || (LA19_0 >= '(' && LA19_0 <= '*') || LA19_0 == ',' || (LA19_0 >= '.' && LA19_0 <= '/') || LA19_0 == '<' || LA19_0 == '>' || LA19_0 == '[' || LA19_0 == ']' || LA19_0 == '{' || LA19_0 == '}') )
            	    {
            	        alt19 = 1;
            	    }


            	    switch (alt19) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:
            			    {
            			    	if ( (input.LA(1) >= '#' && input.LA(1) <= '$') || (input.LA(1) >= '(' && input.LA(1) <= '*') || input.LA(1) == ',' || (input.LA(1) >= '.' && input.LA(1) <= '/') || input.LA(1) == '<' || input.LA(1) == '>' || input.LA(1) == '[' || input.LA(1) == ']' || input.LA(1) == '{' || input.LA(1) == '}' ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop19;
            	    }
            	} while (true);

            	loop19:
            		;	// Stops C# compiler whining that label 'loop19' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CHARS"

    // $ANTLR start "LINE_COMMENT"
    public void mLINE_COMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LINE_COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1391:5: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1391:7: '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
            {
            	Match("//"); 

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1391:12: (~ ( '\\n' | '\\r' ) )*
            	do 
            	{
            	    int alt20 = 2;
            	    int LA20_0 = input.LA(1);

            	    if ( ((LA20_0 >= '\u0000' && LA20_0 <= '\t') || (LA20_0 >= '\u000B' && LA20_0 <= '\f') || (LA20_0 >= '\u000E' && LA20_0 <= '\uFFFF')) )
            	    {
            	        alt20 = 1;
            	    }


            	    switch (alt20) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1391:12: ~ ( '\\n' | '\\r' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop20;
            	    }
            	} while (true);

            	loop20:
            		;	// Stops C# compiler whining that label 'loop20' has no statements

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1391:26: ( '\\r' )?
            	int alt21 = 2;
            	int LA21_0 = input.LA(1);

            	if ( (LA21_0 == '\r') )
            	{
            	    alt21 = 1;
            	}
            	switch (alt21) 
            	{
            	    case 1 :
            	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1391:26: '\\r'
            	        {
            	        	Match('\r'); 

            	        }
            	        break;

            	}

            	Match('\n'); 
            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LINE_COMMENT"

    // $ANTLR start "COMMENT"
    public void mCOMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1396:5: ( '/*' ( options {greedy=false; } : . )* '*/' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1396:9: '/*' ( options {greedy=false; } : . )* '*/'
            {
            	Match("/*"); 

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1396:14: ( options {greedy=false; } : . )*
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);

            	    if ( (LA22_0 == '*') )
            	    {
            	        int LA22_1 = input.LA(2);

            	        if ( (LA22_1 == '/') )
            	        {
            	            alt22 = 2;
            	        }
            	        else if ( ((LA22_1 >= '\u0000' && LA22_1 <= '.') || (LA22_1 >= '0' && LA22_1 <= '\uFFFF')) )
            	        {
            	            alt22 = 1;
            	        }


            	    }
            	    else if ( ((LA22_0 >= '\u0000' && LA22_0 <= ')') || (LA22_0 >= '+' && LA22_0 <= '\uFFFF')) )
            	    {
            	        alt22 = 1;
            	    }


            	    switch (alt22) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1396:42: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop22;
            	    }
            	} while (true);

            	loop22:
            		;	// Stops C# compiler whining that label 'loop22' has no statements

            	Match("*/"); 

            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COMMENT"

    // $ANTLR start "PRINT"
    public void mPRINT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PRINT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1400:6: ( 'printf(' ( options {greedy=false; } : . )* ');' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1400:8: 'printf(' ( options {greedy=false; } : . )* ');'
            {
            	Match("printf("); 

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1400:18: ( options {greedy=false; } : . )*
            	do 
            	{
            	    int alt23 = 2;
            	    int LA23_0 = input.LA(1);

            	    if ( (LA23_0 == ')') )
            	    {
            	        int LA23_1 = input.LA(2);

            	        if ( (LA23_1 == ';') )
            	        {
            	            alt23 = 2;
            	        }
            	        else if ( ((LA23_1 >= '\u0000' && LA23_1 <= ':') || (LA23_1 >= '<' && LA23_1 <= '\uFFFF')) )
            	        {
            	            alt23 = 1;
            	        }


            	    }
            	    else if ( ((LA23_0 >= '\u0000' && LA23_0 <= '(') || (LA23_0 >= '*' && LA23_0 <= '\uFFFF')) )
            	    {
            	        alt23 = 1;
            	    }


            	    switch (alt23) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1400:46: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop23;
            	    }
            	} while (true);

            	loop23:
            		;	// Stops C# compiler whining that label 'loop23' has no statements

            	Match(");"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PRINT"

    // $ANTLR start "CHARACTER_LITERAL"
    public void mCHARACTER_LITERAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CHARACTER_LITERAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1404:5: ( '\\'' ( EscapeSequence | ~ ( '\\'' | '\\\\' ) ) '\\'' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1404:9: '\\'' ( EscapeSequence | ~ ( '\\'' | '\\\\' ) ) '\\''
            {
            	Match('\''); 
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1404:14: ( EscapeSequence | ~ ( '\\'' | '\\\\' ) )
            	int alt24 = 2;
            	int LA24_0 = input.LA(1);

            	if ( (LA24_0 == '\\') )
            	{
            	    alt24 = 1;
            	}
            	else if ( ((LA24_0 >= '\u0000' && LA24_0 <= '&') || (LA24_0 >= '(' && LA24_0 <= '[') || (LA24_0 >= ']' && LA24_0 <= '\uFFFF')) )
            	{
            	    alt24 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d24s0 =
            	        new NoViableAltException("", 24, 0, input);

            	    throw nvae_d24s0;
            	}
            	switch (alt24) 
            	{
            	    case 1 :
            	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1404:16: EscapeSequence
            	        {
            	        	mEscapeSequence(); 

            	        }
            	        break;
            	    case 2 :
            	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1404:33: ~ ( '\\'' | '\\\\' )
            	        {
            	        	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '&') || (input.LA(1) >= '(' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '\uFFFF') ) 
            	        	{
            	        	    input.Consume();

            	        	}
            	        	else 
            	        	{
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    Recover(mse);
            	        	    throw mse;}


            	        }
            	        break;

            	}

            	Match('\''); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CHARACTER_LITERAL"

    // $ANTLR start "STRING_LITERAL"
    public void mSTRING_LITERAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STRING_LITERAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1410:5: ( '\"' ( EscapeSequence | ~ ( '\\\\' | '\"' ) )* '\"' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1410:8: '\"' ( EscapeSequence | ~ ( '\\\\' | '\"' ) )* '\"'
            {
            	Match('\"'); 
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1410:12: ( EscapeSequence | ~ ( '\\\\' | '\"' ) )*
            	do 
            	{
            	    int alt25 = 3;
            	    int LA25_0 = input.LA(1);

            	    if ( (LA25_0 == '\\') )
            	    {
            	        alt25 = 1;
            	    }
            	    else if ( ((LA25_0 >= '\u0000' && LA25_0 <= '!') || (LA25_0 >= '#' && LA25_0 <= '[') || (LA25_0 >= ']' && LA25_0 <= '\uFFFF')) )
            	    {
            	        alt25 = 2;
            	    }


            	    switch (alt25) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1410:14: EscapeSequence
            			    {
            			    	mEscapeSequence(); 

            			    }
            			    break;
            			case 2 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1410:31: ~ ( '\\\\' | '\"' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop25;
            	    }
            	} while (true);

            	loop25:
            		;	// Stops C# compiler whining that label 'loop25' has no statements

            	Match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STRING_LITERAL"

    // $ANTLR start "EscapeSequence"
    public void mEscapeSequence() // throws RecognitionException [2]
    {
    		try
    		{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1416:5: ( '\\\\' ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' ) | OctalEscape )
            int alt26 = 2;
            int LA26_0 = input.LA(1);

            if ( (LA26_0 == '\\') )
            {
                int LA26_1 = input.LA(2);

                if ( (LA26_1 == '\"' || LA26_1 == '\'' || LA26_1 == '\\' || LA26_1 == 'b' || LA26_1 == 'f' || LA26_1 == 'n' || LA26_1 == 'r' || LA26_1 == 't') )
                {
                    alt26 = 1;
                }
                else if ( ((LA26_1 >= '0' && LA26_1 <= '7')) )
                {
                    alt26 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d26s1 =
                        new NoViableAltException("", 26, 1, input);

                    throw nvae_d26s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d26s0 =
                    new NoViableAltException("", 26, 0, input);

                throw nvae_d26s0;
            }
            switch (alt26) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1416:9: '\\\\' ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' )
                    {
                    	Match('\\'); 
                    	if ( input.LA(1) == '\"' || input.LA(1) == '\'' || input.LA(1) == '\\' || input.LA(1) == 'b' || input.LA(1) == 'f' || input.LA(1) == 'n' || input.LA(1) == 'r' || input.LA(1) == 't' ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1418:9: OctalEscape
                    {
                    	mOctalEscape(); 

                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EscapeSequence"

    // $ANTLR start "OctalEscape"
    public void mOctalEscape() // throws RecognitionException [2]
    {
    		try
    		{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1425:5: ( '\\\\' ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' ) | '\\\\' ( '0' .. '7' ) ( '0' .. '7' ) | '\\\\' ( '0' .. '7' ) )
            int alt27 = 3;
            int LA27_0 = input.LA(1);

            if ( (LA27_0 == '\\') )
            {
                int LA27_1 = input.LA(2);

                if ( ((LA27_1 >= '0' && LA27_1 <= '3')) )
                {
                    int LA27_2 = input.LA(3);

                    if ( ((LA27_2 >= '0' && LA27_2 <= '7')) )
                    {
                        int LA27_4 = input.LA(4);

                        if ( ((LA27_4 >= '0' && LA27_4 <= '7')) )
                        {
                            alt27 = 1;
                        }
                        else 
                        {
                            alt27 = 2;}
                    }
                    else 
                    {
                        alt27 = 3;}
                }
                else if ( ((LA27_1 >= '4' && LA27_1 <= '7')) )
                {
                    int LA27_3 = input.LA(3);

                    if ( ((LA27_3 >= '0' && LA27_3 <= '7')) )
                    {
                        alt27 = 2;
                    }
                    else 
                    {
                        alt27 = 3;}
                }
                else 
                {
                    NoViableAltException nvae_d27s1 =
                        new NoViableAltException("", 27, 1, input);

                    throw nvae_d27s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d27s0 =
                    new NoViableAltException("", 27, 0, input);

                throw nvae_d27s0;
            }
            switch (alt27) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1425:9: '\\\\' ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' )
                    {
                    	Match('\\'); 
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1425:14: ( '0' .. '3' )
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1425:15: '0' .. '3'
                    	{
                    		MatchRange('0','3'); 

                    	}

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1425:25: ( '0' .. '7' )
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1425:26: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1425:36: ( '0' .. '7' )
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1425:37: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1427:9: '\\\\' ( '0' .. '7' ) ( '0' .. '7' )
                    {
                    	Match('\\'); 
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1427:14: ( '0' .. '7' )
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1427:15: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1427:25: ( '0' .. '7' )
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1427:26: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1429:9: '\\\\' ( '0' .. '7' )
                    {
                    	Match('\\'); 
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1429:14: ( '0' .. '7' )
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1429:15: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}


                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OctalEscape"

    override public void mTokens() // throws RecognitionException 
    {
        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:8: ( T__19 | T__20 | T__21 | T__22 | T__23 | T__24 | T__25 | T__26 | T__27 | T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | MAINS | RWORD | ID | ARRAY | Keyword | INT | WS | CHARS | LINE_COMMENT | COMMENT | PRINT | CHARACTER_LITERAL | STRING_LITERAL )
        int alt28 = 71;
        alt28 = dfa28.Predict(input);
        switch (alt28) 
        {
            case 1 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:10: T__19
                {
                	mT__19(); 

                }
                break;
            case 2 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:16: T__20
                {
                	mT__20(); 

                }
                break;
            case 3 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:22: T__21
                {
                	mT__21(); 

                }
                break;
            case 4 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:28: T__22
                {
                	mT__22(); 

                }
                break;
            case 5 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:34: T__23
                {
                	mT__23(); 

                }
                break;
            case 6 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:40: T__24
                {
                	mT__24(); 

                }
                break;
            case 7 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:46: T__25
                {
                	mT__25(); 

                }
                break;
            case 8 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:52: T__26
                {
                	mT__26(); 

                }
                break;
            case 9 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:58: T__27
                {
                	mT__27(); 

                }
                break;
            case 10 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:64: T__28
                {
                	mT__28(); 

                }
                break;
            case 11 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:70: T__29
                {
                	mT__29(); 

                }
                break;
            case 12 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:76: T__30
                {
                	mT__30(); 

                }
                break;
            case 13 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:82: T__31
                {
                	mT__31(); 

                }
                break;
            case 14 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:88: T__32
                {
                	mT__32(); 

                }
                break;
            case 15 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:94: T__33
                {
                	mT__33(); 

                }
                break;
            case 16 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:100: T__34
                {
                	mT__34(); 

                }
                break;
            case 17 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:106: T__35
                {
                	mT__35(); 

                }
                break;
            case 18 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:112: T__36
                {
                	mT__36(); 

                }
                break;
            case 19 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:118: T__37
                {
                	mT__37(); 

                }
                break;
            case 20 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:124: T__38
                {
                	mT__38(); 

                }
                break;
            case 21 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:130: T__39
                {
                	mT__39(); 

                }
                break;
            case 22 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:136: T__40
                {
                	mT__40(); 

                }
                break;
            case 23 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:142: T__41
                {
                	mT__41(); 

                }
                break;
            case 24 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:148: T__42
                {
                	mT__42(); 

                }
                break;
            case 25 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:154: T__43
                {
                	mT__43(); 

                }
                break;
            case 26 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:160: T__44
                {
                	mT__44(); 

                }
                break;
            case 27 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:166: T__45
                {
                	mT__45(); 

                }
                break;
            case 28 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:172: T__46
                {
                	mT__46(); 

                }
                break;
            case 29 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:178: T__47
                {
                	mT__47(); 

                }
                break;
            case 30 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:184: T__48
                {
                	mT__48(); 

                }
                break;
            case 31 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:190: T__49
                {
                	mT__49(); 

                }
                break;
            case 32 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:196: T__50
                {
                	mT__50(); 

                }
                break;
            case 33 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:202: T__51
                {
                	mT__51(); 

                }
                break;
            case 34 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:208: T__52
                {
                	mT__52(); 

                }
                break;
            case 35 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:214: T__53
                {
                	mT__53(); 

                }
                break;
            case 36 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:220: T__54
                {
                	mT__54(); 

                }
                break;
            case 37 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:226: T__55
                {
                	mT__55(); 

                }
                break;
            case 38 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:232: T__56
                {
                	mT__56(); 

                }
                break;
            case 39 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:238: T__57
                {
                	mT__57(); 

                }
                break;
            case 40 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:244: T__58
                {
                	mT__58(); 

                }
                break;
            case 41 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:250: T__59
                {
                	mT__59(); 

                }
                break;
            case 42 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:256: T__60
                {
                	mT__60(); 

                }
                break;
            case 43 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:262: T__61
                {
                	mT__61(); 

                }
                break;
            case 44 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:268: T__62
                {
                	mT__62(); 

                }
                break;
            case 45 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:274: T__63
                {
                	mT__63(); 

                }
                break;
            case 46 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:280: T__64
                {
                	mT__64(); 

                }
                break;
            case 47 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:286: T__65
                {
                	mT__65(); 

                }
                break;
            case 48 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:292: T__66
                {
                	mT__66(); 

                }
                break;
            case 49 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:298: T__67
                {
                	mT__67(); 

                }
                break;
            case 50 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:304: T__68
                {
                	mT__68(); 

                }
                break;
            case 51 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:310: T__69
                {
                	mT__69(); 

                }
                break;
            case 52 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:316: T__70
                {
                	mT__70(); 

                }
                break;
            case 53 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:322: T__71
                {
                	mT__71(); 

                }
                break;
            case 54 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:328: T__72
                {
                	mT__72(); 

                }
                break;
            case 55 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:334: T__73
                {
                	mT__73(); 

                }
                break;
            case 56 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:340: T__74
                {
                	mT__74(); 

                }
                break;
            case 57 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:346: T__75
                {
                	mT__75(); 

                }
                break;
            case 58 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:352: T__76
                {
                	mT__76(); 

                }
                break;
            case 59 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:358: MAINS
                {
                	mMAINS(); 

                }
                break;
            case 60 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:364: RWORD
                {
                	mRWORD(); 

                }
                break;
            case 61 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:370: ID
                {
                	mID(); 

                }
                break;
            case 62 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:373: ARRAY
                {
                	mARRAY(); 

                }
                break;
            case 63 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:379: Keyword
                {
                	mKeyword(); 

                }
                break;
            case 64 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:387: INT
                {
                	mINT(); 

                }
                break;
            case 65 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:391: WS
                {
                	mWS(); 

                }
                break;
            case 66 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:394: CHARS
                {
                	mCHARS(); 

                }
                break;
            case 67 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:400: LINE_COMMENT
                {
                	mLINE_COMMENT(); 

                }
                break;
            case 68 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:413: COMMENT
                {
                	mCOMMENT(); 

                }
                break;
            case 69 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:421: PRINT
                {
                	mPRINT(); 

                }
                break;
            case 70 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:427: CHARACTER_LITERAL
                {
                	mCHARACTER_LITERAL(); 

                }
                break;
            case 71 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1:445: STRING_LITERAL
                {
                	mSTRING_LITERAL(); 

                }
                break;

        }

    }


    protected DFA4 dfa4;
    protected DFA14 dfa14;
    protected DFA6 dfa6;
    protected DFA9 dfa9;
    protected DFA28 dfa28;
	private void InitializeCyclicDFAs()
	{
	    this.dfa4 = new DFA4(this);
	    this.dfa14 = new DFA14(this);
	    this.dfa6 = new DFA6(this);
	    this.dfa9 = new DFA9(this);
	    this.dfa28 = new DFA28(this);
	    this.dfa28.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA28_SpecialStateTransition);
	}

    const string DFA4_eotS =
        "\x01\uffff\x02\x03\x02\uffff";
    const string DFA4_eofS =
        "\x05\uffff";
    const string DFA4_minS =
        "\x01\x26\x02\x2e\x02\uffff";
    const string DFA4_maxS =
        "\x03\x7a\x02\uffff";
    const string DFA4_acceptS =
        "\x03\uffff\x01\x01\x01\x02";
    const string DFA4_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA4_transitionS = {
            "\x01\x01\x1a\uffff\x1a\x01\x04\uffff\x01\x01\x01\uffff\x1a"+
            "\x01",
            "\x01\x02\x01\uffff\x0a\x02\x03\uffff\x01\x04\x03\uffff\x1a"+
            "\x02\x04\uffff\x01\x02\x01\uffff\x1a\x02",
            "\x01\x02\x01\uffff\x0a\x02\x03\uffff\x01\x04\x03\uffff\x1a"+
            "\x02\x04\uffff\x01\x02\x01\uffff\x1a\x02",
            "",
            ""
    };

    static readonly short[] DFA4_eot = DFA.UnpackEncodedString(DFA4_eotS);
    static readonly short[] DFA4_eof = DFA.UnpackEncodedString(DFA4_eofS);
    static readonly char[] DFA4_min = DFA.UnpackEncodedStringToUnsignedChars(DFA4_minS);
    static readonly char[] DFA4_max = DFA.UnpackEncodedStringToUnsignedChars(DFA4_maxS);
    static readonly short[] DFA4_accept = DFA.UnpackEncodedString(DFA4_acceptS);
    static readonly short[] DFA4_special = DFA.UnpackEncodedString(DFA4_specialS);
    static readonly short[][] DFA4_transition = DFA.UnpackEncodedStringArray(DFA4_transitionS);

    protected class DFA4 : DFA
    {
        public DFA4(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 4;
            this.eot = DFA4_eot;
            this.eof = DFA4_eof;
            this.min = DFA4_min;
            this.max = DFA4_max;
            this.accept = DFA4_accept;
            this.special = DFA4_special;
            this.transition = DFA4_transition;

        }

        override public string Description
        {
            get { return "1355:1: ID : ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )* | ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )* ( '=' ) ( ( INT )+ ) );"; }
        }

    }

    const string DFA14_eotS =
        "\x06\uffff";
    const string DFA14_eofS =
        "\x06\uffff";
    const string DFA14_minS =
        "\x01\x26\x02\x2e\x01\x26\x02\uffff";
    const string DFA14_maxS =
        "\x04\x7a\x02\uffff";
    const string DFA14_acceptS =
        "\x04\uffff\x01\x02\x01\x01";
    const string DFA14_specialS =
        "\x06\uffff}>";
    static readonly string[] DFA14_transitionS = {
            "\x01\x01\x1a\uffff\x1a\x01\x04\uffff\x01\x01\x01\uffff\x1a"+
            "\x01",
            "\x01\x02\x01\uffff\x0a\x02\x07\uffff\x1a\x02\x01\x03\x03\uffff"+
            "\x01\x02\x01\uffff\x1a\x02",
            "\x01\x02\x01\uffff\x0a\x02\x07\uffff\x1a\x02\x01\x03\x03\uffff"+
            "\x01\x02\x01\uffff\x1a\x02",
            "\x01\x05\x06\uffff\x01\x05\x02\uffff\x0a\x05\x07\uffff\x1a"+
            "\x05\x02\uffff\x01\x04\x01\uffff\x01\x05\x01\uffff\x1a\x05",
            "",
            ""
    };

    static readonly short[] DFA14_eot = DFA.UnpackEncodedString(DFA14_eotS);
    static readonly short[] DFA14_eof = DFA.UnpackEncodedString(DFA14_eofS);
    static readonly char[] DFA14_min = DFA.UnpackEncodedStringToUnsignedChars(DFA14_minS);
    static readonly char[] DFA14_max = DFA.UnpackEncodedStringToUnsignedChars(DFA14_maxS);
    static readonly short[] DFA14_accept = DFA.UnpackEncodedString(DFA14_acceptS);
    static readonly short[] DFA14_special = DFA.UnpackEncodedString(DFA14_specialS);
    static readonly short[][] DFA14_transition = DFA.UnpackEncodedStringArray(DFA14_transitionS);

    protected class DFA14 : DFA
    {
        public DFA14(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 14;
            this.eot = DFA14_eot;
            this.eof = DFA14_eof;
            this.min = DFA14_min;
            this.max = DFA14_max;
            this.accept = DFA14_accept;
            this.special = DFA14_special;
            this.transition = DFA14_transition;

        }

        override public string Description
        {
            get { return "1363:1: ARRAY : ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )* ( '[' ( INT | ID | ARRAY ) ( ( ' ' )* ( '+' | '-' | '/' | '*' ) ( ' ' )* ( INT | ID | ARRAY ) )* ']' )+ | ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )* ( '[' ']' )+ );"; }
        }

    }

    const string DFA6_eotS =
        "\x06\uffff";
    const string DFA6_eofS =
        "\x06\uffff";
    const string DFA6_minS =
        "\x01\x26\x01\uffff\x02\x20\x02\uffff";
    const string DFA6_maxS =
        "\x01\x7a\x01\uffff\x02\x7a\x02\uffff";
    const string DFA6_acceptS =
        "\x01\uffff\x01\x01\x02\uffff\x01\x03\x01\x02";
    const string DFA6_specialS =
        "\x06\uffff}>";
    static readonly string[] DFA6_transitionS = {
            "\x01\x02\x06\uffff\x01\x01\x02\uffff\x0a\x01\x07\uffff\x1a"+
            "\x02\x04\uffff\x01\x02\x01\uffff\x1a\x02",
            "",
            "\x01\x05\x09\uffff\x02\x05\x01\uffff\x01\x05\x01\x03\x01\x05"+
            "\x0a\x03\x03\uffff\x01\x05\x03\uffff\x1a\x03\x01\x04\x01\uffff"+
            "\x01\x05\x01\uffff\x01\x03\x01\uffff\x1a\x03",
            "\x01\x05\x09\uffff\x02\x05\x01\uffff\x01\x05\x01\x03\x01\x05"+
            "\x0a\x03\x03\uffff\x01\x05\x03\uffff\x1a\x03\x01\x04\x01\uffff"+
            "\x01\x05\x01\uffff\x01\x03\x01\uffff\x1a\x03",
            "",
            ""
    };

    static readonly short[] DFA6_eot = DFA.UnpackEncodedString(DFA6_eotS);
    static readonly short[] DFA6_eof = DFA.UnpackEncodedString(DFA6_eofS);
    static readonly char[] DFA6_min = DFA.UnpackEncodedStringToUnsignedChars(DFA6_minS);
    static readonly char[] DFA6_max = DFA.UnpackEncodedStringToUnsignedChars(DFA6_maxS);
    static readonly short[] DFA6_accept = DFA.UnpackEncodedString(DFA6_acceptS);
    static readonly short[] DFA6_special = DFA.UnpackEncodedString(DFA6_specialS);
    static readonly short[][] DFA6_transition = DFA.UnpackEncodedStringArray(DFA6_transitionS);

    protected class DFA6 : DFA
    {
        public DFA6(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 6;
            this.eot = DFA6_eot;
            this.eof = DFA6_eof;
            this.min = DFA6_min;
            this.max = DFA6_max;
            this.accept = DFA6_accept;
            this.special = DFA6_special;
            this.transition = DFA6_transition;

        }

        override public string Description
        {
            get { return "1364:75: ( INT | ID | ARRAY )"; }
        }

    }

    const string DFA9_eotS =
        "\x06\uffff";
    const string DFA9_eofS =
        "\x06\uffff";
    const string DFA9_minS =
        "\x01\x26\x01\uffff\x02\x20\x02\uffff";
    const string DFA9_maxS =
        "\x01\x7a\x01\uffff\x02\x7a\x02\uffff";
    const string DFA9_acceptS =
        "\x01\uffff\x01\x01\x02\uffff\x01\x03\x01\x02";
    const string DFA9_specialS =
        "\x06\uffff}>";
    static readonly string[] DFA9_transitionS = {
            "\x01\x02\x06\uffff\x01\x01\x02\uffff\x0a\x01\x07\uffff\x1a"+
            "\x02\x04\uffff\x01\x02\x01\uffff\x1a\x02",
            "",
            "\x01\x05\x09\uffff\x02\x05\x01\uffff\x01\x05\x01\x03\x01\x05"+
            "\x0a\x03\x03\uffff\x01\x05\x03\uffff\x1a\x03\x01\x04\x01\uffff"+
            "\x01\x05\x01\uffff\x01\x03\x01\uffff\x1a\x03",
            "\x01\x05\x09\uffff\x02\x05\x01\uffff\x01\x05\x01\x03\x01\x05"+
            "\x0a\x03\x03\uffff\x01\x05\x03\uffff\x1a\x03\x01\x04\x01\uffff"+
            "\x01\x05\x01\uffff\x01\x03\x01\uffff\x1a\x03",
            "",
            ""
    };

    static readonly short[] DFA9_eot = DFA.UnpackEncodedString(DFA9_eotS);
    static readonly short[] DFA9_eof = DFA.UnpackEncodedString(DFA9_eofS);
    static readonly char[] DFA9_min = DFA.UnpackEncodedStringToUnsignedChars(DFA9_minS);
    static readonly char[] DFA9_max = DFA.UnpackEncodedStringToUnsignedChars(DFA9_maxS);
    static readonly short[] DFA9_accept = DFA.UnpackEncodedString(DFA9_acceptS);
    static readonly short[] DFA9_special = DFA.UnpackEncodedString(DFA9_specialS);
    static readonly short[][] DFA9_transition = DFA.UnpackEncodedStringArray(DFA9_transitionS);

    protected class DFA9 : DFA
    {
        public DFA9(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 9;
            this.eot = DFA9_eot;
            this.eof = DFA9_eof;
            this.min = DFA9_min;
            this.max = DFA9_max;
            this.accept = DFA9_accept;
            this.special = DFA9_special;
            this.transition = DFA9_transition;

        }

        override public string Description
        {
            get { return "1364:123: ( INT | ID | ARRAY )"; }
        }

    }

    const string DFA28_eotS =
        "\x02\uffff\x01\x2c\x02\x31\x01\x35\x01\x37\x01\x38\x01\x3a\x01"+
        "\x3b\x01\x3c\x01\uffff\x01\x3f\x01\x42\x01\x45\x01\uffff\x06\x31"+
        "\x01\x28\x01\x54\x01\uffff\x03\x31\x01\uffff\x01\x5a\x01\x5c\x01"+
        "\x31\x01\uffff\x01\x5f\x04\x31\x05\uffff\x01\x64\x01\uffff\x01\x31"+
        "\x01\x66\x01\x31\x02\uffff\x02\x31\x02\uffff\x01\x69\x0c\uffff\x02"+
        "\x28\x01\uffff\x06\x31\x01\x76\x03\x31\x05\uffff\x03\x31\x06\uffff"+
        "\x01\x7e\x01\uffff\x03\x31\x02\uffff\x01\u0082\x01\uffff\x02\x31"+
        "\x01\uffff\x01\x28\x01\uffff\x02\x28\x01\uffff\x01\x31\x01\u0087"+
        "\x05\x31\x01\uffff\x03\x31\x01\uffff\x03\x31\x01\uffff\x03\x31\x01"+
        "\uffff\x01\u0097\x01\x31\x01\x28\x01\x31\x01\uffff\x01\x31\x01\u009b"+
        "\x01\x31\x01\u009d\x04\x31\x01\uffff\x02\x31\x01\u00a5\x02\x31\x01"+
        "\u00a8\x01\uffff\x01\x31\x01\u00aa\x01\x31\x01\uffff\x01\x31\x01"+
        "\uffff\x04\x31\x01\uffff\x01\x31\x01\u00b3\x01\uffff\x01\u00b4\x01"+
        "\x31\x01\uffff\x01\x31\x01\uffff\x01\x31\x01\u00b9\x01\u00ba\x01"+
        "\x31\x01\u00bc\x01\u00bd\x01\uffff\x01\u00bf\x02\uffff\x03\x31\x03"+
        "\uffff\x01\u00c3\x04\uffff\x01\u00c5\x01\x31\x05\uffff\x01\x31\x01"+
        "\uffff\x01\x31\x01\uffff\x01\x31\x01\uffff\x01\x31\x01\uffff\x01"+
        "\x31\x01\uffff\x01\u00d3\x05\uffff";
    const string DFA28_eofS =
        "\u00d7\uffff";
    const string DFA28_minS =
        "\x01\x09\x01\uffff\x01\x23\x02\x2e\x06\x23\x01\uffff\x01\x2b\x01"+
        "\x2d\x01\x23\x01\uffff\x06\x2e\x01\x64\x01\x3d\x01\uffff\x03\x2e"+
        "\x01\uffff\x02\x23\x01\x26\x01\uffff\x01\x23\x04\x2e\x05\uffff\x01"+
        "\x23\x01\uffff\x03\x2e\x02\uffff\x02\x2e\x02\uffff\x01\x23\x0c\uffff"+
        "\x02\x00\x01\uffff\x0a\x2e\x01\uffff\x01\x72\x03\uffff\x03\x2e\x06"+
        "\uffff\x01\x23\x01\uffff\x03\x2e\x02\uffff\x01\x2e\x01\uffff\x02"+
        "\x2e\x01\uffff\x01\x00\x01\uffff\x02\x00\x01\uffff\x07\x2e\x01\uffff"+
        "\x03\x2e\x01\x61\x03\x2e\x01\uffff\x03\x2e\x01\uffff\x02\x2e\x01"+
        "\x00\x01\x2e\x01\uffff\x08\x2e\x01\x67\x06\x2e\x01\uffff\x03\x2e"+
        "\x01\uffff\x01\x2e\x01\uffff\x04\x2e\x01\x6d\x02\x2e\x01\uffff\x02"+
        "\x2e\x01\uffff\x01\x2e\x01\uffff\x01\x2e\x01\x28\x04\x2e\x01\x61"+
        "\x01\x2e\x02\uffff\x01\x28\x01\x2e\x01\x28\x03\uffff\x01\x2e\x02"+
        "\uffff\x01\x20\x01\uffff\x01\x00\x01\x2e\x02\uffff\x01\x6b\x02\uffff"+
        "\x01\x2e\x01\x65\x01\x2e\x01\x72\x01\x2e\x01\x6e\x01\x2e\x01\x65"+
        "\x01\x2e\x01\x6c\x01\x2e\x01\x5f\x01\uffff\x01\x65\x02\uffff";
    const string DFA28_maxS =
        "\x01\x7d\x01\uffff\x01\x7d\x02\x7a\x06\x7d\x01\uffff\x02\x3d\x01"+
        "\x7d\x01\uffff\x06\x7a\x01\x70\x01\x3d\x01\uffff\x03\x7a\x01\uffff"+
        "\x02\x7d\x01\x7a\x01\uffff\x01\x7d\x04\x7a\x05\uffff\x01\x7d\x01"+
        "\uffff\x03\x7a\x02\uffff\x02\x7a\x02\uffff\x01\x7d\x0c\uffff\x02"+
        "\uffff\x01\uffff\x0a\x7a\x01\uffff\x01\x72\x03\uffff\x03\x7a\x06"+
        "\uffff\x01\x7d\x01\uffff\x03\x7a\x02\uffff\x01\x7a\x01\uffff\x02"+
        "\x7a\x01\uffff\x01\uffff\x01\uffff\x02\uffff\x01\uffff\x07\x7a\x01"+
        "\uffff\x03\x7a\x01\x61\x03\x7a\x01\uffff\x03\x7a\x01\uffff\x02\x7a"+
        "\x01\uffff\x01\x7a\x01\uffff\x08\x7a\x01\x67\x06\x7a\x01\uffff\x03"+
        "\x7a\x01\uffff\x01\x7a\x01\uffff\x04\x7a\x01\x6d\x02\x7a\x01\uffff"+
        "\x02\x7a\x01\uffff\x01\x7a\x01\uffff\x06\x7a\x01\x61\x01\x7a\x02"+
        "\uffff\x03\x7a\x03\uffff\x01\x7a\x02\uffff\x01\x20\x01\uffff\x01"+
        "\uffff\x01\x7a\x02\uffff\x01\x6b\x02\uffff\x01\x7a\x01\x65\x01\x7a"+
        "\x01\x72\x01\x7a\x01\x6e\x01\x7a\x01\x65\x01\x7a\x01\x6c\x01\x7a"+
        "\x01\x5f\x01\uffff\x01\x73\x02\uffff";
    const string DFA28_acceptS =
        "\x01\uffff\x01\x01\x09\uffff\x01\x0d\x03\uffff\x01\x11\x08\uffff"+
        "\x01\x20\x03\uffff\x01\x2b\x03\uffff\x01\x31\x05\uffff\x01\x40\x01"+
        "\x41\x01\x42\x01\x46\x01\x47\x01\uffff\x01\x03\x03\uffff\x01\x3e"+
        "\x01\x3d\x02\uffff\x01\x29\x01\x06\x01\uffff\x01\x32\x01\x08\x01"+
        "\x0c\x01\x09\x01\x0a\x01\x0b\x01\x1d\x01\x27\x01\x0e\x01\x1c\x01"+
        "\x28\x01\x0f\x02\uffff\x01\x10\x0a\uffff\x01\x19\x01\uffff\x01\x3c"+
        "\x01\x2a\x01\x1b\x03\uffff\x01\x2e\x01\x3f\x01\x2c\x01\x2f\x01\x2d"+
        "\x01\x30\x01\uffff\x01\x33\x03\uffff\x01\x35\x01\x02\x01\uffff\x01"+
        "\x24\x02\uffff\x01\x07\x01\uffff\x01\x43\x02\uffff\x01\x44\x07\uffff"+
        "\x01\x23\x07\uffff\x01\x3a\x03\uffff\x01\x04\x04\uffff\x01\x1a\x0f"+
        "\uffff\x01\x05\x03\uffff\x01\x13\x01\uffff\x01\x15\x07\uffff\x01"+
        "\x25\x02\uffff\x01\x3b\x01\uffff\x01\x12\x08\uffff\x01\x22\x01\x36"+
        "\x03\uffff\x01\x34\x01\x14\x01\x16\x01\uffff\x01\x18\x01\x26\x01"+
        "\uffff\x01\x21\x02\uffff\x01\x1e\x01\x1f\x01\uffff\x01\x39\x01\x45"+
        "\x0c\uffff\x01\x17\x01\uffff\x01\x37\x01\x38";
    const string DFA28_specialS =
        "\x43\uffff\x01\x04\x01\x05\x25\uffff\x01\x06\x01\uffff\x01\x01"+
        "\x01\x00\x17\uffff\x01\x03\x3a\uffff\x01\x02\x16\uffff}>";
    static readonly string[] DFA28_transitionS = {
            "\x02\x27\x02\uffff\x01\x27\x12\uffff\x01\x27\x01\x1c\x01\x2a"+
            "\x01\x16\x01\x28\x01\x0f\x01\x1f\x01\x29\x01\x02\x01\x08\x01"+
            "\x05\x01\x0c\x01\x07\x01\x0d\x01\x0b\x01\x0e\x0a\x26\x01\x18"+
            "\x01\x01\x01\x1d\x01\x17\x01\x1e\x02\uffff\x1a\x25\x01\x06\x01"+
            "\uffff\x01\x21\x01\uffff\x01\x25\x01\uffff\x01\x25\x01\x11\x01"+
            "\x04\x01\x14\x01\x1b\x01\x10\x02\x25\x01\x03\x01\x25\x01\x12"+
            "\x01\x22\x01\x24\x02\x25\x01\x23\x01\x25\x01\x19\x01\x15\x02"+
            "\x25\x01\x13\x01\x1a\x03\x25\x01\x09\x01\x20\x01\x0a",
            "",
            "\x02\x28\x03\uffff\x01\x28\x01\x2b\x01\x28\x01\uffff\x01\x28"+
            "\x01\uffff\x02\x28\x0c\uffff\x01\x28\x01\uffff\x01\x28\x1c\uffff"+
            "\x01\x28\x01\uffff\x01\x28\x1d\uffff\x01\x28\x01\uffff\x01\x28",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x05\x2f\x01\x2e\x07\x2f\x01\x2d\x0c\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x07\x2f\x01\x32\x0c\x2f\x01\x33\x05\x2f",
            "\x02\x28\x03\uffff\x03\x28\x01\uffff\x01\x28\x01\uffff\x02"+
            "\x28\x0c\uffff\x01\x28\x01\x34\x01\x28\x1c\uffff\x01\x28\x01"+
            "\uffff\x01\x28\x1d\uffff\x01\x28\x01\uffff\x01\x28",
            "\x02\x28\x03\uffff\x03\x28\x01\uffff\x01\x28\x01\uffff\x02"+
            "\x28\x0c\uffff\x01\x28\x01\uffff\x01\x28\x1c\uffff\x01\x28\x01"+
            "\uffff\x01\x36\x1d\uffff\x01\x28\x01\uffff\x01\x28",
            "\x02\x28\x03\uffff\x03\x28\x01\uffff\x01\x28\x01\uffff\x02"+
            "\x28\x0c\uffff\x01\x28\x01\uffff\x01\x28\x1c\uffff\x01\x28\x01"+
            "\uffff\x01\x28\x1d\uffff\x01\x28\x01\uffff\x01\x28",
            "\x02\x28\x03\uffff\x03\x28\x01\uffff\x01\x28\x01\uffff\x02"+
            "\x28\x0b\uffff\x01\x39\x01\x28\x01\uffff\x01\x28\x1c\uffff\x01"+
            "\x28\x01\uffff\x01\x28\x1d\uffff\x01\x28\x01\uffff\x01\x28",
            "\x02\x28\x03\uffff\x03\x28\x01\uffff\x01\x28\x01\uffff\x02"+
            "\x28\x0c\uffff\x01\x28\x01\uffff\x01\x28\x1c\uffff\x01\x28\x01"+
            "\uffff\x01\x28\x1d\uffff\x01\x28\x01\uffff\x01\x28",
            "\x02\x28\x03\uffff\x03\x28\x01\uffff\x01\x28\x01\uffff\x02"+
            "\x28\x0c\uffff\x01\x28\x01\uffff\x01\x28\x1c\uffff\x01\x28\x01"+
            "\uffff\x01\x28\x1d\uffff\x01\x28\x01\uffff\x01\x28",
            "",
            "\x01\x3e\x11\uffff\x01\x3d",
            "\x01\x41\x02\uffff\x0a\x26\x03\uffff\x01\x40",
            "\x02\x28\x03\uffff\x02\x28\x01\x44\x01\uffff\x01\x28\x01\uffff"+
            "\x01\x28\x01\x43\x0c\uffff\x01\x28\x01\uffff\x01\x28\x1c\uffff"+
            "\x01\x28\x01\uffff\x01\x28\x1d\uffff\x01\x28\x01\uffff\x01\x28",
            "",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x0b\x2f\x01\x46\x02\x2f\x01\x47\x01\x48\x0a"+
            "\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x0e\x2f\x01\x49\x0b\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x04\x2f\x01\x4a\x15\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x0e\x2f\x01\x4b\x0b\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x04\x2f\x01\x4d\x09\x2f\x01\x4c\x0b\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x08\x2f\x01\x4e\x0d\x2f\x01\x4f\x03\x2f",
            "\x01\x52\x04\uffff\x01\x50\x06\uffff\x01\x51",
            "\x01\x53",
            "",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x04\x2f\x01\x55\x15\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x07\x2f\x01\x56\x12\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x0b\x2f\x01\x57\x0e\x2f",
            "",
            "\x02\x28\x03\uffff\x03\x28\x01\uffff\x01\x28\x01\uffff\x02"+
            "\x28\x0c\uffff\x01\x28\x01\x58\x01\x28\x1c\uffff\x01\x28\x01"+
            "\uffff\x01\x28\x05\uffff\x01\x59\x0f\uffff\x01\x59\x07\uffff"+
            "\x01\x28\x01\uffff\x01\x28",
            "\x02\x28\x03\uffff\x03\x28\x01\uffff\x01\x28\x01\uffff\x02"+
            "\x28\x0c\uffff\x01\x28\x01\x5b\x01\x28\x1c\uffff\x01\x28\x01"+
            "\uffff\x01\x28\x1d\uffff\x01\x28\x01\uffff\x01\x28",
            "\x01\x5d\x07\uffff\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a"+
            "\x2f\x01\x30\x03\uffff\x01\x2f\x01\uffff\x1a\x2f",
            "",
            "\x02\x28\x03\uffff\x03\x28\x01\uffff\x01\x28\x01\uffff\x02"+
            "\x28\x0c\uffff\x01\x28\x01\uffff\x01\x28\x1c\uffff\x01\x28\x01"+
            "\uffff\x01\x5e\x1d\uffff\x01\x28\x01\uffff\x01\x28",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x0e\x2f\x01\x60\x0b\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x11\x2f\x01\x61\x08\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x01\x62\x19\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x1a\x2f",
            "",
            "",
            "",
            "",
            "",
            "\x02\x28\x03\uffff\x03\x28\x01\uffff\x01\x28\x01\uffff\x02"+
            "\x28\x0b\uffff\x01\x63\x01\x28\x01\uffff\x01\x28\x1c\uffff\x01"+
            "\x28\x01\uffff\x01\x28\x1d\uffff\x01\x28\x01\uffff\x01\x28",
            "",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x13\x2f\x01\x65\x06\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x03\uffff\x01\x31\x03\uffff\x1a"+
            "\x2f\x01\x30\x03\uffff\x01\x2f\x01\uffff\x1a\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x1a\x2f",
            "",
            "",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x01\x67\x19\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x03\x2f\x01\x68\x16\x2f",
            "",
            "",
            "\x02\x28\x03\uffff\x03\x28\x01\uffff\x01\x28\x01\uffff\x02"+
            "\x28\x0c\uffff\x01\x28\x01\uffff\x01\x28\x1c\uffff\x01\x28\x01"+
            "\uffff\x01\x28\x1d\uffff\x01\x28\x01\uffff\x01\x28",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x23\x6b\x02\x6a\x03\x6b\x03\x6a\x01\x6b\x01\x6a\x01\x6b\x02"+
            "\x6a\x0c\x6b\x01\x6a\x01\x6b\x01\x6a\x1c\x6b\x01\x6a\x01\x6b"+
            "\x01\x6a\x1d\x6b\x01\x6a\x01\x6b\x01\x6a\uff82\x6b",
            "\x23\x6e\x02\x6d\x03\x6e\x02\x6d\x01\x6c\x01\x6e\x01\x6d\x01"+
            "\x6e\x02\x6d\x0c\x6e\x01\x6d\x01\x6e\x01\x6d\x1c\x6e\x01\x6d"+
            "\x01\x6e\x01\x6d\x1d\x6e\x01\x6d\x01\x6e\x01\x6d\uff82\x6e",
            "",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x0e\x2f\x01\x6f\x0b\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x11\x2f\x01\x70\x08\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x11\x2f\x01\x71\x08\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x0e\x2f\x01\x72\x0b\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x11\x2f\x01\x73\x08\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x08\x2f\x01\x74\x11\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x03\uffff\x01\x31\x03\uffff\x1a"+
            "\x2f\x01\x30\x03\uffff\x01\x2f\x01\uffff\x14\x2f\x01\x75\x05"+
            "\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x05\x2f\x01\x77\x14\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x19\x2f\x01\x78",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x08\x2f\x01\x79\x11\x2f",
            "",
            "\x01\x7a",
            "",
            "",
            "",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x13\x2f\x01\x7b\x06\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x08\x2f\x01\x7c\x11\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x12\x2f\x01\x7d\x07\x2f",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x02\x28\x03\uffff\x03\x28\x01\uffff\x01\x28\x01\uffff\x02"+
            "\x28\x0c\uffff\x01\x28\x01\uffff\x01\x28\x1c\uffff\x01\x28\x01"+
            "\uffff\x01\x28\x1d\uffff\x01\x28\x01\uffff\x01\x28",
            "",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x02\x2f\x01\x7f\x17\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x08\x2f\x01\u0080\x11\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x08\x2f\x01\u0081\x11\x2f",
            "",
            "",
            "\x01\x2f\x01\uffff\x0a\x2f\x03\uffff\x01\x31\x03\uffff\x1a"+
            "\x2f\x01\x30\x03\uffff\x01\x2f\x01\uffff\x1a\x2f",
            "",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x11\x2f\x01\u0083\x08\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x01\u0084\x19\x2f",
            "",
            "\x23\x6b\x02\x6a\x03\x6b\x03\x6a\x01\x6b\x01\x6a\x01\x6b\x02"+
            "\x6a\x0c\x6b\x01\x6a\x01\x6b\x01\x6a\x1c\x6b\x01\x6a\x01\x6b"+
            "\x01\x6a\x1d\x6b\x01\x6a\x01\x6b\x01\x6a\uff82\x6b",
            "",
            "\x23\x6e\x02\x6d\x03\x6e\x02\x6d\x01\x6c\x01\x6e\x01\x6d\x01"+
            "\x6e\x01\x6d\x01\u0085\x0c\x6e\x01\x6d\x01\x6e\x01\x6d\x1c\x6e"+
            "\x01\x6d\x01\x6e\x01\x6d\x1d\x6e\x01\x6d\x01\x6e\x01\x6d\uff82"+
            "\x6e",
            "\x23\x6e\x02\x6d\x03\x6e\x02\x6d\x01\x6c\x01\x6e\x01\x6d\x01"+
            "\x6e\x02\x6d\x0c\x6e\x01\x6d\x01\x6e\x01\x6d\x1c\x6e\x01\x6d"+
            "\x01\x6e\x01\x6d\x1d\x6e\x01\x6d\x01\x6e\x01\x6d\uff82\x6e",
            "",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x01\u0086\x19\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x03\uffff\x01\x31\x03\uffff\x1a"+
            "\x2f\x01\x30\x03\uffff\x01\x2f\x01\uffff\x1a\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x08\x2f\x01\u0088\x11\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x0b\x2f\x01\u0089\x0e\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x0d\x2f\x01\u008a\x0c\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x03\x2f\x01\u008b\x16\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x01\x2f\x01\u008c\x18\x2f",
            "",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x01\u008d\x19\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x04\x2f\x01\u008e\x15\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x13\x2f\x01\u008f\x06\x2f",
            "\x01\u0090",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x14\x2f\x01\u0091\x05\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x0b\x2f\x01\u0092\x0e\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x04\x2f\x01\u0093\x15\x2f",
            "",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x01\u0094\x19\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x0d\x2f\x01\u0095\x0c\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x0d\x2f\x01\u0096\x0c\x2f",
            "",
            "\x01\x2f\x01\uffff\x0a\x2f\x03\uffff\x01\x31\x03\uffff\x1a"+
            "\x2f\x01\x30\x03\uffff\x01\x2f\x01\uffff\x1a\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x03\x2f\x01\u0098\x16"+
            "\x2f\x01\x30\x03\uffff\x01\x2f\x01\uffff\x1a\x2f",
            "\x23\x6e\x02\x6d\x03\x6e\x02\x6d\x01\x6c\x01\x6e\x01\x6d\x01"+
            "\x6e\x02\x6d\x0c\x6e\x01\x6d\x01\x6e\x01\x6d\x1c\x6e\x01\x6d"+
            "\x01\x6e\x01\x6d\x1d\x6e\x01\x6d\x01\x6e\x01\x6d\uff82\x6e",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x13\x2f\x01\u0099\x06\x2f",
            "",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x0d\x2f\x01\u009a\x0c\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x03\uffff\x01\x31\x03\uffff\x1a"+
            "\x2f\x01\x30\x03\uffff\x01\x2f\x01\uffff\x1a\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x04\x2f\x01\u009c\x15\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x03\uffff\x01\x31\x03\uffff\x1a"+
            "\x2f\x01\x30\x03\uffff\x01\x2f\x01\uffff\x1a\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x0b\x2f\x01\u009e\x0e\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x14\x2f\x01\u009f\x05\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\u00a0\x01\uffff\x1a\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x02\x2f\x01\u00a1\x17\x2f",
            "\x01\u00a2",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x11\x2f\x01\u00a3\x08\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x04\x2f\x01\u00a4\x15\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x03\uffff\x01\x31\x03\uffff\x1a"+
            "\x2f\x01\x30\x03\uffff\x01\x2f\x01\uffff\x1a\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x0b\x2f\x01\u00a6\x0e\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x13\x2f\x01\u00a7\x06\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x03\uffff\x01\x31\x03\uffff\x1a"+
            "\x2f\x01\x30\x03\uffff\x01\x2f\x01\uffff\x1a\x2f",
            "",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x04\x2f\x01\u00a9\x15\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x03\uffff\x01\x31\x03\uffff\x1a"+
            "\x2f\x01\x30\x03\uffff\x01\x2f\x01\uffff\x1a\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x13\x2f\x01\u00ab\x06\x2f",
            "",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x0b\x2f\x01\u00ac\x0e\x2f",
            "",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x04\x2f\x01\u00ad\x15\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x0b\x2f\x01\u00ae\x0e\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x13\x2f\x01\u00af\x06\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x07\x2f\x01\u00b0\x12\x2f",
            "\x01\u00b1",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x0d\x2f\x01\u00b2\x0c\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x03\uffff\x01\x31\x03\uffff\x1a"+
            "\x2f\x01\x30\x03\uffff\x01\x2f\x01\uffff\x1a\x2f",
            "",
            "\x01\x2f\x01\uffff\x0a\x2f\x03\uffff\x01\x31\x03\uffff\x1a"+
            "\x2f\x01\x30\x03\uffff\x01\x2f\x01\uffff\x1a\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x05\x2f\x01\u00b5\x14\x2f",
            "",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x15\x2f\x01\u00b6\x04\x2f",
            "",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x05\x2f\x01\u00b7\x14\x2f",
            "\x01\u00b8\x05\uffff\x01\x2f\x01\uffff\x0a\x2f\x03\uffff\x01"+
            "\x31\x03\uffff\x1a\x2f\x01\x30\x03\uffff\x01\x2f\x01\uffff\x1a"+
            "\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x03\uffff\x01\x31\x03\uffff\x1a"+
            "\x2f\x01\x30\x03\uffff\x01\x2f\x01\uffff\x1a\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x13\x2f\x01\u00bb\x06\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x03\uffff\x01\x31\x03\uffff\x1a"+
            "\x2f\x01\x30\x03\uffff\x01\x2f\x01\uffff\x1a\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x03\uffff\x01\x31\x03\uffff\x1a"+
            "\x2f\x01\x30\x03\uffff\x01\x2f\x01\uffff\x1a\x2f",
            "\x01\u00be",
            "\x01\x2f\x01\uffff\x0a\x2f\x03\uffff\x01\x31\x03\uffff\x1a"+
            "\x2f\x01\x30\x03\uffff\x01\x2f\x01\uffff\x1a\x2f",
            "",
            "",
            "\x01\u00c0\x05\uffff\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a"+
            "\x2f\x01\x30\x03\uffff\x01\x2f\x01\uffff\x1a\x2f",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x08\x2f\x01\u00c1\x11\x2f",
            "\x01\u00c2\x05\uffff\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a"+
            "\x2f\x01\x30\x03\uffff\x01\x2f\x01\uffff\x1a\x2f",
            "",
            "",
            "",
            "\x01\x2f\x01\uffff\x0a\x2f\x03\uffff\x01\x31\x03\uffff\x1a"+
            "\x2f\x01\x30\x03\uffff\x01\x2f\x01\uffff\x1a\x2f",
            "",
            "",
            "\x01\u00c4",
            "",
            "\x00\u00c6",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x02\x2f\x01\u00c7\x17\x2f",
            "",
            "",
            "\x01\u00c8",
            "",
            "",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x04\x2f\x01\u00c9\x15\x2f",
            "\x01\u00ca",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x0f\x2f\x01\u00cb\x0a"+
            "\x2f\x01\x30\x03\uffff\x01\x2f\x01\uffff\x1a\x2f",
            "\x01\u00cc",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x11\x2f\x01\u00cd\x08\x2f",
            "\x01\u00ce",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x0e\x2f\x01\u00cf\x0b\x2f",
            "\x01\u00d0",
            "\x01\x2f\x01\uffff\x0a\x2f\x07\uffff\x1a\x2f\x01\x30\x03\uffff"+
            "\x01\x2f\x01\uffff\x0f\x2f\x01\u00d1\x0a\x2f",
            "\x01\u00d2",
            "\x01\x2f\x01\uffff\x0a\x2f\x03\uffff\x01\x31\x03\uffff\x1a"+
            "\x2f\x01\x30\x03\uffff\x01\x2f\x01\uffff\x1a\x2f",
            "\x01\u00d4",
            "",
            "\x01\u00d6\x0d\uffff\x01\u00d5",
            "",
            ""
    };

    static readonly short[] DFA28_eot = DFA.UnpackEncodedString(DFA28_eotS);
    static readonly short[] DFA28_eof = DFA.UnpackEncodedString(DFA28_eofS);
    static readonly char[] DFA28_min = DFA.UnpackEncodedStringToUnsignedChars(DFA28_minS);
    static readonly char[] DFA28_max = DFA.UnpackEncodedStringToUnsignedChars(DFA28_maxS);
    static readonly short[] DFA28_accept = DFA.UnpackEncodedString(DFA28_acceptS);
    static readonly short[] DFA28_special = DFA.UnpackEncodedString(DFA28_specialS);
    static readonly short[][] DFA28_transition = DFA.UnpackEncodedStringArray(DFA28_transitionS);

    protected class DFA28 : DFA
    {
        public DFA28(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 28;
            this.eot = DFA28_eot;
            this.eof = DFA28_eof;
            this.min = DFA28_min;
            this.max = DFA28_max;
            this.accept = DFA28_accept;
            this.special = DFA28_special;
            this.transition = DFA28_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__19 | T__20 | T__21 | T__22 | T__23 | T__24 | T__25 | T__26 | T__27 | T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | MAINS | RWORD | ID | ARRAY | Keyword | INT | WS | CHARS | LINE_COMMENT | COMMENT | PRINT | CHARACTER_LITERAL | STRING_LITERAL );"; }
        }

    }


    protected internal int DFA28_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA28_109 = input.LA(1);

                   	s = -1;
                   	if ( (LA28_109 == '*') ) { s = 108; }

                   	else if ( ((LA28_109 >= '#' && LA28_109 <= '$') || (LA28_109 >= '(' && LA28_109 <= ')') || LA28_109 == ',' || (LA28_109 >= '.' && LA28_109 <= '/') || LA28_109 == '<' || LA28_109 == '>' || LA28_109 == '[' || LA28_109 == ']' || LA28_109 == '{' || LA28_109 == '}') ) { s = 109; }

                   	else if ( ((LA28_109 >= '\u0000' && LA28_109 <= '\"') || (LA28_109 >= '%' && LA28_109 <= '\'') || LA28_109 == '+' || LA28_109 == '-' || (LA28_109 >= '0' && LA28_109 <= ';') || LA28_109 == '=' || (LA28_109 >= '?' && LA28_109 <= 'Z') || LA28_109 == '\\' || (LA28_109 >= '^' && LA28_109 <= 'z') || LA28_109 == '|' || (LA28_109 >= '~' && LA28_109 <= '\uFFFF')) ) { s = 110; }

                   	else s = 40;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA28_108 = input.LA(1);

                   	s = -1;
                   	if ( (LA28_108 == '/') ) { s = 133; }

                   	else if ( (LA28_108 == '*') ) { s = 108; }

                   	else if ( ((LA28_108 >= '#' && LA28_108 <= '$') || (LA28_108 >= '(' && LA28_108 <= ')') || LA28_108 == ',' || LA28_108 == '.' || LA28_108 == '<' || LA28_108 == '>' || LA28_108 == '[' || LA28_108 == ']' || LA28_108 == '{' || LA28_108 == '}') ) { s = 109; }

                   	else if ( ((LA28_108 >= '\u0000' && LA28_108 <= '\"') || (LA28_108 >= '%' && LA28_108 <= '\'') || LA28_108 == '+' || LA28_108 == '-' || (LA28_108 >= '0' && LA28_108 <= ';') || LA28_108 == '=' || (LA28_108 >= '?' && LA28_108 <= 'Z') || LA28_108 == '\\' || (LA28_108 >= '^' && LA28_108 <= 'z') || LA28_108 == '|' || (LA28_108 >= '~' && LA28_108 <= '\uFFFF')) ) { s = 110; }

                   	else s = 40;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA28_192 = input.LA(1);

                   	s = -1;
                   	if ( ((LA28_192 >= '\u0000' && LA28_192 <= '\uFFFF')) ) { s = 198; }

                   	else s = 197;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA28_133 = input.LA(1);

                   	s = -1;
                   	if ( (LA28_133 == '*') ) { s = 108; }

                   	else if ( ((LA28_133 >= '#' && LA28_133 <= '$') || (LA28_133 >= '(' && LA28_133 <= ')') || LA28_133 == ',' || (LA28_133 >= '.' && LA28_133 <= '/') || LA28_133 == '<' || LA28_133 == '>' || LA28_133 == '[' || LA28_133 == ']' || LA28_133 == '{' || LA28_133 == '}') ) { s = 109; }

                   	else if ( ((LA28_133 >= '\u0000' && LA28_133 <= '\"') || (LA28_133 >= '%' && LA28_133 <= '\'') || LA28_133 == '+' || LA28_133 == '-' || (LA28_133 >= '0' && LA28_133 <= ';') || LA28_133 == '=' || (LA28_133 >= '?' && LA28_133 <= 'Z') || LA28_133 == '\\' || (LA28_133 >= '^' && LA28_133 <= 'z') || LA28_133 == '|' || (LA28_133 >= '~' && LA28_133 <= '\uFFFF')) ) { s = 110; }

                   	else s = 40;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA28_67 = input.LA(1);

                   	s = -1;
                   	if ( ((LA28_67 >= '#' && LA28_67 <= '$') || (LA28_67 >= '(' && LA28_67 <= '*') || LA28_67 == ',' || (LA28_67 >= '.' && LA28_67 <= '/') || LA28_67 == '<' || LA28_67 == '>' || LA28_67 == '[' || LA28_67 == ']' || LA28_67 == '{' || LA28_67 == '}') ) { s = 106; }

                   	else if ( ((LA28_67 >= '\u0000' && LA28_67 <= '\"') || (LA28_67 >= '%' && LA28_67 <= '\'') || LA28_67 == '+' || LA28_67 == '-' || (LA28_67 >= '0' && LA28_67 <= ';') || LA28_67 == '=' || (LA28_67 >= '?' && LA28_67 <= 'Z') || LA28_67 == '\\' || (LA28_67 >= '^' && LA28_67 <= 'z') || LA28_67 == '|' || (LA28_67 >= '~' && LA28_67 <= '\uFFFF')) ) { s = 107; }

                   	else s = 40;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA28_68 = input.LA(1);

                   	s = -1;
                   	if ( (LA28_68 == '*') ) { s = 108; }

                   	else if ( ((LA28_68 >= '#' && LA28_68 <= '$') || (LA28_68 >= '(' && LA28_68 <= ')') || LA28_68 == ',' || (LA28_68 >= '.' && LA28_68 <= '/') || LA28_68 == '<' || LA28_68 == '>' || LA28_68 == '[' || LA28_68 == ']' || LA28_68 == '{' || LA28_68 == '}') ) { s = 109; }

                   	else if ( ((LA28_68 >= '\u0000' && LA28_68 <= '\"') || (LA28_68 >= '%' && LA28_68 <= '\'') || LA28_68 == '+' || LA28_68 == '-' || (LA28_68 >= '0' && LA28_68 <= ';') || LA28_68 == '=' || (LA28_68 >= '?' && LA28_68 <= 'Z') || LA28_68 == '\\' || (LA28_68 >= '^' && LA28_68 <= 'z') || LA28_68 == '|' || (LA28_68 >= '~' && LA28_68 <= '\uFFFF')) ) { s = 110; }

                   	else s = 40;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA28_106 = input.LA(1);

                   	s = -1;
                   	if ( ((LA28_106 >= '\u0000' && LA28_106 <= '\"') || (LA28_106 >= '%' && LA28_106 <= '\'') || LA28_106 == '+' || LA28_106 == '-' || (LA28_106 >= '0' && LA28_106 <= ';') || LA28_106 == '=' || (LA28_106 >= '?' && LA28_106 <= 'Z') || LA28_106 == '\\' || (LA28_106 >= '^' && LA28_106 <= 'z') || LA28_106 == '|' || (LA28_106 >= '~' && LA28_106 <= '\uFFFF')) ) { s = 107; }

                   	else if ( ((LA28_106 >= '#' && LA28_106 <= '$') || (LA28_106 >= '(' && LA28_106 <= '*') || LA28_106 == ',' || (LA28_106 >= '.' && LA28_106 <= '/') || LA28_106 == '<' || LA28_106 == '>' || LA28_106 == '[' || LA28_106 == ']' || LA28_106 == '{' || LA28_106 == '}') ) { s = 106; }

                   	else s = 40;

                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae28 =
            new NoViableAltException(dfa.Description, 28, _s, input);
        dfa.Error(nvae28);
        throw nvae28;
    }
 
    
}
