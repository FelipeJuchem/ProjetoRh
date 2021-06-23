ÅM
0C:\Projetos\ProjetoRH\RhProject\RhIOC\Startup.cs
	namespace 	
RhIOC
 
{ 
public 

static 
class 
Startup 
{ 
public 
static 
void 
ConfigureServices ,
(, -
IServiceCollection- ?
services@ H
,H I
IConfigurationJ X
configurationY f
)f g
{ 	
services 
. 
AddDbContext !
<! "
DataContext" -
>- .
(. /
options/ 6
=>7 9
options: A
.A B
UseSqlServerB N
(N O
configurationO \
[\ ]
$str] {
]{ |
)| }
)} ~
;~ 
services 
. 
	AddScoped 
( 
typeof %
(% &
IUnitOfWork& 1
)1 2
,2 3
typeof4 :
(: ;

UnitOfWork; E
)E F
)F G
;G H
services   
.   
	AddScoped   
(   
typeof   %
(  % &
IRepository  & 1
<  1 2
,  2 3
>  3 4
)  4 5
,  5 6
typeof  7 =
(  = >

Repository  > H
<  H I
,  I J
>  J K
)  K L
)  L M
;  M N
services!! 
.!! 
	AddScoped!! 
(!! 
typeof!! %
(!!% &
ICandidatoConsulta!!& 8
)!!8 9
,!!9 :
typeof!!; A
(!!A B
CandidatoConsulta!!B S
)!!S T
)!!T U
;!!U V
services"" 
."" 
	AddScoped"" 
("" 
typeof"" %
(""% & 
ICandidatoRepository""& :
)"": ;
,""; <
typeof""= C
(""C D
CandidatoRepository""D W
)""W X
)""X Y
;""Y Z
services## 
.## 
	AddScoped## 
(## 
typeof## %
(##% &
IVagaRepository##& 5
)##5 6
,##6 7
typeof##8 >
(##> ?
VagaRepository##? M
)##M N
)##N O
;##O P
services$$ 
.$$ 
	AddScoped$$ 
($$ 
typeof$$ %
($$% &%
IVagaTecnologiaRepository$$& ?
)$$? @
,$$@ A
typeof$$B H
($$H I$
VagaTecnologiaRepository$$I a
)$$a b
)$$b c
;$$c d
services%% 
.%% 
	AddScoped%% 
(%% 
typeof%% %
(%%% &!
ICandidatoArmazenador%%& ;
)%%; <
,%%< =
typeof%%> D
(%%D E 
CandidatoArmazenador%%E Y
)%%Y Z
)%%Z [
;%%[ \
services&& 
.&& 
	AddScoped&& 
(&& 
typeof&& %
(&&% & 
ICandidatoValidation&&& :
)&&: ;
,&&; <
typeof&&= C
(&&C D
CandidatoValidation&&D W
)&&W X
)&&X Y
;&&Y Z
services'' 
.'' 
	AddScoped'' 
('' 
typeof'' %
(''% &
ICandidatoExcluidor''& 9
)''9 :
,'': ;
typeof''< B
(''B C
CandidatoExcluidor''C U
)''U V
)''V W
;''W X
services(( 
.(( 
	AddScoped(( 
((( 
typeof(( %
(((% &
IVagaArmazenador((& 6
)((6 7
,((7 8
typeof((9 ?
(((? @
VagaArmazenador((@ O
)((O P
)((P Q
;((Q R
services)) 
.)) 
	AddScoped)) 
()) 
typeof)) %
())% &
IVagaValidation))& 5
)))5 6
,))6 7
typeof))8 >
())> ?
VagaValidation))? M
)))M N
)))N O
;))O P
services** 
.** 
	AddScoped** 
(** 
typeof** %
(**% &
IVagaConsulta**& 3
)**3 4
,**4 5
typeof**6 <
(**< =
VagaConsulta**= I
)**I J
)**J K
;**K L
services++ 
.++ 
	AddScoped++ 
(++ 
typeof++ %
(++% &
IVagaAlterador++& 4
)++4 5
,++5 6
typeof++7 =
(++= >
VagaAlterador++> K
)++K L
)++L M
;++M N
services,, 
.,, 
	AddScoped,, 
(,, 
typeof,, %
(,,% &
IVagaExcluidor,,& 4
),,4 5
,,,5 6
typeof,,7 =
(,,= >
VagaExcluidor,,> K
),,K L
),,L M
;,,M N
services-- 
.-- 
	AddScoped-- 
(-- 
typeof-- %
(--% &
ICandidatoAlterador--& 9
)--9 :
,--: ;
typeof--< B
(--B C
CandidatoAlterador--C U
)--U V
)--V W
;--W X
services.. 
... 
	AddScoped.. 
(.. 
typeof.. %
(..% &!
ITecnologiaValidation..& ;
)..; <
,..< =
typeof..> D
(..D E 
TecnologiaValidation..E Y
)..Y Z
)..Z [
;..[ \
services// 
.// 
	AddScoped// 
(// 
typeof// %
(//% &"
ITecnologiaArmazenador//& <
)//< =
,//= >
typeof//? E
(//E F!
TecnologiaArmazenador//F [
)//[ \
)//\ ]
;//] ^
services00 
.00 
	AddScoped00 
(00 
typeof00 %
(00% &
ITecnologiaConsulta00& 9
)009 :
,00: ;
typeof00< B
(00B C
TecnologiaConsulta00C U
)00U V
)00V W
;00W X
services11 
.11 
	AddScoped11 
(11 
typeof11 %
(11% &!
ITecnologiaRepository11& ;
)11; <
,11< =
typeof11> D
(11D E 
TecnologiaRepository11E Y
)11Y Z
)11Z [
;11[ \
services22 
.22 
	AddScoped22 
(22 
typeof22 %
(22% & 
ITecnologiaExcluidor22& :
)22: ;
,22; <
typeof22= C
(22C D
TecnologiaExcluidor22D W
)22W X
)22X Y
;22Y Z
services33 
.33 
	AddScoped33 
(33 
typeof33 %
(33% & 
ITecnologiaAlterador33& :
)33: ;
,33; <
typeof33= C
(33C D
TecnologiaAlterador33D W
)33W X
)33X Y
;33Y Z
services44 
.44 
	AddScoped44 
(44 
typeof44 %
(44% &&
IVagaTecnologiaArmazenador44& @
)44@ A
,44A B
typeof44C I
(44I J%
VagaTecnologiaArmazenador44J c
)44c d
)44d e
;44e f
services55 
.55 
	AddScoped55 
(55 
typeof55 %
(55% &#
IVagaTecnologiaConsulta55& =
)55= >
,55> ?
typeof55@ F
(55F G"
VagaTecnologiaConsulta55G ]
)55] ^
)55^ _
;55_ `
services66 
.66 
	AddScoped66 
(66 
typeof66 %
(66% &$
IVagaTecnologiaExcluidor66& >
)66> ?
,66? @
typeof66A G
(66G H#
VagaTecnologiaExcluidor66H _
)66_ `
)66` a
;66a b
services77 
.77 
	AddScoped77 
(77 
typeof77 %
(77% &*
ICandidatoTecnologiaRepository77& D
)77D E
,77E F
typeof77G M
(77M N)
CandidatoTecnologiaRepository77N k
)77k l
)77l m
;77m n
services88 
.88 
	AddScoped88 
(88 
typeof88 %
(88% &+
ICandidatoTecnologiaArmazenador88& E
)88E F
,88F G
typeof88H N
(88N O*
CandidatoTecnologiaArmazenador88O m
)88m n
)88n o
;88o p
services99 
.99 
	AddScoped99 
(99 
typeof99 %
(99% &(
ICandidatoTecnologiaConsulta99& B
)99B C
,99C D
typeof99E K
(99K L'
CandidatoTecnologiaConsulta99L g
)99g h
)99h i
;99i j
services:: 
.:: 
	AddScoped:: 
(:: 
typeof:: %
(::% &)
ICandidatoTecnologiaExcluidor::& C
)::C D
,::D E
typeof::F L
(::L M(
CandidatoTecnologiaExcluidor::M i
)::i j
)::j k
;::k l
services;; 
.;; 
	AddScoped;; 
(;; 
typeof;; %
(;;% &+
ICandidatoTecnologiaValidations;;& E
);;E F
,;;F G
typeof;;H N
(;;N O*
CandidatoTecnologiaValidations;;O m
);;m n
);;n o
;;;o p
services<< 
.<< 
	AddScoped<< 
(<< 
typeof<< %
(<<% &-
!IPermitirExclusaoDeVagaTecnologia<<& G
)<<G H
,<<H I
typeof<<J P
(<<P Q,
 PermitirExclusaoDeVagaTecnologia<<Q q
)<<q r
)<<r s
;<<s t
services== 
.== 
	AddScoped== 
(== 
typeof== %
(==% &'
IPermitirExclusaoTecnologia==& A
)==A B
,==B C
typeof==D J
(==J K&
PermitirExclusaoTecnologia==K e
)==e f
)==f g
;==g h
}>> 	
}?? 
}AA 