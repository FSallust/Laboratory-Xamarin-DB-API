CREATE TABLE [dbo].[Casting]
(
	[Id] INT NOT NULL IDENTITY, 
	[MovieId] INT NOT NULL, 
	[PersonId] INT NOT NULL, 
	[Role] VARCHAR(150) NOT NULL, 
    CONSTRAINT [PK_Casting] PRIMARY KEY ([Id]), 
    /*CONSTRAINT [FK_Casting_Movie] FOREIGN KEY ([MovieId]) REFERENCES [Movie]([Id]), 
    CONSTRAINT [FK_Casting_Person] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id]), 
	*/
)
