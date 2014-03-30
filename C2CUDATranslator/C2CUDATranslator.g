grammar C2CUDATranslator;

options {
	language=CSharp2;
	output=template;

}

scope slist {
    IList locals; // must be defined one per semicolon
    IList stats;
}

@header {

}
@members {
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
              for(i=0;i<$program::Constants.Count;i++)
              {
                  String s = $program::Constants[i].ToString();
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
            for (i = 0; i < $program::RowsAccessed2.Count; i++)
            {
                if(String.Compare($program::RowsAccessed[i].ToString(), name)==0)
                {
                a=$program::RowsAccessed2[i].ToString();
                }
            }
            return a;
        }
        public string Get2DArrayDevicePitch(String name)
        {
            string a = string.Empty ;
            int i;
            for (i = 0; i < $program::RowsAccessed3.Count; i++)
            {
                if(String.Compare($program::RowsAccessed4[i].ToString(), name)==0)
                {
                a=$program::RowsAccessed3[i].ToString();
                }
            }
            return a;
        }
}
program
scope {
  IList globals;
  IList functions;
  IList kernelvars;
  IList includes;
  IList mainstats;
  IList kernelcopyin;
  IList kernelcopyout;
  IList kernelalloc;
  IList kernelvarfree;
  IList kernelvarsize;
  IList functiondeclarations;
  IList ReadOnly;
  IList WriteOnly;
  IList funclist;
  IList PitchSatements;
  IList Constants;
  IList RowsAccessed;
  IList RowsAccessed2;
  IList RowsAccessed3;
  IList RowsAccessed4;
  IList RowsAccessed5;
  IList kernellocals;
  String kernelpar;
  String kernelpar2;
  String temp;
  String size;
  String index;
  Boolean recursionflag;
  Boolean iteraiveflag;
  int kernelforloopindex;
  }

@init {
  $program::globals = new ArrayList();
  $program::functions = new ArrayList();
  $program::includes = new ArrayList();
  $program::mainstats = new ArrayList();
  $program::kernelvars = new ArrayList();
  $program::kernelcopyin = new ArrayList();
  $program::kernelcopyout = new ArrayList();
  $program::kernelalloc = new ArrayList();
  $program::kernelvarfree = new ArrayList();
  $program::kernelvarsize = new ArrayList();
  $program::functiondeclarations = new ArrayList();
  $program::ReadOnly = new ArrayList();
  $program::WriteOnly = new ArrayList();
  $program::funclist = new ArrayList();
  $program::PitchSatements = new ArrayList();
  $program::Constants = new ArrayList();
  $program::RowsAccessed = new ArrayList();
  $program::RowsAccessed2 = new ArrayList();
  $program::RowsAccessed3 = new ArrayList();
  $program::RowsAccessed4 = new ArrayList();
  $program::RowsAccessed5 = new ArrayList();
  $program::kernellocals = new ArrayList();
  $program::recursionflag = new Boolean();
  $program::iteraiveflag = new Boolean();
  $program::kernelforloopindex = new int();
}
    :   declaration+
        -> program(globals={$program::globals},functions={$program::functions},includes={$program::includes},mainstats= {$program::mainstats},kernelvars = {$program::kernelvars},kernelcopyin = {$program::kernelcopyin},functiondeclarations = {$program::functiondeclarations},ReadOnly={$program::ReadOnly},WriteOnly={$program::WriteOnly},size={$program::size},funclist={$program::funclist},pitchstats={$program::PitchSatements},rowaccessed={$program::RowsAccessed},kernellocals={$program::kernellocals})
    ;

declaration
    :   variable   {$program::globals.Add($variable.st);}
    |   funcDecl {$program::functiondeclarations.Add($funcDecl.st);}
   // |   function {$program::functions.Add($function.st);}
    |   kernel_variable {$program::kernelvars.Add($kernel_variable.st);}
    |   kernel_array {$program::kernelvars.Add($kernel_array.st);}
    |   kernel_local_variable {$program::kernellocals.Add($kernel_local_variable.st);}
    |   include {$program::includes.Add($include.st);}
    |   define {$program::includes.Add($define.st);}
    |   main {$program::includes.Add($main.st);} 
    |   statement {$program::mainstats.Add($statement.st);}
    |   kf=kernel_function {$program::functions.Add($kernel_function.st);
        $program::mainstats.Add($program::kernelalloc);
        $program::mainstats.Add($program::kernelcopyin);  
         if($program::funclist.Contains("kernel"))
	 {
	 $program::recursionflag=true;
	 }
        $program::funclist.Add("kernel");
	$program::mainstats.Add("\n// call kernel \n kernel <<< dim3(n_blocks), dim3(block_size,block_size) >>>("+ $program::kernelpar.ToString().Substring(1,$program::kernelpar.Length -1 )+");");
	$program::mainstats.Add($program::kernelcopyout);
	$program::mainstats.Add($program::kernelvarfree);
	$program::mainstats.Add("\n");
 
    }
    
    ;

// ack is $function.st ambig?  It can mean the rule's dyn scope or
// the ref in this rule.  Ack.




variable
    :   type declarator ';'
        -> {$function.Count>0 && $function::name==null}?
           globalVariable(type={$type.st},name={$declarator.st})
        -> variable(type={$type.st},name={$declarator.st})
      |  type arraydeclarator ';'
        -> {$function.Count>0 && $function::name==null}?
           globalVariable(type={$type.st},name={$arraydeclarator.st})
        -> variable(type={$type.st},name={$arraydeclarator.st})
    ;
    
 kvariable
    :   type kdecl ';'
        -> {$function.Count>0 && $function::name==null}?
           globalVariable(type={$type.st},name={"gpu_"+$kdecl.st})
        -> variable(type={$type.st},name={"gpu_"+$kdecl.st})
      |  type arraydeclarator ';'
        -> {$function.Count>0 && $function::name==null}?
           globalVariable(type={$type.st},name={"gpu_"+$arraydeclarator.st})
        -> variable(type={$type.st},name={"gpu_"+$arraydeclarator.st})
    ;
    
statement
:      stat ->type(name={$stat.st})
	;
statement_list

	: statement+

	;

main
scope slist;
@init {
	$slist::locals = new ArrayList();
	$slist::stats = new ArrayList();
}
:  
	type mdeclarator '()' mblock { $program::funclist.Add("main");}
	->main(type={$type.st},name={$mdeclarator.st})
	
	| type mdeclarator '(' (('int'|'char') ('*')* declarator ('[]')*) ((',') (('int'|'char') ('*')* declarator ('[]')* ))* ')' mblock { $program::funclist.Add("main");}
	->maint(type={$type.st},name={$mdeclarator.st})
	| mdeclarator '()' mblock { $program::funclist.Add("main");}
	->main(type={""},name={$mdeclarator.st})
	; 
	

mblock
    :  '{' 
    {
    $program::kernelcopyout.Add("\n// Retrieve result from device and store it in host array");
    $program::kernelcopyin.Add("\n// Copy Data to device from host ");
    $program::kernelalloc.Add("\n// Memory Allocation ");
    $program::kernelvarfree.Add("\n// Free GPU Variables ");
    $program::PitchSatements.Add("\n//Pitch Slices per Row for 2D Array");
    }
	declaration+         
       '}'
       ;
include
:       type kdeclarator 
//	-> include(name={$include.st})
	-> include(type={$type.st},name={$kdeclarator.st})
	
	;
funcDecl
:	type ID '(' ( p+=formalParameter ( ',' p+=formalParameter )* )? ')'';' -> type(name={$type.st + $ID.text + "("+ $p +");"}) 
	| type ID '(' ');' -> type(name={$type.st + $ID.text + "("+");"}) 	
	;
