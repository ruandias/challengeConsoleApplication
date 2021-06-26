CREATE OR ALTER VIEW vwPacientesMortosPorOutraCausa AS
    SELECT 
        [Nome]
    FROM 
        vwPacientesTestePositivo
    WHERE 
        DATEDIFF(MONTH, [Data_Teste], [Data_Obito]) > 2