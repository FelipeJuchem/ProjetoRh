∂E
FC:\Projetos\ProjetoRH\RhProject\RhDomain\AutoMapper\AutoMapperSetup.cs
	namespace 	
RhDomain
 
. 

AutoMapper 
{ 
public 

class 
AutoMapperSetup  
:! "
Profile# *
{ 
public 
AutoMapperSetup 
( 
)  
{ 	
	CreateMap 
< 
	Candidato 
,  2
&CandidatoComTecnologiaParaArmazenarDto! G
>G H
(H I
)I J
. 
	ForMember 
( 
x 
=> 
x  !
.! "
CandidatoId" -
,- .
y/ 0
=>1 3
y4 5
.5 6
MapFrom6 =
(= >
t> ?
=>@ B
tC D
.D E
IdE G
)G H
)H I
. 
	ForMember 
( 
x 
=> 
x  !
.! "
VagaId" (
,( )
y* +
=>, .
y/ 0
.0 1
MapFrom1 8
(8 9
t9 :
=>; =
t> ?
.? @
VagaId@ F
)F G
)G H
. 
	ForMember 
( 
x 
=> 
x  !
.! "
TecnologiaId" .
,. /
y0 1
=>2 4
y5 6
.6 7
MapFrom7 >
(> ?
t? @
=>A C
tD E
.E F
VagaF J
.J K
VagasTecnologiasK [
.[ \
FirstOrDefault\ j
(j k
)k l
.l m
TecnologiaIdm y
)y z
)z {
. 
	ForMember 
( 
x 
=> 
x  !
.! "
Peso" &
,& '
y( )
=>* ,
y- .
.. /
MapFrom/ 6
(6 7
t7 8
=>9 ;
t< =
.= >
Vaga> B
.B C
VagasTecnologiasC S
.S T
FirstOrDefaultT b
(b c
)c d
.d e
Pesoe i
)i j
)j k
;k l
	CreateMap 
< 
	Candidato 
,  
CandidatoDto! -
>- .
(. /
)/ 0
. 
	ForMember 
( 
x 
=> 
x  !
.! "
VagaDescricao" /
,/ 0
y1 2
=>3 5
y6 7
.7 8
MapFrom8 ?
(? @
t@ A
=>B D
tE F
.F G
VagaG K
.K L
	DescricaoL U
)U V
)V W
;W X
	CreateMap 
< 
	Candidato 
,  %
CandidatoComTecnologiaDto! :
>: ;
(; <
)< =
.   
	ForMember   
(   
x   
=>   
x    !
.  ! "
	Pontuacao  " +
,  + ,
y  - .
=>  / 1
y  2 3
.  3 4
Ignore  4 :
(  : ;
)  ; <
)  < =
.!! 
	ForMember!! 
(!! 
x!! 
=>!! 
x!!  !
.!!! "
Tecnologias!!" -
,!!- .
y!!/ 0
=>!!1 3
y!!4 5
.!!5 6
MapFrom!!6 =
(!!= >
t!!> ?
=>!!@ B
t!!C D
.!!D E!
CandidatosTecnologias!!E Z
."" 
Select"" 
("" 
o"" 
=>"" 
new""  
TecnologiaDto""! .
("". /
)""/ 0
{## 
	Descricao## 
=## 
o## 
.##  

Tecnologia##  *
.##* +
	Descricao##+ 4
,##4 5
Id##6 8
=##9 :
o##; <
.##< =

Tecnologia##= G
.##G H
Id##H J
,##J K
Peso##L P
=##Q R
o##S T
.##T U
Peso##U Y
}##Z [
)##[ \
)##\ ]
)##] ^
;##^ _
	CreateMap%% 
<%% 
Vaga%% 
,%% '
VagaComCandidatoDtoSorteado%% 7
>%%7 8
(%%8 9
)%%9 :
.&& 
	ForMember&& 
(&& 
x&& 
=>&& 
x&&  !
.&&! "
Tecnologias&&" -
,&&- .
y&&/ 0
=>&&1 3
y&&4 5
.&&5 6
MapFrom&&6 =
(&&= >
t&&> ?
=>&&@ B
t&&C D
.&&D E
VagasTecnologias&&E U
.'' 
Select'' 
('' 
o'' 
=>'' 
new''  
TecnologiaDto''! .
(''. /
)''/ 0
{(( 
	Descricao(( 
=(( 
o(( 
.((  

Tecnologia((  *
.((* +
	Descricao((+ 4
,((4 5
Id((6 8
=((9 :
o((; <
.((< =

Tecnologia((= G
.((G H
Id((H J
,((J K
Peso((L P
=((Q R
o((S T
.((T U
Peso((U Y
}((Z [
)(([ \
)((\ ]
)((] ^
.)) 
	ForMember)) 
()) 
x)) 
=>)) 
x))  !
.))! "

Candidatos))" ,
,)), -
y)). /
=>))0 2
y))3 4
.))4 5
MapFrom))5 <
())< =
t))= >
=>))? A
t))B C
.))C D

Candidatos))D N
)))N O
)))O P
;))P Q
	CreateMap++ 
<++ 
Vaga++ 
,++ +
VagaComTecnologiaECandidatosDto++ ;
>++; <
(++< =
)++= >
.,, 
	ForMember,, 
(,, 
x,, 
=>,, 
x,,  !
.,,! "
Tecnologias,," -
,,,- .
y,,/ 0
=>,,1 3
y,,4 5
.,,5 6
MapFrom,,6 =
(,,= >
t,,> ?
=>,,@ B
t,,C D
.,,D E
VagasTecnologias,,E U
.-- 
Select-- 
(-- 
o-- 
=>-- 
new--  
TecnologiaDto--! .
(--. /
)--/ 0
{.. 
	Descricao.. 
=.. 
o.. 
...  

Tecnologia..  *
...* +
	Descricao..+ 4
,..4 5
Id..6 8
=..9 :
o..; <
...< =

Tecnologia..= G
...G H
Id..H J
,..J K
Peso..L P
=..Q R
o..S T
...T U
Peso..U Y
}..Z [
)..[ \
)..\ ]
)..] ^
.// 
	ForMember// 
(// 
x// 
=>// 
x//  !
.//! "

Candidatos//" ,
,//, -
y//. /
=>//0 2
y//3 4
.//4 5
MapFrom//5 <
(//< =
t//= >
=>//? A
t//B C
.//C D

Candidatos//D N
)//N O
)//O P
;//P Q
	CreateMap00 
<00 
Vaga00 
,00 
VagaDto00 #
>00# $
(00$ %
)00% &
;00& '
	CreateMap11 
<11 

Tecnologia11  
,11  !
TecnologiaDto11" /
>11/ 0
(110 1
)111 2
.22 
	ForMember22 
(22 
x22 
=>22 
x22  !
.22! "
Peso22" &
,22& '
y22( )
=>22* ,
y22- .
.22. /
MapFrom22/ 6
(226 7
o227 8
=>229 ;
o22< =
.22= >
VagasTecnologias22> N
.22N O
FirstOrDefault22O ]
(22] ^
)22^ _
.22_ `
Peso22` d
)22d e
)22e f
;22f g
	CreateMap33 
<33 
VagaTecnologia33 $
,33$ %
VagaTecnologiaDto33& 7
>337 8
(338 9
)339 :
;33: ;
	CreateMap44 
<44 
CandidatoTecnologia44 )
,44) *"
CandidatoTecnologiaDto44+ A
>44A B
(44B C
)44C D
.55 
	ForMember55 
(55 
x55 
=>55 
x55  !
.55! "
Peso55" &
,55& '
y55( )
=>55* ,
y55- .
.55. /
MapFrom55/ 6
(556 7
o557 8
=>559 ;
o55< =
.55= >

Tecnologia55> H
.55H I
VagasTecnologias55I Y
.55Y Z
FirstOrDefault55Z h
(55h i
)55i j
.55j k
Peso55k o
)55o p
)55p q
;55q r
}77 	
}88 
}99 õ
IC:\Projetos\ProjetoRH\RhProject\RhDomain\Dto\CandidatoComTecnologiaDto.cs
	namespace 	
RhDomain
 
. 
Dto 
{ 
public 

class %
CandidatoComTecnologiaDto *
{ 
public		 
int		 
Id		 
{		 
get		 
;		 
set		  
;		  !
}		" #
public

 
string

 
Nome

 
{

 
get

  
;

  !
set

" %
;

% &
}

' (
public 
string 
	Sobrenome 
{  !
get" %
;% &
set' *
;* +
}, -
public 
double 
Idade 
{ 
get !
;! "
set# &
;& '
}( )
public 
string 
Cpf 
{ 
get 
;  
set! $
;$ %
}& '
public 
int 
VagaId 
{ 
get 
;  
set! $
;$ %
}& '
public 
int 
	Pontuacao 
{ 
get "
;" #
set$ '
;' (
}) *
public 
List 
< 
TecnologiaDto !
>! "
Tecnologias# .
{/ 0
get1 4
;4 5
set6 9
;9 :
}; <
} 
} õ
VC:\Projetos\ProjetoRH\RhProject\RhDomain\Dto\CandidatoComTecnologiaParaArmazenarDto.cs
	namespace 	
RhDomain
 
. 
Dto 
{ 
public 

class 2
&CandidatoComTecnologiaParaArmazenarDto 7
{ 
public		 
int		 
CandidatoId		 
{		  
get		! $
;		$ %
set		& )
;		) *
}		+ ,
public

 
int

 
VagaId

 
{

 
get

 
;

  
set

! $
;

$ %
}

& '
public 
int 
TecnologiaId 
{  !
get" %
;% &
set' *
;* +
}, -
public 
int 
Peso 
{ 
get 
; 
set "
;" #
}$ %
} 
} à
<C:\Projetos\ProjetoRH\RhProject\RhDomain\Dto\CandidatoDto.cs
	namespace 	
RhDomain
 
. 
Dto 
{ 
public 

class 
CandidatoDto 
{ 
public		 
int		 
Id		 
{		 
get		 
;		 
set		  
;		  !
}		" #
public

 
string

 
Nome

 
{

 
get

  
;

  !
set

" %
;

% &
}

' (
public 
string 
	Sobrenome 
{  !
get" %
;% &
set' *
;* +
}, -
public 
double 
Idade 
{ 
get !
;! "
set# &
;& '
}( )
public 
string 
Cpf 
{ 
get 
;  
set! $
;$ %
}& '
public 
int 
VagaId 
{ 
get 
;  
set! $
;$ %
}& '
public 
string 
VagaDescricao #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
List 
< 
TecnologiaDto !
>! "
Tecnologias# .
{/ 0
get1 4
;4 5
set6 9
;9 :
}; <
} 
} ‰
FC:\Projetos\ProjetoRH\RhProject\RhDomain\Dto\CandidatoTecnologiaDto.cs
	namespace 	
RhDomain
 
. 
Dto 
{ 
public 

class "
CandidatoTecnologiaDto '
{ 
public		 
int		 
TecnologiaId		 
{		  !
get		" %
;		% &
set		' *
;		* +
}		, -
public

 
int

 
CandidatoId

 
{

  
get

! $
;

$ %
set

& )
;

) *
}

+ ,
public 
int 
Peso 
{ 
get 
; 
set "
;" #
}$ %
} 
} …
=C:\Projetos\ProjetoRH\RhProject\RhDomain\Dto\TecnologiaDto.cs
	namespace 	
