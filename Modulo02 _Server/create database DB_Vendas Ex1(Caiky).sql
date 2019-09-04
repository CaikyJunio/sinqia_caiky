--Caiky Junio Barbosa De Oliveira
use master;
GO
CREATE DATABASE DB_VENDAS
ON
(
	NAME = DB_VENDAS_DAT,
	FILENAME= N'C:\Users\sinqia\Documents\Sinqia_Aspnet\DATA\DB_VENDAS.mdf',
	SIZE = 5000,
	MAXSIZE= UNLIMITED,
	FILEGROWTH = 1000KB
)

LOG ON
(
	NAME = DB_VENDAS_LOG,
	FILENAME= N'C:\Users\sinqia\Documents\Sinqia_Aspnet\DATA\DB_VENDAS_log.ldf',
	SIZE = 2000,
	MAXSIZE= UNLIMITED,
	FILEGROWTH = 1000KB

);
GO
