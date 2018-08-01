﻿CREATE TABLE [dbo].[Usuario]
(
	[Id] INT NOT NULL IDENTITY,
	[Email] VARCHAR(100) UNIQUE NOT NULL,
	[Senha] VARCHAR(8) NOT NULL,
	[Tipo] CHAR NOT NULL,
	[Ativo] BIT NOT NULL,
	
	CONSTRAINT [PK_Usuario] PRIMARY KEY (Id)
)