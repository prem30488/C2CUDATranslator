// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Administrator\\Desktop\\P.g 2012-01-27 15:49:48

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
public partial class PParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"ID", 
		"INT", 
		"ARRAY", 
		"EXPONENT", 
		"FLOAT", 
		"COMMENT", 
		"WS", 
		"ESC_SEQ", 
		"STRING", 
		"CHAR", 
		"HEX_DIGIT", 
		"UNICODE_ESC", 
		"OCTAL_ESC", 
		"'kernel'", 
		"'#include <stdio.h>'", 
		"'#include <conio.h>'", 
		"'#define'", 
		"'('", 
		"')'", 
		"';'", 
		"'#pragma kernel_start'", 
		"'#pragma kernel_end'", 
		"'{'", 
		"'}'", 
		"'printf(\"'", 
		"','", 
		"'int'", 
		"'char'", 
		"'float'", 
		"'unsigned'", 
		"'void'"
    };

    public const int EXPONENT = 7;
    public const int T__29 = 29;
    public const int T__28 = 28;
    public const int T__27 = 27;
    public const int T__26 = 26;
    public const int T__25 = 25;
    public const int T__24 = 24;
    public const int T__23 = 23;
    public const int T__22 = 22;
    public const int T__21 = 21;
    public const int UNICODE_ESC = 15;
    public const int T__20 = 20;
    public const int OCTAL_ESC = 16;
    public const int CHAR = 13;
    public const int HEX_DIGIT = 14;
    public const int FLOAT = 8;
    public const int INT = 5;
    public const int ID = 4;
    public const int EOF = -1;
    public const int T__19 = 19;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int ESC_SEQ = 11;
    public const int WS = 10;
    public const int T__33 = 33;
    public const int T__34 = 34;
    public const int T__18 = 18;
    public const int T__17 = 17;
    public const int COMMENT = 9;
    public const int ARRAY = 6;
    public const int STRING = 12;

    // delegates
    // delegators

    protected class slist_scope 
    {
        protected internal IList locals;
        protected internal // must be defined one per semicolon
            IList stats;
    }
    protected Stack slist_stack = new Stack();



        public PParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public PParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected StringTemplateGroup templateLib =
      new StringTemplateGroup("PParserTemplates", typeof(AngleBracketTemplateLexer));

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
		get { return PParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\Users\\Administrator\\Desktop\\P.g"; }
    }


       string getkernelstr(string getarr)
            {
                string temp, result;
                temp = "";
                result = "";
                int i;
                for (i = 0; i < getarr.Length ; i++)
                {
                    if (getarr[i] == '[' || getarr[i] == ']' || getarr[i] == '+' || getarr[i] == '-' ||    getarr[i] == '*' || getarr[i] == '/')
                    {
                        temp = "";
                        result = result+ getarr[i];
                    }
                  
                    else
                    {
                        temp = "gpu_";
                        while ((getarr[i] >= 'a' && getarr[i] <= 'z') || (getarr[i] >= 'A' && getarr[i] <= 'Z') || (getarr[i] == '_') || (getarr[i] == '&') || (getarr[i] == '.'))
                        {
                            temp = temp + getarr[i];
                            i++;
                        }
                        result = result + temp;
                        i=i-1;
                    }

                }
                return result;
            }
     string Getdeclfrmlist(IList list)
               {
                   string d=string.Empty ;
                   int i;
                   for (i = 0; i < list.Count - 1; i++)
                   {
                       d = d.ToString() + list[i].ToString().SubString(list[i]);
                   }
                   return d;
               }



    protected class program_scope 
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
        protected internal IList functiondeclarations;
        protected internal String kernelpar;
        protected internal String kernelpar2;
        protected internal String temp;
    }
    protected Stack program_stack = new Stack();

    public class program_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "program"
    // C:\\Users\\Administrator\\Desktop\\P.g:58:1: program : ( declaration )+ -> program(globals=$program::globalsfunctions=$program::functionsincludes=$program::includesmainstats=$program::mainstatskernelvars=$program::kernelvarskernelcopyin=$program::kernelcopyinfunctiondeclarations=$program::functiondeclarations);
    public PParser.program_return program() // throws RecognitionException [1]
    {   
        program_stack.Push(new program_scope());
        PParser.program_return retval = new PParser.program_return();
        retval.Start = input.LT(1);


          ((program_scope)program_stack.Peek()).globals =  new ArrayList();
          ((program_scope)program_stack.Peek()).functions =  new ArrayList();
          ((program_scope)program_stack.Peek()).includes =  new ArrayList();
          ((program_scope)program_stack.Peek()).mainstats =  new ArrayList();
          ((program_scope)program_stack.Peek()).kernelvars =  new ArrayList();
          ((program_scope)program_stack.Peek()).kernelcopyin =  new ArrayList();
          ((program_scope)program_stack.Peek()).kernelcopyout =  new ArrayList();
          ((program_scope)program_stack.Peek()).kernelalloc =  new ArrayList();
          ((program_scope)program_stack.Peek()).kernelvarfree =  new ArrayList();
          ((program_scope)program_stack.Peek()).kernelvarsize =  new ArrayList();
          ((program_scope)program_stack.Peek()).functiondeclarations =  new ArrayList();
         

        try 
    	{
            // C:\\Users\\Administrator\\Desktop\\P.g:90:5: ( ( declaration )+ -> program(globals=$program::globalsfunctions=$program::functionsincludes=$program::includesmainstats=$program::mainstatskernelvars=$program::kernelvarskernelcopyin=$program::kernelcopyinfunctiondeclarations=$program::functiondeclarations))
            // C:\\Users\\Administrator\\Desktop\\P.g:90:9: ( declaration )+
            {
            	// C:\\Users\\Administrator\\Desktop\\P.g:90:9: ( declaration )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= 17 && LA1_0 <= 18) || LA1_0 == 20 || LA1_0 == 24 || LA1_0 == 28 || (LA1_0 >= 30 && LA1_0 <= 34)) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\Administrator\\Desktop\\P.g:90:9: declaration
            			    {
            			    	PushFollow(FOLLOW_declaration_in_program61);
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
            	// 91:9: -> program(globals=$program::globalsfunctions=$program::functionsincludes=$program::includesmainstats=$program::mainstatskernelvars=$program::kernelvarskernelcopyin=$program::kernelcopyinfunctiondeclarations=$program::functiondeclarations)
            	{
            	    retval.ST = templateLib.GetInstanceOf("program",
            	  new STAttrMap().Add("globals", ((program_scope)program_stack.Peek()).globals).Add("functions", ((program_scope)program_stack.Peek()).functions).Add("includes", ((program_scope)program_stack.Peek()).includes).Add("mainstats", ((program_scope)program_stack.Peek()).mainstats).Add("kernelvars", ((program_scope)program_stack.Peek()).kernelvars).Add("kernelcopyin", ((program_scope)program_stack.Peek()).kernelcopyin).Add("functiondeclarations", ((program_scope)program_stack.Peek()).functiondeclarations));
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
            program_stack.Pop();
        }
        return retval;
    }
    // $ANTLR end "program"

    public class declaration_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "declaration"
    // C:\\Users\\Administrator\\Desktop\\P.g:94:1: declaration : ( include | variable | funcDecl | function | define | statement | kf= kernel_function );
    public PParser.declaration_return declaration() // throws RecognitionException [1]
    {   
        PParser.declaration_return retval = new PParser.declaration_return();
        retval.Start = input.LT(1);

        PParser.kernel_function_return kf = default(PParser.kernel_function_return);

        PParser.include_return include1 = default(PParser.include_return);

        PParser.variable_return variable2 = default(PParser.variable_return);

        PParser.funcDecl_return funcDecl3 = default(PParser.funcDecl_return);

        PParser.function_return function4 = default(PParser.function_return);

        PParser.define_return define5 = default(PParser.define_return);

        PParser.statement_return statement6 = default(PParser.statement_return);


        try 
    	{
            // C:\\Users\\Administrator\\Desktop\\P.g:95:5: ( include | variable | funcDecl | function | define | statement | kf= kernel_function )
            int alt2 = 7;
            alt2 = dfa2.Predict(input);
            switch (alt2) 
            {
                case 1 :
                    // C:\\Users\\Administrator\\Desktop\\P.g:95:8: include
                    {
                    	PushFollow(FOLLOW_include_in_declaration128);
                    	include1 = include();
                    	state.followingStackPointer--;

                    	((program_scope)program_stack.Peek()).includes.Add(((include1 != null) ? include1.ST : null));

                    }
                    break;
                case 2 :
                    // C:\\Users\\Administrator\\Desktop\\P.g:96:7: variable
                    {
                    	PushFollow(FOLLOW_variable_in_declaration138);
                    	variable2 = variable();
                    	state.followingStackPointer--;

                    	((program_scope)program_stack.Peek()).globals.Add(((variable2 != null) ? variable2.ST : null));

                    }
                    break;
                case 3 :
                    // C:\\Users\\Administrator\\Desktop\\P.g:97:9: funcDecl
                    {
                    	PushFollow(FOLLOW_funcDecl_in_declaration152);
                    	funcDecl3 = funcDecl();
                    	state.followingStackPointer--;

                    	((program_scope)program_stack.Peek()).functiondeclarations.Add(((funcDecl3 != null) ? funcDecl3.ST : null));

                    }
                    break;
                case 4 :
                    // C:\\Users\\Administrator\\Desktop\\P.g:98:9: function
                    {
                    	PushFollow(FOLLOW_function_in_declaration164);
                    	function4 = function();
                    	state.followingStackPointer--;

                    	((program_scope)program_stack.Peek()).functions.Add(((function4 != null) ? function4.ST : null));

                    }
                    break;
                case 5 :
                    // C:\\Users\\Administrator\\Desktop\\P.g:102:9: define
                    {
                    	PushFollow(FOLLOW_define_in_declaration188);
                    	define5 = define();
                    	state.followingStackPointer--;

                    	((program_scope)program_stack.Peek()).includes.Add(((define5 != null) ? define5.ST : null));

                    }
                    break;
                case 6 :
                    // C:\\Users\\Administrator\\Desktop\\P.g:104:9: statement
                    {
                    	PushFollow(FOLLOW_statement_in_declaration201);
                    	statement6 = statement();
                    	state.followingStackPointer--;

                    	((program_scope)program_stack.Peek()).mainstats.Add(((statement6 != null) ? statement6.ST : null));

                    }
                    break;
                case 7 :
                    // C:\\Users\\Administrator\\Desktop\\P.g:105:9: kf= kernel_function
                    {
                    	PushFollow(FOLLOW_kernel_function_in_declaration215);
                    	kf = kernel_function();
                    	state.followingStackPointer--;

                    	((program_scope)program_stack.Peek()).functions.Add(((kf != null) ? kf.ST : null));
                    	        ((program_scope)program_stack.Peek()).mainstats.Add(((program_scope)program_stack.Peek()).kernelalloc);
                    	        ((program_scope)program_stack.Peek()).mainstats.Add(((program_scope)program_stack.Peek()).kernelcopyin);
                    		((program_scope)program_stack.Peek()).mainstats.Add("\n// call kernel \n kernel <<< n_blocks, block_size >>>("+ ((program_scope)program_stack.Peek()).kernelpar.ToString().Substring(1,((program_scope)program_stack.Peek()).kernelpar.Length -1 )+");");
                    		((program_scope)program_stack.Peek()).mainstats.Add(((program_scope)program_stack.Peek()).kernelcopyout);
                    		((program_scope)program_stack.Peek()).mainstats.Add(((program_scope)program_stack.Peek()).kernelvarfree);
                    		((program_scope)program_stack.Peek()).mainstats.Add("\n");
                    	 
                    	    

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
    // $ANTLR end "declaration"

    public class kernel_variable_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "kernel_variable"
    // C:\\Users\\Administrator\\Desktop\\P.g:116:1: kernel_variable : 'kernel' variable ;
    public PParser.kernel_variable_return kernel_variable() // throws RecognitionException [1]
    {   
        PParser.kernel_variable_return retval = new PParser.kernel_variable_return();
        retval.Start = input.LT(1);

        try 
    	{
            // C:\\Users\\Administrator\\Desktop\\P.g:117:1: ( 'kernel' variable )
            // C:\\Users\\Administrator\\Desktop\\P.g:118:2: 'kernel' variable
            {
            	Match(input,17,FOLLOW_17_in_kernel_variable235); 
            	PushFollow(FOLLOW_variable_in_kernel_variable237);
            	variable();
            	state.followingStackPointer--;


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
    // $ANTLR end "kernel_variable"

    public class kernel_array_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "kernel_array"
    // C:\\Users\\Administrator\\Desktop\\P.g:120:1: kernel_array : 'kernel' arraydeclarator ;
    public PParser.kernel_array_return kernel_array() // throws RecognitionException [1]
    {   
        PParser.kernel_array_return retval = new PParser.kernel_array_return();
        retval.Start = input.LT(1);

        try 
    	{
            // C:\\Users\\Administrator\\Desktop\\P.g:121:1: ( 'kernel' arraydeclarator )
            // C:\\Users\\Administrator\\Desktop\\P.g:122:2: 'kernel' arraydeclarator
            {
            	Match(input,17,FOLLOW_17_in_kernel_array247); 
            	PushFollow(FOLLOW_arraydeclarator_in_kernel_array249);
            	arraydeclarator();
            	state.followingStackPointer--;


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
    // $ANTLR end "kernel_array"

    public class include_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "include"
    // C:\\Users\\Administrator\\Desktop\\P.g:124:1: include : '#include <stdio.h>' '#include <conio.h>' ;
    public PParser.include_return include() // throws RecognitionException [1]
    {   
        PParser.include_return retval = new PParser.include_return();
        retval.Start = input.LT(1);

        try 
    	{
            // C:\\Users\\Administrator\\Desktop\\P.g:124:9: ( '#include <stdio.h>' '#include <conio.h>' )
            // C:\\Users\\Administrator\\Desktop\\P.g:125:2: '#include <stdio.h>' '#include <conio.h>'
            {
            	Match(input,18,FOLLOW_18_in_include259); 
            	Match(input,19,FOLLOW_19_in_include262); 

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
    // C:\\Users\\Administrator\\Desktop\\P.g:128:1: define : '#define' ID INT ;
    public PParser.define_return define() // throws RecognitionException [1]
    {   
        PParser.define_return retval = new PParser.define_return();
        retval.Start = input.LT(1);

        try 
    	{
            // C:\\Users\\Administrator\\Desktop\\P.g:128:8: ( '#define' ID INT )
            // C:\\Users\\Administrator\\Desktop\\P.g:129:2: '#define' ID INT
            {
            	Match(input,20,FOLLOW_20_in_define274); 
            	Match(input,ID,FOLLOW_ID_in_define276); 
            	Match(input,INT,FOLLOW_INT_in_define278); 

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

    public class funcDecl_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "funcDecl"
    // C:\\Users\\Administrator\\Desktop\\P.g:132:1: funcDecl : type declarator '(' ( parameters )* ')' ';' ;
    public PParser.funcDecl_return funcDecl() // throws RecognitionException [1]
    {   
        PParser.funcDecl_return retval = new PParser.funcDecl_return();
        retval.Start = input.LT(1);

        try 
    	{
            // C:\\Users\\Administrator\\Desktop\\P.g:132:9: ( type declarator '(' ( parameters )* ')' ';' )
            // C:\\Users\\Administrator\\Desktop\\P.g:133:2: type declarator '(' ( parameters )* ')' ';'
            {
            	PushFollow(FOLLOW_type_in_funcDecl288);
            	type();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_declarator_in_funcDecl290);
            	declarator();
            	state.followingStackPointer--;

            	Match(input,21,FOLLOW_21_in_funcDecl292); 
            	// C:\\Users\\Administrator\\Desktop\\P.g:133:22: ( parameters )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= 30 && LA3_0 <= 34)) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Users\\Administrator\\Desktop\\P.g:133:23: parameters
            			    {
            			    	PushFollow(FOLLOW_parameters_in_funcDecl295);
            			    	parameters();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	Match(input,22,FOLLOW_22_in_funcDecl299); 
            	Match(input,23,FOLLOW_23_in_funcDecl301); 

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
    // $ANTLR end "funcDecl"

    protected class kernel_function_scope 
    {
        protected internal String name;
    }
    protected Stack kernel_function_stack = new Stack();

    public class kernel_function_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "kernel_function"
    // C:\\Users\\Administrator\\Desktop\\P.g:136:1: kernel_function : '#pragma kernel_start' ( statement )+ '#pragma kernel_end' ;
    public PParser.kernel_function_return kernel_function() // throws RecognitionException [1]
    {   
        slist_stack.Push(new slist_scope());
        kernel_function_stack.Push(new kernel_function_scope());
        PParser.kernel_function_return retval = new PParser.kernel_function_return();
        retval.Start = input.LT(1);


        	((slist_scope)slist_stack.Peek()).locals =  new ArrayList();
        	((slist_scope)slist_stack.Peek()).stats =  new ArrayList();

        try 
    	{
            // C:\\Users\\Administrator\\Desktop\\P.g:145:2: ( '#pragma kernel_start' ( statement )+ '#pragma kernel_end' )
            // C:\\Users\\Administrator\\Desktop\\P.g:146:2: '#pragma kernel_start' ( statement )+ '#pragma kernel_end'
            {
            	Match(input,24,FOLLOW_24_in_kernel_function328); 
            	// C:\\Users\\Administrator\\Desktop\\P.g:147:2: ( statement )+
            	int cnt4 = 0;
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == 17 || LA4_0 == 28 || (LA4_0 >= 30 && LA4_0 <= 34)) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\Users\\Administrator\\Desktop\\P.g:147:2: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_kernel_function331);
            			    	statement();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    if ( cnt4 >= 1 ) goto loop4;
            		            EarlyExitException eee4 =
            		                new EarlyExitException(4, input);
            		            throw eee4;
            	    }
            	    cnt4++;
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements

            	Match(input,25,FOLLOW_25_in_kernel_function335); 

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
            kernel_function_stack.Pop();
        }
        return retval;
    }
    // $ANTLR end "kernel_function"

    protected class function_scope 
    {
        protected internal String name;
    }
    protected Stack function_stack = new Stack();

    public class function_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "function"
    // C:\\Users\\Administrator\\Desktop\\P.g:150:1: function : type declarator '(' ( parameters )* ')' block ;
    public PParser.function_return function() // throws RecognitionException [1]
    {   
        slist_stack.Push(new slist_scope());
        function_stack.Push(new function_scope());
        PParser.function_return retval = new PParser.function_return();
        retval.Start = input.LT(1);


        	((slist_scope)slist_stack.Peek()).locals =  new ArrayList();
        	((slist_scope)slist_stack.Peek()).stats =  new ArrayList();

        try 
    	{
            // C:\\Users\\Administrator\\Desktop\\P.g:159:2: ( type declarator '(' ( parameters )* ')' block )
            // C:\\Users\\Administrator\\Desktop\\P.g:160:2: type declarator '(' ( parameters )* ')' block
            {
            	PushFollow(FOLLOW_type_in_function360);
            	type();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_declarator_in_function362);
            	declarator();
            	state.followingStackPointer--;

            	Match(input,21,FOLLOW_21_in_function364); 
            	// C:\\Users\\Administrator\\Desktop\\P.g:160:22: ( parameters )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( ((LA5_0 >= 30 && LA5_0 <= 34)) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // C:\\Users\\Administrator\\Desktop\\P.g:160:23: parameters
            			    {
            			    	PushFollow(FOLLOW_parameters_in_function367);
            			    	parameters();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements

            	Match(input,22,FOLLOW_22_in_function371); 
            	PushFollow(FOLLOW_block_in_function373);
            	block();
            	state.followingStackPointer--;


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
            function_stack.Pop();
        }
        return retval;
    }
    // $ANTLR end "function"

    public class block_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "block"
    // C:\\Users\\Administrator\\Desktop\\P.g:162:1: block : '{' ( statement )* '}' ;
    public PParser.block_return block() // throws RecognitionException [1]
    {   
        PParser.block_return retval = new PParser.block_return();
        retval.Start = input.LT(1);

        try 
    	{
            // C:\\Users\\Administrator\\Desktop\\P.g:162:7: ( '{' ( statement )* '}' )
            // C:\\Users\\Administrator\\Desktop\\P.g:163:2: '{' ( statement )* '}'
            {
            	Match(input,26,FOLLOW_26_in_block383); 
            	// C:\\Users\\Administrator\\Desktop\\P.g:163:6: ( statement )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( (LA6_0 == 17 || LA6_0 == 28 || (LA6_0 >= 30 && LA6_0 <= 34)) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\Users\\Administrator\\Desktop\\P.g:163:7: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_block386);
            			    	statement();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements

            	Match(input,27,FOLLOW_27_in_block390); 

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

    public class declaration_statement_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "declaration_statement"
    // C:\\Users\\Administrator\\Desktop\\P.g:165:1: declaration_statement : ( variable ';' | kernel_variable ';' | kernel_array ';' );
    public PParser.declaration_statement_return declaration_statement() // throws RecognitionException [1]
    {   
        PParser.declaration_statement_return retval = new PParser.declaration_statement_return();
        retval.Start = input.LT(1);

        PParser.kernel_variable_return kernel_variable7 = default(PParser.kernel_variable_return);

        PParser.kernel_array_return kernel_array8 = default(PParser.kernel_array_return);


        try 
    	{
            // C:\\Users\\Administrator\\Desktop\\P.g:166:2: ( variable ';' | kernel_variable ';' | kernel_array ';' )
            int alt7 = 3;
            int LA7_0 = input.LA(1);

            if ( ((LA7_0 >= 30 && LA7_0 <= 34)) )
            {
                alt7 = 1;
            }
            else if ( (LA7_0 == 17) )
            {
                int LA7_2 = input.LA(2);

                if ( ((LA7_2 >= 30 && LA7_2 <= 34)) )
                {
                    alt7 = 2;
                }
                else if ( (LA7_2 == ARRAY) )
                {
                    alt7 = 3;
                }
                else 
                {
                    NoViableAltException nvae_d7s2 =
                        new NoViableAltException("", 7, 2, input);

                    throw nvae_d7s2;
                }
            }
            else 
            {
                NoViableAltException nvae_d7s0 =
                    new NoViableAltException("", 7, 0, input);

                throw nvae_d7s0;
            }
            switch (alt7) 
            {
                case 1 :
                    // C:\\Users\\Administrator\\Desktop\\P.g:167:2: variable ';'
                    {
                    	PushFollow(FOLLOW_variable_in_declaration_statement402);
                    	variable();
                    	state.followingStackPointer--;

                    	Match(input,23,FOLLOW_23_in_declaration_statement404); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Administrator\\Desktop\\P.g:168:2: kernel_variable ';'
                    {
                    	PushFollow(FOLLOW_kernel_variable_in_declaration_statement408);
                    	kernel_variable7 = kernel_variable();
                    	state.followingStackPointer--;

                    	Match(input,23,FOLLOW_23_in_declaration_statement410); 
                    	((program_scope)program_stack.Peek()).kernelvars.Add(((kernel_variable7 != null) ? kernel_variable7.ST : null));

                    }
                    break;
                case 3 :
                    // C:\\Users\\Administrator\\Desktop\\P.g:169:2: kernel_array ';'
                    {
                    	PushFollow(FOLLOW_kernel_array_in_declaration_statement417);
                    	kernel_array8 = kernel_array();
                    	state.followingStackPointer--;

                    	Match(input,23,FOLLOW_23_in_declaration_statement419); 
                    	((program_scope)program_stack.Peek()).kernelvars.Add(((kernel_array8 != null) ? kernel_array8.ST : null));

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
    // $ANTLR end "declaration_statement"

    public class printf_statament_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "printf_statament"
    // C:\\Users\\Administrator\\Desktop\\P.g:171:1: printf_statament : 'printf(\"' . ')' ';' ;
    public PParser.printf_statament_return printf_statament() // throws RecognitionException [1]
    {   
        PParser.printf_statament_return retval = new PParser.printf_statament_return();
        retval.Start = input.LT(1);

        try 
    	{
            // C:\\Users\\Administrator\\Desktop\\P.g:172:1: ( 'printf(\"' . ')' ';' )
            // C:\\Users\\Administrator\\Desktop\\P.g:173:2: 'printf(\"' . ')' ';'
            {
            	Match(input,28,FOLLOW_28_in_printf_statament432); 
            	MatchAny(input); 
            	Match(input,22,FOLLOW_22_in_printf_statament437); 
            	Match(input,23,FOLLOW_23_in_printf_statament439); 

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
    // $ANTLR end "printf_statament"

    public class statement_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "statement"
    // C:\\Users\\Administrator\\Desktop\\P.g:175:1: statement : ( declaration_statement | printf_statament );
    public PParser.statement_return statement() // throws RecognitionException [1]
    {   
        PParser.statement_return retval = new PParser.statement_return();
        retval.Start = input.LT(1);

        try 
    	{
            // C:\\Users\\Administrator\\Desktop\\P.g:176:2: ( declaration_statement | printf_statament )
            int alt8 = 2;
            int LA8_0 = input.LA(1);

            if ( (LA8_0 == 17 || (LA8_0 >= 30 && LA8_0 <= 34)) )
            {
                alt8 = 1;
            }
            else if ( (LA8_0 == 28) )
            {
                alt8 = 2;
            }
            else 
            {
                NoViableAltException nvae_d8s0 =
                    new NoViableAltException("", 8, 0, input);

                throw nvae_d8s0;
            }
            switch (alt8) 
            {
                case 1 :
                    // C:\\Users\\Administrator\\Desktop\\P.g:177:2: declaration_statement
                    {
                    	PushFollow(FOLLOW_declaration_statement_in_statement451);
                    	declaration_statement();
                    	state.followingStackPointer--;


                    }
                    break;
                case 2 :
                    // C:\\Users\\Administrator\\Desktop\\P.g:178:4: printf_statament
                    {
                    	PushFollow(FOLLOW_printf_statament_in_statement456);
                    	printf_statament();
                    	state.followingStackPointer--;


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
    // $ANTLR end "statement"

    public class parameters_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "parameters"
    // C:\\Users\\Administrator\\Desktop\\P.g:180:1: parameters : ( type ( declarator | arraydeclarator ) ) ( ( ',' ) ( type ( declarator | arraydeclarator ) ) )* ;
    public PParser.parameters_return parameters() // throws RecognitionException [1]
    {   
        PParser.parameters_return retval = new PParser.parameters_return();
        retval.Start = input.LT(1);

        try 
    	{
            // C:\\Users\\Administrator\\Desktop\\P.g:181:2: ( ( type ( declarator | arraydeclarator ) ) ( ( ',' ) ( type ( declarator | arraydeclarator ) ) )* )
            // C:\\Users\\Administrator\\Desktop\\P.g:182:2: ( type ( declarator | arraydeclarator ) ) ( ( ',' ) ( type ( declarator | arraydeclarator ) ) )*
            {
            	// C:\\Users\\Administrator\\Desktop\\P.g:182:2: ( type ( declarator | arraydeclarator ) )
            	// C:\\Users\\Administrator\\Desktop\\P.g:182:3: type ( declarator | arraydeclarator )
            	{
            		PushFollow(FOLLOW_type_in_parameters469);
            		type();
            		state.followingStackPointer--;

            		// C:\\Users\\Administrator\\Desktop\\P.g:182:8: ( declarator | arraydeclarator )
            		int alt9 = 2;
            		int LA9_0 = input.LA(1);

            		if ( (LA9_0 == ID) )
            		{
            		    alt9 = 1;
            		}
            		else if ( (LA9_0 == ARRAY) )
            		{
            		    alt9 = 2;
            		}
            		else 
            		{
            		    NoViableAltException nvae_d9s0 =
            		        new NoViableAltException("", 9, 0, input);

            		    throw nvae_d9s0;
            		}
            		switch (alt9) 
            		{
            		    case 1 :
            		        // C:\\Users\\Administrator\\Desktop\\P.g:182:9: declarator
            		        {
            		        	PushFollow(FOLLOW_declarator_in_parameters472);
            		        	declarator();
            		        	state.followingStackPointer--;


            		        }
            		        break;
            		    case 2 :
            		        // C:\\Users\\Administrator\\Desktop\\P.g:182:20: arraydeclarator
            		        {
            		        	PushFollow(FOLLOW_arraydeclarator_in_parameters474);
            		        	arraydeclarator();
            		        	state.followingStackPointer--;


            		        }
            		        break;

            		}


            	}

            	// C:\\Users\\Administrator\\Desktop\\P.g:182:38: ( ( ',' ) ( type ( declarator | arraydeclarator ) ) )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == 29) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // C:\\Users\\Administrator\\Desktop\\P.g:182:39: ( ',' ) ( type ( declarator | arraydeclarator ) )
            			    {
            			    	// C:\\Users\\Administrator\\Desktop\\P.g:182:39: ( ',' )
            			    	// C:\\Users\\Administrator\\Desktop\\P.g:182:40: ','
            			    	{
            			    		Match(input,29,FOLLOW_29_in_parameters480); 

            			    	}

            			    	// C:\\Users\\Administrator\\Desktop\\P.g:182:45: ( type ( declarator | arraydeclarator ) )
            			    	// C:\\Users\\Administrator\\Desktop\\P.g:182:46: type ( declarator | arraydeclarator )
            			    	{
            			    		PushFollow(FOLLOW_type_in_parameters484);
            			    		type();
            			    		state.followingStackPointer--;

            			    		// C:\\Users\\Administrator\\Desktop\\P.g:182:51: ( declarator | arraydeclarator )
            			    		int alt10 = 2;
            			    		int LA10_0 = input.LA(1);

            			    		if ( (LA10_0 == ID) )
            			    		{
            			    		    alt10 = 1;
            			    		}
            			    		else if ( (LA10_0 == ARRAY) )
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
            			    		        // C:\\Users\\Administrator\\Desktop\\P.g:182:52: declarator
            			    		        {
            			    		        	PushFollow(FOLLOW_declarator_in_parameters487);
            			    		        	declarator();
            			    		        	state.followingStackPointer--;


            			    		        }
            			    		        break;
            			    		    case 2 :
            			    		        // C:\\Users\\Administrator\\Desktop\\P.g:182:63: arraydeclarator
            			    		        {
            			    		        	PushFollow(FOLLOW_arraydeclarator_in_parameters489);
            			    		        	arraydeclarator();
            			    		        	state.followingStackPointer--;


            			    		        }
            			    		        break;

            			    		}


            			    	}


            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements


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
    // $ANTLR end "parameters"

    public class variable_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "variable"
    // C:\\Users\\Administrator\\Desktop\\P.g:184:1: variable : variabledeclarator ;
    public PParser.variable_return variable() // throws RecognitionException [1]
    {   
        PParser.variable_return retval = new PParser.variable_return();
        retval.Start = input.LT(1);

        try 
    	{
            // C:\\Users\\Administrator\\Desktop\\P.g:184:9: ( variabledeclarator )
            // C:\\Users\\Administrator\\Desktop\\P.g:185:3: variabledeclarator
            {
            	PushFollow(FOLLOW_variabledeclarator_in_variable504);
            	variabledeclarator();
            	state.followingStackPointer--;


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

    public class variabledeclarator_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "variabledeclarator"
    // C:\\Users\\Administrator\\Desktop\\P.g:188:1: variabledeclarator : type mixdeclarator ;
    public PParser.variabledeclarator_return variabledeclarator() // throws RecognitionException [1]
    {   
        PParser.variabledeclarator_return retval = new PParser.variabledeclarator_return();
        retval.Start = input.LT(1);

        try 
    	{
            // C:\\Users\\Administrator\\Desktop\\P.g:188:19: ( type mixdeclarator )
            // C:\\Users\\Administrator\\Desktop\\P.g:189:4: type mixdeclarator
            {
            	PushFollow(FOLLOW_type_in_variabledeclarator516);
            	type();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_mixdeclarator_in_variabledeclarator518);
            	mixdeclarator();
            	state.followingStackPointer--;


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
    // $ANTLR end "variabledeclarator"

    public class mixdeclarator_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "mixdeclarator"
    // C:\\Users\\Administrator\\Desktop\\P.g:192:1: mixdeclarator : ( ID | ARRAY ) ( ( ',' ) ( ID | ARRAY ) )* ;
    public PParser.mixdeclarator_return mixdeclarator() // throws RecognitionException [1]
    {   
        PParser.mixdeclarator_return retval = new PParser.mixdeclarator_return();
        retval.Start = input.LT(1);

        try 
    	{
            // C:\\Users\\Administrator\\Desktop\\P.g:193:2: ( ( ID | ARRAY ) ( ( ',' ) ( ID | ARRAY ) )* )
            // C:\\Users\\Administrator\\Desktop\\P.g:194:2: ( ID | ARRAY ) ( ( ',' ) ( ID | ARRAY ) )*
            {
            	if ( input.LA(1) == ID || input.LA(1) == ARRAY ) 
            	{
            	    input.Consume();
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}

            	// C:\\Users\\Administrator\\Desktop\\P.g:194:13: ( ( ',' ) ( ID | ARRAY ) )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( (LA12_0 == 29) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\Users\\Administrator\\Desktop\\P.g:194:14: ( ',' ) ( ID | ARRAY )
            			    {
            			    	// C:\\Users\\Administrator\\Desktop\\P.g:194:14: ( ',' )
            			    	// C:\\Users\\Administrator\\Desktop\\P.g:194:15: ','
            			    	{
            			    		Match(input,29,FOLLOW_29_in_mixdeclarator538); 

            			    	}

            			    	if ( input.LA(1) == ID || input.LA(1) == ARRAY ) 
            			    	{
            			    	    input.Consume();
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}


            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements


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
    // $ANTLR end "mixdeclarator"

    public class declarator_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "declarator"
    // C:\\Users\\Administrator\\Desktop\\P.g:197:1: declarator : ID ;
    public PParser.declarator_return declarator() // throws RecognitionException [1]
    {   
        PParser.declarator_return retval = new PParser.declarator_return();
        retval.Start = input.LT(1);

        try 
    	{
            // C:\\Users\\Administrator\\Desktop\\P.g:198:2: ( ID )
            // C:\\Users\\Administrator\\Desktop\\P.g:199:2: ID
            {
            	Match(input,ID,FOLLOW_ID_in_declarator560); 

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

    public class arraydeclarator_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "arraydeclarator"
    // C:\\Users\\Administrator\\Desktop\\P.g:201:1: arraydeclarator : ARRAY ;
    public PParser.arraydeclarator_return arraydeclarator() // throws RecognitionException [1]
    {   
        PParser.arraydeclarator_return retval = new PParser.arraydeclarator_return();
        retval.Start = input.LT(1);

        try 
    	{
            // C:\\Users\\Administrator\\Desktop\\P.g:202:2: ( ARRAY )
            // C:\\Users\\Administrator\\Desktop\\P.g:203:2: ARRAY
            {
            	Match(input,ARRAY,FOLLOW_ARRAY_in_arraydeclarator571); 

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

    public class type_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "type"
    // C:\\Users\\Administrator\\Desktop\\P.g:206:1: type : ( 'int' | 'char' | 'float' | 'unsigned' | 'void' );
    public PParser.type_return type() // throws RecognitionException [1]
    {   
        PParser.type_return retval = new PParser.type_return();
        retval.Start = input.LT(1);

        try 
    	{
            // C:\\Users\\Administrator\\Desktop\\P.g:206:6: ( 'int' | 'char' | 'float' | 'unsigned' | 'void' )
            // C:\\Users\\Administrator\\Desktop\\P.g:
            {
            	if ( (input.LA(1) >= 30 && input.LA(1) <= 34) ) 
            	{
            	    input.Consume();
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
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
    // $ANTLR end "type"

    // Delegated rules


   	protected DFA2 dfa2;
	private void InitializeCyclicDFAs()
	{
    	this.dfa2 = new DFA2(this);
	}

    const string DFA2_eotS =
        "\x16\uffff";
    const string DFA2_eofS =
        "\x06\uffff\x02\x09\x03\uffff\x01\x09\x0a\uffff";
    const string DFA2_minS =
        "\x01\x11\x01\uffff\x01\x04\x03\uffff\x02\x11\x01\x04\x01\uffff"+
        "\x01\x16\x01\x11\x01\x04\x01\x17\x02\x16\x02\uffff\x01\x1e\x01\x04"+
        "\x02\x16";
    const string DFA2_maxS =
        "\x01\x22\x01\uffff\x01\x06\x03\uffff\x02\x22\x01\x06\x01\uffff"+
        "\x02\x22\x01\x06\x01\x1a\x02\x22\x02\uffff\x01\x22\x01\x06\x02\x22";
    const string DFA2_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x05\x01\x06\x01\x07\x03\uffff"+
        "\x01\x02\x06\uffff\x01\x03\x01\x04\x04\uffff";
    const string DFA2_specialS =
        "\x16\uffff}>";
    static readonly string[] DFA2_transitionS = {
            "\x01\x04\x01\x01\x01\uffff\x01\x03\x03\uffff\x01\x05\x03\uffff"+
            "\x01\x04\x01\uffff\x05\x02",
            "",
            "\x01\x06\x01\uffff\x01\x07",
            "",
            "",
            "",
            "\x02\x09\x01\uffff\x01\x09\x01\x0a\x01\uffff\x01\x04\x01\x09"+
            "\x03\uffff\x01\x09\x01\x08\x05\x09",
            "\x02\x09\x01\uffff\x01\x09\x02\uffff\x01\x04\x01\x09\x03\uffff"+
            "\x01\x09\x01\x08\x05\x09",
            "\x01\x0b\x01\uffff\x01\x0b",
            "",
            "\x01\x0d\x07\uffff\x05\x0c",
            "\x02\x09\x01\uffff\x01\x09\x02\uffff\x01\x04\x01\x09\x03\uffff"+
            "\x01\x09\x01\x08\x05\x09",
            "\x01\x0e\x01\uffff\x01\x0f",
            "\x01\x10\x02\uffff\x01\x11",
            "\x01\x0d\x06\uffff\x01\x12\x05\x0c",
            "\x01\x0d\x06\uffff\x01\x12\x05\x0c",
            "",
            "",
            "\x05\x13",
            "\x01\x14\x01\uffff\x01\x15",
            "\x01\x0d\x06\uffff\x01\x12\x05\x0c",
            "\x01\x0d\x06\uffff\x01\x12\x05\x0c"
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
            get { return "94:1: declaration : ( include | variable | funcDecl | function | define | statement | kf= kernel_function );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_declaration_in_program61 = new BitSet(new ulong[]{0x00000007D1160002UL});
    public static readonly BitSet FOLLOW_include_in_declaration128 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_declaration138 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_funcDecl_in_declaration152 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_function_in_declaration164 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_define_in_declaration188 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_declaration201 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_kernel_function_in_declaration215 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_17_in_kernel_variable235 = new BitSet(new ulong[]{0x00000007C0000000UL});
    public static readonly BitSet FOLLOW_variable_in_kernel_variable237 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_17_in_kernel_array247 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_arraydeclarator_in_kernel_array249 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_18_in_include259 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_include262 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_20_in_define274 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_define276 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_INT_in_define278 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_funcDecl288 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_declarator_in_funcDecl290 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_funcDecl292 = new BitSet(new ulong[]{0x00000007C0400000UL});
    public static readonly BitSet FOLLOW_parameters_in_funcDecl295 = new BitSet(new ulong[]{0x00000007C0400000UL});
    public static readonly BitSet FOLLOW_22_in_funcDecl299 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_23_in_funcDecl301 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_24_in_kernel_function328 = new BitSet(new ulong[]{0x00000007D0020000UL});
    public static readonly BitSet FOLLOW_statement_in_kernel_function331 = new BitSet(new ulong[]{0x00000007D2020000UL});
    public static readonly BitSet FOLLOW_25_in_kernel_function335 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_function360 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_declarator_in_function362 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_function364 = new BitSet(new ulong[]{0x00000007C0400000UL});
    public static readonly BitSet FOLLOW_parameters_in_function367 = new BitSet(new ulong[]{0x00000007C0400000UL});
    public static readonly BitSet FOLLOW_22_in_function371 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_block_in_function373 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_26_in_block383 = new BitSet(new ulong[]{0x00000007D8020000UL});
    public static readonly BitSet FOLLOW_statement_in_block386 = new BitSet(new ulong[]{0x00000007D8020000UL});
    public static readonly BitSet FOLLOW_27_in_block390 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_declaration_statement402 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_23_in_declaration_statement404 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_kernel_variable_in_declaration_statement408 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_23_in_declaration_statement410 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_kernel_array_in_declaration_statement417 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_23_in_declaration_statement419 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_28_in_printf_statament432 = new BitSet(new ulong[]{0x00000007FFFFFFF0UL});
    public static readonly BitSet FOLLOW_22_in_printf_statament437 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_23_in_printf_statament439 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_declaration_statement_in_statement451 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_printf_statament_in_statement456 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_parameters469 = new BitSet(new ulong[]{0x0000000000000050UL});
    public static readonly BitSet FOLLOW_declarator_in_parameters472 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_arraydeclarator_in_parameters474 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_29_in_parameters480 = new BitSet(new ulong[]{0x00000007C0000000UL});
    public static readonly BitSet FOLLOW_type_in_parameters484 = new BitSet(new ulong[]{0x0000000000000050UL});
    public static readonly BitSet FOLLOW_declarator_in_parameters487 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_arraydeclarator_in_parameters489 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_variabledeclarator_in_variable504 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_variabledeclarator516 = new BitSet(new ulong[]{0x0000000000000050UL});
    public static readonly BitSet FOLLOW_mixdeclarator_in_variabledeclarator518 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_mixdeclarator530 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_29_in_mixdeclarator538 = new BitSet(new ulong[]{0x0000000000000050UL});
    public static readonly BitSet FOLLOW_set_in_mixdeclarator541 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_ID_in_declarator560 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ARRAY_in_arraydeclarator571 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_type0 = new BitSet(new ulong[]{0x0000000000000002UL});

}
