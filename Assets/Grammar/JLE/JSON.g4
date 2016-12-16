grammar JSON;

@members
{
	public Compiler compiler = new Compiler();
}

INT : '-'? ('0'..'9')+ ;
STRING : [a-zA-Z_]+ ;
LEFTPAR : '(' ;
RIGHTPAR : ')' ;
LEFTSQ: '{' ;
RIGHTSQ : '}' ;
SEMICOLON : ';' ;
COMMA : ',' ;
LESSERTHAN : '<' ;
GREATERTHAN : '>' ;
PLUS: '+' ;
MINUS: '-' ;

WS : [ \t\r\n]+ -> skip ;

start
    : prog EOF
    ;

prog
    : (function)+ function
    | function
    ;

function
    : function_use
    | function_declaration
	| for_cycle
    ;

function_use
    : identifier=STRING
      LEFTPAR
      param_id_list?
      RIGHTPAR {compiler.FunctionManager.addFunctionUse($identifier.text, $param_id_list.text); }
      SEMICOLON { compiler.FunctionManager.ErrorManager.checkLineEnding($SEMICOLON.text); }
    ;

function_inside_function
	: identifier=STRING
      LEFTPAR
      param_id_list?
      RIGHTPAR {compiler.FunctionManager.addFunctionToCurrent($identifier.text, $param_id_list.text); }
      SEMICOLON { compiler.FunctionManager.ErrorManager.checkLineEnding($SEMICOLON.text); }
    ;

function_declaration
    : function_type=STRING
      identifier=STRING {compiler.FunctionManager.addDeclaredFunction($function_type.text, $identifier.text); }
	  LEFTPAR
      param_decl_list?
	  RIGHTPAR
	  LEFTSQ
	  (function_inside_function | for_cycle)*
	  RIGHTSQ
	;

for_cycle
	: 'for'
	   LEFTPAR
	   'int' val_dec=STRING '=' val_init=INT SEMICOLON
	   val_use=STRING LESSERTHAN val_total=INT SEMICOLON
	   val_inc=STRING PLUS PLUS
	   RIGHTPAR { compiler.FunctionManager.addForCycle($val_dec.text, $val_init.text, $val_use.text, $val_total.text, $val_inc.text); }
	   LEFTSQ
	   function_inside_function*
	   RIGHTSQ { compiler.FunctionManager.addForCycleCommands(); }
	;
	
param_id_list
    : (param_id COMMA)+ param_id
    | param_id
    ;

param_decl_list
    : (param_decl COMMA)+ param_decl
    | param_decl
    ;

param_decl
    : param_type=STRING param_identifier=STRING
    ;

param_id
    : STRING
    | INT
    ;

statement_list
    : statement_list statement
    |
    ;

statement
    : function_use
    ;