define
:
	rdeclarator declarator t+=digits ('.' t+=digits)* {$program::Constants.Add($declarator.st);}
	-> define(type={$rdeclarator.st},name={$declarator.st},val={ArraytoString((ArrayList)$t,".")})
	;

declarator
    :   ID  -> {new StringTemplate($ID.text)} 
 | f+=ID (',' f+=ID  )+   -> type(name={$f})
    ;

kdecl
    :   ID  -> {new StringTemplate($ID.text)} 
 | f+=ID (',' f+=ID  )+   -> type(name={$f})
    ;

digits
    :   INT -> {new StringTemplate($INT.text)} 
    ;

kdeclarator
    :   Keyword -> {new StringTemplate($Keyword.text)} 
     
    ;

arraydeclarator
    :   ARRAY -> {new StringTemplate($ARRAY.text)} 
   //  | ARRAY ((' ')* ('=') (' ')*) ('{'((INT)* (',' (INT)*)*)'}')  ->  {new StringTemplate($ARRAY.text)} 
    ;
rdeclarator
    :   RWORD -> {new StringTemplate($RWORD.text)} 
     ;

mdeclarator
    :   MAINS -> {new StringTemplate($MAINS.text)} 
     
    ;
    
function
scope {
  String name;
}
scope slist;
@init {
	$slist::locals = new ArrayList();
	$slist::stats = new ArrayList();
}
  :   type ID {$function::name=$ID.text;}
        '(' ( p+=formalParameter ( ',' p+=formalParameter )* )? ')'
        block
        -> function(type={$type.st}, name={$ID.text},
                    locals={$slist::locals},
                    stats={$slist::stats},
                   args={$p})
    ;

formalParameter
    :   type (declarator)*
        -> parameter(type={$type.st},name={$declarator.st})
        | type arraydeclarator
        -> parameter(type={$type.st},name={$arraydeclarator.st})       
    ;
afexpr	:
	 (a=aftom -> {$a.st})
	        ( '+' b=aftom -> add(left={$afexpr.st}, right={$b.st}) )*
	        ( '-' b=aftom -> Sub(left={$afexpr.st}, right={$b.st}) )*
	        ( '/' b=aftom -> Div(left={$afexpr.st}, right={$b.st}) )*
	        ( '*' b=aftom -> Mul(left={$afexpr.st}, right={$b.st}) )*
	        ( '%' b=aftom -> Mod(left={$afexpr.st}, right={$b.st}) )*	
	;
aftom	:
	ID  -> type(name={$ID.text})
    | ARRAY -> type(name={$ARRAY.text})
    | INT -> type(name={$INT.text})		
	;

kakfexpr	:
	 (a=kakftom -> {$a.st})
	        ( '+' b=kakftom -> add(left={$kakfexpr.st}, right={$b.st}) )*
	        ( '-' b=kakftom -> Sub(left={$kakfexpr.st}, right={$b.st}) )*
	        ( '/' b=kakftom -> Div(left={$kakfexpr.st}, right={$b.st}) )*
	        ( '*' b=kakftom -> Mul(left={$kakfexpr.st}, right={$b.st}) )*
	        ( '%' b=kakftom -> Mod(left={$kakfexpr.st}, right={$b.st}) )*	
	;
kakftom	:
	ID  -> type(name={$ID.text})
    | ARRAY -> type(name={$ARRAY.text})
    | INT -> type(name={$INT.text})		
	;

type
    :   'int'  		-> type_int()
    |   'char' 		-> type_char()
    |   'float' 	-> type_float()
    |   'bool'		-> type_bool()
    |   'kernel'	-> type_kernel()
    |   'void'		-> type(name={"void"})
    |   'double'		-> type(name={"double"})
    |   'cudaDeviceProp'-> type(name={"cudaDeviceProp"})
    | 'size_t'-> type(name={"size_t"})
    //|   ID     		-> type_user_object(name={$ID.text})
    //|   CHARS 		-> type_user_object(name={$CHARS.text})
//    |   INT 		-> type_user_object(name={$INT.text})
    |   '#include' 	-> type(name={"#include"})
  //  |   '#define' 	-> type(name={"#define"})
    //|   KID    -> type_kernel_object(name={$KID.text})
    ;



block
    :  '{'
         (variable {$slist::locals.Add($variable.st);} )* 
         (stat {$slist::stats.Add($stat.st);})* 
//	 (func_call2 {$slist::stats.Add($func_call2.st);})*

        // (kblock {$slist::stats.Add($kblock.st);})*
        // (kernel_variable {$program::kernelvars.Add($kernel_variable.st);})*
        // (kernel_array {$program::kernelvars.Add($kernel_array.st);})*
         
       '}'
              
    ;

stat
scope slist;
@init {
  $slist::locals = new ArrayList();
  $slist::stats = new ArrayList();
}
    : forStat -> {$forStat.st}
    | func_call  ';' {
    
    if($program::funclist.Contains($func_call.st.ToString()))
    {
    $program::recursionflag=true;
    }
    $program::funclist.Add($func_call.st);
    }
    -> {$func_call.st} 
    | expr ';' -> statement(expr={$expr.st})
    | block -> statementList(locals={$slist::locals}, stats={$slist::stats})
    | assignStat ';' -> {$assignStat.st}
    | print_statement ';' -> {$print_statement.st}
    | selection_statement  -> {$selection_statement.st}
    | while_statement  -> {$while_statement.st}
    | return_statement ';' -> {$return_statement.st}
    | func_call2 -> {$func_call2.st}
    
    //| funcstat ';' -> {$funcstat.st}
    //| function -> {$function.st}
//    | dirExpr->statement(expr={$dirExpr.st})
    | ';' -> {new StringTemplate(";")}
    ;



forStat
scope slist;
@init {
  $slist::locals = new ArrayList();
  $slist::stats = new ArrayList();
}
    :   'for' '(' e1=assignStat ';' e2=expr ';' e3=incStat ')' block
        -> forLoop(e1={$e1.st},e2={$e2.st},e3={$e3.st},
                   locals={$slist::locals}, stats={$slist::stats})
    ;

assignStat
    :     ID '=' expr -> assign(lhs={$ID.text}, rhs={$expr.st})
     // |   arraydeclarator '='   -> type({name={$arraydeclarator.st}})
    |   ARRAY '=' expr -> assign(lhs={$ARRAY.text}, rhs={$expr.st})
   
    //|   ARRAY '=' atom -> assign(lhs={$ARRAY.text}, rhs={$atom.st})
    |   ID '-=' expr -> assignop(lhs={$ID.text}, rhs={$expr.st},op={"-="})
    |   ARRAY '-=' expr -> assignop(lhs={$ARRAY.text}, rhs={$expr.st},op={"-="})
    |   ID '+=' expr -> assignop(lhs={$ID.text}, rhs={$expr.st},op={"+="})
    |   ARRAY '+=' expr -> assignop(lhs={$ARRAY.text}, rhs={$expr.st},op={"+="})
    |   ID '=' func_call ->  assignop(lhs={$ID.text}, rhs={$func_call.st},op={"="})
    |   ID '=' func_call '%' expr ->  assignop(lhs={$ID.text}, rhs={$func_call.st + "\%" + $expr.st},op={"="})
    |   ARRAY '=' func_call '%' expr ->  assignop(lhs={$ARRAY.text}, rhs={$func_call.st + "\%" + $expr.st},op={"="})
    ;