RhDomain
 
. 
Dto 
{ 
public 

class 
TecnologiaDto 
{		 
public

 
int

 
Id

 
{

 
get

 
;

 
set

  
;

  !
}

" #
public 
string 
	Descricao 
{  !
get" %
;% &
set' *
;* +
}, -
public 
int 
Peso 
{ 
get 
; 
set "
;" #
}$ %
} 
} á
KC:\Projetos\ProjetoRH\RhProject\RhDomain\Dto\VagaComCandidatoDtoSorteado.cs
	namespace 	
RhDomain
 
. 
Dto 
{ 
public 

class '
VagaComCandidatoDtoSorteado ,
{ 
public		 
int		 
Id		 
{		 
get		 
;		 
set		  
;		  !
}		" #
public

 
string

 
	Descricao

 
{

  !
get

" %
;

% &
set

' *
;

* +
}

, -
public 
List 
< 
TecnologiaDto !
>! "
Tecnologias# .
{/ 0
get1 4
;4 5
set6 9
;9 :
}; <
public 
List 
< %
CandidatoComTecnologiaDto -
>- .

Candidatos/ 9
{: ;
get< ?
;? @
setA D
;D E
}F G
} 
} Ç
OC:\Projetos\ProjetoRH\RhProject\RhDomain\Dto\VagaComTecnologiaECandidatosDto.cs
	namespace 	
RhDomain
 
. 
Dto 
{ 
public 

class +
VagaComTecnologiaECandidatosDto 0
{		 
public

 
int

 
Id

 
{

 
get

 
;

 
set

  
;

  !
}

" #
public 
string 
	Descricao 
{  !
get" %
;% &
set' *
;* +
}, -
public 
List 
< 
TecnologiaDto !
>! "
Tecnologias# .
{/ 0
get1 4
;4 5
set6 9
;9 :
}; <
public 
List 
< 
CandidatoDto  
>  !

Candidatos" ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
} 
} ®
7C:\Projetos\ProjetoRH\RhProject\RhDomain\Dto\VagaDto.cs
	namespace 	
RhDomain
 
. 
Dto 
{ 
public 

class 
VagaDto 
{ 
public		 
int		 
Id		 
{		 
get		 
;		 
set		  
;		  !
}		" #
public

 
string

 
	Descricao

 
{

  !
get

" %
;

% &
set

' *
;

* +
}

, -
} 
} ’
AC:\Projetos\ProjetoRH\RhProject\RhDomain\Dto\VagaTecnologiaDto.cs
	namespace 	
RhDomain
 
. 
Dto 
{ 
public 

class 
VagaTecnologiaDto "
{ 
public		 
int		 
VagaId		 
{		 
get		 
;		  
set		! $
;		$ %
}		& '
public

 
int

 
TecnologiaId

 
{

  !
get

" %
;

% &
set

' *
;

* +
}

, -
public 
int 
Peso 
{ 
get 
; 
set "
;" #
}$ %
} 
} ›
^C:\Projetos\ProjetoRH\RhProject\RhDomain\Entities\CandidatosTecnologias\CandidatoTecnologia.cs
	namespace 	
RhDomain
 
. 
Entities 
. !
CandidatosTecnologias 1
{ 
public		 

class		 
CandidatoTecnologia		 $
{

 
public 
int 
CandidatoId 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
	Candidato 
	Candidato "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
int 
TecnologiaId 
{  !
get" %
;% &
set' *
;* +
}, -
public 

Tecnologia 

Tecnologia $
{% &
get' *
;* +
set, /
;/ 0
}1 2
public 
int 
Peso 
{ 
get 
; 
set "
;" #
}$ %
public 
CandidatoTecnologia "
(" #
int# &
candidatoId' 2
,2 3
int4 7
tecnologiaId8 D
,D E
intF I
pesoJ N
)N O
{ 	
CandidatoId 
= 
candidatoId %
;% &
TecnologiaId 
= 
tecnologiaId '
;' (
Peso 
= 
peso 
; 
} 	
} 
}  
IC:\Projetos\ProjetoRH\RhProject\RhDomain\Entities\Candidatos\Candidato.cs
	namespace		 	
RhDomain		
 
.		 
Entities		 
.		 

