grammar PatternGenerator;

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
		
}
pattern
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
  String kernelpar;
  String kernelpar2;
  String temp;
  }

@init {
  $pattern::globals = new ArrayList();
  $pattern::functions = new ArrayList();
  $pattern::includes = new ArrayList();
  $pattern::mainstats = new ArrayList();
  $pattern::kernelvars = new ArrayList();
  $pattern::kernelcopyin = new ArrayList();
  $pattern::kernelcopyout = new ArrayList();
  $pattern::kernelalloc = new ArrayList();
  $pattern::kernelvarfree = new ArrayList();
  $pattern::kernelvarsize = new ArrayList();

}
    :   declaration+
    		-> pattern(kernelfunction={$pattern::functions})
    ;
    
    declaration
    	:	
    kernelfunction  {$pattern::functions.Add($kernelfunction.st);}
   
    ;


// ack is $function.st ambig?  It can mean the rule's dyn scope or
// the ref in this rule.  Ack.




variable
    :   type  declarator ';'
        -> variable(type={$type.st},name={$declarator.st})
      |  type arraydeclarator ';'
        -> variable(type={$type.st},name={$arraydeclarator.st})
    ;
    
statement
:      stat ->type(name={$stat.st})
	;
	
statement_list
	: statement+
	;



include
:       type kdeclarator 
//	-> include(name={$include.st})
	-> include(type={$type.st},name={$kdeclarator.st})
	
	;

define
:
	rdeclarator declarator t+=digits ('.' t+=digits)*
	-> define(type={$rdeclarator.st},name={$declarator.st},val={ArraytoString((ArrayList)$t,".")})
	;

declarator
    :   ID -> {new StringTemplate($ID.text)} 
    
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


    
kernelfunction
scope {
  String name;
}
scope slist;
@init {
	$slist::locals = new ArrayList();
	$slist::stats = new ArrayList();
}
  :  cudafunctiontype type 'kernel' {$kernelfunction::name="kernel";}
        '(' ( p+=formalParameter ( ',' p+=formalParameter )* )? ')'
        block
        -> kernelfunction(cudafunctiontype={$cudafunctiontype.st},type={$type.st}, name={"kernel"},
                    locals={$slist::locals},
                    stats={$slist::stats},
                   args={$p})
    ;

formalParameter
    :   type (declarator)*
        -> parameter(type={$type.st},name={$declarator.st})
    ;



type
    :   'int'  		-> type_int()
    |   'char' 		-> type_char()
    |   'float' 	-> type_float()
    |   'bool'		-> type_bool()
    |   'kernel'	-> type_kernel()
    |   'void'		-> type(name={"void"})
    |   'double'		-> type(name={"double"})
    |   'size_t'		-> type(name={"size_t"})
    |   'cudaDeviceProp'-> type(name={"cudaDeviceProp"})
    //|   ID     		-> type_user_object(name={$ID.text})
    //|   CHARS 		-> type_user_object(name={$CHARS.text})
//    |   INT 		-> type_user_object(name={$INT.text})
    |   '#include' 	-> type(name={"#include"})
    |   '#define' 	-> type(name={"#define"})
    //|   KID    -> type_kernel_object(name={$KID.text})
    ;

cudafunctiontype
:
		'__global__' -> type(name={"__global__"})
	|	'__device__' -> type(name={"__device__"})
	|	'__shared__' -> type(name={"__shared__"})
	;

block
    :  '{'
         (variable {$slist::locals.Add($variable.st);} )* 
         (stat {$slist::stats.Add($stat.st);})*
        // (kblock {$slist::stats.Add($kblock.st);})*
        // (kernel_variable {$pattern::kernelvars.Add($kernel_variable.st);})*
        // (kernel_array {$pattern::kernelvars.Add($kernel_array.st);})*
         
       '}'
              
    ;

stat
scope slist;
@init {
  $slist::locals = new ArrayList();
  $slist::stats = new ArrayList();
}
    : forStat -> {$forStat.st}
    | expr ';' -> statement(expr={$expr.st})
    | block -> statementList(locals={$slist::locals}, stats={$slist::stats})
    | assignStat ';' -> type(name={"assignStat"})
    | print_statement ';' -> {$print_statement.st}
    | selection_statement  -> {$selection_statement.st}
    | while_statement  -> {$while_statement.st}
    | return_statement ';' -> {$return_statement.st}
    | func_call ';' -> {$func_call.st}
    | pitchstat ';' -> type(name={"pitchstat"})
    //| funcstat ';' -> {$funcstat.st}
    //| function -> {$function.st}
//    | dirExpr->statement(expr={$dirExpr.st})
    | ';' -> {new StringTemplate(";")}
    ;

pitchstat
	:
	type '*' ID '=' '(' type '*' ')' '(''(' type '*' ')' ID	'+' '(' expr ')' '*' ID ')'
	;

