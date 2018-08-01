CREATE TABLE [dbo].[Medico]
(
	[Id] INT NOT NULL IDENTITY, 
	[IdEspecialidade] INT NOT NULL,
	[IdUsuario] INT NOT NULL,
    [Nome] VARCHAR(100) NOT NULL, 
    [Crm] VARCHAR(10) UNIQUE NOT NULL, 
	[Telefone_r] VARCHAR(13) NOT NULL,
	[Telefone_c] VARCHAR(13) NOT NULL,
	[Endereco_c] VARCHAR(100) NOT NULL,
	[Cidade] VARCHAR(50) NOT NULL,
	[Estado] VARCHAR(2) NOT NULL,
	[Ativo] BIT NOT NULL,

	CONSTRAINT [PK_Medico] PRIMARY KEY (Id),
    CONSTRAINT [FK_Medico_Especialidade] FOREIGN KEY (IdEspecialidade) REFERENCES [Especialidade]([Id]),
	CONSTRAINT [FK_Medico_Usuario] FOREIGN KEY (IdUsuario) REFERENCES [Usuario]([Id])
)
