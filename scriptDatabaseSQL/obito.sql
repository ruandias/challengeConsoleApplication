USE [Covid19]
GO


CREATE TABLE [Obito]
(
    [Id] INT NOT NULL IDENTITY(1, 1),
    [Data_Obito] DATE NOT NULL,
    [Id_Paciente] INT NOT NULL,
    [CPF_Paciente] VARCHAR(13) NOT NULL,
    

    CONSTRAINT [PK_Obito] PRIMARY KEY([Id]),
    CONSTRAINT [FK_Obito_Paciente_CPF_Paciente] FOREIGN KEY ([Id_Paciente], [CPF_Paciente]) REFERENCES [Paciente] ([Id], [CPF]) ON DELETE NO ACTION,
);
GO