Candidatos		 &
{

 
public 

class 
	Candidato 
{ 
public 
int 
Id 
{ 
get 
; 
private $
set% (
;( )
}* +
public 
string 
Nome 
{ 
get  
;  !
private" )
set* -
;- .
}/ 0
public 
string 
	Sobrenome 
{  !
get" %
;% &
private' .
set/ 2
;2 3
}4 5
public 
double 
Idade 
{ 
get !
;! "
private# *
set+ .
;. /
}0 1
public 
string 
Cpf 
{ 
get 
;  
private! (
set) ,
;, -
}. /
public 
int 
VagaId 
{ 
get 
;  
private! (
set) ,
;, -
}. /
public 
Vaga 
Vaga 
{ 
get 
; 
private  '
set( +
;+ ,
}- .
public 
IList 
< 
CandidatoTecnologia (
>( )!
CandidatosTecnologias* ?
{@ A
getB E
;E F
setH K
;K L
}M N
public 
	Candidato 
( 
) 
{ 	
} 	
public 
	Candidato 
( 
string 
nome  $
,$ %
string& ,
	sobrenome- 6
,6 7
double8 >
idade? D
,D E
stringF L
cpfM P
,P Q
intR U
vagaIdV \
)\ ]
{ 	
Nome 
= 
nome 
; 
	Sobrenome 
= 
	sobrenome !
;! "
Idade 
= 
idade 
; 
Cpf   
=   
cpf   
;   
VagaId!! 
=!! 
vagaId!! 
;!! 
}## 	
public%% 
void%% 
	Atualizar%% 
(%% 
string%% $
nome%%% )
,%%) *
string%%+ 1
	sobrenome%%2 ;
,%%; <
double%%= C
idade%%D I
,%%I J
string%%K Q
cpf%%R U
,%%U V
int%%W Z
vagaId%%[ a
)%%a b
{&& 	
Nome'' 
='' 
nome'' 
;'' 
	Sobrenome(( 
=(( 
	sobrenome(( !
;((! "
Idade)) 
=)) 
idade)) 
;)) 
Cpf** 
=** 
cpf** 
;** 
VagaId++ 
=++ 
vagaId++ 
;++ 
},, 	
}11 
}22 ƒ
KC:\Projetos\ProjetoRH\RhProject\RhDomain\Entities\Tecnologias\Tecnologia.cs
	namespace		 	
RhDomain		
 
.		 
Entities		 
.		 
Tecnologias		 '
{

 
public 

class 

Tecnologia 
{ 
public 
int 
Id 
{ 
get 
; 
private $
set% (
;( )
}* +
public 
string 
	Descricao 
{  !
get" %
;% &
private' .
set/ 2
;2 3
}4 5
public 
IList 
< 
VagaTecnologia #
># $
VagasTecnologias% 5
{6 7
get8 ;
;; <
private= D
setE H
;H I
}J K
public 
IList 
< 
CandidatoTecnologia (
>( )!
CandidatosTecnologias* ?
{@ A
getB E
;E F
privateG N
setO R
;R S
}T U
public 

Tecnologia 
( 
) 
{ 	
} 	
public 

Tecnologia 
( 
string  
	descricao! *
)* +
{ 	
	Descricao 
= 
	descricao !
;! "
} 	
public 
void 
AtualizarDescricao &
(& '
string' -
	descricao. 7
)7 8
{ 	
	Descricao 
= 
	descricao !
;! "
} 	
}   
}!! –
TC:\Projetos\ProjetoRH\RhProject\RhDomain\Entities\VagasTecnologias\VagaTecnologia.cs
	namespace 	
RhDomain
 
. 
Entities 
. 
VagasTecnologias ,
{ 
public		 

class		 
VagaTecnologia		 
{

 
public 
int 
VagaId 
{ 
get 
;  
set! $
;$ %
}& '
public 
int 
TecnologiaId 
{  !
get" %
;% &
set' *
;* +
}, -
public 
int 
Peso 
{ 
get 
; 
set "
;" #
}$ %
public 
virtual 
Vaga 
Vaga  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
virtual 

Tecnologia !

Tecnologia" ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
public 
VagaTecnologia 
( 
int !
vagaId" (
,( )
int* -
tecnologiaId. :
,: ;
int< ?
peso@ D
)D E
{ 	
VagaId 
= 
vagaId 
; 
TecnologiaId 
= 
tecnologiaId '
;' (
Peso 
= 
peso 
; 
} 	
} 
} 
?C:\Projetos\ProjetoRH\RhProject\RhDomain\Entities\Vagas\Vaga.cs
	namespace 	
RhDomain
 
. 
Entities 
. 
Vagas !
{		 
public

 

class

 
Vaga

 
{ 
public 
int 
Id 
{ 
get 
; 
private $
set% (
;( )
}* +
public 
string 
	Descricao 
{  !
get" %
;% &
private' .
set/ 2
;2 3
}4 5
public 
IList 
< 
	Candidato 
> 

Candidatos  *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
public 
IList 
< 
VagaTecnologia #
># $
VagasTecnologias% 5
{6 7
get8 ;
;; <
private= D
setE H
;H I
}J K
	protected 
Vaga 
( 
) 
{ 	
} 	
public 
Vaga 
( 
string 
	descricao $
)$ %
{ 	
	Descricao 
= 
	descricao !
;! "
} 	
public 
void 
	Atualizar 
( 
string $
	descricao% .
). /
{ 	
	Descricao 
= 
	descricao !
;! "
} 	
}   
}!! ¨
XC:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Repositories\ICandidatoRepository.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Repositories *
{		 
public

 

	interface

  
ICandidatoRepository

 )
:

* +
IRepository

, 7
<

7 8
int

8 ;
,

; <
	Candidato

= F
>

F G
{ 
	Candidato 2
&BuscaCandidatoTecnologiaComTecnologias 8
(8 9
int9 <
id= ?
)? @
;@ A
	Candidato 2
&BuscarParaArmazenarCandidatoTecnologia 8
(8 92
&CandidatoComTecnologiaParaArmazenarDto9 _3
&candidatoComTecnologiaParaArmazenarDto	` Ü
)
Ü á
;
á à
Task 
< 
List 
< 
	Candidato 
> 
> 1
%BuscarListaCandidatosComVagaDescricao C
(C D
)D E
;E F
} 
} á
bC:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Repositories\ICandidatoTecnologiaRepository.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Repositories *
{ 
public 

	interface *
ICandidatoTecnologiaRepository 3
:4 5
IRepository6 A
<A B
intB E
,E F
CandidatoTecnologiaG Z
>Z [
{		 
CandidatoTecnologia

 /
#BuscarCandidatoTecnologiaporDuploId

 ?
(

? @
int

@ C
candidatoId

D O
,

O P
int

Q T
tecnologiaId

U a
)

a b
;

b c
CandidatoTecnologia 4
(BuscarCandidatoTecnologiaPorTecnologiaId D
(D E
intE H
tecnologiaIdI U
)U V
;V W
} 
} ÿ	
OC:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Repositories\IRepository.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Repositories *
{ 
public 

	interface 
IRepository  
<  !
TId! $
,$ %
TEntity& -
>- .
where		 
TId		 
:		 
struct		 
where

 
TEntity

 
:

 
class

 
{ 
void 
	Armazenar 
( 
TEntity 
obj "
)" #
;# $
void 
Excluir 
( 
TEntity 
obj  
)  !
;! "
TEntity 
BuscarPorId 
( 
TId 
Id  "
)" #
;# $
Task 
< 
List 
< 
TEntity 
> 
> 
BuscarLista '
(' (
)( )
;) *
TEntity 
	Alterador 
( 
TEntity !
obj" %
)% &
;& '
} 
} ⁄
YC:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Repositories\ITecnologiaRepository.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Repositories *
{ 
public 

	interface !
ITecnologiaRepository *
:+ ,
IRepository- 8
<8 9
int9 <
,= >

Tecnologia? I
>I J
{		 
}

 
} …
SC:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Repositories\IVagaRepository.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Repositories *
{		 
public

 

	interface

 
IVagaRepository

 $
:

% &
IRepository

' 2
<

2 3
int

3 6
,

6 7
Vaga

8 <
>

< =
{ 
Vaga 
BuscaVagaComInclude  
(  !
int! $
id% '
)' (
;( )
} 
} •
]C:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Repositories\IVagaTecnologiaRepository.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Repositories *
{ 
public		 

	interface		 %
IVagaTecnologiaRepository		 .
:		/ 0
IRepository		1 <
<		< =
int		= @
,		@ A
VagaTecnologia		B P
>		P Q
{

 
Task 
< 
VagaTecnologia 
> )
BuscaVagaTecnologiaPorIdDuplo :
(: ;
int; >
vagaId? E
,E F
intG J
tecnologiaIdK W
)W X
;X Y
VagaTecnologia .
"BuscaVagaTecnologiaPorTecnologiaId 9
(9 :
int: =
tecnologiaId> J
)J K
;K L
VagaTecnologia (
BuscaVagaTecnologiaPorVagaId 3
(3 4
int4 7
vagaId8 >
)> ?
;? @
} 
} ¬
~C:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Services\CandidatoTecnologiaValidations\ICandidatoTecnologiaValidations.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Services &
.& '*
CandidatoTecnologiaValidations' E
{ 
public 

	interface +
ICandidatoTecnologiaValidations 4
{ 
}

 
} ∞
qC:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Services\CandidatoValidationInterface\ICandidatoValidation.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Services &
.& '(
CandidatoValidationInterface' C
{ 
public 

	interface  
ICandidatoValidation )
{		 
bool

 
validar

 
(

 
CandidatoDto

 !
candidatoDto

" .
)

. /
;

/ 0
} 
} Ù
SC:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Services\ICandidatoAlterador.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Services &
{ 
public 

	interface 
ICandidatoAlterador (
{		 
public

 
CandidatoDto

 
Alterar

 #
(

# $
CandidatoDto

$ 0
candidatoDto

1 =
)

= >
;

> ?
} 
} •
UC:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Services\ICandidatoArmazenador.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Services &
{		 
public

 

	interface

 !
ICandidatoArmazenador

 *
{ 
ActionResult 
< 
CandidatoDto !
>! "
IncluirCandidato# 3
(3 4
CandidatoDto4 @
candidatoDtoA M
)M N
;N O
} 
} ≤
RC:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Services\ICandidatoConsulta.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Services &
{		 
public

 

	interface

 
ICandidatoConsulta

 '
{ 
Task 
< 
List 
< 
CandidatoDto 
> 
>   
ObterListaCandidatos! 5
(5 6
)6 7
;7 8
CandidatoDto 

ObterPorId 
(  
int  #
id$ &
)& '
;' (%
CandidatoComTecnologiaDto !'
ObterCandidatoComTecnologia" =
(= >
int> A
idB D
)D E
;E F2
&CandidatoComTecnologiaParaArmazenarDto .2
&BuscarParaArmazenarCandidatoTecnologia/ U
(U V2
&CandidatoComTecnologiaParaArmazenarDto 22
&candidatoComTecnologiaParaArmazenarDto3 Y
)Y Z
;Z [
} 
} ‘
SC:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Services\ICandidatoExcluidor.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Services &
{ 
public		 

	interface		 
ICandidatoExcluidor		 (
{

 
void "
ExcluirCandidatoPeloId #
(# $
int$ '
id( *
)* +
;+ ,
} 
} Ÿ
_C:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Services\ICandidatoTecnologiaArmazenador.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Services &
{ 
public		 

	interface		 +
ICandidatoTecnologiaArmazenador		 4
{

 
Task 
< "
CandidatoTecnologiaDto #
># $&
IncluirCandidatoTecnologia% ?
(? @"
CandidatoTecnologiaDto@ V"
candidatoTecnologiaDtoW m
)m n
;n o
} 
} í
\C:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Services\ICandidatoTecnologiaConsulta.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Services &
{ 
public		 

	interface		 (
ICandidatoTecnologiaConsulta		 1
{

 
Task 
< 
List 
< "
CandidatoTecnologiaDto (
>( )
>) **
BuscarListaCandidatoTecnologia+ I
(I J
)J K
;K L"
CandidatoTecnologiaDto 
BuscarPorIdDuplo /
(/ 0
int0 3
candidatoId4 ?
,? @
intA D
TecnologiaIdE Q
)Q R
;R S
} 
} ú
]C:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Services\ICandidatoTecnologiaExcluidor.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Services &
{ 
public 

	interface )
ICandidatoTecnologiaExcluidor 2
{		 
void

 
Deletar

 
(

 
int

 
candidatoId

 $
,

$ %
int

& )
tecnologiaId

* 6
)

6 7
;

7 8
} 
} ∂
aC:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Services\IPermitirExclusaoDeVagaTecnologia.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Services &
{ 
public 

	interface -
!IPermitirExclusaoDeVagaTecnologia 6
{ 
bool		 *
ValidaExclusaoDeVagaTecnologia		 +
(		+ ,
int		, /
vagaId		0 6
,		6 7
int		8 ;
tecnologiaId		< H
)		H I
;		I J
}

 
} 
[C:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Services\IPermitirExclusaoTecnologia.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Services &
{ 
public 

	interface '
IPermitirExclusaoTecnologia 0
{ 
bool		 $
ValidaExclusaoTecnologia		 %
(		% &
int		& )
tecnologiaId		* 6
)		6 7
;		7 8
}

 
} Â
TC:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Services\ITecnologiaAlterador.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Services &
{ 
public 

	interface  
ITecnologiaAlterador )
{		 
TecnologiaDto

 
Alterar

 
(

 
TecnologiaDto

 +
tecnologiaDto

, 9
)

9 :
;

: ;
} 
} ´
VC:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Services\ITecnologiaArmazenador.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Services &
{ 
public		 

	interface		 "
ITecnologiaArmazenador		 +
{

 
ActionResult 
< 
TecnologiaDto "
>" #
IncluirTecnologia$ 5
(5 6
TecnologiaDto6 C
tecnologiaDtoD Q
)Q R
;R S
} 
} ®
SC:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Services\ITecnologiaConsulta.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Services &
{ 
public		 

	interface		 
ITecnologiaConsulta		 (
{

 
Task 
< 
List 
< 
TecnologiaDto 
>  
>  !#
ObterListaDeTecnologias" 9
(9 :
): ;
;; <
TecnologiaDto  
ObterTecnologiaPorId *
(* +
int+ .
id/ 1
)1 2
;2 3
} 
} —
TC:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Services\ITecnologiaExcluidor.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Services &
{ 
public 

	interface  
ITecnologiaExcluidor )
{ 
bool		 
ExcluirTecnologia		 
(		 
int		 "
id		# %
)		% &
;		& '
}

 
} ˜
NC:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Services\IVagaAlterador.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Services &
{ 
public 

	interface 
IVagaAlterador #
{		 +
VagaComTecnologiaECandidatosDto

 '
Alterar

( /
(

/ 0+
VagaComTecnologiaECandidatosDto

0 O
vagaDto

P W
)

W X
;

X Y
} 
} ∑
PC:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Services\IVagaArmazenador.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Services &
{ 
public		 

	interface		 
IVagaArmazenador		 %
{

 
ActionResult 
< +
VagaComTecnologiaECandidatosDto 4
>4 5
IncluirVaga6 A
(A B+
VagaComTecnologiaECandidatosDtoB a
vagaDtob i
)i j
;j k
} 
} ¸
MC:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Services\IVagaConsulta.cs
	namespace		 	
RhDomain		
 
.		 

Interfaces		 
.		 
Services		 &
{

 
public 

	interface 
IVagaConsulta "
{ 
Task 
< 
List 
< +
VagaComTecnologiaECandidatosDto 1
>1 2
>2 3
ObterListaDeVagas4 E
(E F
)F G
;G H+
VagaComTecnologiaECandidatosDto ''
ObterVagaComTecnologiaPorId( C
(C D
intD G
idH J
)J K
;K L
public '
VagaComCandidatoDtoSorteado *.
"ObterVagaComCandidatoSorteadoPorId+ M
(M N
intN Q
idR T
)T U
;U V
} 
} ≈
NC:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Services\IVagaExcluidor.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Services &
{ 
public 

	interface 
IVagaExcluidor #
{ 
void		 
ExcluirVagaPeloId		 
(		 
int		 "
id		# %
)		% &
;		& '
}

 
} ã
ZC:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Services\IVagaTecnologiaArmazenador.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Services &
{ 
public 

	interface &
IVagaTecnologiaArmazenador /
{		 
VagaTecnologiaDto

 !
IncluirVagaTecnologia

 /
(

/ 0
VagaTecnologiaDto

0 A
vagaTecnologiaDto

B S
)

S T
;

T U
} 
} ¸
WC:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Services\IVagaTecnologiaConsulta.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Services &
{ 
public		 

	interface		 #
IVagaTecnologiaConsulta		 ,
{

 
Task 
< 
List 
< 
VagaTecnologiaDto #
># $
>$ %%
BuscarListaVagaTecnologia& ?
(? @
)@ A
;A B
VagaTecnologiaDto $
BuscaVagaTecnologiaPorId 2
(2 3
int3 6
vagaId7 =
,= >
int? B
tecnologiaIdC O
)O P
;P Q
} 
} Ω
XC:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Services\IVagaTecnologiaExcluidor.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Services &
{ 
public		 

	interface		 $
IVagaTecnologiaExcluidor		 -
{

 
Task 
< 
bool 
> 
Deletar 
( 
int 
vagaId %
,% &
int' *
tecnologiaId+ 7
)7 8
;8 9
} 
} Ω
jC:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Services\TecnologiaValidation\ITecnologiaValidation.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Services &
.& ' 
TecnologiaValidation' ;
{ 
public 

	interface !
ITecnologiaValidation *
{		 
bool

 ,
 ValidaSeTecnologiaEstaPreenchido

 -
(

- .
TecnologiaDto

. ;
tecnologiaDto

< I
)

I J
;

J K
} 
} ¿
gC:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\Services\VagaValidationInterface\IVagaValidation.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 
Services &
.& '#
VagaValidationInterface' >
{ 
public 

	interface 
IVagaValidation $
{		 
bool

 )
ValidaSeVagaDtoEstaPreenchido

 *
(

* ++
VagaComTecnologiaECandidatosDto

+ J
vagaDto

K R
)

R S
;

S T
} 
} ˚
MC:\Projetos\ProjetoRH\RhProject\RhDomain\Interfaces\UnitOfWork\IUnitOfWork.cs
	namespace 	
RhDomain
 
. 

Interfaces 
. 

UnitOfWork (
{ 
public 

	interface 
IUnitOfWork  
{		 
CommandResponse

 
Commit

 
(

 
)

  
;

  !
void 
ResetChanges 
( 
) 
; 
} 
} ¬
YC:\Projetos\ProjetoRH\RhProject\RhDomain\Services\CandidatoServices\CandidatoAlterador.cs
	namespace

 	
RhDomain


 
.

 
Services

 
.

 
CandidatoServices

 -
{ 
public 

class 
CandidatoAlterador #
:$ %
ICandidatoAlterador& 9
{ 
private 
readonly 
IUnitOfWork $
_uow% )
;) *
private 
readonly  
ICandidatoRepository - 
_candidatoRepository. B
;B C
private 
readonly  
ICandidatoValidation - 
_candidatoValidation. B
;B C
public 
CandidatoAlterador !
(! "
IUnitOfWork" -
uow. 1
,1 2 
ICandidatoRepository3 G
candidatoRepositoryH [
,[ \ 
ICandidatoValidation  
candidatoValidation! 4
)4 5
{ 	
_uow 
= 
uow 
;  
_candidatoRepository  
=! "
candidatoRepository# 6
;6 7 
_candidatoValidation  
=! "
candidatoValidation# 6
;6 7
} 	
public 
CandidatoDto 
Alterar #
(# $
CandidatoDto$ 0
candidatoDto1 =
)= >
{ 	
if 
(  
_candidatoValidation $
.$ %
validar% ,
(, -
candidatoDto- 9
)9 :
): ;
{ 
var 
	candidato 
=  
_candidatoRepository  4
.4 5
BuscarPorId5 @
(@ A
candidatoDtoA M
.M N
IdN P
)P Q
;Q R
	candidato 
. 
	Atualizar #
(# $
candidatoDto$ 0
.0 1
Nome1 5
,5 6
candidatoDto7 C
.C D
	SobrenomeD M
,M N
candidatoDto    
.    !
Idade  ! &
,  & '
candidatoDto  ( 4
.  4 5
Cpf  5 8
,  8 9
candidatoDto  : F
.  F G
VagaId  G M
)  M N
;  N O 
_candidatoRepository!! $
.!!$ %
	Alterador!!% .
(!!. /
	candidato!!/ 8
)!!8 9
;!!9 :
_uow"" 
."" 
Commit"" 
("" 
)"" 
;"" 
return## 
candidatoDto## #
;### $
}$$ 
return%% 
null%% 
;%% 
}&& 	
}'' 
}(( ã
[C:\Projetos\ProjetoRH\RhProject\RhDomain\Services\CandidatoServices\CandidatoArmazenador.cs
	namespace 	
RhDomain
 
. 
Services 
. 
CandidatoServices -
{ 
public 

class  
CandidatoArmazenador %
:& '!
ICandidatoArmazenador( =
{ 
private 
readonly 
IUnitOfWork $
_uow% )
;) *
private 
readonly  
ICandidatoRepository - 
_candidatoRepository. B
;B C
private 
readonly  
ICandidatoValidation - 
_candidatoValidation. B
;B C
public  
CandidatoArmazenador #
(# $ 
ICandidatoRepository$ 8
candidatoRepository9 L
,L M 
ICandidatoValidationN b
candidatoValidationc v
,v w
IUnitOfWork 
uow 
) 
{ 	
_uow 
= 
uow 
;  
_candidatoRepository  
=! "
candidatoRepository# 6
;6 7 
_candidatoValidation  
=! "
candidatoValidation# 6
;6 7
} 	
public 
ActionResult 
< 
CandidatoDto (
>( )
IncluirCandidato* :
(: ;
CandidatoDto; G
candidatoDtoH T
)T U
{ 	
if 
(  
_candidatoValidation $
.$ %
validar% ,
(, -
candidatoDto- 9
)9 :
): ;
{ 
var 
	candidato 
= 
new  #
	Candidato$ -
(- .
candidatoDto    
.    !
Nome  ! %
,  % &
candidatoDto!!  
.!!  !
	Sobrenome!!! *
,!!* +
candidatoDto""  
.""  !
Idade""! &
,""& '
candidatoDto##  
.##  !
Cpf##! $
,##$ %
candidatoDto$$  
.$$  !
VagaId$$! '
)&& 
;&&  
_candidatoRepository(( $
.(($ %
	Armazenar((% .
(((. /
	candidato((/ 8
)((8 9
;((9 :
_uow)) 
.)) 
Commit)) 
()) 
))) 
;)) 
return** 
candidatoDto** #
;**# $
}++ 
throw,, 
new,, 
	Exception,, 
(,,  
$str,,  7
),,7 8
;,,8 9
}-- 	
}00 
}11 ∞(
XC:\Projetos\ProjetoRH\RhProject\RhDomain\Services\CandidatoServices\CandidatoConsulta.cs
	namespace

 	
RhDomain


 
.

 
Services

 
.

 
CandidatoServices

 -
{ 
public 

class 
CandidatoConsulta "
:# $
ICandidatoConsulta% 7
{ 
private 
readonly 
IMapper  
_mapper! (
;( )
private 
readonly  
ICandidatoRepository - 
_candidatoRepository. B
;B C
public 
CandidatoConsulta  
(  ! 
ICandidatoRepository! 5
candidatoRepository6 I
,I J
IMapperK R
mapperS Y
)Y Z
{ 	
_mapper 
= 
mapper 
;  
_candidatoRepository  
=! "
candidatoRepository# 6
;6 7
} 	
public 
async 
Task 
< 
List 
< 
CandidatoDto +
>+ ,
>, - 
ObterListaCandidatos. B
(B C
)C D
{ 	
var 
listaCandidatos 
=  !
await" ' 
_candidatoRepository( <
.< =1
%BuscarListaCandidatosComVagaDescricao= b
(b c
)c d
;d e
if 
( 
listaCandidatos 
. 
Count $
==% '
$num( )
)) *
{ 
throw 
new 
	Exception #
(# $
$str$ M
)M N
;N O
} 
var 
listaCandidatosDto "
=# $
_mapper% ,
., -
Map- 0
<0 1
List1 5
<5 6
CandidatoDto6 B
>B C
>C D
(D E
listaCandidatosE T
)T U
;U V
return 
listaCandidatosDto %
;% &
} 	
public!! 
CandidatoDto!! 

ObterPorId!! &
(!!& '
int!!' *
id!!+ -
)!!- .
{"" 	
var## 
	candidato## 
=##  
_candidatoRepository## 0
.##0 1
BuscarPorId##1 <
(##< =
id##= ?
)##? @
;##@ A
if$$ 
($$ 
	candidato$$ 
==$$ 
null$$  
)$$  !
{%% 
throw&& 
new&& 
	Exception&& #
(&&# $
$str&&$ ;
)&&; <
;&&< =
}'' 
var(( 
candidatoDto(( 
=(( 
_mapper(( &
.((& '
Map((' *
<((* +
CandidatoDto((+ 7
>((7 8
(((8 9
	candidato((9 B
)((B C
;((C D
return)) 
candidatoDto)) 
;))  
}** 	
public,, %
CandidatoComTecnologiaDto,, ('
ObterCandidatoComTecnologia,,) D
(,,D E
int,,E H
id,,I K
),,K L
{-- 	
var.. 
	candidato.. 
=..  
_candidatoRepository.. 0
...0 12
&BuscaCandidatoTecnologiaComTecnologias..1 W
(..W X
id..X Z
)..Z [
;..[ \
var// 
candidatoDto// 
=// 
_mapper//  '
.//' (
Map//( +
<//+ ,%
CandidatoComTecnologiaDto//, E
>//E F
(//F G
	candidato//G P
)//P Q
;//Q R
var00 4
(candidatosSorteadosPorPesoDasTecnologias00 8
=009 :
candidatoDto00; G
.00G H
Tecnologias00H S
.00S T
OrderBy00T [
(00[ \
x00\ ]
=>00^ `
x00a b
.00b c
Peso00c g
)00g h
.00h i
ToList00i o
(00o p
)00p q
;00q r
candidatoDto11 
.11 
Tecnologias11 $
=11% &4
(candidatosSorteadosPorPesoDasTecnologias11' O
;11O P
return22 
candidatoDto22 
;22  
}33 	
public55 2
&CandidatoComTecnologiaParaArmazenarDto55 52
&BuscarParaArmazenarCandidatoTecnologia556 \
(55\ ]2
&CandidatoComTecnologiaParaArmazenarDto66 22
&candidatoComTecnologiaParaArmazenarDto663 Y
)66Y Z
{77 	
var88 
	candidato88 
=88  
_candidatoRepository88 0
.880 12
&BuscarParaArmazenarCandidatoTecnologia881 W
(88W X2
&candidatoComTecnologiaParaArmazenarDto88X ~
)88~ 
;	88 Ä
var99 
candidatoDto99 
=99 
_mapper99 &
.99& '
Map99' *
<99* +2
&CandidatoComTecnologiaParaArmazenarDto99+ Q
>99Q R
(99R S
	candidato99S \
)99\ ]
;99] ^
return:: 
candidatoDto:: 
;::  
};; 	
}?? 
}@@ Ú
YC:\Projetos\ProjetoRH\RhProject\RhDomain\Services\CandidatoServices\CandidatoExcluidor.cs
	namespace 	
