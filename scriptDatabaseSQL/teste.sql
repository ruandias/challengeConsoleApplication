USE [Covid19]
GO

CREATE TABLE [Teste]
(
    [Id] INT NOT NULL IDENTITY(1, 1),
    [Data_Teste] DATE NOT NULL,
    [Id_Paciente] INT NOT NULL,
    [CPF_Paciente] VARCHAR(13) NOT NULL,
    [Resultado] BIT NOT NULL,

    CONSTRAINT [PK_Teste] PRIMARY KEY([Id]),
    CONSTRAINT [FK_Teste_Paciente_CPF_Paciente] FOREIGN KEY ([Id_Paciente],[CPF_Paciente]) 
    REFERENCES [Paciente] ([Id], [CPF]) ON DELETE NO ACTION,
);
GO
