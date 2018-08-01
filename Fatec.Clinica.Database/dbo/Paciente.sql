create table Paciente (
Id int not null identity,
Nome varchar(100) not null,
[Cpf] VARCHAR(11) UNIQUE NOT NULL,
Telefone varchar(13) not null,
Sexo char not null,
Data_Nasc Date not null,
Ativo bit not null,
IdUsuario int not null,
Constraint [PK_Paciente] Primary Key (Id),
Constraint [FK_Paciente_Usuario] foreign key (IdUsuario) references [Usuario]([id])
)
