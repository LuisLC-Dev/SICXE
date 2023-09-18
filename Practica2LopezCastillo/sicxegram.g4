grammar sicxegram;

options {							
    language=CSharp2;								//lenguaje objetivo de la gramatica
}


prog:    inicio proposiciones fin;

inicio     :    ID 'START' NUM;

fin    :   'END' entrada?;

entrada    :    ID;

proposiciones  : proposicion+;

proposicion    : instruccion | directiva ;

instruccion:    etiq opinstruccion;

directiva:    etiq tipodirectiva opdirectiva;

tipodirectiva:    | 'BYTE' | 'WORD' | 'RESB' | 'RESW' | 'BASE';

etiq:    ID?;

opinstruccion:    formato;

formato    :    f1 | f2 | f3 | f4;

f1    :    CODOP;

f2    :    CODOP NUM | CODOP REG | CODOP REG', 'REG | CODOP REG', 'NUM| CODOP REG', X';

f3    :    simple3 | indirecto3 | inmediato3;

f4    :    '+'f3;

simple3    :    CODOP ID | CODOP NUM | CODOP NUM ', X'| CODOP ID ', X';

indirecto3:    CODOP '@'NUM | CODOP '@'ID;

inmediato3:    CODOP '#'NUM| CODOP '#'ID;

opdirectiva:    NUM | consthex | constcad | ID;

CODOP	:	'ADD' | 'ADDF' | 'ADDR' | 'AND' | 'CLEAR' | 'COMP' |
		'COMPF' | 'COMPR' | 'DIV' | 'DIVF' | 'DIVR' | 'FIX' | 
		'FLOAT' | 'HIO' | 'J' | 'JEQ' | 'JGT' | 'JLT' | 'JSUB' | 
		'LDA'| 'LDB' | 'LDCH' | 'LDF' | 'LDL' | 'LDS' | 'LDT' | 
		'LDX' | 'LPS' | 'MUL' | 'MULF' | 'MULR' | 'NORM' | 'OR' | 
		'RD' | 'RMO' | 'RSUB' | 'SHIFTL' | 'SHIFTR' | 'SIO' | 
		'SSK' | 'STA' | 'STB' | 'STCH' | 'STF' | 'STI' | 'STL' | 
		'STS' | 'STSW' | 'STT' | 'STX' | 'SUB' | 'SUBF' | 'SUBR' | 
		'SVC' | 'TD' | 'TIO' | 'TIX' | 'TIXR' | 'WD';  

REG            : 'A'|'X'|'L'|'B'|'S'|'T'|'F'|'CP'|'PC'|'SW';

NUM            : ('0'..'9')+ | ('0'..'9'|'A'..'F')+('h'|'H');

consthex       : 'X\''NUM'\'';

constcad       : 'C\''ID'\'';

ID             : ('a'..'z'|'A'..'Z')('a'..'z'|'A'..'Z'|'0'..'9')*;


FINL 	:	'\n';

WS
	: (' '|'\r'|'\n'|'\t')+ {Skip();}	//tokens que identifican las secuencas de escape.
	;


compileUnit:
			   prog EOF;