RhDomain
 
. 
Services 
. 
CandidatoServices -
{ 
public 

class 
CandidatoExcluidor #
:$ %
ICandidatoExcluidor& 9
{ 
private 
readonly  
ICandidatoRepository - 
_candidatoRepository. B
;B C
private 
readonly 
IUnitOfWork $
_uow% )
;) *
public 
CandidatoExcluidor !
(! " 
ICandidatoRepository" 6
candidatoRepository7 J
,J K
IUnitOfWorkL W
uowX [
)[ \
{ 	
_uow 
= 
uow 
;  
_candidatoRepository  
=! "
candidatoRepository# 6
;6 7
} 	
public 
void "
ExcluirCandidatoPeloId *
(* +
int+ .
id/ 1
)1 2
{ 	
var 
	candidato 
=  
_candidatoRepository 0
.0 1
BuscarPorId1 <
(< =
id= ?
)? @
;@ A
if 
( 
	candidato 
== 
null !
)! "
{ 
return 
; 
}  
_candidatoRepository  
.  !
Excluir! (
(( )
	candidato) 2
)2 3
;3 4
_uow   
.   
Commit   
(   
)   
;   
}!! 	
}"" 
}## ã
oC:\Projetos\ProjetoRH\RhProject\RhDomain\Services\CandidatoTecnologiaServices\CandidatoTecnologiaArmazenador.cs
	namespace 	
