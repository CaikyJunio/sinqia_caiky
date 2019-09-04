/* Trabalhando com consultas simples 
*/

-- Listando todas as escolas
USE DB_ESCOLA

go

select * FROM TBEscolas

-- Listando apenas o nome e o telefone
-- Forma 3

SELECT Descricao, Telefone FROM TBEscolas

SELECT Descricao AS Descrição, 
Telefone AS Fone 
FROM TBEscolas 

--Forma 4
SELECT
E.Descricao, E.Endereco
FROM TBEscolas E

--FORM 5 (Menos desejavel)

Select 
	TBEscolas.Descricao, TBEscolas.Endereco
FROM TBEscolas



------------Restrições--------------------

SELECT * FROM TBEscolas WHERE Descricao LIKE '%F%'
SELECT * FROM TBEscolas WHERE Descricao = 'UNA-Centro Universidade'
SELECT * FROM TBEscolas WHERE Id >=2 AND Id<=5
SELECT * FROM TBEscolas WHERE Id BETWEEN 2 AND 5 
AND Endereco LIKE 'Av%'

