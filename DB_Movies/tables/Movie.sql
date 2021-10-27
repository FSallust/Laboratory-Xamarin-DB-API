CREATE TABLE [dbo].[movie]
(
	[Id] INT NOT NULL IDENTITY,
	[Title] VARCHAR(150) NOT NULL,
	[ReleaseYear] INT NOT NULL,
	[Synopsis] TEXT NOT NULL,
	[PosterUrl] VARCHAR(250) NOT NULL,
	[RealisatorId] INT NOT NULL,
	[ScenaristId] INT NOT NULL,
	[CategoryId] INT NOT NULL,
	[PersonnalComment] TEXT NOT NULL, 
    CONSTRAINT [PK_Movie] PRIMARY KEY ([Id]), 
    /*CONSTRAINT [FK_Movie_Realisator] FOREIGN KEY ([RealisatorId]) REFERENCES [Person]([Id]), 
    CONSTRAINT [FK_Movie_Scenarist] FOREIGN KEY ([ScenaristId]) REFERENCES [Person]([Id]), 
    CONSTRAINT [FK_Movie_Category] FOREIGN KEY ([CategoryId]) REFERENCES [Category]([Id]),
	*/
)
