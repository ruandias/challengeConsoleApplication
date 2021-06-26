USE [Covid19]
GO

CREATE TABLE [Paciente]
(
    [Id] INT NOT NULL IDENTITY(1, 1),
    [Nome] NVARCHAR(80) NOT NULL,
    [CPF] VARCHAR(13) NOT NULL,
    [Data_Nascimento] DATE NOT NULL,
    [Idade] TINYINT NOT NULL,
    [Estado] VARCHAR(2) NOT NULL,
    [Cidade] NVARCHAR(50) NOT NULL,

    CONSTRAINT [PK_Paciente] PRIMARY KEY([Id], [CPF])
);
GO

