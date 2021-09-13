/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
INSERT INTO Contact ([FirstName], [LastName]) VALUES (N'Georges', N'Lucas');
INSERT INTO Contact ([FirstName], [LastName]) VALUES (N'Clint', N'Eastwood');
INSERT INTO Contact ([FirstName], [LastName]) VALUES (N'Sean', N'Connery');
INSERT INTO Contact ([FirstName], [LastName]) VALUES (N'Robert', N'De Niro');
INSERT INTO Contact ([FirstName], [LastName]) VALUES (N'Kevin', N'Bacon');
INSERT INTO Contact ([FirstName], [LastName]) VALUES (N'Kim', N'Basinger');
INSERT INTO Contact ([FirstName], [LastName]) VALUES (N'Johnny', N'Depp');
INSERT INTO Contact ([FirstName], [LastName]) VALUES (N'Julia', N'Roberts');
INSERT INTO Contact ([FirstName], [LastName]) VALUES (N'Natalie', N'Portman');
INSERT INTO Contact ([FirstName], [LastName]) VALUES (N'Georges', N'Clooney');
INSERT INTO Contact ([FirstName], [LastName]) VALUES (N'Andy', N'Garcia');
INSERT INTO Contact ([FirstName], [LastName]) VALUES (N'Bruce', N'Willis');
INSERT INTO Contact ([FirstName], [LastName]) VALUES (N'Tom', N'Cruise');
INSERT INTO Contact ([FirstName], [LastName]) VALUES (N'Reese', N'Witherspoon');
INSERT INTO Contact ([FirstName], [LastName]) VALUES (N'Sophie', N'Marceau');
INSERT INTO Contact ([FirstName], [LastName]) VALUES (N'Sarah', N'Michelle Gellar');
INSERT INTO Contact ([FirstName], [LastName]) VALUES (N'Alyssa', N'Milano');
INSERT INTO Contact ([FirstName], [LastName]) VALUES (N'Jennifer', N'Garner');
INSERT INTO Contact ([FirstName], [LastName]) VALUES (N'Michael J.', N'Fox');
INSERT INTO Contact ([FirstName], [LastName]) VALUES (N'Tom', N'Hanks');
INSERT INTO Contact ([FirstName], [LastName]) VALUES (N'David', N'Morse');
INSERT INTO Contact ([FirstName], [LastName]) VALUES (N'Sandra', N'Bullock');
INSERT INTO Contact ([FirstName], [LastName]) VALUES (N'Keanu', N'Reeves');
INSERT INTO Contact ([FirstName], [LastName]) VALUES (N'Shannen', N'Doherty');
INSERT INTO Contact ([FirstName], [LastName]) VALUES (N'Halle', N'Berry');