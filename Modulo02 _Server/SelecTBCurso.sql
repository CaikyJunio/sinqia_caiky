use DB_ESCOLA
go

--listando todos os cursos de todas as escolas

SELECT * FROM TBCursos


SELECT * FROM TBEscolas,TBCursos 
WHERE
TBEscolas.Id = TBCursos.IdEscola

--Lista com relacionamento, permitindo sele��ode campos
--usando uma vari�vel como base de pesquisa.
DECLARE	@Valor	FLOAT;
SET @Valor =1500;

SELECT  
E.Descricao AS Escola,
C.Desr AS Curso,
E.Endereco AS Endere�o,
C.Preco AS Pre�o

FROM 
TBEscolas E, TBCursos C

WHERE 
E.Id = C.IdEscola 
AND C.Preco >= @Valor 

--Consutas envolvendo agrupamentos e fun��es de agrega��o
SELECT
E.Descricao AS Escola,
C.Desrcicao AS Curso

From
TBEscolas E, TBCursos 
WHERE

E.Id = C.IdEscola
