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


using Antlr.StringTemplate;
using Antlr.StringTemplate.Language;
using Hashtable = System.Collections.Hashtable;
public partial class PatternGeneratorParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"ID", 
		"INT", 
		"Keyword", 
		"ARRAY", 
		"RWORD", 
		"STRING_LITERAL", 
		"WS", 
		"CHARS", 
		"LINE_COMMENT", 
		"COMMENT", 
		"EscapeSequence", 
		"CHARACTER_LITERAL", 
		"OctalEscape", 
		"';'", 
		"'.'", 
		"'kernel'", 
		"'('", 
		"','", 
		"')'", 
		"'int'", 
		"'char'", 
		"'float'", 
		"'bool'", 
		"'void'", 
		"'double'", 
		"'size_t'", 
		"'cudaDeviceProp'", 
		"'#include'", 
		"'__global__'", 
		"'__device__'", 
		"'__shared__'", 
		"'{'", 
		"'}'", 
		"'*'", 
		"'='", 
		"'+'", 
		"'for'", 
		"'-='", 
		"'+='", 
		"'printf('", 
		"'fprintf('", 
		"'default'", 
		"':'", 
		"'return'", 
		"'while'", 
		"'if'", 
		"'else'", 
		"'++'", 
		"'--'", 
		"'*='", 
		"'=='", 
		"'!='", 
		"'<'", 
		"'>'", 
		"'<='", 
		"'>='", 
		"'&&'", 
		"'||'", 
		"'-'", 
		"'/'", 
		"'%'", 
		"'['", 
		"']'"
    };

    public const int T__66 = 66;
    public const int T__64 = 64;
    public const int T__29 = 29;
    public const int T__65 = 65;
    public const int T__28 = 28;
    public const int RWORD = 8;
    public const int T__62 = 62;
    public const int T__27 = 27;
    public const int T__63 = 63;
    public const int T__26 = 26;
    public const int T__25 = 25;
    public const int T__24 = 24;
    public const int T__23 = 23;
    public const int T__22 = 22;
    public const int T__21 = 21;
    public const int T__20 = 20;
    public const int ID = 4;
    public const int T__61 = 61;
    public const int T__60 = 60;
    public const int EOF = -1;
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
    public const int WS = 10;
    public const int T__33 = 33;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int CHARS = 11;
    public const int OctalEscape = 16;
    public const int EscapeSequence = 14;

    // delegates
    // delegators

    protected class slist_scope 
    {
        protected internal IList locals;
        protected internal // must be defined one per semicolon
            IList stats;
    }
    protected Stack slist_stack = new Stack();



        public PatternGeneratorParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public PatternGeneratorParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected StringTemplateGroup templateLib =
      new StringTemplateGroup("PatternGeneratorParserTemplates", typeof(AngleBracketTemplateLexer));

    public StringTemplateGroup TemplateLib
    {
     	get { return this.templateLib; }
     	set { this.templateLib = value; }
    }

    /// <summary> Allows convenient multi-value initialization:
    ///  "new STAttrMap().Add(...).Add(...)"
    /// </summary>
    protected class STAttrMap : Hashtable
    {
      public STAttrMap Add(string attrName, object value) 
      {
        base.Add(attrName, value);
        return this;
      }
      public STAttrMap Add(string attrName, int value) 
      {
        base.Add(attrName, value);
        return this;
      }
    }

    override public string[] TokenNames {
		get { return PatternGeneratorParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g"; }
    }


        public string ArraytoString(ArrayList index1,String Separator)
                {
                    string a = string.Empty ;
                    int i;
                    for (i = 0; i < index1.Count; i++)
                    {
                        a += index1[i];
                        if(i!=index1.Count-1)
                        {
                        	a+=Separator;
                        }
                    }
                    return a;
                }
    		


    protected class pattern_scope 
    {
        protected internal IList globals;
        protected internal IList functions;
        protected internal IList kernelvars;
        protected internal IList includes;
        protected internal IList mainstats;
        protected internal IList kernelcopyin;
        protected internal IList kernelcopyout;
        protected internal IList kernelalloc;
        protected internal IList kernelvarfree;
        protected internal IList kernelvarsize;
        protected internal String kernelpar;
        protected internal String kernelpar2;
        protected internal String temp;
    }
    protected Stack pattern_stack = new Stack();

    public class pattern_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "pattern"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:33:1: pattern : ( declaration )+ -> pattern(kernelfunction=$pattern::functions);
    public PatternGeneratorParser.pattern_return pattern() // throws RecognitionException [1]
    {   
        pattern_stack.Push(new pattern_scope());
        PatternGeneratorParser.pattern_return retval = new PatternGeneratorParser.pattern_return();
        retval.Start = input.LT(1);


          ((pattern_scope)pattern_stack.Peek()).globals =  new ArrayList();
          ((pattern_scope)pattern_stack.Peek()).functions =  new ArrayList();
          ((pattern_scope)pattern_stack.Peek()).includes =  new ArrayList();
          ((pattern_scope)pattern_stack.Peek()).mainstats =  new ArrayList();
          ((pattern_scope)pattern_stack.Peek()).kernelvars =  new ArrayList();
          ((pattern_scope)pattern_stack.Peek()).kernelcopyin =  new ArrayList();
          ((pattern_scope)pattern_stack.Peek()).kernelcopyout =  new ArrayList();
          ((pattern_scope)pattern_stack.Peek()).kernelalloc =  new ArrayList();
          ((pattern_scope)pattern_stack.Peek()).kernelvarfree =  new ArrayList();
          ((pattern_scope)pattern_stack.Peek()).kernelvarsize =  new ArrayList();


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:63:5: ( ( declaration )+ -> pattern(kernelfunction=$pattern::functions))
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:63:9: ( declaration )+
            {
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:63:9: ( declaration )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= 32 && LA1_0 <= 34)) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:63:9: declaration
            			    {
            			    	PushFollow(FOLLOW_declaration_in_pattern62);
            			    	declaration();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            throw eee1;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements



            	// TEMPLATE REWRITE
            	// 64:7: -> pattern(kernelfunction=$pattern::functions)
            	{
            	    retval.ST = templateLib.GetInstanceOf("pattern",
            	  new STAttrMap().Add("kernelfunction", ((pattern_scope)pattern_stack.Peek()).functions));
            	}


            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            pattern_stack.Pop();
        }
        return retval;
    }
    // $ANTLR end "pattern"

    public class declaration_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "declaration"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:67:5: declaration : kernelfunction ;
    public PatternGeneratorParser.declaration_return declaration() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.declaration_return retval = new PatternGeneratorParser.declaration_return();
        retval.Start = input.LT(1);

        PatternGeneratorParser.kernelfunction_return kernelfunction1 = default(PatternGeneratorParser.kernelfunction_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:68:6: ( kernelfunction )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:69:5: kernelfunction
            {
            	PushFollow(FOLLOW_kernelfunction_in_declaration109);
            	kernelfunction1 = kernelfunction();
            	state.followingStackPointer--;

            	((pattern_scope)pattern_stack.Peek()).functions.Add(((kernelfunction1 != null) ? kernelfunction1.ST : null));

            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "declaration"

    public class variable_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "variable"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:80:1: variable : ( type declarator ';' -> variable(type=$type.stname=$declarator.st) | type arraydeclarator ';' -> variable(type=$type.stname=$arraydeclarator.st));
    public PatternGeneratorParser.variable_return variable() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.variable_return retval = new PatternGeneratorParser.variable_return();
        retval.Start = input.LT(1);

        PatternGeneratorParser.type_return type2 = default(PatternGeneratorParser.type_return);

        PatternGeneratorParser.declarator_return declarator3 = default(PatternGeneratorParser.declarator_return);

        PatternGeneratorParser.type_return type4 = default(PatternGeneratorParser.type_return);

        PatternGeneratorParser.arraydeclarator_return arraydeclarator5 = default(PatternGeneratorParser.arraydeclarator_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:81:5: ( type declarator ';' -> variable(type=$type.stname=$declarator.st) | type arraydeclarator ';' -> variable(type=$type.stname=$arraydeclarator.st))
            int alt2 = 2;
            alt2 = dfa2.Predict(input);
            switch (alt2) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:81:9: type declarator ';'
                    {
                    	PushFollow(FOLLOW_type_in_variable142);
                    	type2 = type();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_declarator_in_variable145);
                    	declarator3 = declarator();
                    	state.followingStackPointer--;

                    	Match(input,17,FOLLOW_17_in_variable147); 


                    	// TEMPLATE REWRITE
                    	// 82:9: -> variable(type=$type.stname=$declarator.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("variable",
                    	  new STAttrMap().Add("type", ((type2 != null) ? type2.ST : null)).Add("name", ((declarator3 != null) ? declarator3.ST : null)));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:83:10: type arraydeclarator ';'
                    {
                    	PushFollow(FOLLOW_type_in_variable179);
                    	type4 = type();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_arraydeclarator_in_variable181);
                    	arraydeclarator5 = arraydeclarator();
                    	state.followingStackPointer--;

                    	Match(input,17,FOLLOW_17_in_variable183); 


                    	// TEMPLATE REWRITE
                    	// 84:9: -> variable(type=$type.stname=$arraydeclarator.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("variable",
                    	  new STAttrMap().Add("type", ((type4 != null) ? type4.ST : null)).Add("name", ((arraydeclarator5 != null) ? arraydeclarator5.ST : null)));
                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "variable"

    public class statement_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "statement"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:87:1: statement : stat -> type(name=$stat.st);
    public PatternGeneratorParser.statement_return statement() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.statement_return retval = new PatternGeneratorParser.statement_return();
        retval.Start = input.LT(1);

        PatternGeneratorParser.stat_return stat6 = default(PatternGeneratorParser.stat_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:88:1: ( stat -> type(name=$stat.st))
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:88:8: stat
            {
            	PushFollow(FOLLOW_stat_in_statement226);
            	stat6 = stat();
            	state.followingStackPointer--;



            	// TEMPLATE REWRITE
            	// 88:13: -> type(name=$stat.st)
            	{
            	    retval.ST = templateLib.GetInstanceOf("type",
            	  new STAttrMap().Add("name", ((stat6 != null) ? stat6.ST : null)));
            	}


            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "statement"

    public class statement_list_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "statement_list"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:91:1: statement_list : ( statement )+ ;
    public PatternGeneratorParser.statement_list_return statement_list() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.statement_list_return retval = new PatternGeneratorParser.statement_list_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:92:2: ( ( statement )+ )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:92:4: ( statement )+
            {
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:92:4: ( statement )+
            	int cnt3 = 0;
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= ID && LA3_0 <= INT) || (LA3_0 >= ARRAY && LA3_0 <= RWORD) || LA3_0 == 17 || (LA3_0 >= 19 && LA3_0 <= 20) || (LA3_0 >= 23 && LA3_0 <= 31) || LA3_0 == 35 || LA3_0 == 40 || (LA3_0 >= 43 && LA3_0 <= 45) || (LA3_0 >= 47 && LA3_0 <= 50) || LA3_0 == 65) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:92:4: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_statement_list246);
            			    	statement();
            			    	state.followingStackPointer--;


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

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "statement_list"

    public class include_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "include"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:97:1: include : type kdeclarator -> include(type=$type.stname=$kdeclarator.st);
    public PatternGeneratorParser.include_return include() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.include_return retval = new PatternGeneratorParser.include_return();
        retval.Start = input.LT(1);

        PatternGeneratorParser.type_return type7 = default(PatternGeneratorParser.type_return);

        PatternGeneratorParser.kdeclarator_return kdeclarator8 = default(PatternGeneratorParser.kdeclarator_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:98:1: ( type kdeclarator -> include(type=$type.stname=$kdeclarator.st))
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:98:9: type kdeclarator
            {
            	PushFollow(FOLLOW_type_in_include265);
            	type7 = type();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_kdeclarator_in_include267);
            	kdeclarator8 = kdeclarator();
            	state.followingStackPointer--;



            	// TEMPLATE REWRITE
            	// 100:2: -> include(type=$type.stname=$kdeclarator.st)
            	{
            	    retval.ST = templateLib.GetInstanceOf("include",
            	  new STAttrMap().Add("type", ((type7 != null) ? type7.ST : null)).Add("name", ((kdeclarator8 != null) ? kdeclarator8.ST : null)));
            	}


            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "include"

    public class define_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "define"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:104:1: define : rdeclarator declarator t+= digits ( '.' t+= digits )* -> define(type=$rdeclarator.stname=$declarator.stval=ArraytoString((ArrayList)$t,\".\"));
    public PatternGeneratorParser.define_return define() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.define_return retval = new PatternGeneratorParser.define_return();
        retval.Start = input.LT(1);

        IList list_t = null;
        PatternGeneratorParser.rdeclarator_return rdeclarator9 = default(PatternGeneratorParser.rdeclarator_return);

        PatternGeneratorParser.declarator_return declarator10 = default(PatternGeneratorParser.declarator_return);

        PatternGeneratorParser.digits_return t = default(PatternGeneratorParser.digits_return);
         t = null;
        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:105:1: ( rdeclarator declarator t+= digits ( '.' t+= digits )* -> define(type=$rdeclarator.stname=$declarator.stval=ArraytoString((ArrayList)$t,\".\")))
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:106:2: rdeclarator declarator t+= digits ( '.' t+= digits )*
            {
            	PushFollow(FOLLOW_rdeclarator_in_define296);
            	rdeclarator9 = rdeclarator();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_declarator_in_define298);
            	declarator10 = declarator();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_digits_in_define302);
            	t = digits();
            	state.followingStackPointer--;

            	if (list_t == null) list_t = new ArrayList();
            	list_t.Add(t.Template);

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:106:35: ( '.' t+= digits )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == 18) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:106:36: '.' t+= digits
            			    {
            			    	Match(input,18,FOLLOW_18_in_define305); 
            			    	PushFollow(FOLLOW_digits_in_define309);
            			    	t = digits();
            			    	state.followingStackPointer--;

            			    	if (list_t == null) list_t = new ArrayList();
            			    	list_t.Add(t.Template);


            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements



            	// TEMPLATE REWRITE
            	// 107:2: -> define(type=$rdeclarator.stname=$declarator.stval=ArraytoString((ArrayList)$t,\".\"))
            	{
            	    retval.ST = templateLib.GetInstanceOf("define",
            	  new STAttrMap().Add("type", ((rdeclarator9 != null) ? rdeclarator9.ST : null)).Add("name", ((declarator10 != null) ? declarator10.ST : null)).Add("val", ArraytoString((ArrayList)list_t,".")));
            	}


            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "define"

    public class declarator_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "declarator"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:110:1: declarator : ID -> {new StringTemplate($ID.text)};
    public PatternGeneratorParser.declarator_return declarator() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.declarator_return retval = new PatternGeneratorParser.declarator_return();
        retval.Start = input.LT(1);

        IToken ID11 = null;

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:111:5: ( ID -> {new StringTemplate($ID.text)})
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:111:9: ID
            {
            	ID11=(IToken)Match(input,ID,FOLLOW_ID_in_declarator345); 


            	// TEMPLATE REWRITE
            	// 111:12: -> {new StringTemplate($ID.text)}
            	{
            	    retval.ST = new StringTemplate(((ID11 != null) ? ID11.Text : null));
            	}


            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "declarator"

    public class digits_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "digits"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:115:1: digits : INT -> {new StringTemplate($INT.text)};
    public PatternGeneratorParser.digits_return digits() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.digits_return retval = new PatternGeneratorParser.digits_return();
        retval.Start = input.LT(1);

        IToken INT12 = null;

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:116:5: ( INT -> {new StringTemplate($INT.text)})
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:116:9: INT
            {
            	INT12=(IToken)Match(input,INT,FOLLOW_INT_in_digits374); 


            	// TEMPLATE REWRITE
            	// 116:13: -> {new StringTemplate($INT.text)}
            	{
            	    retval.ST = new StringTemplate(((INT12 != null) ? INT12.Text : null));
            	}


            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "digits"

    public class kdeclarator_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "kdeclarator"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:119:1: kdeclarator : Keyword -> {new StringTemplate($Keyword.text)};
    public PatternGeneratorParser.kdeclarator_return kdeclarator() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.kdeclarator_return retval = new PatternGeneratorParser.kdeclarator_return();
        retval.Start = input.LT(1);

        IToken Keyword13 = null;

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:120:5: ( Keyword -> {new StringTemplate($Keyword.text)})
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:120:9: Keyword
            {
            	Keyword13=(IToken)Match(input,Keyword,FOLLOW_Keyword_in_kdeclarator398); 


            	// TEMPLATE REWRITE
            	// 120:17: -> {new StringTemplate($Keyword.text)}
            	{
            	    retval.ST = new StringTemplate(((Keyword13 != null) ? Keyword13.Text : null));
            	}


            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "kdeclarator"

    public class arraydeclarator_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "arraydeclarator"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:124:1: arraydeclarator : ARRAY -> {new StringTemplate($ARRAY.text)};
    public PatternGeneratorParser.arraydeclarator_return arraydeclarator() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.arraydeclarator_return retval = new PatternGeneratorParser.arraydeclarator_return();
        retval.Start = input.LT(1);

        IToken ARRAY14 = null;

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:125:5: ( ARRAY -> {new StringTemplate($ARRAY.text)})
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:125:9: ARRAY
            {
            	ARRAY14=(IToken)Match(input,ARRAY,FOLLOW_ARRAY_in_arraydeclarator428); 


            	// TEMPLATE REWRITE
            	// 125:15: -> {new StringTemplate($ARRAY.text)}
            	{
            	    retval.ST = new StringTemplate(((ARRAY14 != null) ? ARRAY14.Text : null));
            	}


            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "arraydeclarator"

    public class rdeclarator_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "rdeclarator"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:128:1: rdeclarator : RWORD -> {new StringTemplate($RWORD.text)};
    public PatternGeneratorParser.rdeclarator_return rdeclarator() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.rdeclarator_return retval = new PatternGeneratorParser.rdeclarator_return();
        retval.Start = input.LT(1);

        IToken RWORD15 = null;

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:129:5: ( RWORD -> {new StringTemplate($RWORD.text)})
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:129:9: RWORD
            {
            	RWORD15=(IToken)Match(input,RWORD,FOLLOW_RWORD_in_rdeclarator455); 


            	// TEMPLATE REWRITE
            	// 129:15: -> {new StringTemplate($RWORD.text)}
            	{
            	    retval.ST = new StringTemplate(((RWORD15 != null) ? RWORD15.Text : null));
            	}


            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "rdeclarator"

    protected class kernelfunction_scope 
    {
        protected internal String name;
    }
    protected Stack kernelfunction_stack = new Stack();

    public class kernelfunction_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "kernelfunction"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:134:1: kernelfunction : cudafunctiontype type 'kernel' '(' (p+= formalParameter ( ',' p+= formalParameter )* )? ')' block -> kernelfunction(cudafunctiontype=$cudafunctiontype.sttype=$type.stname=\"kernel\"locals=$slist::localsstats=$slist::statsargs=$p);
    public PatternGeneratorParser.kernelfunction_return kernelfunction() // throws RecognitionException [1]
    {   
        slist_stack.Push(new slist_scope());
        kernelfunction_stack.Push(new kernelfunction_scope());
        PatternGeneratorParser.kernelfunction_return retval = new PatternGeneratorParser.kernelfunction_return();
        retval.Start = input.LT(1);

        IList list_p = null;
        PatternGeneratorParser.cudafunctiontype_return cudafunctiontype16 = default(PatternGeneratorParser.cudafunctiontype_return);

        PatternGeneratorParser.type_return type17 = default(PatternGeneratorParser.type_return);

        PatternGeneratorParser.formalParameter_return p = default(PatternGeneratorParser.formalParameter_return);
         p = null;

        	((slist_scope)slist_stack.Peek()).locals =  new ArrayList();
        	((slist_scope)slist_stack.Peek()).stats =  new ArrayList();

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:143:3: ( cudafunctiontype type 'kernel' '(' (p+= formalParameter ( ',' p+= formalParameter )* )? ')' block -> kernelfunction(cudafunctiontype=$cudafunctiontype.sttype=$type.stname=\"kernel\"locals=$slist::localsstats=$slist::statsargs=$p))
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:143:6: cudafunctiontype type 'kernel' '(' (p+= formalParameter ( ',' p+= formalParameter )* )? ')' block
            {
            	PushFollow(FOLLOW_cudafunctiontype_in_kernelfunction497);
            	cudafunctiontype16 = cudafunctiontype();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_type_in_kernelfunction499);
            	type17 = type();
            	state.followingStackPointer--;

            	Match(input,19,FOLLOW_19_in_kernelfunction501); 
            	((kernelfunction_scope)kernelfunction_stack.Peek()).name = "kernel";
            	Match(input,20,FOLLOW_20_in_kernelfunction513); 
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:144:13: (p+= formalParameter ( ',' p+= formalParameter )* )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == RWORD || LA6_0 == 19 || (LA6_0 >= 23 && LA6_0 <= 31)) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:144:15: p+= formalParameter ( ',' p+= formalParameter )*
            	        {
            	        	PushFollow(FOLLOW_formalParameter_in_kernelfunction519);
            	        	p = formalParameter();
            	        	state.followingStackPointer--;

            	        	if (list_p == null) list_p = new ArrayList();
            	        	list_p.Add(p.Template);

            	        	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:144:34: ( ',' p+= formalParameter )*
            	        	do 
            	        	{
            	        	    int alt5 = 2;
            	        	    int LA5_0 = input.LA(1);

            	        	    if ( (LA5_0 == 21) )
            	        	    {
            	        	        alt5 = 1;
            	        	    }


            	        	    switch (alt5) 
            	        		{
            	        			case 1 :
            	        			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:144:36: ',' p+= formalParameter
            	        			    {
            	        			    	Match(input,21,FOLLOW_21_in_kernelfunction523); 
            	        			    	PushFollow(FOLLOW_formalParameter_in_kernelfunction527);
            	        			    	p = formalParameter();
            	        			    	state.followingStackPointer--;

            	        			    	if (list_p == null) list_p = new ArrayList();
            	        			    	list_p.Add(p.Template);


            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop5;
            	        	    }
            	        	} while (true);

            	        	loop5:
            	        		;	// Stops C# compiler whining that label 'loop5' has no statements


            	        }
            	        break;

            	}

            	Match(input,22,FOLLOW_22_in_kernelfunction535); 
            	PushFollow(FOLLOW_block_in_kernelfunction545);
            	block();
            	state.followingStackPointer--;



            	// TEMPLATE REWRITE
            	// 146:9: -> kernelfunction(cudafunctiontype=$cudafunctiontype.sttype=$type.stname=\"kernel\"locals=$slist::localsstats=$slist::statsargs=$p)
            	{
            	    retval.ST = templateLib.GetInstanceOf("kernelfunction",
            	  new STAttrMap().Add("cudafunctiontype", ((cudafunctiontype16 != null) ? cudafunctiontype16.ST : null)).Add("type", ((type17 != null) ? type17.ST : null)).Add("name", "kernel").Add("locals", ((slist_scope)slist_stack.Peek()).locals).Add("stats", ((slist_scope)slist_stack.Peek()).stats).Add("args", list_p));
            	}


            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            slist_stack.Pop();
            kernelfunction_stack.Pop();
        }
        return retval;
    }
    // $ANTLR end "kernelfunction"

    public class formalParameter_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "formalParameter"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:152:1: formalParameter : type ( declarator )* -> parameter(type=$type.stname=$declarator.st);
    public PatternGeneratorParser.formalParameter_return formalParameter() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.formalParameter_return retval = new PatternGeneratorParser.formalParameter_return();
        retval.Start = input.LT(1);

        PatternGeneratorParser.type_return type18 = default(PatternGeneratorParser.type_return);

        PatternGeneratorParser.declarator_return declarator19 = default(PatternGeneratorParser.declarator_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:153:5: ( type ( declarator )* -> parameter(type=$type.stname=$declarator.st))
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:153:9: type ( declarator )*
            {
            	PushFollow(FOLLOW_type_in_formalParameter664);
            	type18 = type();
            	state.followingStackPointer--;

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:153:14: ( declarator )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == ID) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:153:15: declarator
            			    {
            			    	PushFollow(FOLLOW_declarator_in_formalParameter667);
            			    	declarator19 = declarator();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements



            	// TEMPLATE REWRITE
            	// 154:9: -> parameter(type=$type.stname=$declarator.st)
            	{
            	    retval.ST = templateLib.GetInstanceOf("parameter",
            	  new STAttrMap().Add("type", ((type18 != null) ? type18.ST : null)).Add("name", ((declarator19 != null) ? declarator19.ST : null)));
            	}


            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "formalParameter"

    public class type_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "type"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:159:1: type : ( 'int' -> type_int() | 'char' -> type_char() | 'float' -> type_float() | 'bool' -> type_bool() | 'kernel' -> type_kernel() | 'void' -> type(name=\"void\") | 'double' -> type(name=\"double\") | 'size_t' -> type(name=\"size_t\") | 'cudaDeviceProp' -> type(name=\"cudaDeviceProp\") | '#include' -> type(name=\"#include\") | '#define' -> type(name=\"#define\"));
    public PatternGeneratorParser.type_return type() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.type_return retval = new PatternGeneratorParser.type_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:160:5: ( 'int' -> type_int() | 'char' -> type_char() | 'float' -> type_float() | 'bool' -> type_bool() | 'kernel' -> type_kernel() | 'void' -> type(name=\"void\") | 'double' -> type(name=\"double\") | 'size_t' -> type(name=\"size_t\") | 'cudaDeviceProp' -> type(name=\"cudaDeviceProp\") | '#include' -> type(name=\"#include\") | '#define' -> type(name=\"#define\"))
            int alt8 = 11;
            switch ( input.LA(1) ) 
            {
            case 23:
            	{
                alt8 = 1;
                }
                break;
            case 24:
            	{
                alt8 = 2;
                }
                break;
            case 25:
            	{
                alt8 = 3;
                }
                break;
            case 26:
            	{
                alt8 = 4;
                }
                break;
            case 19:
            	{
                alt8 = 5;
                }
                break;
            case 27:
            	{
                alt8 = 6;
                }
                break;
            case 28:
            	{
                alt8 = 7;
                }
                break;
            case 29:
            	{
                alt8 = 8;
                }
                break;
            case 30:
            	{
                alt8 = 9;
                }
                break;
            case 31:
            	{
                alt8 = 10;
                }
                break;
            case RWORD:
            	{
                alt8 = 11;
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
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:160:9: 'int'
                    {
                    	Match(input,23,FOLLOW_23_in_type711); 


                    	// TEMPLATE REWRITE
                    	// 160:18: -> type_int()
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type_int");
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:161:9: 'char'
                    {
                    	Match(input,24,FOLLOW_24_in_type730); 


                    	// TEMPLATE REWRITE
                    	// 161:18: -> type_char()
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type_char");
                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:162:9: 'float'
                    {
                    	Match(input,25,FOLLOW_25_in_type748); 


                    	// TEMPLATE REWRITE
                    	// 162:18: -> type_float()
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type_float");
                    	}


                    }
                    break;
                case 4 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:163:9: 'bool'
                    {
                    	Match(input,26,FOLLOW_26_in_type765); 


                    	// TEMPLATE REWRITE
                    	// 163:17: -> type_bool()
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type_bool");
                    	}


                    }
                    break;
                case 5 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:164:9: 'kernel'
                    {
                    	Match(input,19,FOLLOW_19_in_type782); 


                    	// TEMPLATE REWRITE
                    	// 164:18: -> type_kernel()
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type_kernel");
                    	}


                    }
                    break;
                case 6 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:165:9: 'void'
                    {
                    	Match(input,27,FOLLOW_27_in_type798); 


                    	// TEMPLATE REWRITE
                    	// 165:17: -> type(name=\"void\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "void"));
                    	}


                    }
                    break;
                case 7 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:166:9: 'double'
                    {
                    	Match(input,28,FOLLOW_28_in_type818); 


                    	// TEMPLATE REWRITE
                    	// 166:19: -> type(name=\"double\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "double"));
                    	}


                    }
                    break;
                case 8 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:167:9: 'size_t'
                    {
                    	Match(input,29,FOLLOW_29_in_type838); 


                    	// TEMPLATE REWRITE
                    	// 167:19: -> type(name=\"size_t\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "size_t"));
                    	}


                    }
                    break;
                case 9 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:168:9: 'cudaDeviceProp'
                    {
                    	Match(input,30,FOLLOW_30_in_type858); 


                    	// TEMPLATE REWRITE
                    	// 168:25: -> type(name=\"cudaDeviceProp\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "cudaDeviceProp"));
                    	}


                    }
                    break;
                case 10 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:172:9: '#include'
                    {
                    	Match(input,31,FOLLOW_31_in_type887); 


                    	// TEMPLATE REWRITE
                    	// 172:21: -> type(name=\"#include\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "#include"));
                    	}


                    }
                    break;
                case 11 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:173:9: '#define'
                    {
                    	Match(input,RWORD,FOLLOW_RWORD_in_type907); 


                    	// TEMPLATE REWRITE
                    	// 173:20: -> type(name=\"#define\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "#define"));
                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "type"

    public class cudafunctiontype_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "cudafunctiontype"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:177:1: cudafunctiontype : ( '__global__' -> type(name=\"__global__\") | '__device__' -> type(name=\"__device__\") | '__shared__' -> type(name=\"__shared__\"));
    public PatternGeneratorParser.cudafunctiontype_return cudafunctiontype() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.cudafunctiontype_return retval = new PatternGeneratorParser.cudafunctiontype_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:178:1: ( '__global__' -> type(name=\"__global__\") | '__device__' -> type(name=\"__device__\") | '__shared__' -> type(name=\"__shared__\"))
            int alt9 = 3;
            switch ( input.LA(1) ) 
            {
            case 32:
            	{
                alt9 = 1;
                }
                break;
            case 33:
            	{
                alt9 = 2;
                }
                break;
            case 34:
            	{
                alt9 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d9s0 =
            	        new NoViableAltException("", 9, 0, input);

            	    throw nvae_d9s0;
            }

            switch (alt9) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:179:3: '__global__'
                    {
                    	Match(input,32,FOLLOW_32_in_cudafunctiontype937); 


                    	// TEMPLATE REWRITE
                    	// 179:16: -> type(name=\"__global__\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "__global__"));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:180:4: '__device__'
                    {
                    	Match(input,33,FOLLOW_33_in_cudafunctiontype951); 


                    	// TEMPLATE REWRITE
                    	// 180:17: -> type(name=\"__device__\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "__device__"));
                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:181:4: '__shared__'
                    {
                    	Match(input,34,FOLLOW_34_in_cudafunctiontype965); 


                    	// TEMPLATE REWRITE
                    	// 181:17: -> type(name=\"__shared__\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "__shared__"));
                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "cudafunctiontype"

    public class block_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "block"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:184:1: block : '{' ( variable )* ( stat )* '}' ;
    public PatternGeneratorParser.block_return block() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.block_return retval = new PatternGeneratorParser.block_return();
        retval.Start = input.LT(1);

        PatternGeneratorParser.variable_return variable20 = default(PatternGeneratorParser.variable_return);

        PatternGeneratorParser.stat_return stat21 = default(PatternGeneratorParser.stat_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:185:5: ( '{' ( variable )* ( stat )* '}' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:185:8: '{' ( variable )* ( stat )* '}'
            {
            	Match(input,35,FOLLOW_35_in_block989); 
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:186:10: ( variable )*
            	do 
            	{
            	    int alt10 = 2;
            	    alt10 = dfa10.Predict(input);
            	    switch (alt10) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:186:11: variable
            			    {
            			    	PushFollow(FOLLOW_variable_in_block1001);
            			    	variable20 = variable();
            			    	state.followingStackPointer--;

            			    	((slist_scope)slist_stack.Peek()).locals.Add(((variable20 != null) ? variable20.ST : null));

            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:187:10: ( stat )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( ((LA11_0 >= ID && LA11_0 <= INT) || (LA11_0 >= ARRAY && LA11_0 <= RWORD) || LA11_0 == 17 || (LA11_0 >= 19 && LA11_0 <= 20) || (LA11_0 >= 23 && LA11_0 <= 31) || LA11_0 == 35 || LA11_0 == 40 || (LA11_0 >= 43 && LA11_0 <= 45) || (LA11_0 >= 47 && LA11_0 <= 50) || LA11_0 == 65) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:187:11: stat
            			    {
            			    	PushFollow(FOLLOW_stat_in_block1019);
            			    	stat21 = stat();
            			    	state.followingStackPointer--;

            			    	((slist_scope)slist_stack.Peek()).stats.Add(((stat21 != null) ? stat21.ST : null));

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

            	Match(input,36,FOLLOW_36_in_block1069); 

            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "block"

    public class stat_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "stat"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:196:1: stat : ( forStat -> {$forStat.st} | expr ';' -> statement(expr=$expr.st) | block -> statementList(locals=$slist::localsstats=$slist::stats) | assignStat ';' -> type(name=\"assignStat\") | print_statement ';' -> {$print_statement.st} | selection_statement -> {$selection_statement.st} | while_statement -> {$while_statement.st} | return_statement ';' -> {$return_statement.st} | func_call ';' -> {$func_call.st} | pitchstat ';' -> type(name=\"pitchstat\") | ';' -> {new StringTemplate(\";\")});
    public PatternGeneratorParser.stat_return stat() // throws RecognitionException [1]
    {   
        slist_stack.Push(new slist_scope());

        PatternGeneratorParser.stat_return retval = new PatternGeneratorParser.stat_return();
        retval.Start = input.LT(1);

        PatternGeneratorParser.forStat_return forStat22 = default(PatternGeneratorParser.forStat_return);

        PatternGeneratorParser.expr_return expr23 = default(PatternGeneratorParser.expr_return);

        PatternGeneratorParser.print_statement_return print_statement24 = default(PatternGeneratorParser.print_statement_return);

        PatternGeneratorParser.selection_statement_return selection_statement25 = default(PatternGeneratorParser.selection_statement_return);

        PatternGeneratorParser.while_statement_return while_statement26 = default(PatternGeneratorParser.while_statement_return);

        PatternGeneratorParser.return_statement_return return_statement27 = default(PatternGeneratorParser.return_statement_return);

        PatternGeneratorParser.func_call_return func_call28 = default(PatternGeneratorParser.func_call_return);



          ((slist_scope)slist_stack.Peek()).locals =  new ArrayList();
          ((slist_scope)slist_stack.Peek()).stats =  new ArrayList();

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:202:5: ( forStat -> {$forStat.st} | expr ';' -> statement(expr=$expr.st) | block -> statementList(locals=$slist::localsstats=$slist::stats) | assignStat ';' -> type(name=\"assignStat\") | print_statement ';' -> {$print_statement.st} | selection_statement -> {$selection_statement.st} | while_statement -> {$while_statement.st} | return_statement ';' -> {$return_statement.st} | func_call ';' -> {$func_call.st} | pitchstat ';' -> type(name=\"pitchstat\") | ';' -> {new StringTemplate(\";\")})
            int alt12 = 11;
            alt12 = dfa12.Predict(input);
            switch (alt12) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:202:7: forStat
                    {
                    	PushFollow(FOLLOW_forStat_in_stat1111);
                    	forStat22 = forStat();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 202:15: -> {$forStat.st}
                    	{
                    	    retval.ST = ((forStat22 != null) ? forStat22.ST : null);
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:203:7: expr ';'
                    {
                    	PushFollow(FOLLOW_expr_in_stat1123);
                    	expr23 = expr();
                    	state.followingStackPointer--;

                    	Match(input,17,FOLLOW_17_in_stat1125); 


                    	// TEMPLATE REWRITE
                    	// 203:16: -> statement(expr=$expr.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("statement",
                    	  new STAttrMap().Add("expr", ((expr23 != null) ? expr23.ST : null)));
                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:204:7: block
                    {
                    	PushFollow(FOLLOW_block_in_stat1142);
                    	block();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 204:13: -> statementList(locals=$slist::localsstats=$slist::stats)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("statementList",
                    	  new STAttrMap().Add("locals", ((slist_scope)slist_stack.Peek()).locals).Add("stats", ((slist_scope)slist_stack.Peek()).stats));
                    	}


                    }
                    break;
                case 4 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:205:7: assignStat ';'
                    {
                    	PushFollow(FOLLOW_assignStat_in_stat1164);
                    	assignStat();
                    	state.followingStackPointer--;

                    	Match(input,17,FOLLOW_17_in_stat1166); 


                    	// TEMPLATE REWRITE
                    	// 205:22: -> type(name=\"assignStat\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "assignStat"));
                    	}


                    }
                    break;
                case 5 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:206:7: print_statement ';'
                    {
                    	PushFollow(FOLLOW_print_statement_in_stat1183);
                    	print_statement24 = print_statement();
                    	state.followingStackPointer--;

                    	Match(input,17,FOLLOW_17_in_stat1185); 


                    	// TEMPLATE REWRITE
                    	// 206:27: -> {$print_statement.st}
                    	{
                    	    retval.ST = ((print_statement24 != null) ? print_statement24.ST : null);
                    	}


                    }
                    break;
                case 6 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:207:7: selection_statement
                    {
                    	PushFollow(FOLLOW_selection_statement_in_stat1197);
                    	selection_statement25 = selection_statement();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 207:28: -> {$selection_statement.st}
                    	{
                    	    retval.ST = ((selection_statement25 != null) ? selection_statement25.ST : null);
                    	}


                    }
                    break;
                case 7 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:208:7: while_statement
                    {
                    	PushFollow(FOLLOW_while_statement_in_stat1210);
                    	while_statement26 = while_statement();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 208:24: -> {$while_statement.st}
                    	{
                    	    retval.ST = ((while_statement26 != null) ? while_statement26.ST : null);
                    	}


                    }
                    break;
                case 8 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:209:7: return_statement ';'
                    {
                    	PushFollow(FOLLOW_return_statement_in_stat1223);
                    	return_statement27 = return_statement();
                    	state.followingStackPointer--;

                    	Match(input,17,FOLLOW_17_in_stat1225); 


                    	// TEMPLATE REWRITE
                    	// 209:28: -> {$return_statement.st}
                    	{
                    	    retval.ST = ((return_statement27 != null) ? return_statement27.ST : null);
                    	}


                    }
                    break;
                case 9 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:210:7: func_call ';'
                    {
                    	PushFollow(FOLLOW_func_call_in_stat1237);
                    	func_call28 = func_call();
                    	state.followingStackPointer--;

                    	Match(input,17,FOLLOW_17_in_stat1239); 


                    	// TEMPLATE REWRITE
                    	// 210:21: -> {$func_call.st}
                    	{
                    	    retval.ST = ((func_call28 != null) ? func_call28.ST : null);
                    	}


                    }
                    break;
                case 10 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:211:7: pitchstat ';'
                    {
                    	PushFollow(FOLLOW_pitchstat_in_stat1251);
                    	pitchstat();
                    	state.followingStackPointer--;

                    	Match(input,17,FOLLOW_17_in_stat1253); 


                    	// TEMPLATE REWRITE
                    	// 211:21: -> type(name=\"pitchstat\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "pitchstat"));
                    	}


                    }
                    break;
                case 11 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:215:7: ';'
                    {
                    	Match(input,17,FOLLOW_17_in_stat1281); 


                    	// TEMPLATE REWRITE
                    	// 215:11: -> {new StringTemplate(\";\")}
                    	{
                    	    retval.ST = new StringTemplate(";");
                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            slist_stack.Pop();

        }
        return retval;
    }
    // $ANTLR end "stat"

    public class pitchstat_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "pitchstat"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:218:1: pitchstat : type '*' ID '=' '(' type '*' ')' '(' '(' type '*' ')' ID '+' '(' expr ')' '*' ID ')' ;
    public PatternGeneratorParser.pitchstat_return pitchstat() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.pitchstat_return retval = new PatternGeneratorParser.pitchstat_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:219:2: ( type '*' ID '=' '(' type '*' ')' '(' '(' type '*' ')' ID '+' '(' expr ')' '*' ID ')' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:220:2: type '*' ID '=' '(' type '*' ')' '(' '(' type '*' ')' ID '+' '(' expr ')' '*' ID ')'
            {
            	PushFollow(FOLLOW_type_in_pitchstat1300);
            	type();
            	state.followingStackPointer--;

            	Match(input,37,FOLLOW_37_in_pitchstat1302); 
            	Match(input,ID,FOLLOW_ID_in_pitchstat1304); 
            	Match(input,38,FOLLOW_38_in_pitchstat1306); 
            	Match(input,20,FOLLOW_20_in_pitchstat1308); 
            	PushFollow(FOLLOW_type_in_pitchstat1310);
            	type();
            	state.followingStackPointer--;

            	Match(input,37,FOLLOW_37_in_pitchstat1312); 
            	Match(input,22,FOLLOW_22_in_pitchstat1314); 
            	Match(input,20,FOLLOW_20_in_pitchstat1316); 
            	Match(input,20,FOLLOW_20_in_pitchstat1317); 
            	PushFollow(FOLLOW_type_in_pitchstat1319);
            	type();
            	state.followingStackPointer--;

            	Match(input,37,FOLLOW_37_in_pitchstat1321); 
            	Match(input,22,FOLLOW_22_in_pitchstat1323); 
            	Match(input,ID,FOLLOW_ID_in_pitchstat1325); 
            	Match(input,39,FOLLOW_39_in_pitchstat1327); 
            	Match(input,20,FOLLOW_20_in_pitchstat1329); 
            	PushFollow(FOLLOW_expr_in_pitchstat1331);
            	expr();
            	state.followingStackPointer--;

            	Match(input,22,FOLLOW_22_in_pitchstat1333); 
            	Match(input,37,FOLLOW_37_in_pitchstat1335); 
            	Match(input,ID,FOLLOW_ID_in_pitchstat1337); 
            	Match(input,22,FOLLOW_22_in_pitchstat1339); 

            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "pitchstat"

    public class forStat_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "forStat"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:223:1: forStat : 'for' '(' e1= assignStat ';' e2= expr ';' e3= incStat ')' block -> forLoop(e1=$e1.ste2=$e2.st.ToString()e3=$e3.stlocals=$slist::localsstats=$slist::stats);
    public PatternGeneratorParser.forStat_return forStat() // throws RecognitionException [1]
    {   
        slist_stack.Push(new slist_scope());

        PatternGeneratorParser.forStat_return retval = new PatternGeneratorParser.forStat_return();
        retval.Start = input.LT(1);

        PatternGeneratorParser.assignStat_return e1 = default(PatternGeneratorParser.assignStat_return);

        PatternGeneratorParser.expr_return e2 = default(PatternGeneratorParser.expr_return);

        PatternGeneratorParser.incStat_return e3 = default(PatternGeneratorParser.incStat_return);



          ((slist_scope)slist_stack.Peek()).locals =  new ArrayList();
          ((slist_scope)slist_stack.Peek()).stats =  new ArrayList();

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:229:5: ( 'for' '(' e1= assignStat ';' e2= expr ';' e3= incStat ')' block -> forLoop(e1=$e1.ste2=$e2.st.ToString()e3=$e3.stlocals=$slist::localsstats=$slist::stats))
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:229:9: 'for' '(' e1= assignStat ';' e2= expr ';' e3= incStat ')' block
            {
            	Match(input,40,FOLLOW_40_in_forStat1365); 
            	Match(input,20,FOLLOW_20_in_forStat1367); 
            	PushFollow(FOLLOW_assignStat_in_forStat1371);
            	e1 = assignStat();
            	state.followingStackPointer--;

            	Match(input,17,FOLLOW_17_in_forStat1373); 
            	PushFollow(FOLLOW_expr_in_forStat1377);
            	e2 = expr();
            	state.followingStackPointer--;

            	Match(input,17,FOLLOW_17_in_forStat1379); 
            	PushFollow(FOLLOW_incStat_in_forStat1383);
            	e3 = incStat();
            	state.followingStackPointer--;

            	Match(input,22,FOLLOW_22_in_forStat1385); 
            	PushFollow(FOLLOW_block_in_forStat1387);
            	block();
            	state.followingStackPointer--;



            	// TEMPLATE REWRITE
            	// 230:9: -> forLoop(e1=$e1.ste2=$e2.st.ToString()e3=$e3.stlocals=$slist::localsstats=$slist::stats)
            	{
            	    retval.ST = templateLib.GetInstanceOf("forLoop",
            	  new STAttrMap().Add("e1", ((e1 != null) ? e1.ST : null)).Add("e2", ((e2 != null) ? e2.ST : null).ToString()).Add("e3", ((e3 != null) ? e3.ST : null)).Add("locals", ((slist_scope)slist_stack.Peek()).locals).Add("stats", ((slist_scope)slist_stack.Peek()).stats));
            	}


            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            slist_stack.Pop();

        }
        return retval;
    }
    // $ANTLR end "forStat"

    public class assignStat_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "assignStat"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:234:1: assignStat : ( ID '=' expr -> assign(lhs=$ID.textrhs=$expr.st) | ARRAY '=' expr -> assign(lhs=$ARRAY.textrhs=$expr.st) | ID '-=' expr -> assignop(lhs=$ID.textrhs=$expr.stop=\"-=\") | ARRAY '-=' expr -> assignop(lhs=$ARRAY.textrhs=$expr.stop=\"-=\") | ID '+=' expr -> assignop(lhs=$ID.textrhs=$expr.stop=\"+=\") | ARRAY '+=' expr -> assignop(lhs=$ARRAY.textrhs=$expr.stop=\"+=\"));
    public PatternGeneratorParser.assignStat_return assignStat() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.assignStat_return retval = new PatternGeneratorParser.assignStat_return();
        retval.Start = input.LT(1);

        IToken ID29 = null;
        IToken ARRAY31 = null;
        IToken ID33 = null;
        IToken ARRAY35 = null;
        IToken ID37 = null;
        IToken ARRAY39 = null;
        PatternGeneratorParser.expr_return expr30 = default(PatternGeneratorParser.expr_return);

        PatternGeneratorParser.expr_return expr32 = default(PatternGeneratorParser.expr_return);

        PatternGeneratorParser.expr_return expr34 = default(PatternGeneratorParser.expr_return);

        PatternGeneratorParser.expr_return expr36 = default(PatternGeneratorParser.expr_return);

        PatternGeneratorParser.expr_return expr38 = default(PatternGeneratorParser.expr_return);

        PatternGeneratorParser.expr_return expr40 = default(PatternGeneratorParser.expr_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:235:5: ( ID '=' expr -> assign(lhs=$ID.textrhs=$expr.st) | ARRAY '=' expr -> assign(lhs=$ARRAY.textrhs=$expr.st) | ID '-=' expr -> assignop(lhs=$ID.textrhs=$expr.stop=\"-=\") | ARRAY '-=' expr -> assignop(lhs=$ARRAY.textrhs=$expr.stop=\"-=\") | ID '+=' expr -> assignop(lhs=$ID.textrhs=$expr.stop=\"+=\") | ARRAY '+=' expr -> assignop(lhs=$ARRAY.textrhs=$expr.stop=\"+=\"))
            int alt13 = 6;
            int LA13_0 = input.LA(1);

            if ( (LA13_0 == ID) )
            {
                switch ( input.LA(2) ) 
                {
                case 38:
                	{
                    alt13 = 1;
                    }
                    break;
                case 41:
                	{
                    alt13 = 3;
                    }
                    break;
                case 42:
                	{
                    alt13 = 5;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d13s1 =
                	        new NoViableAltException("", 13, 1, input);

                	    throw nvae_d13s1;
                }

            }
            else if ( (LA13_0 == ARRAY) )
            {
                switch ( input.LA(2) ) 
                {
                case 38:
                	{
                    alt13 = 2;
                    }
                    break;
                case 41:
                	{
                    alt13 = 4;
                    }
                    break;
                case 42:
                	{
                    alt13 = 6;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d13s2 =
                	        new NoViableAltException("", 13, 2, input);

                	    throw nvae_d13s2;
                }

            }
            else 
            {
                NoViableAltException nvae_d13s0 =
                    new NoViableAltException("", 13, 0, input);

                throw nvae_d13s0;
            }
            switch (alt13) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:235:11: ID '=' expr
                    {
                    	ID29=(IToken)Match(input,ID,FOLLOW_ID_in_assignStat1462); 
                    	Match(input,38,FOLLOW_38_in_assignStat1464); 
                    	PushFollow(FOLLOW_expr_in_assignStat1466);
                    	expr30 = expr();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 235:23: -> assign(lhs=$ID.textrhs=$expr.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("assign",
                    	  new STAttrMap().Add("lhs", ((ID29 != null) ? ID29.Text : null)).Add("rhs", ((expr30 != null) ? expr30.ST : null)));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:237:9: ARRAY '=' expr
                    {
                    	ARRAY31=(IToken)Match(input,ARRAY,FOLLOW_ARRAY_in_assignStat1496); 
                    	Match(input,38,FOLLOW_38_in_assignStat1498); 
                    	PushFollow(FOLLOW_expr_in_assignStat1500);
                    	expr32 = expr();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 237:24: -> assign(lhs=$ARRAY.textrhs=$expr.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("assign",
                    	  new STAttrMap().Add("lhs", ((ARRAY31 != null) ? ARRAY31.Text : null)).Add("rhs", ((expr32 != null) ? expr32.ST : null)));
                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:240:9: ID '-=' expr
                    {
                    	ID33=(IToken)Match(input,ID,FOLLOW_ID_in_assignStat1533); 
                    	Match(input,41,FOLLOW_41_in_assignStat1535); 
                    	PushFollow(FOLLOW_expr_in_assignStat1537);
                    	expr34 = expr();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 240:22: -> assignop(lhs=$ID.textrhs=$expr.stop=\"-=\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("assignop",
                    	  new STAttrMap().Add("lhs", ((ID33 != null) ? ID33.Text : null)).Add("rhs", ((expr34 != null) ? expr34.ST : null)).Add("op", "-="));
                    	}


                    }
                    break;
                case 4 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:241:9: ARRAY '-=' expr
                    {
                    	ARRAY35=(IToken)Match(input,ARRAY,FOLLOW_ARRAY_in_assignStat1565); 
                    	Match(input,41,FOLLOW_41_in_assignStat1567); 
                    	PushFollow(FOLLOW_expr_in_assignStat1569);
                    	expr36 = expr();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 241:25: -> assignop(lhs=$ARRAY.textrhs=$expr.stop=\"-=\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("assignop",
                    	  new STAttrMap().Add("lhs", ((ARRAY35 != null) ? ARRAY35.Text : null)).Add("rhs", ((expr36 != null) ? expr36.ST : null)).Add("op", "-="));
                    	}


                    }
                    break;
                case 5 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:242:9: ID '+=' expr
                    {
                    	ID37=(IToken)Match(input,ID,FOLLOW_ID_in_assignStat1597); 
                    	Match(input,42,FOLLOW_42_in_assignStat1599); 
                    	PushFollow(FOLLOW_expr_in_assignStat1601);
                    	expr38 = expr();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 242:22: -> assignop(lhs=$ID.textrhs=$expr.stop=\"+=\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("assignop",
                    	  new STAttrMap().Add("lhs", ((ID37 != null) ? ID37.Text : null)).Add("rhs", ((expr38 != null) ? expr38.ST : null)).Add("op", "+="));
                    	}


                    }
                    break;
                case 6 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:243:9: ARRAY '+=' expr
                    {
                    	ARRAY39=(IToken)Match(input,ARRAY,FOLLOW_ARRAY_in_assignStat1629); 
                    	Match(input,42,FOLLOW_42_in_assignStat1631); 
                    	PushFollow(FOLLOW_expr_in_assignStat1633);
                    	expr40 = expr();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 243:25: -> assignop(lhs=$ARRAY.textrhs=$expr.stop=\"+=\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("assignop",
                    	  new STAttrMap().Add("lhs", ((ARRAY39 != null) ? ARRAY39.Text : null)).Add("rhs", ((expr40 != null) ? expr40.ST : null)).Add("op", "+="));
                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "assignStat"

    public class print_statement_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "print_statement"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:247:1: print_statement : ( 'printf(' STRING_LITERAL ')' -> type(name=\"printf(\"+$STRING_LITERAL.text+\");\") | 'printf(' STRING_LITERAL ( ( ',' printfParameter )+ ) ')' -> type(name=\"printf(\"+$STRING_LITERAL.text+$pattern::temp+\");\") | 'fprintf(' ID ',' STRING_LITERAL ')' -> type(name=\"fprintf(\"+$ID.text+\",\"+$STRING_LITERAL.text+\");\") | 'fprintf(' ID ',' STRING_LITERAL (r+= ',' printfParameter )+ ')' -> type(name=\"printf(\"+$ID.text+\",\"+$STRING_LITERAL.text+$printfParameter.st+\");\") | 'default' ':' statement -> type(name=\"default :\"+$statement.st));
    public PatternGeneratorParser.print_statement_return print_statement() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.print_statement_return retval = new PatternGeneratorParser.print_statement_return();
        retval.Start = input.LT(1);

        IToken STRING_LITERAL41 = null;
        IToken STRING_LITERAL42 = null;
        IToken ID43 = null;
        IToken STRING_LITERAL44 = null;
        IToken ID45 = null;
        IToken STRING_LITERAL46 = null;
        IToken r = null;
        IList list_r = null;
        PatternGeneratorParser.printfParameter_return printfParameter47 = default(PatternGeneratorParser.printfParameter_return);

        PatternGeneratorParser.statement_return statement48 = default(PatternGeneratorParser.statement_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:248:2: ( 'printf(' STRING_LITERAL ')' -> type(name=\"printf(\"+$STRING_LITERAL.text+\");\") | 'printf(' STRING_LITERAL ( ( ',' printfParameter )+ ) ')' -> type(name=\"printf(\"+$STRING_LITERAL.text+$pattern::temp+\");\") | 'fprintf(' ID ',' STRING_LITERAL ')' -> type(name=\"fprintf(\"+$ID.text+\",\"+$STRING_LITERAL.text+\");\") | 'fprintf(' ID ',' STRING_LITERAL (r+= ',' printfParameter )+ ')' -> type(name=\"printf(\"+$ID.text+\",\"+$STRING_LITERAL.text+$printfParameter.st+\");\") | 'default' ':' statement -> type(name=\"default :\"+$statement.st))
            int alt16 = 5;
            alt16 = dfa16.Predict(input);
            switch (alt16) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:248:4: 'printf(' STRING_LITERAL ')'
                    {
                    	Match(input,43,FOLLOW_43_in_print_statement1666); 
                    	STRING_LITERAL41=(IToken)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_print_statement1668); 
                    	Match(input,22,FOLLOW_22_in_print_statement1670); 


                    	// TEMPLATE REWRITE
                    	// 248:33: -> type(name=\"printf(\"+$STRING_LITERAL.text+\");\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "printf("+((STRING_LITERAL41 != null) ? STRING_LITERAL41.Text : null)+");"));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:250:4: 'printf(' STRING_LITERAL ( ( ',' printfParameter )+ ) ')'
                    {
                    	Match(input,43,FOLLOW_43_in_print_statement1686); 
                    	((pattern_scope)pattern_stack.Peek()).temp = "";
                    	STRING_LITERAL42=(IToken)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_print_statement1690); 
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:250:50: ( ( ',' printfParameter )+ )
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:250:51: ( ',' printfParameter )+
                    	{
                    		// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:250:51: ( ',' printfParameter )+
                    		int cnt14 = 0;
                    		do 
                    		{
                    		    int alt14 = 2;
                    		    int LA14_0 = input.LA(1);

                    		    if ( (LA14_0 == 21) )
                    		    {
                    		        alt14 = 1;
                    		    }


                    		    switch (alt14) 
                    			{
                    				case 1 :
                    				    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:250:52: ',' printfParameter
                    				    {
                    				    	Match(input,21,FOLLOW_21_in_print_statement1694); 
                    				    	((pattern_scope)pattern_stack.Peek()).temp+=",";
                    				    	PushFollow(FOLLOW_printfParameter_in_print_statement1698);
                    				    	printfParameter();
                    				    	state.followingStackPointer--;


                    				    }
                    				    break;

                    				default:
                    				    if ( cnt14 >= 1 ) goto loop14;
                    			            EarlyExitException eee14 =
                    			                new EarlyExitException(14, input);
                    			            throw eee14;
                    		    }
                    		    cnt14++;
                    		} while (true);

                    		loop14:
                    			;	// Stops C# compiler whining that label 'loop14' has no statements


                    	}

                    	Match(input,22,FOLLOW_22_in_print_statement1708); 


                    	// TEMPLATE REWRITE
                    	// 250:107: -> type(name=\"printf(\"+$STRING_LITERAL.text+$pattern::temp+\");\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "printf("+((STRING_LITERAL42 != null) ? STRING_LITERAL42.Text : null)+((pattern_scope)pattern_stack.Peek()).temp+");"));
                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:251:4: 'fprintf(' ID ',' STRING_LITERAL ')'
                    {
                    	Match(input,44,FOLLOW_44_in_print_statement1722); 
                    	ID43=(IToken)Match(input,ID,FOLLOW_ID_in_print_statement1724); 
                    	Match(input,21,FOLLOW_21_in_print_statement1726); 
                    	STRING_LITERAL44=(IToken)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_print_statement1728); 
                    	Match(input,22,FOLLOW_22_in_print_statement1730); 


                    	// TEMPLATE REWRITE
                    	// 251:41: -> type(name=\"fprintf(\"+$ID.text+\",\"+$STRING_LITERAL.text+\");\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "fprintf("+((ID43 != null) ? ID43.Text : null)+","+((STRING_LITERAL44 != null) ? STRING_LITERAL44.Text : null)+");"));
                    	}


                    }
                    break;
                case 4 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:252:4: 'fprintf(' ID ',' STRING_LITERAL (r+= ',' printfParameter )+ ')'
                    {
                    	Match(input,44,FOLLOW_44_in_print_statement1744); 
                    	ID45=(IToken)Match(input,ID,FOLLOW_ID_in_print_statement1746); 
                    	Match(input,21,FOLLOW_21_in_print_statement1748); 
                    	STRING_LITERAL46=(IToken)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_print_statement1750); 
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:252:37: (r+= ',' printfParameter )+
                    	int cnt15 = 0;
                    	do 
                    	{
                    	    int alt15 = 2;
                    	    int LA15_0 = input.LA(1);

                    	    if ( (LA15_0 == 21) )
                    	    {
                    	        alt15 = 1;
                    	    }


                    	    switch (alt15) 
                    		{
                    			case 1 :
                    			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:252:39: r+= ',' printfParameter
                    			    {
                    			    	r=(IToken)Match(input,21,FOLLOW_21_in_print_statement1756); 
                    			    	if (list_r == null) list_r = new ArrayList();
                    			    	list_r.Add(r);

                    			    	PushFollow(FOLLOW_printfParameter_in_print_statement1758);
                    			    	printfParameter47 = printfParameter();
                    			    	state.followingStackPointer--;


                    			    }
                    			    break;

                    			default:
                    			    if ( cnt15 >= 1 ) goto loop15;
                    		            EarlyExitException eee15 =
                    		                new EarlyExitException(15, input);
                    		            throw eee15;
                    	    }
                    	    cnt15++;
                    	} while (true);

                    	loop15:
                    		;	// Stops C# compiler whining that label 'loop15' has no statements

                    	Match(input,22,FOLLOW_22_in_print_statement1766); 


                    	// TEMPLATE REWRITE
                    	// 252:72: -> type(name=\"printf(\"+$ID.text+\",\"+$STRING_LITERAL.text+$printfParameter.st+\");\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "printf("+((ID45 != null) ? ID45.Text : null)+","+((STRING_LITERAL46 != null) ? STRING_LITERAL46.Text : null)+((printfParameter47 != null) ? printfParameter47.ST : null)+");"));
                    	}


                    }
                    break;
                case 5 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:255:4: 'default' ':' statement
                    {
                    	Match(input,45,FOLLOW_45_in_print_statement1784); 
                    	Match(input,46,FOLLOW_46_in_print_statement1786); 
                    	PushFollow(FOLLOW_statement_in_print_statement1788);
                    	statement48 = statement();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 255:28: -> type(name=\"default :\"+$statement.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "default :"+((statement48 != null) ? statement48.ST : null)));
                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "print_statement"

    public class printfParameter_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "printfParameter"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:257:1: printfParameter : aexpr -> type(name=$aexpr.st);
    public PatternGeneratorParser.printfParameter_return printfParameter() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.printfParameter_return retval = new PatternGeneratorParser.printfParameter_return();
        retval.Start = input.LT(1);

        PatternGeneratorParser.aexpr_return aexpr49 = default(PatternGeneratorParser.aexpr_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:258:5: ( aexpr -> type(name=$aexpr.st))
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:258:9: aexpr
            {
            	PushFollow(FOLLOW_aexpr_in_printfParameter1813);
            	aexpr49 = aexpr();
            	state.followingStackPointer--;

            	((pattern_scope)pattern_stack.Peek()).temp+=((aexpr49 != null) ? aexpr49.ST : null);


            	// TEMPLATE REWRITE
            	// 259:9: -> type(name=$aexpr.st)
            	{
            	    retval.ST = templateLib.GetInstanceOf("type",
            	  new STAttrMap().Add("name", ((aexpr49 != null) ? aexpr49.ST : null)));
            	}


            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "printfParameter"

    public class return_statement_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "return_statement"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:263:1: return_statement : ( 'return' digits -> type(name=\"return \"+$digits.text +\";\") | 'return' ID -> type(name=\"return \"+$ID.text+\";\") | 'return' ARRAY -> type(name=\"return \"+$ARRAY.text+\";\"));
    public PatternGeneratorParser.return_statement_return return_statement() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.return_statement_return retval = new PatternGeneratorParser.return_statement_return();
        retval.Start = input.LT(1);

        IToken ID51 = null;
        IToken ARRAY52 = null;
        PatternGeneratorParser.digits_return digits50 = default(PatternGeneratorParser.digits_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:264:1: ( 'return' digits -> type(name=\"return \"+$digits.text +\";\") | 'return' ID -> type(name=\"return \"+$ID.text+\";\") | 'return' ARRAY -> type(name=\"return \"+$ARRAY.text+\";\"))
            int alt17 = 3;
            int LA17_0 = input.LA(1);

            if ( (LA17_0 == 47) )
            {
                switch ( input.LA(2) ) 
                {
                case ID:
                	{
                    alt17 = 2;
                    }
                    break;
                case ARRAY:
                	{
                    alt17 = 3;
                    }
                    break;
                case INT:
                	{
                    alt17 = 1;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d17s1 =
                	        new NoViableAltException("", 17, 1, input);

                	    throw nvae_d17s1;
                }

            }
            else 
            {
                NoViableAltException nvae_d17s0 =
                    new NoViableAltException("", 17, 0, input);

                throw nvae_d17s0;
            }
            switch (alt17) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:265:4: 'return' digits
                    {
                    	Match(input,47,FOLLOW_47_in_return_statement1854); 
                    	PushFollow(FOLLOW_digits_in_return_statement1856);
                    	digits50 = digits();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 265:20: -> type(name=\"return \"+$digits.text +\";\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "return "+((digits50 != null) ? input.ToString((IToken)(digits50.Start),(IToken)(digits50.Stop)) : null) +";"));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:266:4: 'return' ID
                    {
                    	Match(input,47,FOLLOW_47_in_return_statement1870); 
                    	ID51=(IToken)Match(input,ID,FOLLOW_ID_in_return_statement1872); 


                    	// TEMPLATE REWRITE
                    	// 266:20: -> type(name=\"return \"+$ID.text+\";\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "return "+((ID51 != null) ? ID51.Text : null)+";"));
                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:267:11: 'return' ARRAY
                    {
                    	Match(input,47,FOLLOW_47_in_return_statement1897); 
                    	ARRAY52=(IToken)Match(input,ARRAY,FOLLOW_ARRAY_in_return_statement1899); 


                    	// TEMPLATE REWRITE
                    	// 267:27: -> type(name=\"return \"+$ARRAY.text+\";\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "return "+((ARRAY52 != null) ? ARRAY52.Text : null)+";"));
                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "return_statement"

    public class while_statement_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "while_statement"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:269:1: while_statement : 'while' '(' expr ')' block -> whileLoop(e1=$expr.stlocals=$slist::localsstats=$slist::stats);
    public PatternGeneratorParser.while_statement_return while_statement() // throws RecognitionException [1]
    {   
        slist_stack.Push(new slist_scope());

        PatternGeneratorParser.while_statement_return retval = new PatternGeneratorParser.while_statement_return();
        retval.Start = input.LT(1);

        PatternGeneratorParser.expr_return expr53 = default(PatternGeneratorParser.expr_return);



          ((slist_scope)slist_stack.Peek()).locals =  new ArrayList();
          ((slist_scope)slist_stack.Peek()).stats =  new ArrayList();

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:275:2: ( 'while' '(' expr ')' block -> whileLoop(e1=$expr.stlocals=$slist::localsstats=$slist::stats))
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:275:4: 'while' '(' expr ')' block
            {
            	Match(input,48,FOLLOW_48_in_while_statement1929); 
            	Match(input,20,FOLLOW_20_in_while_statement1931); 
            	PushFollow(FOLLOW_expr_in_while_statement1933);
            	expr53 = expr();
            	state.followingStackPointer--;

            	Match(input,22,FOLLOW_22_in_while_statement1935); 
            	PushFollow(FOLLOW_block_in_while_statement1937);
            	block();
            	state.followingStackPointer--;



            	// TEMPLATE REWRITE
            	// 276:4: -> whileLoop(e1=$expr.stlocals=$slist::localsstats=$slist::stats)
            	{
            	    retval.ST = templateLib.GetInstanceOf("whileLoop",
            	  new STAttrMap().Add("e1", ((expr53 != null) ? expr53.ST : null)).Add("locals", ((slist_scope)slist_stack.Peek()).locals).Add("stats", ((slist_scope)slist_stack.Peek()).stats));
            	}


            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            slist_stack.Pop();

        }
        return retval;
    }
    // $ANTLR end "while_statement"

    public class selection_statement_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "selection_statement"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:279:1: selection_statement : ( 'if' '(' condExpr ')' stat -> type(name=\"Conditionif ()\" +$stat.st) | 'else' stat -> type(name=\"Condition else \" +$stat.st));
    public PatternGeneratorParser.selection_statement_return selection_statement() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.selection_statement_return retval = new PatternGeneratorParser.selection_statement_return();
        retval.Start = input.LT(1);

        PatternGeneratorParser.stat_return stat54 = default(PatternGeneratorParser.stat_return);

        PatternGeneratorParser.stat_return stat55 = default(PatternGeneratorParser.stat_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:281:2: ( 'if' '(' condExpr ')' stat -> type(name=\"Conditionif ()\" +$stat.st) | 'else' stat -> type(name=\"Condition else \" +$stat.st))
            int alt18 = 2;
            int LA18_0 = input.LA(1);

            if ( (LA18_0 == 49) )
            {
                alt18 = 1;
            }
            else if ( (LA18_0 == 50) )
            {
                alt18 = 2;
            }
            else 
            {
                NoViableAltException nvae_d18s0 =
                    new NoViableAltException("", 18, 0, input);

                throw nvae_d18s0;
            }
            switch (alt18) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:281:4: 'if' '(' condExpr ')' stat
                    {
                    	Match(input,49,FOLLOW_49_in_selection_statement1989); 
                    	Match(input,20,FOLLOW_20_in_selection_statement1991); 
                    	PushFollow(FOLLOW_condExpr_in_selection_statement1993);
                    	condExpr();
                    	state.followingStackPointer--;

                    	Match(input,22,FOLLOW_22_in_selection_statement1995); 
                    	PushFollow(FOLLOW_stat_in_selection_statement1997);
                    	stat54 = stat();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 282:2: -> type(name=\"Conditionif ()\" +$stat.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "Conditionif ()" +((stat54 != null) ? stat54.ST : null)));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:283:4: 'else' stat
                    {
                    	Match(input,50,FOLLOW_50_in_selection_statement2013); 
                    	PushFollow(FOLLOW_stat_in_selection_statement2015);
                    	stat55 = stat();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 283:16: -> type(name=\"Condition else \" +$stat.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "Condition else " +((stat55 != null) ? stat55.ST : null)));
                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "selection_statement"

    public class expression_statement_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "expression_statement"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:297:1: expression_statement : ( ';' -> type(name=\";\") | expr ';' -> type(name=$expr.st));
    public PatternGeneratorParser.expression_statement_return expression_statement() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.expression_statement_return retval = new PatternGeneratorParser.expression_statement_return();
        retval.Start = input.LT(1);

        PatternGeneratorParser.expr_return expr56 = default(PatternGeneratorParser.expr_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:299:2: ( ';' -> type(name=\";\") | expr ';' -> type(name=$expr.st))
            int alt19 = 2;
            int LA19_0 = input.LA(1);

            if ( (LA19_0 == 17) )
            {
                alt19 = 1;
            }
            else if ( ((LA19_0 >= ID && LA19_0 <= INT) || (LA19_0 >= ARRAY && LA19_0 <= RWORD) || LA19_0 == 20 || LA19_0 == 65) )
            {
                alt19 = 2;
            }
            else 
            {
                NoViableAltException nvae_d19s0 =
                    new NoViableAltException("", 19, 0, input);

                throw nvae_d19s0;
            }
            switch (alt19) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:299:4: ';'
                    {
                    	Match(input,17,FOLLOW_17_in_expression_statement2049); 


                    	// TEMPLATE REWRITE
                    	// 299:8: -> type(name=\";\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", ";"));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:301:4: expr ';'
                    {
                    	PushFollow(FOLLOW_expr_in_expression_statement2064);
                    	expr56 = expr();
                    	state.followingStackPointer--;

                    	Match(input,17,FOLLOW_17_in_expression_statement2066); 


                    	// TEMPLATE REWRITE
                    	// 301:13: -> type(name=$expr.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", ((expr56 != null) ? expr56.ST : null)));
                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expression_statement"

    public class incStat_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "incStat"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:304:1: incStat : ( ID '++' -> type(name=$ID.text + \"++\") | ID '--' -> type(name=$ID.text + \"--\") | '++' ID -> type(name=\"++\"+$ID.text) | '--' ID -> type(name=\"--\"+$ID.text) | ID '+=' INT -> type(name=\"gpu_\"+$ID.text + \"+=\" + $INT.text) | ID '-=' INT -> type(name=\"gpu_\"+$ID.text + \"-=\" + $INT.text) | ID '*=' INT -> type(name=\"gpu_\"+$ID.text + \"*=\" + $INT.text));
    public PatternGeneratorParser.incStat_return incStat() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.incStat_return retval = new PatternGeneratorParser.incStat_return();
        retval.Start = input.LT(1);

        IToken ID57 = null;
        IToken ID58 = null;
        IToken ID59 = null;
        IToken ID60 = null;
        IToken ID61 = null;
        IToken INT62 = null;
        IToken ID63 = null;
        IToken INT64 = null;
        IToken ID65 = null;
        IToken INT66 = null;

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:305:2: ( ID '++' -> type(name=$ID.text + \"++\") | ID '--' -> type(name=$ID.text + \"--\") | '++' ID -> type(name=\"++\"+$ID.text) | '--' ID -> type(name=\"--\"+$ID.text) | ID '+=' INT -> type(name=\"gpu_\"+$ID.text + \"+=\" + $INT.text) | ID '-=' INT -> type(name=\"gpu_\"+$ID.text + \"-=\" + $INT.text) | ID '*=' INT -> type(name=\"gpu_\"+$ID.text + \"*=\" + $INT.text))
            int alt20 = 7;
            switch ( input.LA(1) ) 
            {
            case ID:
            	{
                switch ( input.LA(2) ) 
                {
                case 51:
                	{
                    alt20 = 1;
                    }
                    break;
                case 52:
                	{
                    alt20 = 2;
                    }
                    break;
                case 42:
                	{
                    alt20 = 5;
                    }
                    break;
                case 41:
                	{
                    alt20 = 6;
                    }
                    break;
                case 53:
                	{
                    alt20 = 7;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d20s1 =
                	        new NoViableAltException("", 20, 1, input);

                	    throw nvae_d20s1;
                }

                }
                break;
            case 51:
            	{
                alt20 = 3;
                }
                break;
            case 52:
            	{
                alt20 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d20s0 =
            	        new NoViableAltException("", 20, 0, input);

            	    throw nvae_d20s0;
            }

            switch (alt20) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:305:6: ID '++'
                    {
                    	ID57=(IToken)Match(input,ID,FOLLOW_ID_in_incStat2088); 
                    	Match(input,51,FOLLOW_51_in_incStat2090); 


                    	// TEMPLATE REWRITE
                    	// 305:15: -> type(name=$ID.text + \"++\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", ((ID57 != null) ? ID57.Text : null) + "++"));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:306:6: ID '--'
                    {
                    	ID58=(IToken)Match(input,ID,FOLLOW_ID_in_incStat2107); 
                    	Match(input,52,FOLLOW_52_in_incStat2109); 


                    	// TEMPLATE REWRITE
                    	// 306:16: -> type(name=$ID.text + \"--\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", ((ID58 != null) ? ID58.Text : null) + "--"));
                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:307:6: '++' ID
                    {
                    	Match(input,51,FOLLOW_51_in_incStat2127); 
                    	ID59=(IToken)Match(input,ID,FOLLOW_ID_in_incStat2129); 


                    	// TEMPLATE REWRITE
                    	// 307:16: -> type(name=\"++\"+$ID.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "++"+((ID59 != null) ? ID59.Text : null)));
                    	}


                    }
                    break;
                case 4 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:308:7: '--' ID
                    {
                    	Match(input,52,FOLLOW_52_in_incStat2148); 
                    	ID60=(IToken)Match(input,ID,FOLLOW_ID_in_incStat2150); 


                    	// TEMPLATE REWRITE
                    	// 308:15: -> type(name=\"--\"+$ID.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "--"+((ID60 != null) ? ID60.Text : null)));
                    	}


                    }
                    break;
                case 5 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:309:7: ID '+=' INT
                    {
                    	ID61=(IToken)Match(input,ID,FOLLOW_ID_in_incStat2168); 
                    	Match(input,42,FOLLOW_42_in_incStat2170); 
                    	INT62=(IToken)Match(input,INT,FOLLOW_INT_in_incStat2172); 


                    	// TEMPLATE REWRITE
                    	// 309:19: -> type(name=\"gpu_\"+$ID.text + \"+=\" + $INT.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "gpu_"+((ID61 != null) ? ID61.Text : null) + "+=" + ((INT62 != null) ? INT62.Text : null)));
                    	}


                    }
                    break;
                case 6 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:310:6: ID '-=' INT
                    {
                    	ID63=(IToken)Match(input,ID,FOLLOW_ID_in_incStat2188); 
                    	Match(input,41,FOLLOW_41_in_incStat2190); 
                    	INT64=(IToken)Match(input,INT,FOLLOW_INT_in_incStat2192); 


                    	// TEMPLATE REWRITE
                    	// 310:18: -> type(name=\"gpu_\"+$ID.text + \"-=\" + $INT.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "gpu_"+((ID63 != null) ? ID63.Text : null) + "-=" + ((INT64 != null) ? INT64.Text : null)));
                    	}


                    }
                    break;
                case 7 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:311:6: ID '*=' INT
                    {
                    	ID65=(IToken)Match(input,ID,FOLLOW_ID_in_incStat2208); 
                    	Match(input,53,FOLLOW_53_in_incStat2210); 
                    	INT66=(IToken)Match(input,INT,FOLLOW_INT_in_incStat2212); 


                    	// TEMPLATE REWRITE
                    	// 311:18: -> type(name=\"gpu_\"+$ID.text + \"*=\" + $INT.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "gpu_"+((ID65 != null) ? ID65.Text : null) + "*=" + ((INT66 != null) ? INT66.Text : null)));
                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "incStat"

    public class expr_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "expr"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:314:1: expr : condExpr -> {$condExpr.st};
    public PatternGeneratorParser.expr_return expr() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.expr_return retval = new PatternGeneratorParser.expr_return();
        retval.Start = input.LT(1);

        PatternGeneratorParser.condExpr_return condExpr67 = default(PatternGeneratorParser.condExpr_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:314:5: ( condExpr -> {$condExpr.st})
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:315:3: condExpr
            {
            	PushFollow(FOLLOW_condExpr_in_expr2238);
            	condExpr67 = condExpr();
            	state.followingStackPointer--;



            	// TEMPLATE REWRITE
            	// 315:12: -> {$condExpr.st}
            	{
            	    retval.ST = ((condExpr67 != null) ? condExpr67.ST : null);
            	}


            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expr"

    public class condExpr_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "condExpr"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:329:1: condExpr : a= aexpr ( ( '==' b= aexpr -> equals(left=$a.stright=$b.st) | '!=' b= aexpr -> notequals(left=$a.stright=$b.st) | '<' b= aexpr -> lessThan(left=$a.stright=$b.st) | '>' b= aexpr -> GreaterThan(left=$a.stright=$b.st) | '<=' b= aexpr -> lessThanEq(left=$a.stright=$b.st) | '>=' b= aexpr -> GreaterThanEq(left=$a.stright=$b.st) | '&&' b= aexpr -> CAND(left=$a.stright=$b.st) | '||' b= aexpr -> COR(left=$a.stright=$b.st)) | -> {$a.st} | '(' condExpr ')' ) ;
    public PatternGeneratorParser.condExpr_return condExpr() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.condExpr_return retval = new PatternGeneratorParser.condExpr_return();
        retval.Start = input.LT(1);

        PatternGeneratorParser.aexpr_return a = default(PatternGeneratorParser.aexpr_return);

        PatternGeneratorParser.aexpr_return b = default(PatternGeneratorParser.aexpr_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:330:5: (a= aexpr ( ( '==' b= aexpr -> equals(left=$a.stright=$b.st) | '!=' b= aexpr -> notequals(left=$a.stright=$b.st) | '<' b= aexpr -> lessThan(left=$a.stright=$b.st) | '>' b= aexpr -> GreaterThan(left=$a.stright=$b.st) | '<=' b= aexpr -> lessThanEq(left=$a.stright=$b.st) | '>=' b= aexpr -> GreaterThanEq(left=$a.stright=$b.st) | '&&' b= aexpr -> CAND(left=$a.stright=$b.st) | '||' b= aexpr -> COR(left=$a.stright=$b.st)) | -> {$a.st} | '(' condExpr ')' ) )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:330:9: a= aexpr ( ( '==' b= aexpr -> equals(left=$a.stright=$b.st) | '!=' b= aexpr -> notequals(left=$a.stright=$b.st) | '<' b= aexpr -> lessThan(left=$a.stright=$b.st) | '>' b= aexpr -> GreaterThan(left=$a.stright=$b.st) | '<=' b= aexpr -> lessThanEq(left=$a.stright=$b.st) | '>=' b= aexpr -> GreaterThanEq(left=$a.stright=$b.st) | '&&' b= aexpr -> CAND(left=$a.stright=$b.st) | '||' b= aexpr -> COR(left=$a.stright=$b.st)) | -> {$a.st} | '(' condExpr ')' )
            {
            	PushFollow(FOLLOW_aexpr_in_condExpr2281);
            	a = aexpr();
            	state.followingStackPointer--;

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:331:9: ( ( '==' b= aexpr -> equals(left=$a.stright=$b.st) | '!=' b= aexpr -> notequals(left=$a.stright=$b.st) | '<' b= aexpr -> lessThan(left=$a.stright=$b.st) | '>' b= aexpr -> GreaterThan(left=$a.stright=$b.st) | '<=' b= aexpr -> lessThanEq(left=$a.stright=$b.st) | '>=' b= aexpr -> GreaterThanEq(left=$a.stright=$b.st) | '&&' b= aexpr -> CAND(left=$a.stright=$b.st) | '||' b= aexpr -> COR(left=$a.stright=$b.st)) | -> {$a.st} | '(' condExpr ')' )
            	int alt22 = 3;
            	switch ( input.LA(1) ) 
            	{
            	case 54:
            	case 55:
            	case 56:
            	case 57:
            	case 58:
            	case 59:
            	case 60:
            	case 61:
            		{
            	    alt22 = 1;
            	    }
            	    break;
            	case 17:
            	case 22:
            	case 66:
            		{
            	    alt22 = 2;
            	    }
            	    break;
            	case 20:
            		{
            	    alt22 = 3;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d22s0 =
            		        new NoViableAltException("", 22, 0, input);

            		    throw nvae_d22s0;
            	}

            	switch (alt22) 
            	{
            	    case 1 :
            	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:331:13: ( '==' b= aexpr -> equals(left=$a.stright=$b.st) | '!=' b= aexpr -> notequals(left=$a.stright=$b.st) | '<' b= aexpr -> lessThan(left=$a.stright=$b.st) | '>' b= aexpr -> GreaterThan(left=$a.stright=$b.st) | '<=' b= aexpr -> lessThanEq(left=$a.stright=$b.st) | '>=' b= aexpr -> GreaterThanEq(left=$a.stright=$b.st) | '&&' b= aexpr -> CAND(left=$a.stright=$b.st) | '||' b= aexpr -> COR(left=$a.stright=$b.st))
            	        {
            	        	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:331:13: ( '==' b= aexpr -> equals(left=$a.stright=$b.st) | '!=' b= aexpr -> notequals(left=$a.stright=$b.st) | '<' b= aexpr -> lessThan(left=$a.stright=$b.st) | '>' b= aexpr -> GreaterThan(left=$a.stright=$b.st) | '<=' b= aexpr -> lessThanEq(left=$a.stright=$b.st) | '>=' b= aexpr -> GreaterThanEq(left=$a.stright=$b.st) | '&&' b= aexpr -> CAND(left=$a.stright=$b.st) | '||' b= aexpr -> COR(left=$a.stright=$b.st))
            	        	int alt21 = 8;
            	        	switch ( input.LA(1) ) 
            	        	{
            	        	case 54:
            	        		{
            	        	    alt21 = 1;
            	        	    }
            	        	    break;
            	        	case 55:
            	        		{
            	        	    alt21 = 2;
            	        	    }
            	        	    break;
            	        	case 56:
            	        		{
            	        	    alt21 = 3;
            	        	    }
            	        	    break;
            	        	case 57:
            	        		{
            	        	    alt21 = 4;
            	        	    }
            	        	    break;
            	        	case 58:
            	        		{
            	        	    alt21 = 5;
            	        	    }
            	        	    break;
            	        	case 59:
            	        		{
            	        	    alt21 = 6;
            	        	    }
            	        	    break;
            	        	case 60:
            	        		{
            	        	    alt21 = 7;
            	        	    }
            	        	    break;
            	        	case 61:
            	        		{
            	        	    alt21 = 8;
            	        	    }
            	        	    break;
            	        		default:
            	        		    NoViableAltException nvae_d21s0 =
            	        		        new NoViableAltException("", 21, 0, input);

            	        		    throw nvae_d21s0;
            	        	}

            	        	switch (alt21) 
            	        	{
            	        	    case 1 :
            	        	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:331:16: '==' b= aexpr
            	        	        {
            	        	        	Match(input,54,FOLLOW_54_in_condExpr2298); 
            	        	        	PushFollow(FOLLOW_aexpr_in_condExpr2302);
            	        	        	b = aexpr();
            	        	        	state.followingStackPointer--;



            	        	        	// TEMPLATE REWRITE
            	        	        	// 331:29: -> equals(left=$a.stright=$b.st)
            	        	        	{
            	        	        	    retval.ST = templateLib.GetInstanceOf("equals",
            	        	        	  new STAttrMap().Add("left", ((a != null) ? a.ST : null)).Add("right", ((b != null) ? b.ST : null)));
            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:332:16: '!=' b= aexpr
            	        	        {
            	        	        	Match(input,55,FOLLOW_55_in_condExpr2332); 
            	        	        	PushFollow(FOLLOW_aexpr_in_condExpr2336);
            	        	        	b = aexpr();
            	        	        	state.followingStackPointer--;



            	        	        	// TEMPLATE REWRITE
            	        	        	// 332:29: -> notequals(left=$a.stright=$b.st)
            	        	        	{
            	        	        	    retval.ST = templateLib.GetInstanceOf("notequals",
            	        	        	  new STAttrMap().Add("left", ((a != null) ? a.ST : null)).Add("right", ((b != null) ? b.ST : null)));
            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 3 :
            	        	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:333:16: '<' b= aexpr
            	        	        {
            	        	        	Match(input,56,FOLLOW_56_in_condExpr2366); 
            	        	        	PushFollow(FOLLOW_aexpr_in_condExpr2370);
            	        	        	b = aexpr();
            	        	        	state.followingStackPointer--;



            	        	        	// TEMPLATE REWRITE
            	        	        	// 333:30: -> lessThan(left=$a.stright=$b.st)
            	        	        	{
            	        	        	    retval.ST = templateLib.GetInstanceOf("lessThan",
            	        	        	  new STAttrMap().Add("left", ((a != null) ? a.ST : null)).Add("right", ((b != null) ? b.ST : null)));
            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 4 :
            	        	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:334:16: '>' b= aexpr
            	        	        {
            	        	        	Match(input,57,FOLLOW_57_in_condExpr2402); 
            	        	        	PushFollow(FOLLOW_aexpr_in_condExpr2406);
            	        	        	b = aexpr();
            	        	        	state.followingStackPointer--;



            	        	        	// TEMPLATE REWRITE
            	        	        	// 334:30: -> GreaterThan(left=$a.stright=$b.st)
            	        	        	{
            	        	        	    retval.ST = templateLib.GetInstanceOf("GreaterThan",
            	        	        	  new STAttrMap().Add("left", ((a != null) ? a.ST : null)).Add("right", ((b != null) ? b.ST : null)));
            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 5 :
            	        	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:335:16: '<=' b= aexpr
            	        	        {
            	        	        	Match(input,58,FOLLOW_58_in_condExpr2438); 
            	        	        	PushFollow(FOLLOW_aexpr_in_condExpr2442);
            	        	        	b = aexpr();
            	        	        	state.followingStackPointer--;



            	        	        	// TEMPLATE REWRITE
            	        	        	// 335:31: -> lessThanEq(left=$a.stright=$b.st)
            	        	        	{
            	        	        	    retval.ST = templateLib.GetInstanceOf("lessThanEq",
            	        	        	  new STAttrMap().Add("left", ((a != null) ? a.ST : null)).Add("right", ((b != null) ? b.ST : null)));
            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 6 :
            	        	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:336:16: '>=' b= aexpr
            	        	        {
            	        	        	Match(input,59,FOLLOW_59_in_condExpr2474); 
            	        	        	PushFollow(FOLLOW_aexpr_in_condExpr2478);
            	        	        	b = aexpr();
            	        	        	state.followingStackPointer--;



            	        	        	// TEMPLATE REWRITE
            	        	        	// 336:31: -> GreaterThanEq(left=$a.stright=$b.st)
            	        	        	{
            	        	        	    retval.ST = templateLib.GetInstanceOf("GreaterThanEq",
            	        	        	  new STAttrMap().Add("left", ((a != null) ? a.ST : null)).Add("right", ((b != null) ? b.ST : null)));
            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 7 :
            	        	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:337:16: '&&' b= aexpr
            	        	        {
            	        	        	Match(input,60,FOLLOW_60_in_condExpr2510); 
            	        	        	PushFollow(FOLLOW_aexpr_in_condExpr2514);
            	        	        	b = aexpr();
            	        	        	state.followingStackPointer--;



            	        	        	// TEMPLATE REWRITE
            	        	        	// 337:31: -> CAND(left=$a.stright=$b.st)
            	        	        	{
            	        	        	    retval.ST = templateLib.GetInstanceOf("CAND",
            	        	        	  new STAttrMap().Add("left", ((a != null) ? a.ST : null)).Add("right", ((b != null) ? b.ST : null)));
            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 8 :
            	        	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:338:16: '||' b= aexpr
            	        	        {
            	        	        	Match(input,61,FOLLOW_61_in_condExpr2546); 
            	        	        	PushFollow(FOLLOW_aexpr_in_condExpr2550);
            	        	        	b = aexpr();
            	        	        	state.followingStackPointer--;



            	        	        	// TEMPLATE REWRITE
            	        	        	// 338:31: -> COR(left=$a.stright=$b.st)
            	        	        	{
            	        	        	    retval.ST = templateLib.GetInstanceOf("COR",
            	        	        	  new STAttrMap().Add("left", ((a != null) ? a.ST : null)).Add("right", ((b != null) ? b.ST : null)));
            	        	        	}


            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:341:13: 
            	        {

            	        	// TEMPLATE REWRITE
            	        	// 341:13: -> {$a.st}
            	        	{
            	        	    retval.ST = ((a != null) ? a.ST : null);
            	        	}


            	        }
            	        break;
            	    case 3 :
            	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:343:11: '(' condExpr ')'
            	        {
            	        	Match(input,20,FOLLOW_20_in_condExpr2630); 
            	        	PushFollow(FOLLOW_condExpr_in_condExpr2632);
            	        	condExpr();
            	        	state.followingStackPointer--;

            	        	Match(input,22,FOLLOW_22_in_condExpr2635); 

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "condExpr"

    public class aexpr_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "aexpr"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:349:1: aexpr : (a= atom -> {$a.st}) ( '+' b= atom -> add(left=$aexpr.stright=$b.st))* ( '-' b= atom -> Sub(left=$aexpr.stright=$b.st))* ( '/' b= atom -> Div(left=$aexpr.stright=$b.st))* ( '*' b= atom -> Mul(left=$aexpr.stright=$b.st))* ( '%' b= atom -> Mod(left=$aexpr.stright=$b.st))* ;
    public PatternGeneratorParser.aexpr_return aexpr() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.aexpr_return retval = new PatternGeneratorParser.aexpr_return();
        retval.Start = input.LT(1);

        PatternGeneratorParser.atom_return a = default(PatternGeneratorParser.atom_return);

        PatternGeneratorParser.atom_return b = default(PatternGeneratorParser.atom_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:350:5: ( (a= atom -> {$a.st}) ( '+' b= atom -> add(left=$aexpr.stright=$b.st))* ( '-' b= atom -> Sub(left=$aexpr.stright=$b.st))* ( '/' b= atom -> Div(left=$aexpr.stright=$b.st))* ( '*' b= atom -> Mul(left=$aexpr.stright=$b.st))* ( '%' b= atom -> Mod(left=$aexpr.stright=$b.st))* )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:350:9: (a= atom -> {$a.st}) ( '+' b= atom -> add(left=$aexpr.stright=$b.st))* ( '-' b= atom -> Sub(left=$aexpr.stright=$b.st))* ( '/' b= atom -> Div(left=$aexpr.stright=$b.st))* ( '*' b= atom -> Mul(left=$aexpr.stright=$b.st))* ( '%' b= atom -> Mod(left=$aexpr.stright=$b.st))*
            {
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:350:9: (a= atom -> {$a.st})
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:350:10: a= atom
            	{
            		PushFollow(FOLLOW_atom_in_aexpr2679);
            		a = atom();
            		state.followingStackPointer--;



            		// TEMPLATE REWRITE
            		// 350:17: -> {$a.st}
            		{
            		    retval.ST = ((a != null) ? a.ST : null);
            		}


            	}

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:351:9: ( '+' b= atom -> add(left=$aexpr.stright=$b.st))*
            	do 
            	{
            	    int alt23 = 2;
            	    int LA23_0 = input.LA(1);

            	    if ( (LA23_0 == 39) )
            	    {
            	        alt23 = 1;
            	    }


            	    switch (alt23) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:351:11: '+' b= atom
            			    {
            			    	Match(input,39,FOLLOW_39_in_aexpr2696); 
            			    	PushFollow(FOLLOW_atom_in_aexpr2700);
            			    	b = atom();
            			    	state.followingStackPointer--;



            			    	// TEMPLATE REWRITE
            			    	// 351:22: -> add(left=$aexpr.stright=$b.st)
            			    	{
            			    	    retval.ST = templateLib.GetInstanceOf("add",
            			    	  new STAttrMap().Add("left", retval.ST).Add("right", ((b != null) ? b.ST : null)));
            			    	}


            			    }
            			    break;

            			default:
            			    goto loop23;
            	    }
            	} while (true);

            	loop23:
            		;	// Stops C# compiler whining that label 'loop23' has no statements

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:352:9: ( '-' b= atom -> Sub(left=$aexpr.stright=$b.st))*
            	do 
            	{
            	    int alt24 = 2;
            	    int LA24_0 = input.LA(1);

            	    if ( (LA24_0 == 62) )
            	    {
            	        alt24 = 1;
            	    }


            	    switch (alt24) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:352:11: '-' b= atom
            			    {
            			    	Match(input,62,FOLLOW_62_in_aexpr2729); 
            			    	PushFollow(FOLLOW_atom_in_aexpr2733);
            			    	b = atom();
            			    	state.followingStackPointer--;



            			    	// TEMPLATE REWRITE
            			    	// 352:22: -> Sub(left=$aexpr.stright=$b.st)
            			    	{
            			    	    retval.ST = templateLib.GetInstanceOf("Sub",
            			    	  new STAttrMap().Add("left", retval.ST).Add("right", ((b != null) ? b.ST : null)));
            			    	}


            			    }
            			    break;

            			default:
            			    goto loop24;
            	    }
            	} while (true);

            	loop24:
            		;	// Stops C# compiler whining that label 'loop24' has no statements

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:353:9: ( '/' b= atom -> Div(left=$aexpr.stright=$b.st))*
            	do 
            	{
            	    int alt25 = 2;
            	    int LA25_0 = input.LA(1);

            	    if ( (LA25_0 == 63) )
            	    {
            	        alt25 = 1;
            	    }


            	    switch (alt25) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:353:11: '/' b= atom
            			    {
            			    	Match(input,63,FOLLOW_63_in_aexpr2762); 
            			    	PushFollow(FOLLOW_atom_in_aexpr2766);
            			    	b = atom();
            			    	state.followingStackPointer--;



            			    	// TEMPLATE REWRITE
            			    	// 353:22: -> Div(left=$aexpr.stright=$b.st)
            			    	{
            			    	    retval.ST = templateLib.GetInstanceOf("Div",
            			    	  new STAttrMap().Add("left", retval.ST).Add("right", ((b != null) ? b.ST : null)));
            			    	}


            			    }
            			    break;

            			default:
            			    goto loop25;
            	    }
            	} while (true);

            	loop25:
            		;	// Stops C# compiler whining that label 'loop25' has no statements

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:354:9: ( '*' b= atom -> Mul(left=$aexpr.stright=$b.st))*
            	do 
            	{
            	    int alt26 = 2;
            	    int LA26_0 = input.LA(1);

            	    if ( (LA26_0 == 37) )
            	    {
            	        alt26 = 1;
            	    }


            	    switch (alt26) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:354:11: '*' b= atom
            			    {
            			    	Match(input,37,FOLLOW_37_in_aexpr2795); 
            			    	PushFollow(FOLLOW_atom_in_aexpr2799);
            			    	b = atom();
            			    	state.followingStackPointer--;



            			    	// TEMPLATE REWRITE
            			    	// 354:22: -> Mul(left=$aexpr.stright=$b.st)
            			    	{
            			    	    retval.ST = templateLib.GetInstanceOf("Mul",
            			    	  new STAttrMap().Add("left", retval.ST).Add("right", ((b != null) ? b.ST : null)));
            			    	}


            			    }
            			    break;

            			default:
            			    goto loop26;
            	    }
            	} while (true);

            	loop26:
            		;	// Stops C# compiler whining that label 'loop26' has no statements

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:355:9: ( '%' b= atom -> Mod(left=$aexpr.stright=$b.st))*
            	do 
            	{
            	    int alt27 = 2;
            	    int LA27_0 = input.LA(1);

            	    if ( (LA27_0 == 64) )
            	    {
            	        alt27 = 1;
            	    }


            	    switch (alt27) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:355:11: '%' b= atom
            			    {
            			    	Match(input,64,FOLLOW_64_in_aexpr2828); 
            			    	PushFollow(FOLLOW_atom_in_aexpr2832);
            			    	b = atom();
            			    	state.followingStackPointer--;



            			    	// TEMPLATE REWRITE
            			    	// 355:22: -> Mod(left=$aexpr.stright=$b.st)
            			    	{
            			    	    retval.ST = templateLib.GetInstanceOf("Mod",
            			    	  new STAttrMap().Add("left", retval.ST).Add("right", ((b != null) ? b.ST : null)));
            			    	}


            			    }
            			    break;

            			default:
            			    goto loop27;
            	    }
            	} while (true);

            	loop27:
            		;	// Stops C# compiler whining that label 'loop27' has no statements


            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "aexpr"

    public class func_call_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "func_call"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:357:1: func_call : ID '(' ')' ;
    public PatternGeneratorParser.func_call_return func_call() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.func_call_return retval = new PatternGeneratorParser.func_call_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:358:1: ( ID '(' ')' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:359:2: ID '(' ')'
            {
            	Match(input,ID,FOLLOW_ID_in_func_call2876); 
            	Match(input,20,FOLLOW_20_in_func_call2878); 
            	Match(input,22,FOLLOW_22_in_func_call2880); 

            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "func_call"

    public class atom_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "atom"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:361:1: atom : ( ID -> refVar(id=$ID.text) | ARRAY -> refVar(id=$ARRAY.text) | INT -> iconst(value=$INT.text) | RWORD -> refVar(id=$RWORD.text) | '(' expr ')' -> {$expr.st} | '[' expr ']' -> {$expr.st});
    public PatternGeneratorParser.atom_return atom() // throws RecognitionException [1]
    {   
        PatternGeneratorParser.atom_return retval = new PatternGeneratorParser.atom_return();
        retval.Start = input.LT(1);

        IToken ID68 = null;
        IToken ARRAY69 = null;
        IToken INT70 = null;
        IToken RWORD71 = null;
        PatternGeneratorParser.expr_return expr72 = default(PatternGeneratorParser.expr_return);

        PatternGeneratorParser.expr_return expr73 = default(PatternGeneratorParser.expr_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:362:5: ( ID -> refVar(id=$ID.text) | ARRAY -> refVar(id=$ARRAY.text) | INT -> iconst(value=$INT.text) | RWORD -> refVar(id=$RWORD.text) | '(' expr ')' -> {$expr.st} | '[' expr ']' -> {$expr.st})
            int alt28 = 6;
            switch ( input.LA(1) ) 
            {
            case ID:
            	{
                alt28 = 1;
                }
                break;
            case ARRAY:
            	{
                alt28 = 2;
                }
                break;
            case INT:
            	{
                alt28 = 3;
                }
                break;
            case RWORD:
            	{
                alt28 = 4;
                }
                break;
            case 20:
            	{
                alt28 = 5;
                }
                break;
            case 65:
            	{
                alt28 = 6;
                }
                break;
            	default:
            	    NoViableAltException nvae_d28s0 =
            	        new NoViableAltException("", 28, 0, input);

            	    throw nvae_d28s0;
            }

            switch (alt28) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:362:7: ID
                    {
                    	ID68=(IToken)Match(input,ID,FOLLOW_ID_in_atom2893); 


                    	// TEMPLATE REWRITE
                    	// 362:11: -> refVar(id=$ID.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("refVar",
                    	  new STAttrMap().Add("id", ((ID68 != null) ? ID68.Text : null)));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:363:7: ARRAY
                    {
                    	ARRAY69=(IToken)Match(input,ARRAY,FOLLOW_ARRAY_in_atom2911); 


                    	// TEMPLATE REWRITE
                    	// 363:13: -> refVar(id=$ARRAY.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("refVar",
                    	  new STAttrMap().Add("id", ((ARRAY69 != null) ? ARRAY69.Text : null)));
                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:364:7: INT
                    {
                    	INT70=(IToken)Match(input,INT,FOLLOW_INT_in_atom2930); 


                    	// TEMPLATE REWRITE
                    	// 364:11: -> iconst(value=$INT.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("iconst",
                    	  new STAttrMap().Add("value", ((INT70 != null) ? INT70.Text : null)));
                    	}


                    }
                    break;
                case 4 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:365:7: RWORD
                    {
                    	RWORD71=(IToken)Match(input,RWORD,FOLLOW_RWORD_in_atom2947); 


                    	// TEMPLATE REWRITE
                    	// 365:13: -> refVar(id=$RWORD.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("refVar",
                    	  new STAttrMap().Add("id", ((RWORD71 != null) ? RWORD71.Text : null)));
                    	}


                    }
                    break;
                case 5 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:366:7: '(' expr ')'
                    {
                    	Match(input,20,FOLLOW_20_in_atom2963); 
                    	PushFollow(FOLLOW_expr_in_atom2965);
                    	expr72 = expr();
                    	state.followingStackPointer--;

                    	Match(input,22,FOLLOW_22_in_atom2967); 


                    	// TEMPLATE REWRITE
                    	// 366:20: -> {$expr.st}
                    	{
                    	    retval.ST = ((expr72 != null) ? expr72.ST : null);
                    	}


                    }
                    break;
                case 6 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\PatternGenerator.g:367:6: '[' expr ']'
                    {
                    	Match(input,65,FOLLOW_65_in_atom2979); 
                    	PushFollow(FOLLOW_expr_in_atom2981);
                    	expr73 = expr();
                    	state.followingStackPointer--;

                    	Match(input,66,FOLLOW_66_in_atom2983); 


                    	// TEMPLATE REWRITE
                    	// 367:19: -> {$expr.st}
                    	{
                    	    retval.ST = ((expr73 != null) ? expr73.ST : null);
                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "atom"

    // Delegated rules


   	protected DFA2 dfa2;
   	protected DFA10 dfa10;
   	protected DFA12 dfa12;
   	protected DFA16 dfa16;
	private void InitializeCyclicDFAs()
	{
    	this.dfa2 = new DFA2(this);
    	this.dfa10 = new DFA10(this);
    	this.dfa12 = new DFA12(this);
    	this.dfa16 = new DFA16(this);
	}

    const string DFA2_eotS =
        "\x0e\uffff";
    const string DFA2_eofS =
        "\x0e\uffff";
    const string DFA2_minS =
        "\x01\x08\x0b\x04\x02\uffff";
    const string DFA2_maxS =
        "\x01\x1f\x0b\x07\x02\uffff";
    const string DFA2_acceptS =
        "\x0c\uffff\x01\x01\x01\x02";
    const string DFA2_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA2_transitionS = {
            "\x01\x0b\x0a\uffff\x01\x05\x03\uffff\x01\x01\x01\x02\x01\x03"+
            "\x01\x04\x01\x06\x01\x07\x01\x08\x01\x09\x01\x0a",
            "\x01\x0c\x02\uffff\x01\x0d",
            "\x01\x0c\x02\uffff\x01\x0d",
            "\x01\x0c\x02\uffff\x01\x0d",
            "\x01\x0c\x02\uffff\x01\x0d",
            "\x01\x0c\x02\uffff\x01\x0d",
            "\x01\x0c\x02\uffff\x01\x0d",
            "\x01\x0c\x02\uffff\x01\x0d",
            "\x01\x0c\x02\uffff\x01\x0d",
            "\x01\x0c\x02\uffff\x01\x0d",
            "\x01\x0c\x02\uffff\x01\x0d",
            "\x01\x0c\x02\uffff\x01\x0d",
            "",
            ""
    };

    static readonly short[] DFA2_eot = DFA.UnpackEncodedString(DFA2_eotS);
    static readonly short[] DFA2_eof = DFA.UnpackEncodedString(DFA2_eofS);
    static readonly char[] DFA2_min = DFA.UnpackEncodedStringToUnsignedChars(DFA2_minS);
    static readonly char[] DFA2_max = DFA.UnpackEncodedStringToUnsignedChars(DFA2_maxS);
    static readonly short[] DFA2_accept = DFA.UnpackEncodedString(DFA2_acceptS);
    static readonly short[] DFA2_special = DFA.UnpackEncodedString(DFA2_specialS);
    static readonly short[][] DFA2_transition = DFA.UnpackEncodedStringArray(DFA2_transitionS);

    protected class DFA2 : DFA
    {
        public DFA2(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 2;
            this.eot = DFA2_eot;
            this.eof = DFA2_eof;
            this.min = DFA2_min;
            this.max = DFA2_max;
            this.accept = DFA2_accept;
            this.special = DFA2_special;
            this.transition = DFA2_transition;

        }

        override public string Description
        {
            get { return "80:1: variable : ( type declarator ';' -> variable(type=$type.stname=$declarator.st) | type arraydeclarator ';' -> variable(type=$type.stname=$arraydeclarator.st));"; }
        }

    }

    const string DFA10_eotS =
        "\x0e\uffff";
    const string DFA10_eofS =
        "\x0e\uffff";
    const string DFA10_minS =
        "\x01\x04\x01\uffff\x0b\x04\x01\uffff";
    const string DFA10_maxS =
        "\x01\x41\x01\uffff\x01\x40\x0a\x25\x01\uffff";
    const string DFA10_acceptS =
        "\x01\uffff\x01\x02\x0b\uffff\x01\x01";
    const string DFA10_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA10_transitionS = {
            "\x02\x01\x01\uffff\x01\x01\x01\x02\x08\uffff\x01\x01\x01\uffff"+
            "\x01\x07\x01\x01\x02\uffff\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
            "\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x03\uffff\x02\x01\x03\uffff"+
            "\x01\x01\x02\uffff\x03\x01\x01\uffff\x04\x01\x0e\uffff\x01\x01",
            "",
            "\x01\x0d\x02\uffff\x01\x0d\x09\uffff\x01\x01\x02\uffff\x01"+
            "\x01\x10\uffff\x01\x01\x01\uffff\x01\x01\x0e\uffff\x0b\x01",
            "\x01\x0d\x02\uffff\x01\x0d\x1d\uffff\x01\x01",
            "\x01\x0d\x02\uffff\x01\x0d\x1d\uffff\x01\x01",
            "\x01\x0d\x02\uffff\x01\x0d\x1d\uffff\x01\x01",
            "\x01\x0d\x02\uffff\x01\x0d\x1d\uffff\x01\x01",
            "\x01\x0d\x02\uffff\x01\x0d\x1d\uffff\x01\x01",
            "\x01\x0d\x02\uffff\x01\x0d\x1d\uffff\x01\x01",
            "\x01\x0d\x02\uffff\x01\x0d\x1d\uffff\x01\x01",
            "\x01\x0d\x02\uffff\x01\x0d\x1d\uffff\x01\x01",
            "\x01\x0d\x02\uffff\x01\x0d\x1d\uffff\x01\x01",
            "\x01\x0d\x02\uffff\x01\x0d\x1d\uffff\x01\x01",
            ""
    };

    static readonly short[] DFA10_eot = DFA.UnpackEncodedString(DFA10_eotS);
    static readonly short[] DFA10_eof = DFA.UnpackEncodedString(DFA10_eofS);
    static readonly char[] DFA10_min = DFA.UnpackEncodedStringToUnsignedChars(DFA10_minS);
    static readonly char[] DFA10_max = DFA.UnpackEncodedStringToUnsignedChars(DFA10_maxS);
    static readonly short[] DFA10_accept = DFA.UnpackEncodedString(DFA10_acceptS);
    static readonly short[] DFA10_special = DFA.UnpackEncodedString(DFA10_specialS);
    static readonly short[][] DFA10_transition = DFA.UnpackEncodedStringArray(DFA10_transitionS);

    protected class DFA10 : DFA
    {
        public DFA10(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 10;
            this.eot = DFA10_eot;
            this.eof = DFA10_eof;
            this.min = DFA10_min;
            this.max = DFA10_max;
            this.accept = DFA10_accept;
            this.special = DFA10_special;
            this.transition = DFA10_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 186:10: ( variable )*"; }
        }

    }

    const string DFA12_eotS =
        "\x12\uffff";
    const string DFA12_eofS =
        "\x12\uffff";
    const string DFA12_minS =
        "\x01\x04\x01\uffff\x02\x11\x01\uffff\x01\x11\x08\uffff\x02\x04"+
        "\x01\uffff\x01\x11";
    const string DFA12_maxS =
        "\x01\x41\x01\uffff\x02\x40\x01\uffff\x01\x40\x08\uffff\x02\x41"+
        "\x01\uffff\x01\x40";
    const string DFA12_acceptS =
        "\x01\uffff\x01\x01\x02\uffff\x01\x02\x01\uffff\x01\x03\x01\x05"+
        "\x01\x06\x01\x07\x01\x08\x01\x0a\x01\x0b\x01\x04\x02\uffff\x01\x09"+
        "\x01\uffff";
    const string DFA12_specialS =
        "\x12\uffff}>";
    static readonly string[] DFA12_transitionS = {
            "\x01\x02\x01\x04\x01\uffff\x01\x03\x01\x05\x08\uffff\x01\x0c"+
            "\x01\uffff\x01\x0b\x01\x04\x02\uffff\x09\x0b\x03\uffff\x01\x06"+
            "\x04\uffff\x01\x01\x02\uffff\x03\x07\x01\uffff\x01\x0a\x01\x09"+
            "\x02\x08\x0e\uffff\x01\x04",
            "",
            "\x01\x04\x02\uffff\x01\x0e\x10\uffff\x01\x04\x01\x0d\x01\x04"+
            "\x01\uffff\x02\x0d\x0b\uffff\x0b\x04",
            "\x01\x04\x02\uffff\x01\x04\x10\uffff\x01\x04\x01\x0d\x01\x04"+
            "\x01\uffff\x02\x0d\x0b\uffff\x0b\x04",
            "",
            "\x01\x04\x02\uffff\x01\x04\x10\uffff\x01\x0f\x01\uffff\x01"+
            "\x04\x0e\uffff\x0b\x04",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x02\x04\x01\uffff\x02\x04\x0b\uffff\x01\x04\x01\uffff\x01"+
            "\x10\x2a\uffff\x01\x04",
            "\x01\x11\x01\x04\x01\uffff\x02\x04\x0b\uffff\x01\x04\x2c\uffff"+
            "\x01\x04",
            "",
            "\x01\x04\x02\uffff\x01\x04\x10\uffff\x01\x04\x01\x0b\x0f\uffff"+
            "\x08\x04\x02\uffff\x01\x04"
    };

    static readonly short[] DFA12_eot = DFA.UnpackEncodedString(DFA12_eotS);
    static readonly short[] DFA12_eof = DFA.UnpackEncodedString(DFA12_eofS);
    static readonly char[] DFA12_min = DFA.UnpackEncodedStringToUnsignedChars(DFA12_minS);
    static readonly char[] DFA12_max = DFA.UnpackEncodedStringToUnsignedChars(DFA12_maxS);
    static readonly short[] DFA12_accept = DFA.UnpackEncodedString(DFA12_acceptS);
    static readonly short[] DFA12_special = DFA.UnpackEncodedString(DFA12_specialS);
    static readonly short[][] DFA12_transition = DFA.UnpackEncodedStringArray(DFA12_transitionS);

    protected class DFA12 : DFA
    {
        public DFA12(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 12;
            this.eot = DFA12_eot;
            this.eof = DFA12_eof;
            this.min = DFA12_min;
            this.max = DFA12_max;
            this.accept = DFA12_accept;
            this.special = DFA12_special;
            this.transition = DFA12_transition;

        }

        override public string Description
        {
            get { return "196:1: stat : ( forStat -> {$forStat.st} | expr ';' -> statement(expr=$expr.st) | block -> statementList(locals=$slist::localsstats=$slist::stats) | assignStat ';' -> type(name=\"assignStat\") | print_statement ';' -> {$print_statement.st} | selection_statement -> {$selection_statement.st} | while_statement -> {$while_statement.st} | return_statement ';' -> {$return_statement.st} | func_call ';' -> {$func_call.st} | pitchstat ';' -> type(name=\"pitchstat\") | ';' -> {new StringTemplate(\";\")});"; }
        }

    }

    const string DFA16_eotS =
        "\x0c\uffff";
    const string DFA16_eofS =
        "\x0c\uffff";
    const string DFA16_minS =
        "\x01\x2b\x01\x09\x01\x04\x01\uffff\x02\x15\x02\uffff\x01\x09\x01"+
        "\x15\x02\uffff";
    const string DFA16_maxS =
        "\x01\x2d\x01\x09\x01\x04\x01\uffff\x01\x16\x01\x15\x02\uffff\x01"+
        "\x09\x01\x16\x02\uffff";
    const string DFA16_acceptS =
        "\x03\uffff\x01\x05\x02\uffff\x01\x01\x01\x02\x02\uffff\x01\x03"+
        "\x01\x04";
    const string DFA16_specialS =
        "\x0c\uffff}>";
    static readonly string[] DFA16_transitionS = {
            "\x01\x01\x01\x02\x01\x03",
            "\x01\x04",
            "\x01\x05",
            "",
            "\x01\x07\x01\x06",
            "\x01\x08",
            "",
            "",
            "\x01\x09",
            "\x01\x0b\x01\x0a",
            "",
            ""
    };

    static readonly short[] DFA16_eot = DFA.UnpackEncodedString(DFA16_eotS);
    static readonly short[] DFA16_eof = DFA.UnpackEncodedString(DFA16_eofS);
    static readonly char[] DFA16_min = DFA.UnpackEncodedStringToUnsignedChars(DFA16_minS);
    static readonly char[] DFA16_max = DFA.UnpackEncodedStringToUnsignedChars(DFA16_maxS);
    static readonly short[] DFA16_accept = DFA.UnpackEncodedString(DFA16_acceptS);
    static readonly short[] DFA16_special = DFA.UnpackEncodedString(DFA16_specialS);
    static readonly short[][] DFA16_transition = DFA.UnpackEncodedStringArray(DFA16_transitionS);

    protected class DFA16 : DFA
    {
        public DFA16(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 16;
            this.eot = DFA16_eot;
            this.eof = DFA16_eof;
            this.min = DFA16_min;
            this.max = DFA16_max;
            this.accept = DFA16_accept;
            this.special = DFA16_special;
            this.transition = DFA16_transition;

        }

        override public string Description
        {
            get { return "247:1: print_statement : ( 'printf(' STRING_LITERAL ')' -> type(name=\"printf(\"+$STRING_LITERAL.text+\");\") | 'printf(' STRING_LITERAL ( ( ',' printfParameter )+ ) ')' -> type(name=\"printf(\"+$STRING_LITERAL.text+$pattern::temp+\");\") | 'fprintf(' ID ',' STRING_LITERAL ')' -> type(name=\"fprintf(\"+$ID.text+\",\"+$STRING_LITERAL.text+\");\") | 'fprintf(' ID ',' STRING_LITERAL (r+= ',' printfParameter )+ ')' -> type(name=\"printf(\"+$ID.text+\",\"+$STRING_LITERAL.text+$printfParameter.st+\");\") | 'default' ':' statement -> type(name=\"default :\"+$statement.st));"; }
        }

    }

 

    public static readonly BitSet FOLLOW_declaration_in_pattern62 = new BitSet(new ulong[]{0x0000000700000002UL});
    public static readonly BitSet FOLLOW_kernelfunction_in_declaration109 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_variable142 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_declarator_in_variable145 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_17_in_variable147 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_variable179 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_arraydeclarator_in_variable181 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_17_in_variable183 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_stat_in_statement226 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_statement_list246 = new BitSet(new ulong[]{0x0007B908FF9A01B2UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_include265 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_kdeclarator_in_include267 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_rdeclarator_in_define296 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_declarator_in_define298 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_digits_in_define302 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_18_in_define305 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_digits_in_define309 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_ID_in_declarator345 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_digits374 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Keyword_in_kdeclarator398 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ARRAY_in_arraydeclarator428 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RWORD_in_rdeclarator455 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cudafunctiontype_in_kernelfunction497 = new BitSet(new ulong[]{0x00000000FF880100UL});
    public static readonly BitSet FOLLOW_type_in_kernelfunction499 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_kernelfunction501 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_20_in_kernelfunction513 = new BitSet(new ulong[]{0x00000000FFC80100UL});
    public static readonly BitSet FOLLOW_formalParameter_in_kernelfunction519 = new BitSet(new ulong[]{0x0000000000600000UL});
    public static readonly BitSet FOLLOW_21_in_kernelfunction523 = new BitSet(new ulong[]{0x00000000FF880100UL});
    public static readonly BitSet FOLLOW_formalParameter_in_kernelfunction527 = new BitSet(new ulong[]{0x0000000000600000UL});
    public static readonly BitSet FOLLOW_22_in_kernelfunction535 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_block_in_kernelfunction545 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_formalParameter664 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_declarator_in_formalParameter667 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_23_in_type711 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_24_in_type730 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_25_in_type748 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_26_in_type765 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_19_in_type782 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_27_in_type798 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_28_in_type818 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_29_in_type838 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_30_in_type858 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_31_in_type887 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RWORD_in_type907 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_32_in_cudafunctiontype937 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_33_in_cudafunctiontype951 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_34_in_cudafunctiontype965 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_35_in_block989 = new BitSet(new ulong[]{0x0007B918FF9A01B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_block1001 = new BitSet(new ulong[]{0x0007B918FF9A01B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_stat_in_block1019 = new BitSet(new ulong[]{0x0007B918FF9A01B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_block1069 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forStat_in_stat1111 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_stat1123 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_17_in_stat1125 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_in_stat1142 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignStat_in_stat1164 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_17_in_stat1166 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_print_statement_in_stat1183 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_17_in_stat1185 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selection_statement_in_stat1197 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_while_statement_in_stat1210 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_return_statement_in_stat1223 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_17_in_stat1225 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_func_call_in_stat1237 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_17_in_stat1239 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_pitchstat_in_stat1251 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_17_in_stat1253 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_17_in_stat1281 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_pitchstat1300 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_37_in_pitchstat1302 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_pitchstat1304 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_38_in_pitchstat1306 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_20_in_pitchstat1308 = new BitSet(new ulong[]{0x00000000FF880100UL});
    public static readonly BitSet FOLLOW_type_in_pitchstat1310 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_37_in_pitchstat1312 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_22_in_pitchstat1314 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_20_in_pitchstat1316 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_20_in_pitchstat1317 = new BitSet(new ulong[]{0x00000000FF880100UL});
    public static readonly BitSet FOLLOW_type_in_pitchstat1319 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_37_in_pitchstat1321 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_22_in_pitchstat1323 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_pitchstat1325 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_39_in_pitchstat1327 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_20_in_pitchstat1329 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_pitchstat1331 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_22_in_pitchstat1333 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_37_in_pitchstat1335 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_pitchstat1337 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_22_in_pitchstat1339 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_forStat1365 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_20_in_forStat1367 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_assignStat_in_forStat1371 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_17_in_forStat1373 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_forStat1377 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_17_in_forStat1379 = new BitSet(new ulong[]{0x0018000000000010UL});
    public static readonly BitSet FOLLOW_incStat_in_forStat1383 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_22_in_forStat1385 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_block_in_forStat1387 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_assignStat1462 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_38_in_assignStat1464 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_assignStat1466 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ARRAY_in_assignStat1496 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_38_in_assignStat1498 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_assignStat1500 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_assignStat1533 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_assignStat1535 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_assignStat1537 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ARRAY_in_assignStat1565 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_assignStat1567 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_assignStat1569 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_assignStat1597 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_assignStat1599 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_assignStat1601 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ARRAY_in_assignStat1629 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_assignStat1631 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_assignStat1633 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_print_statement1666 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_print_statement1668 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_22_in_print_statement1670 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_print_statement1686 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_print_statement1690 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_print_statement1694 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_printfParameter_in_print_statement1698 = new BitSet(new ulong[]{0x0000000000600000UL});
    public static readonly BitSet FOLLOW_22_in_print_statement1708 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_print_statement1722 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_print_statement1724 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_print_statement1726 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_print_statement1728 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_22_in_print_statement1730 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_print_statement1744 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_print_statement1746 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_print_statement1748 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_print_statement1750 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_print_statement1756 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_printfParameter_in_print_statement1758 = new BitSet(new ulong[]{0x0000000000600000UL});
    public static readonly BitSet FOLLOW_22_in_print_statement1766 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_print_statement1784 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_print_statement1786 = new BitSet(new ulong[]{0x0007B908FF9A01B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_print_statement1788 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_aexpr_in_printfParameter1813 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_47_in_return_statement1854 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_digits_in_return_statement1856 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_47_in_return_statement1870 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_return_statement1872 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_47_in_return_statement1897 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_ARRAY_in_return_statement1899 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_48_in_while_statement1929 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_20_in_while_statement1931 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_while_statement1933 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_22_in_while_statement1935 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_block_in_while_statement1937 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_49_in_selection_statement1989 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_20_in_selection_statement1991 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_condExpr_in_selection_statement1993 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_22_in_selection_statement1995 = new BitSet(new ulong[]{0x0007B908FF9A01B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_stat_in_selection_statement1997 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_50_in_selection_statement2013 = new BitSet(new ulong[]{0x0007B908FF9A01B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_stat_in_selection_statement2015 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_17_in_expression_statement2049 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_expression_statement2064 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_17_in_expression_statement2066 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_incStat2088 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_incStat2090 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_incStat2107 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_incStat2109 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_51_in_incStat2127 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_incStat2129 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_incStat2148 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_incStat2150 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_incStat2168 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_incStat2170 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_INT_in_incStat2172 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_incStat2188 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_incStat2190 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_INT_in_incStat2192 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_incStat2208 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_incStat2210 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_INT_in_incStat2212 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_condExpr_in_expr2238 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_aexpr_in_condExpr2281 = new BitSet(new ulong[]{0x3FC0000000100002UL});
    public static readonly BitSet FOLLOW_54_in_condExpr2298 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_aexpr_in_condExpr2302 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_condExpr2332 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_aexpr_in_condExpr2336 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_condExpr2366 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_aexpr_in_condExpr2370 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_57_in_condExpr2402 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_aexpr_in_condExpr2406 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_58_in_condExpr2438 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_aexpr_in_condExpr2442 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_59_in_condExpr2474 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_aexpr_in_condExpr2478 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_60_in_condExpr2510 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_aexpr_in_condExpr2514 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_61_in_condExpr2546 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_aexpr_in_condExpr2550 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_20_in_condExpr2630 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_condExpr_in_condExpr2632 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_22_in_condExpr2635 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_atom_in_aexpr2679 = new BitSet(new ulong[]{0xC00000A000000002UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_39_in_aexpr2696 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_atom_in_aexpr2700 = new BitSet(new ulong[]{0xC00000A000000002UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_62_in_aexpr2729 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_atom_in_aexpr2733 = new BitSet(new ulong[]{0xC000002000000002UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_63_in_aexpr2762 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_atom_in_aexpr2766 = new BitSet(new ulong[]{0x8000002000000002UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_37_in_aexpr2795 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_atom_in_aexpr2799 = new BitSet(new ulong[]{0x0000002000000002UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_aexpr2828 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_atom_in_aexpr2832 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_ID_in_func_call2876 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_20_in_func_call2878 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_22_in_func_call2880 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_atom2893 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ARRAY_in_atom2911 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_atom2930 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RWORD_in_atom2947 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_20_in_atom2963 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_atom2965 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_22_in_atom2967 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_atom2979 = new BitSet(new ulong[]{0x00000000001001B0UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_atom2981 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_atom2983 = new BitSet(new ulong[]{0x0000000000000002UL});

}