print_statement
	:
	PRINT -> type(name={$PRINT.text}) |
	// 'printf(' STRING_LITERAL ')' -> type(name={"printf("+$STRING_LITERAL.text+");"})
	//'printf(' ( options {greedy=false;} : . )* ');' {$channel=HIDDEN;}
	//| 'printf(' STRING_LITERAL (( r+=',' atom )+ )   ')' -> type(name={"printf("+$STRING_LITERAL.text+","+$r+")"})
	//| 'printf(' {$program::temp="";} STRING_LITERAL ((',' {$program::temp+=",";} printfParameter )+  )   ')' -> type(name={"printf("+$STRING_LITERAL.text+$program::temp+");"})
	 'fprintf(' ID ',' STRING_LITERAL ')' -> type(name={"fprintf("+$ID.text+","+$STRING_LITERAL.text+");"})
	| 'fprintf(' ID ',' STRING_LITERAL ( r+=',' printfParameter )+    ')' -> type(name={"printf("+$ID.text+","+$STRING_LITERAL.text+$printfParameter.st+");"})
	//| 'printf' '(' STRING_LITERAL (',' ID)* ')' -> type(name={"printf("+$STRING_LITERAL.text+","+$ID.text+")"})
	//| 'printf' constant_expression ':' statement
	| 'default' ':' statement -> type(name={"default :"+$statement.st})	
	;
printfParameter
    :   aexpr {$program::temp+=$aexpr.st;} 
        -> type(name={$aexpr.st})
    // | ',' ARRAY
    ;
return_statement
:
	  'return' digits -> type(name={"printf(\"\\n  blocksize=\%d numofblock=\%d\\n\",block_size,n_blocks); \r\n system(\"pause\"); \r\n return "+$digits.text +";"})
	| 'return' ID     -> type(name={"return "+$ID.text+";"})
        | 'return' ARRAY  -> type(name={"return "+$ARRAY.text+";"})
        | 'return'  -> type(name={"return;"})
	;
while_statement
scope slist;
@init {
  $slist::locals = new ArrayList();
  $slist::stats = new ArrayList();
}
	: 'while' '(' expr ')' block
	  -> whileLoop(e1={$expr.st},
                   locals={$slist::locals}, stats={$slist::stats})
        | 'do' block 'while' '(' expr ')'
	  -> whileLoop(e1={$expr.st},
                   locals={$slist::locals}, stats={$slist::stats})
	;
selection_statement

	: 'if' '(' condExpr ')' stat //('else' statement)?
	-> type(name={"if ("+$condExpr.st+")" +$stat.st})// + "else " + $statement.st}) 
	| 'else' stat -> type(name={"else " +$stat.st})
	| 'switch' '(' expr ')' stat -> type(name={"switch ("+$expr.st+")" +$stat.st}) 

	;

//iteration_statement

//	: 'while' '(' expr ')' statement

//	| 'do' statement 'while' '(' expr ')' ';'

	//| 'for' '(' expression_statement expression_statement expr? ')' statement

//	;
expression_statement

	: ';' -> type(name={";"})

	| expr ';' -> type(name={$expr.st})

	;
incStat
	:   ID '++' 	-> type(name={$ID.text + "++"})
	|   ID '--'  	-> type(name={$ID.text + "--"})
	|   '++' ID  	-> type(name={"++"+$ID.text})
 	|   '--' ID	-> type(name={"--"+$ID.text})
 	|   ID '+=' INT	-> type(name={$ID.text + "+=" + $INT.text})
	|   ID '-=' INT	-> type(name={$ID.text + "-=" + $INT.text})
	|   ID '*=' INT	-> type(name={$ID.text + "*=" + $INT.text})	
    ;

expr:   
	 condExpr -> {$condExpr.st}
    
	
	//| func_call -> $func_call.st}
    ;
    


//dirExpr
//:
//	DIRECTIVES '<' (ID) '.' (ID) '>'
//	|	DIRECTIVES '"' ID '.' ID '"' 
//	|	DIRECTIVES ID INT 
	
//	;

condExpr
    :   a=aexpr
        (   (  '==' b=aexpr -> equals(left={$a.st},right={$b.st})
            |  '!=' b=aexpr -> notequals(left={$a.st},right={$b.st})
            |  '<' b=aexpr   -> lessThan(left={$a.st},right={$b.st})
            |  '>' b=aexpr   -> GreaterThan(left={$a.st},right={$b.st})
            |  '<=' b=aexpr   -> lessThanEq(left={$a.st},right={$b.st})
            |  '>=' b=aexpr   -> GreaterThanEq(left={$a.st},right={$b.st})
            |  '&&' b=aexpr   -> CAND(left={$a.st},right={$b.st})
            |  '||' b=aexpr   -> COR(left={$a.st},right={$b.st})
            //|  ','  b=aexpr   -> type(name={$a.st+","+$b.st})
            )
        |   -> {$a.st} // else just aexpr
        //|     condExpr     '&&'     condExpr      
        | '(' condExpr  ')'
     	
        )
    
    ;

aexpr
    :   (a=atom -> {$a.st})
        ( '+' b=atom -> add(left={$aexpr.st}, right={$b.st}) )*
        ( '-' b=atom -> Sub(left={$aexpr.st}, right={$b.st}) )*
        ( '/' b=atom -> Div(left={$aexpr.st}, right={$b.st}) )*
        ( '*' b=atom -> Mul(left={$aexpr.st}, right={$b.st}) )*
        ( '%' b=atom -> Mod(left={$aexpr.st}, right={$b.st}) )*              
    ;

atom
    : ID  -> refVar(id={$ID.text})
    | ARRAY -> refVar(id={$ARRAY.text})  
    | INT -> iconst(value={$INT.text})
    | RWORD ->refVar(id={$RWORD.text})
    | '(' expr ')' -> {$expr.st} 
    | '[' expr ']' -> {$expr.st}
    | CHARACTER_LITERAL -> refVar(id={$CHARACTER_LITERAL.text})
   
    
   // | FUNC_CALL->refVar(id={$FUNC_CALL.text})
   // | func_call -> {$func_call.st}
 //   | ID '()' -> type(name={$ID.text+"()"})
  //  | ID '('+(declarator)*+')' -> type(name={$ID.text+"("+$declarator.st+")"})
  //  | ID '[' expr ']' -> {$expr.st}
    ; 
    
    func_call
:
	//ID '(' ')' ->type(name={$ID.text+"()"})
	 ID '(' ( (p+=formalParameter) ( ',' p+=formalParameter )* )? ')' ->type(name={$ID.text+"("+$p+")"})
	 | ID '()' ->type(name={$ID.text + "()"})
	;

	
func_call2
:
	//ID '(' ')' ->type(name={$ID.text+"()"})
	 ID '(' ( (p+=afexpr) ( ',' p+=afexpr )* )? ');' ->type(name={$ID.text+"("+$p+");"}) 



	 //| 	 'main(' ( (p+=afexpr) ( ',' p+=afexpr )* )? ');' ->type(name={$ID.text+"("+$p+");"}) 
	 //|  	'kernel(' ( (p+=afexpr) ( ',' p+=afexpr )* )? ');' ->type(name={$ID.text+"("+$p+");"}) 
	//| ID '();'
	//| 'main();'
	//| 'kernel();'
	;

kfunc_call
:
	//ID '(' ')' ->type(name={$ID.text+"()"})
	 ID '(' ( (p+=kakfexpr) ( ',' p+=kakfexpr )* )? ');' {
	 if($program::funclist.Contains($ID.text))
	 {
	 $program::recursionflag=true;
	 }
	 $program::funclist.Add($ID.text);}
	  ->type(name={$ID.text+"("+ArraytoString((ArrayList)$p,",")+");"}) 
	// | 	 'main(' ( (p+=kakfexpr) ( ',' p+=kakfexpr )* )? ');' ->type(name={"main"+"("+$p+");"}) 
	 |  	'kernel(' ( (p+=kakfexpr) ( ',' p+=kakfexpr )* )? ');' {

	 $program::recursionflag=true;
	 Boolean d=$program::recursionflag;
	  $program::funclist.Add("kernel");}
	   ->type(name={"kernel"+"("+ArraytoString((ArrayList)$p,",")+");"}) 
	| ID '();'  {
	 if($program::funclist.Contains($ID.text))
	 {
	 $program::recursionflag=true;
	 }
	 $program::funclist.Add($ID.text);}
	//| 'main();'
	//| 'kernel();'
	;

