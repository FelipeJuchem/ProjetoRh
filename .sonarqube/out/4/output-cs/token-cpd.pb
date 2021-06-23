ˇ-
^C:\Projetos\ProjetoRH\RhProject\RhAPI\Controllers\CandidatosController\CandidatosController.cs
	namespace

 	
RhAPI


 
.

 
Controllers

 
.

  
CandidatosController

 0
{ 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
public 

class  
CandidatosController %
:& '

Controller( 2
{ 
private 
readonly 
ICandidatoExcluidor ,
_candidatoExcluidor- @
;@ A
private 
readonly 
ICandidatoConsulta +
_candidatoConsulta, >
;> ?
private 
readonly !
ICandidatoArmazenador .!
_candidatoArmazenador/ D
;D E
private 
readonly 
ICandidatoAlterador ,
_candidatoAlterador- @
;@ A
public  
CandidatosController #
(# $
ICandidatoConsulta$ 6
candidatoConsulta7 H
,H I!
ICandidatoArmazenadorJ _ 
candidatoArmazenador` t
,t u
ICandidatoExcluidor 
candidatoExcluidor  2
,2 3
ICandidatoAlterador4 G
candidatoAlteradorH Z
)Z [
{ 	
_candidatoExcluidor 
=  !
candidatoExcluidor" 4
;4 5
_candidatoConsulta 
=  
candidatoConsulta! 2
;2 3!
_candidatoArmazenador !
=" # 
candidatoArmazenador$ 8
;8 9
_candidatoAlterador 
=  !
candidatoAlterador" 4
;4 5
} 	
[ 	
HttpGet	 
( 
$str ,
), -
]- .
public 
ActionResult 
< %
CandidatoComTecnologiaDto 5
>5 6
Get7 :
(: ;
int; >
id? A
)A B
{   	
return!! 
_candidatoConsulta!! %
.!!% &'
ObterCandidatoComTecnologia!!& A
(!!A B
id!!B D
)!!D E
;!!E F
}"" 	
[%% 	
HttpGet%%	 
]%% 
public&& 
async&& 
Task&& 
<&& 
ActionResult&& &
<&&& '
List&&' +
<&&+ ,
CandidatoDto&&, 8
>&&8 9
>&&9 :
>&&: ;
Get&&< ?
(&&? @
)&&@ A
{'' 	
try(( 
{)) 
return** 
await** 
_candidatoConsulta** /
.**/ 0 
ObterListaCandidatos**0 D
(**D E
)**E F
;**F G
}++ 
catch,, 
(,, 
	Exception,, 
ex,, 
),, 
{-- 
return.. 

BadRequest.. !
(..! "
ex.." $
...$ %
Message..% ,
).., -
;..- .
}// 
}11 	
[33 	
HttpGet33	 
(33 
$str33 
)33 
]33 
public44 
ActionResult44 
<44 
CandidatoDto44 (
>44( )
GetById44* 1
(441 2
int442 5
id446 8
)448 9
{55 	
try66 
{77 
return88 
_candidatoConsulta88 )
.88) *

ObterPorId88* 4
(884 5
id885 7
)887 8
;888 9
}99 
catch:: 
(:: 
	Exception:: 
ex:: 
):: 
{;; 
return<< 

BadRequest<< !
(<<! "
ex<<" $
.<<$ %
Message<<% ,
)<<, -
;<<- .
}== 
}?? 	
[AA 	
HttpPostAA	 
]AA 
publicBB 
ActionResultBB 
<BB 
CandidatoDtoBB (
>BB( )
PostBB* .
(BB. /
[BB/ 0
FromBodyBB0 8
]BB8 9
CandidatoDtoBB: F
candidatoDtoBBG S
)BBS T
{CC 	
tryDD 
{EE 
returnFF !
_candidatoArmazenadorFF ,
.FF, -
IncluirCandidatoFF- =
(FF= >
candidatoDtoFF> J
)FFJ K
;FFK L
}GG 
catchHH 
(HH 
	ExceptionHH 
exHH 
)HH  
{II 
returnJJ 

BadRequestJJ !
(JJ! "
exJJ" $
.JJ$ %
MessageJJ% ,
)JJ, -
;JJ- .
}KK 
}MM 	
[OO 	
HttpPutOO	 
]OO 
publicPP 
ActionResultPP 
<PP 
CandidatoDtoPP (
>PP( )
PutPP* -
(PP- .
CandidatoDtoPP. :
candidatoDtoPP; G
)PPG H
{QQ 	
tryRR 
{SS 
returnTT 
_candidatoAlteradorTT *
.TT* +
AlterarTT+ 2
(TT2 3
candidatoDtoTT3 ?
)TT? @
;TT@ A
}UU 
catchUU 
(UU 
	ExceptionUU 
exUU 
)UU  
{VV 
returnWW 

BadRequestWW !
(WW! "
exWW" $
.WW$ %
MessageWW% ,
)WW, -
;WW- .
}XX 
}ZZ 	
[\\ 	

HttpDelete\\	 
(\\ 
$str\\ 
)\\ 
]\\ 
public]] 
void]] 
Delete]] 
(]] 
int]] 
id]] !
)]]! "
{^^ 	
_candidatoExcluidor__ 
.__  "
ExcluirCandidatoPeloId__  6
(__6 7
id__7 9
)__9 :
;__: ;
}`` 	
}aa 
}bb !
pC:\Projetos\ProjetoRH\RhProject\RhAPI\Controllers\CandidatoTecnologiaController\CandidatoTecnologiaController.cs
	namespace		 	
RhAPI		
 
.		 
Controllers		 
.		 )
CandidatoTecnologiaController		 9
{

 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
public 

class )
CandidatoTecnologiaController .
:/ 0

Controller1 ;
{ 
private 
readonly +
ICandidatoTecnologiaArmazenador 8+
_candidatoTecnologiaArmazenador9 X
;X Y
private 
readonly (
ICandidatoTecnologiaConsulta 5(
_candidatoTecnologiaConsulta6 R
;R S
private 
readonly )
ICandidatoTecnologiaExcluidor 6)
_candidatoTecnologiaExcluidor7 T
;T U
public )
CandidatoTecnologiaController ,
(, -+
ICandidatoTecnologiaArmazenador- L*
candidatoTecnologiaArmazenadorM k
,k l(
ICandidatoTecnologiaConsulta ('
candidatoTecnologiaConsulta) D
,D E)
ICandidatoTecnologiaExcluidorF c)
candidatoTecnologiaExcluidor	d Ä
)
Ä Å
{ 	+
_candidatoTecnologiaArmazenador +
=, -*
candidatoTecnologiaArmazenador. L
;L M(
_candidatoTecnologiaConsulta (
=) *'
candidatoTecnologiaConsulta+ F
;F G)
_candidatoTecnologiaExcluidor )
=* +(
candidatoTecnologiaExcluidor, H
;H I
} 	
[ 	
HttpPost	 
] 
public 
async 
Task 
< 
ActionResult &
<& '"
CandidatoTecnologiaDto' =
>= >
>> ?
Post@ D
(D E
[E F
FromBodyF N
]N O"
CandidatoTecnologiaDtoP f"
candidatoTecnologiaDtog }
)} ~
{ 	
try 
{   
return!! 
await!! +
_candidatoTecnologiaArmazenador!! <
.!!< =&
IncluirCandidatoTecnologia!!= W
(!!W X"
candidatoTecnologiaDto!!X n
)!!n o
;!!o p
}"" 
catch## 
(## 
	Exception## 
ex## 
)## 
{$$ 
return%% 

BadRequest%% !
(%%! "
ex%%" $
.%%$ %
Message%%% ,
)%%, -
;%%- .
}&& 
})) 	
[++ 	
HttpGet++	 
]++ 
public,, 
async,, 
Task,, 
<,, 
ActionResult,, &
<,,& '
List,,' +
<,,+ ,"
CandidatoTecnologiaDto,,, B
>,,B C
>,,C D
>,,D E
Get,,F I
(,,I J
),,J K
{-- 	
return.. 
await.. (
_candidatoTecnologiaConsulta.. 5
...5 6*
BuscarListaCandidatoTecnologia..6 T
(..T U
)..U V
;..V W
}// 	
[11 	
HttpGet11	 
(11 
$str11 /
)11/ 0
]110 1
public22 "
CandidatoTecnologiaDto22 %
Get22& )
(22) *
int22* -
candidatoId22. 9
,229 :
int22; >
tecnologiaId22? K
)22K L
{33 	
return44 (
_candidatoTecnologiaConsulta44 /
.44/ 0
BuscarPorIdDuplo440 @
(44@ A
candidatoId44A L
,44L M
tecnologiaId44N Z
)44Z [
;44[ \
}55 	
[77 	

HttpDelete77	 
(77 
$str77 2
)772 3
]773 4
public88 
void88 
Delete88 
(88 
int88 
candidatoId88 *
,88* +
int88, /
tecnologiaId880 <
)88< =
{99 	)
_candidatoTecnologiaExcluidor:: )
.::) *
Deletar::* 1
(::1 2
candidatoId::2 =
,::= >
tecnologiaId::? K
)::K L
;::L M
};; 	
}<< 
}== Ê*
^C:\Projetos\ProjetoRH\RhProject\RhAPI\Controllers\TecnologiaController\TecnologiaController.cs
	namespace		 	
RhAPI		
 
.		 
Controllers		 
.		  
TecnologiaController		 0
{

 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
public 

class  
TecnologiaController %
:& '

Controller( 2
{ 
private 
readonly "
ITecnologiaArmazenador /"
_tecnologiaArmazenador0 F
;F G
private 
readonly 
ITecnologiaConsulta ,
_tecnologiaConsulta- @
;@ A
private 
readonly  
ITecnologiaExcluidor - 
_tecnologiaExcluidor. B
;B C
private 
readonly  
ITecnologiaAlterador - 
_tecnologiaAlterador. B
;B C
public  
TecnologiaController #
(# $"
ITecnologiaArmazenador$ :!
tecnologiaArmazenador; P
,P Q
ITecnologiaConsultaR e
tecnologiaConsultaf x
,x y 
ITecnologiaExcluidor  
tecnologiaExcluidor! 4
,4 5 
ITecnologiaAlterador6 J
tecnologiaAlteradorK ^
)^ _
{ 	"
_tecnologiaArmazenador "
=# $!
tecnologiaArmazenador% :
;: ;
_tecnologiaConsulta 
=  !
tecnologiaConsulta" 4
;4 5 
_tecnologiaExcluidor  
=! "
tecnologiaExcluidor# 6
;6 7 
_tecnologiaAlterador  
=! "
tecnologiaAlterador# 6
;6 7
} 	
[ 	
HttpPost	 
] 
public 
ActionResult 
< 
TecnologiaDto )
>) *
Post+ /
(/ 0
[0 1
FromBody1 9
]9 :
TecnologiaDto; H
tecnologiaDtoI V
)V W
{ 	
try   
{!! 
return"" "
_tecnologiaArmazenador"" -
.""- .
IncluirTecnologia"". ?
(""? @
tecnologiaDto""@ M
)""M N
;""N O
}## 
catch$$ 
($$ 
	Exception$$ 
ex$$ 
)$$  
{%% 
return&& 

BadRequest&& !
(&&! "
ex&&" $
.&&$ %
Message&&% ,
)&&, -
;&&- .
}'' 
})) 	
[++ 	
HttpGet++	 
]++ 
public,, 
async,, 
Task,, 
<,, 
ActionResult,, &
<,,& '
List,,' +
<,,+ ,
TecnologiaDto,,, 9
>,,9 :
>,,: ;
>,,; <
Get,,= @
(,,@ A
),,A B
{-- 	
try.. 
{// 
return00 
await00 
_tecnologiaConsulta00 0
.000 1#
ObterListaDeTecnologias001 H
(00H I
)00I J
;00J K
}11 
catch22 
(22 
	Exception22 
ex22 
)22 
{33 
return44 

BadRequest44 !
(44! "
ex44" $
.44$ %
Message44% ,
)44, -
;44- .
}55 
}77 	
[99 	
HttpGet99	 
(99 
$str99 
)99 
]99 
public:: 
TecnologiaDto:: 
GetById:: $
(::$ %
int::% (
id::) +
)::+ ,
{;; 	
return<< 
_tecnologiaConsulta<< &
.<<& ' 
ObterTecnologiaPorId<<' ;
(<<; <
id<<< >
)<<> ?
;<<? @
}== 	
[?? 	

HttpDelete??	 
(?? 
$str?? 
)?? 
]?? 
public@@ 
ActionResult@@ 
Excluir@@ #
(@@# $
int@@$ '
id@@( *
)@@* +
{AA 	
tryBB 
{CC  
_tecnologiaExcluidorDD $
.DD$ %
ExcluirTecnologiaDD% 6
(DD6 7
idDD7 9
)DD9 :
;DD: ;
}EE 
catchEE 
(EE 
	ExceptionEE 
exEE 
)EE  
{FF 
returnGG 

BadRequestGG !
(GG! "
exGG" $
.GG$ %
MessageGG% ,
)GG, -
;GG- .
}HH 
returnII 
OkII 
(II 
)II 
;II 
}JJ 	
[LL 	
HttpPutLL	 
]LL 
publicMM 
ActionResultMM 
<MM 
TecnologiaDtoMM )
>MM) *
PutMM+ .
(MM. /
TecnologiaDtoMM/ <
tecnologiaDtoMM= J
)MMJ K
{NN 	
tryOO 
{PP 
returnQQ  
_tecnologiaAlteradorQQ +
.QQ+ ,
AlterarQQ, 3
(QQ3 4
tecnologiaDtoQQ4 A
)QQA B
;QQB C
}RR 
catchSS 
(SS 
	ExceptionSS 
exSS 
)SS  
{TT 
returnUU 

BadRequestUU !
(UU! "
exUU" $
.UU$ %
MessageUU% ,
)UU, -
;UU- .
}VV 
}XX 	
}ZZ 
}[[ ¥/
TC:\Projetos\ProjetoRH\RhProject\RhAPI\Controllers\VagasController\VagasController.cs
	namespace 	
RhAPI
 
. 
Controllers 
. 
VagasController +
{ 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
public 

class 
VagasController  
:! "

Controller# -
{ 
private 
readonly 
IVagaConsulta &
_vagaConsulta' 4
;4 5
private 
readonly 
IVagaArmazenador )
_vagaArmazenador* :
;: ;
private 
readonly 
IVagaAlterador '
_vagaAlterador( 6
;6 7
private 
readonly 
IVagaExcluidor '
_vagaExcluidor( 6
;6 7
public 
VagasController 
( 
IVagaArmazenador /
vagaArmazenador0 ?
,? @
IVagaConsultaA N
vagaConsultaO [
,[ \
IVagaAlterador] k
vagaAlteradorl y
,y z
IVagaExcluidor 
vagaExcluidor (
)( )
{ 	
_vagaConsulta 
= 
vagaConsulta (
;( )
_vagaArmazenador 
= 
vagaArmazenador .
;. /
_vagaAlterador 
= 
vagaAlterador *
;* +
_vagaExcluidor 
= 
vagaExcluidor *
;* +
} 	
[ 	
HttpPost	 
] 
public 
ActionResult 
< +
VagaComTecnologiaECandidatosDto ;
>; <
Post= A
(A B
[B C
FromBodyC K
]K L+
VagaComTecnologiaECandidatosDtoM l
vagaDtom t
)t u
{   	
try!! 
{"" 
return## 
_vagaArmazenador## '
.##' (
IncluirVaga##( 3
(##3 4
vagaDto##4 ;
)##; <
;##< =
}$$ 
catch$$ 
($$ 
	Exception$$ 
ex$$ 
)$$  
{%% 
return&& 

BadRequest&& !
(&&! "
ex&&" $
.&&$ %
Message&&% ,
)&&, -
;&&- .
}'' 
})) 	
[++ 	
HttpGet++	 
]++ 
public,, 
async,, 
Task,, 
<,, 
List,, 
<,, +
VagaComTecnologiaECandidatosDto,, >
>,,> ?
>,,? @
Get,,A D
(,,D E
),,E F
{-- 	
return.. 
await.. 
_vagaConsulta.. &
...& '
ObterListaDeVagas..' 8
(..8 9
)..9 :
;..: ;
}// 	
[11 	
HttpGet11	 
(11 
$str11 
)11 
]11 
public22 
ActionResult22 
<22 +
VagaComTecnologiaECandidatosDto22 ;
>22; <
Get22= @
(22@ A
int22A D
id22E G
)22G H
{33 	
return44 
_vagaConsulta44  
.44  !'
ObterVagaComTecnologiaPorId44! <
(44< =
id44= ?
)44? @
;44@ A
}55 	
[77 	
HttpGet77	 
(77 
$str77  
)77  !
]77! "
public88 
ActionResult88 
<88 +
VagaComTecnologiaECandidatosDto88 ;
>88; <
GetTeste88= E
(88E F
int88F I
id88J L
)88L M
{99 	
return:: 
_vagaConsulta::  
.::  !'
ObterVagaComTecnologiaPorId::! <
(::< =
id::= ?
)::? @
;::@ A
};; 	
[== 	
HttpGet==	 
(== 
$str== 6
)==6 7
]==7 8
public>> 
ActionResult>> 
<>> '
VagaComCandidatoDtoSorteado>> 7
>>>7 8'
GetVagaComCandidatoSorteado>>9 T
(>>T U
int>>U X
id>>Y [
)>>[ \
{?? 	
return@@ 
_vagaConsulta@@  
.@@  !.
"ObterVagaComCandidatoSorteadoPorId@@! C
(@@C D
id@@D F
)@@F G
;@@G H
}AA 	
[CC 	
HttpPutCC	 
]CC 
publicDD 
ActionResultDD 
<DD +
VagaComTecnologiaECandidatosDtoDD ;
>DD; <
PutDD= @
(DD@ A+
VagaComTecnologiaECandidatosDtoDDA `
vagaDtoDDa h
)DDh i
{EE 	
tryFF 
{GG 
returnHH 
_vagaAlteradorHH %
.HH% &
AlterarHH& -
(HH- .
vagaDtoHH. 5
)HH5 6
;HH6 7
}II 
catchJJ 
(JJ 
	ExceptionJJ 
exJJ 
)JJ  
{KK 
returnLL 

BadRequestLL !
(LL! "
exLL" $
.LL$ %
MessageLL% ,
)LL, -
;LL- .
}MM 
}OO 	
[QQ 	

HttpDeleteQQ	 
(QQ 
$strQQ 
)QQ 
]QQ 
publicRR 
IActionResultRR 
DeleteRR #
(RR# $
intRR$ '
idRR( *
)RR* +
{SS 	
tryTT 
{UU 
_vagaExcluidorVV 
.VV 
ExcluirVagaPeloIdVV 0
(VV0 1
idVV1 3
)VV3 4
;VV4 5
returnWW 
OkWW 
(WW 
)WW 
;WW 
}XX 
catchYY 
(YY 
	ExceptionYY 
exYY 
)YY  
{ZZ 
return[[ 

BadRequest[[ !
([[! "
ex[[" $
.[[$ %
Message[[% ,
)[[, -
;[[- .
}\\ 
}^^ 	
}bb 
}cc ‡"
fC:\Projetos\ProjetoRH\RhProject\RhAPI\Controllers\VagaTecnologiaController\VagaTecnologiaController.cs
	namespace 	
RhAPI
 
. 
Controllers 
. $
VagaTecnologiaController 4
{ 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
public 

class $
VagaTecnologiaController )
:* +

Controller, 6
{ 
private 
readonly $
IVagaTecnologiaExcluidor 1$
_vagaTecnologiaExcluidor2 J
;J K
private 
readonly &
IVagaTecnologiaArmazenador 3&
_vagaTecnologiaArmazenador4 N
;N O
private 
readonly #
IVagaTecnologiaConsulta 0#
_vagaTecnologiaConsulta1 H
;H I
public $
VagaTecnologiaController '
(' (&
IVagaTecnologiaArmazenador( B%
vagaTecnologiaArmazenadorC \
,\ ]#
IVagaTecnologiaConsulta^ u#
vagaTecnologiaConsulta	v å
,
å ç$
IVagaTecnologiaExcluidor $#
vagaTecnologiaExcluidor% <
)< =
{ 	$
_vagaTecnologiaExcluidor $
=% &#
vagaTecnologiaExcluidor' >
;> ?&
_vagaTecnologiaArmazenador &
=' (%
vagaTecnologiaArmazenador) B
;B C#
_vagaTecnologiaConsulta #
=$ %"
vagaTecnologiaConsulta& <
;< =
} 	
[   	
HttpPost  	 
]   
public!! 
ActionResult!! 
<!! 
VagaTecnologiaDto!! -
>!!- .
Post!!/ 3
(!!3 4
[!!4 5
FromBody!!5 =
]!!= >
VagaTecnologiaDto!!? P
vagaTecnologiaDto!!Q b
)!!b c
{"" 	
return## &
_vagaTecnologiaArmazenador## -
.##- .!
IncluirVagaTecnologia##. C
(##C D
vagaTecnologiaDto##D U
)##U V
;##V W
}$$ 	
[&& 	
HttpGet&&	 
]&& 
public'' 
async'' 
Task'' 
<'' 
List'' 
<'' 
VagaTecnologiaDto'' 0
>''0 1
>''1 2
Get''3 6
(''6 7
)''7 8
{(( 	
return)) 
await)) #
_vagaTecnologiaConsulta)) 0
.))0 1%
BuscarListaVagaTecnologia))1 J
())J K
)))K L
;))L M
}** 	
[,, 	
HttpGet,,	 
(,, 
$str,, *
),,* +
],,+ ,
public-- 
VagaTecnologiaDto--  
Get--! $
(--$ %
int--% (
vagaId--) /
,--/ 0
int--1 4
tecnologiaId--5 A
)--A B
{.. 	
return// #
_vagaTecnologiaConsulta// *
.//* +$
BuscaVagaTecnologiaPorId//+ C
(//C D
vagaId//D J
,//J K
tecnologiaId//L X
)//X Y
;//Y Z
}00 	
[22 	

HttpDelete22	 
(22 
$str22 -
)22- .
]22. /
public33 
async33 
Task33 
<33 
ActionResult33 &
>33& '
Delete33( .
(33. /
int33/ 2
vagaId333 9
,339 :
int33; >
tecnologiaId33? K
)33K L
{44 	
try55 
{66 
var77 
	resultado77 
=77 
await77  %$
_vagaTecnologiaExcluidor77& >
.77> ?
Deletar77? F
(77F G
vagaId77G M
,77M N
tecnologiaId77O [
)77[ \
;77\ ]
if88 
(88 
	resultado88 
)88 
{99 
return:: 
Ok:: 
(:: 
):: 
;::  
};; 
return<< 

BadRequest<< !
(<<! "
$str	<<" Ã
)
<<Ã Õ
;
<<Õ Œ
}== 
catch>> 
(>> 
	Exception>> 
ex>> 
)>> 
{?? 
return@@ 

BadRequest@@ !
(@@! "
ex@@" $
.@@$ %
Message@@% ,
)@@, -
;@@- .
}AA 
}BB 	
}CC 
}DD ó

0C:\Projetos\ProjetoRH\RhProject\RhAPI\Program.cs
	namespace

 	
RhAPI


 
{ 
public 

static 
class 
Program 
{ 
public 
static 
void 
Main 
(  
string  &
[& '
]' (
args) -
)- .
{ 	
CreateHostBuilder 
( 
args "
)" #
.# $
Build$ )
() *
)* +
.+ ,
Run, /
(/ 0
)0 1
;1 2
} 	
public 
static 
IHostBuilder "
CreateHostBuilder# 4
(4 5
string5 ;
[; <
]< =
args> B
)B C
=>D F
Host 
.  
CreateDefaultBuilder %
(% &
args& *
)* +
. $
ConfigureWebHostDefaults )
() *

webBuilder* 4
=>5 7
{ 

webBuilder 
. 

UseStartup )
<) *
Startup* 1
>1 2
(2 3
)3 4
;4 5
} 
) 
; 
} 
} ú)
0C:\Projetos\ProjetoRH\RhProject\RhAPI\Startup.cs
	namespace 	
