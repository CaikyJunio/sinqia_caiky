USE DB_EVENTOS
GO


INSERT INTO TBEventos (Descricao,Responsavel,Data,Preco)
SELECT Descricao, Responsavel, Data, Preco FROM EventosBackup


SELECT * FROM EventosBackup




--- selecionar todos os eventos cujo o preço esteja
-- entre 500 e 1000 reais
SELECT * FROM TBEventos

WHERE Preco BETWEEN 500 AND 1000

-- selecionar todos os convidadeos(nome, e-mail)
--qu estiverem inscritors em eventos gratis

SELECT C.Nome, C.Email
FROM TBConvidados C, TBEventos E
WHERE E.Preco =0 AND E.Id = C.IdEvento





--Apresentar a qquantidade de convidadoss por evento
--(exibir o nome do evento e a quantidade de convidados)
SELECT E.Descricao,COUNT (C.Nome)
FROM TBConvidados C, TBEventos E
WHERE E.Id= C.IdEvento 
GROUP BY E.Descricao

--Apresentar o valor arrecadado por evento
--(Apresentar o nome do evento e o total pago pleos convidados)

SELECT E.Descricao As Evento,
SUM (E.Preco) AS ValorTotal

FROM 
TBEventos E, TBConvidados C

Where 
E.Id = C.IdEvento

GROUP BY
E.Descricao