kernel_variable
    :   'kernel' type declarator ';'                            
					{if($declarator.st.ToString().Contains("="))
    					//{input.LT(1).ToString().Contains("=")}?
    					{
    					   $program::kernelalloc.Add("g_"+$declarator.st.ToString().Substring(0,$declarator.st.ToString().IndexOf('='))+"= ("+$type.st+" *)malloc(sizeof("+$type.st+")); // Allocate variable on host \n cudaMalloc((void **) &g_"+$declarator.st.ToString().Substring(0,$declarator.st.ToString().IndexOf('='))+",sizeof("+$type.st+")); // Allocate variable on device");
    					   $program::kernelvarfree.Add("cudaFree(g_"+$declarator.st.ToString().Substring(0,$declarator.st.ToString().IndexOf('='))+");");
					   $program::kernelcopyin.Add("cudaMemcpy(g_"+$declarator.st.ToString().Substring(0,$declarator.st.ToString().IndexOf('='))+", &"+$declarator.st.ToString().ToString().Substring(0,$declarator.st.ToString().IndexOf('='))+", sizeof("+$type.st+"), cudaMemcpyHostToDevice);");
                                           $program::kernelcopyout.Add("cudaMemcpy(&"+$declarator.st.ToString().Substring(0,$declarator.st.ToString().IndexOf('='))+", g_"+$declarator.st.ToString().ToString().Substring(0,$declarator.st.ToString().IndexOf('='))+", sizeof("+$type.st+"), cudaMemcpyDeviceToHost);");
                                           $program::kernelpar= $program::kernelpar+(", g_"+$declarator.st.ToString().Substring(0,$declarator.st.ToString().IndexOf('=')));
                                           $program::kernelpar2= $program::kernelpar2+(", "+$type.st+" *gpu_"+$declarator.st.ToString().Substring(0,$declarator.st.ToString().IndexOf('=')));
        				    } 
        				 else
        				    { 
        				   $program::kernelalloc.Add("g_"+$declarator.st.ToString()+"= ("+$type.st+" *)malloc(size); // Allocate variable on host \n cudaMalloc((void **) &g_"+$declarator.st+", sizeof("+$type.st+")); // Allocate variable on device");
        				   $program::kernelvarfree.Add("cudaFree(g_"+$declarator.st+");");
					   $program::kernelcopyin.Add("cudaMemcpy(g_"+$declarator.st+", &"+$declarator.st.ToString().ToString()+", sizeof("+$type.st+"), cudaMemcpyHostToDevice);");
                                           $program::kernelcopyout.Add("cudaMemcpy(&"+$declarator.st+", g_"+$declarator.st.ToString().ToString()+", sizeof("+$type.st+"), cudaMemcpyDeviceToHost);");
                                           $program::kernelpar =  $program::kernelpar+(", g_"+$declarator.st);
                                           $program::kernelpar2 =  $program::kernelpar2+(", "+$type.st+" *gpu_"+$declarator.st);
        				}}
	{
	if($program::index=="1D" || $program::index == "2D")
	{
	}
	else
	{
		$program::index="1";
	}
	}
        ->{$declarator.st.ToString().Contains("=")}? 
         kernel_variable(type={$type.st},name={$declarator.st},id={$declarator.st.ToString().Substring(0,$declarator.st.ToString().IndexOf('='))})       
         ->kernel_var(type={$type.st},name={$declarator.st})      


    ;
kernel_local_variable
    :   'local' type declarator ';'                            
	 //->{$declarator.st.ToString().Contains("=")}? 
         //kernel_variable(type={$type.st},name={$declarator.st},id={$declarator.st.ToString().Substring(0,$declarator.st.ToString().IndexOf('='))})       
         ->kernel_local_var(type={$type.st},name={$declarator.st}) 
	;

