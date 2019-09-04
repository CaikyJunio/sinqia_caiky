
USE DB_CADASTRO;
GO
--CRIANDo a tabela TbEventos, com uma chave primaria auto incremento

CREATE TABLE TBPacientes
(	
	Id				int IDENTITY (1,1) not null,
	Nome			varchar (50) not null,
	CPF				varchar (11) not null,
	Data			datetime not null,
	Endereco		varchar (100),
	Telefone		varchar

	PRIMARY KEY (Id)
);
GO


ALTER TABLE TBPacientes add
Telefone	varchar(16);

Select * From TBPacientes



CREATE TABLE TBTratamentos
(
	Id				int IDENTITY (1,1)not null,
	IdPaciente		int not null,
	IdMateriaisMedicamentos		varchar (100) not null,
	Descricao		varchar (100) not null,
	Codigo          int not null,
	Preco			float not null,
	DataInicio		datetime not null,
	DataFim			datetime not null,
	
	PRIMARY KEY (Id),
	FOREIGN KEY (IdPaciente) REFERENCES	TBPacientes (Id)

	
);
GO
-- Falta colocar chave estrangeira no materiais medicamentos
--legal, então pode fazer depois. Uma dica: não precisa ter uma tabela para as consultas,
--pois estas serão realizadas via SQL






CREATE TABLE TBMedico 
(
	Id				int IDENTITY (1,1) not null,
	Nome			varchar (50) not null,
	CPF				varchar (11) not null,
	Data			datetime not null,
	Endereco		varchar (100) not null,
	Telefone		varchar (16) not null,
	PRIMARY KEY (Id)
);



CREATE TABLE TBMateriaisMedicamentos
(
	Id						int IDENTITY (1,1)not null,
	IdTratamentos			int not null,
	IdPacientes				int not null,
	DescricaoMaterial		varchar (100)not null,
	DescricaoMedicamento	varchar (100)not null,
	Codigo					int not null,
	Preco					float not null,
	Unidades				int not null,

	PRIMARY KEY(Id),
	FOREIGN KEY (IdTratamentos)  REFERENCES TBTratamentos (Id),
	FOREIGN KEY (IdPacientes)    REFERENCES TBPacientes (Id)

);
GO



CREATE TABLE TBInterTratamentoMateriasMedicamentos
(
Id					int IDENTITY (1,1) not null,
Quantidade			int not null,
IdMateriais			int not null,

PRIMARY KEY (Id),
FOREIGN KEY (IdMateriais)  REFERENCES TBMAteriaisMedicamentos (Id)
);
GO
ALTER TABLE TBInterTratamentoMateriasMedicamentos  ADD
FOREIGN KEY (IdTratamentos) REFERENCES TBTratamentos (Id)		




CREATE TABLE TBConsultas
(
	Id					int IDENTITY (1,1) not null,
	IdNomeMaterial		int not null,
	IdNomeMedicamento	   int not null,
	IdPaciente			int  not null,
	IdMedico				int not null,

	PRIMARY KEY (Id),
	
	FOREIGN KEY (IdNomeMaterial) REFERENCES TBMateriaisMedicamentos (Id),
	FOREIGN KEY (IdNomeMedicamento) REFERENCES TBMateriaisMedicamentos (Id),
	FOREIGN KEY (IdPaciente) REFERENCES TBPacientes (Id),
	FOREIGN KEY (IdMedico)	REFERENCES TBMedico (Id)

);  
GO

 


CREATE TABLE TBConvenios
(
	Id					int IDENTITY (1,1) NOT NULL,	
	IdPaciente			int not null,
	Codigo				int not null,
	Descricao			varchar (100)

	PRIMARY KEY (Id),
	FOREIGN KEY (IdPaciente)  REFERENCES TBPacientes(Id)

);
GO



