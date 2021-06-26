CREATE OR ALTER VIEW vwPacientesQueMorreram AS
    SELECT TOP 100
        [Paciente].[Nome],
        [Obito].[Data_Obito]

    FROM
        [Paciente]
        INNER JOIN [Obito] ON [Obito].[Id_Paciente] = [Paciente].[Id]
    GROUP BY
        [Paciente].[Nome],
        [Obito].[Id_Paciente],
        [Obito].[Data_Obito]
