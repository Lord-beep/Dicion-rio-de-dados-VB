CREATE TABLE [dbo].[PNT]
(
	[IdDisciplina] INT NOT NULL PRIMARY KEY IDENTITY,
    [Disciplina] NVARCHAR(50) NOT NULL, 
    [Ano] INT NOT NULL, 
    [Modulo] INT NOT NULL
)
