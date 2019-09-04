USE DB_EVENTOS
GO

-- Inserir dados na tabela TBEventos (4 Eventos)

--- OBS: As datas podem ser fornecidas nos formatos
--MM/dd/yyyy ou yyyy-mm-dd

INSERT INTO	TBEventos (Descricao,Responsavel,Data,Preco)

VALUES
('Palestra Javascript', 'Prof.Joao', '2019-08-12', 500 ),
('Formatura TI', 'Unip', '2019-12-20',0),
('Passeio por BH','Sinqia','2019-08-10',100),
('Aula de Ingles', 'Prof.Maria','2019-08-15', 300)

--Inserir dados na tabela convidados (Procurar colocar mais de um por evento)


INSERT INTO TBConvidados (Cpf, IdEvento,Nome,Email,Telefone)
VALUES

('72128552610',4,'Marcela','troia@sememail.com.br','3435-1700')

('02128552610',2,'Bolsonaro','suite@sememail.com.br', '3365-2200'),
('41128552650',3,'Marcos','atendimento@sememail.com.br', '3365-2211'),
('32128552610',3,'Lucas','suit@sememail.com.br', '3365-2150'),
('02128552650',4,'Marcos','atendimento@sememail.com.br', '3365-0000'),
('05528552610',4,'Jose','su@sememail.com.br', '3265-5200'),
('02128552650',5,'Daniel','atendimento@sememail.com.br', '3365-2211'),
('04518552610',5,'Emanoela','to@sememail.com.br', '2100-2200'),
('71432552650',6,'Larissa','ato@sememail.com.br', '3585-2711'),
('98218552610',6,'Carol','carol@sememail.com.br', '3132-2000')


select *  from TBEventos


-- transferindo dados da tabela TbEventos backup para a tabela
--TbEventos, mediante consulta

INSERT INTO TBEventos (Descricao,Responsavel,Data,Preco)
SELECT Descricao, Responsavel, Data, Preco, FROM TBEventosBackup


SELECT * FROM TBEventosBackup

