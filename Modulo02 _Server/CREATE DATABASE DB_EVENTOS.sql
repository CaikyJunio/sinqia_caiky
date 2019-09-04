use master;
go
CREATE DATABASE DB_EVENTOS
ON
(
	NAME = DB_EVENTOS_DAT,
	FILENAME= N'C:\Users\sinqia\Documents\Sinqia_Aspnet\DATA\DB_Eventos.mdf',
	SIZE = 5000,
	MAXSIZE= UNLIMITED,
	FILEGROWTH = 1000KB
)

LOG ON
(
	NAME = DB_EVENTOS_LOG,
	FILENAME= N'C:\Users\sinqia\Documents\Sinqia_Aspnet\DATA\DB_Eventos_log.ldf',
	SIZE = 2000,
	MAXSIZE= UNLIMITED,
	FILEGROWTH = 1000KB

);
GO