CREATE TABLE [dbo].[Contact]
(
	[Id] INT NOT NULL Identity, 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Prenom] NVARCHAR(50) NOT NULL, 
    [Created] DATETIME2 NOT NULL
        CONSTRAINT DF_CONTACT_CREATED DEFAULT (SysDateTime()), 
    CONSTRAINT [PK_Contact] PRIMARY KEY ([Id])
)
