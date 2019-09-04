use DB_ESCOLA
go

--listando todos os cursos de todas as escolas

SELECT * FROM TBCursos


SELECT * FROM TBEscolas,TBCursos 
WHERE
TBEscolas.Id = TBCursos.IdEscola

--Lista com relacionamento, permitindo seleçãode campos
--usando uma variável como base de pesquisa.
DECLARE	@Valor	FLOAT;
SET @Valor =1500;

SELECT  
E.Descricao AS Escola,
C.Desr AS Curso,
E.Endereco AS Endereço,
C.Preco AS Preço

FROM 
TBEscolas E, TBCursos C

WHERE 
E.Id = C.IdEscola 
AND C.Preco >= @Valor 

--Consutas envolvendo agrupamentos e funções de agregação
SELECT
E.Descricao AS Escola,
C.Desrcicao AS Curso

From
TBEscolas E, TBCursos 
WHERE

E.Id = C.IdEscola
