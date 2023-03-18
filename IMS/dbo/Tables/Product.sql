CREATE TABLE [dbo].[Product] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Name]      VARCHAR (MAX) NULL,
    [CreatedOn] DATETIME      NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([Id] ASC)
);