RhDomain
 
. 
Services 
. '
CandidatoTecnologiaServices 7
{ 
public 

class *
CandidatoTecnologiaArmazenador /
:0 1+
ICandidatoTecnologiaArmazenador2 Q
{ 
private 
readonly  
ICandidatoRepository - 
_candidatoRepository. B
;B C
private 
readonly %
IVagaTecnologiaRepository 2%
_vagaTecnologiaRepository3 L
;L M
private 
readonly *
ICandidatoTecnologiaRepository 7*
_candidatoTecnologiaRepository8 V
;V W
private 
readonly 
IUnitOfWork $
_uow% )
;) *
public *
CandidatoTecnologiaArmazenador -
(- .*
ICandidatoTecnologiaRepository. L)
candidatoTecnologiaRepositoryM j
,j k
IUnitOfWorkl w
uowx {
,{ |%
IVagaTecnologiaRepository %$
vagaTecnologiaRepository& >
,> ? 
ICandidatoRepository@ T
candidatoRepositoryU h
)h i
{ 	 
_candidatoRepository  
=! "
candidatoRepository# 6
;6 7%
_vagaTecnologiaRepository %
=& '$
vagaTecnologiaRepository( @
;@ A*
_candidatoTecnologiaRepository *
=+ ,)
candidatoTecnologiaRepository- J
;J K
_uow 
= 
uow 
; 
} 	
public 
async 
Task 
< "
CandidatoTecnologiaDto 0
>0 1&
IncluirCandidatoTecnologia2 L
(L M"
CandidatoTecnologiaDtoM c"
candidatoTecnologiaDtod z
)z {
{ 	
if   
(   "
candidatoTecnologiaDto   &
!=  ' )
null  * .
&&  / 1"
candidatoTecnologiaDto  2 H
.  H I
TecnologiaId  I U
!=  V X
$num  Y Z
)  Z [
{!! 
var"" 
	candidato"" 
=""  
_candidatoRepository""  4
.""4 5
BuscarPorId""5 @
(""@ A"
candidatoTecnologiaDto""A W
.""W X
CandidatoId""X c
)""c d
;""d e
var## 
vagaTecnologia## "
=### $
await##% *%
_vagaTecnologiaRepository##+ D
.##D E)
BuscaVagaTecnologiaPorIdDuplo##E b
(##b c
	candidato##c l
.##l m
VagaId##m s
,##s t#
candidatoTecnologiaDto	##u ã
.
##ã å
TecnologiaId
##å ò
)
##ò ô
;
##ô ö
var$$ 
candidatoTecnologia$$ '
=$$( )
new$$* -
CandidatoTecnologia$$. A
($$A B"
candidatoTecnologiaDto$$B X
.$$X Y
CandidatoId$$Y d
,$$d e"
candidatoTecnologiaDto$$f |
.$$| }
TecnologiaId	$$} â
,
$$â ä
vagaTecnologia
$$ã ô
.
$$ô ö
Peso
$$ö û
)
$$û ü
;
$$ü †*
_candidatoTecnologiaRepository%% .
.%%. /
	Armazenar%%/ 8
(%%8 9
candidatoTecnologia%%9 L
)%%L M
;%%M N
_uow&& 
.&& 
Commit&& 
(&& 
)&& 
;&& 
return'' "
candidatoTecnologiaDto'' -
;''- .
}(( 
throw)) 
new)) 
	Exception)) 
())  
$str))  =
)))= >
;))> ?
}** 	
}++ 
},, ‘
lC:\Projetos\ProjetoRH\RhProject\RhDomain\Services\CandidatoTecnologiaServices\CandidatoTecnologiaConsulta.cs
	namespace

 	
RhDomain


 
.

 
Services

 
.

 '
CandidatoTecnologiaServices

 7
{ 
public 

class '
CandidatoTecnologiaConsulta ,
:- .(
ICandidatoTecnologiaConsulta/ K
{ 
private 
readonly *
ICandidatoTecnologiaRepository 7*
_candidatoTecnologiaRepository8 V
;V W
private 
readonly 
IMapper  
_mapper! (
;( )
public '
CandidatoTecnologiaConsulta *
(* +*
ICandidatoTecnologiaRepository+ I)
candidatoTecnologiaRepositoryJ g
,g h
IMapperi p
mapperq w
)w x
{ 	*
_candidatoTecnologiaRepository *
=+ ,)
candidatoTecnologiaRepository- J
;J K
_mapper 
= 
mapper 
; 
} 	
public 
async 
Task 
< 
List 
< "
CandidatoTecnologiaDto 5
>5 6
>6 7*
BuscarListaCandidatoTecnologia8 V
(V W
)W X
{ 	
var $
listaCandidatoTecnologia (
=) *
await+ 0*
_candidatoTecnologiaRepository1 O
.O P
BuscarListaP [
([ \
)\ ]
;] ^
var '
listaCandidatoTecnologiaDto +
=, -
_mapper. 5
.5 6
Map6 9
<9 :
List: >
<> ?"
CandidatoTecnologiaDto? U
>U V
>V W
(W X$
listaCandidatoTecnologiaX p
)p q
;q r
return '
listaCandidatoTecnologiaDto .
;. /
} 	
public "
CandidatoTecnologiaDto %
BuscarPorIdDuplo& 6
(6 7
int7 :
candidatoId; F
,F G
intH K
TecnologiaIdL X
)X Y
{ 	
var 
candidatoTecnologia #
=$ %*
_candidatoTecnologiaRepository& D
.D E/
#BuscarCandidatoTecnologiaporDuploIdE h
(h i
candidatoIdi t
,t u
TecnologiaId	v Ç
)
Ç É
;
É Ñ
var   "
candidatoTecnologiaDto   &
=  ' (
_mapper  ) 0
.  0 1
Map  1 4
<  4 5"
CandidatoTecnologiaDto  5 K
>  K L
(  L M
candidatoTecnologia  M `
)  ` a
;  a b
return!! "
candidatoTecnologiaDto!! )
;!!) *
}"" 	
}%% 
}&& Ì
mC:\Projetos\ProjetoRH\RhProject\RhDomain\Services\CandidatoTecnologiaServices\CandidatoTecnologiaExcluidor.cs
	namespace

 	
RhDomain


 
.

 
Services

 
.

 '
CandidatoTecnologiaServices

 7
{ 
public 

class (
CandidatoTecnologiaExcluidor -
:. /)
ICandidatoTecnologiaExcluidor0 M
{ 
private 
readonly *
ICandidatoTecnologiaRepository 7*
_candidatoTecnologiaRepository8 V
;V W
private 
readonly 
IUnitOfWork $
_uow% )
;) *
public (
CandidatoTecnologiaExcluidor +
(+ ,*
ICandidatoTecnologiaRepository, J)
candidatoTecnologiaRepositoryK h
,h i
IUnitOfWorki t
uowu x
)x y
{ 	*
_candidatoTecnologiaRepository *
=+ ,)
candidatoTecnologiaRepository- J
;J K
_uow 
= 
uow 
; 
} 	
public 
void 
Deletar 
( 
int 
candidatoId  +
,+ ,
int- 0
tecnologiaId1 =
)= >
{ 	
var 
candidatoTecnologia #
=$ %*
_candidatoTecnologiaRepository& D
.D E/
#BuscarCandidatoTecnologiaporDuploIdE h
(h i
candidatoIdi t
,t u
tecnologiaId	v Ç
)
Ç É
;
É Ñ*
_candidatoTecnologiaRepository *
.* +
Excluir+ 2
(2 3
candidatoTecnologia3 F
)F G
;G H
_uow 
. 
Commit 
( 
) 
; 
} 	
} 
} ƒ
qC:\Projetos\ProjetoRH\RhProject\RhDomain\Services\CandidatoTecnologiaValidation\CandidatoTecnologiaValidations.cs
	namespace 	
RhDomain
 
. 
Services 
. )
CandidatoTecnologiaValidation 9
{		 
public

 

class

 *
CandidatoTecnologiaValidations

 /
:

0 1+
ICandidatoTecnologiaValidations

2 Q
{ 
} 
} ≥
]C:\Projetos\ProjetoRH\RhProject\RhDomain\Services\CandidatoValidations\CandidatoValidation.cs
	namespace 	
RhDomain
 