RhAPI
 
{ 
public 

class 
Startup 
{ 
public 
Startup 
( 
IConfiguration $
configuration% 2
)2 3
{ 	
Configuration 
= 
configuration )
;) *
} 	
public 
IConfiguration 
Configuration +
{, -
get. 1
;1 2
}3 4
public 
void 
ConfigureServices %
(% &
IServiceCollection& 8
services9 A
)A B
{ 	
services 
. 
AddCors 
( 
options $
=>% '
{ 
options 
. 
	AddPolicy !
(! "
$str" .
,. /
builder0 7
=>8 :
builder; B
. 
AllowAnyOrigin #
(# $
)$ %
.   
AllowAnyMethod   #
(  # $
)  $ %
.!! 
AllowAnyHeader!! #
(!!# $
)!!$ %
)!!% &
;!!& '
}"" 
)"" 
;"" 
services%% 
.%% 
AddControllers%% #
(%%# $
)%%$ %
;%%% &
RhIOC&& 
.&& 
Startup&& 
.&& 
ConfigureServices&& +
(&&+ ,
services&&, 4
,&&4 5
Configuration&&6 C
)&&C D
;&&D E
services(( 
.(( 
AddAutoMapper(( "
(((" #
typeof((# )
((() *
AutoMapperSetup((* 9
)((9 :
)((: ;
;((; <
services** 
.** 
AddSwaggerGen** "
(**" #
c**# $
=>**% '
{++ 
c,, 
.,, 

SwaggerDoc,, 
(,, 
$str,, !
,,,! "
new,,# &
OpenApiInfo,,' 2
{,,3 4
Title,,5 :
=,,; <
$str,,= D
,,,D E
Version,,F M
=,,N O
$str,,P T
},,U V
),,V W
;,,W X
}-- 
)-- 
;-- 
}.. 	
public11 
void11 
	Configure11 
(11 
IApplicationBuilder11 1
app112 5
,115 6
IWebHostEnvironment117 J
env11K N
)11N O
{22 	
app44 
.44 
Use44 
(44 
async44 
(44 
context44 "
,44" #
next44$ (
)44( )
=>44* ,
{55 
await66 
next66 
.66 
Invoke66 !
(66! "
)66" #
;66# $
string88 
method88 
=88 
context88  '
.88' (
Request88( /
.88/ 0
Method880 6
;886 7
var99 "
allowedMethodsToCommit99 *
=99+ ,
new99- 0
string991 7
[997 8
]998 9
{99: ;
$str99< B
,99B C
$str99D I
,99I J
$str99K S
}99T U
;99U V
if:: 
(:: "
allowedMethodsToCommit:: *
.::* +
Contains::+ 3
(::3 4
method::4 :
)::: ;
)::; <
{;; 
var<< 

unitOfWork<< "
=<<# $
(<<% &
IUnitOfWork<<& 1
)<<1 2
context<<2 9
.<<9 :
RequestServices<<: I
.<<I J

GetService<<J T
(<<T U
typeof<<U [
(<<[ \
IUnitOfWork<<\ g
)<<g h
)<<h i
;<<i j

unitOfWork== 
.== 
Commit== %
(==% &
)==& '
;==' (
}>> 
}?? 
)?? 
;?? 
ifAA 
(AA 
envAA 
.AA 
IsDevelopmentAA !
(AA! "
)AA" #
)AA# $
{BB 
appCC 
.CC %
UseDeveloperExceptionPageCC -
(CC- .
)CC. /
;CC/ 0
appDD 
.DD 

UseSwaggerDD 
(DD 
)DD  
;DD  !
appEE 
.EE 
UseSwaggerUIEE  
(EE  !
cEE! "
=>EE# %
cEE& '
.EE' (
SwaggerEndpointEE( 7
(EE7 8
$strEE8 R
,EER S
$strEET ^
)EE^ _
)EE_ `
;EE` a
}FF 
appHH 
.HH 
UseCorsHH 
(HH 
$strHH $
)HH$ %
;HH% &
appJJ 
.JJ 

UseRoutingJJ 
(JJ 
)JJ 
;JJ 
appLL 
.LL 
UseAuthorizationLL  
(LL  !
)LL! "
;LL" #
appNN 
.NN 
UseEndpointsNN 
(NN 
	endpointsNN &
=>NN' )
{OO 
	endpointsPP 
.PP 
MapControllersPP (
(PP( )
)PP) *
;PP* +
}QQ 
)QQ 
;QQ 
}RR 	
}SS 
}TT 