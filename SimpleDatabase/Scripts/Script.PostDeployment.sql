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
INSERT INTO Contact ([LastName], [FirstName]) VALUES (N'Georges', N'Lucas');
INSERT INTO Contact ([LastName], [FirstName]) VALUES (N'Clint', N'Eastwood');
INSERT INTO Contact ([LastName], [FirstName]) VALUES (N'Sean', N'Connery');
INSERT INTO Contact ([LastName], [FirstName]) VALUES (N'Robert', N'De Niro');
INSERT INTO Contact ([LastName], [FirstName]) VALUES (N'Kevin', N'Bacon');
INSERT INTO Contact ([LastName], [FirstName]) VALUES (N'Kim', N'Basinger');
INSERT INTO Contact ([LastName], [FirstName]) VALUES (N'Johnny', N'Depp');
INSERT INTO Contact ([LastName], [FirstName]) VALUES (N'Julia', N'Roberts');
INSERT INTO Contact ([LastName], [FirstName]) VALUES (N'Natalie', N'Portman');
INSERT INTO Contact ([LastName], [FirstName]) VALUES (N'Georges', N'Clooney');
INSERT INTO Contact ([LastName], [FirstName]) VALUES (N'Andy', N'Garcia');
INSERT INTO Contact ([LastName], [FirstName]) VALUES (N'Bruce', N'Willis');
INSERT INTO Contact ([LastName], [FirstName]) VALUES (N'Tom', N'Cruise');
INSERT INTO Contact ([LastName], [FirstName]) VALUES (N'Reese', N'Witherspoon');
INSERT INTO Contact ([LastName], [FirstName]) VALUES (N'Sophie', N'Marceau');
INSERT INTO Contact ([LastName], [FirstName]) VALUES (N'Sarah', N'Michelle Gellar');
INSERT INTO Contact ([LastName], [FirstName]) VALUES (N'Alyssa', N'Milano');
INSERT INTO Contact ([LastName], [FirstName]) VALUES (N'Jennifer', N'Garner');
INSERT INTO Contact ([LastName], [FirstName]) VALUES (N'Michael J.', N'Fox');
INSERT INTO Contact ([LastName], [FirstName]) VALUES (N'Tom', N'Hanks');
INSERT INTO Contact ([LastName], [FirstName]) VALUES (N'David', N'Morse');
INSERT INTO Contact ([LastName], [FirstName]) VALUES (N'Sandra', N'Bullock');
INSERT INTO Contact ([LastName], [FirstName]) VALUES (N'Keanu', N'Reeves');
INSERT INTO Contact ([LastName], [FirstName]) VALUES (N'Shannen', N'Doherty');
INSERT INTO Contact ([LastName], [FirstName]) VALUES (N'Halle', N'Berry');