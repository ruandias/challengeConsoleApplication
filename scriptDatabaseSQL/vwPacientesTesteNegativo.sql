CREATE OR ALTER VIEW vwPacientesTesteNegativo AS
    SELECT TOP 100
        [Paciente].[Nome],
        [Paciente].[CPF],
        [Teste].[Data_Teste],
        [Teste].[Resultado],
        [Obito].[Data_Obito]

    FROM
        [Paciente]
        INNER JOIN [Obito] ON [Obito].[Id_Paciente] = [Paciente].[Id]
        INNER JOIN [Teste] ON [Teste].[Id_Paciente] = [Paciente].[Id]
    GROUP BY
        [Paciente].[Nome],
        [Paciente].[CPF],
        [Teste].[Id_Paciente],
        [Teste].[Data_Teste],
        [Teste].[Resultado],
        [Obito].[Id_Paciente],
        [Obito].[Data_Obito]
    HAVING 
        [Teste].[Resultado] = 0