forStat
scope slist;
@init {
  $slist::locals = new ArrayList();
  $slist::stats = new ArrayList();
}
    :   'for' '(' e1=assignStat ';' e2=expr ';' e3=incStat ')' block
        -> forLoop(e1={$e1.st},e2={$e2.st.ToString()},e3={$e3.st},
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

    ;

print_statement
	: 'printf(' STRING_LITERAL ')' -> type(name={"printf("+$STRING_LITERAL.text+");"})
	//| 'printf(' STRING_LITERAL (( r+=',' atom )+ )   ')' -> type(name={"printf("+$STRING_LITERAL.text+","+$r+")"})
	| 'printf(' {$pattern::temp="";} STRING_LITERAL ((',' {$pattern::temp+=",";} printfParameter )+  )   ')' -> type(name={"printf("+$STRING_LITERAL.text+$pattern::temp+");"})
	| 'fprintf(' ID ',' STRING_LITERAL ')' -> type(name={"fprintf("+$ID.text+","+$STRING_LITERAL.text+");"})
	| 'fprintf(' ID ',' STRING_LITERAL ( r+=',' printfParameter )+    ')' -> type(name={"printf("+$ID.text+","+$STRING_LITERAL.text+$printfParameter.st+");"})
	//| 'printf' '(' STRING_LITERAL (',' ID)* ')' -> type(name={"printf("+$STRING_LITERAL.text+","+$ID.text+")"})
	//| 'printf' constant_expression ':' statement
	| 'default' ':' statement -> type(name={"default :"+$statement.st})	
	;
printfParameter
    :   aexpr {$pattern::temp+=$aexpr.st;} 
        -> type(name={$aexpr.st})
    // | ',' ARRAY
    ;

return_statement
:
	  'return' digits -> type(name={"return "+$digits.text +";"})
	| 'return' ID     -> type(name={"return "+$ID.text+";"})
        | 'return' ARRAY  -> type(name={"return "+$ARRAY.text+";"})
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
	;
selection_statement

	: 'if' '(' condExpr ')' stat //('else' statement)?
	-> type(name={"Conditionif ()" +$stat.st})// + "else " + $statement.st}) 
	| 'else' stat -> type(name={"Condition else " +$stat.st})
	//| 'switch' '(' expr ')' stat -> type(name={"switch ("+$expr.st+")" +$stat.st}) 

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
 	|   ID '+=' INT	-> type(name={"gpu_"+$ID.text + "+=" + $INT.text})
	|   ID '-=' INT	-> type(name={"gpu_"+$ID.text + "-=" + $INT.text})
	|   ID '*=' INT	-> type(name={"gpu_"+$ID.text + "*=" + $INT.text})
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
func_call
:
	ID '(' ')'
	;
atom
    : ID  -> refVar(id={$ID.text})
    | ARRAY -> refVar(id={$ARRAY.text})  
    | INT -> iconst(value={$INT.text})
    | RWORD ->refVar(id={$RWORD.text})
    | '(' expr ')' -> {$expr.st} 
   | '[' expr ']' -> {$expr.st}
    
   // | FUNC_CALL->refVar(id={$FUNC_CALL.text})
   // | func_call -> {$func_call.st}
 //   | ID '()' -> type(name={$ID.text+"()"})
  //  | ID '('+(declarator)*+')' -> type(name={$ID.text+"("+$declarator.st+")"})
  //  | ID '[' expr ']' -> {$expr.st}
    ; 
     

RWORD	:
	'#define'
	
	;
ID  :   ('a'..'z'|'A'..'Z'|'_'|'&'|'*'|'**') ('a'..'z'|'A'..'Z'|'0'..'9'|'_'|'.')* 
|	('a'..'z'|'A'..'Z'|'_'|'&'|'*'|'**') ((',') ('a'..'z'|'A'..'Z'|'0'..'9'|'_'|'.')) 
|	('a'..'z'|'A'..'Z'|'_'|'&'|'*'|'**') ('a'..'z'|'A'..'Z'|'0'..'9'|'_'|'.')* ('=') ((INT)+)
//|	('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')* ('['((INT)|('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')*)']') 
    ;

ARRAY	:
	  ('a'..'z'|'A'..'Z'|'_'|'&'|'*'|'**') ('a'..'z'|'A'..'Z'|'0'..'9'|'_'|'.')* ('['((INT)|ID)']')+ 
	| ('a'..'z'|'A'..'Z'|'_'|'&'|'*'|'**') ('a'..'z'|'A'..'Z'|'0'..'9'|'_'|'.')* '[' ('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')* ('['((INT)|ID)']') ']'
        | ('a'..'z'|'A'..'Z'|'_'|'&') ('a'..'z'|'A'..'Z'|'0'..'9'|'_'|'.')* ('[' (' ')* (ARRAY|INT|(('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')*)) (' ')* ('+'|'-'|'/'|'*') (' ')* (ARRAY|INT|(('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')*)) (' ')* ']') 

//	|	('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')* ('['((INT)|(('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')*))']') ((' ')* ('=') (' ')*) ('{'((INT)+ (',' (INT)*)*)'}') 
	;

Keyword	:
	  '<stdio.h>'
	| '<conio.h>'
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