. 
Services 
.  
CandidatoValidations 0
{ 
public		 

class		 
CandidatoValidation		 $
:		% & 
ICandidatoValidation		' ;
{

 
public 
bool 
validar 
( 
CandidatoDto (
candidatoDto) 5
)5 6
{ 	
return )
VerificarSeNomeEstaPreenchido 0
(0 1
candidatoDto1 =
)= >
&&? A.
"VerificarSeSobrenomeEstaPreenchido 2
(2 3
candidatoDto3 ?
)? @
&&A C*
VerificarSeIdadeEstaPreenchido .
(. /
candidatoDto/ ;
); <
&&= ?*
VerificarSeIdadeEstaPreenchido .
(. /
candidatoDto/ ;
); <
;< =
} 	
public 
bool )
VerificarSeNomeEstaPreenchido 1
(1 2
CandidatoDto2 >
candidatoDto? K
)K L
{ 	
if 
( 
string 
. 
IsNullOrWhiteSpace )
() *
candidatoDto* 6
.6 7
Nome7 ;
); <
)< =
{ 
return 
false 
; 
} 
return 
true 
; 
} 	
public 
bool .
"VerificarSeSobrenomeEstaPreenchido 6
(6 7
CandidatoDto7 C
candidatoDtoD P
)P Q
{ 	
if 
( 
string 
. 
IsNullOrEmpty $
($ %
candidatoDto% 1
.1 2
	Sobrenome2 ;
); <
)< =
{ 
return   
false   
;   
}!! 
return"" 
true"" 
;"" 
}## 	
public%% 
bool%% *
VerificarSeIdadeEstaPreenchido%% 2
(%%2 3
CandidatoDto%%3 ?
candidatoDto%%@ L
)%%L M
{&& 	
if'' 
('' 
candidatoDto'' 
.'' 
Idade'' !
==''" $
$num''% &
)''& '
{(( 
return)) 
false)) 
;)) 
}** 
return++ 
true++ 
;++ 
},, 	
public.. 
bool.. (
VerificarSeCpfEstaPreenchido.. 0
(..0 1
CandidatoDto..1 =
candidatoDto..> J
)..J K
{// 	
if00 
(00 
string00 
.00 
IsNullOrEmpty00 #
(00# $
candidatoDto00$ 0
.000 1
Cpf001 4
)004 5
)005 6
{11 
return22 
false22 
;22 
}33 
return44 
true44 
;44 
}55 	
}66 
}77 °
bC:\Projetos\ProjetoRH\RhProject\RhDomain\Services\TecnologiaServices\PermitirExclusaoTecnologia.cs
	namespace 	
RhDomain
 
. 
Services 
. 
TecnologiaServices .
{ 
public		 

class		 &
PermitirExclusaoTecnologia		 +
:		, -'
IPermitirExclusaoTecnologia		. I
{

 
private 
readonly %
IVagaTecnologiaRepository 2%
_vagaTecnologiaRepository3 L
;L M
private 
readonly *
ICandidatoTecnologiaRepository 7*
_candidatoTecnologiaRepository8 V
;V W
public &
PermitirExclusaoTecnologia )
() *%
IVagaTecnologiaRepository* C$
vagaTecnologiaRepositoryD \
,\ ]*
ICandidatoTecnologiaRepository^ |*
candidatoTecnologiaRepository	} ö
)
ö õ
{ 	%
_vagaTecnologiaRepository %
=& '$
vagaTecnologiaRepository( @
;@ A*
_candidatoTecnologiaRepository *
=+ ,)
candidatoTecnologiaRepository- J
;J K
} 	
public 
bool $
ValidaExclusaoTecnologia ,
(, -
int- 0
tecnologiaId1 =
)= >
{ 	
var 
vagaTecnologia 
=  %
_vagaTecnologiaRepository! :
.: ;.
"BuscaVagaTecnologiaPorTecnologiaId; ]
(] ^
tecnologiaId^ j
)j k
;k l
var 
candidatoTecnologia #
=$ %*
_candidatoTecnologiaRepository& D
.D E4
(BuscarCandidatoTecnologiaPorTecnologiaIdE m
(m n
tecnologiaIdn z
)z {
;{ |
if 
( 
vagaTecnologia 
!= !
null" &
)& '
{ 
throw 
new 
	Exception #
(# $
$str$ a
)a b
;b c
} 
if 
( 
candidatoTecnologia "
!=# %
null& *
)* +
{ 
throw 
new 
	Exception #
(# $
$str$ n
)n o
;o p
} 
return   
true   
;   
}"" 	
}## 
}$$ ’
[C:\Projetos\ProjetoRH\RhProject\RhDomain\Services\TecnologiaServices\TecnologiaAlterador.cs
	namespace		 	
RhDomain		
 
.		 
Services		 
.		 
TecnologiaServices		 .
{

 
public 

class 
TecnologiaAlterador $
:% & 
ITecnologiaAlterador' ;
{ 
private 
readonly !
ITecnologiaRepository .!
_tecnologiaRepository/ D
;D E
private 
readonly 
IUnitOfWork $
_uow% )
;) *
public 
TecnologiaAlterador "
(" #!
ITecnologiaRepository# 8 
tecnologiaRepository9 M
,M N
IUnitOfWorkO Z
uow[ ^
)^ _
{ 	!
_tecnologiaRepository !
=" # 
tecnologiaRepository$ 8
;8 9
_uow 
= 
uow 
; 
} 	
public 
TecnologiaDto 
Alterar $
($ %
TecnologiaDto% 2
tecnologiaDto3 @
)@ A
{ 	
if 
( 
tecnologiaDto 
. 
	Descricao &
!=' )
string* 0
.0 1
Empty1 6
)6 7
{ 
var 

tecnologia 
=  !
_tecnologiaRepository! 6
.6 7
BuscarPorId7 B
(B C
tecnologiaDtoC P
.P Q
IdQ S
)S T
;T U

tecnologia 
. 
AtualizarDescricao -
(- .
tecnologiaDto. ;
.; <
	Descricao< E
)E F
;F G!
_tecnologiaRepository %
.% &
	Alterador& /
(/ 0

tecnologia0 :
): ;
;; <
_uow 
. 
Commit 
( 
) 
; 
return 
tecnologiaDto $
;$ %
} 
throw   
new   
	Exception   
(    
$str    A
)  A B
;  B C
}"" 	
}## 
}$$ ò
]C:\Projetos\ProjetoRH\RhProject\RhDomain\Services\TecnologiaServices\TecnologiaArmazenador.cs
	namespace 	
RhDomain
 
. 
Services 
. 
TecnologiaServices .
{ 
public 

class !
TecnologiaArmazenador &
:' ("
ITecnologiaArmazenador) ?
{ 
private 
readonly !
ITecnologiaRepository .!
_tecnologiaRepository/ D
;D E
private 
readonly !
ITecnologiaValidation .!
_tecnologiaValidation/ D
;D E
private 
readonly 
IUnitOfWork $
_uow% )
;) *
public !
TecnologiaArmazenador $
($ %!
ITecnologiaRepository% : 
tecnologiaRepository; O
,O P!
ITecnologiaValidationQ f 
tecnologiaValidationg {
,{ |
IUnitOfWork 
uow 
) 
{ 	!
_tecnologiaRepository !
=" # 
tecnologiaRepository$ 8
;8 9!
_tecnologiaValidation !
=" # 
tecnologiaValidation$ 8
;8 9
_uow 
= 
uow 
; 
} 	
public 
ActionResult 
< 
TecnologiaDto )
>) *
IncluirTecnologia+ <
(< =
TecnologiaDto= J
tecnologiaDtoK X
)X Y
{ 	
if   
(   !
_tecnologiaValidation   %
.  % &,
 ValidaSeTecnologiaEstaPreenchido  & F
(  F G
tecnologiaDto  G T
)  T U
)  U V
{!! 
var"" 

tecnologia"" 
=""  
new""! $

Tecnologia""% /
(""/ 0
tecnologiaDto""0 =
.""= >
	Descricao""> G
)""G H
;""H I!
_tecnologiaRepository## %
.##% &
	Armazenar##& /
(##/ 0

tecnologia##0 :
)##: ;
;##; <
_uow$$ 
.$$ 
Commit$$ 
($$ 
)$$ 
;$$ 
return%% 
tecnologiaDto%% $
;%%$ %
}&& 
throw'' 
new'' 
	Exception'' 
(''  
$str''  8
)''8 9
;''9 :
}(( 	
})) 
}** Å
ZC:\Projetos\ProjetoRH\RhProject\RhDomain\Services\TecnologiaServices\TecnologiaConsulta.cs
	namespace

 	
