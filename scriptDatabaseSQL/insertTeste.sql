USE [Covid19]
GO

INSERT INTO [Teste] ([Data_Teste], [Id_Paciente], [CPF_Paciente], [Resultado]) 
    VALUES('2021-03-25', '1', '14929818770', 0);

INSERT INTO [Teste] ([Data_Teste], [Id_Paciente], [CPF_Paciente], [Resultado]) 
    VALUES('2021-03-24', '2', '30036369365', 0);

INSERT INTO [Teste] ([Data_Teste], [Id_Paciente], [CPF_Paciente], [Resultado]) 
    VALUES('2021-03-23', '3', '00167486110', 0);

INSERT INTO [Teste] ([Data_Teste], [Id_Paciente], [CPF_Paciente], [Resultado]) 
    VALUES('2021-03-22', '4', '99647059728', 0);

INSERT INTO [Teste] ([Data_Teste], [Id_Paciente], [CPF_Paciente], [Resultado]) 
    VALUES('2021-03-21', '5', '13969688906', 0);

SELECT * FROM [Teste]