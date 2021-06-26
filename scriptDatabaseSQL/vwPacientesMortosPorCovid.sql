CREATE OR ALTER VIEW vwPacientesMortosPorCovid
    SELECT 
        [Nome]
    FROM 
        vwPacientesTestePositivo
    WHERE 
        DATEDIFF(MONTH, [Data_Teste], [Data_Obito]) < 2