kernel_array
    :   'kernel' type arraydeclarator ';' {if($arraydeclarator.st.ToString().IndexOf("[")==$arraydeclarator.st.ToString().LastIndexOf("["))
    					   {
    					   $program::kernelalloc.Add("g_"+$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('['))+"= ("+$type.st+" *)malloc("+ $arraydeclarator.st.ToString().Substring($arraydeclarator.st.ToString().IndexOf('[')+1,$arraydeclarator.st.ToString().IndexOf(']')-$arraydeclarator.st.ToString().IndexOf('[')-1) + " *" +"sizeof("+$type.st+")); // Allocate array on host \n cudaMalloc((void **) &g_"+$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('['))+ "," + $arraydeclarator.st.ToString().Substring($arraydeclarator.st.ToString().IndexOf('[')+1,$arraydeclarator.st.ToString().IndexOf(']')-$arraydeclarator.st.ToString().IndexOf('[')-1) + " *" +" sizeof("+$type.st+")); // Allocate array on device");
    					   $program::kernelvarfree.Add("cudaFree(g_"+$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('['))+");");
					   $program::kernelcopyin.Add("cudaMemcpy(g_"+$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('['))+", "+$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('['))+","+ $arraydeclarator.st.ToString().Substring($arraydeclarator.st.ToString().IndexOf('[')+1,$arraydeclarator.st.ToString().IndexOf(']')-$arraydeclarator.st.ToString().IndexOf('[')-1) + " *" +" sizeof("+$type.st+"), cudaMemcpyHostToDevice);");
                                           $program::kernelcopyout.Add("cudaMemcpy("+$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('['))+", g_"+$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('['))+","+ $arraydeclarator.st.ToString().Substring($arraydeclarator.st.ToString().IndexOf('[')+1,$arraydeclarator.st.ToString().IndexOf(']')-$arraydeclarator.st.ToString().IndexOf('[')-1) + " *" +" sizeof("+$type.st+"), cudaMemcpyDeviceToHost);");
					   $program::kernelpar= $program::kernelpar+(", g_"+$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('[')));
					   $program::kernelpar2= $program::kernelpar2+(","+$type.st+" *gpu_"+$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('[')));
					   
						if($program::index=="1D" || $program::index == "2D")
						{
						}
						else
						{
							$program::index="1D";
						}
						
					   }
					   else
        				   { 
	        				   $program::kernelalloc.Add("size_t pitch"+ $program::kernelcopyin.Count.ToString()+";\r\n cudaMallocPitch(&"+"g_"+$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('['))+", &pitch"+ $program::kernelcopyin.Count.ToString()+", "+ $arraydeclarator.st.ToString().Substring($arraydeclarator.st.ToString().LastIndexOf('[')+1,$arraydeclarator.st.ToString().LastIndexOf(']')-$arraydeclarator.st.ToString().LastIndexOf('[')-1) + " *" +" sizeof("+$type.st+")"+", "+ $arraydeclarator.st.ToString().Substring($arraydeclarator.st.ToString().IndexOf('[')+1,$arraydeclarator.st.ToString().IndexOf(']')-$arraydeclarator.st.ToString().IndexOf('[')-1)+");"+" \r\n // Allocate 2Darray on device");
	        				   $program::RowsAccessed3.Add("pitch"+$program::kernelcopyin.Count.ToString());
  	        				   $program::RowsAccessed4.Add($arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('[')));
	    					   $program::kernelvarfree.Add("cudaFree(g_"+$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('['))+");");
						   
						   String s,temp1 = $arraydeclarator.st.ToString();
						   int n1= $program::WriteOnly.Count;
						   for(int i=0;i<n1;i++)
						   {
						   	temp1=$program::WriteOnly[i].ToString();
						   }
	                                           if($program::WriteOnly.Contains($arraydeclarator.st.ToString()))
	                                           {                                           	   
		                                   	$program::kernelcopyin.Add("cudaMemcpy2D(g_"+$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('['))+", "+"pitch"+ $program::kernelcopyin.Count.ToString()+ ", "+$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('['))+", "+ $arraydeclarator.st.ToString().Substring($arraydeclarator.st.ToString().LastIndexOf('[')+1,$arraydeclarator.st.ToString().LastIndexOf(']')-$arraydeclarator.st.ToString().LastIndexOf('[')-1) + " *" +" sizeof("+$type.st+")"+", "+ $arraydeclarator.st.ToString().Substring($arraydeclarator.st.ToString().LastIndexOf('[')+1,$arraydeclarator.st.ToString().LastIndexOf(']')-$arraydeclarator.st.ToString().LastIndexOf('[')-1) + " *" +" sizeof("+$type.st+"),"+ $arraydeclarator.st.ToString().Substring($arraydeclarator.st.ToString().IndexOf('[')+1,$arraydeclarator.st.ToString().IndexOf(']')-$arraydeclarator.st.ToString().IndexOf('[')-1) +"," +" cudaMemcpyHostToDevice);");        
	                                           }
	                                           else
	                                           {
		                                   	$program::kernelcopyin.Add("cudaMemcpy2D(g_"+$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('['))+", "+"pitch"+ $program::kernelcopyin.Count.ToString()+ ", "+$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('['))+", "+ $arraydeclarator.st.ToString().Substring($arraydeclarator.st.ToString().LastIndexOf('[')+1,$arraydeclarator.st.ToString().LastIndexOf(']')-$arraydeclarator.st.ToString().LastIndexOf('[')-1) + " *" +" sizeof("+$type.st+")"+", "+ $arraydeclarator.st.ToString().Substring($arraydeclarator.st.ToString().LastIndexOf('[')+1,$arraydeclarator.st.ToString().LastIndexOf(']')-$arraydeclarator.st.ToString().LastIndexOf('[')-1) + " *" +" sizeof("+$type.st+"),"+ $arraydeclarator.st.ToString().Substring($arraydeclarator.st.ToString().IndexOf('[')+1,$arraydeclarator.st.ToString().IndexOf(']')-$arraydeclarator.st.ToString().IndexOf('[')-1) +"," +" cudaMemcpyHostToDevice);");        
	                                           }
	                                           
	                                           $program::PitchSatements.Add("int* row"+$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('['))+" = (int*)((char*)gpu_"+$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('['))+" + idx*pitch"+($program::kernelcopyin.Count-1).ToString()+");");
	                                           
	                                           $program::kernelcopyout.Add("cudaMemcpy2D("+$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('['))+","+$arraydeclarator.st.ToString().Substring($arraydeclarator.st.ToString().LastIndexOf('[')+1,$arraydeclarator.st.ToString().LastIndexOf(']')-$arraydeclarator.st.ToString().LastIndexOf('[')-1) + " *" +" sizeof("+$type.st+")"+", g_"+$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('['))+",pitch"+ ($program::kernelcopyin.Count-1).ToString()+","+ $arraydeclarator.st.ToString().Substring($arraydeclarator.st.ToString().LastIndexOf('[')+1,$arraydeclarator.st.ToString().LastIndexOf(']')-$arraydeclarator.st.ToString().LastIndexOf('[')-1) + " *" +" sizeof("+$type.st+")"+","+$arraydeclarator.st.ToString().Substring($arraydeclarator.st.ToString().IndexOf('[')+1,$arraydeclarator.st.ToString().IndexOf(']')-$arraydeclarator.st.ToString().IndexOf('[')-1)+", cudaMemcpyDeviceToHost);");
						  
						   $program::kernelpar= $program::kernelpar+(", g_"+$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('['))+ ",pitch"+ ($program::kernelcopyin.Count-1).ToString());
						   $program::kernelpar2= $program::kernelpar2+(", "+$type.st+" *"+"*gpu_"+$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('['))+" , size_t pitch"+ ($program::kernelcopyin.Count-1).ToString());
						   if($program::index == "2D")
							{
							}
							else
							{
								$program::index="2D";
							}
					    }
					   }
		->{$arraydeclarator.st.ToString().IndexOf("[")==$arraydeclarator.st.ToString().LastIndexOf("[")}? 
		kernel_array(type={$type.st},name={$arraydeclarator.st},arr={$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('['))})
            -> kernel_array2D(type={$type.st},name={$arraydeclarator.st},arr={$arraydeclarator.st.ToString().Substring(0,$arraydeclarator.st.ToString().IndexOf('['))})
            
  //      |'kernel' type arraydeclarator ((' ')* ('=') (' ')*) ('{'((INT)* (',' (INT)*)*)'}') ';'
//        -> kernel_array(type={$type.st},name={$arraydeclarator.st})
    ;
kblock
    :  '#pragma kernel_start'
        // (variable {$slist::locals.Add("g_"+$variable.st);} )* 
         (kstat {$slist::stats.Add($kstat.st);})*
       '#pragma kernel_end'  
       {
       
       }

    ;

kernel_function
scope {
  String name;
}
scope slist;
@init {
	$slist::locals = new ArrayList();
	$slist::stats = new ArrayList();
}
  :   kblock {$kernel_function::name="kernel";
  	if($program::index=="2D")
  	{
  		$program::index="int idx=threadIdx.x+blockIdx.x*blockDim.x;\r\n int idy=threadIdx.y+blockIdx.y*blockDim.y;";
	}
	else
	{
		if($program::index=="1D")
	  	{
	  		$program::index="int idx=threadIdx.x+blockIdx.x*blockDim.x;";
		}
	}
  	if(($program::iteraiveflag == false) && ($program::recursionflag == false))
  	{
  	// If no Dependecy then no change
  	}
  	else
  	{
  	$program::index="";
  	}
   } 
        -> kernel_function(type={"void"},name={"kernel"},args={$program::kernelpar2.ToString().Substring(1,$program::kernelpar2.Length -1 )},locals={$slist::locals},stats={$slist::stats},index={$program::index.ToString()},pitchstats={$program::PitchSatements},kernellocals={$program::kernellocals})
    ;

