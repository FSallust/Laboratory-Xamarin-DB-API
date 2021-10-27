/*
Modello di script post-distribuzione							
--------------------------------------------------------------------------------------
 Questo file contiene istruzioni SQL che verranno aggiunte allo script di compilazione		
 Utilizzare la sintassi SQLCMD per includere un file nello script post-distribuzione			
 Esempio:      :r .\myfile.sql								
 Utilizzare la sintassi SQLCMD per fare riferimento a una variabile nello script post-distribuzione		
 Esempio:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

/*Venom Carnage*/
/*Category*/
INSERT INTO Category (NameCat) VALUES ('Super Heroes')

/*Realisator*/
INSERT INTO Person (LastName, FirstName, PictureUrl) VALUES ('Serkis', 'Andrew Clement', 'https://en.wikipedia.org/wiki/Andy_Serkis#/media/File:Andy_Serkis_by_Gage_Skidmore_2.jpg')

/*Scenarist*/
INSERT INTO Person (LastName, FirstName, PictureUrl) VALUES ('Marcel', 'Kelly', 'https://http.cat/404')

/*Acteurs*/
INSERT INTO Person (LastName, FirstName, PictureUrl) VALUES ('Hardy', 'Tom', 'https://en.wikipedia.org/wiki/Tom_Hardy#/media/File:Tom_Hardy_by_Gage_Skidmore.jpg')
INSERT INTO Person (LastName, FirstName, PictureUrl) VALUES ('Harrelson', 'Woody', 'https://en.wikipedia.org/wiki/Woody_Harrelson#/media/File:Woody_Harrelson_October_2016.jpg')
INSERT INTO Person (LastName, FirstName, PictureUrl) VALUES ('Williams', 'Michelle', 'https://en.wikipedia.org/wiki/Michelle_Williams_(actress)#/media/File:Michelle_Williams_2012_Shankbone_3_(cropped).JPG')
INSERT INTO Person (LastName, FirstName, PictureUrl) VALUES ('Harris', 'Noemi', 'https://en.wikipedia.org/wiki/Naomie_Harris#/media/File:Naomie_Harris_2014.jpg')

/*Movie*/
INSERT INTO Movie (Title, ReleaseYear, Synopsis, PosterUrl, RealisatorId, ScenaristId, CategoryId, PersonnalComment) VALUES (
'Venom: Let Ther Be Carnage', 
2021, 
'After finding a host body in investigative reporter Eddie Brock, the alien symbiote must face a new enemy, Carnage, the alter ego of serial killer Cletus Kasady.', 
'https://upload.wikimedia.org/wikipedia/en/a/a7/Venom_Let_There_Be_Carnage_poster.jpg', 
1, 
2, 
1, 
'Didn''t see it')

/*Casting*/
INSERT INTO Casting (MovieId, PersonId, [Role]) VALUES (1, 3, 'Eddie Brock / Venom')

/*Dune*/
/*Category*/
INSERT INTO Category (NameCat) VALUES ('Science Fiction')

/*Realisator*/
INSERT INTO Person (LastName, FirstName, PictureUrl) VALUES ('Villeneuve', 'Denis', 'https://it.wikipedia.org/wiki/File:Denis_Villeneuve_by_Gage_Skidmore.jpg')

/*Scenarist*/
INSERT INTO Person (LastName, FirstName, PictureUrl) VALUES ('Roth', 'Eric', 'https://http.cat/404')

/*Acteurs*/
INSERT INTO Person (LastName, FirstName, PictureUrl) VALUES ('Chalamet', 'Timothée', 'https://upload.wikimedia.org/wikipedia/commons/9/95/%ED%8B%B0%EB%AA%A8%EC%8B%9C_%EC%83%AC%EB%9D%BC%EB%A9%94_%28Timothee_Chalamet%29_%27%EB%8D%94_%ED%82%B9_%ED%97%A8%EB%A6%AC_5%EC%84%B8%27_04.png')
INSERT INTO Person (LastName, FirstName, PictureUrl) VALUES ('Coleman', 'Zendaya', 'https://upload.wikimedia.org/wikipedia/commons/thumb/2/28/Zendaya_-_2019_by_Glenn_Francis.jpg/200px-Zendaya_-_2019_by_Glenn_Francis.jpg')

/*Movie*/
INSERT INTO Movie (Title, ReleaseYear, Synopsis, PosterUrl, RealisatorId, ScenaristId, CategoryId, PersonnalComment) VALUES (
'Dune', 
2021, 
'Paul Atreides, a brilliant and gifted young man born into a great destiny beyond his understanding, must travel to the most dangerous planet in the universe to ensure the future of his family and his people. As malevolent forces explode into conflict over the planet''s exclusive supply of the most precious resource in existence-a commodity capable of unlocking humanity''s greatest potential-only those who can conquer their fear will survive.', 
'https://assets-prd.ignimgs.com/2021/08/09/dune-insta-vert-main-dom-1638x2048-1628522913715.jpg', 
7, 
8, 
2, 
'Spectacular!')

/*Casting*/
INSERT INTO Casting (MovieId, PersonId, [Role]) VALUES (2, 9, 'Paul Atreides')
INSERT INTO Casting (MovieId, PersonId, [Role]) VALUES (2, 10, 'Chani')

/*Constraintes*/
ALTER TABLE Movie ADD CONSTRAINT [FK_Movie_Realisator] FOREIGN KEY ([RealisatorId]) REFERENCES [Person]([Id])
ALTER TABLE Movie ADD CONSTRAINT [FK_Movie_Scenarist] FOREIGN KEY ([ScenaristId]) REFERENCES [Person]([Id])
ALTER TABLE Movie ADD CONSTRAINT [FK_Movie_Category] FOREIGN KEY ([CategoryId]) REFERENCES [Category]([Id])
ALTER TABLE Casting ADD CONSTRAINT [FK_Casting_Movie] FOREIGN KEY ([MovieId]) REFERENCES [Movie]([Id])
ALTER TABLE Casting ADD CONSTRAINT [FK_Casting_Person] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id])