grammar Expression;

/*
 * Parser Rules
 */


exp : '(' exp ')'               #parensExp
    | exp (MUL|DIV) exp         #mulDivExp
	| exp (PLUS|MINUS) exp      #addSubExp
	| <assoc=right> exp '^' exp #powExp
	| NUMBER                    #numExp
    ;


/*
 * Lexer Rules
 */

PLUS  : NUMBER '+' NUMBER ;
MINUS : NUMBER '-' NUMBER ;
MUL  : NUMBER '*' NUMBER ;
DIV  : NUMBER '/' NUMBER ;

fragment DIGIT : [0-9] ;
NUMBER         : DIGIT+ ([.,] DIGIT+)? ;

WHITESPACE : ' ' -> skip ;