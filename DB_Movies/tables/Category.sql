CREATE TABLE [dbo].[Category]
(
	[Id] INT NOT NULL IDENTITY, 
	[NameCat] VARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Category] PRIMARY KEY ([Id]), 
)
