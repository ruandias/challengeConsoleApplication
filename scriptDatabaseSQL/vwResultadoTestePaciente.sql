CREATE OR ALTER VIEW vwResultadoTestePaciente AS
    SELECT TOP 100
        [Paciente].[Nome],
        [Teste].[Resultado],
        [Teste].[Data_Teste]

    FROM
        [Paciente]
        INNER JOIN [Teste] ON [Teste].[Id_Paciente] = [Paciente].[Id]
    GROUP BY
        [Paciente].[Nome],
        [Teste].[Id_Paciente],
        [Teste].[Resultado],
        [Teste].[Data_Teste]