kstat
scope slist;
@init {
  $slist::locals = new ArrayList();
  $slist::stats = new ArrayList();
}
    : kforStat -> {$kforStat.st}

    | kexpr ';' -> statement(expr={$kexpr.st})
    | kkblock -> statementList(locals={$slist::locals}, stats={$slist::stats})
    | kassignStat ';'   { if($kassignStat.st.ToString().Contains("[") && ($kassignStat.st.ToString().Contains("]")) && ($kassignStat.st.ToString().IndexOf("[")!=$kassignStat.st.ToString().LastIndexOf("[")) )
    {
   
   
 //   q = $kassignStat.st.ToString().LastIndexOf("[");
    
    C2CUDATranslator.Analysis analysis = new C2CUDATranslator.Analysis();
      System.Collections.ArrayList one = new   System.Collections.ArrayList(); 
      System.Collections.ArrayList two = new   System.Collections.ArrayList();
      String temp,temp2;
      temp = $kassignStat.st.ToString().Substring(0,$kassignStat.st.ToString().IndexOf("]")+1);
    one = analysis.GetindexofArrayfromassignmentStatement(temp);
    temp2 = $kassignStat.st.ToString().Substring($kassignStat.st.ToString().IndexOf("]")+1,$kassignStat.st.ToString().Length-($kassignStat.st.ToString().IndexOf("]")+1));
    two = analysis.GetindexofArrayfromassignmentStatement(temp2);

    int n1= $program::ReadOnly.Count;
    int n2= $program::WriteOnly.Count;
    String temp1="";
    String temp3 = "";
    Boolean flag=false;
	
    for(int i=0;i<n1;i++)
	{
	     for(int j=0;j<n2;j++)
	         {
	         temp1=$program::ReadOnly[i].ToString();
	         temp2=$program::WriteOnly[j].ToString();
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
    
    	Console.WriteLine($kassignStat.st.ToString() + " Iterative Dependecy");
    	$program::iteraiveflag = true;   
    }
    else
    {
   // Console.WriteLine($kassignStat.st.ToString());
    $program::iteraiveflag = false  ;  
       
    }
    }
    else
    {
    	
    }
    } -> {$kassignStat.st}
    | kselection_statement  -> {$kselection_statement.st}
    | kprint_statement ';' -> {$kprint_statement.st}  
    | kwhile_statement  -> {$kwhile_statement.st}
    | kreturn_statement ';' -> {$kreturn_statement.st}
    | kfunc_call -> {$kfunc_call.st}
//    | print_statement ';' -> {$print_statement.st}
//    | dirExpr->statement(expr={$dirExpr.st})
    | kvariable  -> {$kvariable.st}
    | ';' -> {new StringTemplate(";")}
    ;
    
kforStat
scope slist;
@init {
  $slist::locals = new ArrayList();
  $slist::stats = new ArrayList();
  String loopindex;
  
}
    :   'for' '(' e1=kassignStat ';' e2=kexpr ';' e3=kincStat ')' kkblock
     {
     C2CUDATranslator.ForLoop Loop1 = new C2CUDATranslator.ForLoop();
     Loop1.Index = GetIndexofe1(e1);
     Loop1.Size = Getsizeofe2(e2);
    
     $program::kernelforloopindex=$program::kernelforloopindex+1;
     if($program::kernelforloopindex==1)
     {
     $program::size=Loop1.Size;
    // $program::size=$program::size+" * "+Loop1.Size;
     }
     else
     {
     Loop1.IsNestLoop=true;
      $program::size=Loop1.Size+" * "+$program::size;
     }
     	 Boolean d=$program::recursionflag;
     	
     if(($program::iteraiveflag == false) && ($program::recursionflag == false))
       {
       
       if($program::index=="2D")
  	{
  		if(Loop1.IsNestLoop)
  		{
  		 for(int myi=0;myi<$slist::stats.Count;myi++) 		
  		{
  			if($slist::stats[myi].ToString().Contains("pitch"))
  			{
  				if($slist::stats[myi].ToString().Contains(Loop1.Index))
  				{
 				//$slist::stats.RemoveAt(0);
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
		if($program::index=="1D")
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
        //-> RemoveforLoop(e1={$e1.st},e2={$e2.st},e3={$e3.st},
          //         locals={$slist::locals}, stats={$slist::stats},index={Loop1.Index})
    ;

kassignStat
    :   ID '=' kexpr {$program::WriteOnly.Add("gpu_"+$ID.text);} 
//    ->($program::index=="2D")?
//	assign(lhs={"gpu_"+$ID.text}, rhs={$kexpr.st})   
    -> assign(lhs={"gpu_"+$ID.text}, rhs={$kexpr.st})   
//      ID '=' kaexpr -> assign(lhs={$ID.text}, rhs={$kaexpr.st})
 // |   arraydeclarator '='   -> type({name={$arraydeclarator.st}})
    |   s=ARRAY '=' kexpr 
    {
    if($program::index=="2D" && ($s.text.ToString().IndexOf("[")!=$s.text.ToString().LastIndexOf("[")))
    	{     	
	    	String pitchstat="";

    		//$program::RowsAccessed.Add($s.text.ToString().Substring($s.text.ToString().IndexOf("["),$s.text.ToString().IndexOf("]")));
    		$program::RowsAccessed.Add($s.text.ToString().Substring(0,$s.text.ToString().IndexOf("]")+1));
		$program::RowsAccessed2.Add("row"+$s.text.ToString().Substring(0,$s.text.ToString().IndexOf('['))+$s.text.ToString().Substring(0,$s.text.ToString().IndexOf("]")+1).ToString().Replace($s.text.ToString().Substring(0,$s.text.ToString().IndexOf("[")+1),"").ToString().Replace("]","").ToString().Replace("+","p").ToString().Replace("-","m").ToString());
			
			
		pitchstat="int* "+"row"+$s.text.ToString().Substring(0,$s.text.ToString().IndexOf('['))+$s.text.ToString().Substring(0,$s.text.ToString().IndexOf("]")+1).ToString().Replace($s.text.ToString().Substring(0,$s.text.ToString().IndexOf("[")+1),"").ToString().Replace("]","").ToString().Replace("+","p").ToString().Replace("-","m").ToString()+" = (int* ) ((char* )gpu_"+$s.text.ToString().Substring(0,$s.text.ToString().IndexOf('['))+" + ("+getkernelstr2($s.text.ToString().Substring(0,$s.text.ToString().IndexOf("]")+1).ToString().Replace($s.text.ToString().Substring(0,$s.text.ToString().IndexOf("[")+1),"").ToString().Replace("]",""))+") * "+Get2DArrayDevicePitch($s.text.ToString().Substring(0,$s.text.ToString().IndexOf("[")))+");";

		int myflag=0;
		for(int i=0;i<$program::RowsAccessed5.Count;i++)
		{
			if(String.Compare($program::RowsAccessed5[i].ToString(),pitchstat)==0)
			{
			myflag=1;
			}
			
		}
		if(myflag==0)
		{
			$program::RowsAccessed5.Add(pitchstat);
    			$program::WriteOnly.Add("row"+$s.text.ToString().Replace($s.text.ToString().Substring($s.text.ToString().IndexOf("["),$s.text.ToString().IndexOf("]")),"").ToString().Replace("[","[gpu_").ToString());
    		}
    	}
    else
    	{
    		$program::WriteOnly.Add(getkernelstr($s.text));
    	}
    }
    ->{$program::index=="2D" && ($s.text.ToString().IndexOf("[")!=$s.text.ToString().LastIndexOf("["))}?
    assign(lhs={"row"+$s.text.ToString().Substring(0,$s.text.ToString().IndexOf('['))+$s.text.ToString().Substring(0,$s.text.ToString().IndexOf("]")+1).ToString().Replace($s.text.ToString().Substring(0,$s.text.ToString().IndexOf("[")+1),"").ToString().Replace("]","").ToString().Replace("+","p").ToString().Replace("-","m").ToString()+$s.text.ToString().Substring($s.text.ToString().IndexOf("]")+1,$s.text.ToString().Length-$s.text.ToString().IndexOf("]")-1).ToString().Replace("[","[gpu_").ToString()}, rhs={$kexpr.st})  
	//assign(lhs={"row"+$s.text.ToString().Replace($s.text.ToString().Substring($s.text.ToString().IndexOf("["),$s.text.ToString().IndexOf("]")),"").ToString().Replace("[","[gpu_").ToString()}, rhs={$kexpr.st})  
    -> assign(lhs={getkernelstr($s.text)}, rhs={$kexpr.st})
  //|   ARRAY '=' kaexpr -> assign(lhs={$ARRAY.text}, rhs={$kaexpr.st})
  //|   ARRAY '=' atom -> assign(lhs={$ARRAY.text}, rhs={$atom.st})
    |   ID '-=' kexpr {$program::WriteOnly.Add("gpu_"+$ID.text);} -> assignop(lhs={"gpu_"+$ID.text}, rhs={$kexpr.st},op={"-="})
    |   s=ARRAY '-=' kexpr  
	{
    if($program::index=="2D" && ($s.text.ToString().IndexOf("[")!=$s.text.ToString().LastIndexOf("[")))
    	{ 
    		$program::WriteOnly.Add("row"+$s.text.ToString().Replace($s.text.ToString().Substring($s.text.ToString().IndexOf("["),$s.text.ToString().IndexOf("]")),"").ToString());
    	}
    else
    	{
    		$program::WriteOnly.Add(getkernelstr($s.text));
    	}
    }
    -> assignop(lhs={getkernelstr($s.text)}, rhs={$kexpr.st},op={"-="})
    |   ID '+=' kexpr  {$program::WriteOnly.Add("gpu_"+$ID.text);} -> assignop(lhs={"gpu_"+$ID.text}, rhs={$kexpr.st},op={"+="})
    |   s=ARRAY '+=' kexpr  
    {
    if($program::index=="2D" && ($s.text.ToString().IndexOf("[")!=$s.text.ToString().LastIndexOf("[")))
    	{ 
    		$program::WriteOnly.Add("row"+$s.text.ToString().Replace($s.text.ToString().Substring($s.text.ToString().IndexOf("["),$s.text.ToString().IndexOf("]")),"").ToString());
    	}
    else
    	{
    		$program::WriteOnly.Add(getkernelstr($s.text));
    	}
    }
    -> assignop(lhs={getkernelstr($s.text)}, rhs={$kexpr.st},op={"+="})
   // |   ID '=' func_call ->  assignop(lhs={$ID.text}, rhs={$func_call.st},op={"="})
    ;
    
kprint_statement
	: 'printf(' STRING_LITERAL ')' -> type(name={"//printf("+$STRING_LITERAL.text+")"})
	| 'printf(' STRING_LITERAL (',') katom + ')' -> type(name={"//printf("+$STRING_LITERAL.text+","+$katom.st+")"})
	//| 'printf' '(' STRING_LITERAL (',' ID)* ')' -> type(name={"printf("+$STRING_LITERAL.text+","+$ID.text+")"})
	//| 'printf' constant_expression ':' statement
	| 'default' ':' kstatement -> type(name={"default :"+$kstatement.st})
	;
kreturn_statement
:
	  'return' digits -> type(name={"return "+$digits.text +";"})
	| 'return' ID     -> type(name={"return "+$ID.text+";"})
        | 'return' ARRAY  -> type(name={"return "+$ARRAY.text+";"})
	;
	
kwhile_statement
scope slist;
@init {
  $slist::locals = new ArrayList();
  $slist::stats = new ArrayList();
}
	: 'while' '(' kexpr ')' kkblock
	  -> whileLoop(e1={$kexpr.st},
                   locals={$slist::locals}, stats={$slist::stats})
	;
kselection_statement

	: 'if' '(' kcondExpr ')' kstat 	-> type(name={"if ("+ $kcondExpr.st+")" + $kstat.st}) 
	| 'else' kstat			-> type(name={"else " + $kstat.st})
	| 'switch' '(' kexpr ')' kstatement 	-> type(name={"switch ("+ $kexpr.st+")" + $kstatement.st}) 

	;
kstatement
:      kstat ->type(name={$kstat.st})
	;
katom
    : ID {
     int flag=0;
     for(int i=0;i<$program::Constants.Count;i++)
         {
             String mytemps = $program::Constants[i].ToString();
             if (String.Compare($ID.text, mytemps) == 0)
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
    	    $program::ReadOnly.Add("gpu_"+$ID.text);
    }

    }
    -> {flag==1}?
    refVar(id={$ID.text})
    ->refVar(id={"gpu_"+$ID.text})
    | INT -> iconst(value={$INT.text})
    | '(' kaexpr ')'  ->  {$kaexpr.st}
    
    | '[' kaexpr (']'|']]') -> {$kaexpr.st}
    | ']' -> type(name={"]"})
    | s=ARRAY 
    {
    if($program::index=="2D" && ($s.text.ToString().IndexOf("[")!=$s.text.ToString().LastIndexOf("[")))
    	{ 
    		int myflag=0;
    		String pitchstat="";
     		for(int i=0;i<$program::RowsAccessed.Count;i++)
         	{
	             String mytemps = $program::RowsAccessed[i].ToString();
	             if (String.Compare($s.text.ToString().Substring(0,$s.text.ToString().IndexOf("]")+1), mytemps) == 0)
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
			$program::RowsAccessed.Add($s.text.ToString().Substring(0,$s.text.ToString().IndexOf("]")+1));
			$program::RowsAccessed2.Add("row"+$s.text.ToString().Substring(0,$s.text.ToString().IndexOf('['))+$s.text.ToString().Substring(0,$s.text.ToString().IndexOf("]")+1).ToString().Replace($s.text.ToString().Substring(0,$s.text.ToString().IndexOf("[")+1),"").ToString().Replace("]","").ToString().Replace("+","p").ToString().Replace("-","m").ToString());
			
			
			pitchstat="int* "+"row"+$s.text.ToString().Substring(0,$s.text.ToString().IndexOf('['))+$s.text.ToString().Substring(0,$s.text.ToString().IndexOf("]")+1).ToString().Replace($s.text.ToString().Substring(0,$s.text.ToString().IndexOf("[")+1),"").ToString().Replace("]","").ToString().Replace("+","p").ToString().Replace("-","m").ToString()+" = (int* ) ((char* )gpu_"+$s.text.ToString().Substring(0,$s.text.ToString().IndexOf('['))+" + ("+getkernelstr2($s.text.ToString().Substring(0,$s.text.ToString().IndexOf("]")+1).ToString().Replace($s.text.ToString().Substring(0,$s.text.ToString().IndexOf("[")+1),"").ToString().Replace("]",""))+") * "+Get2DArrayDevicePitch($s.text.ToString().Substring(0,$s.text.ToString().IndexOf("[")))+");";
			$program::RowsAccessed5.Add(pitchstat);
				    		
		    }
$program::ReadOnly.Add("row"+$s.text.ToString().Replace($s.text.ToString().Substring($s.text.ToString().IndexOf("["),$s.text.ToString().IndexOf("]")),"").ToString().Replace("[","[gpu_").ToString());	    	    	       
    	}
 	else
  	{
  	$program::ReadOnly.Add(getkernelstr($s.text));
  	}
    }
        ->{$program::index=="2D" && ($s.text.ToString().IndexOf("[")!=$s.text.ToString().LastIndexOf("["))}?
        type(name={"row"+$s.text.ToString().Substring(0,$s.text.ToString().IndexOf('['))+$s.text.ToString().Substring(0,$s.text.ToString().IndexOf("]")+1).ToString().Replace($s.text.ToString().Substring(0,$s.text.ToString().IndexOf("[")+1),"").ToString().Replace("]","").ToString().Replace("+","p").ToString().Replace("-","m").ToString()+$s.text.ToString().Substring($s.text.ToString().IndexOf("]")+1,$s.text.ToString().Length-$s.text.ToString().IndexOf("]")-1).ToString().Replace("[","[gpu_").ToString()})
        //type(name={"row"+$s.text.ToString().Replace($s.text.ToString().Substring($s.text.ToString().IndexOf("["),$s.text.ToString().IndexOf("]")),"").ToString().Replace("[","[gpu_").ToString()})
          
        ->    type(name={getkernelstr($s.text)})
   //->{$s.text.ToString().Contains("-")}? 
    //type(name={("gpu_"+$s.text.Substring(0,$s.text.ToString().IndexOf('['))
    //+ "[gpu_"
    //+$s.text.ToString().Substring($s.text.ToString().IndexOf('[')+1,$s.text.ToString().IndexOf(']')-$s.text.ToString().IndexOf('[')-1)
    
    //+ "]").ToString().Replace("-","-gpu_")})
    //->type(name={"gpu_"+$s.text.Substring(0,$s.text.ToString().IndexOf('['))
    //+ "[gpu_"
    //+$s.text.ToString().Substring($s.text.ToString().IndexOf('[')+1,$s.text.ToString().IndexOf(']')-$s.text.ToString().IndexOf('[')-1)
    
    //+ "]"})

	
    // typr(name={
    //"gpu_"
    //+$ARRAY.text//.ToString().Substring(0,$ARRAY.text.ToString().IndexOf('['))
    //+"gpu_"+$ARRAY.text.ToString().Substring($ARRAY.text.ToString().IndexOf('[')+1,$ARRAY.text.ToString().IndexOf(']')-$ARRAY.text.ToString().IndexOf('[')-1)
    //})

    //| ID '[' kexpr ']' -> refarr(ID={$ID.text},value={$kexpr.st})
  //  | '(' type ')' katom -> -> type(name={"(" + $type.st + ")" + $katom.st})
    ; 
kcondExpr
    :   a=kaexpr 
        (   (  '==' b=kaexpr -> equals(left={$a.st},right={$b.st})
            |  '!=' b=kaexpr -> notequals(left={$a.st},right={$b.st})
            |  '<' b=kaexpr   -> lessThan(left={$a.st},right={$b.st})
            |  '>' b=kaexpr   -> GreaterThan(left={$a.st},right={$b.st})
            |  '<=' b=kaexpr   -> lessThanEq(left={$a.st},right={$b.st})
            |  '>=' b=kaexpr   -> GreaterThanEq(left={$a.st},right={$b.st})
            |  '&&' b=kaexpr   -> CAND(left={$a.st},right={$b.st})
            |  '||' b=kaexpr   -> COR(left={$a.st},right={$b.st})
            
            )
        |   -> {$a.st} // else just aexpr
        
        //|     condExpr     '&&'     condExpr
       // | '(' kaexpr ')' '&&' '(' kaexpr ')'
  //      | '(' kcondExpr  ')'
//        | condExpr ('(')* '||' (')')* condExpr
        )
    ;
kincStat
	:   ID '++' 	-> type(name={"gpu_"+$ID.text + "++"})
	|   ID '--'  	-> type(name={"gpu_"+$ID.text + "--"})
	|   '++' ID  	-> type(name={"++"+"gpu_"+$ID.text})
 	|   '--' ID	-> type(name={"--"+"gpu_"+$ID.text})
 	|   ID '+=' INT	-> type(name={"gpu_"+$ID.text + "+=" + $INT.text})
	|   ID '-=' INT	-> type(name={"gpu_"+$ID.text + "-=" + $INT.text})
	|   ID '*=' INT	-> type(name={"gpu_"+$ID.text + "*=" + $INT.text})
    ;

kexpr:  
	kcondExpr -> {$kcondExpr.st}

    ;
kaexpr
    :   (a=katom -> {$a.st})
        ( '+' b=katom -> add(left={$kaexpr.st}, right={$b.st}) )*
        ( '-' b=katom -> Sub(left={$kaexpr.st}, right={$b.st}) )*
        ( '/' b=katom -> Div(left={$kaexpr.st}, right={$b.st}) )*
        ( '*' b=katom -> Mul(left={$kaexpr.st}, right={$b.st}) )*
        ( '%' b=katom -> Mod(left={$kaexpr.st}, right={$b.st}) )*        
  
    ;   
kkblock
    :  '{'
    	
         //(variable {$slist::locals.Add($variable.st);} )* 
         (kstat {
         for(int i=0;i<$program::RowsAccessed5.Count;i++)
         {
         $slist::stats.Add($program::RowsAccessed5[i]);
         
         }
         $program::RowsAccessed5.Clear();
         $slist::stats.Add($kstat.st);})*
         
       '}'
              
    ; 
mixdeclarator
	:
		(ID|ARRAY) ((',') (ID|ARRAY))* -> {$mixdeclarator.st;}
	;
	MAINS
    	:	
    	    	'main'
    	;

RWORD	:
	'#define'
	
	;
ID  :   ('a'..'z'|'A'..'Z'|'_'|'&') ('a'..'z'|'A'..'Z'|'0'..'9'|'_'|'.')* 

|	('a'..'z'|'A'..'Z'|'_'|'&') ('a'..'z'|'A'..'Z'|'0'..'9'|'_'|'.')* ('=') ((INT)+)
//|	('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')* ('['((INT)|('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')*)']') 
    ;
    


ARRAY	:
	  ('a'..'z'|'A'..'Z'|'_'|'&') ('a'..'z'|'A'..'Z'|'0'..'9'|'_'|'.')* ('[' (INT|ID|ARRAY) ((' ')* ('+'|'-'|'/'|'*') (' ')* (INT|ID|ARRAY))*  ']')+ 
	  | ('a'..'z'|'A'..'Z'|'_'|'&') ('a'..'z'|'A'..'Z'|'0'..'9'|'_'|'.')* ('['  ']')+ 
	//| ('a'..'z'|'A'..'Z'|'_'|'&') ('a'..'z'|'A'..'Z'|'0'..'9'|'_'|'.')* '[' ('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')* ('['((INT)|ID)']') ']'
        //| ('a'..'z'|'A'..'Z'|'_'|'&') ('a'..'z'|'A'..'Z'|'0'..'9'|'_'|'.')* ('[' (' ')* (ARRAY|INT|(('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')*)) (' ')* ('+'|'-'|'/'|'*') (' ')* (ARRAY|INT|(('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')*)) (' ')* ']') (('[' (' ')* (ARRAY|INT|(('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')*)) (' ')* ('+'|'-'|'/'|'*') (' ')* (ARRAY|INT|(('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')*)) (' ')* ']') )*

//	|	('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')* ('['((INT)|(('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')*))']') ((' ')* ('=') (' ')*) ('{'((INT)+ (',' (INT)*)*)'}') 
	;

Keyword	:
	  '<stdio.h>'
	| '<conio.h>'
	| '<string.h>'
	;

INT	:	('-')?('0'..'9')+
	;

WS  :   (' ' | '\t' | '\r' | '\n')+ {$channel=HIDDEN;}
    ;

CHARS
:
('#'|'$'|'<'|'>'|','|'{'|'}'|'('|')'|'/'|'*'|'['|']') ('#'|'$'|'<'|'>'|'.'|','|'{'|'}'|'('|')'|'/'|'*'|'['|']')*
	;   
LINE_COMMENT


    : '//' ~('\n'|'\r')* '\r'? '\n' {$channel=HIDDEN;}

    ;
COMMENT

    :   '/*' ( options {greedy=false;} : . )* '*/' {$channel=HIDDEN;}

    ;
PRINT
    	:	'printf(' ( options {greedy=false;} : . )* ');' //{$channel=HIDDEN;}
    	;
CHARACTER_LITERAL

    :   '\'' ( EscapeSequence | ~('\''|'\\') ) '\''

    ;

STRING_LITERAL

    :  '"' ( EscapeSequence | ~('\\'|'"') )* '"'

	;
fragment
EscapeSequence

    :   '\\' ('b'|'t'|'n'|'f'|'r'|'\"'|'\''|'\\')

    |   OctalEscape

    ;
    
fragment
OctalEscape

    :   '\\' ('0'..'3') ('0'..'7') ('0'..'7')

    |   '\\' ('0'..'7') ('0'..'7')

    |   '\\' ('0'..'7')

    ; 