RhDomain


 
.

 
Services

 
.

 
TecnologiaServices

 .
{ 
public 

class 
TecnologiaConsulta #
:$ %
ITecnologiaConsulta& 9
{ 
private 
readonly !
ITecnologiaRepository .!
_tecnologiaRepository/ D
;D E
private 
readonly 
IMapper  
_mapper! (
;( )
public 
TecnologiaConsulta !
(! "!
ITecnologiaRepository" 7 
tecnologiaRepository8 L
,L M
IMapperN U
mapperV \
)\ ]
{ 	!
_tecnologiaRepository !
=" # 
tecnologiaRepository$ 8
;8 9
_mapper 
= 
mapper 
; 
} 	
public 
async 
Task 
< 
List 
< 
TecnologiaDto ,
>, -
>- .#
ObterListaDeTecnologias/ F
(F G
)G H
{ 	
var 
listaTecnologias  
=! "
await# (!
_tecnologiaRepository) >
.> ?
BuscarLista? J
(J K
)K L
;L M
if 
( 
listaTecnologias 
.  
Count  %
==& (
$num) *
)* +
{ 
throw 
new 
	Exception #
(# $
$str$ I
)I J
;J K
} 
var 
listaTecnologiasDto #
=$ %
_mapper& -
.- .
Map. 1
<1 2
List2 6
<6 7
TecnologiaDto7 D
>D E
>E F
(F G
listaTecnologiasG W
)W X
;X Y
return 
listaTecnologiasDto &
;& '
}   	
public"" 
TecnologiaDto""  
ObterTecnologiaPorId"" 1
(""1 2
int""2 5
id""6 8
)""8 9
{## 	
var$$ 

tecnologia$$ 
=$$ !
_tecnologiaRepository$$ 2
.$$2 3
BuscarPorId$$3 >
($$> ?
id$$? A
)$$A B
;$$B C
var%% 
tecnologiaDto%% 
=%% 
_mapper%%  '
.%%' (
Map%%( +
<%%+ ,
TecnologiaDto%%, 9
>%%9 :
(%%: ;

tecnologia%%; E
)%%E F
;%%F G
return&& 
tecnologiaDto&&  
;&&  !
}'' 	
}** 
}++ ˆ
[C:\Projetos\ProjetoRH\RhProject\RhDomain\Services\TecnologiaServices\TecnologiaExcluidor.cs
	namespace 	
RhDomain
 
. 
Services 
. 
TecnologiaServices .
{		 
public

 

class

 
TecnologiaExcluidor

 $
:

% & 
ITecnologiaExcluidor

' ;
{ 
private 
readonly !
ITecnologiaRepository .!
_tecnologiaRepository/ D
;D E
private 
readonly 
IUnitOfWork $
_uow% )
;) *
private 
readonly '
IPermitirExclusaoTecnologia 4'
_permitirExclusaoTecnologia5 P
;P Q
public 
TecnologiaExcluidor "
(" #!
ITecnologiaRepository# 8 
tecnologiaRepository9 M
,M N
IUnitOfWorkO Z
uow[ ^
,^ _'
IPermitirExclusaoTecnologia` {'
permitirExclusaoTecnologia	| ñ
)
ñ ó
{ 	!
_tecnologiaRepository !
=" # 
tecnologiaRepository$ 8
;8 9
_uow 
= 
uow 
; '
_permitirExclusaoTecnologia '
=( )&
permitirExclusaoTecnologia* D
;D E
} 	
public 
bool 
ExcluirTecnologia %
(% &
int& )
id* ,
), -
{ 	
if 
( '
_permitirExclusaoTecnologia +
.+ ,$
ValidaExclusaoTecnologia, D
(D E
idE G
)G H
)H I
{ 
var 

tecnologia 
=  !
_tecnologiaRepository! 6
.6 7
BuscarPorId7 B
(B C
idC E
)E F
;F G!
_tecnologiaRepository %
.% &
Excluir& -
(- .

tecnologia. 8
)8 9
;9 :
_uow 
. 
Commit 
( 
) 
; 
return 
true 
; 
} 
return 
false 
; 
}   	
}!! 
}"" ∞
_C:\Projetos\ProjetoRH\RhProject\RhDomain\Services\TecnologiaValidations\TecnologiaValidation.cs
	namespace 	
RhDomain
 
. 
Services 
. !
TecnologiaValidations 1
{ 
public		 

class		  
TecnologiaValidation		 %
:		& '!
ITecnologiaValidation		( =
{

 
public 
bool ,
 ValidaSeTecnologiaEstaPreenchido 4
(4 5
TecnologiaDto5 B
tecnologiaDtoC P
)P Q
{ 	
if 
( 
string 
. 
IsNullOrEmpty $
($ %
tecnologiaDto% 2
.2 3
	Descricao3 <
)< =
)= >
{ 
return 
false 
; 
} 
return 
true 
; 
} 	
} 
} à
OC:\Projetos\ProjetoRH\RhProject\RhDomain\Services\VagaServices\VagaAlterador.cs
	namespace

 	
RhDomain


 
.

 
Services

 
.

 
VagaServices

 (
{ 
public 

class 
VagaAlterador 
:  
IVagaAlterador! /
{ 
private 
readonly 
IVagaRepository (
_vagaRepository) 8
;8 9
private 
readonly 
IUnitOfWork $
_uow% )
;) *
private 
readonly 
IVagaValidation (
_vagaValidation) 8
;8 9
public 
VagaAlterador 
( 
IVagaRepository ,
vagaRepository- ;
,; <
IUnitOfWork= H
uowI L
,L M
IVagaValidationN ]
vagaValidation^ l
)l m
{ 	
_uow 
= 
uow 
; 
_vagaRepository 
= 
vagaRepository ,
;, -
_vagaValidation 
= 
vagaValidation ,
;, -
} 	
public +
VagaComTecnologiaECandidatosDto .
Alterar/ 6
(6 7+
VagaComTecnologiaECandidatosDto7 V
vagaDtoW ^
)^ _
{ 	
if 
( 
_vagaValidation 
.  )
ValidaSeVagaDtoEstaPreenchido  =
(= >
vagaDto> E
)E F
)F G
{ 
var 
vaga 
= 
_vagaRepository *
.* +
BuscarPorId+ 6
(6 7
vagaDto7 >
.> ?
Id? A
)A B
;B C
vaga 
. 
	Atualizar 
( 
vagaDto &
.& '
	Descricao' 0
)0 1
;1 2
_vagaRepository 
.  
	Alterador  )
() *
vaga* .
). /
;/ 0
_uow   
.   
Commit   
(   
)   
;   
return!! 
vagaDto!! 
;!! 
}"" 
throw## 
new## 
	Exception## 
(##  
$str##  B
)##B C
;##C D
}$$ 	
}%% 
}&& ë
QC:\Projetos\ProjetoRH\RhProject\RhDomain\Services\VagaServices\VagaArmazenador.cs
	namespace 	
RhDomain
 
. 
Services 
. 
VagaServices (
{ 
public 

class 
VagaArmazenador  
:! "
IVagaArmazenador# 3
{ 
private 
readonly 
IVagaRepository (
_vagaRepository) 8
;8 9
private 
readonly 
IUnitOfWork $
_uow% )
;) *
private 
readonly 
IVagaValidation (
_vagaValidation) 8
;8 9
public 
VagaArmazenador 
( 
IVagaRepository .
vagaRepository/ =
,= >
IUnitOfWork? J
uowK N
,N O
IVagaValidation 
vagaValidation *
)* +
{ 	
_vagaValidation 
= 
vagaValidation ,
;, -
_uow 
= 
uow 
; 
_vagaRepository 
= 
vagaRepository ,
;, -
} 	
public 
ActionResult 
< +
VagaComTecnologiaECandidatosDto ;
>; <
IncluirVaga= H
(H I+
VagaComTecnologiaECandidatosDtoI h
vagaDtoi p
)p q
{ 	
if 
( 
_vagaValidation 
.  )
ValidaSeVagaDtoEstaPreenchido  =
(= >
vagaDto> E
)E F
)F G
{ 
var   
vaga   
=   
new   
Vaga   #
(  # $
vagaDto  $ +
.  + ,
	Descricao  , 5
)  5 6
;  6 7
_vagaRepository!! 
.!!  
	Armazenar!!  )
(!!) *
vaga!!* .
)!!. /
;!!/ 0
_uow"" 
."" 
Commit"" 
("" 
)"" 
;"" 
return## 
vagaDto## 
;## 
}$$ 
throw%% 
new%% 
	Exception%% 
(%%  
$str%%  :
)%%: ;
;%%; <
}&& 	
}'' 
}(( ¨&
NC:\Projetos\ProjetoRH\RhProject\RhDomain\Services\VagaServices\VagaConsulta.cs
	namespace 	
RhDomain
 
. 
Services 
. 
VagaServices (
{ 
public 

class 
VagaConsulta 
: 
IVagaConsulta  -
{ 
private 
readonly 
IMapper  
_mapper! (
;( )
private 
readonly 
IVagaRepository (
_vagaRepository) 8
;8 9
public 
VagaConsulta 
( 
IVagaRepository +
vagaRepository, :
,: ;
IMapper< C
mapperD J
)J K
{ 	
_mapper 
= 
mapper 
; 
_vagaRepository 
= 
vagaRepository ,
;, -
} 	
public 
async 
Task 
< 
List 
< +
VagaComTecnologiaECandidatosDto >
>> ?
>? @
ObterListaDeVagasA R
(R S
)S T
{ 	
var 
	listaVaga 
= 
await !
_vagaRepository" 1
.1 2
BuscarLista2 =
(= >
)> ?
;? @
var 
listaVagaDto 
= 
_mapper &
.& '
Map' *
<* +
List+ /
</ 0+
VagaComTecnologiaECandidatosDto0 O
>O P
>P Q
(Q R
	listaVagaR [
)[ \
;\ ]
return 
listaVagaDto 
;  
} 	
public!! +
VagaComTecnologiaECandidatosDto!! .'
ObterVagaComTecnologiaPorId!!/ J
(!!J K
int!!K N
id!!O Q
)!!Q R
{"" 	
var## 
vaga## 
=## 
_vagaRepository## &
.##& '
BuscaVagaComInclude##' :
(##: ;
id##; =
)##= >
;##> ?
return$$ 
_mapper$$ 
.$$ 
Map$$ 
<$$  +
VagaComTecnologiaECandidatosDto$$  ?
>$$? @
($$@ A
vaga$$A E
)$$E F
;$$F G
}%% 	
public'' '
VagaComCandidatoDtoSorteado'' *.
"ObterVagaComCandidatoSorteadoPorId''+ M
(''M N
int''N Q
id''R T
)''T U
{(( 	
var)) 
vaga)) 
=)) 
_vagaRepository)) &
.))& '
BuscaVagaComInclude))' :
()): ;
id)); =
)))= >
;))> ?
_mapper** 
.** 
Map** 
<** 
List** 
<** %
CandidatoComTecnologiaDto** 6
>**6 7
>**7 8
(**8 9
vaga**9 =
.**= >

Candidatos**> H
)**H I
;**I J
var++ 
vagaDto++ 
=++ 
_mapper++ !
.++! "
Map++" %
<++% &'
VagaComCandidatoDtoSorteado++& A
>++A B
(++B C
vaga++C G
)++G H
;++H I
foreach,, 
(,, 
var,, 
candidatoDto,, $
in,,% '
vagaDto,,( /
.,,/ 0

Candidatos,,0 :
),,: ;
{-- 
foreach.. 
(.. 
var.. 

tecnologia.. &
in..' )
candidatoDto..* 6
...6 7
Tecnologias..7 B
)..B C
{// 
candidatoDto00  
.00  !
	Pontuacao00! *
+=00+ -

tecnologia00. 8
.008 9
Peso009 =
;00= >
}11 
}22 
var33 
candidatosSorteados33 #
=33$ %
vagaDto33& -
.33- .

Candidatos33. 8
.338 9
OrderByDescending339 J
(33J K
x33K L
=>33M O
x33P Q
.33Q R
	Pontuacao33R [
)33[ \
.33\ ]
ToList33] c
(33c d
)33d e
;33e f
vagaDto44 
.44 

Candidatos44 
=44  
candidatosSorteados44! 4
;444 5
return55 
vagaDto55 
;55 
}66 	
public88 
VagaDto88 
ObterVagaPorId88 %
(88% &
int88& )
id88* ,
)88, -
{99 	
var:: 
vaga:: 
=:: 
_vagaRepository:: &
.::& '
BuscarPorId::' 2
(::2 3
id::3 5
)::5 6
;::6 7
return;; 
_mapper;; 
.;; 
Map;; 
<;; 
VagaDto;; &
>;;& '
(;;' (
vaga;;( ,
);;, -
;;;- .
}<< 	
}== 
}>> Ô
OC:\Projetos\ProjetoRH\RhProject\RhDomain\Services\VagaServices\VagaExcluidor.cs
	namespace 	
RhDomain
 
. 
Services 
. 
VagaServices (
{		 
public

 

class

 
VagaExcluidor

 
:

  
IVagaExcluidor

! /
{ 
private 
readonly 
IVagaRepository (
_vagaRepository) 8
;8 9
private 
readonly 
IUnitOfWork $
_uow% )
;) *
public 
VagaExcluidor 
( 
IVagaRepository ,
vagaRepository- ;
,; <
IUnitOfWork= H
uowI L
)L M
{ 	
_vagaRepository 
= 
vagaRepository ,
;, -
_uow 
= 
uow 
; 
} 	
public 
void 
ExcluirVagaPeloId %
(% &
int& )
id* ,
), -
{ 	
var 
vaga 
= 
_vagaRepository &
.& '
BuscarPorId' 2
(2 3
id3 5
)5 6
;6 7
if 
( 
vaga 
== 
null 
) 
{ 
throw 
new 
	Exception #
(# $
$str$ 4
)4 5
;5 6
} 
_vagaRepository 
. 
Excluir #
(# $
vaga$ (
)( )
;) *
_uow 
. 
Commit 
( 
) 
; 
} 	
} 
}   ï
SC:\Projetos\ProjetoRH\RhProject\RhDomain\Services\VagasValidation\VagaValidation.cs
	namespace 	
RhDomain
 
. 
Services 
. 
VagasValidation +
{ 
public		 

class		 
VagaValidation		 
:		  !
IVagaValidation		" 1
{

 
public 
bool )
ValidaSeVagaDtoEstaPreenchido 1
(1 2+
VagaComTecnologiaECandidatosDto2 Q
vagaDtoR Y
)Y Z
{ 	
if 
( 
string 
. 
IsNullOrEmpty $
($ %
vagaDto% ,
., -
	Descricao- 6
)6 7
)7 8
{ 
return 
false 
; 
} 
return 
true 
; 
} 	
} 
} ˛
lC:\Projetos\ProjetoRH\RhProject\RhDomain\Services\VagaTecnologiaServices\PermitirExclusaoDeVagaTecnologia.cs
	namespace 	
RhDomain
 
. 
Services 
. "
VagaTecnologiaServices 2
{ 
public		 

class		 ,
 PermitirExclusaoDeVagaTecnologia		 1
:		2 3-
!IPermitirExclusaoDeVagaTecnologia		4 U
{

 
private 
readonly 
IVagaRepository (
_vagaRepository) 8
;8 9
public ,
 PermitirExclusaoDeVagaTecnologia /
(/ 0
IVagaRepository0 ?
vagaRepository@ N
)N O
{ 	
_vagaRepository 
= 
vagaRepository ,
;, -
} 	
public 
bool *
ValidaExclusaoDeVagaTecnologia 2
(2 3
int3 6
vagaId7 =
,= >
int> A
tecnologiaIdB N
)N O
{ 	
var 
vaga 
= 
_vagaRepository &
.& '
BuscaVagaComInclude' :
(: ;
vagaId; A
)A B
;B C
if 
( 
vaga 
== 
null 
) 
throw 
new 
	Exception #
(# $
$str$ 5
)5 6
;6 7
foreach 
( 
var 
	candidato !
in" $
vaga% )
.) *

Candidatos* 4
)4 5
{ 
foreach 
( 
var 

tecnologia '
in( *
	candidato+ 4
.4 5!
CandidatosTecnologias5 J
)J K
{ 
if 
( 

tecnologia !
.! "
TecnologiaId" .
==/ 1
tecnologiaId2 >
)> ?
{ 
return 
false $
;$ %
}   
}!! 
}"" 
return## 
true## 
;## 
}$$ 	
}%% 
}&& Ã
eC:\Projetos\ProjetoRH\RhProject\RhDomain\Services\VagaTecnologiaServices\VagaTecnologiaArmazenador.cs
	namespace

 	
RhDomain


 
.

 
Services

 
.

 "
VagaTecnologiaServices

 2
{ 
public 

class %
VagaTecnologiaArmazenador *
:+ ,&
IVagaTecnologiaArmazenador- G
{ 
private 
readonly %
IVagaTecnologiaRepository 2%
_vagaTecnologiaRepository3 L
;L M
private 
readonly 
IUnitOfWork $
_uow% )
;) *
public %
VagaTecnologiaArmazenador (
(( )%
IVagaTecnologiaRepository) B$
vagaTecnologiaRepositoryC [
,[ \
IUnitOfWork] h
uowi l
)l m
{ 	%
_vagaTecnologiaRepository %
=& '$
vagaTecnologiaRepository( @
;@ A
_uow 
= 
uow 
; 
} 	
public 
VagaTecnologiaDto  !
IncluirVagaTecnologia! 6
(6 7
VagaTecnologiaDto7 H
vagaTecnologiaDtoI Z
)Z [
{ 	
var 
vagaTecnologia 
=  
new! $
VagaTecnologia% 3
(3 4
vagaTecnologiaDto4 E
.E F
VagaIdF L
,L M
vagaTecnologiaDtoN _
._ `
TecnologiaId` l
,l m
vagaTecnologiaDton 
.	 Ä
Peso
Ä Ñ
)
Ñ Ö
;
Ö Ü%
_vagaTecnologiaRepository %
.% &
	Armazenar& /
(/ 0
vagaTecnologia0 >
)> ?
;? @
_uow 
. 
Commit 
( 
) 
; 
return 
vagaTecnologiaDto $
;$ %
} 	
} 
} ‹
bC:\Projetos\ProjetoRH\RhProject\RhDomain\Services\VagaTecnologiaServices\VagaTecnologiaConsulta.cs
	namespace

 	
RhDomain


 
.

 
Services

 
.

 "
VagaTecnologiaServices

 2
{ 
public 

class "
VagaTecnologiaConsulta '
:( )#
IVagaTecnologiaConsulta* A
{ 
private 
readonly 
IMapper  
_mapper! (
;( )
private 
readonly %
IVagaTecnologiaRepository 2%
_vagaTecnologiaRepository3 L
;L M
public "
VagaTecnologiaConsulta %
(% &%
IVagaTecnologiaRepository& ?$
vagaTecnologiaRepository@ X
,X Y
IMapperZ a
mapperb h
)h i
{ 	%
_vagaTecnologiaRepository %
=& '$
vagaTecnologiaRepository( @
;@ A
_mapper 
= 
mapper 
; 
} 	
public 
async 
Task 
< 
List 
< 
VagaTecnologiaDto 0
>0 1
>1 2%
BuscarListaVagaTecnologia3 L
(L M
)M N
{ 	
var 
listaVagaTecnologia #
=$ %
await& +%
_vagaTecnologiaRepository, E
.E F
BuscarListaF Q
(Q R
)R S
;S T
return 
_mapper 
. 
Map 
< 
List #
<# $
VagaTecnologiaDto$ 5
>5 6
>6 7
(7 8
listaVagaTecnologia8 K
)K L
;L M
} 	
public 
VagaTecnologiaDto  $
BuscaVagaTecnologiaPorId! 9
(9 :
int: =
vagaId> D
,D E
intF I
tecnologiaIdJ V
)V W
{ 	
var 
vagaTecnologia 
=  %
_vagaTecnologiaRepository! :
.: ;)
BuscaVagaTecnologiaPorIdDuplo; X
(X Y
vagaIdY _
,_ `
tecnologiaIda m
)m n
;n o
return 
_mapper 
. 
Map 
< 
VagaTecnologiaDto 0
>0 1
(1 2
vagaTecnologia2 @
)@ A
;A B
}   	
}!! 
}"" ﬁ
cC:\Projetos\ProjetoRH\RhProject\RhDomain\Services\VagaTecnologiaServices\VagaTecnologiaExcluidor.cs
	namespace

 	
