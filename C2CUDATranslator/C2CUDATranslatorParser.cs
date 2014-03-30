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


using Antlr.StringTemplate;
using Antlr.StringTemplate.Language;
using Hashtable = System.Collections.Hashtable;
public partial class C2CUDATranslatorParser : Parser
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
		"MAINS", 
		"PRINT", 
		"STRING_LITERAL", 
		"CHARACTER_LITERAL", 
		"WS", 
		"CHARS", 
		"LINE_COMMENT", 
		"COMMENT", 
		"EscapeSequence", 
		"OctalEscape", 
		"';'", 
		"'()'", 
		"'('", 
		"'int'", 
		"'char'", 
		"'*'", 
		"'[]'", 
		"','", 
		"')'", 
		"'{'", 
		"'}'", 
		"');'", 
		"'.'", 
		"'+'", 
		"'-'", 
		"'/'", 
		"'%'", 
		"'float'", 
		"'bool'", 
		"'kernel'", 
		"'void'", 
		"'double'", 
		"'cudaDeviceProp'", 
		"'size_t'", 
		"'#include'", 
		"'for'", 
		"'='", 
		"'-='", 
		"'+='", 
		"'fprintf('", 
		"'default'", 
		"':'", 
		"'return'", 
		"'while'", 
		"'do'", 
		"'if'", 
		"'else'", 
		"'switch'", 
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
		"'['", 
		"']'", 
		"'kernel('", 
		"'();'", 
		"'local'", 
		"'#pragma kernel_start'", 
		"'#pragma kernel_end'", 
		"'printf('", 
		"']]'"
    };

    public const int T__68 = 68;
    public const int T__69 = 69;
    public const int T__66 = 66;
    public const int T__67 = 67;
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
    public const int Keyword = 6;
    public const int T__41 = 41;
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
    public const int WS = 13;
    public const int T__71 = 71;
    public const int T__33 = 33;
    public const int T__72 = 72;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int T__70 = 70;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int CHARS = 14;
    public const int MAINS = 9;
    public const int T__76 = 76;
    public const int T__75 = 75;
    public const int T__74 = 74;
    public const int OctalEscape = 18;
    public const int EscapeSequence = 17;
    public const int T__73 = 73;

    // delegates
    // delegators

    protected class slist_scope 
    {
        protected internal IList locals;
        protected internal // must be defined one per semicolon
            IList stats;
    }
    protected Stack slist_stack = new Stack();



        public C2CUDATranslatorParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public C2CUDATranslatorParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected StringTemplateGroup templateLib =
      new StringTemplateGroup("C2CUDATranslatorParserTemplates", typeof(AngleBracketTemplateLexer));

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
		get { return C2CUDATranslatorParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g"; }
    }


       string getkernelstr(string getarr)
                {
                    string temp, result;
                    temp = "";
                    result = "";
                    int i;
                    for (i = 0; i < getarr.Length ; i++)
                    {
                        if (getarr[i] == '[' || getarr[i] == ']' || getarr[i] == '+' || getarr[i] == '-' || getarr[i] == '*' || getarr[i] == '/' || (getarr[i] >= '0' && getarr[i] <= '9'))
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
    string getkernelstr2(string getarr)
                {
                    string temp, result;
                    temp = "";
                    result = "";
                    int i;
                    for (i = 0; i < getarr.Length ; i++)
                    {
                        if (getarr[i] == '[' || getarr[i] == ']' || getarr[i] == '+' || getarr[i] == '-' || getarr[i] == '*' || getarr[i] == '/' || (getarr[i] >= '0' && getarr[i] <= '9'))
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
                                    if (i == getarr.Length - 1)
                                        {
                                            goto p;
                                        }
                                        else
                                        {
                                            i++;
                                        }
                                }
                                result = result + temp;
                                i=i-1;
                         
                        }

                    }
                    return result;
                     p:
                        result = result + temp;
                        i = i - 1;
                        return result;
                }
     string Getdeclfrmlist(IList list)
               {
                   string d=string.Empty ;
                   int i;
                   for (i = 0; i < list.Count - 1; i++)
                   {
                      // d = d.ToString() + list[i].ToString().SubString(list[i]);
                   }
                   return d;
               }
       string GetIndexofe1(C2CUDATranslatorParser.kassignStat_return e1)
                {

                    string index = "";
                    if (e1==null)
                	{
                	return index;
                	}
                    int i=0;
                    while (e1.ST.ToString()[i] != '=')
                    {
                        index = index + e1.ST.ToString()[i];
                        i++;
                    }
                    return index;
                }
          string Getsizeofe2(C2CUDATranslatorParser.kexpr_return  e2)
                   {
                       string index = "";
                       string temp = "";
                       Boolean flag = false;
                        if (e2==null)
                    	{
                    	return index;
                    	}
                       int i = 0;
                      
                       
                       for (i = 0; i < e2.ST.ToString().Length; i++)
                       {
                           if (e2.ST.ToString()[i] >= '0' && e2.ST.ToString()[i] <= '9')
                           {
                               index = index + e2.ST.ToString()[i];
                               
                           }
                           else
                           {
                               if (e2.ST.ToString()[i] == '>' || e2.ST.ToString()[i] == '<' || e2.ST.ToString()[i] == '=' || e2.ST.ToString()[i] == '!')
                               {
                                   flag=true ;
                               }
                               if ((e2.ST.ToString()[i] >= 'A' && e2.ST.ToString()[i] <= 'Z') || (e2.ST.ToString()[i] >= 'a' && e2.ST.ToString()[i] <= 'z') || (e2.ST.ToString()[i] >= '_'))
                               {
                                   if (flag)
                                   {
                                       temp = temp + e2.ST.ToString()[i];
                                   }
                               }
                               else
                               {
                                   
                               }
                           }

                       }
                      temp= temp.Replace("gpu_","").ToString();
                  for(i=0;i<((program_scope)program_stack.Peek()).Constants.Count;i++)
                  {
                      String s = ((program_scope)program_stack.Peek()).Constants[i].ToString();
                      if (String.Compare(temp, s) == 0)
                      {
                          index = temp;
                      }
                  }
                      
                       return index;
                   }
          public string ArraytoString(ArrayList index1)
            {
                string a = string.Empty ;
                int i;
                for (i = 0; i < index1.Count; i++)
                {
                    a += index1[i];
                }
                return a;
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
     	public string Get2DArrayDeviceName(String name)
            {
                string a = string.Empty ;
                int i;
                for (i = 0; i < ((program_scope)program_stack.Peek()).RowsAccessed2.Count; i++)
                {
                    if(String.Compare(((program_scope)program_stack.Peek()).RowsAccessed[i].ToString(), name)==0)
                    {
                    a=((program_scope)program_stack.Peek()).RowsAccessed2[i].ToString();
                    }
                }
                return a;
            }
            public string Get2DArrayDevicePitch(String name)
            {
                string a = string.Empty ;
                int i;
                for (i = 0; i < ((program_scope)program_stack.Peek()).RowsAccessed3.Count; i++)
                {
                    if(String.Compare(((program_scope)program_stack.Peek()).RowsAccessed4[i].ToString(), name)==0)
                    {
                    a=((program_scope)program_stack.Peek()).RowsAccessed3[i].ToString();
                    }
                }
                return a;
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
        protected internal IList ReadOnly;
        protected internal IList WriteOnly;
        protected internal IList funclist;
        protected internal IList PitchSatements;
        protected internal IList Constants;
        protected internal IList RowsAccessed;
        protected internal IList RowsAccessed2;
        protected internal IList RowsAccessed3;
        protected internal IList RowsAccessed4;
        protected internal IList RowsAccessed5;
        protected internal IList kernellocals;
        protected internal String kernelpar;
        protected internal String kernelpar2;
        protected internal String temp;
        protected internal String size;
        protected internal String index;
        protected internal Boolean recursionflag;
        protected internal Boolean iteraiveflag;
        protected internal int kernelforloopindex;
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
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:221:1: program : ( declaration )+ -> program(globals=$program::globalsfunctions=$program::functionsincludes=$program::includesmainstats=$program::mainstatskernelvars=$program::kernelvarskernelcopyin=$program::kernelcopyinfunctiondeclarations=$program::functiondeclarationsReadOnly=$program::ReadOnlyWriteOnly=$program::WriteOnlysize=$program::sizefunclist=$program::funclistpitchstats=$program::PitchSatementsrowaccessed=$program::RowsAccessedkernellocals=$program::kernellocals);
    public C2CUDATranslatorParser.program_return program() // throws RecognitionException [1]
    {   
        program_stack.Push(new program_scope());
        C2CUDATranslatorParser.program_return retval = new C2CUDATranslatorParser.program_return();
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
          ((program_scope)program_stack.Peek()).ReadOnly =  new ArrayList();
          ((program_scope)program_stack.Peek()).WriteOnly =  new ArrayList();
          ((program_scope)program_stack.Peek()).funclist =  new ArrayList();
          ((program_scope)program_stack.Peek()).PitchSatements =  new ArrayList();
          ((program_scope)program_stack.Peek()).Constants =  new ArrayList();
          ((program_scope)program_stack.Peek()).RowsAccessed =  new ArrayList();
          ((program_scope)program_stack.Peek()).RowsAccessed2 =  new ArrayList();
          ((program_scope)program_stack.Peek()).RowsAccessed3 =  new ArrayList();
          ((program_scope)program_stack.Peek()).RowsAccessed4 =  new ArrayList();
          ((program_scope)program_stack.Peek()).RowsAccessed5 =  new ArrayList();
          ((program_scope)program_stack.Peek()).kernellocals =  new ArrayList();
          ((program_scope)program_stack.Peek()).recursionflag =  new Boolean();
          ((program_scope)program_stack.Peek()).iteraiveflag =  new Boolean();
          ((program_scope)program_stack.Peek()).kernelforloopindex =  new int();

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:282:5: ( ( declaration )+ -> program(globals=$program::globalsfunctions=$program::functionsincludes=$program::includesmainstats=$program::mainstatskernelvars=$program::kernelvarskernelcopyin=$program::kernelcopyinfunctiondeclarations=$program::functiondeclarationsReadOnly=$program::ReadOnlyWriteOnly=$program::WriteOnlysize=$program::sizefunclist=$program::funclistpitchstats=$program::PitchSatementsrowaccessed=$program::RowsAccessedkernellocals=$program::kernellocals))
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:282:9: ( declaration )+
            {
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:282:9: ( declaration )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= ID && LA1_0 <= INT) || (LA1_0 >= ARRAY && LA1_0 <= PRINT) || LA1_0 == CHARACTER_LITERAL || LA1_0 == 19 || (LA1_0 >= 21 && LA1_0 <= 23) || LA1_0 == 28 || (LA1_0 >= 36 && LA1_0 <= 44) || (LA1_0 >= 48 && LA1_0 <= 49) || (LA1_0 >= 51 && LA1_0 <= 56) || LA1_0 == 68 || (LA1_0 >= 72 && LA1_0 <= 73)) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:282:9: declaration
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
            	// 283:9: -> program(globals=$program::globalsfunctions=$program::functionsincludes=$program::includesmainstats=$program::mainstatskernelvars=$program::kernelvarskernelcopyin=$program::kernelcopyinfunctiondeclarations=$program::functiondeclarationsReadOnly=$program::ReadOnlyWriteOnly=$program::WriteOnlysize=$program::sizefunclist=$program::funclistpitchstats=$program::PitchSatementsrowaccessed=$program::RowsAccessedkernellocals=$program::kernellocals)
            	{
            	    retval.ST = templateLib.GetInstanceOf("program",
            	  new STAttrMap().Add("globals", ((program_scope)program_stack.Peek()).globals).Add("functions", ((program_scope)program_stack.Peek()).functions).Add("includes", ((program_scope)program_stack.Peek()).includes).Add("mainstats", ((program_scope)program_stack.Peek()).mainstats).Add("kernelvars", ((program_scope)program_stack.Peek()).kernelvars).Add("kernelcopyin", ((program_scope)program_stack.Peek()).kernelcopyin).Add("functiondeclarations", ((program_scope)program_stack.Peek()).functiondeclarations).Add("ReadOnly", ((program_scope)program_stack.Peek()).ReadOnly).Add("WriteOnly", ((program_scope)program_stack.Peek()).WriteOnly).Add("size", ((program_scope)program_stack.Peek()).size).Add("funclist", ((program_scope)program_stack.Peek()).funclist).Add("pitchstats", ((program_scope)program_stack.Peek()).PitchSatements).Add("rowaccessed", ((program_scope)program_stack.Peek()).RowsAccessed).Add("kernellocals", ((program_scope)program_stack.Peek()).kernellocals));
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
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:286:1: declaration : ( variable | funcDecl | kernel_variable | kernel_array | kernel_local_variable | include | define | main | statement | kf= kernel_function );
    public C2CUDATranslatorParser.declaration_return declaration() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.declaration_return retval = new C2CUDATranslatorParser.declaration_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.kernel_function_return kf = default(C2CUDATranslatorParser.kernel_function_return);

        C2CUDATranslatorParser.variable_return variable1 = default(C2CUDATranslatorParser.variable_return);

        C2CUDATranslatorParser.funcDecl_return funcDecl2 = default(C2CUDATranslatorParser.funcDecl_return);

        C2CUDATranslatorParser.kernel_variable_return kernel_variable3 = default(C2CUDATranslatorParser.kernel_variable_return);

        C2CUDATranslatorParser.kernel_array_return kernel_array4 = default(C2CUDATranslatorParser.kernel_array_return);

        C2CUDATranslatorParser.kernel_local_variable_return kernel_local_variable5 = default(C2CUDATranslatorParser.kernel_local_variable_return);

        C2CUDATranslatorParser.include_return include6 = default(C2CUDATranslatorParser.include_return);

        C2CUDATranslatorParser.define_return define7 = default(C2CUDATranslatorParser.define_return);

        C2CUDATranslatorParser.main_return main8 = default(C2CUDATranslatorParser.main_return);

        C2CUDATranslatorParser.statement_return statement9 = default(C2CUDATranslatorParser.statement_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:287:5: ( variable | funcDecl | kernel_variable | kernel_array | kernel_local_variable | include | define | main | statement | kf= kernel_function )
            int alt2 = 10;
            alt2 = dfa2.Predict(input);
            switch (alt2) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:287:9: variable
                    {
                    	PushFollow(FOLLOW_variable_in_declaration157);
                    	variable1 = variable();
                    	state.followingStackPointer--;

                    	((program_scope)program_stack.Peek()).globals.Add(((variable1 != null) ? variable1.ST : null));

                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:288:9: funcDecl
                    {
                    	PushFollow(FOLLOW_funcDecl_in_declaration171);
                    	funcDecl2 = funcDecl();
                    	state.followingStackPointer--;

                    	((program_scope)program_stack.Peek()).functiondeclarations.Add(((funcDecl2 != null) ? funcDecl2.ST : null));

                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:290:9: kernel_variable
                    {
                    	PushFollow(FOLLOW_kernel_variable_in_declaration187);
                    	kernel_variable3 = kernel_variable();
                    	state.followingStackPointer--;

                    	((program_scope)program_stack.Peek()).kernelvars.Add(((kernel_variable3 != null) ? kernel_variable3.ST : null));

                    }
                    break;
                case 4 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:291:9: kernel_array
                    {
                    	PushFollow(FOLLOW_kernel_array_in_declaration199);
                    	kernel_array4 = kernel_array();
                    	state.followingStackPointer--;

                    	((program_scope)program_stack.Peek()).kernelvars.Add(((kernel_array4 != null) ? kernel_array4.ST : null));

                    }
                    break;
                case 5 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:292:9: kernel_local_variable
                    {
                    	PushFollow(FOLLOW_kernel_local_variable_in_declaration211);
                    	kernel_local_variable5 = kernel_local_variable();
                    	state.followingStackPointer--;

                    	((program_scope)program_stack.Peek()).kernellocals.Add(((kernel_local_variable5 != null) ? kernel_local_variable5.ST : null));

                    }
                    break;
                case 6 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:293:9: include
                    {
                    	PushFollow(FOLLOW_include_in_declaration223);
                    	include6 = include();
                    	state.followingStackPointer--;

                    	((program_scope)program_stack.Peek()).includes.Add(((include6 != null) ? include6.ST : null));

                    }
                    break;
                case 7 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:294:9: define
                    {
                    	PushFollow(FOLLOW_define_in_declaration235);
                    	define7 = define();
                    	state.followingStackPointer--;

                    	((program_scope)program_stack.Peek()).includes.Add(((define7 != null) ? define7.ST : null));

                    }
                    break;
                case 8 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:295:9: main
                    {
                    	PushFollow(FOLLOW_main_in_declaration247);
                    	main8 = main();
                    	state.followingStackPointer--;

                    	((program_scope)program_stack.Peek()).includes.Add(((main8 != null) ? main8.ST : null));

                    }
                    break;
                case 9 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:296:9: statement
                    {
                    	PushFollow(FOLLOW_statement_in_declaration260);
                    	statement9 = statement();
                    	state.followingStackPointer--;

                    	((program_scope)program_stack.Peek()).mainstats.Add(((statement9 != null) ? statement9.ST : null));

                    }
                    break;
                case 10 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:297:9: kf= kernel_function
                    {
                    	PushFollow(FOLLOW_kernel_function_in_declaration274);
                    	kf = kernel_function();
                    	state.followingStackPointer--;

                    	((program_scope)program_stack.Peek()).functions.Add(((kf != null) ? kf.ST : null));
                    	        ((program_scope)program_stack.Peek()).mainstats.Add(((program_scope)program_stack.Peek()).kernelalloc);
                    	        ((program_scope)program_stack.Peek()).mainstats.Add(((program_scope)program_stack.Peek()).kernelcopyin);  
                    	         if(((program_scope)program_stack.Peek()).funclist.Contains("kernel"))
                    		 {
                    		 ((program_scope)program_stack.Peek()).recursionflag = true;
                    		 }
                    	        ((program_scope)program_stack.Peek()).funclist.Add("kernel");
                    		((program_scope)program_stack.Peek()).mainstats.Add("\n// call kernel \n kernel <<< dim3(n_blocks), dim3(block_size,block_size) >>>("+ ((program_scope)program_stack.Peek()).kernelpar.ToString().Substring(1,((program_scope)program_stack.Peek()).kernelpar.Length -1 )+");");
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

    public class variable_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "variable"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:320:1: variable : ( type declarator ';' -> {$function.Count>0 && $function::name==null}? globalVariable(type=$type.stname=$declarator.st) -> variable(type=$type.stname=$declarator.st) | type arraydeclarator ';' -> {$function.Count>0 && $function::name==null}? globalVariable(type=$type.stname=$arraydeclarator.st) -> variable(type=$type.stname=$arraydeclarator.st));
    public C2CUDATranslatorParser.variable_return variable() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.variable_return retval = new C2CUDATranslatorParser.variable_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.type_return type10 = default(C2CUDATranslatorParser.type_return);

        C2CUDATranslatorParser.declarator_return declarator11 = default(C2CUDATranslatorParser.declarator_return);

        C2CUDATranslatorParser.type_return type12 = default(C2CUDATranslatorParser.type_return);

        C2CUDATranslatorParser.arraydeclarator_return arraydeclarator13 = default(C2CUDATranslatorParser.arraydeclarator_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:321:5: ( type declarator ';' -> {$function.Count>0 && $function::name==null}? globalVariable(type=$type.stname=$declarator.st) -> variable(type=$type.stname=$declarator.st) | type arraydeclarator ';' -> {$function.Count>0 && $function::name==null}? globalVariable(type=$type.stname=$arraydeclarator.st) -> variable(type=$type.stname=$arraydeclarator.st))
            int alt3 = 2;
            alt3 = dfa3.Predict(input);
            switch (alt3) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:321:9: type declarator ';'
                    {
                    	PushFollow(FOLLOW_type_in_variable306);
                    	type10 = type();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_declarator_in_variable308);
                    	declarator11 = declarator();
                    	state.followingStackPointer--;

                    	Match(input,19,FOLLOW_19_in_variable310); 


                    	// TEMPLATE REWRITE
                    	// 322:9: -> {$function.Count>0 && $function::name==null}? globalVariable(type=$type.stname=$declarator.st)
                    	if (function_stack.Count>0 && ((function_scope)function_stack.Peek()).name==null) {
                    	    retval.ST = templateLib.GetInstanceOf("globalVariable",
                    	  new STAttrMap().Add("type", ((type10 != null) ? type10.ST : null)).Add("name", ((declarator11 != null) ? declarator11.ST : null)));
                    	}
                    	else // 324:9: -> variable(type=$type.stname=$declarator.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("variable",
                    	  new STAttrMap().Add("type", ((type10 != null) ? type10.ST : null)).Add("name", ((declarator11 != null) ? declarator11.ST : null)));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:325:10: type arraydeclarator ';'
                    {
                    	PushFollow(FOLLOW_type_in_variable376);
                    	type12 = type();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_arraydeclarator_in_variable378);
                    	arraydeclarator13 = arraydeclarator();
                    	state.followingStackPointer--;

                    	Match(input,19,FOLLOW_19_in_variable380); 


                    	// TEMPLATE REWRITE
                    	// 326:9: -> {$function.Count>0 && $function::name==null}? globalVariable(type=$type.stname=$arraydeclarator.st)
                    	if (function_stack.Count>0 && ((function_scope)function_stack.Peek()).name==null) {
                    	    retval.ST = templateLib.GetInstanceOf("globalVariable",
                    	  new STAttrMap().Add("type", ((type12 != null) ? type12.ST : null)).Add("name", ((arraydeclarator13 != null) ? arraydeclarator13.ST : null)));
                    	}
                    	else // 328:9: -> variable(type=$type.stname=$arraydeclarator.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("variable",
                    	  new STAttrMap().Add("type", ((type12 != null) ? type12.ST : null)).Add("name", ((arraydeclarator13 != null) ? arraydeclarator13.ST : null)));
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

    public class kvariable_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "kvariable"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:331:2: kvariable : ( type kdecl ';' -> {$function.Count>0 && $function::name==null}? globalVariable(type=$type.stname=\"gpu_\"+$kdecl.st) -> variable(type=$type.stname=\"gpu_\"+$kdecl.st) | type arraydeclarator ';' -> {$function.Count>0 && $function::name==null}? globalVariable(type=$type.stname=\"gpu_\"+$arraydeclarator.st) -> variable(type=$type.stname=\"gpu_\"+$arraydeclarator.st));
    public C2CUDATranslatorParser.kvariable_return kvariable() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.kvariable_return retval = new C2CUDATranslatorParser.kvariable_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.type_return type14 = default(C2CUDATranslatorParser.type_return);

        C2CUDATranslatorParser.kdecl_return kdecl15 = default(C2CUDATranslatorParser.kdecl_return);

        C2CUDATranslatorParser.type_return type16 = default(C2CUDATranslatorParser.type_return);

        C2CUDATranslatorParser.arraydeclarator_return arraydeclarator17 = default(C2CUDATranslatorParser.arraydeclarator_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:332:5: ( type kdecl ';' -> {$function.Count>0 && $function::name==null}? globalVariable(type=$type.stname=\"gpu_\"+$kdecl.st) -> variable(type=$type.stname=\"gpu_\"+$kdecl.st) | type arraydeclarator ';' -> {$function.Count>0 && $function::name==null}? globalVariable(type=$type.stname=\"gpu_\"+$arraydeclarator.st) -> variable(type=$type.stname=\"gpu_\"+$arraydeclarator.st))
            int alt4 = 2;
            alt4 = dfa4.Predict(input);
            switch (alt4) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:332:9: type kdecl ';'
                    {
                    	PushFollow(FOLLOW_type_in_kvariable459);
                    	type14 = type();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_kdecl_in_kvariable461);
                    	kdecl15 = kdecl();
                    	state.followingStackPointer--;

                    	Match(input,19,FOLLOW_19_in_kvariable463); 


                    	// TEMPLATE REWRITE
                    	// 333:9: -> {$function.Count>0 && $function::name==null}? globalVariable(type=$type.stname=\"gpu_\"+$kdecl.st)
                    	if (function_stack.Count>0 && ((function_scope)function_stack.Peek()).name==null) {
                    	    retval.ST = templateLib.GetInstanceOf("globalVariable",
                    	  new STAttrMap().Add("type", ((type14 != null) ? type14.ST : null)).Add("name", "gpu_"+((kdecl15 != null) ? kdecl15.ST : null)));
                    	}
                    	else // 335:9: -> variable(type=$type.stname=\"gpu_\"+$kdecl.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("variable",
                    	  new STAttrMap().Add("type", ((type14 != null) ? type14.ST : null)).Add("name", "gpu_"+((kdecl15 != null) ? kdecl15.ST : null)));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:336:10: type arraydeclarator ';'
                    {
                    	PushFollow(FOLLOW_type_in_kvariable529);
                    	type16 = type();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_arraydeclarator_in_kvariable531);
                    	arraydeclarator17 = arraydeclarator();
                    	state.followingStackPointer--;

                    	Match(input,19,FOLLOW_19_in_kvariable533); 


                    	// TEMPLATE REWRITE
                    	// 337:9: -> {$function.Count>0 && $function::name==null}? globalVariable(type=$type.stname=\"gpu_\"+$arraydeclarator.st)
                    	if (function_stack.Count>0 && ((function_scope)function_stack.Peek()).name==null) {
                    	    retval.ST = templateLib.GetInstanceOf("globalVariable",
                    	  new STAttrMap().Add("type", ((type16 != null) ? type16.ST : null)).Add("name", "gpu_"+((arraydeclarator17 != null) ? arraydeclarator17.ST : null)));
                    	}
                    	else // 339:9: -> variable(type=$type.stname=\"gpu_\"+$arraydeclarator.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("variable",
                    	  new STAttrMap().Add("type", ((type16 != null) ? type16.ST : null)).Add("name", "gpu_"+((arraydeclarator17 != null) ? arraydeclarator17.ST : null)));
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
    // $ANTLR end "kvariable"

    public class statement_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "statement"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:342:1: statement : stat -> type(name=$stat.st);
    public C2CUDATranslatorParser.statement_return statement() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.statement_return retval = new C2CUDATranslatorParser.statement_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.stat_return stat18 = default(C2CUDATranslatorParser.stat_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:343:1: ( stat -> type(name=$stat.st))
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:343:8: stat
            {
            	PushFollow(FOLLOW_stat_in_statement610);
            	stat18 = stat();
            	state.followingStackPointer--;



            	// TEMPLATE REWRITE
            	// 343:13: -> type(name=$stat.st)
            	{
            	    retval.ST = templateLib.GetInstanceOf("type",
            	  new STAttrMap().Add("name", ((stat18 != null) ? stat18.ST : null)));
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
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:345:1: statement_list : ( statement )+ ;
    public C2CUDATranslatorParser.statement_list_return statement_list() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.statement_list_return retval = new C2CUDATranslatorParser.statement_list_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:347:2: ( ( statement )+ )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:347:4: ( statement )+
            {
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:347:4: ( statement )+
            	int cnt5 = 0;
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( ((LA5_0 >= ID && LA5_0 <= INT) || (LA5_0 >= ARRAY && LA5_0 <= RWORD) || LA5_0 == PRINT || LA5_0 == CHARACTER_LITERAL || LA5_0 == 19 || LA5_0 == 21 || LA5_0 == 28 || LA5_0 == 44 || (LA5_0 >= 48 && LA5_0 <= 49) || (LA5_0 >= 51 && LA5_0 <= 56) || LA5_0 == 68) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:347:4: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_statement_list629);
            			    	statement();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    if ( cnt5 >= 1 ) goto loop5;
            		            EarlyExitException eee5 =
            		                new EarlyExitException(5, input);
            		            throw eee5;
            	    }
            	    cnt5++;
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements


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

    public class main_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "main"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:351:1: main : ( type mdeclarator '()' mblock -> main(type=$type.stname=$mdeclarator.st) | type mdeclarator '(' ( ( 'int' | 'char' ) ( '*' )* declarator ( '[]' )* ) ( ( ',' ) ( ( 'int' | 'char' ) ( '*' )* declarator ( '[]' )* ) )* ')' mblock -> maint(type=$type.stname=$mdeclarator.st) | mdeclarator '()' mblock -> main(type=\"\"name=$mdeclarator.st));
    public C2CUDATranslatorParser.main_return main() // throws RecognitionException [1]
    {   
        slist_stack.Push(new slist_scope());

        C2CUDATranslatorParser.main_return retval = new C2CUDATranslatorParser.main_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.type_return type19 = default(C2CUDATranslatorParser.type_return);

        C2CUDATranslatorParser.mdeclarator_return mdeclarator20 = default(C2CUDATranslatorParser.mdeclarator_return);

        C2CUDATranslatorParser.type_return type21 = default(C2CUDATranslatorParser.type_return);

        C2CUDATranslatorParser.mdeclarator_return mdeclarator22 = default(C2CUDATranslatorParser.mdeclarator_return);

        C2CUDATranslatorParser.mdeclarator_return mdeclarator23 = default(C2CUDATranslatorParser.mdeclarator_return);



        	((slist_scope)slist_stack.Peek()).locals =  new ArrayList();
        	((slist_scope)slist_stack.Peek()).stats =  new ArrayList();

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:357:1: ( type mdeclarator '()' mblock -> main(type=$type.stname=$mdeclarator.st) | type mdeclarator '(' ( ( 'int' | 'char' ) ( '*' )* declarator ( '[]' )* ) ( ( ',' ) ( ( 'int' | 'char' ) ( '*' )* declarator ( '[]' )* ) )* ')' mblock -> maint(type=$type.stname=$mdeclarator.st) | mdeclarator '()' mblock -> main(type=\"\"name=$mdeclarator.st))
            int alt13 = 3;
            alt13 = dfa13.Predict(input);
            switch (alt13) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:358:2: type mdeclarator '()' mblock
                    {
                    	PushFollow(FOLLOW_type_in_main654);
                    	type19 = type();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_mdeclarator_in_main656);
                    	mdeclarator20 = mdeclarator();
                    	state.followingStackPointer--;

                    	Match(input,20,FOLLOW_20_in_main658); 
                    	PushFollow(FOLLOW_mblock_in_main660);
                    	mblock();
                    	state.followingStackPointer--;

                    	 ((program_scope)program_stack.Peek()).funclist.Add("main");


                    	// TEMPLATE REWRITE
                    	// 359:2: -> main(type=$type.stname=$mdeclarator.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("main",
                    	  new STAttrMap().Add("type", ((type19 != null) ? type19.ST : null)).Add("name", ((mdeclarator20 != null) ? mdeclarator20.ST : null)));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:361:4: type mdeclarator '(' ( ( 'int' | 'char' ) ( '*' )* declarator ( '[]' )* ) ( ( ',' ) ( ( 'int' | 'char' ) ( '*' )* declarator ( '[]' )* ) )* ')' mblock
                    {
                    	PushFollow(FOLLOW_type_in_main682);
                    	type21 = type();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_mdeclarator_in_main684);
                    	mdeclarator22 = mdeclarator();
                    	state.followingStackPointer--;

                    	Match(input,21,FOLLOW_21_in_main686); 
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:361:25: ( ( 'int' | 'char' ) ( '*' )* declarator ( '[]' )* )
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:361:26: ( 'int' | 'char' ) ( '*' )* declarator ( '[]' )*
                    	{
                    		// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:361:26: ( 'int' | 'char' )
                    		int alt6 = 2;
                    		int LA6_0 = input.LA(1);

                    		if ( (LA6_0 == 22) )
                    		{
                    		    alt6 = 1;
                    		}
                    		else if ( (LA6_0 == 23) )
                    		{
                    		    alt6 = 2;
                    		}
                    		else 
                    		{
                    		    NoViableAltException nvae_d6s0 =
                    		        new NoViableAltException("", 6, 0, input);

                    		    throw nvae_d6s0;
                    		}
                    		switch (alt6) 
                    		{
                    		    case 1 :
                    		        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:361:27: 'int'
                    		        {
                    		        	Match(input,22,FOLLOW_22_in_main690); 

                    		        }
                    		        break;
                    		    case 2 :
                    		        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:361:33: 'char'
                    		        {
                    		        	Match(input,23,FOLLOW_23_in_main692); 

                    		        }
                    		        break;

                    		}

                    		// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:361:41: ( '*' )*
                    		do 
                    		{
                    		    int alt7 = 2;
                    		    int LA7_0 = input.LA(1);

                    		    if ( (LA7_0 == 24) )
                    		    {
                    		        alt7 = 1;
                    		    }


                    		    switch (alt7) 
                    			{
                    				case 1 :
                    				    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:361:42: '*'
                    				    {
                    				    	Match(input,24,FOLLOW_24_in_main696); 

                    				    }
                    				    break;

                    				default:
                    				    goto loop7;
                    		    }
                    		} while (true);

                    		loop7:
                    			;	// Stops C# compiler whining that label 'loop7' has no statements

                    		PushFollow(FOLLOW_declarator_in_main700);
                    		declarator();
                    		state.followingStackPointer--;

                    		// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:361:59: ( '[]' )*
                    		do 
                    		{
                    		    int alt8 = 2;
                    		    int LA8_0 = input.LA(1);

                    		    if ( (LA8_0 == 25) )
                    		    {
                    		        alt8 = 1;
                    		    }


                    		    switch (alt8) 
                    			{
                    				case 1 :
                    				    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:361:60: '[]'
                    				    {
                    				    	Match(input,25,FOLLOW_25_in_main703); 

                    				    }
                    				    break;

                    				default:
                    				    goto loop8;
                    		    }
                    		} while (true);

                    		loop8:
                    			;	// Stops C# compiler whining that label 'loop8' has no statements


                    	}

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:361:68: ( ( ',' ) ( ( 'int' | 'char' ) ( '*' )* declarator ( '[]' )* ) )*
                    	do 
                    	{
                    	    int alt12 = 2;
                    	    int LA12_0 = input.LA(1);

                    	    if ( (LA12_0 == 26) )
                    	    {
                    	        alt12 = 1;
                    	    }


                    	    switch (alt12) 
                    		{
                    			case 1 :
                    			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:361:69: ( ',' ) ( ( 'int' | 'char' ) ( '*' )* declarator ( '[]' )* )
                    			    {
                    			    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:361:69: ( ',' )
                    			    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:361:70: ','
                    			    	{
                    			    		Match(input,26,FOLLOW_26_in_main710); 

                    			    	}

                    			    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:361:75: ( ( 'int' | 'char' ) ( '*' )* declarator ( '[]' )* )
                    			    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:361:76: ( 'int' | 'char' ) ( '*' )* declarator ( '[]' )*
                    			    	{
                    			    		// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:361:76: ( 'int' | 'char' )
                    			    		int alt9 = 2;
                    			    		int LA9_0 = input.LA(1);

                    			    		if ( (LA9_0 == 22) )
                    			    		{
                    			    		    alt9 = 1;
                    			    		}
                    			    		else if ( (LA9_0 == 23) )
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
                    			    		        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:361:77: 'int'
                    			    		        {
                    			    		        	Match(input,22,FOLLOW_22_in_main715); 

                    			    		        }
                    			    		        break;
                    			    		    case 2 :
                    			    		        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:361:83: 'char'
                    			    		        {
                    			    		        	Match(input,23,FOLLOW_23_in_main717); 

                    			    		        }
                    			    		        break;

                    			    		}

                    			    		// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:361:91: ( '*' )*
                    			    		do 
                    			    		{
                    			    		    int alt10 = 2;
                    			    		    int LA10_0 = input.LA(1);

                    			    		    if ( (LA10_0 == 24) )
                    			    		    {
                    			    		        alt10 = 1;
                    			    		    }


                    			    		    switch (alt10) 
                    			    			{
                    			    				case 1 :
                    			    				    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:361:92: '*'
                    			    				    {
                    			    				    	Match(input,24,FOLLOW_24_in_main721); 

                    			    				    }
                    			    				    break;

                    			    				default:
                    			    				    goto loop10;
                    			    		    }
                    			    		} while (true);

                    			    		loop10:
                    			    			;	// Stops C# compiler whining that label 'loop10' has no statements

                    			    		PushFollow(FOLLOW_declarator_in_main725);
                    			    		declarator();
                    			    		state.followingStackPointer--;

                    			    		// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:361:109: ( '[]' )*
                    			    		do 
                    			    		{
                    			    		    int alt11 = 2;
                    			    		    int LA11_0 = input.LA(1);

                    			    		    if ( (LA11_0 == 25) )
                    			    		    {
                    			    		        alt11 = 1;
                    			    		    }


                    			    		    switch (alt11) 
                    			    			{
                    			    				case 1 :
                    			    				    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:361:110: '[]'
                    			    				    {
                    			    				    	Match(input,25,FOLLOW_25_in_main728); 

                    			    				    }
                    			    				    break;

                    			    				default:
                    			    				    goto loop11;
                    			    		    }
                    			    		} while (true);

                    			    		loop11:
                    			    			;	// Stops C# compiler whining that label 'loop11' has no statements


                    			    	}


                    			    }
                    			    break;

                    			default:
                    			    goto loop12;
                    	    }
                    	} while (true);

                    	loop12:
                    		;	// Stops C# compiler whining that label 'loop12' has no statements

                    	Match(input,27,FOLLOW_27_in_main736); 
                    	PushFollow(FOLLOW_mblock_in_main738);
                    	mblock();
                    	state.followingStackPointer--;

                    	 ((program_scope)program_stack.Peek()).funclist.Add("main");


                    	// TEMPLATE REWRITE
                    	// 362:2: -> maint(type=$type.stname=$mdeclarator.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("maint",
                    	  new STAttrMap().Add("type", ((type21 != null) ? type21.ST : null)).Add("name", ((mdeclarator22 != null) ? mdeclarator22.ST : null)));
                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:363:4: mdeclarator '()' mblock
                    {
                    	PushFollow(FOLLOW_mdeclarator_in_main758);
                    	mdeclarator23 = mdeclarator();
                    	state.followingStackPointer--;

                    	Match(input,20,FOLLOW_20_in_main760); 
                    	PushFollow(FOLLOW_mblock_in_main762);
                    	mblock();
                    	state.followingStackPointer--;

                    	 ((program_scope)program_stack.Peek()).funclist.Add("main");


                    	// TEMPLATE REWRITE
                    	// 364:2: -> main(type=\"\"name=$mdeclarator.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("main",
                    	  new STAttrMap().Add("type", "").Add("name", ((mdeclarator23 != null) ? mdeclarator23.ST : null)));
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
    // $ANTLR end "main"

    public class mblock_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "mblock"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:368:1: mblock : '{' ( declaration )+ '}' ;
    public C2CUDATranslatorParser.mblock_return mblock() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.mblock_return retval = new C2CUDATranslatorParser.mblock_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:369:5: ( '{' ( declaration )+ '}' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:369:8: '{' ( declaration )+ '}'
            {
            	Match(input,28,FOLLOW_28_in_mblock795); 

            	    ((program_scope)program_stack.Peek()).kernelcopyout.Add("\n// Retrieve result from device and store it in host array");
            	    ((program_scope)program_stack.Peek()).kernelcopyin.Add("\n// Copy Data to device from host ");
            	    ((program_scope)program_stack.Peek()).kernelalloc.Add("\n// Memory Allocation ");
            	    ((program_scope)program_stack.Peek()).kernelvarfree.Add("\n// Free GPU Variables ");
            	    ((program_scope)program_stack.Peek()).PitchSatements.Add("\n//Pitch Slices per Row for 2D Array");
            	    
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:377:2: ( declaration )+
            	int cnt14 = 0;
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( ((LA14_0 >= ID && LA14_0 <= INT) || (LA14_0 >= ARRAY && LA14_0 <= PRINT) || LA14_0 == CHARACTER_LITERAL || LA14_0 == 19 || (LA14_0 >= 21 && LA14_0 <= 23) || LA14_0 == 28 || (LA14_0 >= 36 && LA14_0 <= 44) || (LA14_0 >= 48 && LA14_0 <= 49) || (LA14_0 >= 51 && LA14_0 <= 56) || LA14_0 == 68 || (LA14_0 >= 72 && LA14_0 <= 73)) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:377:2: declaration
            			    {
            			    	PushFollow(FOLLOW_declaration_in_mblock805);
            			    	declaration();
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

            	Match(input,29,FOLLOW_29_in_mblock824); 

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
    // $ANTLR end "mblock"

    public class include_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "include"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:380:1: include : type kdeclarator -> include(type=$type.stname=$kdeclarator.st);
    public C2CUDATranslatorParser.include_return include() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.include_return retval = new C2CUDATranslatorParser.include_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.type_return type24 = default(C2CUDATranslatorParser.type_return);

        C2CUDATranslatorParser.kdeclarator_return kdeclarator25 = default(C2CUDATranslatorParser.kdeclarator_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:381:1: ( type kdeclarator -> include(type=$type.stname=$kdeclarator.st))
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:381:9: type kdeclarator
            {
            	PushFollow(FOLLOW_type_in_include845);
            	type24 = type();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_kdeclarator_in_include847);
            	kdeclarator25 = kdeclarator();
            	state.followingStackPointer--;



            	// TEMPLATE REWRITE
            	// 383:2: -> include(type=$type.stname=$kdeclarator.st)
            	{
            	    retval.ST = templateLib.GetInstanceOf("include",
            	  new STAttrMap().Add("type", ((type24 != null) ? type24.ST : null)).Add("name", ((kdeclarator25 != null) ? kdeclarator25.ST : null)));
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

    public class funcDecl_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "funcDecl"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:386:1: funcDecl : ( type ID '(' (p+= formalParameter ( ',' p+= formalParameter )* )? ')' ';' -> type(name=$type.st + $ID.text + \"(\"+ $p +\");\") | type ID '(' ');' -> type(name=$type.st + $ID.text + \"(\"+\");\"));
    public C2CUDATranslatorParser.funcDecl_return funcDecl() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.funcDecl_return retval = new C2CUDATranslatorParser.funcDecl_return();
        retval.Start = input.LT(1);

        IToken ID27 = null;
        IToken ID29 = null;
        IList list_p = null;
        C2CUDATranslatorParser.type_return type26 = default(C2CUDATranslatorParser.type_return);

        C2CUDATranslatorParser.type_return type28 = default(C2CUDATranslatorParser.type_return);

        C2CUDATranslatorParser.formalParameter_return p = default(C2CUDATranslatorParser.formalParameter_return);
         p = null;
        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:387:1: ( type ID '(' (p+= formalParameter ( ',' p+= formalParameter )* )? ')' ';' -> type(name=$type.st + $ID.text + \"(\"+ $p +\");\") | type ID '(' ');' -> type(name=$type.st + $ID.text + \"(\"+\");\"))
            int alt17 = 2;
            alt17 = dfa17.Predict(input);
            switch (alt17) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:387:3: type ID '(' (p+= formalParameter ( ',' p+= formalParameter )* )? ')' ';'
                    {
                    	PushFollow(FOLLOW_type_in_funcDecl874);
                    	type26 = type();
                    	state.followingStackPointer--;

                    	ID27=(IToken)Match(input,ID,FOLLOW_ID_in_funcDecl876); 
                    	Match(input,21,FOLLOW_21_in_funcDecl878); 
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:387:15: (p+= formalParameter ( ',' p+= formalParameter )* )?
                    	int alt16 = 2;
                    	int LA16_0 = input.LA(1);

                    	if ( ((LA16_0 >= 22 && LA16_0 <= 23) || (LA16_0 >= 36 && LA16_0 <= 43)) )
                    	{
                    	    alt16 = 1;
                    	}
                    	switch (alt16) 
                    	{
                    	    case 1 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:387:17: p+= formalParameter ( ',' p+= formalParameter )*
                    	        {
                    	        	PushFollow(FOLLOW_formalParameter_in_funcDecl884);
                    	        	p = formalParameter();
                    	        	state.followingStackPointer--;

                    	        	if (list_p == null) list_p = new ArrayList();
                    	        	list_p.Add(p.Template);

                    	        	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:387:36: ( ',' p+= formalParameter )*
                    	        	do 
                    	        	{
                    	        	    int alt15 = 2;
                    	        	    int LA15_0 = input.LA(1);

                    	        	    if ( (LA15_0 == 26) )
                    	        	    {
                    	        	        alt15 = 1;
                    	        	    }


                    	        	    switch (alt15) 
                    	        		{
                    	        			case 1 :
                    	        			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:387:38: ',' p+= formalParameter
                    	        			    {
                    	        			    	Match(input,26,FOLLOW_26_in_funcDecl888); 
                    	        			    	PushFollow(FOLLOW_formalParameter_in_funcDecl892);
                    	        			    	p = formalParameter();
                    	        			    	state.followingStackPointer--;

                    	        			    	if (list_p == null) list_p = new ArrayList();
                    	        			    	list_p.Add(p.Template);


                    	        			    }
                    	        			    break;

                    	        			default:
                    	        			    goto loop15;
                    	        	    }
                    	        	} while (true);

                    	        	loop15:
                    	        		;	// Stops C# compiler whining that label 'loop15' has no statements


                    	        }
                    	        break;

                    	}

                    	Match(input,27,FOLLOW_27_in_funcDecl900); 
                    	Match(input,19,FOLLOW_19_in_funcDecl901); 


                    	// TEMPLATE REWRITE
                    	// 387:74: -> type(name=$type.st + $ID.text + \"(\"+ $p +\");\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", ((type26 != null) ? type26.ST : null) + ((ID27 != null) ? ID27.Text : null) + "("+ list_p +");"));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:388:4: type ID '(' ');'
                    {
                    	PushFollow(FOLLOW_type_in_funcDecl916);
                    	type28 = type();
                    	state.followingStackPointer--;

                    	ID29=(IToken)Match(input,ID,FOLLOW_ID_in_funcDecl918); 
                    	Match(input,21,FOLLOW_21_in_funcDecl920); 
                    	Match(input,30,FOLLOW_30_in_funcDecl922); 


                    	// TEMPLATE REWRITE
                    	// 388:21: -> type(name=$type.st + $ID.text + \"(\"+\");\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", ((type28 != null) ? type28.ST : null) + ((ID29 != null) ? ID29.Text : null) + "("+");"));
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
    // $ANTLR end "funcDecl"

    public class define_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "define"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:390:1: define : rdeclarator declarator t+= digits ( '.' t+= digits )* -> define(type=$rdeclarator.stname=$declarator.stval=ArraytoString((ArrayList)$t,\".\"));
    public C2CUDATranslatorParser.define_return define() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.define_return retval = new C2CUDATranslatorParser.define_return();
        retval.Start = input.LT(1);

        IList list_t = null;
        C2CUDATranslatorParser.declarator_return declarator30 = default(C2CUDATranslatorParser.declarator_return);

        C2CUDATranslatorParser.rdeclarator_return rdeclarator31 = default(C2CUDATranslatorParser.rdeclarator_return);

        C2CUDATranslatorParser.digits_return t = default(C2CUDATranslatorParser.digits_return);
         t = null;
        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:391:1: ( rdeclarator declarator t+= digits ( '.' t+= digits )* -> define(type=$rdeclarator.stname=$declarator.stval=ArraytoString((ArrayList)$t,\".\")))
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:392:2: rdeclarator declarator t+= digits ( '.' t+= digits )*
            {
            	PushFollow(FOLLOW_rdeclarator_in_define943);
            	rdeclarator31 = rdeclarator();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_declarator_in_define945);
            	declarator30 = declarator();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_digits_in_define949);
            	t = digits();
            	state.followingStackPointer--;

            	if (list_t == null) list_t = new ArrayList();
            	list_t.Add(t.Template);

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:392:35: ( '.' t+= digits )*
            	do 
            	{
            	    int alt18 = 2;
            	    int LA18_0 = input.LA(1);

            	    if ( (LA18_0 == 31) )
            	    {
            	        alt18 = 1;
            	    }


            	    switch (alt18) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:392:36: '.' t+= digits
            			    {
            			    	Match(input,31,FOLLOW_31_in_define952); 
            			    	PushFollow(FOLLOW_digits_in_define956);
            			    	t = digits();
            			    	state.followingStackPointer--;

            			    	if (list_t == null) list_t = new ArrayList();
            			    	list_t.Add(t.Template);


            			    }
            			    break;

            			default:
            			    goto loop18;
            	    }
            	} while (true);

            	loop18:
            		;	// Stops C# compiler whining that label 'loop18' has no statements

            	((program_scope)program_stack.Peek()).Constants.Add(((declarator30 != null) ? declarator30.ST : null));


            	// TEMPLATE REWRITE
            	// 393:2: -> define(type=$rdeclarator.stname=$declarator.stval=ArraytoString((ArrayList)$t,\".\"))
            	{
            	    retval.ST = templateLib.GetInstanceOf("define",
            	  new STAttrMap().Add("type", ((rdeclarator31 != null) ? rdeclarator31.ST : null)).Add("name", ((declarator30 != null) ? declarator30.ST : null)).Add("val", ArraytoString((ArrayList)list_t,".")));
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
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:396:1: declarator : ( ID -> {new StringTemplate($ID.text)} | f+= ID ( ',' f+= ID )+ -> type(name=$f));
    public C2CUDATranslatorParser.declarator_return declarator() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.declarator_return retval = new C2CUDATranslatorParser.declarator_return();
        retval.Start = input.LT(1);

        IToken ID32 = null;
        IToken f = null;
        IList list_f = null;

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:397:5: ( ID -> {new StringTemplate($ID.text)} | f+= ID ( ',' f+= ID )+ -> type(name=$f))
            int alt20 = 2;
            int LA20_0 = input.LA(1);

            if ( (LA20_0 == ID) )
            {
                int LA20_1 = input.LA(2);

                if ( ((LA20_1 >= ID && LA20_1 <= INT) || LA20_1 == 19 || LA20_1 == 25 || LA20_1 == 27) )
                {
                    alt20 = 1;
                }
                else if ( (LA20_1 == 26) )
                {
                    int LA20_3 = input.LA(3);

                    if ( (LA20_3 == ID) )
                    {
                        alt20 = 2;
                    }
                    else if ( ((LA20_3 >= 22 && LA20_3 <= 23) || (LA20_3 >= 36 && LA20_3 <= 43)) )
                    {
                        alt20 = 1;
                    }
                    else 
                    {
                        NoViableAltException nvae_d20s3 =
                            new NoViableAltException("", 20, 3, input);

                        throw nvae_d20s3;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d20s1 =
                        new NoViableAltException("", 20, 1, input);

                    throw nvae_d20s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d20s0 =
                    new NoViableAltException("", 20, 0, input);

                throw nvae_d20s0;
            }
            switch (alt20) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:397:9: ID
                    {
                    	ID32=(IToken)Match(input,ID,FOLLOW_ID_in_declarator994); 


                    	// TEMPLATE REWRITE
                    	// 397:13: -> {new StringTemplate($ID.text)}
                    	{
                    	    retval.ST = new StringTemplate(((ID32 != null) ? ID32.Text : null));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:398:4: f+= ID ( ',' f+= ID )+
                    {
                    	f=(IToken)Match(input,ID,FOLLOW_ID_in_declarator1007); 
                    	if (list_f == null) list_f = new ArrayList();
                    	list_f.Add(f);

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:398:10: ( ',' f+= ID )+
                    	int cnt19 = 0;
                    	do 
                    	{
                    	    int alt19 = 2;
                    	    int LA19_0 = input.LA(1);

                    	    if ( (LA19_0 == 26) )
                    	    {
                    	        int LA19_2 = input.LA(2);

                    	        if ( (LA19_2 == ID) )
                    	        {
                    	            alt19 = 1;
                    	        }


                    	    }


                    	    switch (alt19) 
                    		{
                    			case 1 :
                    			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:398:11: ',' f+= ID
                    			    {
                    			    	Match(input,26,FOLLOW_26_in_declarator1010); 
                    			    	f=(IToken)Match(input,ID,FOLLOW_ID_in_declarator1014); 
                    			    	if (list_f == null) list_f = new ArrayList();
                    			    	list_f.Add(f);


                    			    }
                    			    break;

                    			default:
                    			    if ( cnt19 >= 1 ) goto loop19;
                    		            EarlyExitException eee19 =
                    		                new EarlyExitException(19, input);
                    		            throw eee19;
                    	    }
                    	    cnt19++;
                    	} while (true);

                    	loop19:
                    		;	// Stops C# compiler whining that label 'loop19' has no statements



                    	// TEMPLATE REWRITE
                    	// 398:27: -> type(name=$f)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", list_f));
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
    // $ANTLR end "declarator"

    public class kdecl_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "kdecl"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:401:1: kdecl : ( ID -> {new StringTemplate($ID.text)} | f+= ID ( ',' f+= ID )+ -> type(name=$f));
    public C2CUDATranslatorParser.kdecl_return kdecl() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.kdecl_return retval = new C2CUDATranslatorParser.kdecl_return();
        retval.Start = input.LT(1);

        IToken ID33 = null;
        IToken f = null;
        IList list_f = null;

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:402:5: ( ID -> {new StringTemplate($ID.text)} | f+= ID ( ',' f+= ID )+ -> type(name=$f))
            int alt22 = 2;
            int LA22_0 = input.LA(1);

            if ( (LA22_0 == ID) )
            {
                int LA22_1 = input.LA(2);

                if ( (LA22_1 == 26) )
                {
                    alt22 = 2;
                }
                else if ( (LA22_1 == 19) )
                {
                    alt22 = 1;
                }
                else 
                {
                    NoViableAltException nvae_d22s1 =
                        new NoViableAltException("", 22, 1, input);

                    throw nvae_d22s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d22s0 =
                    new NoViableAltException("", 22, 0, input);

                throw nvae_d22s0;
            }
            switch (alt22) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:402:9: ID
                    {
                    	ID33=(IToken)Match(input,ID,FOLLOW_ID_in_kdecl1048); 


                    	// TEMPLATE REWRITE
                    	// 402:13: -> {new StringTemplate($ID.text)}
                    	{
                    	    retval.ST = new StringTemplate(((ID33 != null) ? ID33.Text : null));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:403:4: f+= ID ( ',' f+= ID )+
                    {
                    	f=(IToken)Match(input,ID,FOLLOW_ID_in_kdecl1061); 
                    	if (list_f == null) list_f = new ArrayList();
                    	list_f.Add(f);

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:403:10: ( ',' f+= ID )+
                    	int cnt21 = 0;
                    	do 
                    	{
                    	    int alt21 = 2;
                    	    int LA21_0 = input.LA(1);

                    	    if ( (LA21_0 == 26) )
                    	    {
                    	        alt21 = 1;
                    	    }


                    	    switch (alt21) 
                    		{
                    			case 1 :
                    			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:403:11: ',' f+= ID
                    			    {
                    			    	Match(input,26,FOLLOW_26_in_kdecl1064); 
                    			    	f=(IToken)Match(input,ID,FOLLOW_ID_in_kdecl1068); 
                    			    	if (list_f == null) list_f = new ArrayList();
                    			    	list_f.Add(f);


                    			    }
                    			    break;

                    			default:
                    			    if ( cnt21 >= 1 ) goto loop21;
                    		            EarlyExitException eee21 =
                    		                new EarlyExitException(21, input);
                    		            throw eee21;
                    	    }
                    	    cnt21++;
                    	} while (true);

                    	loop21:
                    		;	// Stops C# compiler whining that label 'loop21' has no statements



                    	// TEMPLATE REWRITE
                    	// 403:27: -> type(name=$f)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", list_f));
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
    // $ANTLR end "kdecl"

    public class digits_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "digits"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:406:1: digits : INT -> {new StringTemplate($INT.text)};
    public C2CUDATranslatorParser.digits_return digits() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.digits_return retval = new C2CUDATranslatorParser.digits_return();
        retval.Start = input.LT(1);

        IToken INT34 = null;

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:407:5: ( INT -> {new StringTemplate($INT.text)})
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:407:9: INT
            {
            	INT34=(IToken)Match(input,INT,FOLLOW_INT_in_digits1102); 


            	// TEMPLATE REWRITE
            	// 407:13: -> {new StringTemplate($INT.text)}
            	{
            	    retval.ST = new StringTemplate(((INT34 != null) ? INT34.Text : null));
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
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:410:1: kdeclarator : Keyword -> {new StringTemplate($Keyword.text)};
    public C2CUDATranslatorParser.kdeclarator_return kdeclarator() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.kdeclarator_return retval = new C2CUDATranslatorParser.kdeclarator_return();
        retval.Start = input.LT(1);

        IToken Keyword35 = null;

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:411:5: ( Keyword -> {new StringTemplate($Keyword.text)})
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:411:9: Keyword
            {
            	Keyword35=(IToken)Match(input,Keyword,FOLLOW_Keyword_in_kdeclarator1126); 


            	// TEMPLATE REWRITE
            	// 411:17: -> {new StringTemplate($Keyword.text)}
            	{
            	    retval.ST = new StringTemplate(((Keyword35 != null) ? Keyword35.Text : null));
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
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:415:1: arraydeclarator : ARRAY -> {new StringTemplate($ARRAY.text)};
    public C2CUDATranslatorParser.arraydeclarator_return arraydeclarator() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.arraydeclarator_return retval = new C2CUDATranslatorParser.arraydeclarator_return();
        retval.Start = input.LT(1);

        IToken ARRAY36 = null;

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:416:5: ( ARRAY -> {new StringTemplate($ARRAY.text)})
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:416:9: ARRAY
            {
            	ARRAY36=(IToken)Match(input,ARRAY,FOLLOW_ARRAY_in_arraydeclarator1156); 


            	// TEMPLATE REWRITE
            	// 416:15: -> {new StringTemplate($ARRAY.text)}
            	{
            	    retval.ST = new StringTemplate(((ARRAY36 != null) ? ARRAY36.Text : null));
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
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:419:1: rdeclarator : RWORD -> {new StringTemplate($RWORD.text)};
    public C2CUDATranslatorParser.rdeclarator_return rdeclarator() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.rdeclarator_return retval = new C2CUDATranslatorParser.rdeclarator_return();
        retval.Start = input.LT(1);

        IToken RWORD37 = null;

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:420:5: ( RWORD -> {new StringTemplate($RWORD.text)})
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:420:9: RWORD
            {
            	RWORD37=(IToken)Match(input,RWORD,FOLLOW_RWORD_in_rdeclarator1183); 


            	// TEMPLATE REWRITE
            	// 420:15: -> {new StringTemplate($RWORD.text)}
            	{
            	    retval.ST = new StringTemplate(((RWORD37 != null) ? RWORD37.Text : null));
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

    public class mdeclarator_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "mdeclarator"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:423:1: mdeclarator : MAINS -> {new StringTemplate($MAINS.text)};
    public C2CUDATranslatorParser.mdeclarator_return mdeclarator() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.mdeclarator_return retval = new C2CUDATranslatorParser.mdeclarator_return();
        retval.Start = input.LT(1);

        IToken MAINS38 = null;

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:424:5: ( MAINS -> {new StringTemplate($MAINS.text)})
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:424:9: MAINS
            {
            	MAINS38=(IToken)Match(input,MAINS,FOLLOW_MAINS_in_mdeclarator1208); 


            	// TEMPLATE REWRITE
            	// 424:15: -> {new StringTemplate($MAINS.text)}
            	{
            	    retval.ST = new StringTemplate(((MAINS38 != null) ? MAINS38.Text : null));
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
    // $ANTLR end "mdeclarator"

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
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:428:1: function : type ID '(' (p+= formalParameter ( ',' p+= formalParameter )* )? ')' block -> function(type=$type.stname=$ID.textlocals=$slist::localsstats=$slist::statsargs=$p);
    public C2CUDATranslatorParser.function_return function() // throws RecognitionException [1]
    {   
        slist_stack.Push(new slist_scope());
        function_stack.Push(new function_scope());
        C2CUDATranslatorParser.function_return retval = new C2CUDATranslatorParser.function_return();
        retval.Start = input.LT(1);

        IToken ID39 = null;
        IList list_p = null;
        C2CUDATranslatorParser.type_return type40 = default(C2CUDATranslatorParser.type_return);

        C2CUDATranslatorParser.formalParameter_return p = default(C2CUDATranslatorParser.formalParameter_return);
         p = null;

        	((slist_scope)slist_stack.Peek()).locals =  new ArrayList();
        	((slist_scope)slist_stack.Peek()).stats =  new ArrayList();

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:437:3: ( type ID '(' (p+= formalParameter ( ',' p+= formalParameter )* )? ')' block -> function(type=$type.stname=$ID.textlocals=$slist::localsstats=$slist::statsargs=$p))
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:437:7: type ID '(' (p+= formalParameter ( ',' p+= formalParameter )* )? ')' block
            {
            	PushFollow(FOLLOW_type_in_function1254);
            	type40 = type();
            	state.followingStackPointer--;

            	ID39=(IToken)Match(input,ID,FOLLOW_ID_in_function1256); 
            	((function_scope)function_stack.Peek()).name = ((ID39 != null) ? ID39.Text : null);
            	Match(input,21,FOLLOW_21_in_function1268); 
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:438:13: (p+= formalParameter ( ',' p+= formalParameter )* )?
            	int alt24 = 2;
            	int LA24_0 = input.LA(1);

            	if ( ((LA24_0 >= 22 && LA24_0 <= 23) || (LA24_0 >= 36 && LA24_0 <= 43)) )
            	{
            	    alt24 = 1;
            	}
            	switch (alt24) 
            	{
            	    case 1 :
            	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:438:15: p+= formalParameter ( ',' p+= formalParameter )*
            	        {
            	        	PushFollow(FOLLOW_formalParameter_in_function1274);
            	        	p = formalParameter();
            	        	state.followingStackPointer--;

            	        	if (list_p == null) list_p = new ArrayList();
            	        	list_p.Add(p.Template);

            	        	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:438:34: ( ',' p+= formalParameter )*
            	        	do 
            	        	{
            	        	    int alt23 = 2;
            	        	    int LA23_0 = input.LA(1);

            	        	    if ( (LA23_0 == 26) )
            	        	    {
            	        	        alt23 = 1;
            	        	    }


            	        	    switch (alt23) 
            	        		{
            	        			case 1 :
            	        			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:438:36: ',' p+= formalParameter
            	        			    {
            	        			    	Match(input,26,FOLLOW_26_in_function1278); 
            	        			    	PushFollow(FOLLOW_formalParameter_in_function1282);
            	        			    	p = formalParameter();
            	        			    	state.followingStackPointer--;

            	        			    	if (list_p == null) list_p = new ArrayList();
            	        			    	list_p.Add(p.Template);


            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop23;
            	        	    }
            	        	} while (true);

            	        	loop23:
            	        		;	// Stops C# compiler whining that label 'loop23' has no statements


            	        }
            	        break;

            	}

            	Match(input,27,FOLLOW_27_in_function1290); 
            	PushFollow(FOLLOW_block_in_function1300);
            	block();
            	state.followingStackPointer--;



            	// TEMPLATE REWRITE
            	// 440:9: -> function(type=$type.stname=$ID.textlocals=$slist::localsstats=$slist::statsargs=$p)
            	{
            	    retval.ST = templateLib.GetInstanceOf("function",
            	  new STAttrMap().Add("type", ((type40 != null) ? type40.ST : null)).Add("name", ((ID39 != null) ? ID39.Text : null)).Add("locals", ((slist_scope)slist_stack.Peek()).locals).Add("stats", ((slist_scope)slist_stack.Peek()).stats).Add("args", list_p));
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
            function_stack.Pop();
        }
        return retval;
    }
    // $ANTLR end "function"

    public class formalParameter_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "formalParameter"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:446:1: formalParameter : ( type ( declarator )* -> parameter(type=$type.stname=$declarator.st) | type arraydeclarator -> parameter(type=$type.stname=$arraydeclarator.st));
    public C2CUDATranslatorParser.formalParameter_return formalParameter() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.formalParameter_return retval = new C2CUDATranslatorParser.formalParameter_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.type_return type41 = default(C2CUDATranslatorParser.type_return);

        C2CUDATranslatorParser.declarator_return declarator42 = default(C2CUDATranslatorParser.declarator_return);

        C2CUDATranslatorParser.type_return type43 = default(C2CUDATranslatorParser.type_return);

        C2CUDATranslatorParser.arraydeclarator_return arraydeclarator44 = default(C2CUDATranslatorParser.arraydeclarator_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:447:5: ( type ( declarator )* -> parameter(type=$type.stname=$declarator.st) | type arraydeclarator -> parameter(type=$type.stname=$arraydeclarator.st))
            int alt26 = 2;
            alt26 = dfa26.Predict(input);
            switch (alt26) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:447:9: type ( declarator )*
                    {
                    	PushFollow(FOLLOW_type_in_formalParameter1415);
                    	type41 = type();
                    	state.followingStackPointer--;

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:447:14: ( declarator )*
                    	do 
                    	{
                    	    int alt25 = 2;
                    	    int LA25_0 = input.LA(1);

                    	    if ( (LA25_0 == ID) )
                    	    {
                    	        alt25 = 1;
                    	    }


                    	    switch (alt25) 
                    		{
                    			case 1 :
                    			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:447:15: declarator
                    			    {
                    			    	PushFollow(FOLLOW_declarator_in_formalParameter1418);
                    			    	declarator42 = declarator();
                    			    	state.followingStackPointer--;


                    			    }
                    			    break;

                    			default:
                    			    goto loop25;
                    	    }
                    	} while (true);

                    	loop25:
                    		;	// Stops C# compiler whining that label 'loop25' has no statements



                    	// TEMPLATE REWRITE
                    	// 448:9: -> parameter(type=$type.stname=$declarator.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("parameter",
                    	  new STAttrMap().Add("type", ((type41 != null) ? type41.ST : null)).Add("name", ((declarator42 != null) ? declarator42.ST : null)));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:449:11: type arraydeclarator
                    {
                    	PushFollow(FOLLOW_type_in_formalParameter1453);
                    	type43 = type();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_arraydeclarator_in_formalParameter1455);
                    	arraydeclarator44 = arraydeclarator();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 450:9: -> parameter(type=$type.stname=$arraydeclarator.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("parameter",
                    	  new STAttrMap().Add("type", ((type43 != null) ? type43.ST : null)).Add("name", ((arraydeclarator44 != null) ? arraydeclarator44.ST : null)));
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
    // $ANTLR end "formalParameter"

    public class afexpr_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "afexpr"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:452:1: afexpr : (a= aftom -> {$a.st}) ( '+' b= aftom -> add(left=$afexpr.stright=$b.st))* ( '-' b= aftom -> Sub(left=$afexpr.stright=$b.st))* ( '/' b= aftom -> Div(left=$afexpr.stright=$b.st))* ( '*' b= aftom -> Mul(left=$afexpr.stright=$b.st))* ( '%' b= aftom -> Mod(left=$afexpr.stright=$b.st))* ;
    public C2CUDATranslatorParser.afexpr_return afexpr() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.afexpr_return retval = new C2CUDATranslatorParser.afexpr_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.aftom_return a = default(C2CUDATranslatorParser.aftom_return);

        C2CUDATranslatorParser.aftom_return b = default(C2CUDATranslatorParser.aftom_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:452:8: ( (a= aftom -> {$a.st}) ( '+' b= aftom -> add(left=$afexpr.stright=$b.st))* ( '-' b= aftom -> Sub(left=$afexpr.stright=$b.st))* ( '/' b= aftom -> Div(left=$afexpr.stright=$b.st))* ( '*' b= aftom -> Mul(left=$afexpr.stright=$b.st))* ( '%' b= aftom -> Mod(left=$afexpr.stright=$b.st))* )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:453:3: (a= aftom -> {$a.st}) ( '+' b= aftom -> add(left=$afexpr.stright=$b.st))* ( '-' b= aftom -> Sub(left=$afexpr.stright=$b.st))* ( '/' b= aftom -> Div(left=$afexpr.stright=$b.st))* ( '*' b= aftom -> Mul(left=$afexpr.stright=$b.st))* ( '%' b= aftom -> Mod(left=$afexpr.stright=$b.st))*
            {
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:453:3: (a= aftom -> {$a.st})
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:453:4: a= aftom
            	{
            		PushFollow(FOLLOW_aftom_in_afexpr1500);
            		a = aftom();
            		state.followingStackPointer--;



            		// TEMPLATE REWRITE
            		// 453:12: -> {$a.st}
            		{
            		    retval.ST = ((a != null) ? a.ST : null);
            		}


            	}

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:454:10: ( '+' b= aftom -> add(left=$afexpr.stright=$b.st))*
            	do 
            	{
            	    int alt27 = 2;
            	    int LA27_0 = input.LA(1);

            	    if ( (LA27_0 == 32) )
            	    {
            	        alt27 = 1;
            	    }


            	    switch (alt27) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:454:12: '+' b= aftom
            			    {
            			    	Match(input,32,FOLLOW_32_in_afexpr1518); 
            			    	PushFollow(FOLLOW_aftom_in_afexpr1522);
            			    	b = aftom();
            			    	state.followingStackPointer--;



            			    	// TEMPLATE REWRITE
            			    	// 454:24: -> add(left=$afexpr.stright=$b.st)
            			    	{
            			    	    retval.ST = templateLib.GetInstanceOf("add",
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

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:455:10: ( '-' b= aftom -> Sub(left=$afexpr.stright=$b.st))*
            	do 
            	{
            	    int alt28 = 2;
            	    int LA28_0 = input.LA(1);

            	    if ( (LA28_0 == 33) )
            	    {
            	        alt28 = 1;
            	    }


            	    switch (alt28) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:455:12: '-' b= aftom
            			    {
            			    	Match(input,33,FOLLOW_33_in_afexpr1552); 
            			    	PushFollow(FOLLOW_aftom_in_afexpr1556);
            			    	b = aftom();
            			    	state.followingStackPointer--;



            			    	// TEMPLATE REWRITE
            			    	// 455:24: -> Sub(left=$afexpr.stright=$b.st)
            			    	{
            			    	    retval.ST = templateLib.GetInstanceOf("Sub",
            			    	  new STAttrMap().Add("left", retval.ST).Add("right", ((b != null) ? b.ST : null)));
            			    	}


            			    }
            			    break;

            			default:
            			    goto loop28;
            	    }
            	} while (true);

            	loop28:
            		;	// Stops C# compiler whining that label 'loop28' has no statements

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:456:10: ( '/' b= aftom -> Div(left=$afexpr.stright=$b.st))*
            	do 
            	{
            	    int alt29 = 2;
            	    int LA29_0 = input.LA(1);

            	    if ( (LA29_0 == 34) )
            	    {
            	        alt29 = 1;
            	    }


            	    switch (alt29) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:456:12: '/' b= aftom
            			    {
            			    	Match(input,34,FOLLOW_34_in_afexpr1586); 
            			    	PushFollow(FOLLOW_aftom_in_afexpr1590);
            			    	b = aftom();
            			    	state.followingStackPointer--;



            			    	// TEMPLATE REWRITE
            			    	// 456:24: -> Div(left=$afexpr.stright=$b.st)
            			    	{
            			    	    retval.ST = templateLib.GetInstanceOf("Div",
            			    	  new STAttrMap().Add("left", retval.ST).Add("right", ((b != null) ? b.ST : null)));
            			    	}


            			    }
            			    break;

            			default:
            			    goto loop29;
            	    }
            	} while (true);

            	loop29:
            		;	// Stops C# compiler whining that label 'loop29' has no statements

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:457:10: ( '*' b= aftom -> Mul(left=$afexpr.stright=$b.st))*
            	do 
            	{
            	    int alt30 = 2;
            	    int LA30_0 = input.LA(1);

            	    if ( (LA30_0 == 24) )
            	    {
            	        alt30 = 1;
            	    }


            	    switch (alt30) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:457:12: '*' b= aftom
            			    {
            			    	Match(input,24,FOLLOW_24_in_afexpr1620); 
            			    	PushFollow(FOLLOW_aftom_in_afexpr1624);
            			    	b = aftom();
            			    	state.followingStackPointer--;



            			    	// TEMPLATE REWRITE
            			    	// 457:24: -> Mul(left=$afexpr.stright=$b.st)
            			    	{
            			    	    retval.ST = templateLib.GetInstanceOf("Mul",
            			    	  new STAttrMap().Add("left", retval.ST).Add("right", ((b != null) ? b.ST : null)));
            			    	}


            			    }
            			    break;

            			default:
            			    goto loop30;
            	    }
            	} while (true);

            	loop30:
            		;	// Stops C# compiler whining that label 'loop30' has no statements

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:458:10: ( '%' b= aftom -> Mod(left=$afexpr.stright=$b.st))*
            	do 
            	{
            	    int alt31 = 2;
            	    int LA31_0 = input.LA(1);

            	    if ( (LA31_0 == 35) )
            	    {
            	        alt31 = 1;
            	    }


            	    switch (alt31) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:458:12: '%' b= aftom
            			    {
            			    	Match(input,35,FOLLOW_35_in_afexpr1654); 
            			    	PushFollow(FOLLOW_aftom_in_afexpr1658);
            			    	b = aftom();
            			    	state.followingStackPointer--;



            			    	// TEMPLATE REWRITE
            			    	// 458:24: -> Mod(left=$afexpr.stright=$b.st)
            			    	{
            			    	    retval.ST = templateLib.GetInstanceOf("Mod",
            			    	  new STAttrMap().Add("left", retval.ST).Add("right", ((b != null) ? b.ST : null)));
            			    	}


            			    }
            			    break;

            			default:
            			    goto loop31;
            	    }
            	} while (true);

            	loop31:
            		;	// Stops C# compiler whining that label 'loop31' has no statements


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
    // $ANTLR end "afexpr"

    public class aftom_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "aftom"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:460:1: aftom : ( ID -> type(name=$ID.text) | ARRAY -> type(name=$ARRAY.text) | INT -> type(name=$INT.text));
    public C2CUDATranslatorParser.aftom_return aftom() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.aftom_return retval = new C2CUDATranslatorParser.aftom_return();
        retval.Start = input.LT(1);

        IToken ID45 = null;
        IToken ARRAY46 = null;
        IToken INT47 = null;

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:460:7: ( ID -> type(name=$ID.text) | ARRAY -> type(name=$ARRAY.text) | INT -> type(name=$INT.text))
            int alt32 = 3;
            switch ( input.LA(1) ) 
            {
            case ID:
            	{
                alt32 = 1;
                }
                break;
            case ARRAY:
            	{
                alt32 = 2;
                }
                break;
            case INT:
            	{
                alt32 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d32s0 =
            	        new NoViableAltException("", 32, 0, input);

            	    throw nvae_d32s0;
            }

            switch (alt32) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:461:2: ID
                    {
                    	ID45=(IToken)Match(input,ID,FOLLOW_ID_in_aftom1686); 


                    	// TEMPLATE REWRITE
                    	// 461:6: -> type(name=$ID.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", ((ID45 != null) ? ID45.Text : null)));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:462:7: ARRAY
                    {
                    	ARRAY46=(IToken)Match(input,ARRAY,FOLLOW_ARRAY_in_aftom1704); 


                    	// TEMPLATE REWRITE
                    	// 462:13: -> type(name=$ARRAY.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", ((ARRAY46 != null) ? ARRAY46.Text : null)));
                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:463:7: INT
                    {
                    	INT47=(IToken)Match(input,INT,FOLLOW_INT_in_aftom1721); 


                    	// TEMPLATE REWRITE
                    	// 463:11: -> type(name=$INT.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", ((INT47 != null) ? INT47.Text : null)));
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
    // $ANTLR end "aftom"

    public class kakfexpr_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "kakfexpr"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:466:1: kakfexpr : (a= kakftom -> {$a.st}) ( '+' b= kakftom -> add(left=$kakfexpr.stright=$b.st))* ( '-' b= kakftom -> Sub(left=$kakfexpr.stright=$b.st))* ( '/' b= kakftom -> Div(left=$kakfexpr.stright=$b.st))* ( '*' b= kakftom -> Mul(left=$kakfexpr.stright=$b.st))* ( '%' b= kakftom -> Mod(left=$kakfexpr.stright=$b.st))* ;
    public C2CUDATranslatorParser.kakfexpr_return kakfexpr() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.kakfexpr_return retval = new C2CUDATranslatorParser.kakfexpr_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.kakftom_return a = default(C2CUDATranslatorParser.kakftom_return);

        C2CUDATranslatorParser.kakftom_return b = default(C2CUDATranslatorParser.kakftom_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:466:10: ( (a= kakftom -> {$a.st}) ( '+' b= kakftom -> add(left=$kakfexpr.stright=$b.st))* ( '-' b= kakftom -> Sub(left=$kakfexpr.stright=$b.st))* ( '/' b= kakftom -> Div(left=$kakfexpr.stright=$b.st))* ( '*' b= kakftom -> Mul(left=$kakfexpr.stright=$b.st))* ( '%' b= kakftom -> Mod(left=$kakfexpr.stright=$b.st))* )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:467:3: (a= kakftom -> {$a.st}) ( '+' b= kakftom -> add(left=$kakfexpr.stright=$b.st))* ( '-' b= kakftom -> Sub(left=$kakfexpr.stright=$b.st))* ( '/' b= kakftom -> Div(left=$kakfexpr.stright=$b.st))* ( '*' b= kakftom -> Mul(left=$kakfexpr.stright=$b.st))* ( '%' b= kakftom -> Mod(left=$kakfexpr.stright=$b.st))*
            {
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:467:3: (a= kakftom -> {$a.st})
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:467:4: a= kakftom
            	{
            		PushFollow(FOLLOW_kakftom_in_kakfexpr1747);
            		a = kakftom();
            		state.followingStackPointer--;



            		// TEMPLATE REWRITE
            		// 467:14: -> {$a.st}
            		{
            		    retval.ST = ((a != null) ? a.ST : null);
            		}


            	}

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:468:10: ( '+' b= kakftom -> add(left=$kakfexpr.stright=$b.st))*
            	do 
            	{
            	    int alt33 = 2;
            	    int LA33_0 = input.LA(1);

            	    if ( (LA33_0 == 32) )
            	    {
            	        alt33 = 1;
            	    }


            	    switch (alt33) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:468:12: '+' b= kakftom
            			    {
            			    	Match(input,32,FOLLOW_32_in_kakfexpr1765); 
            			    	PushFollow(FOLLOW_kakftom_in_kakfexpr1769);
            			    	b = kakftom();
            			    	state.followingStackPointer--;



            			    	// TEMPLATE REWRITE
            			    	// 468:26: -> add(left=$kakfexpr.stright=$b.st)
            			    	{
            			    	    retval.ST = templateLib.GetInstanceOf("add",
            			    	  new STAttrMap().Add("left", retval.ST).Add("right", ((b != null) ? b.ST : null)));
            			    	}


            			    }
            			    break;

            			default:
            			    goto loop33;
            	    }
            	} while (true);

            	loop33:
            		;	// Stops C# compiler whining that label 'loop33' has no statements

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:469:10: ( '-' b= kakftom -> Sub(left=$kakfexpr.stright=$b.st))*
            	do 
            	{
            	    int alt34 = 2;
            	    int LA34_0 = input.LA(1);

            	    if ( (LA34_0 == 33) )
            	    {
            	        alt34 = 1;
            	    }


            	    switch (alt34) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:469:12: '-' b= kakftom
            			    {
            			    	Match(input,33,FOLLOW_33_in_kakfexpr1799); 
            			    	PushFollow(FOLLOW_kakftom_in_kakfexpr1803);
            			    	b = kakftom();
            			    	state.followingStackPointer--;



            			    	// TEMPLATE REWRITE
            			    	// 469:26: -> Sub(left=$kakfexpr.stright=$b.st)
            			    	{
            			    	    retval.ST = templateLib.GetInstanceOf("Sub",
            			    	  new STAttrMap().Add("left", retval.ST).Add("right", ((b != null) ? b.ST : null)));
            			    	}


            			    }
            			    break;

            			default:
            			    goto loop34;
            	    }
            	} while (true);

            	loop34:
            		;	// Stops C# compiler whining that label 'loop34' has no statements

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:470:10: ( '/' b= kakftom -> Div(left=$kakfexpr.stright=$b.st))*
            	do 
            	{
            	    int alt35 = 2;
            	    int LA35_0 = input.LA(1);

            	    if ( (LA35_0 == 34) )
            	    {
            	        alt35 = 1;
            	    }


            	    switch (alt35) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:470:12: '/' b= kakftom
            			    {
            			    	Match(input,34,FOLLOW_34_in_kakfexpr1833); 
            			    	PushFollow(FOLLOW_kakftom_in_kakfexpr1837);
            			    	b = kakftom();
            			    	state.followingStackPointer--;



            			    	// TEMPLATE REWRITE
            			    	// 470:26: -> Div(left=$kakfexpr.stright=$b.st)
            			    	{
            			    	    retval.ST = templateLib.GetInstanceOf("Div",
            			    	  new STAttrMap().Add("left", retval.ST).Add("right", ((b != null) ? b.ST : null)));
            			    	}


            			    }
            			    break;

            			default:
            			    goto loop35;
            	    }
            	} while (true);

            	loop35:
            		;	// Stops C# compiler whining that label 'loop35' has no statements

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:471:10: ( '*' b= kakftom -> Mul(left=$kakfexpr.stright=$b.st))*
            	do 
            	{
            	    int alt36 = 2;
            	    int LA36_0 = input.LA(1);

            	    if ( (LA36_0 == 24) )
            	    {
            	        alt36 = 1;
            	    }


            	    switch (alt36) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:471:12: '*' b= kakftom
            			    {
            			    	Match(input,24,FOLLOW_24_in_kakfexpr1867); 
            			    	PushFollow(FOLLOW_kakftom_in_kakfexpr1871);
            			    	b = kakftom();
            			    	state.followingStackPointer--;



            			    	// TEMPLATE REWRITE
            			    	// 471:26: -> Mul(left=$kakfexpr.stright=$b.st)
            			    	{
            			    	    retval.ST = templateLib.GetInstanceOf("Mul",
            			    	  new STAttrMap().Add("left", retval.ST).Add("right", ((b != null) ? b.ST : null)));
            			    	}


            			    }
            			    break;

            			default:
            			    goto loop36;
            	    }
            	} while (true);

            	loop36:
            		;	// Stops C# compiler whining that label 'loop36' has no statements

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:472:10: ( '%' b= kakftom -> Mod(left=$kakfexpr.stright=$b.st))*
            	do 
            	{
            	    int alt37 = 2;
            	    int LA37_0 = input.LA(1);

            	    if ( (LA37_0 == 35) )
            	    {
            	        alt37 = 1;
            	    }


            	    switch (alt37) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:472:12: '%' b= kakftom
            			    {
            			    	Match(input,35,FOLLOW_35_in_kakfexpr1901); 
            			    	PushFollow(FOLLOW_kakftom_in_kakfexpr1905);
            			    	b = kakftom();
            			    	state.followingStackPointer--;



            			    	// TEMPLATE REWRITE
            			    	// 472:26: -> Mod(left=$kakfexpr.stright=$b.st)
            			    	{
            			    	    retval.ST = templateLib.GetInstanceOf("Mod",
            			    	  new STAttrMap().Add("left", retval.ST).Add("right", ((b != null) ? b.ST : null)));
            			    	}


            			    }
            			    break;

            			default:
            			    goto loop37;
            	    }
            	} while (true);

            	loop37:
            		;	// Stops C# compiler whining that label 'loop37' has no statements


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
    // $ANTLR end "kakfexpr"

    public class kakftom_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "kakftom"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:474:1: kakftom : ( ID -> type(name=$ID.text) | ARRAY -> type(name=$ARRAY.text) | INT -> type(name=$INT.text));
    public C2CUDATranslatorParser.kakftom_return kakftom() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.kakftom_return retval = new C2CUDATranslatorParser.kakftom_return();
        retval.Start = input.LT(1);

        IToken ID48 = null;
        IToken ARRAY49 = null;
        IToken INT50 = null;

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:474:9: ( ID -> type(name=$ID.text) | ARRAY -> type(name=$ARRAY.text) | INT -> type(name=$INT.text))
            int alt38 = 3;
            switch ( input.LA(1) ) 
            {
            case ID:
            	{
                alt38 = 1;
                }
                break;
            case ARRAY:
            	{
                alt38 = 2;
                }
                break;
            case INT:
            	{
                alt38 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d38s0 =
            	        new NoViableAltException("", 38, 0, input);

            	    throw nvae_d38s0;
            }

            switch (alt38) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:475:2: ID
                    {
                    	ID48=(IToken)Match(input,ID,FOLLOW_ID_in_kakftom1933); 


                    	// TEMPLATE REWRITE
                    	// 475:6: -> type(name=$ID.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", ((ID48 != null) ? ID48.Text : null)));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:476:7: ARRAY
                    {
                    	ARRAY49=(IToken)Match(input,ARRAY,FOLLOW_ARRAY_in_kakftom1951); 


                    	// TEMPLATE REWRITE
                    	// 476:13: -> type(name=$ARRAY.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", ((ARRAY49 != null) ? ARRAY49.Text : null)));
                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:477:7: INT
                    {
                    	INT50=(IToken)Match(input,INT,FOLLOW_INT_in_kakftom1968); 


                    	// TEMPLATE REWRITE
                    	// 477:11: -> type(name=$INT.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", ((INT50 != null) ? INT50.Text : null)));
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
    // $ANTLR end "kakftom"

    public class type_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "type"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:480:1: type : ( 'int' -> type_int() | 'char' -> type_char() | 'float' -> type_float() | 'bool' -> type_bool() | 'kernel' -> type_kernel() | 'void' -> type(name=\"void\") | 'double' -> type(name=\"double\") | 'cudaDeviceProp' -> type(name=\"cudaDeviceProp\") | 'size_t' -> type(name=\"size_t\") | '#include' -> type(name=\"#include\"));
    public C2CUDATranslatorParser.type_return type() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.type_return retval = new C2CUDATranslatorParser.type_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:481:5: ( 'int' -> type_int() | 'char' -> type_char() | 'float' -> type_float() | 'bool' -> type_bool() | 'kernel' -> type_kernel() | 'void' -> type(name=\"void\") | 'double' -> type(name=\"double\") | 'cudaDeviceProp' -> type(name=\"cudaDeviceProp\") | 'size_t' -> type(name=\"size_t\") | '#include' -> type(name=\"#include\"))
            int alt39 = 10;
            switch ( input.LA(1) ) 
            {
            case 22:
            	{
                alt39 = 1;
                }
                break;
            case 23:
            	{
                alt39 = 2;
                }
                break;
            case 36:
            	{
                alt39 = 3;
                }
                break;
            case 37:
            	{
                alt39 = 4;
                }
                break;
            case 38:
            	{
                alt39 = 5;
                }
                break;
            case 39:
            	{
                alt39 = 6;
                }
                break;
            case 40:
            	{
                alt39 = 7;
                }
                break;
            case 41:
            	{
                alt39 = 8;
                }
                break;
            case 42:
            	{
                alt39 = 9;
                }
                break;
            case 43:
            	{
                alt39 = 10;
                }
                break;
            	default:
            	    NoViableAltException nvae_d39s0 =
            	        new NoViableAltException("", 39, 0, input);

            	    throw nvae_d39s0;
            }

            switch (alt39) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:481:9: 'int'
                    {
                    	Match(input,22,FOLLOW_22_in_type1995); 


                    	// TEMPLATE REWRITE
                    	// 481:18: -> type_int()
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type_int");
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:482:9: 'char'
                    {
                    	Match(input,23,FOLLOW_23_in_type2014); 


                    	// TEMPLATE REWRITE
                    	// 482:18: -> type_char()
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type_char");
                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:483:9: 'float'
                    {
                    	Match(input,36,FOLLOW_36_in_type2032); 


                    	// TEMPLATE REWRITE
                    	// 483:18: -> type_float()
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type_float");
                    	}


                    }
                    break;
                case 4 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:484:9: 'bool'
                    {
                    	Match(input,37,FOLLOW_37_in_type2049); 


                    	// TEMPLATE REWRITE
                    	// 484:17: -> type_bool()
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type_bool");
                    	}


                    }
                    break;
                case 5 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:485:9: 'kernel'
                    {
                    	Match(input,38,FOLLOW_38_in_type2066); 


                    	// TEMPLATE REWRITE
                    	// 485:18: -> type_kernel()
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type_kernel");
                    	}


                    }
                    break;
                case 6 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:486:9: 'void'
                    {
                    	Match(input,39,FOLLOW_39_in_type2082); 


                    	// TEMPLATE REWRITE
                    	// 486:17: -> type(name=\"void\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "void"));
                    	}


                    }
                    break;
                case 7 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:487:9: 'double'
                    {
                    	Match(input,40,FOLLOW_40_in_type2102); 


                    	// TEMPLATE REWRITE
                    	// 487:19: -> type(name=\"double\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "double"));
                    	}


                    }
                    break;
                case 8 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:488:9: 'cudaDeviceProp'
                    {
                    	Match(input,41,FOLLOW_41_in_type2122); 


                    	// TEMPLATE REWRITE
                    	// 488:25: -> type(name=\"cudaDeviceProp\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "cudaDeviceProp"));
                    	}


                    }
                    break;
                case 9 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:489:7: 'size_t'
                    {
                    	Match(input,42,FOLLOW_42_in_type2138); 


                    	// TEMPLATE REWRITE
                    	// 489:15: -> type(name=\"size_t\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "size_t"));
                    	}


                    }
                    break;
                case 10 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:493:9: '#include'
                    {
                    	Match(input,43,FOLLOW_43_in_type2167); 


                    	// TEMPLATE REWRITE
                    	// 493:21: -> type(name=\"#include\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "#include"));
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

    public class block_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "block"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:500:1: block : '{' ( variable )* ( stat )* '}' ;
    public C2CUDATranslatorParser.block_return block() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.block_return retval = new C2CUDATranslatorParser.block_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.variable_return variable51 = default(C2CUDATranslatorParser.variable_return);

        C2CUDATranslatorParser.stat_return stat52 = default(C2CUDATranslatorParser.stat_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:501:5: ( '{' ( variable )* ( stat )* '}' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:501:8: '{' ( variable )* ( stat )* '}'
            {
            	Match(input,28,FOLLOW_28_in_block2205); 
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:502:10: ( variable )*
            	do 
            	{
            	    int alt40 = 2;
            	    int LA40_0 = input.LA(1);

            	    if ( ((LA40_0 >= 22 && LA40_0 <= 23) || (LA40_0 >= 36 && LA40_0 <= 43)) )
            	    {
            	        alt40 = 1;
            	    }


            	    switch (alt40) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:502:11: variable
            			    {
            			    	PushFollow(FOLLOW_variable_in_block2217);
            			    	variable51 = variable();
            			    	state.followingStackPointer--;

            			    	((slist_scope)slist_stack.Peek()).locals.Add(((variable51 != null) ? variable51.ST : null));

            			    }
            			    break;

            			default:
            			    goto loop40;
            	    }
            	} while (true);

            	loop40:
            		;	// Stops C# compiler whining that label 'loop40' has no statements

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:503:10: ( stat )*
            	do 
            	{
            	    int alt41 = 2;
            	    int LA41_0 = input.LA(1);

            	    if ( ((LA41_0 >= ID && LA41_0 <= INT) || (LA41_0 >= ARRAY && LA41_0 <= RWORD) || LA41_0 == PRINT || LA41_0 == CHARACTER_LITERAL || LA41_0 == 19 || LA41_0 == 21 || LA41_0 == 28 || LA41_0 == 44 || (LA41_0 >= 48 && LA41_0 <= 49) || (LA41_0 >= 51 && LA41_0 <= 56) || LA41_0 == 68) )
            	    {
            	        alt41 = 1;
            	    }


            	    switch (alt41) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:503:11: stat
            			    {
            			    	PushFollow(FOLLOW_stat_in_block2235);
            			    	stat52 = stat();
            			    	state.followingStackPointer--;

            			    	((slist_scope)slist_stack.Peek()).stats.Add(((stat52 != null) ? stat52.ST : null));

            			    }
            			    break;

            			default:
            			    goto loop41;
            	    }
            	} while (true);

            	loop41:
            		;	// Stops C# compiler whining that label 'loop41' has no statements

            	Match(input,29,FOLLOW_29_in_block2288); 

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
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:514:1: stat : ( forStat -> {$forStat.st} | func_call ';' -> {$func_call.st} | expr ';' -> statement(expr=$expr.st) | block -> statementList(locals=$slist::localsstats=$slist::stats) | assignStat ';' -> {$assignStat.st} | print_statement ';' -> {$print_statement.st} | selection_statement -> {$selection_statement.st} | while_statement -> {$while_statement.st} | return_statement ';' -> {$return_statement.st} | func_call2 -> {$func_call2.st} | ';' -> {new StringTemplate(\";\")});
    public C2CUDATranslatorParser.stat_return stat() // throws RecognitionException [1]
    {   
        slist_stack.Push(new slist_scope());

        C2CUDATranslatorParser.stat_return retval = new C2CUDATranslatorParser.stat_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.forStat_return forStat53 = default(C2CUDATranslatorParser.forStat_return);

        C2CUDATranslatorParser.func_call_return func_call54 = default(C2CUDATranslatorParser.func_call_return);

        C2CUDATranslatorParser.expr_return expr55 = default(C2CUDATranslatorParser.expr_return);

        C2CUDATranslatorParser.assignStat_return assignStat56 = default(C2CUDATranslatorParser.assignStat_return);

        C2CUDATranslatorParser.print_statement_return print_statement57 = default(C2CUDATranslatorParser.print_statement_return);

        C2CUDATranslatorParser.selection_statement_return selection_statement58 = default(C2CUDATranslatorParser.selection_statement_return);

        C2CUDATranslatorParser.while_statement_return while_statement59 = default(C2CUDATranslatorParser.while_statement_return);

        C2CUDATranslatorParser.return_statement_return return_statement60 = default(C2CUDATranslatorParser.return_statement_return);

        C2CUDATranslatorParser.func_call2_return func_call261 = default(C2CUDATranslatorParser.func_call2_return);



          ((slist_scope)slist_stack.Peek()).locals =  new ArrayList();
          ((slist_scope)slist_stack.Peek()).stats =  new ArrayList();

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:520:5: ( forStat -> {$forStat.st} | func_call ';' -> {$func_call.st} | expr ';' -> statement(expr=$expr.st) | block -> statementList(locals=$slist::localsstats=$slist::stats) | assignStat ';' -> {$assignStat.st} | print_statement ';' -> {$print_statement.st} | selection_statement -> {$selection_statement.st} | while_statement -> {$while_statement.st} | return_statement ';' -> {$return_statement.st} | func_call2 -> {$func_call2.st} | ';' -> {new StringTemplate(\";\")})
            int alt42 = 11;
            alt42 = dfa42.Predict(input);
            switch (alt42) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:520:7: forStat
                    {
                    	PushFollow(FOLLOW_forStat_in_stat2330);
                    	forStat53 = forStat();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 520:15: -> {$forStat.st}
                    	{
                    	    retval.ST = ((forStat53 != null) ? forStat53.ST : null);
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:521:7: func_call ';'
                    {
                    	PushFollow(FOLLOW_func_call_in_stat2342);
                    	func_call54 = func_call();
                    	state.followingStackPointer--;

                    	Match(input,19,FOLLOW_19_in_stat2345); 

                    	    
                    	    if(((program_scope)program_stack.Peek()).funclist.Contains(((func_call54 != null) ? func_call54.ST : null).ToString()))
                    	    {
                    	    ((program_scope)program_stack.Peek()).recursionflag = true;
                    	    }
                    	    ((program_scope)program_stack.Peek()).funclist.Add(((func_call54 != null) ? func_call54.ST : null));
                    	    


                    	// TEMPLATE REWRITE
                    	// 529:5: -> {$func_call.st}
                    	{
                    	    retval.ST = ((func_call54 != null) ? func_call54.ST : null);
                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:530:7: expr ';'
                    {
                    	PushFollow(FOLLOW_expr_in_stat2364);
                    	expr55 = expr();
                    	state.followingStackPointer--;

                    	Match(input,19,FOLLOW_19_in_stat2366); 


                    	// TEMPLATE REWRITE
                    	// 530:16: -> statement(expr=$expr.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("statement",
                    	  new STAttrMap().Add("expr", ((expr55 != null) ? expr55.ST : null)));
                    	}


                    }
                    break;
                case 4 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:531:7: block
                    {
                    	PushFollow(FOLLOW_block_in_stat2383);
                    	block();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 531:13: -> statementList(locals=$slist::localsstats=$slist::stats)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("statementList",
                    	  new STAttrMap().Add("locals", ((slist_scope)slist_stack.Peek()).locals).Add("stats", ((slist_scope)slist_stack.Peek()).stats));
                    	}


                    }
                    break;
                case 5 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:532:7: assignStat ';'
                    {
                    	PushFollow(FOLLOW_assignStat_in_stat2405);
                    	assignStat56 = assignStat();
                    	state.followingStackPointer--;

                    	Match(input,19,FOLLOW_19_in_stat2407); 


                    	// TEMPLATE REWRITE
                    	// 532:22: -> {$assignStat.st}
                    	{
                    	    retval.ST = ((assignStat56 != null) ? assignStat56.ST : null);
                    	}


                    }
                    break;
                case 6 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:533:7: print_statement ';'
                    {
                    	PushFollow(FOLLOW_print_statement_in_stat2419);
                    	print_statement57 = print_statement();
                    	state.followingStackPointer--;

                    	Match(input,19,FOLLOW_19_in_stat2421); 


                    	// TEMPLATE REWRITE
                    	// 533:27: -> {$print_statement.st}
                    	{
                    	    retval.ST = ((print_statement57 != null) ? print_statement57.ST : null);
                    	}


                    }
                    break;
                case 7 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:534:7: selection_statement
                    {
                    	PushFollow(FOLLOW_selection_statement_in_stat2433);
                    	selection_statement58 = selection_statement();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 534:28: -> {$selection_statement.st}
                    	{
                    	    retval.ST = ((selection_statement58 != null) ? selection_statement58.ST : null);
                    	}


                    }
                    break;
                case 8 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:535:7: while_statement
                    {
                    	PushFollow(FOLLOW_while_statement_in_stat2446);
                    	while_statement59 = while_statement();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 535:24: -> {$while_statement.st}
                    	{
                    	    retval.ST = ((while_statement59 != null) ? while_statement59.ST : null);
                    	}


                    }
                    break;
                case 9 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:536:7: return_statement ';'
                    {
                    	PushFollow(FOLLOW_return_statement_in_stat2459);
                    	return_statement60 = return_statement();
                    	state.followingStackPointer--;

                    	Match(input,19,FOLLOW_19_in_stat2461); 


                    	// TEMPLATE REWRITE
                    	// 536:28: -> {$return_statement.st}
                    	{
                    	    retval.ST = ((return_statement60 != null) ? return_statement60.ST : null);
                    	}


                    }
                    break;
                case 10 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:537:7: func_call2
                    {
                    	PushFollow(FOLLOW_func_call2_in_stat2473);
                    	func_call261 = func_call2();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 537:18: -> {$func_call2.st}
                    	{
                    	    retval.ST = ((func_call261 != null) ? func_call261.ST : null);
                    	}


                    }
                    break;
                case 11 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:542:7: ';'
                    {
                    	Match(input,19,FOLLOW_19_in_stat2501); 


                    	// TEMPLATE REWRITE
                    	// 542:11: -> {new StringTemplate(\";\")}
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

    public class forStat_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "forStat"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:547:1: forStat : 'for' '(' e1= assignStat ';' e2= expr ';' e3= incStat ')' block -> forLoop(e1=$e1.ste2=$e2.ste3=$e3.stlocals=$slist::localsstats=$slist::stats);
    public C2CUDATranslatorParser.forStat_return forStat() // throws RecognitionException [1]
    {   
        slist_stack.Push(new slist_scope());

        C2CUDATranslatorParser.forStat_return retval = new C2CUDATranslatorParser.forStat_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.assignStat_return e1 = default(C2CUDATranslatorParser.assignStat_return);

        C2CUDATranslatorParser.expr_return e2 = default(C2CUDATranslatorParser.expr_return);

        C2CUDATranslatorParser.incStat_return e3 = default(C2CUDATranslatorParser.incStat_return);



          ((slist_scope)slist_stack.Peek()).locals =  new ArrayList();
          ((slist_scope)slist_stack.Peek()).stats =  new ArrayList();

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:553:5: ( 'for' '(' e1= assignStat ';' e2= expr ';' e3= incStat ')' block -> forLoop(e1=$e1.ste2=$e2.ste3=$e3.stlocals=$slist::localsstats=$slist::stats))
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:553:9: 'for' '(' e1= assignStat ';' e2= expr ';' e3= incStat ')' block
            {
            	Match(input,44,FOLLOW_44_in_forStat2536); 
            	Match(input,21,FOLLOW_21_in_forStat2538); 
            	PushFollow(FOLLOW_assignStat_in_forStat2542);
            	e1 = assignStat();
            	state.followingStackPointer--;

            	Match(input,19,FOLLOW_19_in_forStat2544); 
            	PushFollow(FOLLOW_expr_in_forStat2548);
            	e2 = expr();
            	state.followingStackPointer--;

            	Match(input,19,FOLLOW_19_in_forStat2550); 
            	PushFollow(FOLLOW_incStat_in_forStat2554);
            	e3 = incStat();
            	state.followingStackPointer--;

            	Match(input,27,FOLLOW_27_in_forStat2556); 
            	PushFollow(FOLLOW_block_in_forStat2558);
            	block();
            	state.followingStackPointer--;



            	// TEMPLATE REWRITE
            	// 554:9: -> forLoop(e1=$e1.ste2=$e2.ste3=$e3.stlocals=$slist::localsstats=$slist::stats)
            	{
            	    retval.ST = templateLib.GetInstanceOf("forLoop",
            	  new STAttrMap().Add("e1", ((e1 != null) ? e1.ST : null)).Add("e2", ((e2 != null) ? e2.ST : null)).Add("e3", ((e3 != null) ? e3.ST : null)).Add("locals", ((slist_scope)slist_stack.Peek()).locals).Add("stats", ((slist_scope)slist_stack.Peek()).stats));
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
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:558:1: assignStat : ( ID '=' expr -> assign(lhs=$ID.textrhs=$expr.st) | ARRAY '=' expr -> assign(lhs=$ARRAY.textrhs=$expr.st) | ID '-=' expr -> assignop(lhs=$ID.textrhs=$expr.stop=\"-=\") | ARRAY '-=' expr -> assignop(lhs=$ARRAY.textrhs=$expr.stop=\"-=\") | ID '+=' expr -> assignop(lhs=$ID.textrhs=$expr.stop=\"+=\") | ARRAY '+=' expr -> assignop(lhs=$ARRAY.textrhs=$expr.stop=\"+=\") | ID '=' func_call -> assignop(lhs=$ID.textrhs=$func_call.stop=\"=\") | ID '=' func_call '%' expr -> assignop(lhs=$ID.textrhs=$func_call.st + \"\\%\" + $expr.stop=\"=\") | ARRAY '=' func_call '%' expr -> assignop(lhs=$ARRAY.textrhs=$func_call.st + \"\\%\" + $expr.stop=\"=\"));
    public C2CUDATranslatorParser.assignStat_return assignStat() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.assignStat_return retval = new C2CUDATranslatorParser.assignStat_return();
        retval.Start = input.LT(1);

        IToken ID62 = null;
        IToken ARRAY64 = null;
        IToken ID66 = null;
        IToken ARRAY68 = null;
        IToken ID70 = null;
        IToken ARRAY72 = null;
        IToken ID74 = null;
        IToken ID76 = null;
        IToken ARRAY79 = null;
        C2CUDATranslatorParser.expr_return expr63 = default(C2CUDATranslatorParser.expr_return);

        C2CUDATranslatorParser.expr_return expr65 = default(C2CUDATranslatorParser.expr_return);

        C2CUDATranslatorParser.expr_return expr67 = default(C2CUDATranslatorParser.expr_return);

        C2CUDATranslatorParser.expr_return expr69 = default(C2CUDATranslatorParser.expr_return);

        C2CUDATranslatorParser.expr_return expr71 = default(C2CUDATranslatorParser.expr_return);

        C2CUDATranslatorParser.expr_return expr73 = default(C2CUDATranslatorParser.expr_return);

        C2CUDATranslatorParser.func_call_return func_call75 = default(C2CUDATranslatorParser.func_call_return);

        C2CUDATranslatorParser.func_call_return func_call77 = default(C2CUDATranslatorParser.func_call_return);

        C2CUDATranslatorParser.expr_return expr78 = default(C2CUDATranslatorParser.expr_return);

        C2CUDATranslatorParser.func_call_return func_call80 = default(C2CUDATranslatorParser.func_call_return);

        C2CUDATranslatorParser.expr_return expr81 = default(C2CUDATranslatorParser.expr_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:559:5: ( ID '=' expr -> assign(lhs=$ID.textrhs=$expr.st) | ARRAY '=' expr -> assign(lhs=$ARRAY.textrhs=$expr.st) | ID '-=' expr -> assignop(lhs=$ID.textrhs=$expr.stop=\"-=\") | ARRAY '-=' expr -> assignop(lhs=$ARRAY.textrhs=$expr.stop=\"-=\") | ID '+=' expr -> assignop(lhs=$ID.textrhs=$expr.stop=\"+=\") | ARRAY '+=' expr -> assignop(lhs=$ARRAY.textrhs=$expr.stop=\"+=\") | ID '=' func_call -> assignop(lhs=$ID.textrhs=$func_call.stop=\"=\") | ID '=' func_call '%' expr -> assignop(lhs=$ID.textrhs=$func_call.st + \"\\%\" + $expr.stop=\"=\") | ARRAY '=' func_call '%' expr -> assignop(lhs=$ARRAY.textrhs=$func_call.st + \"\\%\" + $expr.stop=\"=\"))
            int alt43 = 9;
            alt43 = dfa43.Predict(input);
            switch (alt43) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:559:11: ID '=' expr
                    {
                    	ID62=(IToken)Match(input,ID,FOLLOW_ID_in_assignStat2633); 
                    	Match(input,45,FOLLOW_45_in_assignStat2635); 
                    	PushFollow(FOLLOW_expr_in_assignStat2637);
                    	expr63 = expr();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 559:23: -> assign(lhs=$ID.textrhs=$expr.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("assign",
                    	  new STAttrMap().Add("lhs", ((ID62 != null) ? ID62.Text : null)).Add("rhs", ((expr63 != null) ? expr63.ST : null)));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:561:9: ARRAY '=' expr
                    {
                    	ARRAY64=(IToken)Match(input,ARRAY,FOLLOW_ARRAY_in_assignStat2667); 
                    	Match(input,45,FOLLOW_45_in_assignStat2669); 
                    	PushFollow(FOLLOW_expr_in_assignStat2671);
                    	expr65 = expr();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 561:24: -> assign(lhs=$ARRAY.textrhs=$expr.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("assign",
                    	  new STAttrMap().Add("lhs", ((ARRAY64 != null) ? ARRAY64.Text : null)).Add("rhs", ((expr65 != null) ? expr65.ST : null)));
                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:564:9: ID '-=' expr
                    {
                    	ID66=(IToken)Match(input,ID,FOLLOW_ID_in_assignStat2704); 
                    	Match(input,46,FOLLOW_46_in_assignStat2706); 
                    	PushFollow(FOLLOW_expr_in_assignStat2708);
                    	expr67 = expr();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 564:22: -> assignop(lhs=$ID.textrhs=$expr.stop=\"-=\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("assignop",
                    	  new STAttrMap().Add("lhs", ((ID66 != null) ? ID66.Text : null)).Add("rhs", ((expr67 != null) ? expr67.ST : null)).Add("op", "-="));
                    	}


                    }
                    break;
                case 4 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:565:9: ARRAY '-=' expr
                    {
                    	ARRAY68=(IToken)Match(input,ARRAY,FOLLOW_ARRAY_in_assignStat2736); 
                    	Match(input,46,FOLLOW_46_in_assignStat2738); 
                    	PushFollow(FOLLOW_expr_in_assignStat2740);
                    	expr69 = expr();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 565:25: -> assignop(lhs=$ARRAY.textrhs=$expr.stop=\"-=\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("assignop",
                    	  new STAttrMap().Add("lhs", ((ARRAY68 != null) ? ARRAY68.Text : null)).Add("rhs", ((expr69 != null) ? expr69.ST : null)).Add("op", "-="));
                    	}


                    }
                    break;
                case 5 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:566:9: ID '+=' expr
                    {
                    	ID70=(IToken)Match(input,ID,FOLLOW_ID_in_assignStat2768); 
                    	Match(input,47,FOLLOW_47_in_assignStat2770); 
                    	PushFollow(FOLLOW_expr_in_assignStat2772);
                    	expr71 = expr();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 566:22: -> assignop(lhs=$ID.textrhs=$expr.stop=\"+=\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("assignop",
                    	  new STAttrMap().Add("lhs", ((ID70 != null) ? ID70.Text : null)).Add("rhs", ((expr71 != null) ? expr71.ST : null)).Add("op", "+="));
                    	}


                    }
                    break;
                case 6 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:567:9: ARRAY '+=' expr
                    {
                    	ARRAY72=(IToken)Match(input,ARRAY,FOLLOW_ARRAY_in_assignStat2800); 
                    	Match(input,47,FOLLOW_47_in_assignStat2802); 
                    	PushFollow(FOLLOW_expr_in_assignStat2804);
                    	expr73 = expr();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 567:25: -> assignop(lhs=$ARRAY.textrhs=$expr.stop=\"+=\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("assignop",
                    	  new STAttrMap().Add("lhs", ((ARRAY72 != null) ? ARRAY72.Text : null)).Add("rhs", ((expr73 != null) ? expr73.ST : null)).Add("op", "+="));
                    	}


                    }
                    break;
                case 7 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:568:9: ID '=' func_call
                    {
                    	ID74=(IToken)Match(input,ID,FOLLOW_ID_in_assignStat2832); 
                    	Match(input,45,FOLLOW_45_in_assignStat2834); 
                    	PushFollow(FOLLOW_func_call_in_assignStat2836);
                    	func_call75 = func_call();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 568:26: -> assignop(lhs=$ID.textrhs=$func_call.stop=\"=\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("assignop",
                    	  new STAttrMap().Add("lhs", ((ID74 != null) ? ID74.Text : null)).Add("rhs", ((func_call75 != null) ? func_call75.ST : null)).Add("op", "="));
                    	}


                    }
                    break;
                case 8 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:569:9: ID '=' func_call '%' expr
                    {
                    	ID76=(IToken)Match(input,ID,FOLLOW_ID_in_assignStat2865); 
                    	Match(input,45,FOLLOW_45_in_assignStat2867); 
                    	PushFollow(FOLLOW_func_call_in_assignStat2869);
                    	func_call77 = func_call();
                    	state.followingStackPointer--;

                    	Match(input,35,FOLLOW_35_in_assignStat2871); 
                    	PushFollow(FOLLOW_expr_in_assignStat2873);
                    	expr78 = expr();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 569:35: -> assignop(lhs=$ID.textrhs=$func_call.st + \"\\%\" + $expr.stop=\"=\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("assignop",
                    	  new STAttrMap().Add("lhs", ((ID76 != null) ? ID76.Text : null)).Add("rhs", ((func_call77 != null) ? func_call77.ST : null) + "%" + ((expr78 != null) ? expr78.ST : null)).Add("op", "="));
                    	}


                    }
                    break;
                case 9 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:570:9: ARRAY '=' func_call '%' expr
                    {
                    	ARRAY79=(IToken)Match(input,ARRAY,FOLLOW_ARRAY_in_assignStat2902); 
                    	Match(input,45,FOLLOW_45_in_assignStat2904); 
                    	PushFollow(FOLLOW_func_call_in_assignStat2906);
                    	func_call80 = func_call();
                    	state.followingStackPointer--;

                    	Match(input,35,FOLLOW_35_in_assignStat2908); 
                    	PushFollow(FOLLOW_expr_in_assignStat2910);
                    	expr81 = expr();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 570:38: -> assignop(lhs=$ARRAY.textrhs=$func_call.st + \"\\%\" + $expr.stop=\"=\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("assignop",
                    	  new STAttrMap().Add("lhs", ((ARRAY79 != null) ? ARRAY79.Text : null)).Add("rhs", ((func_call80 != null) ? func_call80.ST : null) + "%" + ((expr81 != null) ? expr81.ST : null)).Add("op", "="));
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
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:573:1: print_statement : ( PRINT -> type(name=$PRINT.text) | 'fprintf(' ID ',' STRING_LITERAL ')' -> type(name=\"fprintf(\"+$ID.text+\",\"+$STRING_LITERAL.text+\");\") | 'fprintf(' ID ',' STRING_LITERAL (r+= ',' printfParameter )+ ')' -> type(name=\"printf(\"+$ID.text+\",\"+$STRING_LITERAL.text+$printfParameter.st+\");\") | 'default' ':' statement -> type(name=\"default :\"+$statement.st));
    public C2CUDATranslatorParser.print_statement_return print_statement() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.print_statement_return retval = new C2CUDATranslatorParser.print_statement_return();
        retval.Start = input.LT(1);

        IToken PRINT82 = null;
        IToken ID83 = null;
        IToken STRING_LITERAL84 = null;
        IToken ID85 = null;
        IToken STRING_LITERAL86 = null;
        IToken r = null;
        IList list_r = null;
        C2CUDATranslatorParser.printfParameter_return printfParameter87 = default(C2CUDATranslatorParser.printfParameter_return);

        C2CUDATranslatorParser.statement_return statement88 = default(C2CUDATranslatorParser.statement_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:574:2: ( PRINT -> type(name=$PRINT.text) | 'fprintf(' ID ',' STRING_LITERAL ')' -> type(name=\"fprintf(\"+$ID.text+\",\"+$STRING_LITERAL.text+\");\") | 'fprintf(' ID ',' STRING_LITERAL (r+= ',' printfParameter )+ ')' -> type(name=\"printf(\"+$ID.text+\",\"+$STRING_LITERAL.text+$printfParameter.st+\");\") | 'default' ':' statement -> type(name=\"default :\"+$statement.st))
            int alt45 = 4;
            switch ( input.LA(1) ) 
            {
            case PRINT:
            	{
                alt45 = 1;
                }
                break;
            case 48:
            	{
                int LA45_2 = input.LA(2);

                if ( (LA45_2 == ID) )
                {
                    int LA45_4 = input.LA(3);

                    if ( (LA45_4 == 26) )
                    {
                        int LA45_5 = input.LA(4);

                        if ( (LA45_5 == STRING_LITERAL) )
                        {
                            int LA45_6 = input.LA(5);

                            if ( (LA45_6 == 27) )
                            {
                                alt45 = 2;
                            }
                            else if ( (LA45_6 == 26) )
                            {
                                alt45 = 3;
                            }
                            else 
                            {
                                NoViableAltException nvae_d45s6 =
                                    new NoViableAltException("", 45, 6, input);

                                throw nvae_d45s6;
                            }
                        }
                        else 
                        {
                            NoViableAltException nvae_d45s5 =
                                new NoViableAltException("", 45, 5, input);

                            throw nvae_d45s5;
                        }
                    }
                    else 
                    {
                        NoViableAltException nvae_d45s4 =
                            new NoViableAltException("", 45, 4, input);

                        throw nvae_d45s4;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d45s2 =
                        new NoViableAltException("", 45, 2, input);

                    throw nvae_d45s2;
                }
                }
                break;
            case 49:
            	{
                alt45 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d45s0 =
            	        new NoViableAltException("", 45, 0, input);

            	    throw nvae_d45s0;
            }

            switch (alt45) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:575:2: PRINT
                    {
                    	PRINT82=(IToken)Match(input,PRINT,FOLLOW_PRINT_in_print_statement2944); 


                    	// TEMPLATE REWRITE
                    	// 575:8: -> type(name=$PRINT.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", ((PRINT82 != null) ? PRINT82.Text : null)));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:580:3: 'fprintf(' ID ',' STRING_LITERAL ')'
                    {
                    	Match(input,48,FOLLOW_48_in_print_statement2967); 
                    	ID83=(IToken)Match(input,ID,FOLLOW_ID_in_print_statement2969); 
                    	Match(input,26,FOLLOW_26_in_print_statement2971); 
                    	STRING_LITERAL84=(IToken)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_print_statement2973); 
                    	Match(input,27,FOLLOW_27_in_print_statement2975); 


                    	// TEMPLATE REWRITE
                    	// 580:40: -> type(name=\"fprintf(\"+$ID.text+\",\"+$STRING_LITERAL.text+\");\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "fprintf("+((ID83 != null) ? ID83.Text : null)+","+((STRING_LITERAL84 != null) ? STRING_LITERAL84.Text : null)+");"));
                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:581:4: 'fprintf(' ID ',' STRING_LITERAL (r+= ',' printfParameter )+ ')'
                    {
                    	Match(input,48,FOLLOW_48_in_print_statement2989); 
                    	ID85=(IToken)Match(input,ID,FOLLOW_ID_in_print_statement2991); 
                    	Match(input,26,FOLLOW_26_in_print_statement2993); 
                    	STRING_LITERAL86=(IToken)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_print_statement2995); 
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:581:37: (r+= ',' printfParameter )+
                    	int cnt44 = 0;
                    	do 
                    	{
                    	    int alt44 = 2;
                    	    int LA44_0 = input.LA(1);

                    	    if ( (LA44_0 == 26) )
                    	    {
                    	        alt44 = 1;
                    	    }


                    	    switch (alt44) 
                    		{
                    			case 1 :
                    			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:581:39: r+= ',' printfParameter
                    			    {
                    			    	r=(IToken)Match(input,26,FOLLOW_26_in_print_statement3001); 
                    			    	if (list_r == null) list_r = new ArrayList();
                    			    	list_r.Add(r);

                    			    	PushFollow(FOLLOW_printfParameter_in_print_statement3003);
                    			    	printfParameter87 = printfParameter();
                    			    	state.followingStackPointer--;


                    			    }
                    			    break;

                    			default:
                    			    if ( cnt44 >= 1 ) goto loop44;
                    		            EarlyExitException eee44 =
                    		                new EarlyExitException(44, input);
                    		            throw eee44;
                    	    }
                    	    cnt44++;
                    	} while (true);

                    	loop44:
                    		;	// Stops C# compiler whining that label 'loop44' has no statements

                    	Match(input,27,FOLLOW_27_in_print_statement3011); 


                    	// TEMPLATE REWRITE
                    	// 581:72: -> type(name=\"printf(\"+$ID.text+\",\"+$STRING_LITERAL.text+$printfParameter.st+\");\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "printf("+((ID85 != null) ? ID85.Text : null)+","+((STRING_LITERAL86 != null) ? STRING_LITERAL86.Text : null)+((printfParameter87 != null) ? printfParameter87.ST : null)+");"));
                    	}


                    }
                    break;
                case 4 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:584:4: 'default' ':' statement
                    {
                    	Match(input,49,FOLLOW_49_in_print_statement3029); 
                    	Match(input,50,FOLLOW_50_in_print_statement3031); 
                    	PushFollow(FOLLOW_statement_in_print_statement3033);
                    	statement88 = statement();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 584:28: -> type(name=\"default :\"+$statement.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "default :"+((statement88 != null) ? statement88.ST : null)));
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
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:586:1: printfParameter : aexpr -> type(name=$aexpr.st);
    public C2CUDATranslatorParser.printfParameter_return printfParameter() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.printfParameter_return retval = new C2CUDATranslatorParser.printfParameter_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.aexpr_return aexpr89 = default(C2CUDATranslatorParser.aexpr_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:587:5: ( aexpr -> type(name=$aexpr.st))
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:587:9: aexpr
            {
            	PushFollow(FOLLOW_aexpr_in_printfParameter3058);
            	aexpr89 = aexpr();
            	state.followingStackPointer--;

            	((program_scope)program_stack.Peek()).temp+=((aexpr89 != null) ? aexpr89.ST : null);


            	// TEMPLATE REWRITE
            	// 588:9: -> type(name=$aexpr.st)
            	{
            	    retval.ST = templateLib.GetInstanceOf("type",
            	  new STAttrMap().Add("name", ((aexpr89 != null) ? aexpr89.ST : null)));
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
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:591:1: return_statement : ( 'return' digits -> type(name=\"printf(\\\"\\\\n blocksize=\\%d numofblock=\\%d\\\\n\\\",block_size,n_blocks); \\r\\n system(\\\"pause\\\"); \\r\\n return \"+$digits.text +\";\") | 'return' ID -> type(name=\"return \"+$ID.text+\";\") | 'return' ARRAY -> type(name=\"return \"+$ARRAY.text+\";\") | 'return' -> type(name=\"return;\"));
    public C2CUDATranslatorParser.return_statement_return return_statement() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.return_statement_return retval = new C2CUDATranslatorParser.return_statement_return();
        retval.Start = input.LT(1);

        IToken ID91 = null;
        IToken ARRAY92 = null;
        C2CUDATranslatorParser.digits_return digits90 = default(C2CUDATranslatorParser.digits_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:592:1: ( 'return' digits -> type(name=\"printf(\\\"\\\\n blocksize=\\%d numofblock=\\%d\\\\n\\\",block_size,n_blocks); \\r\\n system(\\\"pause\\\"); \\r\\n return \"+$digits.text +\";\") | 'return' ID -> type(name=\"return \"+$ID.text+\";\") | 'return' ARRAY -> type(name=\"return \"+$ARRAY.text+\";\") | 'return' -> type(name=\"return;\"))
            int alt46 = 4;
            int LA46_0 = input.LA(1);

            if ( (LA46_0 == 51) )
            {
                switch ( input.LA(2) ) 
                {
                case ID:
                	{
                    alt46 = 2;
                    }
                    break;
                case ARRAY:
                	{
                    alt46 = 3;
                    }
                    break;
                case INT:
                	{
                    alt46 = 1;
                    }
                    break;
                case 19:
                	{
                    alt46 = 4;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d46s1 =
                	        new NoViableAltException("", 46, 1, input);

                	    throw nvae_d46s1;
                }

            }
            else 
            {
                NoViableAltException nvae_d46s0 =
                    new NoViableAltException("", 46, 0, input);

                throw nvae_d46s0;
            }
            switch (alt46) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:593:4: 'return' digits
                    {
                    	Match(input,51,FOLLOW_51_in_return_statement3098); 
                    	PushFollow(FOLLOW_digits_in_return_statement3100);
                    	digits90 = digits();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 593:20: -> type(name=\"printf(\\\"\\\\n blocksize=\\%d numofblock=\\%d\\\\n\\\",block_size,n_blocks); \\r\\n system(\\\"pause\\\"); \\r\\n return \"+$digits.text +\";\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "printf(\"\\n  blocksize=%d numofblock=%d\\n\",block_size,n_blocks); \r\n system(\"pause\"); \r\n return "+((digits90 != null) ? input.ToString((IToken)(digits90.Start),(IToken)(digits90.Stop)) : null) +";"));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:594:4: 'return' ID
                    {
                    	Match(input,51,FOLLOW_51_in_return_statement3114); 
                    	ID91=(IToken)Match(input,ID,FOLLOW_ID_in_return_statement3116); 


                    	// TEMPLATE REWRITE
                    	// 594:20: -> type(name=\"return \"+$ID.text+\";\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "return "+((ID91 != null) ? ID91.Text : null)+";"));
                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:595:11: 'return' ARRAY
                    {
                    	Match(input,51,FOLLOW_51_in_return_statement3141); 
                    	ARRAY92=(IToken)Match(input,ARRAY,FOLLOW_ARRAY_in_return_statement3143); 


                    	// TEMPLATE REWRITE
                    	// 595:27: -> type(name=\"return \"+$ARRAY.text+\";\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "return "+((ARRAY92 != null) ? ARRAY92.Text : null)+";"));
                    	}


                    }
                    break;
                case 4 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:596:11: 'return'
                    {
                    	Match(input,51,FOLLOW_51_in_return_statement3165); 


                    	// TEMPLATE REWRITE
                    	// 596:21: -> type(name=\"return;\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "return;"));
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
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:598:1: while_statement : ( 'while' '(' expr ')' block -> whileLoop(e1=$expr.stlocals=$slist::localsstats=$slist::stats) | 'do' block 'while' '(' expr ')' -> whileLoop(e1=$expr.stlocals=$slist::localsstats=$slist::stats));
    public C2CUDATranslatorParser.while_statement_return while_statement() // throws RecognitionException [1]
    {   
        slist_stack.Push(new slist_scope());

        C2CUDATranslatorParser.while_statement_return retval = new C2CUDATranslatorParser.while_statement_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.expr_return expr93 = default(C2CUDATranslatorParser.expr_return);

        C2CUDATranslatorParser.expr_return expr94 = default(C2CUDATranslatorParser.expr_return);



          ((slist_scope)slist_stack.Peek()).locals =  new ArrayList();
          ((slist_scope)slist_stack.Peek()).stats =  new ArrayList();

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:604:2: ( 'while' '(' expr ')' block -> whileLoop(e1=$expr.stlocals=$slist::localsstats=$slist::stats) | 'do' block 'while' '(' expr ')' -> whileLoop(e1=$expr.stlocals=$slist::localsstats=$slist::stats))
            int alt47 = 2;
            int LA47_0 = input.LA(1);

            if ( (LA47_0 == 52) )
            {
                alt47 = 1;
            }
            else if ( (LA47_0 == 53) )
            {
                alt47 = 2;
            }
            else 
            {
                NoViableAltException nvae_d47s0 =
                    new NoViableAltException("", 47, 0, input);

                throw nvae_d47s0;
            }
            switch (alt47) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:604:4: 'while' '(' expr ')' block
                    {
                    	Match(input,52,FOLLOW_52_in_while_statement3195); 
                    	Match(input,21,FOLLOW_21_in_while_statement3197); 
                    	PushFollow(FOLLOW_expr_in_while_statement3199);
                    	expr93 = expr();
                    	state.followingStackPointer--;

                    	Match(input,27,FOLLOW_27_in_while_statement3201); 
                    	PushFollow(FOLLOW_block_in_while_statement3203);
                    	block();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 605:4: -> whileLoop(e1=$expr.stlocals=$slist::localsstats=$slist::stats)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("whileLoop",
                    	  new STAttrMap().Add("e1", ((expr93 != null) ? expr93.ST : null)).Add("locals", ((slist_scope)slist_stack.Peek()).locals).Add("stats", ((slist_scope)slist_stack.Peek()).stats));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:607:11: 'do' block 'while' '(' expr ')'
                    {
                    	Match(input,53,FOLLOW_53_in_while_statement3256); 
                    	PushFollow(FOLLOW_block_in_while_statement3258);
                    	block();
                    	state.followingStackPointer--;

                    	Match(input,52,FOLLOW_52_in_while_statement3260); 
                    	Match(input,21,FOLLOW_21_in_while_statement3262); 
                    	PushFollow(FOLLOW_expr_in_while_statement3264);
                    	expr94 = expr();
                    	state.followingStackPointer--;

                    	Match(input,27,FOLLOW_27_in_while_statement3266); 


                    	// TEMPLATE REWRITE
                    	// 608:4: -> whileLoop(e1=$expr.stlocals=$slist::localsstats=$slist::stats)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("whileLoop",
                    	  new STAttrMap().Add("e1", ((expr94 != null) ? expr94.ST : null)).Add("locals", ((slist_scope)slist_stack.Peek()).locals).Add("stats", ((slist_scope)slist_stack.Peek()).stats));
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
    // $ANTLR end "while_statement"

    public class selection_statement_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "selection_statement"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:611:1: selection_statement : ( 'if' '(' condExpr ')' stat -> type(name=\"if (\"+$condExpr.st+\")\" +$stat.st) | 'else' stat -> type(name=\"else \" +$stat.st) | 'switch' '(' expr ')' stat -> type(name=\"switch (\"+$expr.st+\")\" +$stat.st));
    public C2CUDATranslatorParser.selection_statement_return selection_statement() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.selection_statement_return retval = new C2CUDATranslatorParser.selection_statement_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.condExpr_return condExpr95 = default(C2CUDATranslatorParser.condExpr_return);

        C2CUDATranslatorParser.stat_return stat96 = default(C2CUDATranslatorParser.stat_return);

        C2CUDATranslatorParser.stat_return stat97 = default(C2CUDATranslatorParser.stat_return);

        C2CUDATranslatorParser.expr_return expr98 = default(C2CUDATranslatorParser.expr_return);

        C2CUDATranslatorParser.stat_return stat99 = default(C2CUDATranslatorParser.stat_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:613:2: ( 'if' '(' condExpr ')' stat -> type(name=\"if (\"+$condExpr.st+\")\" +$stat.st) | 'else' stat -> type(name=\"else \" +$stat.st) | 'switch' '(' expr ')' stat -> type(name=\"switch (\"+$expr.st+\")\" +$stat.st))
            int alt48 = 3;
            switch ( input.LA(1) ) 
            {
            case 54:
            	{
                alt48 = 1;
                }
                break;
            case 55:
            	{
                alt48 = 2;
                }
                break;
            case 56:
            	{
                alt48 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d48s0 =
            	        new NoViableAltException("", 48, 0, input);

            	    throw nvae_d48s0;
            }

            switch (alt48) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:613:4: 'if' '(' condExpr ')' stat
                    {
                    	Match(input,54,FOLLOW_54_in_selection_statement3318); 
                    	Match(input,21,FOLLOW_21_in_selection_statement3320); 
                    	PushFollow(FOLLOW_condExpr_in_selection_statement3322);
                    	condExpr95 = condExpr();
                    	state.followingStackPointer--;

                    	Match(input,27,FOLLOW_27_in_selection_statement3324); 
                    	PushFollow(FOLLOW_stat_in_selection_statement3326);
                    	stat96 = stat();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 614:2: -> type(name=\"if (\"+$condExpr.st+\")\" +$stat.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "if ("+((condExpr95 != null) ? condExpr95.ST : null)+")" +((stat96 != null) ? stat96.ST : null)));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:615:4: 'else' stat
                    {
                    	Match(input,55,FOLLOW_55_in_selection_statement3342); 
                    	PushFollow(FOLLOW_stat_in_selection_statement3344);
                    	stat97 = stat();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 615:16: -> type(name=\"else \" +$stat.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "else " +((stat97 != null) ? stat97.ST : null)));
                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:616:4: 'switch' '(' expr ')' stat
                    {
                    	Match(input,56,FOLLOW_56_in_selection_statement3358); 
                    	Match(input,21,FOLLOW_21_in_selection_statement3360); 
                    	PushFollow(FOLLOW_expr_in_selection_statement3362);
                    	expr98 = expr();
                    	state.followingStackPointer--;

                    	Match(input,27,FOLLOW_27_in_selection_statement3364); 
                    	PushFollow(FOLLOW_stat_in_selection_statement3366);
                    	stat99 = stat();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 616:31: -> type(name=\"switch (\"+$expr.st+\")\" +$stat.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "switch ("+((expr98 != null) ? expr98.ST : null)+")" +((stat99 != null) ? stat99.ST : null)));
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
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:629:1: expression_statement : ( ';' -> type(name=\";\") | expr ';' -> type(name=$expr.st));
    public C2CUDATranslatorParser.expression_statement_return expression_statement() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.expression_statement_return retval = new C2CUDATranslatorParser.expression_statement_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.expr_return expr100 = default(C2CUDATranslatorParser.expr_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:631:2: ( ';' -> type(name=\";\") | expr ';' -> type(name=$expr.st))
            int alt49 = 2;
            int LA49_0 = input.LA(1);

            if ( (LA49_0 == 19) )
            {
                alt49 = 1;
            }
            else if ( ((LA49_0 >= ID && LA49_0 <= INT) || (LA49_0 >= ARRAY && LA49_0 <= RWORD) || LA49_0 == CHARACTER_LITERAL || LA49_0 == 21 || LA49_0 == 68) )
            {
                alt49 = 2;
            }
            else 
            {
                NoViableAltException nvae_d49s0 =
                    new NoViableAltException("", 49, 0, input);

                throw nvae_d49s0;
            }
            switch (alt49) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:631:4: ';'
                    {
                    	Match(input,19,FOLLOW_19_in_expression_statement3399); 


                    	// TEMPLATE REWRITE
                    	// 631:8: -> type(name=\";\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", ";"));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:633:4: expr ';'
                    {
                    	PushFollow(FOLLOW_expr_in_expression_statement3414);
                    	expr100 = expr();
                    	state.followingStackPointer--;

                    	Match(input,19,FOLLOW_19_in_expression_statement3416); 


                    	// TEMPLATE REWRITE
                    	// 633:13: -> type(name=$expr.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", ((expr100 != null) ? expr100.ST : null)));
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
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:636:1: incStat : ( ID '++' -> type(name=$ID.text + \"++\") | ID '--' -> type(name=$ID.text + \"--\") | '++' ID -> type(name=\"++\"+$ID.text) | '--' ID -> type(name=\"--\"+$ID.text) | ID '+=' INT -> type(name=$ID.text + \"+=\" + $INT.text) | ID '-=' INT -> type(name=$ID.text + \"-=\" + $INT.text) | ID '*=' INT -> type(name=$ID.text + \"*=\" + $INT.text));
    public C2CUDATranslatorParser.incStat_return incStat() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.incStat_return retval = new C2CUDATranslatorParser.incStat_return();
        retval.Start = input.LT(1);

        IToken ID101 = null;
        IToken ID102 = null;
        IToken ID103 = null;
        IToken ID104 = null;
        IToken ID105 = null;
        IToken INT106 = null;
        IToken ID107 = null;
        IToken INT108 = null;
        IToken ID109 = null;
        IToken INT110 = null;

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:637:2: ( ID '++' -> type(name=$ID.text + \"++\") | ID '--' -> type(name=$ID.text + \"--\") | '++' ID -> type(name=\"++\"+$ID.text) | '--' ID -> type(name=\"--\"+$ID.text) | ID '+=' INT -> type(name=$ID.text + \"+=\" + $INT.text) | ID '-=' INT -> type(name=$ID.text + \"-=\" + $INT.text) | ID '*=' INT -> type(name=$ID.text + \"*=\" + $INT.text))
            int alt50 = 7;
            switch ( input.LA(1) ) 
            {
            case ID:
            	{
                switch ( input.LA(2) ) 
                {
                case 57:
                	{
                    alt50 = 1;
                    }
                    break;
                case 58:
                	{
                    alt50 = 2;
                    }
                    break;
                case 47:
                	{
                    alt50 = 5;
                    }
                    break;
                case 46:
                	{
                    alt50 = 6;
                    }
                    break;
                case 59:
                	{
                    alt50 = 7;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d50s1 =
                	        new NoViableAltException("", 50, 1, input);

                	    throw nvae_d50s1;
                }

                }
                break;
            case 57:
            	{
                alt50 = 3;
                }
                break;
            case 58:
            	{
                alt50 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d50s0 =
            	        new NoViableAltException("", 50, 0, input);

            	    throw nvae_d50s0;
            }

            switch (alt50) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:637:6: ID '++'
                    {
                    	ID101=(IToken)Match(input,ID,FOLLOW_ID_in_incStat3438); 
                    	Match(input,57,FOLLOW_57_in_incStat3440); 


                    	// TEMPLATE REWRITE
                    	// 637:15: -> type(name=$ID.text + \"++\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", ((ID101 != null) ? ID101.Text : null) + "++"));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:638:6: ID '--'
                    {
                    	ID102=(IToken)Match(input,ID,FOLLOW_ID_in_incStat3457); 
                    	Match(input,58,FOLLOW_58_in_incStat3459); 


                    	// TEMPLATE REWRITE
                    	// 638:16: -> type(name=$ID.text + \"--\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", ((ID102 != null) ? ID102.Text : null) + "--"));
                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:639:6: '++' ID
                    {
                    	Match(input,57,FOLLOW_57_in_incStat3477); 
                    	ID103=(IToken)Match(input,ID,FOLLOW_ID_in_incStat3479); 


                    	// TEMPLATE REWRITE
                    	// 639:16: -> type(name=\"++\"+$ID.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "++"+((ID103 != null) ? ID103.Text : null)));
                    	}


                    }
                    break;
                case 4 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:640:7: '--' ID
                    {
                    	Match(input,58,FOLLOW_58_in_incStat3498); 
                    	ID104=(IToken)Match(input,ID,FOLLOW_ID_in_incStat3500); 


                    	// TEMPLATE REWRITE
                    	// 640:15: -> type(name=\"--\"+$ID.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "--"+((ID104 != null) ? ID104.Text : null)));
                    	}


                    }
                    break;
                case 5 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:641:7: ID '+=' INT
                    {
                    	ID105=(IToken)Match(input,ID,FOLLOW_ID_in_incStat3517); 
                    	Match(input,47,FOLLOW_47_in_incStat3519); 
                    	INT106=(IToken)Match(input,INT,FOLLOW_INT_in_incStat3521); 


                    	// TEMPLATE REWRITE
                    	// 641:19: -> type(name=$ID.text + \"+=\" + $INT.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", ((ID105 != null) ? ID105.Text : null) + "+=" + ((INT106 != null) ? INT106.Text : null)));
                    	}


                    }
                    break;
                case 6 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:642:6: ID '-=' INT
                    {
                    	ID107=(IToken)Match(input,ID,FOLLOW_ID_in_incStat3537); 
                    	Match(input,46,FOLLOW_46_in_incStat3539); 
                    	INT108=(IToken)Match(input,INT,FOLLOW_INT_in_incStat3541); 


                    	// TEMPLATE REWRITE
                    	// 642:18: -> type(name=$ID.text + \"-=\" + $INT.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", ((ID107 != null) ? ID107.Text : null) + "-=" + ((INT108 != null) ? INT108.Text : null)));
                    	}


                    }
                    break;
                case 7 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:643:6: ID '*=' INT
                    {
                    	ID109=(IToken)Match(input,ID,FOLLOW_ID_in_incStat3557); 
                    	Match(input,59,FOLLOW_59_in_incStat3559); 
                    	INT110=(IToken)Match(input,INT,FOLLOW_INT_in_incStat3561); 


                    	// TEMPLATE REWRITE
                    	// 643:18: -> type(name=$ID.text + \"*=\" + $INT.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", ((ID109 != null) ? ID109.Text : null) + "*=" + ((INT110 != null) ? INT110.Text : null)));
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
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:646:1: expr : condExpr -> {$condExpr.st};
    public C2CUDATranslatorParser.expr_return expr() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.expr_return retval = new C2CUDATranslatorParser.expr_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.condExpr_return condExpr111 = default(C2CUDATranslatorParser.condExpr_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:646:5: ( condExpr -> {$condExpr.st})
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:647:3: condExpr
            {
            	PushFollow(FOLLOW_condExpr_in_expr3588);
            	condExpr111 = condExpr();
            	state.followingStackPointer--;



            	// TEMPLATE REWRITE
            	// 647:12: -> {$condExpr.st}
            	{
            	    retval.ST = ((condExpr111 != null) ? condExpr111.ST : null);
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
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:663:1: condExpr : a= aexpr ( ( '==' b= aexpr -> equals(left=$a.stright=$b.st) | '!=' b= aexpr -> notequals(left=$a.stright=$b.st) | '<' b= aexpr -> lessThan(left=$a.stright=$b.st) | '>' b= aexpr -> GreaterThan(left=$a.stright=$b.st) | '<=' b= aexpr -> lessThanEq(left=$a.stright=$b.st) | '>=' b= aexpr -> GreaterThanEq(left=$a.stright=$b.st) | '&&' b= aexpr -> CAND(left=$a.stright=$b.st) | '||' b= aexpr -> COR(left=$a.stright=$b.st)) | -> {$a.st} | '(' condExpr ')' ) ;
    public C2CUDATranslatorParser.condExpr_return condExpr() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.condExpr_return retval = new C2CUDATranslatorParser.condExpr_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.aexpr_return a = default(C2CUDATranslatorParser.aexpr_return);

        C2CUDATranslatorParser.aexpr_return b = default(C2CUDATranslatorParser.aexpr_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:664:5: (a= aexpr ( ( '==' b= aexpr -> equals(left=$a.stright=$b.st) | '!=' b= aexpr -> notequals(left=$a.stright=$b.st) | '<' b= aexpr -> lessThan(left=$a.stright=$b.st) | '>' b= aexpr -> GreaterThan(left=$a.stright=$b.st) | '<=' b= aexpr -> lessThanEq(left=$a.stright=$b.st) | '>=' b= aexpr -> GreaterThanEq(left=$a.stright=$b.st) | '&&' b= aexpr -> CAND(left=$a.stright=$b.st) | '||' b= aexpr -> COR(left=$a.stright=$b.st)) | -> {$a.st} | '(' condExpr ')' ) )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:664:9: a= aexpr ( ( '==' b= aexpr -> equals(left=$a.stright=$b.st) | '!=' b= aexpr -> notequals(left=$a.stright=$b.st) | '<' b= aexpr -> lessThan(left=$a.stright=$b.st) | '>' b= aexpr -> GreaterThan(left=$a.stright=$b.st) | '<=' b= aexpr -> lessThanEq(left=$a.stright=$b.st) | '>=' b= aexpr -> GreaterThanEq(left=$a.stright=$b.st) | '&&' b= aexpr -> CAND(left=$a.stright=$b.st) | '||' b= aexpr -> COR(left=$a.stright=$b.st)) | -> {$a.st} | '(' condExpr ')' )
            {
            	PushFollow(FOLLOW_aexpr_in_condExpr3637);
            	a = aexpr();
            	state.followingStackPointer--;

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:665:9: ( ( '==' b= aexpr -> equals(left=$a.stright=$b.st) | '!=' b= aexpr -> notequals(left=$a.stright=$b.st) | '<' b= aexpr -> lessThan(left=$a.stright=$b.st) | '>' b= aexpr -> GreaterThan(left=$a.stright=$b.st) | '<=' b= aexpr -> lessThanEq(left=$a.stright=$b.st) | '>=' b= aexpr -> GreaterThanEq(left=$a.stright=$b.st) | '&&' b= aexpr -> CAND(left=$a.stright=$b.st) | '||' b= aexpr -> COR(left=$a.stright=$b.st)) | -> {$a.st} | '(' condExpr ')' )
            	int alt52 = 3;
            	switch ( input.LA(1) ) 
            	{
            	case 60:
            	case 61:
            	case 62:
            	case 63:
            	case 64:
            	case 65:
            	case 66:
            	case 67:
            		{
            	    alt52 = 1;
            	    }
            	    break;
            	case 19:
            	case 27:
            	case 69:
            		{
            	    alt52 = 2;
            	    }
            	    break;
            	case 21:
            		{
            	    alt52 = 3;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d52s0 =
            		        new NoViableAltException("", 52, 0, input);

            		    throw nvae_d52s0;
            	}

            	switch (alt52) 
            	{
            	    case 1 :
            	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:665:13: ( '==' b= aexpr -> equals(left=$a.stright=$b.st) | '!=' b= aexpr -> notequals(left=$a.stright=$b.st) | '<' b= aexpr -> lessThan(left=$a.stright=$b.st) | '>' b= aexpr -> GreaterThan(left=$a.stright=$b.st) | '<=' b= aexpr -> lessThanEq(left=$a.stright=$b.st) | '>=' b= aexpr -> GreaterThanEq(left=$a.stright=$b.st) | '&&' b= aexpr -> CAND(left=$a.stright=$b.st) | '||' b= aexpr -> COR(left=$a.stright=$b.st))
            	        {
            	        	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:665:13: ( '==' b= aexpr -> equals(left=$a.stright=$b.st) | '!=' b= aexpr -> notequals(left=$a.stright=$b.st) | '<' b= aexpr -> lessThan(left=$a.stright=$b.st) | '>' b= aexpr -> GreaterThan(left=$a.stright=$b.st) | '<=' b= aexpr -> lessThanEq(left=$a.stright=$b.st) | '>=' b= aexpr -> GreaterThanEq(left=$a.stright=$b.st) | '&&' b= aexpr -> CAND(left=$a.stright=$b.st) | '||' b= aexpr -> COR(left=$a.stright=$b.st))
            	        	int alt51 = 8;
            	        	switch ( input.LA(1) ) 
            	        	{
            	        	case 60:
            	        		{
            	        	    alt51 = 1;
            	        	    }
            	        	    break;
            	        	case 61:
            	        		{
            	        	    alt51 = 2;
            	        	    }
            	        	    break;
            	        	case 62:
            	        		{
            	        	    alt51 = 3;
            	        	    }
            	        	    break;
            	        	case 63:
            	        		{
            	        	    alt51 = 4;
            	        	    }
            	        	    break;
            	        	case 64:
            	        		{
            	        	    alt51 = 5;
            	        	    }
            	        	    break;
            	        	case 65:
            	        		{
            	        	    alt51 = 6;
            	        	    }
            	        	    break;
            	        	case 66:
            	        		{
            	        	    alt51 = 7;
            	        	    }
            	        	    break;
            	        	case 67:
            	        		{
            	        	    alt51 = 8;
            	        	    }
            	        	    break;
            	        		default:
            	        		    NoViableAltException nvae_d51s0 =
            	        		        new NoViableAltException("", 51, 0, input);

            	        		    throw nvae_d51s0;
            	        	}

            	        	switch (alt51) 
            	        	{
            	        	    case 1 :
            	        	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:665:16: '==' b= aexpr
            	        	        {
            	        	        	Match(input,60,FOLLOW_60_in_condExpr3654); 
            	        	        	PushFollow(FOLLOW_aexpr_in_condExpr3658);
            	        	        	b = aexpr();
            	        	        	state.followingStackPointer--;



            	        	        	// TEMPLATE REWRITE
            	        	        	// 665:29: -> equals(left=$a.stright=$b.st)
            	        	        	{
            	        	        	    retval.ST = templateLib.GetInstanceOf("equals",
            	        	        	  new STAttrMap().Add("left", ((a != null) ? a.ST : null)).Add("right", ((b != null) ? b.ST : null)));
            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:666:16: '!=' b= aexpr
            	        	        {
            	        	        	Match(input,61,FOLLOW_61_in_condExpr3688); 
            	        	        	PushFollow(FOLLOW_aexpr_in_condExpr3692);
            	        	        	b = aexpr();
            	        	        	state.followingStackPointer--;



            	        	        	// TEMPLATE REWRITE
            	        	        	// 666:29: -> notequals(left=$a.stright=$b.st)
            	        	        	{
            	        	        	    retval.ST = templateLib.GetInstanceOf("notequals",
            	        	        	  new STAttrMap().Add("left", ((a != null) ? a.ST : null)).Add("right", ((b != null) ? b.ST : null)));
            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 3 :
            	        	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:667:16: '<' b= aexpr
            	        	        {
            	        	        	Match(input,62,FOLLOW_62_in_condExpr3722); 
            	        	        	PushFollow(FOLLOW_aexpr_in_condExpr3726);
            	        	        	b = aexpr();
            	        	        	state.followingStackPointer--;



            	        	        	// TEMPLATE REWRITE
            	        	        	// 667:30: -> lessThan(left=$a.stright=$b.st)
            	        	        	{
            	        	        	    retval.ST = templateLib.GetInstanceOf("lessThan",
            	        	        	  new STAttrMap().Add("left", ((a != null) ? a.ST : null)).Add("right", ((b != null) ? b.ST : null)));
            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 4 :
            	        	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:668:16: '>' b= aexpr
            	        	        {
            	        	        	Match(input,63,FOLLOW_63_in_condExpr3758); 
            	        	        	PushFollow(FOLLOW_aexpr_in_condExpr3762);
            	        	        	b = aexpr();
            	        	        	state.followingStackPointer--;



            	        	        	// TEMPLATE REWRITE
            	        	        	// 668:30: -> GreaterThan(left=$a.stright=$b.st)
            	        	        	{
            	        	        	    retval.ST = templateLib.GetInstanceOf("GreaterThan",
            	        	        	  new STAttrMap().Add("left", ((a != null) ? a.ST : null)).Add("right", ((b != null) ? b.ST : null)));
            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 5 :
            	        	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:669:16: '<=' b= aexpr
            	        	        {
            	        	        	Match(input,64,FOLLOW_64_in_condExpr3794); 
            	        	        	PushFollow(FOLLOW_aexpr_in_condExpr3798);
            	        	        	b = aexpr();
            	        	        	state.followingStackPointer--;



            	        	        	// TEMPLATE REWRITE
            	        	        	// 669:31: -> lessThanEq(left=$a.stright=$b.st)
            	        	        	{
            	        	        	    retval.ST = templateLib.GetInstanceOf("lessThanEq",
            	        	        	  new STAttrMap().Add("left", ((a != null) ? a.ST : null)).Add("right", ((b != null) ? b.ST : null)));
            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 6 :
            	        	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:670:16: '>=' b= aexpr
            	        	        {
            	        	        	Match(input,65,FOLLOW_65_in_condExpr3830); 
            	        	        	PushFollow(FOLLOW_aexpr_in_condExpr3834);
            	        	        	b = aexpr();
            	        	        	state.followingStackPointer--;



            	        	        	// TEMPLATE REWRITE
            	        	        	// 670:31: -> GreaterThanEq(left=$a.stright=$b.st)
            	        	        	{
            	        	        	    retval.ST = templateLib.GetInstanceOf("GreaterThanEq",
            	        	        	  new STAttrMap().Add("left", ((a != null) ? a.ST : null)).Add("right", ((b != null) ? b.ST : null)));
            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 7 :
            	        	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:671:16: '&&' b= aexpr
            	        	        {
            	        	        	Match(input,66,FOLLOW_66_in_condExpr3866); 
            	        	        	PushFollow(FOLLOW_aexpr_in_condExpr3870);
            	        	        	b = aexpr();
            	        	        	state.followingStackPointer--;



            	        	        	// TEMPLATE REWRITE
            	        	        	// 671:31: -> CAND(left=$a.stright=$b.st)
            	        	        	{
            	        	        	    retval.ST = templateLib.GetInstanceOf("CAND",
            	        	        	  new STAttrMap().Add("left", ((a != null) ? a.ST : null)).Add("right", ((b != null) ? b.ST : null)));
            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 8 :
            	        	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:672:16: '||' b= aexpr
            	        	        {
            	        	        	Match(input,67,FOLLOW_67_in_condExpr3902); 
            	        	        	PushFollow(FOLLOW_aexpr_in_condExpr3906);
            	        	        	b = aexpr();
            	        	        	state.followingStackPointer--;



            	        	        	// TEMPLATE REWRITE
            	        	        	// 672:31: -> COR(left=$a.stright=$b.st)
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
            	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:675:13: 
            	        {

            	        	// TEMPLATE REWRITE
            	        	// 675:13: -> {$a.st}
            	        	{
            	        	    retval.ST = ((a != null) ? a.ST : null);
            	        	}


            	        }
            	        break;
            	    case 3 :
            	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:677:11: '(' condExpr ')'
            	        {
            	        	Match(input,21,FOLLOW_21_in_condExpr3986); 
            	        	PushFollow(FOLLOW_condExpr_in_condExpr3988);
            	        	condExpr();
            	        	state.followingStackPointer--;

            	        	Match(input,27,FOLLOW_27_in_condExpr3991); 

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
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:683:1: aexpr : (a= atom -> {$a.st}) ( '+' b= atom -> add(left=$aexpr.stright=$b.st))* ( '-' b= atom -> Sub(left=$aexpr.stright=$b.st))* ( '/' b= atom -> Div(left=$aexpr.stright=$b.st))* ( '*' b= atom -> Mul(left=$aexpr.stright=$b.st))* ( '%' b= atom -> Mod(left=$aexpr.stright=$b.st))* ;
    public C2CUDATranslatorParser.aexpr_return aexpr() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.aexpr_return retval = new C2CUDATranslatorParser.aexpr_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.atom_return a = default(C2CUDATranslatorParser.atom_return);

        C2CUDATranslatorParser.atom_return b = default(C2CUDATranslatorParser.atom_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:684:5: ( (a= atom -> {$a.st}) ( '+' b= atom -> add(left=$aexpr.stright=$b.st))* ( '-' b= atom -> Sub(left=$aexpr.stright=$b.st))* ( '/' b= atom -> Div(left=$aexpr.stright=$b.st))* ( '*' b= atom -> Mul(left=$aexpr.stright=$b.st))* ( '%' b= atom -> Mod(left=$aexpr.stright=$b.st))* )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:684:9: (a= atom -> {$a.st}) ( '+' b= atom -> add(left=$aexpr.stright=$b.st))* ( '-' b= atom -> Sub(left=$aexpr.stright=$b.st))* ( '/' b= atom -> Div(left=$aexpr.stright=$b.st))* ( '*' b= atom -> Mul(left=$aexpr.stright=$b.st))* ( '%' b= atom -> Mod(left=$aexpr.stright=$b.st))*
            {
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:684:9: (a= atom -> {$a.st})
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:684:10: a= atom
            	{
            		PushFollow(FOLLOW_atom_in_aexpr4035);
            		a = atom();
            		state.followingStackPointer--;



            		// TEMPLATE REWRITE
            		// 684:17: -> {$a.st}
            		{
            		    retval.ST = ((a != null) ? a.ST : null);
            		}


            	}

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:685:9: ( '+' b= atom -> add(left=$aexpr.stright=$b.st))*
            	do 
            	{
            	    int alt53 = 2;
            	    int LA53_0 = input.LA(1);

            	    if ( (LA53_0 == 32) )
            	    {
            	        alt53 = 1;
            	    }


            	    switch (alt53) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:685:11: '+' b= atom
            			    {
            			    	Match(input,32,FOLLOW_32_in_aexpr4052); 
            			    	PushFollow(FOLLOW_atom_in_aexpr4056);
            			    	b = atom();
            			    	state.followingStackPointer--;



            			    	// TEMPLATE REWRITE
            			    	// 685:22: -> add(left=$aexpr.stright=$b.st)
            			    	{
            			    	    retval.ST = templateLib.GetInstanceOf("add",
            			    	  new STAttrMap().Add("left", retval.ST).Add("right", ((b != null) ? b.ST : null)));
            			    	}


            			    }
            			    break;

            			default:
            			    goto loop53;
            	    }
            	} while (true);

            	loop53:
            		;	// Stops C# compiler whining that label 'loop53' has no statements

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:686:9: ( '-' b= atom -> Sub(left=$aexpr.stright=$b.st))*
            	do 
            	{
            	    int alt54 = 2;
            	    int LA54_0 = input.LA(1);

            	    if ( (LA54_0 == 33) )
            	    {
            	        alt54 = 1;
            	    }


            	    switch (alt54) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:686:11: '-' b= atom
            			    {
            			    	Match(input,33,FOLLOW_33_in_aexpr4085); 
            			    	PushFollow(FOLLOW_atom_in_aexpr4089);
            			    	b = atom();
            			    	state.followingStackPointer--;



            			    	// TEMPLATE REWRITE
            			    	// 686:22: -> Sub(left=$aexpr.stright=$b.st)
            			    	{
            			    	    retval.ST = templateLib.GetInstanceOf("Sub",
            			    	  new STAttrMap().Add("left", retval.ST).Add("right", ((b != null) ? b.ST : null)));
            			    	}


            			    }
            			    break;

            			default:
            			    goto loop54;
            	    }
            	} while (true);

            	loop54:
            		;	// Stops C# compiler whining that label 'loop54' has no statements

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:687:9: ( '/' b= atom -> Div(left=$aexpr.stright=$b.st))*
            	do 
            	{
            	    int alt55 = 2;
            	    int LA55_0 = input.LA(1);

            	    if ( (LA55_0 == 34) )
            	    {
            	        alt55 = 1;
            	    }


            	    switch (alt55) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:687:11: '/' b= atom
            			    {
            			    	Match(input,34,FOLLOW_34_in_aexpr4118); 
            			    	PushFollow(FOLLOW_atom_in_aexpr4122);
            			    	b = atom();
            			    	state.followingStackPointer--;



            			    	// TEMPLATE REWRITE
            			    	// 687:22: -> Div(left=$aexpr.stright=$b.st)
            			    	{
            			    	    retval.ST = templateLib.GetInstanceOf("Div",
            			    	  new STAttrMap().Add("left", retval.ST).Add("right", ((b != null) ? b.ST : null)));
            			    	}


            			    }
            			    break;

            			default:
            			    goto loop55;
            	    }
            	} while (true);

            	loop55:
            		;	// Stops C# compiler whining that label 'loop55' has no statements

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:688:9: ( '*' b= atom -> Mul(left=$aexpr.stright=$b.st))*
            	do 
            	{
            	    int alt56 = 2;
            	    int LA56_0 = input.LA(1);

            	    if ( (LA56_0 == 24) )
            	    {
            	        alt56 = 1;
            	    }


            	    switch (alt56) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:688:11: '*' b= atom
            			    {
            			    	Match(input,24,FOLLOW_24_in_aexpr4151); 
            			    	PushFollow(FOLLOW_atom_in_aexpr4155);
            			    	b = atom();
            			    	state.followingStackPointer--;



            			    	// TEMPLATE REWRITE
            			    	// 688:22: -> Mul(left=$aexpr.stright=$b.st)
            			    	{
            			    	    retval.ST = templateLib.GetInstanceOf("Mul",
            			    	  new STAttrMap().Add("left", retval.ST).Add("right", ((b != null) ? b.ST : null)));
            			    	}


            			    }
            			    break;

            			default:
            			    goto loop56;
            	    }
            	} while (true);

            	loop56:
            		;	// Stops C# compiler whining that label 'loop56' has no statements

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:689:9: ( '%' b= atom -> Mod(left=$aexpr.stright=$b.st))*
            	do 
            	{
            	    int alt57 = 2;
            	    int LA57_0 = input.LA(1);

            	    if ( (LA57_0 == 35) )
            	    {
            	        alt57 = 1;
            	    }


            	    switch (alt57) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:689:11: '%' b= atom
            			    {
            			    	Match(input,35,FOLLOW_35_in_aexpr4184); 
            			    	PushFollow(FOLLOW_atom_in_aexpr4188);
            			    	b = atom();
            			    	state.followingStackPointer--;



            			    	// TEMPLATE REWRITE
            			    	// 689:22: -> Mod(left=$aexpr.stright=$b.st)
            			    	{
            			    	    retval.ST = templateLib.GetInstanceOf("Mod",
            			    	  new STAttrMap().Add("left", retval.ST).Add("right", ((b != null) ? b.ST : null)));
            			    	}


            			    }
            			    break;

            			default:
            			    goto loop57;
            	    }
            	} while (true);

            	loop57:
            		;	// Stops C# compiler whining that label 'loop57' has no statements


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

    public class atom_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "atom"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:692:1: atom : ( ID -> refVar(id=$ID.text) | ARRAY -> refVar(id=$ARRAY.text) | INT -> iconst(value=$INT.text) | RWORD -> refVar(id=$RWORD.text) | '(' expr ')' -> {$expr.st} | '[' expr ']' -> {$expr.st} | CHARACTER_LITERAL -> refVar(id=$CHARACTER_LITERAL.text));
    public C2CUDATranslatorParser.atom_return atom() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.atom_return retval = new C2CUDATranslatorParser.atom_return();
        retval.Start = input.LT(1);

        IToken ID112 = null;
        IToken ARRAY113 = null;
        IToken INT114 = null;
        IToken RWORD115 = null;
        IToken CHARACTER_LITERAL118 = null;
        C2CUDATranslatorParser.expr_return expr116 = default(C2CUDATranslatorParser.expr_return);

        C2CUDATranslatorParser.expr_return expr117 = default(C2CUDATranslatorParser.expr_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:693:5: ( ID -> refVar(id=$ID.text) | ARRAY -> refVar(id=$ARRAY.text) | INT -> iconst(value=$INT.text) | RWORD -> refVar(id=$RWORD.text) | '(' expr ')' -> {$expr.st} | '[' expr ']' -> {$expr.st} | CHARACTER_LITERAL -> refVar(id=$CHARACTER_LITERAL.text))
            int alt58 = 7;
            switch ( input.LA(1) ) 
            {
            case ID:
            	{
                alt58 = 1;
                }
                break;
            case ARRAY:
            	{
                alt58 = 2;
                }
                break;
            case INT:
            	{
                alt58 = 3;
                }
                break;
            case RWORD:
            	{
                alt58 = 4;
                }
                break;
            case 21:
            	{
                alt58 = 5;
                }
                break;
            case 68:
            	{
                alt58 = 6;
                }
                break;
            case CHARACTER_LITERAL:
            	{
                alt58 = 7;
                }
                break;
            	default:
            	    NoViableAltException nvae_d58s0 =
            	        new NoViableAltException("", 58, 0, input);

            	    throw nvae_d58s0;
            }

            switch (alt58) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:693:7: ID
                    {
                    	ID112=(IToken)Match(input,ID,FOLLOW_ID_in_atom4236); 


                    	// TEMPLATE REWRITE
                    	// 693:11: -> refVar(id=$ID.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("refVar",
                    	  new STAttrMap().Add("id", ((ID112 != null) ? ID112.Text : null)));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:694:7: ARRAY
                    {
                    	ARRAY113=(IToken)Match(input,ARRAY,FOLLOW_ARRAY_in_atom4254); 


                    	// TEMPLATE REWRITE
                    	// 694:13: -> refVar(id=$ARRAY.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("refVar",
                    	  new STAttrMap().Add("id", ((ARRAY113 != null) ? ARRAY113.Text : null)));
                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:695:7: INT
                    {
                    	INT114=(IToken)Match(input,INT,FOLLOW_INT_in_atom4273); 


                    	// TEMPLATE REWRITE
                    	// 695:11: -> iconst(value=$INT.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("iconst",
                    	  new STAttrMap().Add("value", ((INT114 != null) ? INT114.Text : null)));
                    	}


                    }
                    break;
                case 4 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:696:7: RWORD
                    {
                    	RWORD115=(IToken)Match(input,RWORD,FOLLOW_RWORD_in_atom4290); 


                    	// TEMPLATE REWRITE
                    	// 696:13: -> refVar(id=$RWORD.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("refVar",
                    	  new STAttrMap().Add("id", ((RWORD115 != null) ? RWORD115.Text : null)));
                    	}


                    }
                    break;
                case 5 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:697:7: '(' expr ')'
                    {
                    	Match(input,21,FOLLOW_21_in_atom4306); 
                    	PushFollow(FOLLOW_expr_in_atom4308);
                    	expr116 = expr();
                    	state.followingStackPointer--;

                    	Match(input,27,FOLLOW_27_in_atom4310); 


                    	// TEMPLATE REWRITE
                    	// 697:20: -> {$expr.st}
                    	{
                    	    retval.ST = ((expr116 != null) ? expr116.ST : null);
                    	}


                    }
                    break;
                case 6 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:698:7: '[' expr ']'
                    {
                    	Match(input,68,FOLLOW_68_in_atom4323); 
                    	PushFollow(FOLLOW_expr_in_atom4325);
                    	expr117 = expr();
                    	state.followingStackPointer--;

                    	Match(input,69,FOLLOW_69_in_atom4327); 


                    	// TEMPLATE REWRITE
                    	// 698:20: -> {$expr.st}
                    	{
                    	    retval.ST = ((expr117 != null) ? expr117.ST : null);
                    	}


                    }
                    break;
                case 7 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:699:7: CHARACTER_LITERAL
                    {
                    	CHARACTER_LITERAL118=(IToken)Match(input,CHARACTER_LITERAL,FOLLOW_CHARACTER_LITERAL_in_atom4339); 


                    	// TEMPLATE REWRITE
                    	// 699:25: -> refVar(id=$CHARACTER_LITERAL.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("refVar",
                    	  new STAttrMap().Add("id", ((CHARACTER_LITERAL118 != null) ? CHARACTER_LITERAL118.Text : null)));
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

    public class func_call_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "func_call"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:709:5: func_call : ( ID '(' ( (p+= formalParameter ) ( ',' p+= formalParameter )* )? ')' -> type(name=$ID.text+\"(\"+$p+\")\") | ID '()' -> type(name=$ID.text + \"()\"));
    public C2CUDATranslatorParser.func_call_return func_call() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.func_call_return retval = new C2CUDATranslatorParser.func_call_return();
        retval.Start = input.LT(1);

        IToken ID119 = null;
        IToken ID120 = null;
        IList list_p = null;
        C2CUDATranslatorParser.formalParameter_return p = default(C2CUDATranslatorParser.formalParameter_return);
         p = null;
        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:710:1: ( ID '(' ( (p+= formalParameter ) ( ',' p+= formalParameter )* )? ')' -> type(name=$ID.text+\"(\"+$p+\")\") | ID '()' -> type(name=$ID.text + \"()\"))
            int alt61 = 2;
            int LA61_0 = input.LA(1);

            if ( (LA61_0 == ID) )
            {
                int LA61_1 = input.LA(2);

                if ( (LA61_1 == 21) )
                {
                    alt61 = 1;
                }
                else if ( (LA61_1 == 20) )
                {
                    alt61 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d61s1 =
                        new NoViableAltException("", 61, 1, input);

                    throw nvae_d61s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d61s0 =
                    new NoViableAltException("", 61, 0, input);

                throw nvae_d61s0;
            }
            switch (alt61) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:712:3: ID '(' ( (p+= formalParameter ) ( ',' p+= formalParameter )* )? ')'
                    {
                    	ID119=(IToken)Match(input,ID,FOLLOW_ID_in_func_call4399); 
                    	Match(input,21,FOLLOW_21_in_func_call4401); 
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:712:10: ( (p+= formalParameter ) ( ',' p+= formalParameter )* )?
                    	int alt60 = 2;
                    	int LA60_0 = input.LA(1);

                    	if ( ((LA60_0 >= 22 && LA60_0 <= 23) || (LA60_0 >= 36 && LA60_0 <= 43)) )
                    	{
                    	    alt60 = 1;
                    	}
                    	switch (alt60) 
                    	{
                    	    case 1 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:712:12: (p+= formalParameter ) ( ',' p+= formalParameter )*
                    	        {
                    	        	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:712:12: (p+= formalParameter )
                    	        	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:712:13: p+= formalParameter
                    	        	{
                    	        		PushFollow(FOLLOW_formalParameter_in_func_call4408);
                    	        		p = formalParameter();
                    	        		state.followingStackPointer--;

                    	        		if (list_p == null) list_p = new ArrayList();
                    	        		list_p.Add(p.Template);


                    	        	}

                    	        	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:712:33: ( ',' p+= formalParameter )*
                    	        	do 
                    	        	{
                    	        	    int alt59 = 2;
                    	        	    int LA59_0 = input.LA(1);

                    	        	    if ( (LA59_0 == 26) )
                    	        	    {
                    	        	        alt59 = 1;
                    	        	    }


                    	        	    switch (alt59) 
                    	        		{
                    	        			case 1 :
                    	        			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:712:35: ',' p+= formalParameter
                    	        			    {
                    	        			    	Match(input,26,FOLLOW_26_in_func_call4413); 
                    	        			    	PushFollow(FOLLOW_formalParameter_in_func_call4417);
                    	        			    	p = formalParameter();
                    	        			    	state.followingStackPointer--;

                    	        			    	if (list_p == null) list_p = new ArrayList();
                    	        			    	list_p.Add(p.Template);


                    	        			    }
                    	        			    break;

                    	        			default:
                    	        			    goto loop59;
                    	        	    }
                    	        	} while (true);

                    	        	loop59:
                    	        		;	// Stops C# compiler whining that label 'loop59' has no statements


                    	        }
                    	        break;

                    	}

                    	Match(input,27,FOLLOW_27_in_func_call4425); 


                    	// TEMPLATE REWRITE
                    	// 712:68: -> type(name=$ID.text+\"(\"+$p+\")\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", ((ID119 != null) ? ID119.Text : null)+"("+list_p+")"));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:713:5: ID '()'
                    {
                    	ID120=(IToken)Match(input,ID,FOLLOW_ID_in_func_call4439); 
                    	Match(input,20,FOLLOW_20_in_func_call4441); 


                    	// TEMPLATE REWRITE
                    	// 713:13: -> type(name=$ID.text + \"()\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", ((ID120 != null) ? ID120.Text : null) + "()"));
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
    // $ANTLR end "func_call"

    public class func_call2_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "func_call2"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:717:1: func_call2 : ID '(' ( (p+= afexpr ) ( ',' p+= afexpr )* )? ');' -> type(name=$ID.text+\"(\"+$p+\");\");
    public C2CUDATranslatorParser.func_call2_return func_call2() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.func_call2_return retval = new C2CUDATranslatorParser.func_call2_return();
        retval.Start = input.LT(1);

        IToken ID121 = null;
        IList list_p = null;
        C2CUDATranslatorParser.afexpr_return p = default(C2CUDATranslatorParser.afexpr_return);
         p = null;
        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:718:1: ( ID '(' ( (p+= afexpr ) ( ',' p+= afexpr )* )? ');' -> type(name=$ID.text+\"(\"+$p+\");\"))
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:720:3: ID '(' ( (p+= afexpr ) ( ',' p+= afexpr )* )? ');'
            {
            	ID121=(IToken)Match(input,ID,FOLLOW_ID_in_func_call24465); 
            	Match(input,21,FOLLOW_21_in_func_call24467); 
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:720:10: ( (p+= afexpr ) ( ',' p+= afexpr )* )?
            	int alt63 = 2;
            	int LA63_0 = input.LA(1);

            	if ( ((LA63_0 >= ID && LA63_0 <= INT) || LA63_0 == ARRAY) )
            	{
            	    alt63 = 1;
            	}
            	switch (alt63) 
            	{
            	    case 1 :
            	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:720:12: (p+= afexpr ) ( ',' p+= afexpr )*
            	        {
            	        	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:720:12: (p+= afexpr )
            	        	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:720:13: p+= afexpr
            	        	{
            	        		PushFollow(FOLLOW_afexpr_in_func_call24474);
            	        		p = afexpr();
            	        		state.followingStackPointer--;

            	        		if (list_p == null) list_p = new ArrayList();
            	        		list_p.Add(p.Template);


            	        	}

            	        	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:720:24: ( ',' p+= afexpr )*
            	        	do 
            	        	{
            	        	    int alt62 = 2;
            	        	    int LA62_0 = input.LA(1);

            	        	    if ( (LA62_0 == 26) )
            	        	    {
            	        	        alt62 = 1;
            	        	    }


            	        	    switch (alt62) 
            	        		{
            	        			case 1 :
            	        			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:720:26: ',' p+= afexpr
            	        			    {
            	        			    	Match(input,26,FOLLOW_26_in_func_call24479); 
            	        			    	PushFollow(FOLLOW_afexpr_in_func_call24483);
            	        			    	p = afexpr();
            	        			    	state.followingStackPointer--;

            	        			    	if (list_p == null) list_p = new ArrayList();
            	        			    	list_p.Add(p.Template);


            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop62;
            	        	    }
            	        	} while (true);

            	        	loop62:
            	        		;	// Stops C# compiler whining that label 'loop62' has no statements


            	        }
            	        break;

            	}

            	Match(input,30,FOLLOW_30_in_func_call24491); 


            	// TEMPLATE REWRITE
            	// 720:51: -> type(name=$ID.text+\"(\"+$p+\");\")
            	{
            	    retval.ST = templateLib.GetInstanceOf("type",
            	  new STAttrMap().Add("name", ((ID121 != null) ? ID121.Text : null)+"("+list_p+");"));
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
    // $ANTLR end "func_call2"

    public class kfunc_call_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "kfunc_call"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:731:1: kfunc_call : ( ID '(' ( (p+= kakfexpr ) ( ',' p+= kakfexpr )* )? ');' -> type(name=$ID.text+\"(\"+ArraytoString((ArrayList)$p,\",\")+\");\") | 'kernel(' ( (p+= kakfexpr ) ( ',' p+= kakfexpr )* )? ');' -> type(name=\"kernel\"+\"(\"+ArraytoString((ArrayList)$p,\",\")+\");\") | ID '();' );
    public C2CUDATranslatorParser.kfunc_call_return kfunc_call() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.kfunc_call_return retval = new C2CUDATranslatorParser.kfunc_call_return();
        retval.Start = input.LT(1);

        IToken ID122 = null;
        IToken ID123 = null;
        IList list_p = null;
        C2CUDATranslatorParser.kakfexpr_return p = default(C2CUDATranslatorParser.kakfexpr_return);
         p = null;
        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:732:1: ( ID '(' ( (p+= kakfexpr ) ( ',' p+= kakfexpr )* )? ');' -> type(name=$ID.text+\"(\"+ArraytoString((ArrayList)$p,\",\")+\");\") | 'kernel(' ( (p+= kakfexpr ) ( ',' p+= kakfexpr )* )? ');' -> type(name=\"kernel\"+\"(\"+ArraytoString((ArrayList)$p,\",\")+\");\") | ID '();' )
            int alt68 = 3;
            int LA68_0 = input.LA(1);

            if ( (LA68_0 == ID) )
            {
                int LA68_1 = input.LA(2);

                if ( (LA68_1 == 21) )
                {
                    alt68 = 1;
                }
                else if ( (LA68_1 == 71) )
                {
                    alt68 = 3;
                }
                else 
                {
                    NoViableAltException nvae_d68s1 =
                        new NoViableAltException("", 68, 1, input);

                    throw nvae_d68s1;
                }
            }
            else if ( (LA68_0 == 70) )
            {
                alt68 = 2;
            }
            else 
            {
                NoViableAltException nvae_d68s0 =
                    new NoViableAltException("", 68, 0, input);

                throw nvae_d68s0;
            }
            switch (alt68) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:734:3: ID '(' ( (p+= kakfexpr ) ( ',' p+= kakfexpr )* )? ');'
                    {
                    	ID122=(IToken)Match(input,ID,FOLLOW_ID_in_kfunc_call4529); 
                    	Match(input,21,FOLLOW_21_in_kfunc_call4531); 
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:734:10: ( (p+= kakfexpr ) ( ',' p+= kakfexpr )* )?
                    	int alt65 = 2;
                    	int LA65_0 = input.LA(1);

                    	if ( ((LA65_0 >= ID && LA65_0 <= INT) || LA65_0 == ARRAY) )
                    	{
                    	    alt65 = 1;
                    	}
                    	switch (alt65) 
                    	{
                    	    case 1 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:734:12: (p+= kakfexpr ) ( ',' p+= kakfexpr )*
                    	        {
                    	        	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:734:12: (p+= kakfexpr )
                    	        	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:734:13: p+= kakfexpr
                    	        	{
                    	        		PushFollow(FOLLOW_kakfexpr_in_kfunc_call4538);
                    	        		p = kakfexpr();
                    	        		state.followingStackPointer--;

                    	        		if (list_p == null) list_p = new ArrayList();
                    	        		list_p.Add(p.Template);


                    	        	}

                    	        	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:734:26: ( ',' p+= kakfexpr )*
                    	        	do 
                    	        	{
                    	        	    int alt64 = 2;
                    	        	    int LA64_0 = input.LA(1);

                    	        	    if ( (LA64_0 == 26) )
                    	        	    {
                    	        	        alt64 = 1;
                    	        	    }


                    	        	    switch (alt64) 
                    	        		{
                    	        			case 1 :
                    	        			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:734:28: ',' p+= kakfexpr
                    	        			    {
                    	        			    	Match(input,26,FOLLOW_26_in_kfunc_call4543); 
                    	        			    	PushFollow(FOLLOW_kakfexpr_in_kfunc_call4547);
                    	        			    	p = kakfexpr();
                    	        			    	state.followingStackPointer--;

                    	        			    	if (list_p == null) list_p = new ArrayList();
                    	        			    	list_p.Add(p.Template);


                    	        			    }
                    	        			    break;

                    	        			default:
                    	        			    goto loop64;
                    	        	    }
                    	        	} while (true);

                    	        	loop64:
                    	        		;	// Stops C# compiler whining that label 'loop64' has no statements


                    	        }
                    	        break;

                    	}

                    	Match(input,30,FOLLOW_30_in_kfunc_call4555); 

                    		 if(((program_scope)program_stack.Peek()).funclist.Contains(((ID122 != null) ? ID122.Text : null)))
                    		 {
                    		 ((program_scope)program_stack.Peek()).recursionflag = true;
                    		 }
                    		 ((program_scope)program_stack.Peek()).funclist.Add(((ID122 != null) ? ID122.Text : null));


                    	// TEMPLATE REWRITE
                    	// 740:4: -> type(name=$ID.text+\"(\"+ArraytoString((ArrayList)$p,\",\")+\");\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", ((ID122 != null) ? ID122.Text : null)+"("+ArraytoString((ArrayList)list_p,",")+");"));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:742:7: 'kernel(' ( (p+= kakfexpr ) ( ',' p+= kakfexpr )* )? ');'
                    {
                    	Match(input,70,FOLLOW_70_in_kfunc_call4579); 
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:742:17: ( (p+= kakfexpr ) ( ',' p+= kakfexpr )* )?
                    	int alt67 = 2;
                    	int LA67_0 = input.LA(1);

                    	if ( ((LA67_0 >= ID && LA67_0 <= INT) || LA67_0 == ARRAY) )
                    	{
                    	    alt67 = 1;
                    	}
                    	switch (alt67) 
                    	{
                    	    case 1 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:742:19: (p+= kakfexpr ) ( ',' p+= kakfexpr )*
                    	        {
                    	        	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:742:19: (p+= kakfexpr )
                    	        	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:742:20: p+= kakfexpr
                    	        	{
                    	        		PushFollow(FOLLOW_kakfexpr_in_kfunc_call4586);
                    	        		p = kakfexpr();
                    	        		state.followingStackPointer--;

                    	        		if (list_p == null) list_p = new ArrayList();
                    	        		list_p.Add(p.Template);


                    	        	}

                    	        	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:742:33: ( ',' p+= kakfexpr )*
                    	        	do 
                    	        	{
                    	        	    int alt66 = 2;
                    	        	    int LA66_0 = input.LA(1);

                    	        	    if ( (LA66_0 == 26) )
                    	        	    {
                    	        	        alt66 = 1;
                    	        	    }


                    	        	    switch (alt66) 
                    	        		{
                    	        			case 1 :
                    	        			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:742:35: ',' p+= kakfexpr
                    	        			    {
                    	        			    	Match(input,26,FOLLOW_26_in_kfunc_call4591); 
                    	        			    	PushFollow(FOLLOW_kakfexpr_in_kfunc_call4595);
                    	        			    	p = kakfexpr();
                    	        			    	state.followingStackPointer--;

                    	        			    	if (list_p == null) list_p = new ArrayList();
                    	        			    	list_p.Add(p.Template);


                    	        			    }
                    	        			    break;

                    	        			default:
                    	        			    goto loop66;
                    	        	    }
                    	        	} while (true);

                    	        	loop66:
                    	        		;	// Stops C# compiler whining that label 'loop66' has no statements


                    	        }
                    	        break;

                    	}

                    	Match(input,30,FOLLOW_30_in_kfunc_call4603); 


                    		 ((program_scope)program_stack.Peek()).recursionflag = true;
                    		 Boolean d=((program_scope)program_stack.Peek()).recursionflag;
                    		  ((program_scope)program_stack.Peek()).funclist.Add("kernel");


                    	// TEMPLATE REWRITE
                    	// 747:5: -> type(name=\"kernel\"+\"(\"+ArraytoString((ArrayList)$p,\",\")+\");\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "kernel"+"("+ArraytoString((ArrayList)list_p,",")+");"));
                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:748:4: ID '();'
                    {
                    	ID123=(IToken)Match(input,ID,FOLLOW_ID_in_kfunc_call4623); 
                    	Match(input,71,FOLLOW_71_in_kfunc_call4625); 

                    		 if(((program_scope)program_stack.Peek()).funclist.Contains(((ID123 != null) ? ID123.Text : null)))
                    		 {
                    		 ((program_scope)program_stack.Peek()).recursionflag = true;
                    		 }
                    		 ((program_scope)program_stack.Peek()).funclist.Add(((ID123 != null) ? ID123.Text : null));

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
    // $ANTLR end "kfunc_call"

    public class kernel_variable_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "kernel_variable"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:758:1: kernel_variable : 'kernel' type declarator ';' -> {$declarator.st.ToString().Contains(\"=\")}? kernel_variable(type=$type.stname=$declarator.stid=$declarator.st.ToString().Substring(0,$declarator.st.ToString().IndexOf('='))) -> kernel_var(type=$type.stname=$declarator.st);
    public C2CUDATranslatorParser.kernel_variable_return kernel_variable() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.kernel_variable_return retval = new C2CUDATranslatorParser.kernel_variable_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.declarator_return declarator124 = default(C2CUDATranslatorParser.declarator_return);

        C2CUDATranslatorParser.type_return type125 = default(C2CUDATranslatorParser.type_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:759:5: ( 'kernel' type declarator ';' -> {$declarator.st.ToString().Contains(\"=\")}? kernel_variable(type=$type.stname=$declarator.stid=$declarator.st.ToString().Substring(0,$declarator.st.ToString().IndexOf('='))) -> kernel_var(type=$type.stname=$declarator.st))
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:759:9: 'kernel' type declarator ';'
            {
            	Match(input,38,FOLLOW_38_in_kernel_variable4648); 
            	PushFollow(FOLLOW_type_in_kernel_variable4650);
            	type125 = type();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_declarator_in_kernel_variable4652);
            	declarator124 = declarator();
            	state.followingStackPointer--;

            	Match(input,19,FOLLOW_19_in_kernel_variable4654); 
            	if(((declarator124 != null) ? declarator124.ST : null).ToString().Contains("="))
            	    					//{input.LT(1).ToString().Contains("=")}?
            	    					{
            	    					   ((program_scope)program_stack.Peek()).kernelalloc.Add("g_"+((declarator124 != null) ? declarator124.ST : null).ToString().Substring(0,((declarator124 != null) ? declarator124.ST : null).ToString().IndexOf('='))+"= ("+((type125 != null) ? type125.ST : null)+" *)malloc(sizeof("+((type125 != null) ? type125.ST : null)+")); // Allocate variable on host \n cudaMalloc((void **) &g_"+((declarator124 != null) ? declarator124.ST : null).ToString().Substring(0,((declarator124 != null) ? declarator124.ST : null).ToString().IndexOf('='))+",sizeof("+((type125 != null) ? type125.ST : null)+")); // Allocate variable on device");
            	    					   ((program_scope)program_stack.Peek()).kernelvarfree.Add("cudaFree(g_"+((declarator124 != null) ? declarator124.ST : null).ToString().Substring(0,((declarator124 != null) ? declarator124.ST : null).ToString().IndexOf('='))+");");
            						   ((program_scope)program_stack.Peek()).kernelcopyin.Add("cudaMemcpy(g_"+((declarator124 != null) ? declarator124.ST : null).ToString().Substring(0,((declarator124 != null) ? declarator124.ST : null).ToString().IndexOf('='))+", &"+((declarator124 != null) ? declarator124.ST : null).ToString().ToString().Substring(0,((declarator124 != null) ? declarator124.ST : null).ToString().IndexOf('='))+", sizeof("+((type125 != null) ? type125.ST : null)+"), cudaMemcpyHostToDevice);");
            	                                           ((program_scope)program_stack.Peek()).kernelcopyout.Add("cudaMemcpy(&"+((declarator124 != null) ? declarator124.ST : null).ToString().Substring(0,((declarator124 != null) ? declarator124.ST : null).ToString().IndexOf('='))+", g_"+((declarator124 != null) ? declarator124.ST : null).ToString().ToString().Substring(0,((declarator124 != null) ? declarator124.ST : null).ToString().IndexOf('='))+", sizeof("+((type125 != null) ? type125.ST : null)+"), cudaMemcpyDeviceToHost);");
            	                                           ((program_scope)program_stack.Peek()).kernelpar =  ((program_scope)program_stack.Peek()).kernelpar+(", g_"+((declarator124 != null) ? declarator124.ST : null).ToString().Substring(0,((declarator124 != null) ? declarator124.ST : null).ToString().IndexOf('=')));
            	                                           ((program_scope)program_stack.Peek()).kernelpar2 =  ((program_scope)program_stack.Peek()).kernelpar2+(", "+((type125 != null) ? type125.ST : null)+" *gpu_"+((declarator124 != null) ? declarator124.ST : null).ToString().Substring(0,((declarator124 != null) ? declarator124.ST : null).ToString().IndexOf('=')));
            	        				    } 
            	        				 else
            	        				    { 
            	        				   ((program_scope)program_stack.Peek()).kernelalloc.Add("g_"+((declarator124 != null) ? declarator124.ST : null).ToString()+"= ("+((type125 != null) ? type125.ST : null)+" *)malloc(size); // Allocate variable on host \n cudaMalloc((void **) &g_"+((declarator124 != null) ? declarator124.ST : null)+", sizeof("+((type125 != null) ? type125.ST : null)+")); // Allocate variable on device");
            	        				   ((program_scope)program_stack.Peek()).kernelvarfree.Add("cudaFree(g_"+((declarator124 != null) ? declarator124.ST : null)+");");
            						   ((program_scope)program_stack.Peek()).kernelcopyin.Add("cudaMemcpy(g_"+((declarator124 != null) ? declarator124.ST : null)+", &"+((declarator124 != null) ? declarator124.ST : null).ToString().ToString()+", sizeof("+((type125 != null) ? type125.ST : null)+"), cudaMemcpyHostToDevice);");
            	                                           ((program_scope)program_stack.Peek()).kernelcopyout.Add("cudaMemcpy(&"+((declarator124 != null) ? declarator124.ST : null)+", g_"+((declarator124 != null) ? declarator124.ST : null).ToString().ToString()+", sizeof("+((type125 != null) ? type125.ST : null)+"), cudaMemcpyDeviceToHost);");
            	                                           ((program_scope)program_stack.Peek()).kernelpar =   ((program_scope)program_stack.Peek()).kernelpar+(", g_"+((declarator124 != null) ? declarator124.ST : null));
            	                                           ((program_scope)program_stack.Peek()).kernelpar2 =   ((program_scope)program_stack.Peek()).kernelpar2+(", "+((type125 != null) ? type125.ST : null)+" *gpu_"+((declarator124 != null) ? declarator124.ST : null));
            	        				}

            		if(((program_scope)program_stack.Peek()).index=="1D" || ((program_scope)program_stack.Peek()).index == "2D")
            		{
            		}
            		else
            		{
            			((program_scope)program_stack.Peek()).index = "1";
            		}
            		


            	// TEMPLATE REWRITE
            	// 788:9: -> {$declarator.st.ToString().Contains(\"=\")}? kernel_variable(type=$type.stname=$declarator.stid=$declarator.st.ToString().Substring(0,$declarator.st.ToString().IndexOf('=')))
            	if (((declarator124 != null) ? declarator124.ST : null).ToString().Contains("=")) {
            	    retval.ST = templateLib.GetInstanceOf("kernel_variable",
            	  new STAttrMap().Add("type", ((type125 != null) ? type125.ST : null)).Add("name", ((declarator124 != null) ? declarator124.ST : null)).Add("id", ((declarator124 != null) ? declarator124.ST : null).ToString().Substring(0,((declarator124 != null) ? declarator124.ST : null).ToString().IndexOf('='))));
            	}
            	else // 790:10: -> kernel_var(type=$type.stname=$declarator.st)
            	{
            	    retval.ST = templateLib.GetInstanceOf("kernel_var",
            	  new STAttrMap().Add("type", ((type125 != null) ? type125.ST : null)).Add("name", ((declarator124 != null) ? declarator124.ST : null)));
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
    // $ANTLR end "kernel_variable"

    public class kernel_local_variable_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "kernel_local_variable"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:794:1: kernel_local_variable : 'local' type declarator ';' -> kernel_local_var(type=$type.stname=$declarator.st);
    public C2CUDATranslatorParser.kernel_local_variable_return kernel_local_variable() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.kernel_local_variable_return retval = new C2CUDATranslatorParser.kernel_local_variable_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.type_return type126 = default(C2CUDATranslatorParser.type_return);

        C2CUDATranslatorParser.declarator_return declarator127 = default(C2CUDATranslatorParser.declarator_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:795:5: ( 'local' type declarator ';' -> kernel_local_var(type=$type.stname=$declarator.st))
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:795:9: 'local' type declarator ';'
            {
            	Match(input,72,FOLLOW_72_in_kernel_local_variable4782); 
            	PushFollow(FOLLOW_type_in_kernel_local_variable4784);
            	type126 = type();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_declarator_in_kernel_local_variable4786);
            	declarator127 = declarator();
            	state.followingStackPointer--;

            	Match(input,19,FOLLOW_19_in_kernel_local_variable4788); 


            	// TEMPLATE REWRITE
            	// 798:10: -> kernel_local_var(type=$type.stname=$declarator.st)
            	{
            	    retval.ST = templateLib.GetInstanceOf("kernel_local_var",
            	  new STAttrMap().Add("type", ((type126 != null) ? type126.ST : null)).Add("name", ((declarator127 != null) ? declarator127.ST : null)));
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
    // $ANTLR end "kernel_local_variable"

    public class kernel_array_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "kernel_array"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:801:1: kernel_array : 'kernel' type arraydeclarator ';' -> {$arraydeclarator.st.ToString().IndexOf(\"[\")==$arraydeclarator.st.ToString().LastIndexOf(\"[\")}? kernel_array(type=$type.stname=$arraydeclarator.starr=$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('['))) -> kernel_array2D(type=$type.stname=$arraydeclarator.starr=$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('[')));
    public C2CUDATranslatorParser.kernel_array_return kernel_array() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.kernel_array_return retval = new C2CUDATranslatorParser.kernel_array_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.arraydeclarator_return arraydeclarator128 = default(C2CUDATranslatorParser.arraydeclarator_return);

        C2CUDATranslatorParser.type_return type129 = default(C2CUDATranslatorParser.type_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:802:5: ( 'kernel' type arraydeclarator ';' -> {$arraydeclarator.st.ToString().IndexOf(\"[\")==$arraydeclarator.st.ToString().LastIndexOf(\"[\")}? kernel_array(type=$type.stname=$arraydeclarator.starr=$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('['))) -> kernel_array2D(type=$type.stname=$arraydeclarator.starr=$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('['))))
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:802:9: 'kernel' type arraydeclarator ';'
            {
            	Match(input,38,FOLLOW_38_in_kernel_array4867); 
            	PushFollow(FOLLOW_type_in_kernel_array4869);
            	type129 = type();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_arraydeclarator_in_kernel_array4871);
            	arraydeclarator128 = arraydeclarator();
            	state.followingStackPointer--;

            	Match(input,19,FOLLOW_19_in_kernel_array4873); 
            	if(((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf("[")==((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().LastIndexOf("["))
            	    					   {
            	    					   ((program_scope)program_stack.Peek()).kernelalloc.Add("g_"+((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(0,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('['))+"= ("+((type129 != null) ? type129.ST : null)+" *)malloc("+ ((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('[')+1,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf(']')-((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('[')-1) + " *" +"sizeof("+((type129 != null) ? type129.ST : null)+")); // Allocate array on host \n cudaMalloc((void **) &g_"+((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(0,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('['))+ "," + ((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('[')+1,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf(']')-((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('[')-1) + " *" +" sizeof("+((type129 != null) ? type129.ST : null)+")); // Allocate array on device");
            	    					   ((program_scope)program_stack.Peek()).kernelvarfree.Add("cudaFree(g_"+((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(0,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('['))+");");
            						   ((program_scope)program_stack.Peek()).kernelcopyin.Add("cudaMemcpy(g_"+((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(0,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('['))+", "+((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(0,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('['))+","+ ((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('[')+1,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf(']')-((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('[')-1) + " *" +" sizeof("+((type129 != null) ? type129.ST : null)+"), cudaMemcpyHostToDevice);");
            	                                           ((program_scope)program_stack.Peek()).kernelcopyout.Add("cudaMemcpy("+((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(0,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('['))+", g_"+((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(0,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('['))+","+ ((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('[')+1,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf(']')-((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('[')-1) + " *" +" sizeof("+((type129 != null) ? type129.ST : null)+"), cudaMemcpyDeviceToHost);");
            						   ((program_scope)program_stack.Peek()).kernelpar =  ((program_scope)program_stack.Peek()).kernelpar+(", g_"+((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(0,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('[')));
            						   ((program_scope)program_stack.Peek()).kernelpar2 =  ((program_scope)program_stack.Peek()).kernelpar2+(","+((type129 != null) ? type129.ST : null)+" *gpu_"+((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(0,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('[')));
            						   
            							if(((program_scope)program_stack.Peek()).index=="1D" || ((program_scope)program_stack.Peek()).index == "2D")
            							{
            							}
            							else
            							{
            								((program_scope)program_stack.Peek()).index = "1D";
            							}
            							
            						   }
            						   else
            	        				   { 
            		        				   ((program_scope)program_stack.Peek()).kernelalloc.Add("size_t pitch"+ ((program_scope)program_stack.Peek()).kernelcopyin.Count.ToString()+";\r\n cudaMallocPitch(&"+"g_"+((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(0,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('['))+", &pitch"+ ((program_scope)program_stack.Peek()).kernelcopyin.Count.ToString()+", "+ ((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().LastIndexOf('[')+1,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().LastIndexOf(']')-((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().LastIndexOf('[')-1) + " *" +" sizeof("+((type129 != null) ? type129.ST : null)+")"+", "+ ((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('[')+1,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf(']')-((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('[')-1)+");"+" \r\n // Allocate 2Darray on device");
            		        				   ((program_scope)program_stack.Peek()).RowsAccessed3.Add("pitch"+((program_scope)program_stack.Peek()).kernelcopyin.Count.ToString());
            	  	        				   ((program_scope)program_stack.Peek()).RowsAccessed4.Add(((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(0,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('[')));
            		    					   ((program_scope)program_stack.Peek()).kernelvarfree.Add("cudaFree(g_"+((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(0,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('['))+");");
            							   
            							   String s,temp1 = ((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString();
            							   int n1= ((program_scope)program_stack.Peek()).WriteOnly.Count;
            							   for(int i=0;i<n1;i++)
            							   {
            							   	temp1=((program_scope)program_stack.Peek()).WriteOnly[i].ToString();
            							   }
            		                                           if(((program_scope)program_stack.Peek()).WriteOnly.Contains(((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString()))
            		                                           {                                           	   
            			                                   	((program_scope)program_stack.Peek()).kernelcopyin.Add("cudaMemcpy2D(g_"+((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(0,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('['))+", "+"pitch"+ ((program_scope)program_stack.Peek()).kernelcopyin.Count.ToString()+ ", "+((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(0,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('['))+", "+ ((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().LastIndexOf('[')+1,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().LastIndexOf(']')-((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().LastIndexOf('[')-1) + " *" +" sizeof("+((type129 != null) ? type129.ST : null)+")"+", "+ ((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().LastIndexOf('[')+1,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().LastIndexOf(']')-((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().LastIndexOf('[')-1) + " *" +" sizeof("+((type129 != null) ? type129.ST : null)+"),"+ ((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('[')+1,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf(']')-((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('[')-1) +"," +" cudaMemcpyHostToDevice);");        
            		                                           }
            		                                           else
            		                                           {
            			                                   	((program_scope)program_stack.Peek()).kernelcopyin.Add("cudaMemcpy2D(g_"+((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(0,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('['))+", "+"pitch"+ ((program_scope)program_stack.Peek()).kernelcopyin.Count.ToString()+ ", "+((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(0,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('['))+", "+ ((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().LastIndexOf('[')+1,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().LastIndexOf(']')-((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().LastIndexOf('[')-1) + " *" +" sizeof("+((type129 != null) ? type129.ST : null)+")"+", "+ ((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().LastIndexOf('[')+1,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().LastIndexOf(']')-((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().LastIndexOf('[')-1) + " *" +" sizeof("+((type129 != null) ? type129.ST : null)+"),"+ ((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('[')+1,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf(']')-((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('[')-1) +"," +" cudaMemcpyHostToDevice);");        
            		                                           }
            		                                           
            		                                           ((program_scope)program_stack.Peek()).PitchSatements.Add("int* row"+((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(0,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('['))+" = (int*)((char*)gpu_"+((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(0,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('['))+" + idx*pitch"+(((program_scope)program_stack.Peek()).kernelcopyin.Count-1).ToString()+");");
            		                                           
            		                                           ((program_scope)program_stack.Peek()).kernelcopyout.Add("cudaMemcpy2D("+((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(0,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('['))+","+((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().LastIndexOf('[')+1,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().LastIndexOf(']')-((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().LastIndexOf('[')-1) + " *" +" sizeof("+((type129 != null) ? type129.ST : null)+")"+", g_"+((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(0,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('['))+",pitch"+ (((program_scope)program_stack.Peek()).kernelcopyin.Count-1).ToString()+","+ ((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().LastIndexOf('[')+1,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().LastIndexOf(']')-((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().LastIndexOf('[')-1) + " *" +" sizeof("+((type129 != null) ? type129.ST : null)+")"+","+((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('[')+1,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf(']')-((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('[')-1)+", cudaMemcpyDeviceToHost);");
            							  
            							   ((program_scope)program_stack.Peek()).kernelpar =  ((program_scope)program_stack.Peek()).kernelpar+(", g_"+((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(0,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('['))+ ",pitch"+ (((program_scope)program_stack.Peek()).kernelcopyin.Count-1).ToString());
            							   ((program_scope)program_stack.Peek()).kernelpar2 =  ((program_scope)program_stack.Peek()).kernelpar2+(", "+((type129 != null) ? type129.ST : null)+" *"+"*gpu_"+((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(0,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('['))+" , size_t pitch"+ (((program_scope)program_stack.Peek()).kernelcopyin.Count-1).ToString());
            							   if(((program_scope)program_stack.Peek()).index == "2D")
            								{
            								}
            								else
            								{
            									((program_scope)program_stack.Peek()).index = "2D";
            								}
            						    }
            						   


            	// TEMPLATE REWRITE
            	// 857:3: -> {$arraydeclarator.st.ToString().IndexOf(\"[\")==$arraydeclarator.st.ToString().LastIndexOf(\"[\")}? kernel_array(type=$type.stname=$arraydeclarator.starr=$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('[')))
            	if (((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf("[")==((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().LastIndexOf("[")) {
            	    retval.ST = templateLib.GetInstanceOf("kernel_array",
            	  new STAttrMap().Add("type", ((type129 != null) ? type129.ST : null)).Add("name", ((arraydeclarator128 != null) ? arraydeclarator128.ST : null)).Add("arr", ((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(0,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('['))));
            	}
            	else // 859:13: -> kernel_array2D(type=$type.stname=$arraydeclarator.starr=$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('[')))
            	{
            	    retval.ST = templateLib.GetInstanceOf("kernel_array2D",
            	  new STAttrMap().Add("type", ((type129 != null) ? type129.ST : null)).Add("name", ((arraydeclarator128 != null) ? arraydeclarator128.ST : null)).Add("arr", ((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().Substring(0,((arraydeclarator128 != null) ? arraydeclarator128.ST : null).ToString().IndexOf('['))));
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
    // $ANTLR end "kernel_array"

    public class kblock_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "kblock"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:864:1: kblock : '#pragma kernel_start' ( kstat )* '#pragma kernel_end' ;
    public C2CUDATranslatorParser.kblock_return kblock() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.kblock_return retval = new C2CUDATranslatorParser.kblock_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.kstat_return kstat130 = default(C2CUDATranslatorParser.kstat_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:865:5: ( '#pragma kernel_start' ( kstat )* '#pragma kernel_end' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:865:8: '#pragma kernel_start' ( kstat )* '#pragma kernel_end'
            {
            	Match(input,73,FOLLOW_73_in_kblock4961); 
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:867:10: ( kstat )*
            	do 
            	{
            	    int alt69 = 2;
            	    int LA69_0 = input.LA(1);

            	    if ( ((LA69_0 >= ID && LA69_0 <= INT) || LA69_0 == ARRAY || LA69_0 == 19 || (LA69_0 >= 21 && LA69_0 <= 23) || LA69_0 == 28 || (LA69_0 >= 36 && LA69_0 <= 44) || LA69_0 == 49 || (LA69_0 >= 51 && LA69_0 <= 52) || (LA69_0 >= 54 && LA69_0 <= 56) || (LA69_0 >= 68 && LA69_0 <= 70) || LA69_0 == 75) )
            	    {
            	        alt69 = 1;
            	    }


            	    switch (alt69) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:867:11: kstat
            			    {
            			    	PushFollow(FOLLOW_kstat_in_kblock4982);
            			    	kstat130 = kstat();
            			    	state.followingStackPointer--;

            			    	((slist_scope)slist_stack.Peek()).stats.Add(((kstat130 != null) ? kstat130.ST : null));

            			    }
            			    break;

            			default:
            			    goto loop69;
            	    }
            	} while (true);

            	loop69:
            		;	// Stops C# compiler whining that label 'loop69' has no statements

            	Match(input,74,FOLLOW_74_in_kblock4995); 

            	       
            	       

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
    // $ANTLR end "kblock"

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
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:875:1: kernel_function : kblock -> kernel_function(type=\"void\"name=\"kernel\"args=$program::kernelpar2.ToString().Substring(1,$program::kernelpar2.Length -1 )locals=$slist::localsstats=$slist::statsindex=$program::index.ToString()pitchstats=$program::PitchSatementskernellocals=$program::kernellocals);
    public C2CUDATranslatorParser.kernel_function_return kernel_function() // throws RecognitionException [1]
    {   
        slist_stack.Push(new slist_scope());
        kernel_function_stack.Push(new kernel_function_scope());
        C2CUDATranslatorParser.kernel_function_return retval = new C2CUDATranslatorParser.kernel_function_return();
        retval.Start = input.LT(1);


        	((slist_scope)slist_stack.Peek()).locals =  new ArrayList();
        	((slist_scope)slist_stack.Peek()).stats =  new ArrayList();

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:884:3: ( kblock -> kernel_function(type=\"void\"name=\"kernel\"args=$program::kernelpar2.ToString().Substring(1,$program::kernelpar2.Length -1 )locals=$slist::localsstats=$slist::statsindex=$program::index.ToString()pitchstats=$program::PitchSatementskernellocals=$program::kernellocals))
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:884:7: kblock
            {
            	PushFollow(FOLLOW_kblock_in_kernel_function5038);
            	kblock();
            	state.followingStackPointer--;

            	((kernel_function_scope)kernel_function_stack.Peek()).name = "kernel";
            	  	if(((program_scope)program_stack.Peek()).index=="2D")
            	  	{
            	  		((program_scope)program_stack.Peek()).index = "int idx=threadIdx.x+blockIdx.x*blockDim.x;\r\n int idy=threadIdx.y+blockIdx.y*blockDim.y;";
            		}
            		else
            		{
            			if(((program_scope)program_stack.Peek()).index=="1D")
            		  	{
            		  		((program_scope)program_stack.Peek()).index = "int idx=threadIdx.x+blockIdx.x*blockDim.x;";
            			}
            		}
            	  	if((((program_scope)program_stack.Peek()).iteraiveflag == false) && (((program_scope)program_stack.Peek()).recursionflag == false))
            	  	{
            	  	// If no Dependecy then no change
            	  	}
            	  	else
            	  	{
            	  	((program_scope)program_stack.Peek()).index = "";
            	  	}
            	   


            	// TEMPLATE REWRITE
            	// 905:9: -> kernel_function(type=\"void\"name=\"kernel\"args=$program::kernelpar2.ToString().Substring(1,$program::kernelpar2.Length -1 )locals=$slist::localsstats=$slist::statsindex=$program::index.ToString()pitchstats=$program::PitchSatementskernellocals=$program::kernellocals)
            	{
            	    retval.ST = templateLib.GetInstanceOf("kernel_function",
            	  new STAttrMap().Add("type", "void").Add("name", "kernel").Add("args", ((program_scope)program_stack.Peek()).kernelpar2.ToString().Substring(1,((program_scope)program_stack.Peek()).kernelpar2.Length -1 )).Add("locals", ((slist_scope)slist_stack.Peek()).locals).Add("stats", ((slist_scope)slist_stack.Peek()).stats).Add("index", ((program_scope)program_stack.Peek()).index.ToString()).Add("pitchstats", ((program_scope)program_stack.Peek()).PitchSatements).Add("kernellocals", ((program_scope)program_stack.Peek()).kernellocals));
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
            kernel_function_stack.Pop();
        }
        return retval;
    }
    // $ANTLR end "kernel_function"

    public class kstat_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "kstat"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:908:1: kstat : ( kforStat -> {$kforStat.st} | kexpr ';' -> statement(expr=$kexpr.st) | kkblock -> statementList(locals=$slist::localsstats=$slist::stats) | kassignStat ';' -> {$kassignStat.st} | kselection_statement -> {$kselection_statement.st} | kprint_statement ';' -> {$kprint_statement.st} | kwhile_statement -> {$kwhile_statement.st} | kreturn_statement ';' -> {$kreturn_statement.st} | kfunc_call -> {$kfunc_call.st} | kvariable -> {$kvariable.st} | ';' -> {new StringTemplate(\";\")});
    public C2CUDATranslatorParser.kstat_return kstat() // throws RecognitionException [1]
    {   
        slist_stack.Push(new slist_scope());

        C2CUDATranslatorParser.kstat_return retval = new C2CUDATranslatorParser.kstat_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.kforStat_return kforStat131 = default(C2CUDATranslatorParser.kforStat_return);

        C2CUDATranslatorParser.kexpr_return kexpr132 = default(C2CUDATranslatorParser.kexpr_return);

        C2CUDATranslatorParser.kassignStat_return kassignStat133 = default(C2CUDATranslatorParser.kassignStat_return);

        C2CUDATranslatorParser.kselection_statement_return kselection_statement134 = default(C2CUDATranslatorParser.kselection_statement_return);

        C2CUDATranslatorParser.kprint_statement_return kprint_statement135 = default(C2CUDATranslatorParser.kprint_statement_return);

        C2CUDATranslatorParser.kwhile_statement_return kwhile_statement136 = default(C2CUDATranslatorParser.kwhile_statement_return);

        C2CUDATranslatorParser.kreturn_statement_return kreturn_statement137 = default(C2CUDATranslatorParser.kreturn_statement_return);

        C2CUDATranslatorParser.kfunc_call_return kfunc_call138 = default(C2CUDATranslatorParser.kfunc_call_return);

        C2CUDATranslatorParser.kvariable_return kvariable139 = default(C2CUDATranslatorParser.kvariable_return);



          ((slist_scope)slist_stack.Peek()).locals =  new ArrayList();
          ((slist_scope)slist_stack.Peek()).stats =  new ArrayList();

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:914:5: ( kforStat -> {$kforStat.st} | kexpr ';' -> statement(expr=$kexpr.st) | kkblock -> statementList(locals=$slist::localsstats=$slist::stats) | kassignStat ';' -> {$kassignStat.st} | kselection_statement -> {$kselection_statement.st} | kprint_statement ';' -> {$kprint_statement.st} | kwhile_statement -> {$kwhile_statement.st} | kreturn_statement ';' -> {$kreturn_statement.st} | kfunc_call -> {$kfunc_call.st} | kvariable -> {$kvariable.st} | ';' -> {new StringTemplate(\";\")})
            int alt70 = 11;
            alt70 = dfa70.Predict(input);
            switch (alt70) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:914:7: kforStat
                    {
                    	PushFollow(FOLLOW_kforStat_in_kstat5113);
                    	kforStat131 = kforStat();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 914:16: -> {$kforStat.st}
                    	{
                    	    retval.ST = ((kforStat131 != null) ? kforStat131.ST : null);
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:916:7: kexpr ';'
                    {
                    	PushFollow(FOLLOW_kexpr_in_kstat5126);
                    	kexpr132 = kexpr();
                    	state.followingStackPointer--;

                    	Match(input,19,FOLLOW_19_in_kstat5128); 


                    	// TEMPLATE REWRITE
                    	// 916:17: -> statement(expr=$kexpr.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("statement",
                    	  new STAttrMap().Add("expr", ((kexpr132 != null) ? kexpr132.ST : null)));
                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:917:7: kkblock
                    {
                    	PushFollow(FOLLOW_kkblock_in_kstat5145);
                    	kkblock();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 917:15: -> statementList(locals=$slist::localsstats=$slist::stats)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("statementList",
                    	  new STAttrMap().Add("locals", ((slist_scope)slist_stack.Peek()).locals).Add("stats", ((slist_scope)slist_stack.Peek()).stats));
                    	}


                    }
                    break;
                case 4 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:918:7: kassignStat ';'
                    {
                    	PushFollow(FOLLOW_kassignStat_in_kstat5167);
                    	kassignStat133 = kassignStat();
                    	state.followingStackPointer--;

                    	Match(input,19,FOLLOW_19_in_kstat5169); 
                    	 if(((kassignStat133 != null) ? kassignStat133.ST : null).ToString().Contains("[") && (((kassignStat133 != null) ? kassignStat133.ST : null).ToString().Contains("]")) && (((kassignStat133 != null) ? kassignStat133.ST : null).ToString().IndexOf("[")!=((kassignStat133 != null) ? kassignStat133.ST : null).ToString().LastIndexOf("[")) )
                    	    {
                    	   
                    	   
                    	 //   q = ((kassignStat133 != null) ? kassignStat133.ST : null).ToString().LastIndexOf("[");
                    	    
                    	    C2CUDATranslator.Analysis analysis = new C2CUDATranslator.Analysis();
                    	      System.Collections.ArrayList one = new   System.Collections.ArrayList(); 
                    	      System.Collections.ArrayList two = new   System.Collections.ArrayList();
                    	      String temp,temp2;
                    	      temp = ((kassignStat133 != null) ? kassignStat133.ST : null).ToString().Substring(0,((kassignStat133 != null) ? kassignStat133.ST : null).ToString().IndexOf("]")+1);
                    	    one = analysis.GetindexofArrayfromassignmentStatement(temp);
                    	    temp2 = ((kassignStat133 != null) ? kassignStat133.ST : null).ToString().Substring(((kassignStat133 != null) ? kassignStat133.ST : null).ToString().IndexOf("]")+1,((kassignStat133 != null) ? kassignStat133.ST : null).ToString().Length-(((kassignStat133 != null) ? kassignStat133.ST : null).ToString().IndexOf("]")+1));
                    	    two = analysis.GetindexofArrayfromassignmentStatement(temp2);

                    	    int n1= ((program_scope)program_stack.Peek()).ReadOnly.Count;
                    	    int n2= ((program_scope)program_stack.Peek()).WriteOnly.Count;
                    	    String temp1="";
                    	    String temp3 = "";
                    	    Boolean flag=false;
                    		
                    	    for(int i=0;i<n1;i++)
                    		{
                    		     for(int j=0;j<n2;j++)
                    		         {
                    		         temp1=((program_scope)program_stack.Peek()).ReadOnly[i].ToString();
                    		         temp2=((program_scope)program_stack.Peek()).WriteOnly[j].ToString();
                    		          if (temp1.Contains("[") && temp2.Contains("["))
                    		             {
                    		              if (String.Compare(temp1, temp) == 0)
                    		              {
                    		              }
                    		              else
                    		              {
                    		                  if (String.Compare(temp1.Substring(0, temp1.IndexOf("[")), temp.Substring(0, temp.IndexOf("["))) == 0)
                    		                  {
                    		                      if (analysis.BenergyTest(one, two))
                    		                      {
                    		                          flag = true;
                    		                      }
                    		                  }
                    		              }
                    		             }
                    		         }
                    		}
                    		
                    	    if(flag)
                    	    {
                    	    
                    	    	Console.WriteLine(((kassignStat133 != null) ? kassignStat133.ST : null).ToString() + " Iterative Dependecy");
                    	    	((program_scope)program_stack.Peek()).iteraiveflag =  true;   
                    	    }
                    	    else
                    	    {
                    	   // Console.WriteLine(((kassignStat133 != null) ? kassignStat133.ST : null).ToString());
                    	    ((program_scope)program_stack.Peek()).iteraiveflag =  false  ;  
                    	       
                    	    }
                    	    }
                    	    else
                    	    {
                    	    	
                    	    }
                    	    


                    	// TEMPLATE REWRITE
                    	// 981:7: -> {$kassignStat.st}
                    	{
                    	    retval.ST = ((kassignStat133 != null) ? kassignStat133.ST : null);
                    	}


                    }
                    break;
                case 5 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:982:7: kselection_statement
                    {
                    	PushFollow(FOLLOW_kselection_statement_in_kstat5185);
                    	kselection_statement134 = kselection_statement();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 982:29: -> {$kselection_statement.st}
                    	{
                    	    retval.ST = ((kselection_statement134 != null) ? kselection_statement134.ST : null);
                    	}


                    }
                    break;
                case 6 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:983:7: kprint_statement ';'
                    {
                    	PushFollow(FOLLOW_kprint_statement_in_kstat5198);
                    	kprint_statement135 = kprint_statement();
                    	state.followingStackPointer--;

                    	Match(input,19,FOLLOW_19_in_kstat5200); 


                    	// TEMPLATE REWRITE
                    	// 983:28: -> {$kprint_statement.st}
                    	{
                    	    retval.ST = ((kprint_statement135 != null) ? kprint_statement135.ST : null);
                    	}


                    }
                    break;
                case 7 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:984:7: kwhile_statement
                    {
                    	PushFollow(FOLLOW_kwhile_statement_in_kstat5214);
                    	kwhile_statement136 = kwhile_statement();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 984:25: -> {$kwhile_statement.st}
                    	{
                    	    retval.ST = ((kwhile_statement136 != null) ? kwhile_statement136.ST : null);
                    	}


                    }
                    break;
                case 8 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:985:7: kreturn_statement ';'
                    {
                    	PushFollow(FOLLOW_kreturn_statement_in_kstat5227);
                    	kreturn_statement137 = kreturn_statement();
                    	state.followingStackPointer--;

                    	Match(input,19,FOLLOW_19_in_kstat5229); 


                    	// TEMPLATE REWRITE
                    	// 985:29: -> {$kreturn_statement.st}
                    	{
                    	    retval.ST = ((kreturn_statement137 != null) ? kreturn_statement137.ST : null);
                    	}


                    }
                    break;
                case 9 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:986:7: kfunc_call
                    {
                    	PushFollow(FOLLOW_kfunc_call_in_kstat5241);
                    	kfunc_call138 = kfunc_call();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 986:18: -> {$kfunc_call.st}
                    	{
                    	    retval.ST = ((kfunc_call138 != null) ? kfunc_call138.ST : null);
                    	}


                    }
                    break;
                case 10 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:989:7: kvariable
                    {
                    	PushFollow(FOLLOW_kvariable_in_kstat5255);
                    	kvariable139 = kvariable();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 989:18: -> {$kvariable.st}
                    	{
                    	    retval.ST = ((kvariable139 != null) ? kvariable139.ST : null);
                    	}


                    }
                    break;
                case 11 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:990:7: ';'
                    {
                    	Match(input,19,FOLLOW_19_in_kstat5268); 


                    	// TEMPLATE REWRITE
                    	// 990:11: -> {new StringTemplate(\";\")}
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
    // $ANTLR end "kstat"

    public class kforStat_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "kforStat"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:993:1: kforStat : 'for' '(' e1= kassignStat ';' e2= kexpr ';' e3= kincStat ')' kkblock ;
    public C2CUDATranslatorParser.kforStat_return kforStat() // throws RecognitionException [1]
    {   
        slist_stack.Push(new slist_scope());

        C2CUDATranslatorParser.kforStat_return retval = new C2CUDATranslatorParser.kforStat_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.kassignStat_return e1 = default(C2CUDATranslatorParser.kassignStat_return);

        C2CUDATranslatorParser.kexpr_return e2 = default(C2CUDATranslatorParser.kexpr_return);

        C2CUDATranslatorParser.kincStat_return e3 = default(C2CUDATranslatorParser.kincStat_return);



          ((slist_scope)slist_stack.Peek()).locals =  new ArrayList();
          ((slist_scope)slist_stack.Peek()).stats =  new ArrayList();
          String loopindex;
          

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1001:5: ( 'for' '(' e1= kassignStat ';' e2= kexpr ';' e3= kincStat ')' kkblock )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1001:9: 'for' '(' e1= kassignStat ';' e2= kexpr ';' e3= kincStat ')' kkblock
            {
            	Match(input,44,FOLLOW_44_in_kforStat5305); 
            	Match(input,21,FOLLOW_21_in_kforStat5307); 
            	PushFollow(FOLLOW_kassignStat_in_kforStat5311);
            	e1 = kassignStat();
            	state.followingStackPointer--;

            	Match(input,19,FOLLOW_19_in_kforStat5313); 
            	PushFollow(FOLLOW_kexpr_in_kforStat5317);
            	e2 = kexpr();
            	state.followingStackPointer--;

            	Match(input,19,FOLLOW_19_in_kforStat5319); 
            	PushFollow(FOLLOW_kincStat_in_kforStat5323);
            	e3 = kincStat();
            	state.followingStackPointer--;

            	Match(input,27,FOLLOW_27_in_kforStat5325); 
            	PushFollow(FOLLOW_kkblock_in_kforStat5327);
            	kkblock();
            	state.followingStackPointer--;


            	     C2CUDATranslator.ForLoop Loop1 = new C2CUDATranslator.ForLoop();
            	     Loop1.Index = GetIndexofe1(e1);
            	     Loop1.Size = Getsizeofe2(e2);
            	    
            	     ((program_scope)program_stack.Peek()).kernelforloopindex = ((program_scope)program_stack.Peek()).kernelforloopindex+1;
            	     if(((program_scope)program_stack.Peek()).kernelforloopindex==1)
            	     {
            	     ((program_scope)program_stack.Peek()).size = Loop1.Size;
            	    // ((program_scope)program_stack.Peek()).size = ((program_scope)program_stack.Peek()).size+" * "+Loop1.Size;
            	     }
            	     else
            	     {
            	     Loop1.IsNestLoop=true;
            	      ((program_scope)program_stack.Peek()).size = Loop1.Size+" * "+((program_scope)program_stack.Peek()).size;
            	     }
            	     	 Boolean d=((program_scope)program_stack.Peek()).recursionflag;
            	     	
            	     if((((program_scope)program_stack.Peek()).iteraiveflag == false) && (((program_scope)program_stack.Peek()).recursionflag == false))
            	       {
            	       
            	       if(((program_scope)program_stack.Peek()).index=="2D")
            	  	{
            	  		if(Loop1.IsNestLoop)
            	  		{
            	  		 for(int myi=0;myi<((slist_scope)slist_stack.Peek()).stats.Count;myi++) 		
            	  		{
            	  			if(((slist_scope)slist_stack.Peek()).stats[myi].ToString().Contains("pitch"))
            	  			{
            	  				if(((slist_scope)slist_stack.Peek()).stats[myi].ToString().Contains(Loop1.Index))
            	  				{
            	 				//((slist_scope)slist_stack.Peek()).stats.RemoveAt(0);
            	  				}
            	  			}
            	  		}
            			retval.ST = templateLib.GetInstanceOf("RemoveforLoop",
            	            	new STAttrMap().Add("e1", ((e1 != null) ? e1.ST : null)).Add("e2", ((e2 != null) ? e2.ST : null)).Add("e3", ((e3 != null) ? e3.ST : null)).Add("locals", ((slist_scope)slist_stack.Peek()).locals).Add("stats", ((slist_scope)slist_stack.Peek()).stats).Add("index", Loop1.Index));
            	  		}
            	  		else
            	  		{
            	  		
            			retval.ST = templateLib.GetInstanceOf("kforLoop",
            	            	new STAttrMap().Add("e1", ((e1 != null) ? e1.ST : null)).Add("e2", ((e2 != null) ? e2.ST : null)).Add("e3", ((e3 != null) ? e3.ST : null)).Add("locals", ((slist_scope)slist_stack.Peek()).locals).Add("stats", ((slist_scope)slist_stack.Peek()).stats).Add("index", Loop1.Index));
            	            	}
            		}
            		else
            		{
            			if(((program_scope)program_stack.Peek()).index=="1D")
            		  	{
            			  retval.ST = templateLib.GetInstanceOf("RemoveChildforLoop",
            	            	  new STAttrMap().Add("e1", ((e1 != null) ? e1.ST : null)).Add("e2", ((e2 != null) ? e2.ST : null)).Add("e3", ((e3 != null) ? e3.ST : null)).Add("locals", ((slist_scope)slist_stack.Peek()).locals).Add("stats", ((slist_scope)slist_stack.Peek()).stats).Add("index", Loop1.Index));
            			}
            			else
            			{
            			 retval.ST = templateLib.GetInstanceOf("kforLoop",
            	            	  new STAttrMap().Add("e1", ((e1 != null) ? e1.ST : null)).Add("e2", ((e2 != null) ? e2.ST : null)).Add("e3", ((e3 != null) ? e3.ST : null)).Add("locals", ((slist_scope)slist_stack.Peek()).locals).Add("stats", ((slist_scope)slist_stack.Peek()).stats));
            			}
            		}
            	      // C2CUDATranslator.Transformation.Parallelize($kblock.ST);
            	     // retval.ST = templateLib.GetInstanceOf("RemoveforLoop",
            	       //     	  new STAttrMap().Add("e1", ((e1 != null) ? e1.ST : null)).Add("e2", ((e2 != null) ? e2.ST : null)).Add("e3", ((e3 != null) ? e3.ST : null)).Add("locals", ((slist_scope)slist_stack.Peek()).locals).Add("stats", ((slist_scope)slist_stack.Peek()).stats));
            		
            	       }
            	       else
            	       {
            	         retval.ST = templateLib.GetInstanceOf("kforLoop",
            	            	  new STAttrMap().Add("e1", ((e1 != null) ? e1.ST : null)).Add("e2", ((e2 != null) ? e2.ST : null)).Add("e3", ((e3 != null) ? e3.ST : null)).Add("locals", ((slist_scope)slist_stack.Peek()).locals).Add("stats", ((slist_scope)slist_stack.Peek()).stats));
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
    // $ANTLR end "kforStat"

    public class kassignStat_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "kassignStat"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1075:1: kassignStat : ( ID '=' kexpr -> assign(lhs=\"gpu_\"+$ID.textrhs=$kexpr.st) | s= ARRAY '=' kexpr -> {$program::index==\"2D\" && ($s.text.ToString().IndexOf(\"[\")!=$s.text.ToString().LastIndexOf(\"[\"))}? assign(lhs=\"row\"+$s.text.ToString().Substring(0,$s.text.ToString().IndexOf('['))+$s.text.ToString().Substring(0,$s.text.ToString().IndexOf(\"]\")+1).ToString().Replace($s.text.ToString().Substring(0,$s.text.ToString().IndexOf(\"[\")+1),\"\").ToString().Replace(\"]\",\"\").ToString().Replace(\"+\",\"p\").ToString().Replace(\"-\",\"m\").ToString()+$s.text.ToString().Substring($s.text.ToString().IndexOf(\"]\")+1,$s.text.ToString().Length-$s.text.ToString().IndexOf(\"]\")-1).ToString().Replace(\"[\",\"[gpu_\").ToString()rhs=$kexpr.st) -> assign(lhs=getkernelstr($s.text)rhs=$kexpr.st) | ID '-=' kexpr -> assignop(lhs=\"gpu_\"+$ID.textrhs=$kexpr.stop=\"-=\") | s= ARRAY '-=' kexpr -> assignop(lhs=getkernelstr($s.text)rhs=$kexpr.stop=\"-=\") | ID '+=' kexpr -> assignop(lhs=\"gpu_\"+$ID.textrhs=$kexpr.stop=\"+=\") | s= ARRAY '+=' kexpr -> assignop(lhs=getkernelstr($s.text)rhs=$kexpr.stop=\"+=\"));
    public C2CUDATranslatorParser.kassignStat_return kassignStat() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.kassignStat_return retval = new C2CUDATranslatorParser.kassignStat_return();
        retval.Start = input.LT(1);

        IToken s = null;
        IToken ID140 = null;
        IToken ID143 = null;
        IToken ID146 = null;
        C2CUDATranslatorParser.kexpr_return kexpr141 = default(C2CUDATranslatorParser.kexpr_return);

        C2CUDATranslatorParser.kexpr_return kexpr142 = default(C2CUDATranslatorParser.kexpr_return);

        C2CUDATranslatorParser.kexpr_return kexpr144 = default(C2CUDATranslatorParser.kexpr_return);

        C2CUDATranslatorParser.kexpr_return kexpr145 = default(C2CUDATranslatorParser.kexpr_return);

        C2CUDATranslatorParser.kexpr_return kexpr147 = default(C2CUDATranslatorParser.kexpr_return);

        C2CUDATranslatorParser.kexpr_return kexpr148 = default(C2CUDATranslatorParser.kexpr_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1076:5: ( ID '=' kexpr -> assign(lhs=\"gpu_\"+$ID.textrhs=$kexpr.st) | s= ARRAY '=' kexpr -> {$program::index==\"2D\" && ($s.text.ToString().IndexOf(\"[\")!=$s.text.ToString().LastIndexOf(\"[\"))}? assign(lhs=\"row\"+$s.text.ToString().Substring(0,$s.text.ToString().IndexOf('['))+$s.text.ToString().Substring(0,$s.text.ToString().IndexOf(\"]\")+1).ToString().Replace($s.text.ToString().Substring(0,$s.text.ToString().IndexOf(\"[\")+1),\"\").ToString().Replace(\"]\",\"\").ToString().Replace(\"+\",\"p\").ToString().Replace(\"-\",\"m\").ToString()+$s.text.ToString().Substring($s.text.ToString().IndexOf(\"]\")+1,$s.text.ToString().Length-$s.text.ToString().IndexOf(\"]\")-1).ToString().Replace(\"[\",\"[gpu_\").ToString()rhs=$kexpr.st) -> assign(lhs=getkernelstr($s.text)rhs=$kexpr.st) | ID '-=' kexpr -> assignop(lhs=\"gpu_\"+$ID.textrhs=$kexpr.stop=\"-=\") | s= ARRAY '-=' kexpr -> assignop(lhs=getkernelstr($s.text)rhs=$kexpr.stop=\"-=\") | ID '+=' kexpr -> assignop(lhs=\"gpu_\"+$ID.textrhs=$kexpr.stop=\"+=\") | s= ARRAY '+=' kexpr -> assignop(lhs=getkernelstr($s.text)rhs=$kexpr.stop=\"+=\"))
            int alt71 = 6;
            int LA71_0 = input.LA(1);

            if ( (LA71_0 == ID) )
            {
                switch ( input.LA(2) ) 
                {
                case 45:
                	{
                    alt71 = 1;
                    }
                    break;
                case 46:
                	{
                    alt71 = 3;
                    }
                    break;
                case 47:
                	{
                    alt71 = 5;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d71s1 =
                	        new NoViableAltException("", 71, 1, input);

                	    throw nvae_d71s1;
                }

            }
            else if ( (LA71_0 == ARRAY) )
            {
                switch ( input.LA(2) ) 
                {
                case 45:
                	{
                    alt71 = 2;
                    }
                    break;
                case 46:
                	{
                    alt71 = 4;
                    }
                    break;
                case 47:
                	{
                    alt71 = 6;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d71s2 =
                	        new NoViableAltException("", 71, 2, input);

                	    throw nvae_d71s2;
                }

            }
            else 
            {
                NoViableAltException nvae_d71s0 =
                    new NoViableAltException("", 71, 0, input);

                throw nvae_d71s0;
            }
            switch (alt71) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1076:9: ID '=' kexpr
                    {
                    	ID140=(IToken)Match(input,ID,FOLLOW_ID_in_kassignStat5373); 
                    	Match(input,45,FOLLOW_45_in_kassignStat5375); 
                    	PushFollow(FOLLOW_kexpr_in_kassignStat5377);
                    	kexpr141 = kexpr();
                    	state.followingStackPointer--;

                    	((program_scope)program_stack.Peek()).WriteOnly.Add("gpu_"+((ID140 != null) ? ID140.Text : null));


                    	// TEMPLATE REWRITE
                    	// 1079:5: -> assign(lhs=\"gpu_\"+$ID.textrhs=$kexpr.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("assign",
                    	  new STAttrMap().Add("lhs", "gpu_"+((ID140 != null) ? ID140.Text : null)).Add("rhs", ((kexpr141 != null) ? kexpr141.ST : null)));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1082:9: s= ARRAY '=' kexpr
                    {
                    	s=(IToken)Match(input,ARRAY,FOLLOW_ARRAY_in_kassignStat5418); 
                    	Match(input,45,FOLLOW_45_in_kassignStat5420); 
                    	PushFollow(FOLLOW_kexpr_in_kassignStat5422);
                    	kexpr142 = kexpr();
                    	state.followingStackPointer--;


                    	    if(((program_scope)program_stack.Peek()).index=="2D" && (((s != null) ? s.Text : null).ToString().IndexOf("[")!=((s != null) ? s.Text : null).ToString().LastIndexOf("[")))
                    	    	{     	
                    		    	String pitchstat="";

                    	    		//((program_scope)program_stack.Peek()).RowsAccessed.Add(((s != null) ? s.Text : null).ToString().Substring(((s != null) ? s.Text : null).ToString().IndexOf("["),((s != null) ? s.Text : null).ToString().IndexOf("]")));
                    	    		((program_scope)program_stack.Peek()).RowsAccessed.Add(((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf("]")+1));
                    			((program_scope)program_stack.Peek()).RowsAccessed2.Add("row"+((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf('['))+((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf("]")+1).ToString().Replace(((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf("[")+1),"").ToString().Replace("]","").ToString().Replace("+","p").ToString().Replace("-","m").ToString());
                    				
                    				
                    			pitchstat="int* "+"row"+((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf('['))+((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf("]")+1).ToString().Replace(((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf("[")+1),"").ToString().Replace("]","").ToString().Replace("+","p").ToString().Replace("-","m").ToString()+" = (int* ) ((char* )gpu_"+((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf('['))+" + ("+getkernelstr2(((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf("]")+1).ToString().Replace(((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf("[")+1),"").ToString().Replace("]",""))+") * "+Get2DArrayDevicePitch(((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf("[")))+");";

                    			int myflag=0;
                    			for(int i=0;i<((program_scope)program_stack.Peek()).RowsAccessed5.Count;i++)
                    			{
                    				if(String.Compare(((program_scope)program_stack.Peek()).RowsAccessed5[i].ToString(),pitchstat)==0)
                    				{
                    				myflag=1;
                    				}
                    				
                    			}
                    			if(myflag==0)
                    			{
                    				((program_scope)program_stack.Peek()).RowsAccessed5.Add(pitchstat);
                    	    			((program_scope)program_stack.Peek()).WriteOnly.Add("row"+((s != null) ? s.Text : null).ToString().Replace(((s != null) ? s.Text : null).ToString().Substring(((s != null) ? s.Text : null).ToString().IndexOf("["),((s != null) ? s.Text : null).ToString().IndexOf("]")),"").ToString().Replace("[","[gpu_").ToString());
                    	    		}
                    	    	}
                    	    else
                    	    	{
                    	    		((program_scope)program_stack.Peek()).WriteOnly.Add(getkernelstr(((s != null) ? s.Text : null)));
                    	    	}
                    	    


                    	// TEMPLATE REWRITE
                    	// 1115:5: -> {$program::index==\"2D\" && ($s.text.ToString().IndexOf(\"[\")!=$s.text.ToString().LastIndexOf(\"[\"))}? assign(lhs=\"row\"+$s.text.ToString().Substring(0,$s.text.ToString().IndexOf('['))+$s.text.ToString().Substring(0,$s.text.ToString().IndexOf(\"]\")+1).ToString().Replace($s.text.ToString().Substring(0,$s.text.ToString().IndexOf(\"[\")+1),\"\").ToString().Replace(\"]\",\"\").ToString().Replace(\"+\",\"p\").ToString().Replace(\"-\",\"m\").ToString()+$s.text.ToString().Substring($s.text.ToString().IndexOf(\"]\")+1,$s.text.ToString().Length-$s.text.ToString().IndexOf(\"]\")-1).ToString().Replace(\"[\",\"[gpu_\").ToString()rhs=$kexpr.st)
                    	if (((program_scope)program_stack.Peek()).index=="2D" && (((s != null) ? s.Text : null).ToString().IndexOf("[")!=((s != null) ? s.Text : null).ToString().LastIndexOf("["))) {
                    	    retval.ST = templateLib.GetInstanceOf("assign",
                    	  new STAttrMap().Add("lhs", "row"+((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf('['))+((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf("]")+1).ToString().Replace(((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf("[")+1),"").ToString().Replace("]","").ToString().Replace("+","p").ToString().Replace("-","m").ToString()+((s != null) ? s.Text : null).ToString().Substring(((s != null) ? s.Text : null).ToString().IndexOf("]")+1,((s != null) ? s.Text : null).ToString().Length-((s != null) ? s.Text : null).ToString().IndexOf("]")-1).ToString().Replace("[","[gpu_").ToString()).Add("rhs", ((kexpr142 != null) ? kexpr142.ST : null)));
                    	}
                    	else // 1118:5: -> assign(lhs=getkernelstr($s.text)rhs=$kexpr.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("assign",
                    	  new STAttrMap().Add("lhs", getkernelstr(((s != null) ? s.Text : null))).Add("rhs", ((kexpr142 != null) ? kexpr142.ST : null)));
                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1121:9: ID '-=' kexpr
                    {
                    	ID143=(IToken)Match(input,ID,FOLLOW_ID_in_kassignStat5490); 
                    	Match(input,46,FOLLOW_46_in_kassignStat5492); 
                    	PushFollow(FOLLOW_kexpr_in_kassignStat5494);
                    	kexpr144 = kexpr();
                    	state.followingStackPointer--;

                    	((program_scope)program_stack.Peek()).WriteOnly.Add("gpu_"+((ID143 != null) ? ID143.Text : null));


                    	// TEMPLATE REWRITE
                    	// 1121:67: -> assignop(lhs=\"gpu_\"+$ID.textrhs=$kexpr.stop=\"-=\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("assignop",
                    	  new STAttrMap().Add("lhs", "gpu_"+((ID143 != null) ? ID143.Text : null)).Add("rhs", ((kexpr144 != null) ? kexpr144.ST : null)).Add("op", "-="));
                    	}


                    }
                    break;
                case 4 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1122:9: s= ARRAY '-=' kexpr
                    {
                    	s=(IToken)Match(input,ARRAY,FOLLOW_ARRAY_in_kassignStat5526); 
                    	Match(input,46,FOLLOW_46_in_kassignStat5528); 
                    	PushFollow(FOLLOW_kexpr_in_kassignStat5530);
                    	kexpr145 = kexpr();
                    	state.followingStackPointer--;


                    	    if(((program_scope)program_stack.Peek()).index=="2D" && (((s != null) ? s.Text : null).ToString().IndexOf("[")!=((s != null) ? s.Text : null).ToString().LastIndexOf("[")))
                    	    	{ 
                    	    		((program_scope)program_stack.Peek()).WriteOnly.Add("row"+((s != null) ? s.Text : null).ToString().Replace(((s != null) ? s.Text : null).ToString().Substring(((s != null) ? s.Text : null).ToString().IndexOf("["),((s != null) ? s.Text : null).ToString().IndexOf("]")),"").ToString());
                    	    	}
                    	    else
                    	    	{
                    	    		((program_scope)program_stack.Peek()).WriteOnly.Add(getkernelstr(((s != null) ? s.Text : null)));
                    	    	}
                    	    


                    	// TEMPLATE REWRITE
                    	// 1133:5: -> assignop(lhs=getkernelstr($s.text)rhs=$kexpr.stop=\"-=\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("assignop",
                    	  new STAttrMap().Add("lhs", getkernelstr(((s != null) ? s.Text : null))).Add("rhs", ((kexpr145 != null) ? kexpr145.ST : null)).Add("op", "-="));
                    	}


                    }
                    break;
                case 5 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1134:9: ID '+=' kexpr
                    {
                    	ID146=(IToken)Match(input,ID,FOLLOW_ID_in_kassignStat5567); 
                    	Match(input,47,FOLLOW_47_in_kassignStat5569); 
                    	PushFollow(FOLLOW_kexpr_in_kassignStat5571);
                    	kexpr147 = kexpr();
                    	state.followingStackPointer--;

                    	((program_scope)program_stack.Peek()).WriteOnly.Add("gpu_"+((ID146 != null) ? ID146.Text : null));


                    	// TEMPLATE REWRITE
                    	// 1134:68: -> assignop(lhs=\"gpu_\"+$ID.textrhs=$kexpr.stop=\"+=\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("assignop",
                    	  new STAttrMap().Add("lhs", "gpu_"+((ID146 != null) ? ID146.Text : null)).Add("rhs", ((kexpr147 != null) ? kexpr147.ST : null)).Add("op", "+="));
                    	}


                    }
                    break;
                case 6 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1135:9: s= ARRAY '+=' kexpr
                    {
                    	s=(IToken)Match(input,ARRAY,FOLLOW_ARRAY_in_kassignStat5604); 
                    	Match(input,47,FOLLOW_47_in_kassignStat5606); 
                    	PushFollow(FOLLOW_kexpr_in_kassignStat5608);
                    	kexpr148 = kexpr();
                    	state.followingStackPointer--;


                    	    if(((program_scope)program_stack.Peek()).index=="2D" && (((s != null) ? s.Text : null).ToString().IndexOf("[")!=((s != null) ? s.Text : null).ToString().LastIndexOf("[")))
                    	    	{ 
                    	    		((program_scope)program_stack.Peek()).WriteOnly.Add("row"+((s != null) ? s.Text : null).ToString().Replace(((s != null) ? s.Text : null).ToString().Substring(((s != null) ? s.Text : null).ToString().IndexOf("["),((s != null) ? s.Text : null).ToString().IndexOf("]")),"").ToString());
                    	    	}
                    	    else
                    	    	{
                    	    		((program_scope)program_stack.Peek()).WriteOnly.Add(getkernelstr(((s != null) ? s.Text : null)));
                    	    	}
                    	    


                    	// TEMPLATE REWRITE
                    	// 1146:5: -> assignop(lhs=getkernelstr($s.text)rhs=$kexpr.stop=\"+=\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("assignop",
                    	  new STAttrMap().Add("lhs", getkernelstr(((s != null) ? s.Text : null))).Add("rhs", ((kexpr148 != null) ? kexpr148.ST : null)).Add("op", "+="));
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
    // $ANTLR end "kassignStat"

    public class kprint_statement_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "kprint_statement"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1150:1: kprint_statement : ( 'printf(' STRING_LITERAL ')' -> type(name=\"//printf(\"+$STRING_LITERAL.text+\")\") | 'printf(' STRING_LITERAL ( ',' ) ( katom )+ ')' -> type(name=\"//printf(\"+$STRING_LITERAL.text+\",\"+$katom.st+\")\") | 'default' ':' kstatement -> type(name=\"default :\"+$kstatement.st));
    public C2CUDATranslatorParser.kprint_statement_return kprint_statement() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.kprint_statement_return retval = new C2CUDATranslatorParser.kprint_statement_return();
        retval.Start = input.LT(1);

        IToken STRING_LITERAL149 = null;
        IToken STRING_LITERAL150 = null;
        C2CUDATranslatorParser.katom_return katom151 = default(C2CUDATranslatorParser.katom_return);

        C2CUDATranslatorParser.kstatement_return kstatement152 = default(C2CUDATranslatorParser.kstatement_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1151:2: ( 'printf(' STRING_LITERAL ')' -> type(name=\"//printf(\"+$STRING_LITERAL.text+\")\") | 'printf(' STRING_LITERAL ( ',' ) ( katom )+ ')' -> type(name=\"//printf(\"+$STRING_LITERAL.text+\",\"+$katom.st+\")\") | 'default' ':' kstatement -> type(name=\"default :\"+$kstatement.st))
            int alt73 = 3;
            int LA73_0 = input.LA(1);

            if ( (LA73_0 == 75) )
            {
                int LA73_1 = input.LA(2);

                if ( (LA73_1 == STRING_LITERAL) )
                {
                    int LA73_3 = input.LA(3);

                    if ( (LA73_3 == 27) )
                    {
                        alt73 = 1;
                    }
                    else if ( (LA73_3 == 26) )
                    {
                        alt73 = 2;
                    }
                    else 
                    {
                        NoViableAltException nvae_d73s3 =
                            new NoViableAltException("", 73, 3, input);

                        throw nvae_d73s3;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d73s1 =
                        new NoViableAltException("", 73, 1, input);

                    throw nvae_d73s1;
                }
            }
            else if ( (LA73_0 == 49) )
            {
                alt73 = 3;
            }
            else 
            {
                NoViableAltException nvae_d73s0 =
                    new NoViableAltException("", 73, 0, input);

                throw nvae_d73s0;
            }
            switch (alt73) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1151:4: 'printf(' STRING_LITERAL ')'
                    {
                    	Match(input,75,FOLLOW_75_in_kprint_statement5660); 
                    	STRING_LITERAL149=(IToken)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_kprint_statement5662); 
                    	Match(input,27,FOLLOW_27_in_kprint_statement5664); 


                    	// TEMPLATE REWRITE
                    	// 1151:33: -> type(name=\"//printf(\"+$STRING_LITERAL.text+\")\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "//printf("+((STRING_LITERAL149 != null) ? STRING_LITERAL149.Text : null)+")"));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1152:4: 'printf(' STRING_LITERAL ( ',' ) ( katom )+ ')'
                    {
                    	Match(input,75,FOLLOW_75_in_kprint_statement5678); 
                    	STRING_LITERAL150=(IToken)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_kprint_statement5680); 
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1152:29: ( ',' )
                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1152:30: ','
                    	{
                    		Match(input,26,FOLLOW_26_in_kprint_statement5683); 

                    	}

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1152:35: ( katom )+
                    	int cnt72 = 0;
                    	do 
                    	{
                    	    int alt72 = 2;
                    	    int LA72_0 = input.LA(1);

                    	    if ( ((LA72_0 >= ID && LA72_0 <= INT) || LA72_0 == ARRAY || LA72_0 == 21 || (LA72_0 >= 68 && LA72_0 <= 69)) )
                    	    {
                    	        alt72 = 1;
                    	    }


                    	    switch (alt72) 
                    		{
                    			case 1 :
                    			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1152:35: katom
                    			    {
                    			    	PushFollow(FOLLOW_katom_in_kprint_statement5686);
                    			    	katom151 = katom();
                    			    	state.followingStackPointer--;


                    			    }
                    			    break;

                    			default:
                    			    if ( cnt72 >= 1 ) goto loop72;
                    		            EarlyExitException eee72 =
                    		                new EarlyExitException(72, input);
                    		            throw eee72;
                    	    }
                    	    cnt72++;
                    	} while (true);

                    	loop72:
                    		;	// Stops C# compiler whining that label 'loop72' has no statements

                    	Match(input,27,FOLLOW_27_in_kprint_statement5690); 


                    	// TEMPLATE REWRITE
                    	// 1152:47: -> type(name=\"//printf(\"+$STRING_LITERAL.text+\",\"+$katom.st+\")\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "//printf("+((STRING_LITERAL150 != null) ? STRING_LITERAL150.Text : null)+","+((katom151 != null) ? katom151.ST : null)+")"));
                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1155:4: 'default' ':' kstatement
                    {
                    	Match(input,49,FOLLOW_49_in_kprint_statement5708); 
                    	Match(input,50,FOLLOW_50_in_kprint_statement5710); 
                    	PushFollow(FOLLOW_kstatement_in_kprint_statement5712);
                    	kstatement152 = kstatement();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 1155:29: -> type(name=\"default :\"+$kstatement.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "default :"+((kstatement152 != null) ? kstatement152.ST : null)));
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
    // $ANTLR end "kprint_statement"

    public class kreturn_statement_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "kreturn_statement"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1157:1: kreturn_statement : ( 'return' digits -> type(name=\"return \"+$digits.text +\";\") | 'return' ID -> type(name=\"return \"+$ID.text+\";\") | 'return' ARRAY -> type(name=\"return \"+$ARRAY.text+\";\"));
    public C2CUDATranslatorParser.kreturn_statement_return kreturn_statement() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.kreturn_statement_return retval = new C2CUDATranslatorParser.kreturn_statement_return();
        retval.Start = input.LT(1);

        IToken ID154 = null;
        IToken ARRAY155 = null;
        C2CUDATranslatorParser.digits_return digits153 = default(C2CUDATranslatorParser.digits_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1158:1: ( 'return' digits -> type(name=\"return \"+$digits.text +\";\") | 'return' ID -> type(name=\"return \"+$ID.text+\";\") | 'return' ARRAY -> type(name=\"return \"+$ARRAY.text+\";\"))
            int alt74 = 3;
            int LA74_0 = input.LA(1);

            if ( (LA74_0 == 51) )
            {
                switch ( input.LA(2) ) 
                {
                case ID:
                	{
                    alt74 = 2;
                    }
                    break;
                case ARRAY:
                	{
                    alt74 = 3;
                    }
                    break;
                case INT:
                	{
                    alt74 = 1;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d74s1 =
                	        new NoViableAltException("", 74, 1, input);

                	    throw nvae_d74s1;
                }

            }
            else 
            {
                NoViableAltException nvae_d74s0 =
                    new NoViableAltException("", 74, 0, input);

                throw nvae_d74s0;
            }
            switch (alt74) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1159:4: 'return' digits
                    {
                    	Match(input,51,FOLLOW_51_in_kreturn_statement5733); 
                    	PushFollow(FOLLOW_digits_in_kreturn_statement5735);
                    	digits153 = digits();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 1159:20: -> type(name=\"return \"+$digits.text +\";\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "return "+((digits153 != null) ? input.ToString((IToken)(digits153.Start),(IToken)(digits153.Stop)) : null) +";"));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1160:4: 'return' ID
                    {
                    	Match(input,51,FOLLOW_51_in_kreturn_statement5749); 
                    	ID154=(IToken)Match(input,ID,FOLLOW_ID_in_kreturn_statement5751); 


                    	// TEMPLATE REWRITE
                    	// 1160:20: -> type(name=\"return \"+$ID.text+\";\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "return "+((ID154 != null) ? ID154.Text : null)+";"));
                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1161:11: 'return' ARRAY
                    {
                    	Match(input,51,FOLLOW_51_in_kreturn_statement5776); 
                    	ARRAY155=(IToken)Match(input,ARRAY,FOLLOW_ARRAY_in_kreturn_statement5778); 


                    	// TEMPLATE REWRITE
                    	// 1161:27: -> type(name=\"return \"+$ARRAY.text+\";\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "return "+((ARRAY155 != null) ? ARRAY155.Text : null)+";"));
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
    // $ANTLR end "kreturn_statement"

    public class kwhile_statement_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "kwhile_statement"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1164:1: kwhile_statement : 'while' '(' kexpr ')' kkblock -> whileLoop(e1=$kexpr.stlocals=$slist::localsstats=$slist::stats);
    public C2CUDATranslatorParser.kwhile_statement_return kwhile_statement() // throws RecognitionException [1]
    {   
        slist_stack.Push(new slist_scope());

        C2CUDATranslatorParser.kwhile_statement_return retval = new C2CUDATranslatorParser.kwhile_statement_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.kexpr_return kexpr156 = default(C2CUDATranslatorParser.kexpr_return);



          ((slist_scope)slist_stack.Peek()).locals =  new ArrayList();
          ((slist_scope)slist_stack.Peek()).stats =  new ArrayList();

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1170:2: ( 'while' '(' kexpr ')' kkblock -> whileLoop(e1=$kexpr.stlocals=$slist::localsstats=$slist::stats))
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1170:4: 'while' '(' kexpr ')' kkblock
            {
            	Match(input,52,FOLLOW_52_in_kwhile_statement5810); 
            	Match(input,21,FOLLOW_21_in_kwhile_statement5812); 
            	PushFollow(FOLLOW_kexpr_in_kwhile_statement5814);
            	kexpr156 = kexpr();
            	state.followingStackPointer--;

            	Match(input,27,FOLLOW_27_in_kwhile_statement5816); 
            	PushFollow(FOLLOW_kkblock_in_kwhile_statement5818);
            	kkblock();
            	state.followingStackPointer--;



            	// TEMPLATE REWRITE
            	// 1171:4: -> whileLoop(e1=$kexpr.stlocals=$slist::localsstats=$slist::stats)
            	{
            	    retval.ST = templateLib.GetInstanceOf("whileLoop",
            	  new STAttrMap().Add("e1", ((kexpr156 != null) ? kexpr156.ST : null)).Add("locals", ((slist_scope)slist_stack.Peek()).locals).Add("stats", ((slist_scope)slist_stack.Peek()).stats));
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
    // $ANTLR end "kwhile_statement"

    public class kselection_statement_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "kselection_statement"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1174:1: kselection_statement : ( 'if' '(' kcondExpr ')' kstat -> type(name=\"if (\"+ $kcondExpr.st+\")\" + $kstat.st) | 'else' kstat -> type(name=\"else \" + $kstat.st) | 'switch' '(' kexpr ')' kstatement -> type(name=\"switch (\"+ $kexpr.st+\")\" + $kstatement.st));
    public C2CUDATranslatorParser.kselection_statement_return kselection_statement() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.kselection_statement_return retval = new C2CUDATranslatorParser.kselection_statement_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.kcondExpr_return kcondExpr157 = default(C2CUDATranslatorParser.kcondExpr_return);

        C2CUDATranslatorParser.kstat_return kstat158 = default(C2CUDATranslatorParser.kstat_return);

        C2CUDATranslatorParser.kstat_return kstat159 = default(C2CUDATranslatorParser.kstat_return);

        C2CUDATranslatorParser.kexpr_return kexpr160 = default(C2CUDATranslatorParser.kexpr_return);

        C2CUDATranslatorParser.kstatement_return kstatement161 = default(C2CUDATranslatorParser.kstatement_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1176:2: ( 'if' '(' kcondExpr ')' kstat -> type(name=\"if (\"+ $kcondExpr.st+\")\" + $kstat.st) | 'else' kstat -> type(name=\"else \" + $kstat.st) | 'switch' '(' kexpr ')' kstatement -> type(name=\"switch (\"+ $kexpr.st+\")\" + $kstatement.st))
            int alt75 = 3;
            switch ( input.LA(1) ) 
            {
            case 54:
            	{
                alt75 = 1;
                }
                break;
            case 55:
            	{
                alt75 = 2;
                }
                break;
            case 56:
            	{
                alt75 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d75s0 =
            	        new NoViableAltException("", 75, 0, input);

            	    throw nvae_d75s0;
            }

            switch (alt75) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1176:4: 'if' '(' kcondExpr ')' kstat
                    {
                    	Match(input,54,FOLLOW_54_in_kselection_statement5870); 
                    	Match(input,21,FOLLOW_21_in_kselection_statement5872); 
                    	PushFollow(FOLLOW_kcondExpr_in_kselection_statement5874);
                    	kcondExpr157 = kcondExpr();
                    	state.followingStackPointer--;

                    	Match(input,27,FOLLOW_27_in_kselection_statement5876); 
                    	PushFollow(FOLLOW_kstat_in_kselection_statement5878);
                    	kstat158 = kstat();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 1176:34: -> type(name=\"if (\"+ $kcondExpr.st+\")\" + $kstat.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "if ("+ ((kcondExpr157 != null) ? kcondExpr157.ST : null)+")" + ((kstat158 != null) ? kstat158.ST : null)));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1177:4: 'else' kstat
                    {
                    	Match(input,55,FOLLOW_55_in_kselection_statement5894); 
                    	PushFollow(FOLLOW_kstat_in_kselection_statement5896);
                    	kstat159 = kstat();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 1177:19: -> type(name=\"else \" + $kstat.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "else " + ((kstat159 != null) ? kstat159.ST : null)));
                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1178:4: 'switch' '(' kexpr ')' kstatement
                    {
                    	Match(input,56,FOLLOW_56_in_kselection_statement5912); 
                    	Match(input,21,FOLLOW_21_in_kselection_statement5914); 
                    	PushFollow(FOLLOW_kexpr_in_kselection_statement5916);
                    	kexpr160 = kexpr();
                    	state.followingStackPointer--;

                    	Match(input,27,FOLLOW_27_in_kselection_statement5918); 
                    	PushFollow(FOLLOW_kstatement_in_kselection_statement5920);
                    	kstatement161 = kstatement();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 1178:39: -> type(name=\"switch (\"+ $kexpr.st+\")\" + $kstatement.st)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "switch ("+ ((kexpr160 != null) ? kexpr160.ST : null)+")" + ((kstatement161 != null) ? kstatement161.ST : null)));
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
    // $ANTLR end "kselection_statement"

    public class kstatement_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "kstatement"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1181:1: kstatement : kstat -> type(name=$kstat.st);
    public C2CUDATranslatorParser.kstatement_return kstatement() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.kstatement_return retval = new C2CUDATranslatorParser.kstatement_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.kstat_return kstat162 = default(C2CUDATranslatorParser.kstat_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1182:1: ( kstat -> type(name=$kstat.st))
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1182:8: kstat
            {
            	PushFollow(FOLLOW_kstat_in_kstatement5946);
            	kstat162 = kstat();
            	state.followingStackPointer--;



            	// TEMPLATE REWRITE
            	// 1182:14: -> type(name=$kstat.st)
            	{
            	    retval.ST = templateLib.GetInstanceOf("type",
            	  new STAttrMap().Add("name", ((kstat162 != null) ? kstat162.ST : null)));
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
    // $ANTLR end "kstatement"

    public class katom_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "katom"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1184:1: katom : ( ID -> {flag==1}? refVar(id=$ID.text) -> refVar(id=\"gpu_\"+$ID.text) | INT -> iconst(value=$INT.text) | '(' kaexpr ')' -> {$kaexpr.st} | '[' kaexpr ( ']' | ']]' ) -> {$kaexpr.st} | ']' -> type(name=\"]\") | s= ARRAY -> {$program::index==\"2D\" && ($s.text.ToString().IndexOf(\"[\")!=$s.text.ToString().LastIndexOf(\"[\"))}? type(name=\"row\"+$s.text.ToString().Substring(0,$s.text.ToString().IndexOf('['))+$s.text.ToString().Substring(0,$s.text.ToString().IndexOf(\"]\")+1).ToString().Replace($s.text.ToString().Substring(0,$s.text.ToString().IndexOf(\"[\")+1),\"\").ToString().Replace(\"]\",\"\").ToString().Replace(\"+\",\"p\").ToString().Replace(\"-\",\"m\").ToString()+$s.text.ToString().Substring($s.text.ToString().IndexOf(\"]\")+1,$s.text.ToString().Length-$s.text.ToString().IndexOf(\"]\")-1).ToString().Replace(\"[\",\"[gpu_\").ToString()) -> type(name=getkernelstr($s.text)));
    public C2CUDATranslatorParser.katom_return katom() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.katom_return retval = new C2CUDATranslatorParser.katom_return();
        retval.Start = input.LT(1);

        IToken s = null;
        IToken ID163 = null;
        IToken INT164 = null;
        C2CUDATranslatorParser.kaexpr_return kaexpr165 = default(C2CUDATranslatorParser.kaexpr_return);

        C2CUDATranslatorParser.kaexpr_return kaexpr166 = default(C2CUDATranslatorParser.kaexpr_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1185:5: ( ID -> {flag==1}? refVar(id=$ID.text) -> refVar(id=\"gpu_\"+$ID.text) | INT -> iconst(value=$INT.text) | '(' kaexpr ')' -> {$kaexpr.st} | '[' kaexpr ( ']' | ']]' ) -> {$kaexpr.st} | ']' -> type(name=\"]\") | s= ARRAY -> {$program::index==\"2D\" && ($s.text.ToString().IndexOf(\"[\")!=$s.text.ToString().LastIndexOf(\"[\"))}? type(name=\"row\"+$s.text.ToString().Substring(0,$s.text.ToString().IndexOf('['))+$s.text.ToString().Substring(0,$s.text.ToString().IndexOf(\"]\")+1).ToString().Replace($s.text.ToString().Substring(0,$s.text.ToString().IndexOf(\"[\")+1),\"\").ToString().Replace(\"]\",\"\").ToString().Replace(\"+\",\"p\").ToString().Replace(\"-\",\"m\").ToString()+$s.text.ToString().Substring($s.text.ToString().IndexOf(\"]\")+1,$s.text.ToString().Length-$s.text.ToString().IndexOf(\"]\")-1).ToString().Replace(\"[\",\"[gpu_\").ToString()) -> type(name=getkernelstr($s.text)))
            int alt77 = 6;
            switch ( input.LA(1) ) 
            {
            case ID:
            	{
                alt77 = 1;
                }
                break;
            case INT:
            	{
                alt77 = 2;
                }
                break;
            case 21:
            	{
                alt77 = 3;
                }
                break;
            case 68:
            	{
                alt77 = 4;
                }
                break;
            case 69:
            	{
                alt77 = 5;
                }
                break;
            case ARRAY:
            	{
                alt77 = 6;
                }
                break;
            	default:
            	    NoViableAltException nvae_d77s0 =
            	        new NoViableAltException("", 77, 0, input);

            	    throw nvae_d77s0;
            }

            switch (alt77) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1185:7: ID
                    {
                    	ID163=(IToken)Match(input,ID,FOLLOW_ID_in_katom5967); 

                    	     int flag=0;
                    	     for(int i=0;i<((program_scope)program_stack.Peek()).Constants.Count;i++)
                    	         {
                    	             String mytemps = ((program_scope)program_stack.Peek()).Constants[i].ToString();
                    	             if (String.Compare(((ID163 != null) ? ID163.Text : null), mytemps) == 0)
                    	             {
                    	                 flag=1;
                    	             }
                    	             else
                    	             {
                    	             
                    	             }
                    	         }
                    	    if(flag==1)
                    	    {
                    	    //constant
                    	    }
                    	    else
                    	    {
                    	    	    ((program_scope)program_stack.Peek()).ReadOnly.Add("gpu_"+((ID163 != null) ? ID163.Text : null));
                    	    }

                    	    


                    	// TEMPLATE REWRITE
                    	// 1209:5: -> {flag==1}? refVar(id=$ID.text)
                    	if (flag==1) {
                    	    retval.ST = templateLib.GetInstanceOf("refVar",
                    	  new STAttrMap().Add("id", ((ID163 != null) ? ID163.Text : null)));
                    	}
                    	else // 1211:5: -> refVar(id=\"gpu_\"+$ID.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("refVar",
                    	  new STAttrMap().Add("id", "gpu_"+((ID163 != null) ? ID163.Text : null)));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1212:7: INT
                    {
                    	INT164=(IToken)Match(input,INT,FOLLOW_INT_in_katom6008); 


                    	// TEMPLATE REWRITE
                    	// 1212:11: -> iconst(value=$INT.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("iconst",
                    	  new STAttrMap().Add("value", ((INT164 != null) ? INT164.Text : null)));
                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1213:7: '(' kaexpr ')'
                    {
                    	Match(input,21,FOLLOW_21_in_katom6025); 
                    	PushFollow(FOLLOW_kaexpr_in_katom6027);
                    	kaexpr165 = kaexpr();
                    	state.followingStackPointer--;

                    	Match(input,27,FOLLOW_27_in_katom6029); 


                    	// TEMPLATE REWRITE
                    	// 1213:23: -> {$kaexpr.st}
                    	{
                    	    retval.ST = ((kaexpr165 != null) ? kaexpr165.ST : null);
                    	}


                    }
                    break;
                case 4 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1215:7: '[' kaexpr ( ']' | ']]' )
                    {
                    	Match(input,68,FOLLOW_68_in_katom6048); 
                    	PushFollow(FOLLOW_kaexpr_in_katom6050);
                    	kaexpr166 = kaexpr();
                    	state.followingStackPointer--;

                    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1215:18: ( ']' | ']]' )
                    	int alt76 = 2;
                    	int LA76_0 = input.LA(1);

                    	if ( (LA76_0 == 69) )
                    	{
                    	    alt76 = 1;
                    	}
                    	else if ( (LA76_0 == 76) )
                    	{
                    	    alt76 = 2;
                    	}
                    	else 
                    	{
                    	    NoViableAltException nvae_d76s0 =
                    	        new NoViableAltException("", 76, 0, input);

                    	    throw nvae_d76s0;
                    	}
                    	switch (alt76) 
                    	{
                    	    case 1 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1215:19: ']'
                    	        {
                    	        	Match(input,69,FOLLOW_69_in_katom6053); 

                    	        }
                    	        break;
                    	    case 2 :
                    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1215:23: ']]'
                    	        {
                    	        	Match(input,76,FOLLOW_76_in_katom6055); 

                    	        }
                    	        break;

                    	}



                    	// TEMPLATE REWRITE
                    	// 1215:29: -> {$kaexpr.st}
                    	{
                    	    retval.ST = ((kaexpr166 != null) ? kaexpr166.ST : null);
                    	}


                    }
                    break;
                case 5 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1216:7: ']'
                    {
                    	Match(input,69,FOLLOW_69_in_katom6068); 


                    	// TEMPLATE REWRITE
                    	// 1216:11: -> type(name=\"]\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "]"));
                    	}


                    }
                    break;
                case 6 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1217:7: s= ARRAY
                    {
                    	s=(IToken)Match(input,ARRAY,FOLLOW_ARRAY_in_katom6087); 

                    	    if(((program_scope)program_stack.Peek()).index=="2D" && (((s != null) ? s.Text : null).ToString().IndexOf("[")!=((s != null) ? s.Text : null).ToString().LastIndexOf("[")))
                    	    	{ 
                    	    		int myflag=0;
                    	    		String pitchstat="";
                    	     		for(int i=0;i<((program_scope)program_stack.Peek()).RowsAccessed.Count;i++)
                    	         	{
                    		             String mytemps = ((program_scope)program_stack.Peek()).RowsAccessed[i].ToString();
                    		             if (String.Compare(((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf("]")+1), mytemps) == 0)
                    		             {
                    		                 myflag=1;
                    		             }
                    		             else
                    		             {
                    		             
                    		             }
                    		         }
                    			    if(myflag==1)
                    			    {
                    			    //constant
                    			    }
                    			    else
                    			    {
                    				((program_scope)program_stack.Peek()).RowsAccessed.Add(((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf("]")+1));
                    				((program_scope)program_stack.Peek()).RowsAccessed2.Add("row"+((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf('['))+((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf("]")+1).ToString().Replace(((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf("[")+1),"").ToString().Replace("]","").ToString().Replace("+","p").ToString().Replace("-","m").ToString());
                    				
                    				
                    				pitchstat="int* "+"row"+((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf('['))+((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf("]")+1).ToString().Replace(((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf("[")+1),"").ToString().Replace("]","").ToString().Replace("+","p").ToString().Replace("-","m").ToString()+" = (int* ) ((char* )gpu_"+((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf('['))+" + ("+getkernelstr2(((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf("]")+1).ToString().Replace(((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf("[")+1),"").ToString().Replace("]",""))+") * "+Get2DArrayDevicePitch(((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf("[")))+");";
                    				((program_scope)program_stack.Peek()).RowsAccessed5.Add(pitchstat);
                    					    		
                    			    }
                    	((program_scope)program_stack.Peek()).ReadOnly.Add("row"+((s != null) ? s.Text : null).ToString().Replace(((s != null) ? s.Text : null).ToString().Substring(((s != null) ? s.Text : null).ToString().IndexOf("["),((s != null) ? s.Text : null).ToString().IndexOf("]")),"").ToString().Replace("[","[gpu_").ToString());	    	    	       
                    	    	}
                    	 	else
                    	  	{
                    	  	((program_scope)program_stack.Peek()).ReadOnly.Add(getkernelstr(((s != null) ? s.Text : null)));
                    	  	}
                    	    


                    	// TEMPLATE REWRITE
                    	// 1256:9: -> {$program::index==\"2D\" && ($s.text.ToString().IndexOf(\"[\")!=$s.text.ToString().LastIndexOf(\"[\"))}? type(name=\"row\"+$s.text.ToString().Substring(0,$s.text.ToString().IndexOf('['))+$s.text.ToString().Substring(0,$s.text.ToString().IndexOf(\"]\")+1).ToString().Replace($s.text.ToString().Substring(0,$s.text.ToString().IndexOf(\"[\")+1),\"\").ToString().Replace(\"]\",\"\").ToString().Replace(\"+\",\"p\").ToString().Replace(\"-\",\"m\").ToString()+$s.text.ToString().Substring($s.text.ToString().IndexOf(\"]\")+1,$s.text.ToString().Length-$s.text.ToString().IndexOf(\"]\")-1).ToString().Replace(\"[\",\"[gpu_\").ToString())
                    	if (((program_scope)program_stack.Peek()).index=="2D" && (((s != null) ? s.Text : null).ToString().IndexOf("[")!=((s != null) ? s.Text : null).ToString().LastIndexOf("["))) {
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "row"+((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf('['))+((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf("]")+1).ToString().Replace(((s != null) ? s.Text : null).ToString().Substring(0,((s != null) ? s.Text : null).ToString().IndexOf("[")+1),"").ToString().Replace("]","").ToString().Replace("+","p").ToString().Replace("-","m").ToString()+((s != null) ? s.Text : null).ToString().Substring(((s != null) ? s.Text : null).ToString().IndexOf("]")+1,((s != null) ? s.Text : null).ToString().Length-((s != null) ? s.Text : null).ToString().IndexOf("]")-1).ToString().Replace("[","[gpu_").ToString()));
                    	}
                    	else // 1260:9: -> type(name=getkernelstr($s.text))
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", getkernelstr(((s != null) ? s.Text : null))));
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
    // $ANTLR end "katom"

    public class kcondExpr_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "kcondExpr"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1283:1: kcondExpr : a= kaexpr ( ( '==' b= kaexpr -> equals(left=$a.stright=$b.st) | '!=' b= kaexpr -> notequals(left=$a.stright=$b.st) | '<' b= kaexpr -> lessThan(left=$a.stright=$b.st) | '>' b= kaexpr -> GreaterThan(left=$a.stright=$b.st) | '<=' b= kaexpr -> lessThanEq(left=$a.stright=$b.st) | '>=' b= kaexpr -> GreaterThanEq(left=$a.stright=$b.st) | '&&' b= kaexpr -> CAND(left=$a.stright=$b.st) | '||' b= kaexpr -> COR(left=$a.stright=$b.st)) | -> {$a.st}) ;
    public C2CUDATranslatorParser.kcondExpr_return kcondExpr() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.kcondExpr_return retval = new C2CUDATranslatorParser.kcondExpr_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.kaexpr_return a = default(C2CUDATranslatorParser.kaexpr_return);

        C2CUDATranslatorParser.kaexpr_return b = default(C2CUDATranslatorParser.kaexpr_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1284:5: (a= kaexpr ( ( '==' b= kaexpr -> equals(left=$a.stright=$b.st) | '!=' b= kaexpr -> notequals(left=$a.stright=$b.st) | '<' b= kaexpr -> lessThan(left=$a.stright=$b.st) | '>' b= kaexpr -> GreaterThan(left=$a.stright=$b.st) | '<=' b= kaexpr -> lessThanEq(left=$a.stright=$b.st) | '>=' b= kaexpr -> GreaterThanEq(left=$a.stright=$b.st) | '&&' b= kaexpr -> CAND(left=$a.stright=$b.st) | '||' b= kaexpr -> COR(left=$a.stright=$b.st)) | -> {$a.st}) )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1284:9: a= kaexpr ( ( '==' b= kaexpr -> equals(left=$a.stright=$b.st) | '!=' b= kaexpr -> notequals(left=$a.stright=$b.st) | '<' b= kaexpr -> lessThan(left=$a.stright=$b.st) | '>' b= kaexpr -> GreaterThan(left=$a.stright=$b.st) | '<=' b= kaexpr -> lessThanEq(left=$a.stright=$b.st) | '>=' b= kaexpr -> GreaterThanEq(left=$a.stright=$b.st) | '&&' b= kaexpr -> CAND(left=$a.stright=$b.st) | '||' b= kaexpr -> COR(left=$a.stright=$b.st)) | -> {$a.st})
            {
            	PushFollow(FOLLOW_kaexpr_in_kcondExpr6272);
            	a = kaexpr();
            	state.followingStackPointer--;

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1285:9: ( ( '==' b= kaexpr -> equals(left=$a.stright=$b.st) | '!=' b= kaexpr -> notequals(left=$a.stright=$b.st) | '<' b= kaexpr -> lessThan(left=$a.stright=$b.st) | '>' b= kaexpr -> GreaterThan(left=$a.stright=$b.st) | '<=' b= kaexpr -> lessThanEq(left=$a.stright=$b.st) | '>=' b= kaexpr -> GreaterThanEq(left=$a.stright=$b.st) | '&&' b= kaexpr -> CAND(left=$a.stright=$b.st) | '||' b= kaexpr -> COR(left=$a.stright=$b.st)) | -> {$a.st})
            	int alt79 = 2;
            	int LA79_0 = input.LA(1);

            	if ( ((LA79_0 >= 60 && LA79_0 <= 67)) )
            	{
            	    alt79 = 1;
            	}
            	else if ( (LA79_0 == 19 || LA79_0 == 27) )
            	{
            	    alt79 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d79s0 =
            	        new NoViableAltException("", 79, 0, input);

            	    throw nvae_d79s0;
            	}
            	switch (alt79) 
            	{
            	    case 1 :
            	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1285:13: ( '==' b= kaexpr -> equals(left=$a.stright=$b.st) | '!=' b= kaexpr -> notequals(left=$a.stright=$b.st) | '<' b= kaexpr -> lessThan(left=$a.stright=$b.st) | '>' b= kaexpr -> GreaterThan(left=$a.stright=$b.st) | '<=' b= kaexpr -> lessThanEq(left=$a.stright=$b.st) | '>=' b= kaexpr -> GreaterThanEq(left=$a.stright=$b.st) | '&&' b= kaexpr -> CAND(left=$a.stright=$b.st) | '||' b= kaexpr -> COR(left=$a.stright=$b.st))
            	        {
            	        	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1285:13: ( '==' b= kaexpr -> equals(left=$a.stright=$b.st) | '!=' b= kaexpr -> notequals(left=$a.stright=$b.st) | '<' b= kaexpr -> lessThan(left=$a.stright=$b.st) | '>' b= kaexpr -> GreaterThan(left=$a.stright=$b.st) | '<=' b= kaexpr -> lessThanEq(left=$a.stright=$b.st) | '>=' b= kaexpr -> GreaterThanEq(left=$a.stright=$b.st) | '&&' b= kaexpr -> CAND(left=$a.stright=$b.st) | '||' b= kaexpr -> COR(left=$a.stright=$b.st))
            	        	int alt78 = 8;
            	        	switch ( input.LA(1) ) 
            	        	{
            	        	case 60:
            	        		{
            	        	    alt78 = 1;
            	        	    }
            	        	    break;
            	        	case 61:
            	        		{
            	        	    alt78 = 2;
            	        	    }
            	        	    break;
            	        	case 62:
            	        		{
            	        	    alt78 = 3;
            	        	    }
            	        	    break;
            	        	case 63:
            	        		{
            	        	    alt78 = 4;
            	        	    }
            	        	    break;
            	        	case 64:
            	        		{
            	        	    alt78 = 5;
            	        	    }
            	        	    break;
            	        	case 65:
            	        		{
            	        	    alt78 = 6;
            	        	    }
            	        	    break;
            	        	case 66:
            	        		{
            	        	    alt78 = 7;
            	        	    }
            	        	    break;
            	        	case 67:
            	        		{
            	        	    alt78 = 8;
            	        	    }
            	        	    break;
            	        		default:
            	        		    NoViableAltException nvae_d78s0 =
            	        		        new NoViableAltException("", 78, 0, input);

            	        		    throw nvae_d78s0;
            	        	}

            	        	switch (alt78) 
            	        	{
            	        	    case 1 :
            	        	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1285:16: '==' b= kaexpr
            	        	        {
            	        	        	Match(input,60,FOLLOW_60_in_kcondExpr6290); 
            	        	        	PushFollow(FOLLOW_kaexpr_in_kcondExpr6294);
            	        	        	b = kaexpr();
            	        	        	state.followingStackPointer--;



            	        	        	// TEMPLATE REWRITE
            	        	        	// 1285:30: -> equals(left=$a.stright=$b.st)
            	        	        	{
            	        	        	    retval.ST = templateLib.GetInstanceOf("equals",
            	        	        	  new STAttrMap().Add("left", ((a != null) ? a.ST : null)).Add("right", ((b != null) ? b.ST : null)));
            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1286:16: '!=' b= kaexpr
            	        	        {
            	        	        	Match(input,61,FOLLOW_61_in_kcondExpr6324); 
            	        	        	PushFollow(FOLLOW_kaexpr_in_kcondExpr6328);
            	        	        	b = kaexpr();
            	        	        	state.followingStackPointer--;



            	        	        	// TEMPLATE REWRITE
            	        	        	// 1286:30: -> notequals(left=$a.stright=$b.st)
            	        	        	{
            	        	        	    retval.ST = templateLib.GetInstanceOf("notequals",
            	        	        	  new STAttrMap().Add("left", ((a != null) ? a.ST : null)).Add("right", ((b != null) ? b.ST : null)));
            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 3 :
            	        	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1287:16: '<' b= kaexpr
            	        	        {
            	        	        	Match(input,62,FOLLOW_62_in_kcondExpr6358); 
            	        	        	PushFollow(FOLLOW_kaexpr_in_kcondExpr6362);
            	        	        	b = kaexpr();
            	        	        	state.followingStackPointer--;



            	        	        	// TEMPLATE REWRITE
            	        	        	// 1287:31: -> lessThan(left=$a.stright=$b.st)
            	        	        	{
            	        	        	    retval.ST = templateLib.GetInstanceOf("lessThan",
            	        	        	  new STAttrMap().Add("left", ((a != null) ? a.ST : null)).Add("right", ((b != null) ? b.ST : null)));
            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 4 :
            	        	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1288:16: '>' b= kaexpr
            	        	        {
            	        	        	Match(input,63,FOLLOW_63_in_kcondExpr6394); 
            	        	        	PushFollow(FOLLOW_kaexpr_in_kcondExpr6398);
            	        	        	b = kaexpr();
            	        	        	state.followingStackPointer--;



            	        	        	// TEMPLATE REWRITE
            	        	        	// 1288:31: -> GreaterThan(left=$a.stright=$b.st)
            	        	        	{
            	        	        	    retval.ST = templateLib.GetInstanceOf("GreaterThan",
            	        	        	  new STAttrMap().Add("left", ((a != null) ? a.ST : null)).Add("right", ((b != null) ? b.ST : null)));
            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 5 :
            	        	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1289:16: '<=' b= kaexpr
            	        	        {
            	        	        	Match(input,64,FOLLOW_64_in_kcondExpr6430); 
            	        	        	PushFollow(FOLLOW_kaexpr_in_kcondExpr6434);
            	        	        	b = kaexpr();
            	        	        	state.followingStackPointer--;



            	        	        	// TEMPLATE REWRITE
            	        	        	// 1289:32: -> lessThanEq(left=$a.stright=$b.st)
            	        	        	{
            	        	        	    retval.ST = templateLib.GetInstanceOf("lessThanEq",
            	        	        	  new STAttrMap().Add("left", ((a != null) ? a.ST : null)).Add("right", ((b != null) ? b.ST : null)));
            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 6 :
            	        	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1290:16: '>=' b= kaexpr
            	        	        {
            	        	        	Match(input,65,FOLLOW_65_in_kcondExpr6466); 
            	        	        	PushFollow(FOLLOW_kaexpr_in_kcondExpr6470);
            	        	        	b = kaexpr();
            	        	        	state.followingStackPointer--;



            	        	        	// TEMPLATE REWRITE
            	        	        	// 1290:32: -> GreaterThanEq(left=$a.stright=$b.st)
            	        	        	{
            	        	        	    retval.ST = templateLib.GetInstanceOf("GreaterThanEq",
            	        	        	  new STAttrMap().Add("left", ((a != null) ? a.ST : null)).Add("right", ((b != null) ? b.ST : null)));
            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 7 :
            	        	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1291:16: '&&' b= kaexpr
            	        	        {
            	        	        	Match(input,66,FOLLOW_66_in_kcondExpr6502); 
            	        	        	PushFollow(FOLLOW_kaexpr_in_kcondExpr6506);
            	        	        	b = kaexpr();
            	        	        	state.followingStackPointer--;



            	        	        	// TEMPLATE REWRITE
            	        	        	// 1291:32: -> CAND(left=$a.stright=$b.st)
            	        	        	{
            	        	        	    retval.ST = templateLib.GetInstanceOf("CAND",
            	        	        	  new STAttrMap().Add("left", ((a != null) ? a.ST : null)).Add("right", ((b != null) ? b.ST : null)));
            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 8 :
            	        	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1292:16: '||' b= kaexpr
            	        	        {
            	        	        	Match(input,67,FOLLOW_67_in_kcondExpr6538); 
            	        	        	PushFollow(FOLLOW_kaexpr_in_kcondExpr6542);
            	        	        	b = kaexpr();
            	        	        	state.followingStackPointer--;



            	        	        	// TEMPLATE REWRITE
            	        	        	// 1292:32: -> COR(left=$a.stright=$b.st)
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
            	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1295:13: 
            	        {

            	        	// TEMPLATE REWRITE
            	        	// 1295:13: -> {$a.st}
            	        	{
            	        	    retval.ST = ((a != null) ? a.ST : null);
            	        	}


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
    // $ANTLR end "kcondExpr"

    public class kincStat_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "kincStat"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1303:1: kincStat : ( ID '++' -> type(name=\"gpu_\"+$ID.text + \"++\") | ID '--' -> type(name=\"gpu_\"+$ID.text + \"--\") | '++' ID -> type(name=\"++\"+\"gpu_\"+$ID.text) | '--' ID -> type(name=\"--\"+\"gpu_\"+$ID.text) | ID '+=' INT -> type(name=\"gpu_\"+$ID.text + \"+=\" + $INT.text) | ID '-=' INT -> type(name=\"gpu_\"+$ID.text + \"-=\" + $INT.text) | ID '*=' INT -> type(name=\"gpu_\"+$ID.text + \"*=\" + $INT.text));
    public C2CUDATranslatorParser.kincStat_return kincStat() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.kincStat_return retval = new C2CUDATranslatorParser.kincStat_return();
        retval.Start = input.LT(1);

        IToken ID167 = null;
        IToken ID168 = null;
        IToken ID169 = null;
        IToken ID170 = null;
        IToken ID171 = null;
        IToken INT172 = null;
        IToken ID173 = null;
        IToken INT174 = null;
        IToken ID175 = null;
        IToken INT176 = null;

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1304:2: ( ID '++' -> type(name=\"gpu_\"+$ID.text + \"++\") | ID '--' -> type(name=\"gpu_\"+$ID.text + \"--\") | '++' ID -> type(name=\"++\"+\"gpu_\"+$ID.text) | '--' ID -> type(name=\"--\"+\"gpu_\"+$ID.text) | ID '+=' INT -> type(name=\"gpu_\"+$ID.text + \"+=\" + $INT.text) | ID '-=' INT -> type(name=\"gpu_\"+$ID.text + \"-=\" + $INT.text) | ID '*=' INT -> type(name=\"gpu_\"+$ID.text + \"*=\" + $INT.text))
            int alt80 = 7;
            switch ( input.LA(1) ) 
            {
            case ID:
            	{
                switch ( input.LA(2) ) 
                {
                case 57:
                	{
                    alt80 = 1;
                    }
                    break;
                case 58:
                	{
                    alt80 = 2;
                    }
                    break;
                case 47:
                	{
                    alt80 = 5;
                    }
                    break;
                case 46:
                	{
                    alt80 = 6;
                    }
                    break;
                case 59:
                	{
                    alt80 = 7;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d80s1 =
                	        new NoViableAltException("", 80, 1, input);

                	    throw nvae_d80s1;
                }

                }
                break;
            case 57:
            	{
                alt80 = 3;
                }
                break;
            case 58:
            	{
                alt80 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d80s0 =
            	        new NoViableAltException("", 80, 0, input);

            	    throw nvae_d80s0;
            }

            switch (alt80) 
            {
                case 1 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1304:6: ID '++'
                    {
                    	ID167=(IToken)Match(input,ID,FOLLOW_ID_in_kincStat6656); 
                    	Match(input,57,FOLLOW_57_in_kincStat6658); 


                    	// TEMPLATE REWRITE
                    	// 1304:15: -> type(name=\"gpu_\"+$ID.text + \"++\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "gpu_"+((ID167 != null) ? ID167.Text : null) + "++"));
                    	}


                    }
                    break;
                case 2 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1305:6: ID '--'
                    {
                    	ID168=(IToken)Match(input,ID,FOLLOW_ID_in_kincStat6675); 
                    	Match(input,58,FOLLOW_58_in_kincStat6677); 


                    	// TEMPLATE REWRITE
                    	// 1305:16: -> type(name=\"gpu_\"+$ID.text + \"--\")
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "gpu_"+((ID168 != null) ? ID168.Text : null) + "--"));
                    	}


                    }
                    break;
                case 3 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1306:6: '++' ID
                    {
                    	Match(input,57,FOLLOW_57_in_kincStat6695); 
                    	ID169=(IToken)Match(input,ID,FOLLOW_ID_in_kincStat6697); 


                    	// TEMPLATE REWRITE
                    	// 1306:16: -> type(name=\"++\"+\"gpu_\"+$ID.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "++"+"gpu_"+((ID169 != null) ? ID169.Text : null)));
                    	}


                    }
                    break;
                case 4 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1307:7: '--' ID
                    {
                    	Match(input,58,FOLLOW_58_in_kincStat6716); 
                    	ID170=(IToken)Match(input,ID,FOLLOW_ID_in_kincStat6718); 


                    	// TEMPLATE REWRITE
                    	// 1307:15: -> type(name=\"--\"+\"gpu_\"+$ID.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "--"+"gpu_"+((ID170 != null) ? ID170.Text : null)));
                    	}


                    }
                    break;
                case 5 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1308:7: ID '+=' INT
                    {
                    	ID171=(IToken)Match(input,ID,FOLLOW_ID_in_kincStat6735); 
                    	Match(input,47,FOLLOW_47_in_kincStat6737); 
                    	INT172=(IToken)Match(input,INT,FOLLOW_INT_in_kincStat6739); 


                    	// TEMPLATE REWRITE
                    	// 1308:19: -> type(name=\"gpu_\"+$ID.text + \"+=\" + $INT.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "gpu_"+((ID171 != null) ? ID171.Text : null) + "+=" + ((INT172 != null) ? INT172.Text : null)));
                    	}


                    }
                    break;
                case 6 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1309:6: ID '-=' INT
                    {
                    	ID173=(IToken)Match(input,ID,FOLLOW_ID_in_kincStat6755); 
                    	Match(input,46,FOLLOW_46_in_kincStat6757); 
                    	INT174=(IToken)Match(input,INT,FOLLOW_INT_in_kincStat6759); 


                    	// TEMPLATE REWRITE
                    	// 1309:18: -> type(name=\"gpu_\"+$ID.text + \"-=\" + $INT.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "gpu_"+((ID173 != null) ? ID173.Text : null) + "-=" + ((INT174 != null) ? INT174.Text : null)));
                    	}


                    }
                    break;
                case 7 :
                    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1310:6: ID '*=' INT
                    {
                    	ID175=(IToken)Match(input,ID,FOLLOW_ID_in_kincStat6775); 
                    	Match(input,59,FOLLOW_59_in_kincStat6777); 
                    	INT176=(IToken)Match(input,INT,FOLLOW_INT_in_kincStat6779); 


                    	// TEMPLATE REWRITE
                    	// 1310:18: -> type(name=\"gpu_\"+$ID.text + \"*=\" + $INT.text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("type",
                    	  new STAttrMap().Add("name", "gpu_"+((ID175 != null) ? ID175.Text : null) + "*=" + ((INT176 != null) ? INT176.Text : null)));
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
    // $ANTLR end "kincStat"

    public class kexpr_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "kexpr"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1313:1: kexpr : kcondExpr -> {$kcondExpr.st};
    public C2CUDATranslatorParser.kexpr_return kexpr() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.kexpr_return retval = new C2CUDATranslatorParser.kexpr_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.kcondExpr_return kcondExpr177 = default(C2CUDATranslatorParser.kcondExpr_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1313:6: ( kcondExpr -> {$kcondExpr.st})
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1314:2: kcondExpr
            {
            	PushFollow(FOLLOW_kcondExpr_in_kexpr6803);
            	kcondExpr177 = kcondExpr();
            	state.followingStackPointer--;



            	// TEMPLATE REWRITE
            	// 1314:12: -> {$kcondExpr.st}
            	{
            	    retval.ST = ((kcondExpr177 != null) ? kcondExpr177.ST : null);
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
    // $ANTLR end "kexpr"

    public class kaexpr_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "kaexpr"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1317:1: kaexpr : (a= katom -> {$a.st}) ( '+' b= katom -> add(left=$kaexpr.stright=$b.st))* ( '-' b= katom -> Sub(left=$kaexpr.stright=$b.st))* ( '/' b= katom -> Div(left=$kaexpr.stright=$b.st))* ( '*' b= katom -> Mul(left=$kaexpr.stright=$b.st))* ( '%' b= katom -> Mod(left=$kaexpr.stright=$b.st))* ;
    public C2CUDATranslatorParser.kaexpr_return kaexpr() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.kaexpr_return retval = new C2CUDATranslatorParser.kaexpr_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.katom_return a = default(C2CUDATranslatorParser.katom_return);

        C2CUDATranslatorParser.katom_return b = default(C2CUDATranslatorParser.katom_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1318:5: ( (a= katom -> {$a.st}) ( '+' b= katom -> add(left=$kaexpr.stright=$b.st))* ( '-' b= katom -> Sub(left=$kaexpr.stright=$b.st))* ( '/' b= katom -> Div(left=$kaexpr.stright=$b.st))* ( '*' b= katom -> Mul(left=$kaexpr.stright=$b.st))* ( '%' b= katom -> Mod(left=$kaexpr.stright=$b.st))* )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1318:9: (a= katom -> {$a.st}) ( '+' b= katom -> add(left=$kaexpr.stright=$b.st))* ( '-' b= katom -> Sub(left=$kaexpr.stright=$b.st))* ( '/' b= katom -> Div(left=$kaexpr.stright=$b.st))* ( '*' b= katom -> Mul(left=$kaexpr.stright=$b.st))* ( '%' b= katom -> Mod(left=$kaexpr.stright=$b.st))*
            {
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1318:9: (a= katom -> {$a.st})
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1318:10: a= katom
            	{
            		PushFollow(FOLLOW_katom_in_kaexpr6829);
            		a = katom();
            		state.followingStackPointer--;



            		// TEMPLATE REWRITE
            		// 1318:18: -> {$a.st}
            		{
            		    retval.ST = ((a != null) ? a.ST : null);
            		}


            	}

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1319:9: ( '+' b= katom -> add(left=$kaexpr.stright=$b.st))*
            	do 
            	{
            	    int alt81 = 2;
            	    int LA81_0 = input.LA(1);

            	    if ( (LA81_0 == 32) )
            	    {
            	        alt81 = 1;
            	    }


            	    switch (alt81) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1319:11: '+' b= katom
            			    {
            			    	Match(input,32,FOLLOW_32_in_kaexpr6846); 
            			    	PushFollow(FOLLOW_katom_in_kaexpr6850);
            			    	b = katom();
            			    	state.followingStackPointer--;



            			    	// TEMPLATE REWRITE
            			    	// 1319:23: -> add(left=$kaexpr.stright=$b.st)
            			    	{
            			    	    retval.ST = templateLib.GetInstanceOf("add",
            			    	  new STAttrMap().Add("left", retval.ST).Add("right", ((b != null) ? b.ST : null)));
            			    	}


            			    }
            			    break;

            			default:
            			    goto loop81;
            	    }
            	} while (true);

            	loop81:
            		;	// Stops C# compiler whining that label 'loop81' has no statements

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1320:9: ( '-' b= katom -> Sub(left=$kaexpr.stright=$b.st))*
            	do 
            	{
            	    int alt82 = 2;
            	    int LA82_0 = input.LA(1);

            	    if ( (LA82_0 == 33) )
            	    {
            	        alt82 = 1;
            	    }


            	    switch (alt82) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1320:11: '-' b= katom
            			    {
            			    	Match(input,33,FOLLOW_33_in_kaexpr6879); 
            			    	PushFollow(FOLLOW_katom_in_kaexpr6883);
            			    	b = katom();
            			    	state.followingStackPointer--;



            			    	// TEMPLATE REWRITE
            			    	// 1320:23: -> Sub(left=$kaexpr.stright=$b.st)
            			    	{
            			    	    retval.ST = templateLib.GetInstanceOf("Sub",
            			    	  new STAttrMap().Add("left", retval.ST).Add("right", ((b != null) ? b.ST : null)));
            			    	}


            			    }
            			    break;

            			default:
            			    goto loop82;
            	    }
            	} while (true);

            	loop82:
            		;	// Stops C# compiler whining that label 'loop82' has no statements

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1321:9: ( '/' b= katom -> Div(left=$kaexpr.stright=$b.st))*
            	do 
            	{
            	    int alt83 = 2;
            	    int LA83_0 = input.LA(1);

            	    if ( (LA83_0 == 34) )
            	    {
            	        alt83 = 1;
            	    }


            	    switch (alt83) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1321:11: '/' b= katom
            			    {
            			    	Match(input,34,FOLLOW_34_in_kaexpr6912); 
            			    	PushFollow(FOLLOW_katom_in_kaexpr6916);
            			    	b = katom();
            			    	state.followingStackPointer--;



            			    	// TEMPLATE REWRITE
            			    	// 1321:23: -> Div(left=$kaexpr.stright=$b.st)
            			    	{
            			    	    retval.ST = templateLib.GetInstanceOf("Div",
            			    	  new STAttrMap().Add("left", retval.ST).Add("right", ((b != null) ? b.ST : null)));
            			    	}


            			    }
            			    break;

            			default:
            			    goto loop83;
            	    }
            	} while (true);

            	loop83:
            		;	// Stops C# compiler whining that label 'loop83' has no statements

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1322:9: ( '*' b= katom -> Mul(left=$kaexpr.stright=$b.st))*
            	do 
            	{
            	    int alt84 = 2;
            	    int LA84_0 = input.LA(1);

            	    if ( (LA84_0 == 24) )
            	    {
            	        alt84 = 1;
            	    }


            	    switch (alt84) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1322:11: '*' b= katom
            			    {
            			    	Match(input,24,FOLLOW_24_in_kaexpr6945); 
            			    	PushFollow(FOLLOW_katom_in_kaexpr6949);
            			    	b = katom();
            			    	state.followingStackPointer--;



            			    	// TEMPLATE REWRITE
            			    	// 1322:23: -> Mul(left=$kaexpr.stright=$b.st)
            			    	{
            			    	    retval.ST = templateLib.GetInstanceOf("Mul",
            			    	  new STAttrMap().Add("left", retval.ST).Add("right", ((b != null) ? b.ST : null)));
            			    	}


            			    }
            			    break;

            			default:
            			    goto loop84;
            	    }
            	} while (true);

            	loop84:
            		;	// Stops C# compiler whining that label 'loop84' has no statements

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1323:9: ( '%' b= katom -> Mod(left=$kaexpr.stright=$b.st))*
            	do 
            	{
            	    int alt85 = 2;
            	    int LA85_0 = input.LA(1);

            	    if ( (LA85_0 == 35) )
            	    {
            	        alt85 = 1;
            	    }


            	    switch (alt85) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1323:11: '%' b= katom
            			    {
            			    	Match(input,35,FOLLOW_35_in_kaexpr6978); 
            			    	PushFollow(FOLLOW_katom_in_kaexpr6982);
            			    	b = katom();
            			    	state.followingStackPointer--;



            			    	// TEMPLATE REWRITE
            			    	// 1323:23: -> Mod(left=$kaexpr.stright=$b.st)
            			    	{
            			    	    retval.ST = templateLib.GetInstanceOf("Mod",
            			    	  new STAttrMap().Add("left", retval.ST).Add("right", ((b != null) ? b.ST : null)));
            			    	}


            			    }
            			    break;

            			default:
            			    goto loop85;
            	    }
            	} while (true);

            	loop85:
            		;	// Stops C# compiler whining that label 'loop85' has no statements


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
    // $ANTLR end "kaexpr"

    public class kkblock_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "kkblock"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1326:1: kkblock : '{' ( kstat )* '}' ;
    public C2CUDATranslatorParser.kkblock_return kkblock() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.kkblock_return retval = new C2CUDATranslatorParser.kkblock_return();
        retval.Start = input.LT(1);

        C2CUDATranslatorParser.kstat_return kstat178 = default(C2CUDATranslatorParser.kstat_return);


        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1327:5: ( '{' ( kstat )* '}' )
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1327:8: '{' ( kstat )* '}'
            {
            	Match(input,28,FOLLOW_28_in_kkblock7030); 
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1330:10: ( kstat )*
            	do 
            	{
            	    int alt86 = 2;
            	    int LA86_0 = input.LA(1);

            	    if ( ((LA86_0 >= ID && LA86_0 <= INT) || LA86_0 == ARRAY || LA86_0 == 19 || (LA86_0 >= 21 && LA86_0 <= 23) || LA86_0 == 28 || (LA86_0 >= 36 && LA86_0 <= 44) || LA86_0 == 49 || (LA86_0 >= 51 && LA86_0 <= 52) || (LA86_0 >= 54 && LA86_0 <= 56) || (LA86_0 >= 68 && LA86_0 <= 70) || LA86_0 == 75) )
            	    {
            	        alt86 = 1;
            	    }


            	    switch (alt86) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1330:11: kstat
            			    {
            			    	PushFollow(FOLLOW_kstat_in_kkblock7058);
            			    	kstat178 = kstat();
            			    	state.followingStackPointer--;


            			    	         for(int i=0;i<((program_scope)program_stack.Peek()).RowsAccessed5.Count;i++)
            			    	         {
            			    	         ((slist_scope)slist_stack.Peek()).stats.Add(((program_scope)program_stack.Peek()).RowsAccessed5[i]);
            			    	         
            			    	         }
            			    	         ((program_scope)program_stack.Peek()).RowsAccessed5.Clear();
            			    	         ((slist_scope)slist_stack.Peek()).stats.Add(((kstat178 != null) ? kstat178.ST : null));

            			    }
            			    break;

            			default:
            			    goto loop86;
            	    }
            	} while (true);

            	loop86:
            		;	// Stops C# compiler whining that label 'loop86' has no statements

            	Match(input,29,FOLLOW_29_in_kkblock7081); 

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
    // $ANTLR end "kkblock"

    public class mixdeclarator_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "mixdeclarator"
    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1342:1: mixdeclarator : ( ID | ARRAY ) ( ( ',' ) ( ID | ARRAY ) )* -> {$mixdeclarator.st;};
    public C2CUDATranslatorParser.mixdeclarator_return mixdeclarator() // throws RecognitionException [1]
    {   
        C2CUDATranslatorParser.mixdeclarator_return retval = new C2CUDATranslatorParser.mixdeclarator_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1343:2: ( ( ID | ARRAY ) ( ( ',' ) ( ID | ARRAY ) )* -> {$mixdeclarator.st;})
            // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1344:3: ( ID | ARRAY ) ( ( ',' ) ( ID | ARRAY ) )*
            {
            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1344:3: ( ID | ARRAY )
            	int alt87 = 2;
            	int LA87_0 = input.LA(1);

            	if ( (LA87_0 == ID) )
            	{
            	    alt87 = 1;
            	}
            	else if ( (LA87_0 == ARRAY) )
            	{
            	    alt87 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d87s0 =
            	        new NoViableAltException("", 87, 0, input);

            	    throw nvae_d87s0;
            	}
            	switch (alt87) 
            	{
            	    case 1 :
            	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1344:4: ID
            	        {
            	        	Match(input,ID,FOLLOW_ID_in_mixdeclarator7113); 

            	        }
            	        break;
            	    case 2 :
            	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1344:7: ARRAY
            	        {
            	        	Match(input,ARRAY,FOLLOW_ARRAY_in_mixdeclarator7115); 

            	        }
            	        break;

            	}

            	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1344:14: ( ( ',' ) ( ID | ARRAY ) )*
            	do 
            	{
            	    int alt89 = 2;
            	    int LA89_0 = input.LA(1);

            	    if ( (LA89_0 == 26) )
            	    {
            	        alt89 = 1;
            	    }


            	    switch (alt89) 
            		{
            			case 1 :
            			    // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1344:15: ( ',' ) ( ID | ARRAY )
            			    {
            			    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1344:15: ( ',' )
            			    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1344:16: ','
            			    	{
            			    		Match(input,26,FOLLOW_26_in_mixdeclarator7120); 

            			    	}

            			    	// Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1344:21: ( ID | ARRAY )
            			    	int alt88 = 2;
            			    	int LA88_0 = input.LA(1);

            			    	if ( (LA88_0 == ID) )
            			    	{
            			    	    alt88 = 1;
            			    	}
            			    	else if ( (LA88_0 == ARRAY) )
            			    	{
            			    	    alt88 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d88s0 =
            			    	        new NoViableAltException("", 88, 0, input);

            			    	    throw nvae_d88s0;
            			    	}
            			    	switch (alt88) 
            			    	{
            			    	    case 1 :
            			    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1344:22: ID
            			    	        {
            			    	        	Match(input,ID,FOLLOW_ID_in_mixdeclarator7124); 

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // Z:\\C2CUDATranslator\\C2CUDATranslator\\C2CUDATranslator.g:1344:25: ARRAY
            			    	        {
            			    	        	Match(input,ARRAY,FOLLOW_ARRAY_in_mixdeclarator7126); 

            			    	        }
            			    	        break;

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop89;
            	    }
            	} while (true);

            	loop89:
            		;	// Stops C# compiler whining that label 'loop89' has no statements



            	// TEMPLATE REWRITE
            	// 1344:34: -> {$mixdeclarator.st;}
            	{
            	    retval.ST = retval.ST;;
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
    // $ANTLR end "mixdeclarator"

    // Delegated rules


   	protected DFA2 dfa2;
   	protected DFA3 dfa3;
   	protected DFA4 dfa4;
   	protected DFA13 dfa13;
   	protected DFA17 dfa17;
   	protected DFA26 dfa26;
   	protected DFA42 dfa42;
   	protected DFA43 dfa43;
   	protected DFA70 dfa70;
	private void InitializeCyclicDFAs()
	{
    	this.dfa2 = new DFA2(this);
    	this.dfa3 = new DFA3(this);
    	this.dfa4 = new DFA4(this);
    	this.dfa13 = new DFA13(this);
    	this.dfa17 = new DFA17(this);
    	this.dfa26 = new DFA26(this);
    	this.dfa42 = new DFA42(this);
    	this.dfa43 = new DFA43(this);
    	this.dfa70 = new DFA70(this);
	}

    const string DFA2_eotS =
        "\x21\uffff";
    const string DFA2_eofS =
        "\x21\uffff";
    const string DFA2_minS =
        "\x0b\x04\x01\uffff\x01\x04\x03\uffff\x01\x13\x02\uffff\x0a\x04"+
        "\x04\uffff";
    const string DFA2_maxS =
        "\x01\x49\x04\x09\x01\x2b\x05\x09\x01\uffff\x01\x43\x03\uffff\x01"+
        "\x1a\x02\uffff\x0a\x07\x04\uffff";
    const string DFA2_acceptS =
        "\x0b\uffff\x01\x05\x01\uffff\x01\x08\x01\x09\x01\x0a\x01\uffff"+
        "\x01\x06\x01\x01\x0a\uffff\x01\x07\x01\x02\x01\x04\x01\x03";
    const string DFA2_specialS =
        "\x21\uffff}>";
    static readonly string[] DFA2_transitionS = {
            "\x02\x0e\x01\uffff\x01\x0e\x01\x0c\x01\x0d\x01\x0e\x01\uffff"+
            "\x01\x0e\x06\uffff\x01\x0e\x01\uffff\x01\x0e\x01\x01\x01\x02"+
            "\x04\uffff\x01\x0e\x07\uffff\x01\x03\x01\x04\x01\x05\x01\x06"+
            "\x01\x07\x01\x08\x01\x09\x01\x0a\x01\x0e\x03\uffff\x02\x0e\x01"+
            "\uffff\x06\x0e\x0b\uffff\x01\x0e\x03\uffff\x01\x0b\x01\x0f",
            "\x01\x10\x01\uffff\x01\x11\x01\x12\x01\uffff\x01\x0d",
            "\x01\x10\x01\uffff\x01\x11\x01\x12\x01\uffff\x01\x0d",
            "\x01\x10\x01\uffff\x01\x11\x01\x12\x01\uffff\x01\x0d",
            "\x01\x10\x01\uffff\x01\x11\x01\x12\x01\uffff\x01\x0d",
            "\x01\x10\x01\uffff\x01\x11\x01\x12\x01\uffff\x01\x0d\x0c\uffff"+
            "\x01\x13\x01\x14\x0c\uffff\x01\x15\x01\x16\x01\x17\x01\x18\x01"+
            "\x19\x01\x1a\x01\x1b\x01\x1c",
            "\x01\x10\x01\uffff\x01\x11\x01\x12\x01\uffff\x01\x0d",
            "\x01\x10\x01\uffff\x01\x11\x01\x12\x01\uffff\x01\x0d",
            "\x01\x10\x01\uffff\x01\x11\x01\x12\x01\uffff\x01\x0d",
            "\x01\x10\x01\uffff\x01\x11\x01\x12\x01\uffff\x01\x0d",
            "\x01\x10\x01\uffff\x01\x11\x01\x12\x01\uffff\x01\x0d",
            "",
            "\x01\x1d\x0e\uffff\x01\x0e\x01\uffff\x01\x0e\x02\uffff\x01"+
            "\x0e\x07\uffff\x04\x0e\x18\uffff\x08\x0e",
            "",
            "",
            "",
            "\x01\x12\x01\uffff\x01\x1e\x04\uffff\x01\x12",
            "",
            "",
            "\x01\x20\x02\uffff\x01\x1f",
            "\x01\x20\x02\uffff\x01\x1f",
            "\x01\x20\x02\uffff\x01\x1f",
            "\x01\x20\x02\uffff\x01\x1f",
            "\x01\x20\x02\uffff\x01\x1f",
            "\x01\x20\x02\uffff\x01\x1f",
            "\x01\x20\x02\uffff\x01\x1f",
            "\x01\x20\x02\uffff\x01\x1f",
            "\x01\x20\x02\uffff\x01\x1f",
            "\x01\x20\x02\uffff\x01\x1f",
            "",
            "",
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
            get { return "286:1: declaration : ( variable | funcDecl | kernel_variable | kernel_array | kernel_local_variable | include | define | main | statement | kf= kernel_function );"; }
        }

    }

    const string DFA3_eotS =
        "\x0d\uffff";
    const string DFA3_eofS =
        "\x0d\uffff";
    const string DFA3_minS =
        "\x01\x16\x0a\x04\x02\uffff";
    const string DFA3_maxS =
        "\x01\x2b\x0a\x07\x02\uffff";
    const string DFA3_acceptS =
        "\x0b\uffff\x01\x01\x01\x02";
    const string DFA3_specialS =
        "\x0d\uffff}>";
    static readonly string[] DFA3_transitionS = {
            "\x01\x01\x01\x02\x0c\uffff\x01\x03\x01\x04\x01\x05\x01\x06"+
            "\x01\x07\x01\x08\x01\x09\x01\x0a",
            "\x01\x0b\x02\uffff\x01\x0c",
            "\x01\x0b\x02\uffff\x01\x0c",
            "\x01\x0b\x02\uffff\x01\x0c",
            "\x01\x0b\x02\uffff\x01\x0c",
            "\x01\x0b\x02\uffff\x01\x0c",
            "\x01\x0b\x02\uffff\x01\x0c",
            "\x01\x0b\x02\uffff\x01\x0c",
            "\x01\x0b\x02\uffff\x01\x0c",
            "\x01\x0b\x02\uffff\x01\x0c",
            "\x01\x0b\x02\uffff\x01\x0c",
            "",
            ""
    };

    static readonly short[] DFA3_eot = DFA.UnpackEncodedString(DFA3_eotS);
    static readonly short[] DFA3_eof = DFA.UnpackEncodedString(DFA3_eofS);
    static readonly char[] DFA3_min = DFA.UnpackEncodedStringToUnsignedChars(DFA3_minS);
    static readonly char[] DFA3_max = DFA.UnpackEncodedStringToUnsignedChars(DFA3_maxS);
    static readonly short[] DFA3_accept = DFA.UnpackEncodedString(DFA3_acceptS);
    static readonly short[] DFA3_special = DFA.UnpackEncodedString(DFA3_specialS);
    static readonly short[][] DFA3_transition = DFA.UnpackEncodedStringArray(DFA3_transitionS);

    protected class DFA3 : DFA
    {
        public DFA3(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 3;
            this.eot = DFA3_eot;
            this.eof = DFA3_eof;
            this.min = DFA3_min;
            this.max = DFA3_max;
            this.accept = DFA3_accept;
            this.special = DFA3_special;
            this.transition = DFA3_transition;

        }

        override public string Description
        {
            get { return "320:1: variable : ( type declarator ';' -> {$function.Count>0 && $function::name==null}? globalVariable(type=$type.stname=$declarator.st) -> variable(type=$type.stname=$declarator.st) | type arraydeclarator ';' -> {$function.Count>0 && $function::name==null}? globalVariable(type=$type.stname=$arraydeclarator.st) -> variable(type=$type.stname=$arraydeclarator.st));"; }
        }

    }

    const string DFA4_eotS =
        "\x0d\uffff";
    const string DFA4_eofS =
        "\x0d\uffff";
    const string DFA4_minS =
        "\x01\x16\x0a\x04\x02\uffff";
    const string DFA4_maxS =
        "\x01\x2b\x0a\x07\x02\uffff";
    const string DFA4_acceptS =
        "\x0b\uffff\x01\x01\x01\x02";
    const string DFA4_specialS =
        "\x0d\uffff}>";
    static readonly string[] DFA4_transitionS = {
            "\x01\x01\x01\x02\x0c\uffff\x01\x03\x01\x04\x01\x05\x01\x06"+
            "\x01\x07\x01\x08\x01\x09\x01\x0a",
            "\x01\x0b\x02\uffff\x01\x0c",
            "\x01\x0b\x02\uffff\x01\x0c",
            "\x01\x0b\x02\uffff\x01\x0c",
            "\x01\x0b\x02\uffff\x01\x0c",
            "\x01\x0b\x02\uffff\x01\x0c",
            "\x01\x0b\x02\uffff\x01\x0c",
            "\x01\x0b\x02\uffff\x01\x0c",
            "\x01\x0b\x02\uffff\x01\x0c",
            "\x01\x0b\x02\uffff\x01\x0c",
            "\x01\x0b\x02\uffff\x01\x0c",
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
            get { return "331:2: kvariable : ( type kdecl ';' -> {$function.Count>0 && $function::name==null}? globalVariable(type=$type.stname=\"gpu_\"+$kdecl.st) -> variable(type=$type.stname=\"gpu_\"+$kdecl.st) | type arraydeclarator ';' -> {$function.Count>0 && $function::name==null}? globalVariable(type=$type.stname=\"gpu_\"+$arraydeclarator.st) -> variable(type=$type.stname=\"gpu_\"+$arraydeclarator.st));"; }
        }

    }

    const string DFA13_eotS =
        "\x0f\uffff";
    const string DFA13_eofS =
        "\x0f\uffff";
    const string DFA13_minS =
        "\x0b\x09\x01\uffff\x01\x14\x02\uffff";
    const string DFA13_maxS =
        "\x01\x2b\x0a\x09\x01\uffff\x01\x15\x02\uffff";
    const string DFA13_acceptS =
        "\x0b\uffff\x01\x03\x01\uffff\x01\x01\x01\x02";
    const string DFA13_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA13_transitionS = {
            "\x01\x0b\x0c\uffff\x01\x01\x01\x02\x0c\uffff\x01\x03\x01\x04"+
            "\x01\x05\x01\x06\x01\x07\x01\x08\x01\x09\x01\x0a",
            "\x01\x0c",
            "\x01\x0c",
            "\x01\x0c",
            "\x01\x0c",
            "\x01\x0c",
            "\x01\x0c",
            "\x01\x0c",
            "\x01\x0c",
            "\x01\x0c",
            "\x01\x0c",
            "",
            "\x01\x0d\x01\x0e",
            "",
            ""
    };

    static readonly short[] DFA13_eot = DFA.UnpackEncodedString(DFA13_eotS);
    static readonly short[] DFA13_eof = DFA.UnpackEncodedString(DFA13_eofS);
    static readonly char[] DFA13_min = DFA.UnpackEncodedStringToUnsignedChars(DFA13_minS);
    static readonly char[] DFA13_max = DFA.UnpackEncodedStringToUnsignedChars(DFA13_maxS);
    static readonly short[] DFA13_accept = DFA.UnpackEncodedString(DFA13_acceptS);
    static readonly short[] DFA13_special = DFA.UnpackEncodedString(DFA13_specialS);
    static readonly short[][] DFA13_transition = DFA.UnpackEncodedStringArray(DFA13_transitionS);

    protected class DFA13 : DFA
    {
        public DFA13(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 13;
            this.eot = DFA13_eot;
            this.eof = DFA13_eof;
            this.min = DFA13_min;
            this.max = DFA13_max;
            this.accept = DFA13_accept;
            this.special = DFA13_special;
            this.transition = DFA13_transition;

        }

        override public string Description
        {
            get { return "351:1: main : ( type mdeclarator '()' mblock -> main(type=$type.stname=$mdeclarator.st) | type mdeclarator '(' ( ( 'int' | 'char' ) ( '*' )* declarator ( '[]' )* ) ( ( ',' ) ( ( 'int' | 'char' ) ( '*' )* declarator ( '[]' )* ) )* ')' mblock -> maint(type=$type.stname=$mdeclarator.st) | mdeclarator '()' mblock -> main(type=\"\"name=$mdeclarator.st));"; }
        }

    }

    const string DFA17_eotS =
        "\x0f\uffff";
    const string DFA17_eofS =
        "\x0f\uffff";
    const string DFA17_minS =
        "\x01\x16\x0a\x04\x01\x15\x01\x16\x02\uffff";
    const string DFA17_maxS =
        "\x01\x2b\x0a\x04\x01\x15\x01\x2b\x02\uffff";
    const string DFA17_acceptS =
        "\x0d\uffff\x01\x02\x01\x01";
    const string DFA17_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA17_transitionS = {
            "\x01\x01\x01\x02\x0c\uffff\x01\x03\x01\x04\x01\x05\x01\x06"+
            "\x01\x07\x01\x08\x01\x09\x01\x0a",
            "\x01\x0b",
            "\x01\x0b",
            "\x01\x0b",
            "\x01\x0b",
            "\x01\x0b",
            "\x01\x0b",
            "\x01\x0b",
            "\x01\x0b",
            "\x01\x0b",
            "\x01\x0b",
            "\x01\x0c",
            "\x02\x0e\x03\uffff\x01\x0e\x02\uffff\x01\x0d\x05\uffff\x08"+
            "\x0e",
            "",
            ""
    };

    static readonly short[] DFA17_eot = DFA.UnpackEncodedString(DFA17_eotS);
    static readonly short[] DFA17_eof = DFA.UnpackEncodedString(DFA17_eofS);
    static readonly char[] DFA17_min = DFA.UnpackEncodedStringToUnsignedChars(DFA17_minS);
    static readonly char[] DFA17_max = DFA.UnpackEncodedStringToUnsignedChars(DFA17_maxS);
    static readonly short[] DFA17_accept = DFA.UnpackEncodedString(DFA17_acceptS);
    static readonly short[] DFA17_special = DFA.UnpackEncodedString(DFA17_specialS);
    static readonly short[][] DFA17_transition = DFA.UnpackEncodedStringArray(DFA17_transitionS);

    protected class DFA17 : DFA
    {
        public DFA17(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 17;
            this.eot = DFA17_eot;
            this.eof = DFA17_eof;
            this.min = DFA17_min;
            this.max = DFA17_max;
            this.accept = DFA17_accept;
            this.special = DFA17_special;
            this.transition = DFA17_transition;

        }

        override public string Description
        {
            get { return "386:1: funcDecl : ( type ID '(' (p+= formalParameter ( ',' p+= formalParameter )* )? ')' ';' -> type(name=$type.st + $ID.text + \"(\"+ $p +\");\") | type ID '(' ');' -> type(name=$type.st + $ID.text + \"(\"+\");\"));"; }
        }

    }

    const string DFA26_eotS =
        "\x0d\uffff";
    const string DFA26_eofS =
        "\x0d\uffff";
    const string DFA26_minS =
        "\x01\x16\x0a\x04\x02\uffff";
    const string DFA26_maxS =
        "\x01\x2b\x0a\x1b\x02\uffff";
    const string DFA26_acceptS =
        "\x0b\uffff\x01\x02\x01\x01";
    const string DFA26_specialS =
        "\x0d\uffff}>";
    static readonly string[] DFA26_transitionS = {
            "\x01\x01\x01\x02\x0c\uffff\x01\x03\x01\x04\x01\x05\x01\x06"+
            "\x01\x07\x01\x08\x01\x09\x01\x0a",
            "\x01\x0c\x02\uffff\x01\x0b\x12\uffff\x02\x0c",
            "\x01\x0c\x02\uffff\x01\x0b\x12\uffff\x02\x0c",
            "\x01\x0c\x02\uffff\x01\x0b\x12\uffff\x02\x0c",
            "\x01\x0c\x02\uffff\x01\x0b\x12\uffff\x02\x0c",
            "\x01\x0c\x02\uffff\x01\x0b\x12\uffff\x02\x0c",
            "\x01\x0c\x02\uffff\x01\x0b\x12\uffff\x02\x0c",
            "\x01\x0c\x02\uffff\x01\x0b\x12\uffff\x02\x0c",
            "\x01\x0c\x02\uffff\x01\x0b\x12\uffff\x02\x0c",
            "\x01\x0c\x02\uffff\x01\x0b\x12\uffff\x02\x0c",
            "\x01\x0c\x02\uffff\x01\x0b\x12\uffff\x02\x0c",
            "",
            ""
    };

    static readonly short[] DFA26_eot = DFA.UnpackEncodedString(DFA26_eotS);
    static readonly short[] DFA26_eof = DFA.UnpackEncodedString(DFA26_eofS);
    static readonly char[] DFA26_min = DFA.UnpackEncodedStringToUnsignedChars(DFA26_minS);
    static readonly char[] DFA26_max = DFA.UnpackEncodedStringToUnsignedChars(DFA26_maxS);
    static readonly short[] DFA26_accept = DFA.UnpackEncodedString(DFA26_acceptS);
    static readonly short[] DFA26_special = DFA.UnpackEncodedString(DFA26_specialS);
    static readonly short[][] DFA26_transition = DFA.UnpackEncodedStringArray(DFA26_transitionS);

    protected class DFA26 : DFA
    {
        public DFA26(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 26;
            this.eot = DFA26_eot;
            this.eof = DFA26_eof;
            this.min = DFA26_min;
            this.max = DFA26_max;
            this.accept = DFA26_accept;
            this.special = DFA26_special;
            this.transition = DFA26_transition;

        }

        override public string Description
        {
            get { return "446:1: formalParameter : ( type ( declarator )* -> parameter(type=$type.stname=$declarator.st) | type arraydeclarator -> parameter(type=$type.stname=$arraydeclarator.st));"; }
        }

    }

    const string DFA42_eotS =
        "\x26\uffff";
    const string DFA42_eofS =
        "\x26\uffff";
    const string DFA42_minS =
        "\x01\x04\x01\uffff\x02\x13\x07\uffff\x01\x04\x02\uffff\x03\x15"+
        "\x01\uffff\x05\x04\x0f\x15";
    const string DFA42_maxS =
        "\x01\x44\x01\uffff\x02\x43\x07\uffff\x01\x44\x02\uffff\x03\x43"+
        "\x01\uffff\x05\x44\x0f\x43";
    const string DFA42_acceptS =
        "\x01\uffff\x01\x01\x02\uffff\x01\x03\x01\x04\x01\x06\x01\x07\x01"+
        "\x08\x01\x09\x01\x0b\x01\uffff\x01\x02\x01\x05\x03\uffff\x01\x0a"+
        "\x14\uffff";
    const string DFA42_specialS =
        "\x26\uffff}>";
    static readonly string[] DFA42_transitionS = {
            "\x01\x02\x01\x04\x01\uffff\x01\x03\x01\x04\x01\uffff\x01\x06"+
            "\x01\uffff\x01\x04\x06\uffff\x01\x0a\x01\uffff\x01\x04\x06\uffff"+
            "\x01\x05\x0f\uffff\x01\x01\x03\uffff\x02\x06\x01\uffff\x01\x09"+
            "\x02\x08\x03\x07\x0b\uffff\x01\x04",
            "",
            "\x01\x04\x01\x0c\x01\x0b\x02\uffff\x01\x04\x07\uffff\x04\x04"+
            "\x09\uffff\x03\x0d\x0c\uffff\x08\x04",
            "\x01\x04\x01\uffff\x01\x04\x02\uffff\x01\x04\x07\uffff\x04"+
            "\x04\x09\uffff\x03\x0d\x0c\uffff\x08\x04",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0e\x01\x10\x01\uffff\x01\x0f\x01\x04\x03\uffff\x01\x04"+
            "\x08\uffff\x01\x04\x02\x0c\x03\uffff\x01\x0c\x02\uffff\x01\x11"+
            "\x05\uffff\x08\x0c\x18\uffff\x01\x04",
            "",
            "",
            "\x01\x04\x02\uffff\x01\x15\x01\uffff\x01\x11\x01\x04\x02\uffff"+
            "\x01\x11\x01\uffff\x01\x12\x01\x13\x01\x14\x01\x16\x18\uffff"+
            "\x08\x04",
            "\x01\x04\x02\uffff\x01\x15\x01\uffff\x01\x11\x01\x04\x02\uffff"+
            "\x01\x11\x01\uffff\x01\x12\x01\x13\x01\x14\x01\x16\x18\uffff"+
            "\x08\x04",
            "\x01\x04\x02\uffff\x01\x15\x01\uffff\x01\x11\x01\x04\x02\uffff"+
            "\x01\x11\x01\uffff\x01\x12\x01\x13\x01\x14\x01\x16\x18\uffff"+
            "\x08\x04",
            "",
            "\x01\x17\x01\x19\x01\uffff\x01\x18\x01\x04\x03\uffff\x01\x04"+
            "\x08\uffff\x01\x04\x2e\uffff\x01\x04",
            "\x01\x1a\x01\x1c\x01\uffff\x01\x1b\x01\x04\x03\uffff\x01\x04"+
            "\x08\uffff\x01\x04\x2e\uffff\x01\x04",
            "\x01\x1d\x01\x1f\x01\uffff\x01\x1e\x01\x04\x03\uffff\x01\x04"+
            "\x08\uffff\x01\x04\x2e\uffff\x01\x04",
            "\x01\x20\x01\x22\x01\uffff\x01\x21\x01\x04\x03\uffff\x01\x04"+
            "\x08\uffff\x01\x04\x2e\uffff\x01\x04",
            "\x01\x23\x01\x25\x01\uffff\x01\x24\x01\x04\x03\uffff\x01\x04"+
            "\x08\uffff\x01\x04\x2e\uffff\x01\x04",
            "\x01\x04\x02\uffff\x01\x15\x01\uffff\x01\x11\x01\x04\x02\uffff"+
            "\x01\x11\x01\uffff\x01\x12\x01\x13\x01\x14\x01\x16\x18\uffff"+
            "\x08\x04",
            "\x01\x04\x02\uffff\x01\x15\x01\uffff\x01\x11\x01\x04\x02\uffff"+
            "\x01\x11\x01\uffff\x01\x12\x01\x13\x01\x14\x01\x16\x18\uffff"+
            "\x08\x04",
            "\x01\x04\x02\uffff\x01\x15\x01\uffff\x01\x11\x01\x04\x02\uffff"+
            "\x01\x11\x01\uffff\x01\x12\x01\x13\x01\x14\x01\x16\x18\uffff"+
            "\x08\x04",
            "\x01\x04\x02\uffff\x01\x15\x01\uffff\x01\x11\x01\x04\x02\uffff"+
            "\x01\x11\x02\uffff\x01\x13\x01\x14\x01\x16\x18\uffff\x08\x04",
            "\x01\x04\x02\uffff\x01\x15\x01\uffff\x01\x11\x01\x04\x02\uffff"+
            "\x01\x11\x02\uffff\x01\x13\x01\x14\x01\x16\x18\uffff\x08\x04",
            "\x01\x04\x02\uffff\x01\x15\x01\uffff\x01\x11\x01\x04\x02\uffff"+
            "\x01\x11\x02\uffff\x01\x13\x01\x14\x01\x16\x18\uffff\x08\x04",
            "\x01\x04\x02\uffff\x01\x15\x01\uffff\x01\x11\x01\x04\x02\uffff"+
            "\x01\x11\x03\uffff\x01\x14\x01\x16\x18\uffff\x08\x04",
            "\x01\x04\x02\uffff\x01\x15\x01\uffff\x01\x11\x01\x04\x02\uffff"+
            "\x01\x11\x03\uffff\x01\x14\x01\x16\x18\uffff\x08\x04",
            "\x01\x04\x02\uffff\x01\x15\x01\uffff\x01\x11\x01\x04\x02\uffff"+
            "\x01\x11\x03\uffff\x01\x14\x01\x16\x18\uffff\x08\x04",
            "\x01\x04\x02\uffff\x01\x15\x01\uffff\x01\x11\x01\x04\x02\uffff"+
            "\x01\x11\x04\uffff\x01\x16\x18\uffff\x08\x04",
            "\x01\x04\x02\uffff\x01\x15\x01\uffff\x01\x11\x01\x04\x02\uffff"+
            "\x01\x11\x04\uffff\x01\x16\x18\uffff\x08\x04",
            "\x01\x04\x02\uffff\x01\x15\x01\uffff\x01\x11\x01\x04\x02\uffff"+
            "\x01\x11\x04\uffff\x01\x16\x18\uffff\x08\x04",
            "\x01\x04\x04\uffff\x01\x11\x01\x04\x02\uffff\x01\x11\x04\uffff"+
            "\x01\x16\x18\uffff\x08\x04",
            "\x01\x04\x04\uffff\x01\x11\x01\x04\x02\uffff\x01\x11\x04\uffff"+
            "\x01\x16\x18\uffff\x08\x04",
            "\x01\x04\x04\uffff\x01\x11\x01\x04\x02\uffff\x01\x11\x04\uffff"+
            "\x01\x16\x18\uffff\x08\x04"
    };

    static readonly short[] DFA42_eot = DFA.UnpackEncodedString(DFA42_eotS);
    static readonly short[] DFA42_eof = DFA.UnpackEncodedString(DFA42_eofS);
    static readonly char[] DFA42_min = DFA.UnpackEncodedStringToUnsignedChars(DFA42_minS);
    static readonly char[] DFA42_max = DFA.UnpackEncodedStringToUnsignedChars(DFA42_maxS);
    static readonly short[] DFA42_accept = DFA.UnpackEncodedString(DFA42_acceptS);
    static readonly short[] DFA42_special = DFA.UnpackEncodedString(DFA42_specialS);
    static readonly short[][] DFA42_transition = DFA.UnpackEncodedStringArray(DFA42_transitionS);

    protected class DFA42 : DFA
    {
        public DFA42(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 42;
            this.eot = DFA42_eot;
            this.eof = DFA42_eof;
            this.min = DFA42_min;
            this.max = DFA42_max;
            this.accept = DFA42_accept;
            this.special = DFA42_special;
            this.transition = DFA42_transition;

        }

        override public string Description
        {
            get { return "514:1: stat : ( forStat -> {$forStat.st} | func_call ';' -> {$func_call.st} | expr ';' -> statement(expr=$expr.st) | block -> statementList(locals=$slist::localsstats=$slist::stats) | assignStat ';' -> {$assignStat.st} | print_statement ';' -> {$print_statement.st} | selection_statement -> {$selection_statement.st} | while_statement -> {$while_statement.st} | return_statement ';' -> {$return_statement.st} | func_call2 -> {$func_call2.st} | ';' -> {new StringTemplate(\";\")});"; }
        }

    }

    const string DFA43_eotS =
        "\x31\uffff";
    const string DFA43_eofS =
        "\x31\uffff";
    const string DFA43_minS =
        "\x01\x04\x02\x2d\x01\x04\x02\uffff\x01\x04\x02\uffff\x01\x13\x01"+
        "\uffff\x01\x13\x01\uffff\x01\x04\x01\x13\x01\x04\x01\uffff\x0a\x04"+
        "\x01\x13\x02\uffff\x01\x04\x01\x16\x01\x1a\x0d\x04\x01\x1a\x02\x04";
    const string DFA43_maxS =
        "\x01\x07\x02\x2f\x01\x44\x02\uffff\x01\x44\x02\uffff\x01\x43\x01"+
        "\uffff\x01\x43\x01\uffff\x01\x44\x01\x23\x01\x44\x01\uffff\x0a\x1b"+
        "\x01\x23\x02\uffff\x01\x1b\x01\x2b\x01\x1b\x01\x2b\x0d\x1b\x01\x2b"+
        "\x01\x1b";
    const string DFA43_acceptS =
        "\x04\uffff\x01\x03\x01\x05\x01\uffff\x01\x04\x01\x06\x01\uffff"+
        "\x01\x01\x01\uffff\x01\x02\x03\uffff\x01\x09\x0b\uffff\x01\x08\x01"+
        "\x07\x13\uffff";
    const string DFA43_specialS =
        "\x31\uffff}>";
    static readonly string[] DFA43_transitionS = {
            "\x01\x01\x02\uffff\x01\x02",
            "\x01\x03\x01\x04\x01\x05",
            "\x01\x06\x01\x07\x01\x08",
            "\x01\x09\x01\x0a\x01\uffff\x02\x0a\x03\uffff\x01\x0a\x08\uffff"+
            "\x01\x0a\x2e\uffff\x01\x0a",
            "",
            "",
            "\x01\x0b\x01\x0c\x01\uffff\x02\x0c\x03\uffff\x01\x0c\x08\uffff"+
            "\x01\x0c\x2e\uffff\x01\x0c",
            "",
            "",
            "\x01\x0a\x01\x0e\x01\x0d\x02\uffff\x01\x0a\x07\uffff\x04\x0a"+
            "\x18\uffff\x08\x0a",
            "",
            "\x01\x0c\x01\x10\x01\x0f\x02\uffff\x01\x0c\x07\uffff\x04\x0c"+
            "\x18\uffff\x08\x0c",
            "",
            "\x02\x0a\x01\uffff\x02\x0a\x03\uffff\x01\x0a\x08\uffff\x01"+
            "\x0a\x01\x11\x01\x12\x03\uffff\x01\x1b\x08\uffff\x01\x13\x01"+
            "\x14\x01\x15\x01\x16\x01\x17\x01\x18\x01\x19\x01\x1a\x18\uffff"+
            "\x01\x0a",
            "\x01\x1d\x0f\uffff\x01\x1c",
            "\x02\x0c\x01\uffff\x02\x0c\x03\uffff\x01\x0c\x08\uffff\x01"+
            "\x0c\x02\x10\x03\uffff\x01\x10\x08\uffff\x08\x10\x18\uffff\x01"+
            "\x0c",
            "",
            "\x01\x1e\x02\uffff\x01\x20\x12\uffff\x01\x1f\x01\x1b",
            "\x01\x1e\x02\uffff\x01\x20\x12\uffff\x01\x1f\x01\x1b",
            "\x01\x1e\x02\uffff\x01\x20\x12\uffff\x01\x1f\x01\x1b",
            "\x01\x1e\x02\uffff\x01\x20\x12\uffff\x01\x1f\x01\x1b",
            "\x01\x1e\x02\uffff\x01\x20\x12\uffff\x01\x1f\x01\x1b",
            "\x01\x1e\x02\uffff\x01\x20\x12\uffff\x01\x1f\x01\x1b",
            "\x01\x1e\x02\uffff\x01\x20\x12\uffff\x01\x1f\x01\x1b",
            "\x01\x1e\x02\uffff\x01\x20\x12\uffff\x01\x1f\x01\x1b",
            "\x01\x1e\x02\uffff\x01\x20\x12\uffff\x01\x1f\x01\x1b",
            "\x01\x1e\x02\uffff\x01\x20\x12\uffff\x01\x1f\x01\x1b",
            "\x01\x1d\x0f\uffff\x01\x1c",
            "",
            "",
            "\x01\x1e\x15\uffff\x01\x21\x01\x1b",
            "\x01\x22\x01\x23\x0c\uffff\x01\x24\x01\x25\x01\x26\x01\x27"+
            "\x01\x28\x01\x29\x01\x2a\x01\x2b",
            "\x01\x1f\x01\x1b",
            "\x01\x2c\x11\uffff\x01\x22\x01\x23\x0c\uffff\x01\x24\x01\x25"+
            "\x01\x26\x01\x27\x01\x28\x01\x29\x01\x2a\x01\x2b",
            "\x01\x2d\x02\uffff\x01\x2e\x12\uffff\x01\x1f\x01\x1b",
            "\x01\x2d\x02\uffff\x01\x2e\x12\uffff\x01\x1f\x01\x1b",
            "\x01\x2d\x02\uffff\x01\x2e\x12\uffff\x01\x1f\x01\x1b",
            "\x01\x2d\x02\uffff\x01\x2e\x12\uffff\x01\x1f\x01\x1b",
            "\x01\x2d\x02\uffff\x01\x2e\x12\uffff\x01\x1f\x01\x1b",
            "\x01\x2d\x02\uffff\x01\x2e\x12\uffff\x01\x1f\x01\x1b",
            "\x01\x2d\x02\uffff\x01\x2e\x12\uffff\x01\x1f\x01\x1b",
            "\x01\x2d\x02\uffff\x01\x2e\x12\uffff\x01\x1f\x01\x1b",
            "\x01\x2d\x02\uffff\x01\x2e\x12\uffff\x01\x1f\x01\x1b",
            "\x01\x2d\x02\uffff\x01\x2e\x12\uffff\x01\x1f\x01\x1b",
            "\x01\x1e\x15\uffff\x01\x21\x01\x1b",
            "\x01\x2d\x15\uffff\x01\x2f\x01\x1b",
            "\x01\x1f\x01\x1b",
            "\x01\x30\x11\uffff\x01\x22\x01\x23\x0c\uffff\x01\x24\x01\x25"+
            "\x01\x26\x01\x27\x01\x28\x01\x29\x01\x2a\x01\x2b",
            "\x01\x2d\x15\uffff\x01\x2f\x01\x1b"
    };

    static readonly short[] DFA43_eot = DFA.UnpackEncodedString(DFA43_eotS);
    static readonly short[] DFA43_eof = DFA.UnpackEncodedString(DFA43_eofS);
    static readonly char[] DFA43_min = DFA.UnpackEncodedStringToUnsignedChars(DFA43_minS);
    static readonly char[] DFA43_max = DFA.UnpackEncodedStringToUnsignedChars(DFA43_maxS);
    static readonly short[] DFA43_accept = DFA.UnpackEncodedString(DFA43_acceptS);
    static readonly short[] DFA43_special = DFA.UnpackEncodedString(DFA43_specialS);
    static readonly short[][] DFA43_transition = DFA.UnpackEncodedStringArray(DFA43_transitionS);

    protected class DFA43 : DFA
    {
        public DFA43(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 43;
            this.eot = DFA43_eot;
            this.eof = DFA43_eof;
            this.min = DFA43_min;
            this.max = DFA43_max;
            this.accept = DFA43_accept;
            this.special = DFA43_special;
            this.transition = DFA43_transition;

        }

        override public string Description
        {
            get { return "558:1: assignStat : ( ID '=' expr -> assign(lhs=$ID.textrhs=$expr.st) | ARRAY '=' expr -> assign(lhs=$ARRAY.textrhs=$expr.st) | ID '-=' expr -> assignop(lhs=$ID.textrhs=$expr.stop=\"-=\") | ARRAY '-=' expr -> assignop(lhs=$ARRAY.textrhs=$expr.stop=\"-=\") | ID '+=' expr -> assignop(lhs=$ID.textrhs=$expr.stop=\"+=\") | ARRAY '+=' expr -> assignop(lhs=$ARRAY.textrhs=$expr.stop=\"+=\") | ID '=' func_call -> assignop(lhs=$ID.textrhs=$func_call.stop=\"=\") | ID '=' func_call '%' expr -> assignop(lhs=$ID.textrhs=$func_call.st + \"\\%\" + $expr.stop=\"=\") | ARRAY '=' func_call '%' expr -> assignop(lhs=$ARRAY.textrhs=$func_call.st + \"\\%\" + $expr.stop=\"=\"));"; }
        }

    }

    const string DFA70_eotS =
        "\x0e\uffff";
    const string DFA70_eofS =
        "\x0e\uffff";
    const string DFA70_minS =
        "\x01\x04\x01\uffff\x01\x13\x01\uffff\x01\x13\x09\uffff";
    const string DFA70_maxS =
        "\x01\x4b\x01\uffff\x01\x47\x01\uffff\x01\x43\x09\uffff";
    const string DFA70_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x02\x01\uffff\x01\x03\x01\x05"+
        "\x01\x06\x01\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x04";
    const string DFA70_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA70_transitionS = {
            "\x01\x02\x01\x03\x01\uffff\x01\x04\x0b\uffff\x01\x0c\x01\uffff"+
            "\x01\x03\x02\x0b\x04\uffff\x01\x05\x07\uffff\x08\x0b\x01\x01"+
            "\x04\uffff\x01\x07\x01\uffff\x01\x09\x01\x08\x01\uffff\x03\x06"+
            "\x0b\uffff\x02\x03\x01\x0a\x04\uffff\x01\x07",
            "",
            "\x01\x03\x01\uffff\x01\x0a\x02\uffff\x01\x03\x07\uffff\x04"+
            "\x03\x09\uffff\x03\x0d\x0c\uffff\x08\x03\x03\uffff\x01\x0a",
            "",
            "\x01\x03\x04\uffff\x01\x03\x07\uffff\x04\x03\x09\uffff\x03"+
            "\x0d\x0c\uffff\x08\x03",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA70_eot = DFA.UnpackEncodedString(DFA70_eotS);
    static readonly short[] DFA70_eof = DFA.UnpackEncodedString(DFA70_eofS);
    static readonly char[] DFA70_min = DFA.UnpackEncodedStringToUnsignedChars(DFA70_minS);
    static readonly char[] DFA70_max = DFA.UnpackEncodedStringToUnsignedChars(DFA70_maxS);
    static readonly short[] DFA70_accept = DFA.UnpackEncodedString(DFA70_acceptS);
    static readonly short[] DFA70_special = DFA.UnpackEncodedString(DFA70_specialS);
    static readonly short[][] DFA70_transition = DFA.UnpackEncodedStringArray(DFA70_transitionS);

    protected class DFA70 : DFA
    {
        public DFA70(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 70;
            this.eot = DFA70_eot;
            this.eof = DFA70_eof;
            this.min = DFA70_min;
            this.max = DFA70_max;
            this.accept = DFA70_accept;
            this.special = DFA70_special;
            this.transition = DFA70_transition;

        }

        override public string Description
        {
            get { return "908:1: kstat : ( kforStat -> {$kforStat.st} | kexpr ';' -> statement(expr=$kexpr.st) | kkblock -> statementList(locals=$slist::localsstats=$slist::stats) | kassignStat ';' -> {$kassignStat.st} | kselection_statement -> {$kselection_statement.st} | kprint_statement ';' -> {$kprint_statement.st} | kwhile_statement -> {$kwhile_statement.st} | kreturn_statement ';' -> {$kreturn_statement.st} | kfunc_call -> {$kfunc_call.st} | kvariable -> {$kvariable.st} | ';' -> {new StringTemplate(\";\")});"; }
        }

    }

 

    public static readonly BitSet FOLLOW_declaration_in_program61 = new BitSet(new ulong[]{0x01FB1FF010E817B2UL,0x0000000000000310UL});
    public static readonly BitSet FOLLOW_variable_in_declaration157 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_funcDecl_in_declaration171 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_kernel_variable_in_declaration187 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_kernel_array_in_declaration199 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_kernel_local_variable_in_declaration211 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_include_in_declaration223 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_define_in_declaration235 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_main_in_declaration247 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_declaration260 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_kernel_function_in_declaration274 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_variable306 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_declarator_in_variable308 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_variable310 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_variable376 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_arraydeclarator_in_variable378 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_variable380 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_kvariable459 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_kdecl_in_kvariable461 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_kvariable463 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_kvariable529 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_arraydeclarator_in_kvariable531 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_kvariable533 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_stat_in_statement610 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_statement_list629 = new BitSet(new ulong[]{0x01FB1000102815B2UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_type_in_main654 = new BitSet(new ulong[]{0x00000FF000C00200UL});
    public static readonly BitSet FOLLOW_mdeclarator_in_main656 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_20_in_main658 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_mblock_in_main660 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_main682 = new BitSet(new ulong[]{0x00000FF000C00200UL});
    public static readonly BitSet FOLLOW_mdeclarator_in_main684 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_main686 = new BitSet(new ulong[]{0x0000000000C00000UL});
    public static readonly BitSet FOLLOW_22_in_main690 = new BitSet(new ulong[]{0x0000000001000010UL});
    public static readonly BitSet FOLLOW_23_in_main692 = new BitSet(new ulong[]{0x0000000001000010UL});
    public static readonly BitSet FOLLOW_24_in_main696 = new BitSet(new ulong[]{0x0000000001000010UL});
    public static readonly BitSet FOLLOW_declarator_in_main700 = new BitSet(new ulong[]{0x000000000E000000UL});
    public static readonly BitSet FOLLOW_25_in_main703 = new BitSet(new ulong[]{0x000000000E000000UL});
    public static readonly BitSet FOLLOW_26_in_main710 = new BitSet(new ulong[]{0x0000000000C00000UL});
    public static readonly BitSet FOLLOW_22_in_main715 = new BitSet(new ulong[]{0x0000000001000010UL});
    public static readonly BitSet FOLLOW_23_in_main717 = new BitSet(new ulong[]{0x0000000001000010UL});
    public static readonly BitSet FOLLOW_24_in_main721 = new BitSet(new ulong[]{0x0000000001000010UL});
    public static readonly BitSet FOLLOW_declarator_in_main725 = new BitSet(new ulong[]{0x000000000E000000UL});
    public static readonly BitSet FOLLOW_25_in_main728 = new BitSet(new ulong[]{0x000000000E000000UL});
    public static readonly BitSet FOLLOW_27_in_main736 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_mblock_in_main738 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mdeclarator_in_main758 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_20_in_main760 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_mblock_in_main762 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_28_in_mblock795 = new BitSet(new ulong[]{0x01FB1FF030E817B0UL,0x0000000000000310UL});
    public static readonly BitSet FOLLOW_declaration_in_mblock805 = new BitSet(new ulong[]{0x01FB1FF030E817B0UL,0x0000000000000310UL});
    public static readonly BitSet FOLLOW_29_in_mblock824 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_include845 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_kdeclarator_in_include847 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_funcDecl874 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_funcDecl876 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_funcDecl878 = new BitSet(new ulong[]{0x00000FF008C00000UL});
    public static readonly BitSet FOLLOW_formalParameter_in_funcDecl884 = new BitSet(new ulong[]{0x000000000C000000UL});
    public static readonly BitSet FOLLOW_26_in_funcDecl888 = new BitSet(new ulong[]{0x00000FF000C00000UL});
    public static readonly BitSet FOLLOW_formalParameter_in_funcDecl892 = new BitSet(new ulong[]{0x000000000C000000UL});
    public static readonly BitSet FOLLOW_27_in_funcDecl900 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_funcDecl901 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_funcDecl916 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_funcDecl918 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_funcDecl920 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_funcDecl922 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_rdeclarator_in_define943 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_declarator_in_define945 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_digits_in_define949 = new BitSet(new ulong[]{0x0000000080000002UL});
    public static readonly BitSet FOLLOW_31_in_define952 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_digits_in_define956 = new BitSet(new ulong[]{0x0000000080000002UL});
    public static readonly BitSet FOLLOW_ID_in_declarator994 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_declarator1007 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_26_in_declarator1010 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_declarator1014 = new BitSet(new ulong[]{0x0000000004000002UL});
    public static readonly BitSet FOLLOW_ID_in_kdecl1048 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_kdecl1061 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_26_in_kdecl1064 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_kdecl1068 = new BitSet(new ulong[]{0x0000000004000002UL});
    public static readonly BitSet FOLLOW_INT_in_digits1102 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Keyword_in_kdeclarator1126 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ARRAY_in_arraydeclarator1156 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RWORD_in_rdeclarator1183 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MAINS_in_mdeclarator1208 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_function1254 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_function1256 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_function1268 = new BitSet(new ulong[]{0x00000FF008C00000UL});
    public static readonly BitSet FOLLOW_formalParameter_in_function1274 = new BitSet(new ulong[]{0x000000000C000000UL});
    public static readonly BitSet FOLLOW_26_in_function1278 = new BitSet(new ulong[]{0x00000FF000C00000UL});
    public static readonly BitSet FOLLOW_formalParameter_in_function1282 = new BitSet(new ulong[]{0x000000000C000000UL});
    public static readonly BitSet FOLLOW_27_in_function1290 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_block_in_function1300 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_formalParameter1415 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_declarator_in_formalParameter1418 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_type_in_formalParameter1453 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_arraydeclarator_in_formalParameter1455 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_aftom_in_afexpr1500 = new BitSet(new ulong[]{0x0000000F01000002UL});
    public static readonly BitSet FOLLOW_32_in_afexpr1518 = new BitSet(new ulong[]{0x00000000000000B0UL});
    public static readonly BitSet FOLLOW_aftom_in_afexpr1522 = new BitSet(new ulong[]{0x0000000F01000002UL});
    public static readonly BitSet FOLLOW_33_in_afexpr1552 = new BitSet(new ulong[]{0x00000000000000B0UL});
    public static readonly BitSet FOLLOW_aftom_in_afexpr1556 = new BitSet(new ulong[]{0x0000000E01000002UL});
    public static readonly BitSet FOLLOW_34_in_afexpr1586 = new BitSet(new ulong[]{0x00000000000000B0UL});
    public static readonly BitSet FOLLOW_aftom_in_afexpr1590 = new BitSet(new ulong[]{0x0000000C01000002UL});
    public static readonly BitSet FOLLOW_24_in_afexpr1620 = new BitSet(new ulong[]{0x00000000000000B0UL});
    public static readonly BitSet FOLLOW_aftom_in_afexpr1624 = new BitSet(new ulong[]{0x0000000801000002UL});
    public static readonly BitSet FOLLOW_35_in_afexpr1654 = new BitSet(new ulong[]{0x00000000000000B0UL});
    public static readonly BitSet FOLLOW_aftom_in_afexpr1658 = new BitSet(new ulong[]{0x0000000800000002UL});
    public static readonly BitSet FOLLOW_ID_in_aftom1686 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ARRAY_in_aftom1704 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_aftom1721 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_kakftom_in_kakfexpr1747 = new BitSet(new ulong[]{0x0000000F01000002UL});
    public static readonly BitSet FOLLOW_32_in_kakfexpr1765 = new BitSet(new ulong[]{0x00000000000000B0UL});
    public static readonly BitSet FOLLOW_kakftom_in_kakfexpr1769 = new BitSet(new ulong[]{0x0000000F01000002UL});
    public static readonly BitSet FOLLOW_33_in_kakfexpr1799 = new BitSet(new ulong[]{0x00000000000000B0UL});
    public static readonly BitSet FOLLOW_kakftom_in_kakfexpr1803 = new BitSet(new ulong[]{0x0000000E01000002UL});
    public static readonly BitSet FOLLOW_34_in_kakfexpr1833 = new BitSet(new ulong[]{0x00000000000000B0UL});
    public static readonly BitSet FOLLOW_kakftom_in_kakfexpr1837 = new BitSet(new ulong[]{0x0000000C01000002UL});
    public static readonly BitSet FOLLOW_24_in_kakfexpr1867 = new BitSet(new ulong[]{0x00000000000000B0UL});
    public static readonly BitSet FOLLOW_kakftom_in_kakfexpr1871 = new BitSet(new ulong[]{0x0000000801000002UL});
    public static readonly BitSet FOLLOW_35_in_kakfexpr1901 = new BitSet(new ulong[]{0x00000000000000B0UL});
    public static readonly BitSet FOLLOW_kakftom_in_kakfexpr1905 = new BitSet(new ulong[]{0x0000000800000002UL});
    public static readonly BitSet FOLLOW_ID_in_kakftom1933 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ARRAY_in_kakftom1951 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_kakftom1968 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_22_in_type1995 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_23_in_type2014 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_type2032 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_type2049 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_type2066 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_type2082 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_type2102 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_41_in_type2122 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_type2138 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_type2167 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_28_in_block2205 = new BitSet(new ulong[]{0x01FB1FF030E815B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_block2217 = new BitSet(new ulong[]{0x01FB1FF030E815B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_stat_in_block2235 = new BitSet(new ulong[]{0x01FB1000302815B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_29_in_block2288 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forStat_in_stat2330 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_func_call_in_stat2342 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_stat2345 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_stat2364 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_stat2366 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_in_stat2383 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignStat_in_stat2405 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_stat2407 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_print_statement_in_stat2419 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_stat2421 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selection_statement_in_stat2433 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_while_statement_in_stat2446 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_return_statement_in_stat2459 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_stat2461 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_func_call2_in_stat2473 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_19_in_stat2501 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_forStat2536 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_forStat2538 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_assignStat_in_forStat2542 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_forStat2544 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_expr_in_forStat2548 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_forStat2550 = new BitSet(new ulong[]{0x0600000000000010UL});
    public static readonly BitSet FOLLOW_incStat_in_forStat2554 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_forStat2556 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_block_in_forStat2558 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_assignStat2633 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_assignStat2635 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_expr_in_assignStat2637 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ARRAY_in_assignStat2667 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_assignStat2669 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_expr_in_assignStat2671 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_assignStat2704 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_assignStat2706 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_expr_in_assignStat2708 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ARRAY_in_assignStat2736 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_assignStat2738 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_expr_in_assignStat2740 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_assignStat2768 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_assignStat2770 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_expr_in_assignStat2772 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ARRAY_in_assignStat2800 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_assignStat2802 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_expr_in_assignStat2804 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_assignStat2832 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_assignStat2834 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_func_call_in_assignStat2836 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_assignStat2865 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_assignStat2867 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_func_call_in_assignStat2869 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_35_in_assignStat2871 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_expr_in_assignStat2873 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ARRAY_in_assignStat2902 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_assignStat2904 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_func_call_in_assignStat2906 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_35_in_assignStat2908 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_expr_in_assignStat2910 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PRINT_in_print_statement2944 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_48_in_print_statement2967 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_print_statement2969 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_26_in_print_statement2971 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_print_statement2973 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_print_statement2975 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_48_in_print_statement2989 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_print_statement2991 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_26_in_print_statement2993 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_print_statement2995 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_26_in_print_statement3001 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_printfParameter_in_print_statement3003 = new BitSet(new ulong[]{0x000000000C000000UL});
    public static readonly BitSet FOLLOW_27_in_print_statement3011 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_49_in_print_statement3029 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_print_statement3031 = new BitSet(new ulong[]{0x01FB1000102815B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_statement_in_print_statement3033 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_aexpr_in_printfParameter3058 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_51_in_return_statement3098 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_digits_in_return_statement3100 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_51_in_return_statement3114 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_return_statement3116 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_51_in_return_statement3141 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_ARRAY_in_return_statement3143 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_51_in_return_statement3165 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_while_statement3195 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_while_statement3197 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_expr_in_while_statement3199 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_while_statement3201 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_block_in_while_statement3203 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_while_statement3256 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_block_in_while_statement3258 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_while_statement3260 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_while_statement3262 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_expr_in_while_statement3264 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_while_statement3266 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_selection_statement3318 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_selection_statement3320 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_condExpr_in_selection_statement3322 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_selection_statement3324 = new BitSet(new ulong[]{0x01FB1000102815B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_stat_in_selection_statement3326 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_selection_statement3342 = new BitSet(new ulong[]{0x01FB1000102815B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_stat_in_selection_statement3344 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_selection_statement3358 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_selection_statement3360 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_expr_in_selection_statement3362 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_selection_statement3364 = new BitSet(new ulong[]{0x01FB1000102815B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_stat_in_selection_statement3366 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_19_in_expression_statement3399 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_expression_statement3414 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_expression_statement3416 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_incStat3438 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_57_in_incStat3440 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_incStat3457 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_incStat3459 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_57_in_incStat3477 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_incStat3479 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_58_in_incStat3498 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_incStat3500 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_incStat3517 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_incStat3519 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_INT_in_incStat3521 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_incStat3537 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_incStat3539 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_INT_in_incStat3541 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_incStat3557 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_incStat3559 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_INT_in_incStat3561 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_condExpr_in_expr3588 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_aexpr_in_condExpr3637 = new BitSet(new ulong[]{0xF000000000200002UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_60_in_condExpr3654 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_aexpr_in_condExpr3658 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_61_in_condExpr3688 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_aexpr_in_condExpr3692 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_62_in_condExpr3722 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_aexpr_in_condExpr3726 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_63_in_condExpr3758 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_aexpr_in_condExpr3762 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_64_in_condExpr3794 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_aexpr_in_condExpr3798 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_condExpr3830 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_aexpr_in_condExpr3834 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_66_in_condExpr3866 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_aexpr_in_condExpr3870 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_67_in_condExpr3902 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_aexpr_in_condExpr3906 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_21_in_condExpr3986 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_condExpr_in_condExpr3988 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_condExpr3991 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_atom_in_aexpr4035 = new BitSet(new ulong[]{0x0000000F01000002UL});
    public static readonly BitSet FOLLOW_32_in_aexpr4052 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_atom_in_aexpr4056 = new BitSet(new ulong[]{0x0000000F01000002UL});
    public static readonly BitSet FOLLOW_33_in_aexpr4085 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_atom_in_aexpr4089 = new BitSet(new ulong[]{0x0000000E01000002UL});
    public static readonly BitSet FOLLOW_34_in_aexpr4118 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_atom_in_aexpr4122 = new BitSet(new ulong[]{0x0000000C01000002UL});
    public static readonly BitSet FOLLOW_24_in_aexpr4151 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_atom_in_aexpr4155 = new BitSet(new ulong[]{0x0000000801000002UL});
    public static readonly BitSet FOLLOW_35_in_aexpr4184 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_atom_in_aexpr4188 = new BitSet(new ulong[]{0x0000000800000002UL});
    public static readonly BitSet FOLLOW_ID_in_atom4236 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ARRAY_in_atom4254 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_atom4273 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RWORD_in_atom4290 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_21_in_atom4306 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_expr_in_atom4308 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_atom4310 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_68_in_atom4323 = new BitSet(new ulong[]{0x00000000002011B0UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_expr_in_atom4325 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_69_in_atom4327 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHARACTER_LITERAL_in_atom4339 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_func_call4399 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_func_call4401 = new BitSet(new ulong[]{0x00000FF008C00000UL});
    public static readonly BitSet FOLLOW_formalParameter_in_func_call4408 = new BitSet(new ulong[]{0x000000000C000000UL});
    public static readonly BitSet FOLLOW_26_in_func_call4413 = new BitSet(new ulong[]{0x00000FF000C00000UL});
    public static readonly BitSet FOLLOW_formalParameter_in_func_call4417 = new BitSet(new ulong[]{0x000000000C000000UL});
    public static readonly BitSet FOLLOW_27_in_func_call4425 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_func_call4439 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_20_in_func_call4441 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_func_call24465 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_func_call24467 = new BitSet(new ulong[]{0x00000000400000B0UL});
    public static readonly BitSet FOLLOW_afexpr_in_func_call24474 = new BitSet(new ulong[]{0x0000000044000000UL});
    public static readonly BitSet FOLLOW_26_in_func_call24479 = new BitSet(new ulong[]{0x00000000000000B0UL});
    public static readonly BitSet FOLLOW_afexpr_in_func_call24483 = new BitSet(new ulong[]{0x0000000044000000UL});
    public static readonly BitSet FOLLOW_30_in_func_call24491 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_kfunc_call4529 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_kfunc_call4531 = new BitSet(new ulong[]{0x00000000400000B0UL});
    public static readonly BitSet FOLLOW_kakfexpr_in_kfunc_call4538 = new BitSet(new ulong[]{0x0000000044000000UL});
    public static readonly BitSet FOLLOW_26_in_kfunc_call4543 = new BitSet(new ulong[]{0x00000000000000B0UL});
    public static readonly BitSet FOLLOW_kakfexpr_in_kfunc_call4547 = new BitSet(new ulong[]{0x0000000044000000UL});
    public static readonly BitSet FOLLOW_30_in_kfunc_call4555 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_70_in_kfunc_call4579 = new BitSet(new ulong[]{0x00000000400000B0UL});
    public static readonly BitSet FOLLOW_kakfexpr_in_kfunc_call4586 = new BitSet(new ulong[]{0x0000000044000000UL});
    public static readonly BitSet FOLLOW_26_in_kfunc_call4591 = new BitSet(new ulong[]{0x00000000000000B0UL});
    public static readonly BitSet FOLLOW_kakfexpr_in_kfunc_call4595 = new BitSet(new ulong[]{0x0000000044000000UL});
    public static readonly BitSet FOLLOW_30_in_kfunc_call4603 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_kfunc_call4623 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_71_in_kfunc_call4625 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_kernel_variable4648 = new BitSet(new ulong[]{0x00000FF000C00000UL});
    public static readonly BitSet FOLLOW_type_in_kernel_variable4650 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_declarator_in_kernel_variable4652 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_kernel_variable4654 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_72_in_kernel_local_variable4782 = new BitSet(new ulong[]{0x00000FF000C00000UL});
    public static readonly BitSet FOLLOW_type_in_kernel_local_variable4784 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_declarator_in_kernel_local_variable4786 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_kernel_local_variable4788 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_kernel_array4867 = new BitSet(new ulong[]{0x00000FF000C00000UL});
    public static readonly BitSet FOLLOW_type_in_kernel_array4869 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_arraydeclarator_in_kernel_array4871 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_kernel_array4873 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_73_in_kblock4961 = new BitSet(new ulong[]{0x01DA1FF010E800B0UL,0x0000000000000C70UL});
    public static readonly BitSet FOLLOW_kstat_in_kblock4982 = new BitSet(new ulong[]{0x01DA1FF010E800B0UL,0x0000000000000C70UL});
    public static readonly BitSet FOLLOW_74_in_kblock4995 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_kblock_in_kernel_function5038 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_kforStat_in_kstat5113 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_kexpr_in_kstat5126 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_kstat5128 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_kkblock_in_kstat5145 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_kassignStat_in_kstat5167 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_kstat5169 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_kselection_statement_in_kstat5185 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_kprint_statement_in_kstat5198 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_kstat5200 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_kwhile_statement_in_kstat5214 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_kreturn_statement_in_kstat5227 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_kstat5229 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_kfunc_call_in_kstat5241 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_kvariable_in_kstat5255 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_19_in_kstat5268 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_kforStat5305 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_kforStat5307 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_kassignStat_in_kforStat5311 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_kforStat5313 = new BitSet(new ulong[]{0x00000000002000B0UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_kexpr_in_kforStat5317 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_kforStat5319 = new BitSet(new ulong[]{0x0600000000000010UL});
    public static readonly BitSet FOLLOW_kincStat_in_kforStat5323 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_kforStat5325 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_kkblock_in_kforStat5327 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_kassignStat5373 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_kassignStat5375 = new BitSet(new ulong[]{0x00000000002000B0UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_kexpr_in_kassignStat5377 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ARRAY_in_kassignStat5418 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_kassignStat5420 = new BitSet(new ulong[]{0x00000000002000B0UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_kexpr_in_kassignStat5422 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_kassignStat5490 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_kassignStat5492 = new BitSet(new ulong[]{0x00000000002000B0UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_kexpr_in_kassignStat5494 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ARRAY_in_kassignStat5526 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_kassignStat5528 = new BitSet(new ulong[]{0x00000000002000B0UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_kexpr_in_kassignStat5530 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_kassignStat5567 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_kassignStat5569 = new BitSet(new ulong[]{0x00000000002000B0UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_kexpr_in_kassignStat5571 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ARRAY_in_kassignStat5604 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_kassignStat5606 = new BitSet(new ulong[]{0x00000000002000B0UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_kexpr_in_kassignStat5608 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_75_in_kprint_statement5660 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_kprint_statement5662 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_kprint_statement5664 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_75_in_kprint_statement5678 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_kprint_statement5680 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_26_in_kprint_statement5683 = new BitSet(new ulong[]{0x00000000002000B0UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_katom_in_kprint_statement5686 = new BitSet(new ulong[]{0x00000000082000B0UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_27_in_kprint_statement5690 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_49_in_kprint_statement5708 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_kprint_statement5710 = new BitSet(new ulong[]{0x01DA1FF010E800B0UL,0x0000000000000870UL});
    public static readonly BitSet FOLLOW_kstatement_in_kprint_statement5712 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_51_in_kreturn_statement5733 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_digits_in_kreturn_statement5735 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_51_in_kreturn_statement5749 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_kreturn_statement5751 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_51_in_kreturn_statement5776 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_ARRAY_in_kreturn_statement5778 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_kwhile_statement5810 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_kwhile_statement5812 = new BitSet(new ulong[]{0x00000000002000B0UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_kexpr_in_kwhile_statement5814 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_kwhile_statement5816 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_kkblock_in_kwhile_statement5818 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_kselection_statement5870 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_kselection_statement5872 = new BitSet(new ulong[]{0x00000000002000B0UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_kcondExpr_in_kselection_statement5874 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_kselection_statement5876 = new BitSet(new ulong[]{0x01DA1FF010E800B0UL,0x0000000000000870UL});
    public static readonly BitSet FOLLOW_kstat_in_kselection_statement5878 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_kselection_statement5894 = new BitSet(new ulong[]{0x01DA1FF010E800B0UL,0x0000000000000870UL});
    public static readonly BitSet FOLLOW_kstat_in_kselection_statement5896 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_kselection_statement5912 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_kselection_statement5914 = new BitSet(new ulong[]{0x00000000002000B0UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_kexpr_in_kselection_statement5916 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_kselection_statement5918 = new BitSet(new ulong[]{0x01DA1FF010E800B0UL,0x0000000000000870UL});
    public static readonly BitSet FOLLOW_kstatement_in_kselection_statement5920 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_kstat_in_kstatement5946 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_katom5967 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_katom6008 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_21_in_katom6025 = new BitSet(new ulong[]{0x00000000002000B0UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_kaexpr_in_katom6027 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_katom6029 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_68_in_katom6048 = new BitSet(new ulong[]{0x00000000002000B0UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_kaexpr_in_katom6050 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000001020UL});
    public static readonly BitSet FOLLOW_69_in_katom6053 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_76_in_katom6055 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_69_in_katom6068 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ARRAY_in_katom6087 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_kaexpr_in_kcondExpr6272 = new BitSet(new ulong[]{0xF000000000000002UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_60_in_kcondExpr6290 = new BitSet(new ulong[]{0x00000000002000B0UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_kaexpr_in_kcondExpr6294 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_61_in_kcondExpr6324 = new BitSet(new ulong[]{0x00000000002000B0UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_kaexpr_in_kcondExpr6328 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_62_in_kcondExpr6358 = new BitSet(new ulong[]{0x00000000002000B0UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_kaexpr_in_kcondExpr6362 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_63_in_kcondExpr6394 = new BitSet(new ulong[]{0x00000000002000B0UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_kaexpr_in_kcondExpr6398 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_64_in_kcondExpr6430 = new BitSet(new ulong[]{0x00000000002000B0UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_kaexpr_in_kcondExpr6434 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_kcondExpr6466 = new BitSet(new ulong[]{0x00000000002000B0UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_kaexpr_in_kcondExpr6470 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_66_in_kcondExpr6502 = new BitSet(new ulong[]{0x00000000002000B0UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_kaexpr_in_kcondExpr6506 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_67_in_kcondExpr6538 = new BitSet(new ulong[]{0x00000000002000B0UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_kaexpr_in_kcondExpr6542 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_kincStat6656 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_57_in_kincStat6658 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_kincStat6675 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_kincStat6677 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_57_in_kincStat6695 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_kincStat6697 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_58_in_kincStat6716 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_kincStat6718 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_kincStat6735 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_kincStat6737 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_INT_in_kincStat6739 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_kincStat6755 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_kincStat6757 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_INT_in_kincStat6759 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_kincStat6775 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_kincStat6777 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_INT_in_kincStat6779 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_kcondExpr_in_kexpr6803 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_katom_in_kaexpr6829 = new BitSet(new ulong[]{0x0000000F01000002UL});
    public static readonly BitSet FOLLOW_32_in_kaexpr6846 = new BitSet(new ulong[]{0x00000000002000B0UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_katom_in_kaexpr6850 = new BitSet(new ulong[]{0x0000000F01000002UL});
    public static readonly BitSet FOLLOW_33_in_kaexpr6879 = new BitSet(new ulong[]{0x00000000002000B0UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_katom_in_kaexpr6883 = new BitSet(new ulong[]{0x0000000E01000002UL});
    public static readonly BitSet FOLLOW_34_in_kaexpr6912 = new BitSet(new ulong[]{0x00000000002000B0UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_katom_in_kaexpr6916 = new BitSet(new ulong[]{0x0000000C01000002UL});
    public static readonly BitSet FOLLOW_24_in_kaexpr6945 = new BitSet(new ulong[]{0x00000000002000B0UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_katom_in_kaexpr6949 = new BitSet(new ulong[]{0x0000000801000002UL});
    public static readonly BitSet FOLLOW_35_in_kaexpr6978 = new BitSet(new ulong[]{0x00000000002000B0UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_katom_in_kaexpr6982 = new BitSet(new ulong[]{0x0000000800000002UL});
    public static readonly BitSet FOLLOW_28_in_kkblock7030 = new BitSet(new ulong[]{0x01DA1FF030E800B0UL,0x0000000000000870UL});
    public static readonly BitSet FOLLOW_kstat_in_kkblock7058 = new BitSet(new ulong[]{0x01DA1FF030E800B0UL,0x0000000000000870UL});
    public static readonly BitSet FOLLOW_29_in_kkblock7081 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_mixdeclarator7113 = new BitSet(new ulong[]{0x0000000004000002UL});
    public static readonly BitSet FOLLOW_ARRAY_in_mixdeclarator7115 = new BitSet(new ulong[]{0x0000000004000002UL});
    public static readonly BitSet FOLLOW_26_in_mixdeclarator7120 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_ID_in_mixdeclarator7124 = new BitSet(new ulong[]{0x0000000004000002UL});
    public static readonly BitSet FOLLOW_ARRAY_in_mixdeclarator7126 = new BitSet(new ulong[]{0x0000000004000002UL});

}
