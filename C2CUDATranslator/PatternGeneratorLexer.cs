// $ANTLR 3.2 Sep 23, 2009 12:02:23 Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g 2012-04-04 13:55:31

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class PatternGeneratorLexer : Lexer {
    public const int T__66 = 66;
    public const int T__64 = 64;
    public const int T__29 = 29;
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
    public const int STRING_LITERAL = 9;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int T__18 = 18;
    public const int T__53 = 53;
    public const int T__17 = 17;
    public const int T__54 = 54;
    public const int T__59 = 59;
    public const int COMMENT = 13;
    public const int T__50 = 50;
    public const int ARRAY = 7;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int T__40 = 40;
    public const int Keyword = 6;
    public const int T__41 = 41;
    public const int T__46 = 46;
    public const int T__47 = 47;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int LINE_COMMENT = 12;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int CHARACTER_LITERAL = 15;
    public const int INT = 5;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int T__33 = 33;
    public const int WS = 10;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int CHARS = 11;
    public const int EscapeSequence = 14;
    public const int OctalEscape = 16;

    // delegates
    // delegators

    public PatternGeneratorLexer() 
    {
		InitializeCyclicDFAs();
    }
    public PatternGeneratorLexer(ICharStream input)
		: this(input, null) {
    }
    public PatternGeneratorLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g";} 
    }

    // $ANTLR start "T__17"
    public void mT__17() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__17;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:7:7: ( ';' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:7:9: ';'
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
    // $ANTLR end "T__17"

    // $ANTLR start "T__18"
    public void mT__18() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__18;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:8:7: ( '.' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:8:9: '.'
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
    // $ANTLR end "T__18"

    // $ANTLR start "T__19"
    public void mT__19() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__19;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:9:7: ( 'kernel' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:9:9: 'kernel'
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
    // $ANTLR end "T__19"

    // $ANTLR start "T__20"
    public void mT__20() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__20;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:10:7: ( '(' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:10:9: '('
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
    // $ANTLR end "T__20"

    // $ANTLR start "T__21"
    public void mT__21() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__21;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:11:7: ( ',' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:11:9: ','
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
    // $ANTLR end "T__21"

    // $ANTLR start "T__22"
    public void mT__22() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__22;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:12:7: ( ')' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:12:9: ')'
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
    // $ANTLR end "T__22"

    // $ANTLR start "T__23"
    public void mT__23() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__23;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:13:7: ( 'int' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:13:9: 'int'
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
    // $ANTLR end "T__23"

    // $ANTLR start "T__24"
    public void mT__24() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__24;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:14:7: ( 'char' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:14:9: 'char'
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
    // $ANTLR end "T__24"

    // $ANTLR start "T__25"
    public void mT__25() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__25;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:15:7: ( 'float' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:15:9: 'float'
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
    // $ANTLR end "T__25"

    // $ANTLR start "T__26"
    public void mT__26() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__26;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:16:7: ( 'bool' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:16:9: 'bool'
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
    // $ANTLR end "T__26"

    // $ANTLR start "T__27"
    public void mT__27() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__27;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:17:7: ( 'void' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:17:9: 'void'
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
    // $ANTLR end "T__27"

    // $ANTLR start "T__28"
    public void mT__28() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__28;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:18:7: ( 'double' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:18:9: 'double'
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
    // $ANTLR end "T__28"

    // $ANTLR start "T__29"
    public void mT__29() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__29;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:19:7: ( 'size_t' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:19:9: 'size_t'
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
    // $ANTLR end "T__29"

    // $ANTLR start "T__30"
    public void mT__30() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__30;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:20:7: ( 'cudaDeviceProp' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:20:9: 'cudaDeviceProp'
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
    // $ANTLR end "T__30"

    // $ANTLR start "T__31"
    public void mT__31() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__31;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:21:7: ( '#include' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:21:9: '#include'
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
    // $ANTLR end "T__31"

    // $ANTLR start "T__32"
    public void mT__32() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__32;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:22:7: ( '__global__' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:22:9: '__global__'
            {
            	Match("__global__"); 


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
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:23:7: ( '__device__' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:23:9: '__device__'
            {
            	Match("__device__"); 


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
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:24:7: ( '__shared__' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:24:9: '__shared__'
            {
            	Match("__shared__"); 


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
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:25:7: ( '{' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:25:9: '{'
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
    // $ANTLR end "T__35"

    // $ANTLR start "T__36"
    public void mT__36() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__36;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:26:7: ( '}' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:26:9: '}'
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
    // $ANTLR end "T__36"

    // $ANTLR start "T__37"
    public void mT__37() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__37;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:27:7: ( '*' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:27:9: '*'
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
    // $ANTLR end "T__37"

    // $ANTLR start "T__38"
    public void mT__38() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__38;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:28:7: ( '=' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:28:9: '='
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
    // $ANTLR end "T__38"

    // $ANTLR start "T__39"
    public void mT__39() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__39;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:29:7: ( '+' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:29:9: '+'
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
    // $ANTLR end "T__39"

    // $ANTLR start "T__40"
    public void mT__40() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__40;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:30:7: ( 'for' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:30:9: 'for'
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
    // $ANTLR end "T__40"

    // $ANTLR start "T__41"
    public void mT__41() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__41;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:31:7: ( '-=' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:31:9: '-='
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
    // $ANTLR end "T__41"

    // $ANTLR start "T__42"
    public void mT__42() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__42;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:32:7: ( '+=' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:32:9: '+='
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
    // $ANTLR end "T__42"

    // $ANTLR start "T__43"
    public void mT__43() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__43;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:33:7: ( 'printf(' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:33:9: 'printf('
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
    // $ANTLR end "T__43"

    // $ANTLR start "T__44"
    public void mT__44() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__44;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:34:7: ( 'fprintf(' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:34:9: 'fprintf('
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
    // $ANTLR end "T__44"

    // $ANTLR start "T__45"
    public void mT__45() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__45;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:35:7: ( 'default' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:35:9: 'default'
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
    // $ANTLR end "T__45"

    // $ANTLR start "T__46"
    public void mT__46() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__46;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:36:7: ( ':' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:36:9: ':'
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
    // $ANTLR end "T__46"

    // $ANTLR start "T__47"
    public void mT__47() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__47;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:37:7: ( 'return' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:37:9: 'return'
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
    // $ANTLR end "T__47"

    // $ANTLR start "T__48"
    public void mT__48() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__48;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:38:7: ( 'while' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:38:9: 'while'
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
    // $ANTLR end "T__48"

    // $ANTLR start "T__49"
    public void mT__49() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__49;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:39:7: ( 'if' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:39:9: 'if'
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
    // $ANTLR end "T__49"

    // $ANTLR start "T__50"
    public void mT__50() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__50;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:40:7: ( 'else' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:40:9: 'else'
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
    // $ANTLR end "T__50"

    // $ANTLR start "T__51"
    public void mT__51() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__51;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:41:7: ( '++' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:41:9: '++'
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
    // $ANTLR end "T__51"

    // $ANTLR start "T__52"
    public void mT__52() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__52;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:42:7: ( '--' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:42:9: '--'
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
    // $ANTLR end "T__52"

    // $ANTLR start "T__53"
    public void mT__53() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__53;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:43:7: ( '*=' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:43:9: '*='
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
    // $ANTLR end "T__53"

    // $ANTLR start "T__54"
    public void mT__54() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__54;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:44:7: ( '==' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:44:9: '=='
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
    // $ANTLR end "T__54"

    // $ANTLR start "T__55"
    public void mT__55() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__55;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:45:7: ( '!=' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:45:9: '!='
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
    // $ANTLR end "T__55"

    // $ANTLR start "T__56"
    public void mT__56() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__56;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:46:7: ( '<' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:46:9: '<'
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
    // $ANTLR end "T__56"

    // $ANTLR start "T__57"
    public void mT__57() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__57;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:47:7: ( '>' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:47:9: '>'
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
    // $ANTLR end "T__57"

    // $ANTLR start "T__58"
    public void mT__58() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__58;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:48:7: ( '<=' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:48:9: '<='
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
    // $ANTLR end "T__58"

    // $ANTLR start "T__59"
    public void mT__59() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__59;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:49:7: ( '>=' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:49:9: '>='
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
    // $ANTLR end "T__59"

    // $ANTLR start "T__60"
    public void mT__60() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__60;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:50:7: ( '&&' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:50:9: '&&'
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
    // $ANTLR end "T__60"

    // $ANTLR start "T__61"
    public void mT__61() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__61;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:51:7: ( '||' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:51:9: '||'
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
    // $ANTLR end "T__61"

    // $ANTLR start "T__62"
    public void mT__62() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__62;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:52:7: ( '-' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:52:9: '-'
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
    // $ANTLR end "T__62"

    // $ANTLR start "T__63"
    public void mT__63() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__63;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:53:7: ( '/' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:53:9: '/'
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
    // $ANTLR end "T__63"

    // $ANTLR start "T__64"
    public void mT__64() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__64;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:54:7: ( '%' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:54:9: '%'
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
    // $ANTLR end "T__64"

    // $ANTLR start "T__65"
    public void mT__65() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__65;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:55:7: ( '[' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:55:9: '['
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
    // $ANTLR end "T__65"

    // $ANTLR start "T__66"
    public void mT__66() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__66;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:56:7: ( ']' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:56:9: ']'
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
    // $ANTLR end "T__66"

    // $ANTLR start "RWORD"
    public void mRWORD() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RWORD;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:377:7: ( '#define' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:378:2: '#define'
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
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:381:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' | '*' | '**' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )* | ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' | '*' | '**' ) ( ( ',' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' ) ) | ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' | '*' | '**' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )* ( '=' ) ( ( INT )+ ) )
            int alt7 = 3;
            alt7 = dfa7.Predict(input);
            switch (alt7) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:381:9: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' | '*' | '**' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )*
                    {
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:381:9: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' | '*' | '**' )
                    	int alt1 = 6;
                    	switch ( input.LA(1) ) 
                    	{
                    	case 'a':
                    	case 'b':
                    	case 'c':
                    	case 'd':
                    	case 'e':
                    	case 'f':
                    	case 'g':
                    	case 'h':
                    	case 'i':
                    	case 'j':
                    	case 'k':
                    	case 'l':
                    	case 'm':
                    	case 'n':
                    	case 'o':
                    	case 'p':
                    	case 'q':
                    	case 'r':
                    	case 's':
                    	case 't':
                    	case 'u':
                    	case 'v':
                    	case 'w':
                    	case 'x':
                    	case 'y':
                    	case 'z':
                    		{
                    	    alt1 = 1;
                    	    }
                    	    break;
                    	case 'A':
                    	case 'B':
                    	case 'C':
                    	case 'D':
                    	case 'E':
                    	case 'F':
                    	case 'G':
                    	case 'H':
                    	case 'I':
                    	case 'J':
                    	case 'K':
                    	case 'L':
                    	case 'M':
                    	case 'N':
                    	case 'O':
                    	case 'P':
                    	case 'Q':
                    	case 'R':
                    	case 'S':
                    	case 'T':
                    	case 'U':
                    	case 'V':
                    	case 'W':
                    	case 'X':
                    	case 'Y':
                    	case 'Z':
                    		{
                    	    alt1 = 2;
                    	    }
                    	    break;
                    	case '_':
                    		{
                    	    alt1 = 3;
                    	    }
                    	    break;
                    	case '&':
                    		{
                    	    alt1 = 4;
                    	    }
                    	    break;
                    	case '*':
                    		{
                    	    int LA1_5 = input.LA(2);

                    	    if ( (LA1_5 == '*') )
                    	    {
                    	        alt1 = 6;
                    	    }
                    	    else 
                    	    {
                    	        alt1 = 5;}
                    	    }
                    	    break;
                    		default:
                    		    NoViableAltException nvae_d1s0 =
                    		        new NoViableAltException("", 1, 0, input);

                    		    throw nvae_d1s0;
                    	}

                    	switch (alt1) 
                    	{
                    	    case 1 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:381:10: 'a' .. 'z'
                    	        {
                    	        	MatchRange('a','z'); 

                    	        }
                    	        break;
                    	    case 2 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:381:19: 'A' .. 'Z'
                    	        {
                    	        	MatchRange('A','Z'); 

                    	        }
                    	        break;
                    	    case 3 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:381:28: '_'
                    	        {
                    	        	Match('_'); 

                    	        }
                    	        break;
                    	    case 4 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:381:32: '&'
                    	        {
                    	        	Match('&'); 

                    	        }
                    	        break;
                    	    case 5 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:381:36: '*'
                    	        {
                    	        	Match('*'); 

                    	        }
                    	        break;
                    	    case 6 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:381:40: '**'
                    	        {
                    	        	Match("**"); 


                    	        }
                    	        break;

                    	}

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:381:46: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )*
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
                    			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:
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


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:382:3: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' | '*' | '**' ) ( ( ',' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' ) )
                    {
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:382:3: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' | '*' | '**' )
                    	int alt3 = 6;
                    	switch ( input.LA(1) ) 
                    	{
                    	case 'a':
                    	case 'b':
                    	case 'c':
                    	case 'd':
                    	case 'e':
                    	case 'f':
                    	case 'g':
                    	case 'h':
                    	case 'i':
                    	case 'j':
                    	case 'k':
                    	case 'l':
                    	case 'm':
                    	case 'n':
                    	case 'o':
                    	case 'p':
                    	case 'q':
                    	case 'r':
                    	case 's':
                    	case 't':
                    	case 'u':
                    	case 'v':
                    	case 'w':
                    	case 'x':
                    	case 'y':
                    	case 'z':
                    		{
                    	    alt3 = 1;
                    	    }
                    	    break;
                    	case 'A':
                    	case 'B':
                    	case 'C':
                    	case 'D':
                    	case 'E':
                    	case 'F':
                    	case 'G':
                    	case 'H':
                    	case 'I':
                    	case 'J':
                    	case 'K':
                    	case 'L':
                    	case 'M':
                    	case 'N':
                    	case 'O':
                    	case 'P':
                    	case 'Q':
                    	case 'R':
                    	case 'S':
                    	case 'T':
                    	case 'U':
                    	case 'V':
                    	case 'W':
                    	case 'X':
                    	case 'Y':
                    	case 'Z':
                    		{
                    	    alt3 = 2;
                    	    }
                    	    break;
                    	case '_':
                    		{
                    	    alt3 = 3;
                    	    }
                    	    break;
                    	case '&':
                    		{
                    	    alt3 = 4;
                    	    }
                    	    break;
                    	case '*':
                    		{
                    	    int LA3_5 = input.LA(2);

                    	    if ( (LA3_5 == '*') )
                    	    {
                    	        alt3 = 6;
                    	    }
                    	    else if ( (LA3_5 == ',') )
                    	    {
                    	        alt3 = 5;
                    	    }
                    	    else 
                    	    {
                    	        NoViableAltException nvae_d3s5 =
                    	            new NoViableAltException("", 3, 5, input);

                    	        throw nvae_d3s5;
                    	    }
                    	    }
                    	    break;
                    		default:
                    		    NoViableAltException nvae_d3s0 =
                    		        new NoViableAltException("", 3, 0, input);

                    		    throw nvae_d3s0;
                    	}

                    	switch (alt3) 
                    	{
                    	    case 1 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:382:4: 'a' .. 'z'
                    	        {
                    	        	MatchRange('a','z'); 

                    	        }
                    	        break;
                    	    case 2 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:382:13: 'A' .. 'Z'
                    	        {
                    	        	MatchRange('A','Z'); 

                    	        }
                    	        break;
                    	    case 3 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:382:22: '_'
                    	        {
                    	        	Match('_'); 

                    	        }
                    	        break;
                    	    case 4 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:382:26: '&'
                    	        {
                    	        	Match('&'); 

                    	        }
                    	        break;
                    	    case 5 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:382:30: '*'
                    	        {
                    	        	Match('*'); 

                    	        }
                    	        break;
                    	    case 6 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:382:34: '**'
                    	        {
                    	        	Match("**"); 


                    	        }
                    	        break;

                    	}

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:382:40: ( ( ',' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' ) )
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:382:41: ( ',' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )
                    	{
                    		// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:382:41: ( ',' )
                    		// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:382:42: ','
                    		{
                    			Match(','); 

                    		}

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


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:383:3: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' | '*' | '**' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )* ( '=' ) ( ( INT )+ )
                    {
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:383:3: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' | '*' | '**' )
                    	int alt4 = 6;
                    	switch ( input.LA(1) ) 
                    	{
                    	case 'a':
                    	case 'b':
                    	case 'c':
                    	case 'd':
                    	case 'e':
                    	case 'f':
                    	case 'g':
                    	case 'h':
                    	case 'i':
                    	case 'j':
                    	case 'k':
                    	case 'l':
                    	case 'm':
                    	case 'n':
                    	case 'o':
                    	case 'p':
                    	case 'q':
                    	case 'r':
                    	case 's':
                    	case 't':
                    	case 'u':
                    	case 'v':
                    	case 'w':
                    	case 'x':
                    	case 'y':
                    	case 'z':
                    		{
                    	    alt4 = 1;
                    	    }
                    	    break;
                    	case 'A':
                    	case 'B':
                    	case 'C':
                    	case 'D':
                    	case 'E':
                    	case 'F':
                    	case 'G':
                    	case 'H':
                    	case 'I':
                    	case 'J':
                    	case 'K':
                    	case 'L':
                    	case 'M':
                    	case 'N':
                    	case 'O':
                    	case 'P':
                    	case 'Q':
                    	case 'R':
                    	case 'S':
                    	case 'T':
                    	case 'U':
                    	case 'V':
                    	case 'W':
                    	case 'X':
                    	case 'Y':
                    	case 'Z':
                    		{
                    	    alt4 = 2;
                    	    }
                    	    break;
                    	case '_':
                    		{
                    	    alt4 = 3;
                    	    }
                    	    break;
                    	case '&':
                    		{
                    	    alt4 = 4;
                    	    }
                    	    break;
                    	case '*':
                    		{
                    	    int LA4_5 = input.LA(2);

                    	    if ( (LA4_5 == '*') )
                    	    {
                    	        alt4 = 6;
                    	    }
                    	    else if ( (LA4_5 == '.' || (LA4_5 >= '0' && LA4_5 <= '9') || LA4_5 == '=' || (LA4_5 >= 'A' && LA4_5 <= 'Z') || LA4_5 == '_' || (LA4_5 >= 'a' && LA4_5 <= 'z')) )
                    	    {
                    	        alt4 = 5;
                    	    }
                    	    else 
                    	    {
                    	        NoViableAltException nvae_d4s5 =
                    	            new NoViableAltException("", 4, 5, input);

                    	        throw nvae_d4s5;
                    	    }
                    	    }
                    	    break;
                    		default:
                    		    NoViableAltException nvae_d4s0 =
                    		        new NoViableAltException("", 4, 0, input);

                    		    throw nvae_d4s0;
                    	}

                    	switch (alt4) 
                    	{
                    	    case 1 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:383:4: 'a' .. 'z'
                    	        {
                    	        	MatchRange('a','z'); 

                    	        }
                    	        break;
                    	    case 2 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:383:13: 'A' .. 'Z'
                    	        {
                    	        	MatchRange('A','Z'); 

                    	        }
                    	        break;
                    	    case 3 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:383:22: '_'
                    	        {
                    	        	Match('_'); 

                    	        }
                    	        break;
                    	    case 4 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:383:26: '&'
                    	        {
                    	        	Match('&'); 

                    	        }
                    	        break;
                    	    case 5 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:383:30: '*'
                    	        {
                    	        	Match('*'); 

                    	        }
                    	        break;
                    	    case 6 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:383:34: '**'
                    	        {
                    	        	Match("**"); 


                    	        }
                    	        break;

                    	}

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:383:40: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )*
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
                    			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:
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

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:383:78: ( '=' )
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:383:79: '='
                    	{
                    		Match('='); 

                    	}

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:383:84: ( ( INT )+ )
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:383:85: ( INT )+
                    	{
                    		// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:383:85: ( INT )+
                    		int cnt6 = 0;
                    		do 
                    		{
                    		    int alt6 = 2;
                    		    int LA6_0 = input.LA(1);

                    		    if ( (LA6_0 == '-' || (LA6_0 >= '0' && LA6_0 <= '9')) )
                    		    {
                    		        alt6 = 1;
                    		    }


                    		    switch (alt6) 
                    			{
                    				case 1 :
                    				    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:383:86: INT
                    				    {
                    				    	mINT(); 

                    				    }
                    				    break;

                    				default:
                    				    if ( cnt6 >= 1 ) goto loop6;
                    			            EarlyExitException eee6 =
                    			                new EarlyExitException(6, input);
                    			            throw eee6;
                    		    }
                    		    cnt6++;
                    		} while (true);

                    		loop6:
                    			;	// Stops C# compiler whining that label 'loop6' has no statements


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
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:387:7: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' | '*' | '**' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )* ( '[' ( ( INT ) | ID ) ']' )+ | ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' | '*' | '**' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )* '[' ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* ( '[' ( ( INT ) | ID ) ']' ) ']' | ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )* ( '[' ( ' ' )* ( ARRAY | INT | ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* ) ) ( ' ' )* ( '+' | '-' | '/' | '*' ) ( ' ' )* ( ARRAY | INT | ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* ) ) ( ' ' )* ']' ) )
            int alt25 = 3;
            alt25 = dfa25.Predict(input);
            switch (alt25) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:388:4: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' | '*' | '**' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )* ( '[' ( ( INT ) | ID ) ']' )+
                    {
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:388:4: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' | '*' | '**' )
                    	int alt8 = 6;
                    	switch ( input.LA(1) ) 
                    	{
                    	case 'a':
                    	case 'b':
                    	case 'c':
                    	case 'd':
                    	case 'e':
                    	case 'f':
                    	case 'g':
                    	case 'h':
                    	case 'i':
                    	case 'j':
                    	case 'k':
                    	case 'l':
                    	case 'm':
                    	case 'n':
                    	case 'o':
                    	case 'p':
                    	case 'q':
                    	case 'r':
                    	case 's':
                    	case 't':
                    	case 'u':
                    	case 'v':
                    	case 'w':
                    	case 'x':
                    	case 'y':
                    	case 'z':
                    		{
                    	    alt8 = 1;
                    	    }
                    	    break;
                    	case 'A':
                    	case 'B':
                    	case 'C':
                    	case 'D':
                    	case 'E':
                    	case 'F':
                    	case 'G':
                    	case 'H':
                    	case 'I':
                    	case 'J':
                    	case 'K':
                    	case 'L':
                    	case 'M':
                    	case 'N':
                    	case 'O':
                    	case 'P':
                    	case 'Q':
                    	case 'R':
                    	case 'S':
                    	case 'T':
                    	case 'U':
                    	case 'V':
                    	case 'W':
                    	case 'X':
                    	case 'Y':
                    	case 'Z':
                    		{
                    	    alt8 = 2;
                    	    }
                    	    break;
                    	case '_':
                    		{
                    	    alt8 = 3;
                    	    }
                    	    break;
                    	case '&':
                    		{
                    	    alt8 = 4;
                    	    }
                    	    break;
                    	case '*':
                    		{
                    	    int LA8_5 = input.LA(2);

                    	    if ( (LA8_5 == '*') )
                    	    {
                    	        alt8 = 6;
                    	    }
                    	    else if ( (LA8_5 == '.' || (LA8_5 >= '0' && LA8_5 <= '9') || (LA8_5 >= 'A' && LA8_5 <= '[') || LA8_5 == '_' || (LA8_5 >= 'a' && LA8_5 <= 'z')) )
                    	    {
                    	        alt8 = 5;
                    	    }
                    	    else 
                    	    {
                    	        NoViableAltException nvae_d8s5 =
                    	            new NoViableAltException("", 8, 5, input);

                    	        throw nvae_d8s5;
                    	    }
                    	    }
                    	    break;
                    		default:
                    		    NoViableAltException nvae_d8s0 =
                    		        new NoViableAltException("", 8, 0, input);

                    		    throw nvae_d8s0;
                    	}

                    	switch (alt8) 
                    	{
                    	    case 1 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:388:5: 'a' .. 'z'
                    	        {
                    	        	MatchRange('a','z'); 

                    	        }
                    	        break;
                    	    case 2 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:388:14: 'A' .. 'Z'
                    	        {
                    	        	MatchRange('A','Z'); 

                    	        }
                    	        break;
                    	    case 3 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:388:23: '_'
                    	        {
                    	        	Match('_'); 

                    	        }
                    	        break;
                    	    case 4 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:388:27: '&'
                    	        {
                    	        	Match('&'); 

                    	        }
                    	        break;
                    	    case 5 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:388:31: '*'
                    	        {
                    	        	Match('*'); 

                    	        }
                    	        break;
                    	    case 6 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:388:35: '**'
                    	        {
                    	        	Match("**"); 


                    	        }
                    	        break;

                    	}

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:388:41: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )*
                    	do 
                    	{
                    	    int alt9 = 2;
                    	    int LA9_0 = input.LA(1);

                    	    if ( (LA9_0 == '.' || (LA9_0 >= '0' && LA9_0 <= '9') || (LA9_0 >= 'A' && LA9_0 <= 'Z') || LA9_0 == '_' || (LA9_0 >= 'a' && LA9_0 <= 'z')) )
                    	    {
                    	        alt9 = 1;
                    	    }


                    	    switch (alt9) 
                    		{
                    			case 1 :
                    			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:
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
                    			    goto loop9;
                    	    }
                    	} while (true);

                    	loop9:
                    		;	// Stops C# compiler whining that label 'loop9' has no statements

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:388:79: ( '[' ( ( INT ) | ID ) ']' )+
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
                    			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:388:80: '[' ( ( INT ) | ID ) ']'
                    			    {
                    			    	Match('['); 
                    			    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:388:83: ( ( INT ) | ID )
                    			    	int alt10 = 2;
                    			    	int LA10_0 = input.LA(1);

                    			    	if ( (LA10_0 == '-' || (LA10_0 >= '0' && LA10_0 <= '9')) )
                    			    	{
                    			    	    alt10 = 1;
                    			    	}
                    			    	else if ( (LA10_0 == '&' || LA10_0 == '*' || (LA10_0 >= 'A' && LA10_0 <= 'Z') || LA10_0 == '_' || (LA10_0 >= 'a' && LA10_0 <= 'z')) )
                    			    	{
                    			    	    alt10 = 2;
                    			    	}
                    			    	else 
                    			    	{
                    			    	    NoViableAltException nvae_d10s0 =
                    			    	        new NoViableAltException("", 10, 0, input);

                    			    	    throw nvae_d10s0;
                    			    	}
                    			    	switch (alt10) 
                    			    	{
                    			    	    case 1 :
                    			    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:388:84: ( INT )
                    			    	        {
                    			    	        	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:388:84: ( INT )
                    			    	        	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:388:85: INT
                    			    	        	{
                    			    	        		mINT(); 

                    			    	        	}


                    			    	        }
                    			    	        break;
                    			    	    case 2 :
                    			    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:388:90: ID
                    			    	        {
                    			    	        	mID(); 

                    			    	        }
                    			    	        break;

                    			    	}

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
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:389:4: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' | '*' | '**' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )* '[' ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* ( '[' ( ( INT ) | ID ) ']' ) ']'
                    {
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:389:4: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' | '*' | '**' )
                    	int alt12 = 6;
                    	switch ( input.LA(1) ) 
                    	{
                    	case 'a':
                    	case 'b':
                    	case 'c':
                    	case 'd':
                    	case 'e':
                    	case 'f':
                    	case 'g':
                    	case 'h':
                    	case 'i':
                    	case 'j':
                    	case 'k':
                    	case 'l':
                    	case 'm':
                    	case 'n':
                    	case 'o':
                    	case 'p':
                    	case 'q':
                    	case 'r':
                    	case 's':
                    	case 't':
                    	case 'u':
                    	case 'v':
                    	case 'w':
                    	case 'x':
                    	case 'y':
                    	case 'z':
                    		{
                    	    alt12 = 1;
                    	    }
                    	    break;
                    	case 'A':
                    	case 'B':
                    	case 'C':
                    	case 'D':
                    	case 'E':
                    	case 'F':
                    	case 'G':
                    	case 'H':
                    	case 'I':
                    	case 'J':
                    	case 'K':
                    	case 'L':
                    	case 'M':
                    	case 'N':
                    	case 'O':
                    	case 'P':
                    	case 'Q':
                    	case 'R':
                    	case 'S':
                    	case 'T':
                    	case 'U':
                    	case 'V':
                    	case 'W':
                    	case 'X':
                    	case 'Y':
                    	case 'Z':
                    		{
                    	    alt12 = 2;
                    	    }
                    	    break;
                    	case '_':
                    		{
                    	    alt12 = 3;
                    	    }
                    	    break;
                    	case '&':
                    		{
                    	    alt12 = 4;
                    	    }
                    	    break;
                    	case '*':
                    		{
                    	    int LA12_5 = input.LA(2);

                    	    if ( (LA12_5 == '*') )
                    	    {
                    	        alt12 = 6;
                    	    }
                    	    else if ( (LA12_5 == '.' || (LA12_5 >= '0' && LA12_5 <= '9') || (LA12_5 >= 'A' && LA12_5 <= '[') || LA12_5 == '_' || (LA12_5 >= 'a' && LA12_5 <= 'z')) )
                    	    {
                    	        alt12 = 5;
                    	    }
                    	    else 
                    	    {
                    	        NoViableAltException nvae_d12s5 =
                    	            new NoViableAltException("", 12, 5, input);

                    	        throw nvae_d12s5;
                    	    }
                    	    }
                    	    break;
                    		default:
                    		    NoViableAltException nvae_d12s0 =
                    		        new NoViableAltException("", 12, 0, input);

                    		    throw nvae_d12s0;
                    	}

                    	switch (alt12) 
                    	{
                    	    case 1 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:389:5: 'a' .. 'z'
                    	        {
                    	        	MatchRange('a','z'); 

                    	        }
                    	        break;
                    	    case 2 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:389:14: 'A' .. 'Z'
                    	        {
                    	        	MatchRange('A','Z'); 

                    	        }
                    	        break;
                    	    case 3 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:389:23: '_'
                    	        {
                    	        	Match('_'); 

                    	        }
                    	        break;
                    	    case 4 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:389:27: '&'
                    	        {
                    	        	Match('&'); 

                    	        }
                    	        break;
                    	    case 5 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:389:31: '*'
                    	        {
                    	        	Match('*'); 

                    	        }
                    	        break;
                    	    case 6 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:389:35: '**'
                    	        {
                    	        	Match("**"); 


                    	        }
                    	        break;

                    	}

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:389:41: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )*
                    	do 
                    	{
                    	    int alt13 = 2;
                    	    int LA13_0 = input.LA(1);

                    	    if ( (LA13_0 == '.' || (LA13_0 >= '0' && LA13_0 <= '9') || (LA13_0 >= 'A' && LA13_0 <= 'Z') || LA13_0 == '_' || (LA13_0 >= 'a' && LA13_0 <= 'z')) )
                    	    {
                    	        alt13 = 1;
                    	    }


                    	    switch (alt13) 
                    		{
                    			case 1 :
                    			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:
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
                    			    goto loop13;
                    	    }
                    	} while (true);

                    	loop13:
                    		;	// Stops C# compiler whining that label 'loop13' has no statements

                    	Match('['); 
                    	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:389:107: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
                    	do 
                    	{
                    	    int alt14 = 2;
                    	    int LA14_0 = input.LA(1);

                    	    if ( ((LA14_0 >= '0' && LA14_0 <= '9') || (LA14_0 >= 'A' && LA14_0 <= 'Z') || LA14_0 == '_' || (LA14_0 >= 'a' && LA14_0 <= 'z')) )
                    	    {
                    	        alt14 = 1;
                    	    }


                    	    switch (alt14) 
                    		{
                    			case 1 :
                    			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:
                    			    {
                    			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
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
                    			    goto loop14;
                    	    }
                    	} while (true);

                    	loop14:
                    		;	// Stops C# compiler whining that label 'loop14' has no statements

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:389:141: ( '[' ( ( INT ) | ID ) ']' )
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:389:142: '[' ( ( INT ) | ID ) ']'
                    	{
                    		Match('['); 
                    		// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:389:145: ( ( INT ) | ID )
                    		int alt15 = 2;
                    		int LA15_0 = input.LA(1);

                    		if ( (LA15_0 == '-' || (LA15_0 >= '0' && LA15_0 <= '9')) )
                    		{
                    		    alt15 = 1;
                    		}
                    		else if ( (LA15_0 == '&' || LA15_0 == '*' || (LA15_0 >= 'A' && LA15_0 <= 'Z') || LA15_0 == '_' || (LA15_0 >= 'a' && LA15_0 <= 'z')) )
                    		{
                    		    alt15 = 2;
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
                    		        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:389:146: ( INT )
                    		        {
                    		        	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:389:146: ( INT )
                    		        	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:389:147: INT
                    		        	{
                    		        		mINT(); 

                    		        	}


                    		        }
                    		        break;
                    		    case 2 :
                    		        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:389:152: ID
                    		        {
                    		        	mID(); 

                    		        }
                    		        break;

                    		}

                    		Match(']'); 

                    	}

                    	Match(']'); 

                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:390:11: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )* ( '[' ( ' ' )* ( ARRAY | INT | ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* ) ) ( ' ' )* ( '+' | '-' | '/' | '*' ) ( ' ' )* ( ARRAY | INT | ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* ) ) ( ' ' )* ']' )
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

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:390:39: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )*
                    	do 
                    	{
                    	    int alt16 = 2;
                    	    int LA16_0 = input.LA(1);

                    	    if ( (LA16_0 == '.' || (LA16_0 >= '0' && LA16_0 <= '9') || (LA16_0 >= 'A' && LA16_0 <= 'Z') || LA16_0 == '_' || (LA16_0 >= 'a' && LA16_0 <= 'z')) )
                    	    {
                    	        alt16 = 1;
                    	    }


                    	    switch (alt16) 
                    		{
                    			case 1 :
                    			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:
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
                    			    goto loop16;
                    	    }
                    	} while (true);

                    	loop16:
                    		;	// Stops C# compiler whining that label 'loop16' has no statements

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:390:77: ( '[' ( ' ' )* ( ARRAY | INT | ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* ) ) ( ' ' )* ( '+' | '-' | '/' | '*' ) ( ' ' )* ( ARRAY | INT | ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* ) ) ( ' ' )* ']' )
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:390:78: '[' ( ' ' )* ( ARRAY | INT | ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* ) ) ( ' ' )* ( '+' | '-' | '/' | '*' ) ( ' ' )* ( ARRAY | INT | ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* ) ) ( ' ' )* ']'
                    	{
                    		Match('['); 
                    		// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:390:82: ( ' ' )*
                    		do 
                    		{
                    		    int alt17 = 2;
                    		    int LA17_0 = input.LA(1);

                    		    if ( (LA17_0 == ' ') )
                    		    {
                    		        alt17 = 1;
                    		    }


                    		    switch (alt17) 
                    			{
                    				case 1 :
                    				    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:390:83: ' '
                    				    {
                    				    	Match(' '); 

                    				    }
                    				    break;

                    				default:
                    				    goto loop17;
                    		    }
                    		} while (true);

                    		loop17:
                    			;	// Stops C# compiler whining that label 'loop17' has no statements

                    		// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:390:89: ( ARRAY | INT | ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* ) )
                    		int alt19 = 3;
                    		alt19 = dfa19.Predict(input);
                    		switch (alt19) 
                    		{
                    		    case 1 :
                    		        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:390:90: ARRAY
                    		        {
                    		        	mARRAY(); 

                    		        }
                    		        break;
                    		    case 2 :
                    		        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:390:96: INT
                    		        {
                    		        	mINT(); 

                    		        }
                    		        break;
                    		    case 3 :
                    		        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:390:100: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* )
                    		        {
                    		        	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:390:100: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* )
                    		        	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:390:101: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
                    		        	{
                    		        		if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
                    		        		{
                    		        		    input.Consume();

                    		        		}
                    		        		else 
                    		        		{
                    		        		    MismatchedSetException mse = new MismatchedSetException(null,input);
                    		        		    Recover(mse);
                    		        		    throw mse;}

                    		        		// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:390:125: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
                    		        		do 
                    		        		{
                    		        		    int alt18 = 2;
                    		        		    int LA18_0 = input.LA(1);

                    		        		    if ( ((LA18_0 >= '0' && LA18_0 <= '9') || (LA18_0 >= 'A' && LA18_0 <= 'Z') || LA18_0 == '_' || (LA18_0 >= 'a' && LA18_0 <= 'z')) )
                    		        		    {
                    		        		        alt18 = 1;
                    		        		    }


                    		        		    switch (alt18) 
                    		        			{
                    		        				case 1 :
                    		        				    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:
                    		        				    {
                    		        				    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
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
                    		        				    goto loop18;
                    		        		    }
                    		        		} while (true);

                    		        		loop18:
                    		        			;	// Stops C# compiler whining that label 'loop18' has no statements


                    		        	}


                    		        }
                    		        break;

                    		}

                    		// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:390:161: ( ' ' )*
                    		do 
                    		{
                    		    int alt20 = 2;
                    		    int LA20_0 = input.LA(1);

                    		    if ( (LA20_0 == ' ') )
                    		    {
                    		        alt20 = 1;
                    		    }


                    		    switch (alt20) 
                    			{
                    				case 1 :
                    				    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:390:162: ' '
                    				    {
                    				    	Match(' '); 

                    				    }
                    				    break;

                    				default:
                    				    goto loop20;
                    		    }
                    		} while (true);

                    		loop20:
                    			;	// Stops C# compiler whining that label 'loop20' has no statements

                    		if ( (input.LA(1) >= '*' && input.LA(1) <= '+') || input.LA(1) == '-' || input.LA(1) == '/' ) 
                    		{
                    		    input.Consume();

                    		}
                    		else 
                    		{
                    		    MismatchedSetException mse = new MismatchedSetException(null,input);
                    		    Recover(mse);
                    		    throw mse;}

                    		// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:390:186: ( ' ' )*
                    		do 
                    		{
                    		    int alt21 = 2;
                    		    int LA21_0 = input.LA(1);

                    		    if ( (LA21_0 == ' ') )
                    		    {
                    		        alt21 = 1;
                    		    }


                    		    switch (alt21) 
                    			{
                    				case 1 :
                    				    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:390:187: ' '
                    				    {
                    				    	Match(' '); 

                    				    }
                    				    break;

                    				default:
                    				    goto loop21;
                    		    }
                    		} while (true);

                    		loop21:
                    			;	// Stops C# compiler whining that label 'loop21' has no statements

                    		// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:390:193: ( ARRAY | INT | ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* ) )
                    		int alt23 = 3;
                    		alt23 = dfa23.Predict(input);
                    		switch (alt23) 
                    		{
                    		    case 1 :
                    		        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:390:194: ARRAY
                    		        {
                    		        	mARRAY(); 

                    		        }
                    		        break;
                    		    case 2 :
                    		        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:390:200: INT
                    		        {
                    		        	mINT(); 

                    		        }
                    		        break;
                    		    case 3 :
                    		        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:390:204: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* )
                    		        {
                    		        	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:390:204: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* )
                    		        	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:390:205: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
                    		        	{
                    		        		if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
                    		        		{
                    		        		    input.Consume();

                    		        		}
                    		        		else 
                    		        		{
                    		        		    MismatchedSetException mse = new MismatchedSetException(null,input);
                    		        		    Recover(mse);
                    		        		    throw mse;}

                    		        		// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:390:229: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
                    		        		do 
                    		        		{
                    		        		    int alt22 = 2;
                    		        		    int LA22_0 = input.LA(1);

                    		        		    if ( ((LA22_0 >= '0' && LA22_0 <= '9') || (LA22_0 >= 'A' && LA22_0 <= 'Z') || LA22_0 == '_' || (LA22_0 >= 'a' && LA22_0 <= 'z')) )
                    		        		    {
                    		        		        alt22 = 1;
                    		        		    }


                    		        		    switch (alt22) 
                    		        			{
                    		        				case 1 :
                    		        				    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:
                    		        				    {
                    		        				    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
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
                    		        				    goto loop22;
                    		        		    }
                    		        		} while (true);

                    		        		loop22:
                    		        			;	// Stops C# compiler whining that label 'loop22' has no statements


                    		        	}


                    		        }
                    		        break;

                    		}

                    		// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:390:265: ( ' ' )*
                    		do 
                    		{
                    		    int alt24 = 2;
                    		    int LA24_0 = input.LA(1);

                    		    if ( (LA24_0 == ' ') )
                    		    {
                    		        alt24 = 1;
                    		    }


                    		    switch (alt24) 
                    			{
                    				case 1 :
                    				    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:390:266: ' '
                    				    {
                    				    	Match(' '); 

                    				    }
                    				    break;

                    				default:
                    				    goto loop24;
                    		    }
                    		} while (true);

                    		loop24:
                    			;	// Stops C# compiler whining that label 'loop24' has no statements

                    		Match(']'); 

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
    // $ANTLR end "ARRAY"

    // $ANTLR start "Keyword"
    public void mKeyword() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Keyword;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:395:9: ( '<stdio.h>' | '<conio.h>' )
            int alt26 = 2;
            int LA26_0 = input.LA(1);

            if ( (LA26_0 == '<') )
            {
                int LA26_1 = input.LA(2);

                if ( (LA26_1 == 's') )
                {
                    alt26 = 1;
                }
                else if ( (LA26_1 == 'c') )
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
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:396:4: '<stdio.h>'
                    {
                    	Match("<stdio.h>"); 


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:397:4: '<conio.h>'
                    {
                    	Match("<conio.h>"); 


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
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:400:5: ( ( '-' )? ( '0' .. '9' )+ )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:400:7: ( '-' )? ( '0' .. '9' )+
            {
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:400:7: ( '-' )?
            	int alt27 = 2;
            	int LA27_0 = input.LA(1);

            	if ( (LA27_0 == '-') )
            	{
            	    alt27 = 1;
            	}
            	switch (alt27) 
            	{
            	    case 1 :
            	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:400:8: '-'
            	        {
            	        	Match('-'); 

            	        }
            	        break;

            	}

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:400:13: ( '0' .. '9' )+
            	int cnt28 = 0;
            	do 
            	{
            	    int alt28 = 2;
            	    int LA28_0 = input.LA(1);

            	    if ( ((LA28_0 >= '0' && LA28_0 <= '9')) )
            	    {
            	        alt28 = 1;
            	    }


            	    switch (alt28) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:400:14: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt28 >= 1 ) goto loop28;
            		            EarlyExitException eee28 =
            		                new EarlyExitException(28, input);
            		            throw eee28;
            	    }
            	    cnt28++;
            	} while (true);

            	loop28:
            		;	// Stops C# compiler whining that label 'loop28' has no statements


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
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:403:5: ( ( ' ' | '\\t' | '\\r' | '\\n' )+ )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:403:9: ( ' ' | '\\t' | '\\r' | '\\n' )+
            {
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:403:9: ( ' ' | '\\t' | '\\r' | '\\n' )+
            	int cnt29 = 0;
            	do 
            	{
            	    int alt29 = 2;
            	    int LA29_0 = input.LA(1);

            	    if ( ((LA29_0 >= '\t' && LA29_0 <= '\n') || LA29_0 == '\r' || LA29_0 == ' ') )
            	    {
            	        alt29 = 1;
            	    }


            	    switch (alt29) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:
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
            			    if ( cnt29 >= 1 ) goto loop29;
            		            EarlyExitException eee29 =
            		                new EarlyExitException(29, input);
            		            throw eee29;
            	    }
            	    cnt29++;
            	} while (true);

            	loop29:
            		;	// Stops C# compiler whining that label 'loop29' has no statements

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
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:407:1: ( ( '#' | '$' | '<' | '>' | ',' | '{' | '}' | '(' | ')' | '/' | '*' | '[' | ']' ) ( '#' | '$' | '<' | '>' | '.' | ',' | '{' | '}' | '(' | ')' | '/' | '*' | '[' | ']' )* )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:408:1: ( '#' | '$' | '<' | '>' | ',' | '{' | '}' | '(' | ')' | '/' | '*' | '[' | ']' ) ( '#' | '$' | '<' | '>' | '.' | ',' | '{' | '}' | '(' | ')' | '/' | '*' | '[' | ']' )*
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

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:408:55: ( '#' | '$' | '<' | '>' | '.' | ',' | '{' | '}' | '(' | ')' | '/' | '*' | '[' | ']' )*
            	do 
            	{
            	    int alt30 = 2;
            	    int LA30_0 = input.LA(1);

            	    if ( ((LA30_0 >= '#' && LA30_0 <= '$') || (LA30_0 >= '(' && LA30_0 <= '*') || LA30_0 == ',' || (LA30_0 >= '.' && LA30_0 <= '/') || LA30_0 == '<' || LA30_0 == '>' || LA30_0 == '[' || LA30_0 == ']' || LA30_0 == '{' || LA30_0 == '}') )
            	    {
            	        alt30 = 1;
            	    }


            	    switch (alt30) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:
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
            			    goto loop30;
            	    }
            	} while (true);

            	loop30:
            		;	// Stops C# compiler whining that label 'loop30' has no statements


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
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:413:5: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:413:7: '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
            {
            	Match("//"); 

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:413:12: (~ ( '\\n' | '\\r' ) )*
            	do 
            	{
            	    int alt31 = 2;
            	    int LA31_0 = input.LA(1);

            	    if ( ((LA31_0 >= '\u0000' && LA31_0 <= '\t') || (LA31_0 >= '\u000B' && LA31_0 <= '\f') || (LA31_0 >= '\u000E' && LA31_0 <= '\uFFFF')) )
            	    {
            	        alt31 = 1;
            	    }


            	    switch (alt31) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:413:12: ~ ( '\\n' | '\\r' )
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
            			    goto loop31;
            	    }
            	} while (true);

            	loop31:
            		;	// Stops C# compiler whining that label 'loop31' has no statements

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:413:26: ( '\\r' )?
            	int alt32 = 2;
            	int LA32_0 = input.LA(1);

            	if ( (LA32_0 == '\r') )
            	{
            	    alt32 = 1;
            	}
            	switch (alt32) 
            	{
            	    case 1 :
            	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:413:26: '\\r'
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
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:418:5: ( '/*' ( options {greedy=false; } : . )* '*/' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:418:9: '/*' ( options {greedy=false; } : . )* '*/'
            {
            	Match("/*"); 

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:418:14: ( options {greedy=false; } : . )*
            	do 
            	{
            	    int alt33 = 2;
            	    int LA33_0 = input.LA(1);

            	    if ( (LA33_0 == '*') )
            	    {
            	        int LA33_1 = input.LA(2);

            	        if ( (LA33_1 == '/') )
            	        {
            	            alt33 = 2;
            	        }
            	        else if ( ((LA33_1 >= '\u0000' && LA33_1 <= '.') || (LA33_1 >= '0' && LA33_1 <= '\uFFFF')) )
            	        {
            	            alt33 = 1;
            	        }


            	    }
            	    else if ( ((LA33_0 >= '\u0000' && LA33_0 <= ')') || (LA33_0 >= '+' && LA33_0 <= '\uFFFF')) )
            	    {
            	        alt33 = 1;
            	    }


            	    switch (alt33) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:418:42: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop33;
            	    }
            	} while (true);

            	loop33:
            		;	// Stops C# compiler whining that label 'loop33' has no statements

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

    // $ANTLR start "CHARACTER_LITERAL"
    public void mCHARACTER_LITERAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CHARACTER_LITERAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:423:5: ( '\\'' ( EscapeSequence | ~ ( '\\'' | '\\\\' ) ) '\\'' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:423:9: '\\'' ( EscapeSequence | ~ ( '\\'' | '\\\\' ) ) '\\''
            {
            	Match('\''); 
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:423:14: ( EscapeSequence | ~ ( '\\'' | '\\\\' ) )
            	int alt34 = 2;
            	int LA34_0 = input.LA(1);

            	if ( (LA34_0 == '\\') )
            	{
            	    alt34 = 1;
            	}
            	else if ( ((LA34_0 >= '\u0000' && LA34_0 <= '&') || (LA34_0 >= '(' && LA34_0 <= '[') || (LA34_0 >= ']' && LA34_0 <= '\uFFFF')) )
            	{
            	    alt34 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d34s0 =
            	        new NoViableAltException("", 34, 0, input);

            	    throw nvae_d34s0;
            	}
            	switch (alt34) 
            	{
            	    case 1 :
            	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:423:16: EscapeSequence
            	        {
            	        	mEscapeSequence(); 

            	        }
            	        break;
            	    case 2 :
            	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:423:33: ~ ( '\\'' | '\\\\' )
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
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:429:5: ( '\"' ( EscapeSequence | ~ ( '\\\\' | '\"' ) )* '\"' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:429:8: '\"' ( EscapeSequence | ~ ( '\\\\' | '\"' ) )* '\"'
            {
            	Match('\"'); 
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:429:12: ( EscapeSequence | ~ ( '\\\\' | '\"' ) )*
            	do 
            	{
            	    int alt35 = 3;
            	    int LA35_0 = input.LA(1);

            	    if ( (LA35_0 == '\\') )
            	    {
            	        alt35 = 1;
            	    }
            	    else if ( ((LA35_0 >= '\u0000' && LA35_0 <= '!') || (LA35_0 >= '#' && LA35_0 <= '[') || (LA35_0 >= ']' && LA35_0 <= '\uFFFF')) )
            	    {
            	        alt35 = 2;
            	    }


            	    switch (alt35) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:429:14: EscapeSequence
            			    {
            			    	mEscapeSequence(); 

            			    }
            			    break;
            			case 2 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:429:31: ~ ( '\\\\' | '\"' )
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
            			    goto loop35;
            	    }
            	} while (true);

            	loop35:
            		;	// Stops C# compiler whining that label 'loop35' has no statements

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
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:435:5: ( '\\\\' ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' ) | OctalEscape )
            int alt36 = 2;
            int LA36_0 = input.LA(1);

            if ( (LA36_0 == '\\') )
            {
                int LA36_1 = input.LA(2);

                if ( (LA36_1 == '\"' || LA36_1 == '\'' || LA36_1 == '\\' || LA36_1 == 'b' || LA36_1 == 'f' || LA36_1 == 'n' || LA36_1 == 'r' || LA36_1 == 't') )
                {
                    alt36 = 1;
                }
                else if ( ((LA36_1 >= '0' && LA36_1 <= '7')) )
                {
                    alt36 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d36s1 =
                        new NoViableAltException("", 36, 1, input);

                    throw nvae_d36s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d36s0 =
                    new NoViableAltException("", 36, 0, input);

                throw nvae_d36s0;
            }
            switch (alt36) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:435:9: '\\\\' ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' )
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
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:437:9: OctalEscape
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
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:444:5: ( '\\\\' ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' ) | '\\\\' ( '0' .. '7' ) ( '0' .. '7' ) | '\\\\' ( '0' .. '7' ) )
            int alt37 = 3;
            int LA37_0 = input.LA(1);

            if ( (LA37_0 == '\\') )
            {
                int LA37_1 = input.LA(2);

                if ( ((LA37_1 >= '0' && LA37_1 <= '3')) )
                {
                    int LA37_2 = input.LA(3);

                    if ( ((LA37_2 >= '0' && LA37_2 <= '7')) )
                    {
                        int LA37_5 = input.LA(4);

                        if ( ((LA37_5 >= '0' && LA37_5 <= '7')) )
                        {
                            alt37 = 1;
                        }
                        else 
                        {
                            alt37 = 2;}
                    }
                    else 
                    {
                        alt37 = 3;}
                }
                else if ( ((LA37_1 >= '4' && LA37_1 <= '7')) )
                {
                    int LA37_3 = input.LA(3);

                    if ( ((LA37_3 >= '0' && LA37_3 <= '7')) )
                    {
                        alt37 = 2;
                    }
                    else 
                    {
                        alt37 = 3;}
                }
                else 
                {
                    NoViableAltException nvae_d37s1 =
                        new NoViableAltException("", 37, 1, input);

                    throw nvae_d37s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d37s0 =
                    new NoViableAltException("", 37, 0, input);

                throw nvae_d37s0;
            }
            switch (alt37) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:444:9: '\\\\' ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' )
                    {
                    	Match('\\'); 
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:444:14: ( '0' .. '3' )
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:444:15: '0' .. '3'
                    	{
                    		MatchRange('0','3'); 

                    	}

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:444:25: ( '0' .. '7' )
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:444:26: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:444:36: ( '0' .. '7' )
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:444:37: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:446:9: '\\\\' ( '0' .. '7' ) ( '0' .. '7' )
                    {
                    	Match('\\'); 
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:446:14: ( '0' .. '7' )
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:446:15: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:446:25: ( '0' .. '7' )
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:446:26: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:448:9: '\\\\' ( '0' .. '7' )
                    {
                    	Match('\\'); 
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:448:14: ( '0' .. '7' )
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:448:15: '0' .. '7'
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
        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:8: ( T__17 | T__18 | T__19 | T__20 | T__21 | T__22 | T__23 | T__24 | T__25 | T__26 | T__27 | T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | RWORD | ID | ARRAY | Keyword | INT | WS | CHARS | LINE_COMMENT | COMMENT | CHARACTER_LITERAL | STRING_LITERAL )
        int alt38 = 61;
        alt38 = dfa38.Predict(input);
        switch (alt38) 
        {
            case 1 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:10: T__17
                {
                	mT__17(); 

                }
                break;
            case 2 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:16: T__18
                {
                	mT__18(); 

                }
                break;
            case 3 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:22: T__19
                {
                	mT__19(); 

                }
                break;
            case 4 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:28: T__20
                {
                	mT__20(); 

                }
                break;
            case 5 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:34: T__21
                {
                	mT__21(); 

                }
                break;
            case 6 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:40: T__22
                {
                	mT__22(); 

                }
                break;
            case 7 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:46: T__23
                {
                	mT__23(); 

                }
                break;
            case 8 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:52: T__24
                {
                	mT__24(); 

                }
                break;
            case 9 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:58: T__25
                {
                	mT__25(); 

                }
                break;
            case 10 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:64: T__26
                {
                	mT__26(); 

                }
                break;
            case 11 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:70: T__27
                {
                	mT__27(); 

                }
                break;
            case 12 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:76: T__28
                {
                	mT__28(); 

                }
                break;
            case 13 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:82: T__29
                {
                	mT__29(); 

                }
                break;
            case 14 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:88: T__30
                {
                	mT__30(); 

                }
                break;
            case 15 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:94: T__31
                {
                	mT__31(); 

                }
                break;
            case 16 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:100: T__32
                {
                	mT__32(); 

                }
                break;
            case 17 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:106: T__33
                {
                	mT__33(); 

                }
                break;
            case 18 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:112: T__34
                {
                	mT__34(); 

                }
                break;
            case 19 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:118: T__35
                {
                	mT__35(); 

                }
                break;
            case 20 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:124: T__36
                {
                	mT__36(); 

                }
                break;
            case 21 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:130: T__37
                {
                	mT__37(); 

                }
                break;
            case 22 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:136: T__38
                {
                	mT__38(); 

                }
                break;
            case 23 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:142: T__39
                {
                	mT__39(); 

                }
                break;
            case 24 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:148: T__40
                {
                	mT__40(); 

                }
                break;
            case 25 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:154: T__41
                {
                	mT__41(); 

                }
                break;
            case 26 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:160: T__42
                {
                	mT__42(); 

                }
                break;
            case 27 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:166: T__43
                {
                	mT__43(); 

                }
                break;
            case 28 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:172: T__44
                {
                	mT__44(); 

                }
                break;
            case 29 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:178: T__45
                {
                	mT__45(); 

                }
                break;
            case 30 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:184: T__46
                {
                	mT__46(); 

                }
                break;
            case 31 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:190: T__47
                {
                	mT__47(); 

                }
                break;
            case 32 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:196: T__48
                {
                	mT__48(); 

                }
                break;
            case 33 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:202: T__49
                {
                	mT__49(); 

                }
                break;
            case 34 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:208: T__50
                {
                	mT__50(); 

                }
                break;
            case 35 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:214: T__51
                {
                	mT__51(); 

                }
                break;
            case 36 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:220: T__52
                {
                	mT__52(); 

                }
                break;
            case 37 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:226: T__53
                {
                	mT__53(); 

                }
                break;
            case 38 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:232: T__54
                {
                	mT__54(); 

                }
                break;
            case 39 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:238: T__55
                {
                	mT__55(); 

                }
                break;
            case 40 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:244: T__56
                {
                	mT__56(); 

                }
                break;
            case 41 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:250: T__57
                {
                	mT__57(); 

                }
                break;
            case 42 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:256: T__58
                {
                	mT__58(); 

                }
                break;
            case 43 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:262: T__59
                {
                	mT__59(); 

                }
                break;
            case 44 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:268: T__60
                {
                	mT__60(); 

                }
                break;
            case 45 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:274: T__61
                {
                	mT__61(); 

                }
                break;
            case 46 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:280: T__62
                {
                	mT__62(); 

                }
                break;
            case 47 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:286: T__63
                {
                	mT__63(); 

                }
                break;
            case 48 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:292: T__64
                {
                	mT__64(); 

                }
                break;
            case 49 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:298: T__65
                {
                	mT__65(); 

                }
                break;
            case 50 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:304: T__66
                {
                	mT__66(); 

                }
                break;
            case 51 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:310: RWORD
                {
                	mRWORD(); 

                }
                break;
            case 52 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:316: ID
                {
                	mID(); 

                }
                break;
            case 53 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:319: ARRAY
                {
                	mARRAY(); 

                }
                break;
            case 54 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:325: Keyword
                {
                	mKeyword(); 

                }
                break;
            case 55 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:333: INT
                {
                	mINT(); 

                }
                break;
            case 56 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:337: WS
                {
                	mWS(); 

                }
                break;
            case 57 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:340: CHARS
                {
                	mCHARS(); 

                }
                break;
            case 58 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:346: LINE_COMMENT
                {
                	mLINE_COMMENT(); 

                }
                break;
            case 59 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:359: COMMENT
                {
                	mCOMMENT(); 

                }
                break;
            case 60 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:367: CHARACTER_LITERAL
                {
                	mCHARACTER_LITERAL(); 

                }
                break;
            case 61 :
                // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:1:385: STRING_LITERAL
                {
                	mSTRING_LITERAL(); 

                }
                break;

        }

    }


    protected DFA7 dfa7;
    protected DFA25 dfa25;
    protected DFA19 dfa19;
    protected DFA23 dfa23;
    protected DFA38 dfa38;
	private void InitializeCyclicDFAs()
	{
	    this.dfa7 = new DFA7(this);
	    this.dfa25 = new DFA25(this);
	    this.dfa19 = new DFA19(this);
	    this.dfa23 = new DFA23(this);
	    this.dfa38 = new DFA38(this);
	    this.dfa38.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA38_SpecialStateTransition);
	}

    const string DFA7_eotS =
        "\x01\uffff\x06\x07\x03\uffff\x01\x07";
    const string DFA7_eofS =
        "\x0b\uffff";
    const string DFA7_minS =
        "\x01\x26\x04\x2c\x01\x2a\x01\x2e\x03\uffff\x01\x2c";
    const string DFA7_maxS =
        "\x07\x7a\x03\uffff\x01\x7a";
    const string DFA7_acceptS =
        "\x07\uffff\x01\x01\x01\x02\x01\x03\x01\uffff";
    const string DFA7_specialS =
        "\x0b\uffff}>";
    static readonly string[] DFA7_transitionS = {
            "\x01\x04\x03\uffff\x01\x05\x16\uffff\x1a\x02\x04\uffff\x01"+
            "\x03\x01\uffff\x1a\x01",
            "\x01\x08\x01\uffff\x01\x06\x01\uffff\x0a\x06\x03\uffff\x01"+
            "\x09\x03\uffff\x1a\x06\x04\uffff\x01\x06\x01\uffff\x1a\x06",
            "\x01\x08\x01\uffff\x01\x06\x01\uffff\x0a\x06\x03\uffff\x01"+
            "\x09\x03\uffff\x1a\x06\x04\uffff\x01\x06\x01\uffff\x1a\x06",
            "\x01\x08\x01\uffff\x01\x06\x01\uffff\x0a\x06\x03\uffff\x01"+
            "\x09\x03\uffff\x1a\x06\x04\uffff\x01\x06\x01\uffff\x1a\x06",
            "\x01\x08\x01\uffff\x01\x06\x01\uffff\x0a\x06\x03\uffff\x01"+
            "\x09\x03\uffff\x1a\x06\x04\uffff\x01\x06\x01\uffff\x1a\x06",
            "\x01\x0a\x01\uffff\x01\x08\x01\uffff\x01\x06\x01\uffff\x0a"+
            "\x06\x03\uffff\x01\x09\x03\uffff\x1a\x06\x04\uffff\x01\x06\x01"+
            "\uffff\x1a\x06",
            "\x01\x06\x01\uffff\x0a\x06\x03\uffff\x01\x09\x03\uffff\x1a"+
            "\x06\x04\uffff\x01\x06\x01\uffff\x1a\x06",
            "",
            "",
            "",
            "\x01\x08\x01\uffff\x01\x06\x01\uffff\x0a\x06\x03\uffff\x01"+
            "\x09\x03\uffff\x1a\x06\x04\uffff\x01\x06\x01\uffff\x1a\x06"
    };

    static readonly short[] DFA7_eot = DFA.UnpackEncodedString(DFA7_eotS);
    static readonly short[] DFA7_eof = DFA.UnpackEncodedString(DFA7_eofS);
    static readonly char[] DFA7_min = DFA.UnpackEncodedStringToUnsignedChars(DFA7_minS);
    static readonly char[] DFA7_max = DFA.UnpackEncodedStringToUnsignedChars(DFA7_maxS);
    static readonly short[] DFA7_accept = DFA.UnpackEncodedString(DFA7_acceptS);
    static readonly short[] DFA7_special = DFA.UnpackEncodedString(DFA7_specialS);
    static readonly short[][] DFA7_transition = DFA.UnpackEncodedStringArray(DFA7_transitionS);

    protected class DFA7 : DFA
    {
        public DFA7(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 7;
            this.eot = DFA7_eot;
            this.eof = DFA7_eof;
            this.min = DFA7_min;
            this.max = DFA7_max;
            this.accept = DFA7_accept;
            this.special = DFA7_special;
            this.transition = DFA7_transition;

        }

        override public string Description
        {
            get { return "381:1: ID : ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' | '*' | '**' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )* | ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' | '*' | '**' ) ( ( ',' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' ) ) | ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' | '*' | '**' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )* ( '=' ) ( ( INT )+ ) );"; }
        }

    }

    const string DFA25_eotS =
        "\x2f\uffff";
    const string DFA25_eofS =
        "\x2f\uffff";
    const string DFA25_minS =
        "\x01\x26\x04\x2e\x01\x2a\x01\x2e\x01\x20\x02\x2e\x01\x26\x01\x20"+
        "\x01\x30\x03\x20\x01\x2c\x01\x2a\x01\uffff\x01\x2c\x01\uffff\x02"+
        "\x2c\x02\x20\x01\x2e\x01\x2c\x02\x2e\x01\uffff\x01\x20\x01\x30\x03"+
        "\x20\x01\x2c\x01\x2a\x01\x20\x01\x2e\x01\x20\x01\x2d\x01\x2e\x01"+
        "\x2c\x01\x2e\x01\x5d\x01\x30\x01\x2d";
    const string DFA25_maxS =
        "\x0c\x7a\x01\x39\x01\x5d\x04\x7a\x01\uffff\x01\x7a\x01\uffff\x08"+
        "\x7a\x01\uffff\x01\x7a\x01\x39\x01\x5d\x06\x7a\x01\x5d\x01\x39\x03"+
        "\x7a\x01\x5d\x01\x39\x01\x5d";
    const string DFA25_acceptS =
        "\x12\uffff\x01\x03\x01\uffff\x01\x01\x08\uffff\x01\x02\x11\uffff";
    const string DFA25_specialS =
        "\x2f\uffff}>";
    static readonly string[] DFA25_transitionS = {
            "\x01\x04\x03\uffff\x01\x05\x16\uffff\x1a\x02\x04\uffff\x01"+
            "\x03\x01\uffff\x1a\x01",
            "\x01\x06\x01\uffff\x0a\x06\x07\uffff\x1a\x06\x01\x07\x03\uffff"+
            "\x01\x06\x01\uffff\x1a\x06",
            "\x01\x06\x01\uffff\x0a\x06\x07\uffff\x1a\x06\x01\x07\x03\uffff"+
            "\x01\x06\x01\uffff\x1a\x06",
            "\x01\x06\x01\uffff\x0a\x06\x07\uffff\x1a\x06\x01\x07\x03\uffff"+
            "\x01\x06\x01\uffff\x1a\x06",
            "\x01\x06\x01\uffff\x0a\x06\x07\uffff\x1a\x06\x01\x07\x03\uffff"+
            "\x01\x06\x01\uffff\x1a\x06",
            "\x01\x08\x03\uffff\x01\x09\x01\uffff\x0a\x09\x07\uffff\x1a"+
            "\x09\x01\x0a\x03\uffff\x01\x09\x01\uffff\x1a\x09",
            "\x01\x06\x01\uffff\x0a\x06\x07\uffff\x1a\x06\x01\x07\x03\uffff"+
            "\x01\x06\x01\uffff\x1a\x06",
            "\x01\x12\x05\uffff\x01\x10\x03\uffff\x01\x11\x02\uffff\x01"+
            "\x0c\x02\uffff\x0a\x0d\x07\uffff\x1a\x0e\x04\uffff\x01\x0f\x01"+
            "\uffff\x1a\x0b",
            "\x01\x09\x01\uffff\x0a\x09\x07\uffff\x1a\x09\x01\x0a\x03\uffff"+
            "\x01\x09\x01\uffff\x1a\x09",
            "\x01\x09\x01\uffff\x0a\x09\x07\uffff\x1a\x09\x01\x0a\x03\uffff"+
            "\x01\x09\x01\uffff\x1a\x09",
            "\x01\x14\x03\uffff\x01\x14\x02\uffff\x01\x14\x02\uffff\x0a"+
            "\x14\x07\uffff\x1a\x15\x04\uffff\x01\x16\x01\uffff\x1a\x13",
            "\x01\x12\x09\uffff\x02\x12\x01\x14\x01\x12\x01\x19\x01\x12"+
            "\x0a\x17\x03\uffff\x01\x14\x03\uffff\x1a\x17\x01\x18\x01\uffff"+
            "\x01\x14\x01\uffff\x01\x17\x01\uffff\x1a\x17",
            "\x0a\x0d",
            "\x01\x12\x09\uffff\x02\x12\x01\uffff\x01\x12\x01\uffff\x01"+
            "\x12\x0a\x0d\x23\uffff\x01\x14",
            "\x01\x12\x09\uffff\x02\x12\x01\x14\x01\x12\x01\x19\x01\x12"+
            "\x0a\x17\x03\uffff\x01\x14\x03\uffff\x1a\x17\x01\x18\x01\uffff"+
            "\x01\x14\x01\uffff\x01\x17\x01\uffff\x1a\x17",
            "\x01\x12\x09\uffff\x02\x12\x01\x14\x01\x12\x01\x19\x01\x12"+
            "\x0a\x17\x03\uffff\x01\x14\x03\uffff\x1a\x17\x01\x18\x01\uffff"+
            "\x01\x14\x01\uffff\x01\x17\x01\uffff\x1a\x17",
            "\x01\x14\x01\uffff\x01\x19\x01\uffff\x0a\x19\x03\uffff\x01"+
            "\x14\x03\uffff\x1a\x19\x01\x12\x01\uffff\x01\x14\x01\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\x1a\x01\uffff\x01\x14\x01\uffff\x01\x1b\x01\uffff\x0a"+
            "\x1b\x03\uffff\x01\x14\x03\uffff\x1a\x1b\x01\x12\x01\uffff\x01"+
            "\x14\x01\uffff\x01\x1b\x01\uffff\x1a\x1b",
            "",
            "\x01\x14\x01\uffff\x01\x14\x01\uffff\x0a\x1c\x03\uffff\x01"+
            "\x14\x03\uffff\x1a\x1c\x01\x1d\x01\uffff\x01\x14\x01\uffff\x01"+
            "\x1c\x01\uffff\x1a\x1c",
            "",
            "\x01\x14\x01\uffff\x01\x14\x01\uffff\x0a\x1c\x03\uffff\x01"+
            "\x14\x03\uffff\x1a\x1c\x01\x1d\x01\uffff\x01\x14\x01\uffff\x01"+
            "\x1c\x01\uffff\x1a\x1c",
            "\x01\x14\x01\uffff\x01\x14\x01\uffff\x0a\x1c\x03\uffff\x01"+
            "\x14\x03\uffff\x1a\x1c\x01\x1d\x01\uffff\x01\x14\x01\uffff\x01"+
            "\x1c\x01\uffff\x1a\x1c",
            "\x01\x12\x09\uffff\x02\x12\x01\uffff\x01\x12\x01\x19\x01\x12"+
            "\x0a\x17\x03\uffff\x01\x14\x03\uffff\x1a\x17\x01\x18\x01\uffff"+
            "\x01\x14\x01\uffff\x01\x17\x01\uffff\x1a\x17",
            "\x01\x12\x05\uffff\x01\x23\x03\uffff\x01\x24\x02\uffff\x01"+
            "\x1f\x02\uffff\x0a\x20\x07\uffff\x1a\x21\x04\uffff\x01\x22\x01"+
            "\uffff\x1a\x1e",
            "\x01\x19\x01\uffff\x0a\x19\x03\uffff\x01\x14\x03\uffff\x1a"+
            "\x19\x01\x12\x01\uffff\x01\x14\x01\uffff\x01\x19\x01\uffff\x1a"+
            "\x19",
            "\x01\x14\x01\uffff\x01\x1b\x01\uffff\x0a\x1b\x03\uffff\x01"+
            "\x14\x03\uffff\x1a\x1b\x01\x12\x01\uffff\x01\x14\x01\uffff\x01"+
            "\x1b\x01\uffff\x1a\x1b",
            "\x01\x1b\x01\uffff\x0a\x1b\x03\uffff\x01\x14\x03\uffff\x1a"+
            "\x1b\x01\x12\x01\uffff\x01\x14\x01\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x01\x14\x01\uffff\x0a\x1c\x03\uffff\x01\x14\x03\uffff\x1a"+
            "\x1c\x01\x1d\x01\uffff\x01\x14\x01\uffff\x01\x1c\x01\uffff\x1a"+
            "\x1c",
            "",
            "\x01\x12\x09\uffff\x02\x12\x01\x26\x01\x12\x01\x29\x01\x12"+
            "\x0a\x25\x03\uffff\x01\x28\x03\uffff\x1a\x25\x01\x12\x01\uffff"+
            "\x01\x27\x01\uffff\x01\x25\x01\uffff\x1a\x25",
            "\x0a\x20",
            "\x01\x12\x09\uffff\x02\x12\x01\uffff\x01\x12\x01\uffff\x01"+
            "\x12\x0a\x20\x23\uffff\x01\x27",
            "\x01\x12\x09\uffff\x02\x12\x01\x26\x01\x12\x01\x29\x01\x12"+
            "\x0a\x25\x03\uffff\x01\x28\x03\uffff\x1a\x25\x01\x12\x01\uffff"+
            "\x01\x27\x01\uffff\x01\x25\x01\uffff\x1a\x25",
            "\x01\x12\x09\uffff\x02\x12\x01\x26\x01\x12\x01\x29\x01\x12"+
            "\x0a\x25\x03\uffff\x01\x28\x03\uffff\x1a\x25\x01\x12\x01\uffff"+
            "\x01\x27\x01\uffff\x01\x25\x01\uffff\x1a\x25",
            "\x01\x26\x01\uffff\x01\x29\x01\uffff\x0a\x29\x03\uffff\x01"+
            "\x28\x03\uffff\x1a\x29\x01\x12\x01\uffff\x01\x27\x01\uffff\x01"+
            "\x29\x01\uffff\x1a\x29",
            "\x01\x2a\x01\uffff\x01\x26\x01\uffff\x01\x2b\x01\uffff\x0a"+
            "\x2b\x03\uffff\x01\x28\x03\uffff\x1a\x2b\x01\x12\x01\uffff\x01"+
            "\x27\x01\uffff\x01\x2b\x01\uffff\x1a\x2b",
            "\x01\x12\x09\uffff\x02\x12\x01\uffff\x01\x12\x01\x29\x01\x12"+
            "\x0a\x25\x03\uffff\x01\x28\x03\uffff\x1a\x25\x01\x12\x01\uffff"+
            "\x01\x27\x01\uffff\x01\x25\x01\uffff\x1a\x25",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c",
            "\x01\x12\x09\uffff\x02\x12\x01\uffff\x01\x12\x01\uffff\x01"+
            "\x12\x2b\uffff\x01\x12\x01\uffff\x01\x1d",
            "\x01\x2d\x02\uffff\x0a\x2e",
            "\x01\x29\x01\uffff\x0a\x29\x03\uffff\x01\x28\x03\uffff\x1a"+
            "\x29\x01\x12\x01\uffff\x01\x27\x01\uffff\x01\x29\x01\uffff\x1a"+
            "\x29",
            "\x01\x26\x01\uffff\x01\x2b\x01\uffff\x0a\x2b\x03\uffff\x01"+
            "\x28\x03\uffff\x1a\x2b\x01\x12\x01\uffff\x01\x27\x01\uffff\x01"+
            "\x2b\x01\uffff\x1a\x2b",
            "\x01\x2b\x01\uffff\x0a\x2b\x03\uffff\x01\x28\x03\uffff\x1a"+
            "\x2b\x01\x12\x01\uffff\x01\x27\x01\uffff\x01\x2b\x01\uffff\x1a"+
            "\x2b",
            "\x01\x27",
            "\x0a\x2e",
            "\x01\x2d\x02\uffff\x0a\x2e\x23\uffff\x01\x27"
    };

    static readonly short[] DFA25_eot = DFA.UnpackEncodedString(DFA25_eotS);
    static readonly short[] DFA25_eof = DFA.UnpackEncodedString(DFA25_eofS);
    static readonly char[] DFA25_min = DFA.UnpackEncodedStringToUnsignedChars(DFA25_minS);
    static readonly char[] DFA25_max = DFA.UnpackEncodedStringToUnsignedChars(DFA25_maxS);
    static readonly short[] DFA25_accept = DFA.UnpackEncodedString(DFA25_acceptS);
    static readonly short[] DFA25_special = DFA.UnpackEncodedString(DFA25_specialS);
    static readonly short[][] DFA25_transition = DFA.UnpackEncodedStringArray(DFA25_transitionS);

    protected class DFA25 : DFA
    {
        public DFA25(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 25;
            this.eot = DFA25_eot;
            this.eof = DFA25_eof;
            this.min = DFA25_min;
            this.max = DFA25_max;
            this.accept = DFA25_accept;
            this.special = DFA25_special;
            this.transition = DFA25_transition;

        }

        override public string Description
        {
            get { return "387:1: ARRAY : ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' | '*' | '**' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )* ( '[' ( ( INT ) | ID ) ']' )+ | ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' | '*' | '**' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )* '[' ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* ( '[' ( ( INT ) | ID ) ']' ) ']' | ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '&' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '.' )* ( '[' ( ' ' )* ( ARRAY | INT | ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* ) ) ( ' ' )* ( '+' | '-' | '/' | '*' ) ( ' ' )* ( ARRAY | INT | ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* ) ) ( ' ' )* ']' ) );"; }
        }

    }

    const string DFA19_eotS =
        "\x08\uffff";
    const string DFA19_eofS =
        "\x08\uffff";
    const string DFA19_minS =
        "\x01\x26\x03\x20\x02\uffff\x01\x20\x01\uffff";
    const string DFA19_maxS =
        "\x04\x7a\x02\uffff\x01\x7a\x01\uffff";
    const string DFA19_acceptS =
        "\x04\uffff\x01\x01\x01\x02\x01\uffff\x01\x03";
    const string DFA19_specialS =
        "\x08\uffff}>";
    static readonly string[] DFA19_transitionS = {
            "\x01\x04\x03\uffff\x01\x04\x02\uffff\x01\x05\x02\uffff\x0a"+
            "\x05\x07\uffff\x1a\x02\x04\uffff\x01\x03\x01\uffff\x1a\x01",
            "\x01\x07\x09\uffff\x02\x07\x01\uffff\x01\x07\x01\x04\x01\x07"+
            "\x0a\x06\x07\uffff\x1a\x06\x01\x04\x03\uffff\x01\x06\x01\uffff"+
            "\x1a\x06",
            "\x01\x07\x09\uffff\x02\x07\x01\uffff\x01\x07\x01\x04\x01\x07"+
            "\x0a\x06\x07\uffff\x1a\x06\x01\x04\x03\uffff\x01\x06\x01\uffff"+
            "\x1a\x06",
            "\x01\x07\x09\uffff\x02\x07\x01\uffff\x01\x07\x01\x04\x01\x07"+
            "\x0a\x06\x07\uffff\x1a\x06\x01\x04\x03\uffff\x01\x06\x01\uffff"+
            "\x1a\x06",
            "",
            "",
            "\x01\x07\x09\uffff\x02\x07\x01\uffff\x01\x07\x01\x04\x01\x07"+
            "\x0a\x06\x07\uffff\x1a\x06\x01\x04\x03\uffff\x01\x06\x01\uffff"+
            "\x1a\x06",
            ""
    };

    static readonly short[] DFA19_eot = DFA.UnpackEncodedString(DFA19_eotS);
    static readonly short[] DFA19_eof = DFA.UnpackEncodedString(DFA19_eofS);
    static readonly char[] DFA19_min = DFA.UnpackEncodedStringToUnsignedChars(DFA19_minS);
    static readonly char[] DFA19_max = DFA.UnpackEncodedStringToUnsignedChars(DFA19_maxS);
    static readonly short[] DFA19_accept = DFA.UnpackEncodedString(DFA19_acceptS);
    static readonly short[] DFA19_special = DFA.UnpackEncodedString(DFA19_specialS);
    static readonly short[][] DFA19_transition = DFA.UnpackEncodedStringArray(DFA19_transitionS);

    protected class DFA19 : DFA
    {
        public DFA19(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 19;
            this.eot = DFA19_eot;
            this.eof = DFA19_eof;
            this.min = DFA19_min;
            this.max = DFA19_max;
            this.accept = DFA19_accept;
            this.special = DFA19_special;
            this.transition = DFA19_transition;

        }

        override public string Description
        {
            get { return "390:89: ( ARRAY | INT | ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* ) )"; }
        }

    }

    const string DFA23_eotS =
        "\x08\uffff";
    const string DFA23_eofS =
        "\x08\uffff";
    const string DFA23_minS =
        "\x01\x26\x03\x20\x02\uffff\x01\x20\x01\uffff";
    const string DFA23_maxS =
        "\x04\x7a\x02\uffff\x01\x7a\x01\uffff";
    const string DFA23_acceptS =
        "\x04\uffff\x01\x01\x01\x02\x01\uffff\x01\x03";
    const string DFA23_specialS =
        "\x08\uffff}>";
    static readonly string[] DFA23_transitionS = {
            "\x01\x04\x03\uffff\x01\x04\x02\uffff\x01\x05\x02\uffff\x0a"+
            "\x05\x07\uffff\x1a\x02\x04\uffff\x01\x03\x01\uffff\x1a\x01",
            "\x01\x07\x0d\uffff\x01\x04\x01\uffff\x0a\x06\x07\uffff\x1a"+
            "\x06\x01\x04\x01\uffff\x01\x07\x01\uffff\x01\x06\x01\uffff\x1a"+
            "\x06",
            "\x01\x07\x0d\uffff\x01\x04\x01\uffff\x0a\x06\x07\uffff\x1a"+
            "\x06\x01\x04\x01\uffff\x01\x07\x01\uffff\x01\x06\x01\uffff\x1a"+
            "\x06",
            "\x01\x07\x0d\uffff\x01\x04\x01\uffff\x0a\x06\x07\uffff\x1a"+
            "\x06\x01\x04\x01\uffff\x01\x07\x01\uffff\x01\x06\x01\uffff\x1a"+
            "\x06",
            "",
            "",
            "\x01\x07\x0d\uffff\x01\x04\x01\uffff\x0a\x06\x07\uffff\x1a"+
            "\x06\x01\x04\x01\uffff\x01\x07\x01\uffff\x01\x06\x01\uffff\x1a"+
            "\x06",
            ""
    };

    static readonly short[] DFA23_eot = DFA.UnpackEncodedString(DFA23_eotS);
    static readonly short[] DFA23_eof = DFA.UnpackEncodedString(DFA23_eofS);
    static readonly char[] DFA23_min = DFA.UnpackEncodedStringToUnsignedChars(DFA23_minS);
    static readonly char[] DFA23_max = DFA.UnpackEncodedStringToUnsignedChars(DFA23_maxS);
    static readonly short[] DFA23_accept = DFA.UnpackEncodedString(DFA23_acceptS);
    static readonly short[] DFA23_special = DFA.UnpackEncodedString(DFA23_specialS);
    static readonly short[][] DFA23_transition = DFA.UnpackEncodedStringArray(DFA23_transitionS);

    protected class DFA23 : DFA
    {
        public DFA23(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 23;
            this.eot = DFA23_eot;
            this.eof = DFA23_eof;
            this.min = DFA23_min;
            this.max = DFA23_max;
            this.accept = DFA23_accept;
            this.special = DFA23_special;
            this.transition = DFA23_transition;

        }

        override public string Description
        {
            get { return "390:193: ( ARRAY | INT | ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* ) )"; }
        }

    }

    const string DFA38_eotS =
        "\x03\uffff\x01\x2d\x01\x2f\x01\x30\x01\x31\x07\x2d\x01\x28\x01"+
        "\x2d\x01\x41\x01\x42\x01\x47\x01\x4b\x01\x4e\x01\x51\x01\x2d\x01"+
        "\uffff\x03\x2d\x01\uffff\x01\x58\x01\x5a\x01\x2d\x01\uffff\x01\x5e"+
        "\x01\uffff\x01\x5f\x01\x60\x02\x2d\x05\uffff\x02\x2d\x05\uffff\x01"+
        "\x2d\x01\x63\x0a\x2d\x02\uffff\x01\x2d\x02\uffff\x01\x71\x02\x2d"+
        "\x01\x28\x01\uffff\x01\x2d\x01\x28\x08\uffff\x04\x2d\x06\uffff\x02"+
        "\x28\x03\uffff\x01\x2d\x01\x7e\x01\uffff\x03\x2d\x01\u0082\x09\x2d"+
        "\x01\uffff\x01\x28\x05\x2d\x01\x28\x01\uffff\x01\x28\x01\uffff\x01"+
        "\x28\x01\x2d\x01\uffff\x01\u0096\x02\x2d\x01\uffff\x01\x2d\x01\u009a"+
        "\x01\u009b\x06\x2d\x03\x28\x01\x2e\x03\x2d\x01\u00a7\x01\x28\x01"+
        "\x2d\x01\uffff\x01\x2d\x01\u00aa\x01\x2d\x02\uffff\x06\x2d\x02\x28"+
        "\x02\x2d\x01\u00b4\x01\uffff\x01\u00b5\x01\x2d\x01\uffff\x01\x2d"+
        "\x01\u00b8\x01\x2d\x01\u00ba\x04\x2d\x01\u00bf\x02\uffff\x02\x2d"+
        "\x01\uffff\x01\u00c2\x01\uffff\x03\x2d\x02\uffff\x01\x2d\x02\uffff"+
        "\x08\x2d\x01\u00cf\x01\u00d0\x01\u00d1\x01\x2d\x03\uffff\x02\x2d"+
        "\x01\u00d5\x01\uffff";
    const string DFA38_eofS =
        "\u00d6\uffff";
    const string DFA38_minS =
        "\x01\x09\x02\uffff\x01\x2e\x03\x23\x07\x2e\x01\x64\x01\x2e\x03"+
        "\x23\x01\x3d\x01\x2b\x01\x2d\x01\x2e\x01\uffff\x03\x2e\x01\uffff"+
        "\x02\x23\x01\x26\x01\uffff\x01\x23\x01\uffff\x02\x23\x02\x2e\x05"+
        "\uffff\x02\x2e\x05\uffff\x0c\x2e\x02\uffff\x01\x2e\x02\uffff\x01"+
        "\x2d\x02\x23\x01\x26\x01\uffff\x02\x2e\x08\uffff\x04\x2e\x06\uffff"+
        "\x02\x00\x03\uffff\x02\x2e\x01\uffff\x0d\x2e\x01\uffff\x01\x2a\x01"+
        "\x23\x04\x2e\x01\x00\x01\uffff\x01\x00\x01\uffff\x01\x00\x01\x2e"+
        "\x01\uffff\x03\x2e\x01\uffff\x09\x2e\x01\x2c\x02\x2e\x01\x23\x04"+
        "\x2e\x01\x00\x01\x2e\x01\uffff\x03\x2e\x02\uffff\x06\x2e\x01\x5d"+
        "\x01\x26\x03\x2e\x01\uffff\x02\x2e\x01\uffff\x07\x2e\x01\x28\x01"+
        "\x2e\x02\uffff\x01\x2e\x01\x28\x01\uffff\x01\x2e\x01\uffff\x03\x2e"+
        "\x02\uffff\x01\x2e\x02\uffff\x0c\x2e\x03\uffff\x03\x2e\x01\uffff";
    const string DFA38_maxS =
        "\x01\x7d\x02\uffff\x01\x7a\x03\x7d\x07\x7a\x01\x69\x01\x7a\x03"+
        "\x7d\x03\x3d\x01\x7a\x01\uffff\x03\x7a\x01\uffff\x02\x7d\x01\x7a"+
        "\x01\uffff\x01\x7d\x01\uffff\x02\x7d\x02\x7a\x05\uffff\x02\x7a\x05"+
        "\uffff\x0c\x7a\x02\uffff\x01\x7a\x02\uffff\x01\x39\x02\x7d\x01\x7a"+
        "\x01\uffff\x02\x7a\x08\uffff\x04\x7a\x06\uffff\x02\uffff\x03\uffff"+
        "\x02\x7a\x01\uffff\x0d\x7a\x01\uffff\x01\x7a\x01\x7d\x04\x7a\x01"+
        "\uffff\x01\uffff\x01\uffff\x01\uffff\x01\uffff\x01\x7a\x01\uffff"+
        "\x03\x7a\x01\uffff\x0c\x7a\x01\x7d\x04\x7a\x01\uffff\x01\x7a\x01"+
        "\uffff\x03\x7a\x02\uffff\x06\x7a\x01\x5d\x04\x7a\x01\uffff\x02\x7a"+
        "\x01\uffff\x09\x7a\x02\uffff\x02\x7a\x01\uffff\x01\x7a\x01\uffff"+
        "\x03\x7a\x02\uffff\x01\x7a\x02\uffff\x0c\x7a\x03\uffff\x03\x7a\x01"+
        "\uffff";
    const string DFA38_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x14\uffff\x01\x1e\x03\uffff\x01\x27"+
        "\x03\uffff\x01\x2d\x01\uffff\x01\x30\x04\uffff\x01\x37\x01\x38\x01"+
        "\x39\x01\x3c\x01\x3d\x02\uffff\x01\x34\x01\x35\x01\x04\x01\x05\x01"+
        "\x06\x0c\uffff\x01\x0f\x01\x33\x01\uffff\x01\x13\x01\x14\x04\uffff"+
        "\x01\x15\x02\uffff\x01\x26\x01\x16\x01\x1a\x01\x23\x01\x17\x01\x19"+
        "\x01\x24\x01\x2e\x04\uffff\x01\x2a\x01\x36\x01\x28\x01\x2b\x01\x29"+
        "\x01\x2c\x02\uffff\x01\x2f\x01\x31\x01\x32\x02\uffff\x01\x21\x0d"+
        "\uffff\x01\x25\x07\uffff\x01\x3a\x01\uffff\x01\x3b\x02\uffff\x01"+
        "\x07\x03\uffff\x01\x18\x13\uffff\x01\x08\x03\uffff\x01\x0a\x01\x0b"+
        "\x0b\uffff\x01\x22\x02\uffff\x01\x09\x09\uffff\x01\x20\x01\x03\x02"+
        "\uffff\x01\x0c\x01\uffff\x01\x0d\x03\uffff\x01\x1b\x01\x1f\x01\uffff"+
        "\x01\x1c\x01\x1d\x0c\uffff\x01\x10\x01\x11\x01\x12\x03\uffff\x01"+
        "\x0e";
    const string DFA38_specialS =
        "\x5c\uffff\x01\x03\x01\x01\x1a\uffff\x01\x04\x01\uffff\x01\x02"+
        "\x01\uffff\x01\x05\x17\uffff\x01\x00\x41\uffff}>";
    static readonly string[] DFA38_transitionS = {
            "\x02\x27\x02\uffff\x01\x27\x12\uffff\x01\x27\x01\x1b\x01\x2a"+
            "\x01\x0e\x01\x28\x01\x21\x01\x1e\x01\x29\x01\x04\x01\x06\x01"+
            "\x12\x01\x14\x01\x05\x01\x15\x01\x02\x01\x20\x0a\x26\x01\x17"+
            "\x01\x01\x01\x1c\x01\x13\x01\x1d\x02\uffff\x1a\x25\x01\x22\x01"+
            "\uffff\x01\x23\x01\uffff\x01\x0f\x01\uffff\x01\x24\x01\x0a\x01"+
            "\x08\x01\x0c\x01\x1a\x01\x09\x02\x24\x01\x07\x01\x24\x01\x03"+
            "\x04\x24\x01\x16\x01\x24\x01\x18\x01\x0d\x02\x24\x01\x0b\x01"+
            "\x19\x03\x24\x01\x10\x01\x1f\x01\x11",
            "",
            "",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x04\x2c\x01\x2b\x15\x2c",
            "\x02\x28\x03\uffff\x03\x28\x01\uffff\x01\x28\x01\uffff\x02"+
            "\x28\x0c\uffff\x01\x28\x01\uffff\x01\x28\x1c\uffff\x01\x28\x01"+
            "\uffff\x01\x28\x1d\uffff\x01\x28\x01\uffff\x01\x28",
            "\x02\x28\x03\uffff\x03\x28\x01\uffff\x01\x28\x01\uffff\x02"+
            "\x28\x0c\uffff\x01\x28\x01\uffff\x01\x28\x1c\uffff\x01\x28\x01"+
            "\uffff\x01\x28\x1d\uffff\x01\x28\x01\uffff\x01\x28",
            "\x02\x28\x03\uffff\x03\x28\x01\uffff\x01\x28\x01\uffff\x02"+
            "\x28\x0c\uffff\x01\x28\x01\uffff\x01\x28\x1c\uffff\x01\x28\x01"+
            "\uffff\x01\x28\x1d\uffff\x01\x28\x01\uffff\x01\x28",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x05\x2c\x01\x33\x07\x2c\x01\x32\x0c\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x07\x2c\x01\x34\x0c\x2c\x01\x35\x05\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x0b\x2c\x01\x36\x02\x2c\x01\x37\x01\x38\x0a"+
            "\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x0e\x2c\x01\x39\x0b\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x0e\x2c\x01\x3a\x0b\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x04\x2c\x01\x3c\x09\x2c\x01\x3b\x0b\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x08\x2c\x01\x3d\x11\x2c",
            "\x01\x3f\x04\uffff\x01\x3e",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x40\x01\uffff\x1a\x2c",
            "\x02\x28\x03\uffff\x03\x28\x01\uffff\x01\x28\x01\uffff\x02"+
            "\x28\x0c\uffff\x01\x28\x01\uffff\x01\x28\x1c\uffff\x01\x28\x01"+
            "\uffff\x01\x28\x1d\uffff\x01\x28\x01\uffff\x01\x28",
            "\x02\x28\x03\uffff\x03\x28\x01\uffff\x01\x28\x01\uffff\x02"+
            "\x28\x0c\uffff\x01\x28\x01\uffff\x01\x28\x1c\uffff\x01\x28\x01"+
            "\uffff\x01\x28\x1d\uffff\x01\x28\x01\uffff\x01\x28",
            "\x02\x28\x03\uffff\x02\x28\x01\x44\x01\uffff\x01\x49\x01\uffff"+
            "\x01\x45\x01\x28\x0a\x48\x02\uffff\x01\x28\x01\x43\x01\x28\x02"+
            "\uffff\x1a\x48\x01\x46\x01\uffff\x01\x28\x01\uffff\x01\x48\x01"+
            "\uffff\x1a\x48\x01\x28\x01\uffff\x01\x28",
            "\x01\x4a",
            "\x01\x4d\x11\uffff\x01\x4c",
            "\x01\x50\x02\uffff\x0a\x26\x03\uffff\x01\x4f",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x11\x2c\x01\x52\x08\x2c",
            "",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x04\x2c\x01\x53\x15\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x07\x2c\x01\x54\x12\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x0b\x2c\x01\x55\x0e\x2c",
            "",
            "\x02\x28\x03\uffff\x03\x28\x01\uffff\x01\x28\x01\uffff\x02"+
            "\x28\x0c\uffff\x01\x28\x01\x56\x01\x28\x1c\uffff\x01\x28\x01"+
            "\uffff\x01\x28\x05\uffff\x01\x57\x0f\uffff\x01\x57\x07\uffff"+
            "\x01\x28\x01\uffff\x01\x28",
            "\x02\x28\x03\uffff\x03\x28\x01\uffff\x01\x28\x01\uffff\x02"+
            "\x28\x0c\uffff\x01\x28\x01\x59\x01\x28\x1c\uffff\x01\x28\x01"+
            "\uffff\x01\x28\x1d\uffff\x01\x28\x01\uffff\x01\x28",
            "\x01\x5b\x07\uffff\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a"+
            "\x2c\x01\x2e\x03\uffff\x01\x2c\x01\uffff\x1a\x2c",
            "",
            "\x02\x28\x03\uffff\x02\x28\x01\x5d\x01\uffff\x01\x28\x01\uffff"+
            "\x01\x28\x01\x5c\x0c\uffff\x01\x28\x01\uffff\x01\x28\x1c\uffff"+
            "\x01\x28\x01\uffff\x01\x28\x1d\uffff\x01\x28\x01\uffff\x01\x28",
            "",
            "\x02\x28\x03\uffff\x03\x28\x01\uffff\x01\x28\x01\uffff\x02"+
            "\x28\x0c\uffff\x01\x28\x01\uffff\x01\x28\x1c\uffff\x01\x28\x01"+
            "\uffff\x01\x28\x1d\uffff\x01\x28\x01\uffff\x01\x28",
            "\x02\x28\x03\uffff\x03\x28\x01\uffff\x01\x28\x01\uffff\x02"+
            "\x28\x0c\uffff\x01\x28\x01\uffff\x01\x28\x1c\uffff\x01\x28\x01"+
            "\uffff\x01\x28\x1d\uffff\x01\x28\x01\uffff\x01\x28",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x1a\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x1a\x2c",
            "",
            "",
            "",
            "",
            "",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x11\x2c\x01\x61\x08\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x1a\x2c",
            "",
            "",
            "",
            "",
            "",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x13\x2c\x01\x62\x06\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x03\uffff\x01\x2d\x03\uffff\x1a"+
            "\x2c\x01\x2e\x03\uffff\x01\x2c\x01\uffff\x1a\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x01\x64\x19\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x03\x2c\x01\x65\x16\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x0e\x2c\x01\x66\x0b\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x11\x2c\x01\x67\x08\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x11\x2c\x01\x68\x08\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x0e\x2c\x01\x69\x0b\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x08\x2c\x01\x6a\x11\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x14\x2c\x01\x6b\x05\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x05\x2c\x01\x6c\x14\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x19\x2c\x01\x6d",
            "",
            "",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x03\x2c\x01\x6f\x02\x2c\x01\x6e\x0b\x2c\x01"+
            "\x70\x07\x2c",
            "",
            "",
            "\x01\x2d\x02\uffff\x0a\x2d",
            "\x02\x28\x03\uffff\x03\x28\x01\uffff\x01\x49\x01\uffff\x01"+
            "\x45\x01\x28\x0a\x48\x02\uffff\x01\x28\x01\uffff\x01\x28\x02"+
            "\uffff\x1a\x48\x01\x46\x01\uffff\x01\x28\x01\uffff\x01\x48\x01"+
            "\uffff\x1a\x48\x01\x28\x01\uffff\x01\x28",
            "\x02\x28\x03\uffff\x03\x28\x01\uffff\x01\x28\x01\uffff\x01"+
            "\x45\x01\x28\x0a\x48\x02\uffff\x01\x28\x01\uffff\x01\x28\x02"+
            "\uffff\x1a\x48\x01\x46\x01\uffff\x01\x28\x01\uffff\x01\x48\x01"+
            "\uffff\x1a\x48\x01\x28\x01\uffff\x01\x28",
            "\x01\x2e\x03\uffff\x01\x72\x02\uffff\x01\x2e\x02\uffff\x0a"+
            "\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a\x2e",
            "",
            "\x01\x48\x01\uffff\x0a\x48\x07\uffff\x1a\x48\x01\x2e\x03\uffff"+
            "\x01\x48\x01\uffff\x1a\x48",
            "\x01\x73\x01\uffff\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01"+
            "\x2d\x01\uffff\x1a\x2d",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x08\x2c\x01\x74\x11\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x13\x2c\x01\x75\x06\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x08\x2c\x01\x76\x11\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x12\x2c\x01\x77\x07\x2c",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x23\x79\x02\x78\x03\x79\x03\x78\x01\x79\x01\x78\x01\x79\x02"+
            "\x78\x0c\x79\x01\x78\x01\x79\x01\x78\x1c\x79\x01\x78\x01\x79"+
            "\x01\x78\x1d\x79\x01\x78\x01\x79\x01\x78\uff82\x79",
            "\x23\x7b\x02\x7c\x03\x7b\x02\x7c\x01\x7a\x01\x7b\x01\x7c\x01"+
            "\x7b\x02\x7c\x0c\x7b\x01\x7c\x01\x7b\x01\x7c\x1c\x7b\x01\x7c"+
            "\x01\x7b\x01\x7c\x1d\x7b\x01\x7c\x01\x7b\x01\x7c\uff82\x7b",
            "",
            "",
            "",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x0d\x2c\x01\x7d\x0c\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x03\uffff\x01\x2d\x03\uffff\x1a"+
            "\x2c\x01\x2e\x03\uffff\x01\x2c\x01\uffff\x1a\x2c",
            "",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x11\x2c\x01\x7f\x08\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x01\u0080\x19\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x01\u0081\x19\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x03\uffff\x01\x2d\x03\uffff\x1a"+
            "\x2c\x01\x2e\x03\uffff\x01\x2c\x01\uffff\x1a\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x08\x2c\x01\u0083\x11\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x0b\x2c\x01\u0084\x0e\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x03\x2c\x01\u0085\x16\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x01\x2c\x01\u0086\x18\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x01\u0087\x19\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x04\x2c\x01\u0088\x15\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x0b\x2c\x01\u0089\x0e\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x04\x2c\x01\u008a\x15\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x07\x2c\x01\u008b\x12\x2c",
            "",
            "\x01\u008c\x01\uffff\x01\u008d\x01\uffff\x01\u008e\x01\uffff"+
            "\x0a\x2e\x03\uffff\x01\x2e\x03\uffff\x1a\x2e\x02\uffff\x01\u008f"+
            "\x01\uffff\x01\x2e\x01\uffff\x1a\x2e",
            "\x02\x28\x03\uffff\x03\x28\x01\uffff\x01\x28\x01\uffff\x02"+
            "\x28\x0c\uffff\x01\x28\x01\uffff\x01\x28\x1c\uffff\x01\x28\x01"+
            "\uffff\x01\x28\x1d\uffff\x01\x28\x01\uffff\x01\x28",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x0d\x2c\x01\u0090\x0c\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x14\x2c\x01\u0091\x05\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x0b\x2c\x01\u0092\x0e\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x04\x2c\x01\u0093\x15\x2c",
            "\x23\x79\x02\x78\x03\x79\x03\x78\x01\x79\x01\x78\x01\x79\x02"+
            "\x78\x0c\x79\x01\x78\x01\x79\x01\x78\x1c\x79\x01\x78\x01\x79"+
            "\x01\x78\x1d\x79\x01\x78\x01\x79\x01\x78\uff82\x79",
            "",
            "\x23\x7b\x02\x7c\x03\x7b\x02\x7c\x01\x7a\x01\x7b\x01\x7c\x01"+
            "\x7b\x01\x7c\x01\u0094\x0c\x7b\x01\x7c\x01\x7b\x01\x7c\x1c\x7b"+
            "\x01\x7c\x01\x7b\x01\x7c\x1d\x7b\x01\x7c\x01\x7b\x01\x7c\uff82"+
            "\x7b",
            "",
            "\x23\x7b\x02\x7c\x03\x7b\x02\x7c\x01\x7a\x01\x7b\x01\x7c\x01"+
            "\x7b\x02\x7c\x0c\x7b\x01\x7c\x01\x7b\x01\x7c\x1c\x7b\x01\x7c"+
            "\x01\x7b\x01\x7c\x1d\x7b\x01\x7c\x01\x7b\x01\x7c\uff82\x7b",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x04\x2c\x01\u0095\x15\x2c",
            "",
            "\x01\x2c\x01\uffff\x0a\x2c\x03\uffff\x01\x2d\x03\uffff\x1a"+
            "\x2c\x01\x2e\x03\uffff\x01\x2c\x01\uffff\x1a\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x03\x2c\x01\u0097\x16"+
            "\x2c\x01\x2e\x03\uffff\x01\x2c\x01\uffff\x1a\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x13\x2c\x01\u0098\x06\x2c",
            "",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x0d\x2c\x01\u0099\x0c\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x03\uffff\x01\x2d\x03\uffff\x1a"+
            "\x2c\x01\x2e\x03\uffff\x01\x2c\x01\uffff\x1a\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x03\uffff\x01\x2d\x03\uffff\x1a"+
            "\x2c\x01\x2e\x03\uffff\x01\x2c\x01\uffff\x1a\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x0b\x2c\x01\u009c\x0e\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x14\x2c\x01\u009d\x05\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\u009e\x01\uffff\x1a\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x0e\x2c\x01\u009f\x0b\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x15\x2c\x01\u00a0\x04\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x01\u00a1\x19\x2c",
            "\x01\u008d\x01\uffff\x01\u008e\x01\uffff\x0a\x2e\x03\uffff"+
            "\x01\x2e\x03\uffff\x1a\x2e\x02\uffff\x01\u008f\x01\uffff\x01"+
            "\x2e\x01\uffff\x1a\x2e",
            "\x01\u00a2\x01\uffff\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01"+
            "\x2e\x01\uffff\x1a\x2e",
            "\x01\u008e\x01\uffff\x0a\x2e\x03\uffff\x01\x2e\x03\uffff\x1a"+
            "\x2e\x02\uffff\x01\u008f\x01\uffff\x01\x2e\x01\uffff\x1a\x2e",
            "\x02\x28\x03\uffff\x03\x28\x01\uffff\x01\x28\x01\uffff\x02"+
            "\x28\x0c\uffff\x01\x28\x01\uffff\x01\x28\x1c\uffff\x01\u00a3"+
            "\x01\uffff\x01\x28\x1d\uffff\x01\x28\x01\uffff\x01\x28",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x13\x2c\x01\u00a4\x06\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x11\x2c\x01\u00a5\x08\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x04\x2c\x01\u00a6\x15\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x03\uffff\x01\x2d\x03\uffff\x1a"+
            "\x2c\x01\x2e\x03\uffff\x01\x2c\x01\uffff\x1a\x2c",
            "\x23\x7b\x02\x7c\x03\x7b\x02\x7c\x01\x7a\x01\x7b\x01\x7c\x01"+
            "\x7b\x02\x7c\x0c\x7b\x01\x7c\x01\x7b\x01\x7c\x1c\x7b\x01\x7c"+
            "\x01\x7b\x01\x7c\x1d\x7b\x01\x7c\x01\x7b\x01\x7c\uff82\x7b",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x0b\x2c\x01\u00a8\x0e\x2c",
            "",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x04\x2c\x01\u00a9\x15\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x03\uffff\x01\x2d\x03\uffff\x1a"+
            "\x2c\x01\x2e\x03\uffff\x01\x2c\x01\uffff\x1a\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x13\x2c\x01\u00ab\x06\x2c",
            "",
            "",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x04\x2c\x01\u00ac\x15\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x0b\x2c\x01\u00ad\x0e\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x13\x2c\x01\u00ae\x06\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x01\x2c\x01\u00af\x18\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x08\x2c\x01\u00b0\x11\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x11\x2c\x01\u00b1\x08\x2c",
            "\x01\u008f",
            "\x01\x2e\x03\uffff\x01\x72\x02\uffff\x01\x2e\x02\uffff\x0a"+
            "\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a\x2e",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x05\x2c\x01\u00b2\x14\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x0d\x2c\x01\u00b3\x0c\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x03\uffff\x01\x2d\x03\uffff\x1a"+
            "\x2c\x01\x2e\x03\uffff\x01\x2c\x01\uffff\x1a\x2c",
            "",
            "\x01\x2c\x01\uffff\x0a\x2c\x03\uffff\x01\x2d\x03\uffff\x1a"+
            "\x2c\x01\x2e\x03\uffff\x01\x2c\x01\uffff\x1a\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x15\x2c\x01\u00b6\x04\x2c",
            "",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x05\x2c\x01\u00b7\x14\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x03\uffff\x01\x2d\x03\uffff\x1a"+
            "\x2c\x01\x2e\x03\uffff\x01\x2c\x01\uffff\x1a\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x13\x2c\x01\u00b9\x06\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x03\uffff\x01\x2d\x03\uffff\x1a"+
            "\x2c\x01\x2e\x03\uffff\x01\x2c\x01\uffff\x1a\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x01\u00bb\x19\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x02\x2c\x01\u00bc\x17\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x04\x2c\x01\u00bd\x15\x2c",
            "\x01\u00be\x05\uffff\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a"+
            "\x2c\x01\x2e\x03\uffff\x01\x2c\x01\uffff\x1a\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x03\uffff\x01\x2d\x03\uffff\x1a"+
            "\x2c\x01\x2e\x03\uffff\x01\x2c\x01\uffff\x1a\x2c",
            "",
            "",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x08\x2c\x01\u00c0\x11\x2c",
            "\x01\u00c1\x05\uffff\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a"+
            "\x2c\x01\x2e\x03\uffff\x01\x2c\x01\uffff\x1a\x2c",
            "",
            "\x01\x2c\x01\uffff\x0a\x2c\x03\uffff\x01\x2d\x03\uffff\x1a"+
            "\x2c\x01\x2e\x03\uffff\x01\x2c\x01\uffff\x1a\x2c",
            "",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x0b\x2c\x01\u00c3\x0e\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x04\x2c\x01\u00c4\x15\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x03\x2c\x01\u00c5\x16\x2c",
            "",
            "",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x02\x2c\x01\u00c6\x17\x2c",
            "",
            "",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\u00c7\x01\uffff\x1a\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\u00c8\x01\uffff\x1a\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\u00c9\x01\uffff\x1a\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x04\x2c\x01\u00ca\x15\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\u00cb\x01\uffff\x1a\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\u00cc\x01\uffff\x1a\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\u00cd\x01\uffff\x1a\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x0f\x2c\x01\u00ce\x0a"+
            "\x2c\x01\x2e\x03\uffff\x01\x2c\x01\uffff\x1a\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x03\uffff\x01\x2d\x03\uffff\x1a"+
            "\x2c\x01\x2e\x03\uffff\x01\x2c\x01\uffff\x1a\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x03\uffff\x01\x2d\x03\uffff\x1a"+
            "\x2c\x01\x2e\x03\uffff\x01\x2c\x01\uffff\x1a\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x03\uffff\x01\x2d\x03\uffff\x1a"+
            "\x2c\x01\x2e\x03\uffff\x01\x2c\x01\uffff\x1a\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x11\x2c\x01\u00d2\x08\x2c",
            "",
            "",
            "",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x0e\x2c\x01\u00d3\x0b\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x07\uffff\x1a\x2c\x01\x2e\x03\uffff"+
            "\x01\x2c\x01\uffff\x0f\x2c\x01\u00d4\x0a\x2c",
            "\x01\x2c\x01\uffff\x0a\x2c\x03\uffff\x01\x2d\x03\uffff\x1a"+
            "\x2c\x01\x2e\x03\uffff\x01\x2c\x01\uffff\x1a\x2c",
            ""
    };

    static readonly short[] DFA38_eot = DFA.UnpackEncodedString(DFA38_eotS);
    static readonly short[] DFA38_eof = DFA.UnpackEncodedString(DFA38_eofS);
    static readonly char[] DFA38_min = DFA.UnpackEncodedStringToUnsignedChars(DFA38_minS);
    static readonly char[] DFA38_max = DFA.UnpackEncodedStringToUnsignedChars(DFA38_maxS);
    static readonly short[] DFA38_accept = DFA.UnpackEncodedString(DFA38_acceptS);
    static readonly short[] DFA38_special = DFA.UnpackEncodedString(DFA38_specialS);
    static readonly short[][] DFA38_transition = DFA.UnpackEncodedStringArray(DFA38_transitionS);

    protected class DFA38 : DFA
    {
        public DFA38(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 38;
            this.eot = DFA38_eot;
            this.eof = DFA38_eof;
            this.min = DFA38_min;
            this.max = DFA38_max;
            this.accept = DFA38_accept;
            this.special = DFA38_special;
            this.transition = DFA38_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__17 | T__18 | T__19 | T__20 | T__21 | T__22 | T__23 | T__24 | T__25 | T__26 | T__27 | T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | RWORD | ID | ARRAY | Keyword | INT | WS | CHARS | LINE_COMMENT | COMMENT | CHARACTER_LITERAL | STRING_LITERAL );"; }
        }

    }


    protected internal int DFA38_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA38_148 = input.LA(1);

                   	s = -1;
                   	if ( (LA38_148 == '*') ) { s = 122; }

                   	else if ( ((LA38_148 >= '#' && LA38_148 <= '$') || (LA38_148 >= '(' && LA38_148 <= ')') || LA38_148 == ',' || (LA38_148 >= '.' && LA38_148 <= '/') || LA38_148 == '<' || LA38_148 == '>' || LA38_148 == '[' || LA38_148 == ']' || LA38_148 == '{' || LA38_148 == '}') ) { s = 124; }

                   	else if ( ((LA38_148 >= '\u0000' && LA38_148 <= '\"') || (LA38_148 >= '%' && LA38_148 <= '\'') || LA38_148 == '+' || LA38_148 == '-' || (LA38_148 >= '0' && LA38_148 <= ';') || LA38_148 == '=' || (LA38_148 >= '?' && LA38_148 <= 'Z') || LA38_148 == '\\' || (LA38_148 >= '^' && LA38_148 <= 'z') || LA38_148 == '|' || (LA38_148 >= '~' && LA38_148 <= '\uFFFF')) ) { s = 123; }

                   	else s = 40;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA38_93 = input.LA(1);

                   	s = -1;
                   	if ( (LA38_93 == '*') ) { s = 122; }

                   	else if ( ((LA38_93 >= '\u0000' && LA38_93 <= '\"') || (LA38_93 >= '%' && LA38_93 <= '\'') || LA38_93 == '+' || LA38_93 == '-' || (LA38_93 >= '0' && LA38_93 <= ';') || LA38_93 == '=' || (LA38_93 >= '?' && LA38_93 <= 'Z') || LA38_93 == '\\' || (LA38_93 >= '^' && LA38_93 <= 'z') || LA38_93 == '|' || (LA38_93 >= '~' && LA38_93 <= '\uFFFF')) ) { s = 123; }

                   	else if ( ((LA38_93 >= '#' && LA38_93 <= '$') || (LA38_93 >= '(' && LA38_93 <= ')') || LA38_93 == ',' || (LA38_93 >= '.' && LA38_93 <= '/') || LA38_93 == '<' || LA38_93 == '>' || LA38_93 == '[' || LA38_93 == ']' || LA38_93 == '{' || LA38_93 == '}') ) { s = 124; }

                   	else s = 40;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA38_122 = input.LA(1);

                   	s = -1;
                   	if ( (LA38_122 == '/') ) { s = 148; }

                   	else if ( (LA38_122 == '*') ) { s = 122; }

                   	else if ( ((LA38_122 >= '#' && LA38_122 <= '$') || (LA38_122 >= '(' && LA38_122 <= ')') || LA38_122 == ',' || LA38_122 == '.' || LA38_122 == '<' || LA38_122 == '>' || LA38_122 == '[' || LA38_122 == ']' || LA38_122 == '{' || LA38_122 == '}') ) { s = 124; }

                   	else if ( ((LA38_122 >= '\u0000' && LA38_122 <= '\"') || (LA38_122 >= '%' && LA38_122 <= '\'') || LA38_122 == '+' || LA38_122 == '-' || (LA38_122 >= '0' && LA38_122 <= ';') || LA38_122 == '=' || (LA38_122 >= '?' && LA38_122 <= 'Z') || LA38_122 == '\\' || (LA38_122 >= '^' && LA38_122 <= 'z') || LA38_122 == '|' || (LA38_122 >= '~' && LA38_122 <= '\uFFFF')) ) { s = 123; }

                   	else s = 40;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA38_92 = input.LA(1);

                   	s = -1;
                   	if ( ((LA38_92 >= '#' && LA38_92 <= '$') || (LA38_92 >= '(' && LA38_92 <= '*') || LA38_92 == ',' || (LA38_92 >= '.' && LA38_92 <= '/') || LA38_92 == '<' || LA38_92 == '>' || LA38_92 == '[' || LA38_92 == ']' || LA38_92 == '{' || LA38_92 == '}') ) { s = 120; }

                   	else if ( ((LA38_92 >= '\u0000' && LA38_92 <= '\"') || (LA38_92 >= '%' && LA38_92 <= '\'') || LA38_92 == '+' || LA38_92 == '-' || (LA38_92 >= '0' && LA38_92 <= ';') || LA38_92 == '=' || (LA38_92 >= '?' && LA38_92 <= 'Z') || LA38_92 == '\\' || (LA38_92 >= '^' && LA38_92 <= 'z') || LA38_92 == '|' || (LA38_92 >= '~' && LA38_92 <= '\uFFFF')) ) { s = 121; }

                   	else s = 40;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA38_120 = input.LA(1);

                   	s = -1;
                   	if ( ((LA38_120 >= '#' && LA38_120 <= '$') || (LA38_120 >= '(' && LA38_120 <= '*') || LA38_120 == ',' || (LA38_120 >= '.' && LA38_120 <= '/') || LA38_120 == '<' || LA38_120 == '>' || LA38_120 == '[' || LA38_120 == ']' || LA38_120 == '{' || LA38_120 == '}') ) { s = 120; }

                   	else if ( ((LA38_120 >= '\u0000' && LA38_120 <= '\"') || (LA38_120 >= '%' && LA38_120 <= '\'') || LA38_120 == '+' || LA38_120 == '-' || (LA38_120 >= '0' && LA38_120 <= ';') || LA38_120 == '=' || (LA38_120 >= '?' && LA38_120 <= 'Z') || LA38_120 == '\\' || (LA38_120 >= '^' && LA38_120 <= 'z') || LA38_120 == '|' || (LA38_120 >= '~' && LA38_120 <= '\uFFFF')) ) { s = 121; }

                   	else s = 40;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA38_124 = input.LA(1);

                   	s = -1;
                   	if ( (LA38_124 == '*') ) { s = 122; }

                   	else if ( ((LA38_124 >= '#' && LA38_124 <= '$') || (LA38_124 >= '(' && LA38_124 <= ')') || LA38_124 == ',' || (LA38_124 >= '.' && LA38_124 <= '/') || LA38_124 == '<' || LA38_124 == '>' || LA38_124 == '[' || LA38_124 == ']' || LA38_124 == '{' || LA38_124 == '}') ) { s = 124; }

                   	else if ( ((LA38_124 >= '\u0000' && LA38_124 <= '\"') || (LA38_124 >= '%' && LA38_124 <= '\'') || LA38_124 == '+' || LA38_124 == '-' || (LA38_124 >= '0' && LA38_124 <= ';') || LA38_124 == '=' || (LA38_124 >= '?' && LA38_124 <= 'Z') || LA38_124 == '\\' || (LA38_124 >= '^' && LA38_124 <= 'z') || LA38_124 == '|' || (LA38_124 >= '~' && LA38_124 <= '\uFFFF')) ) { s = 123; }

                   	else s = 40;

                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae38 =
            new NoViableAltException(dfa.Description, 38, _s, input);
        dfa.Error(nvae38);
        throw nvae38;
    }
 
    
}