RhDomain


 
.

 
Services

 
.

 "
VagaTecnologiaServices

 2
{ 
public 

class #
VagaTecnologiaExcluidor (
:) *$
IVagaTecnologiaExcluidor+ C
{ 
private 
readonly -
!IPermitirExclusaoDeVagaTecnologia :-
!_permitirExclusaoDeVagaTecnologia; \
;\ ]
private 
readonly %
IVagaTecnologiaRepository 2%
_vagaTecnologiaRepository3 L
;L M
private 
readonly 
IUnitOfWork $
_uow% )
;) *
public #
VagaTecnologiaExcluidor &
(& '%
IVagaTecnologiaRepository' @$
vagaTecnologiaRepositoryA Y
,Y Z
IUnitOfWork[ f
uowg j
,j k.
!IPermitirExclusaoDeVagaTecnologia	l ç.
 permitirExclusaoDeVagaTecnologia
é Æ
)
Æ Ø
{ 	%
_vagaTecnologiaRepository %
=& '$
vagaTecnologiaRepository( @
;@ A
_uow 
= 
uow 
; -
!_permitirExclusaoDeVagaTecnologia -
=. /,
 permitirExclusaoDeVagaTecnologia0 P
;P Q
} 	
public 
async 
Task 
< 
bool 
> 
Deletar  '
(' (
int( +
vagaId, 2
,2 3
int4 7
tecnologiaId8 D
)D E
{ 	
if 
( -
!_permitirExclusaoDeVagaTecnologia 0
.0 1*
ValidaExclusaoDeVagaTecnologia1 O
(O P
vagaIdP V
,V W
tecnologiaIdX d
)d e
)e f
{ 
var 
vagaTecnologia "
=# $
await% *%
_vagaTecnologiaRepository+ D
.D E)
BuscaVagaTecnologiaPorIdDuploE b
(b c
vagaIdc i
,i j
tecnologiaIdk w
)w x
;x y%
_vagaTecnologiaRepository )
.) *
Excluir* 1
(1 2
vagaTecnologia2 @
)@ A
;A B
_uow 
. 
Commit 
( 
) 
; 
return   
true   
;   
}!! 
return"" 
false"" 
;"" 
}## 	
}$$ 
}%% •	
AC:\Projetos\ProjetoRH\RhProject\RhDomain\Utils\CommandResponse.cs
	namespace 	
RhDomain
 
. 
Utils 
{ 
public 

class 
CommandResponse  
{ 
public		 
static		 
CommandResponse		 %
Ok		& (
=		) *
new		+ .
CommandResponse		/ >
{		? @
Success		A H
=		I J
true		K O
}		P Q
;		Q R
public

 
static

 
CommandResponse

 %
Fail

& *
=

+ ,
new

- 0
CommandResponse

1 @
{

A B
Success

C J
=

K L
false

M R
}

S T
;

T U
public 
CommandResponse 
( 
bool #
success$ +
=, -
false. 3
)3 4
{ 	
Success 
= 
success 
; 
} 	
public 
bool 
Success 
{ 
get !
;! "
private# *
set+ .
;. /
}0 1
} 
} 