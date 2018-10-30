grammar Expression;

/*
 * Parser Rules
 */


exp : exp (mul|div) exp      #expMulDiv
    | exp (add|sub) exp      #expAddSub
	| exp pow exp            #expPow
	| (expNum|expParens)     #expAtom
    ;

	
expNum : NUMBER ;
expParens : '(' exp ')' ;

add : ADD ;
sub : SUB ;
mul : MUL ;
div : DIV ;
pow : POW ;



/*
 * Lexer Rules
 */

ADD : '+' ;
SUB : '-' ;
MUL : '*' ;
DIV : '÷' ;
POW : '^' ;

fragment DIGIT : [0-9] ;
NUMBER         : DIGIT+ ([.,] DIGIT+)? ;

WHITESPACE : ' ' -> skip ;