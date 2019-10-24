CREATE TABLE [dbo].[ClientContactinfo] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (50)  NOT NULL,
    [PhoneNumber]   NCHAR (10)     NOT NULL,
    [EmailAddress]  NVARCHAR (50)  NOT NULL,
    [Message]       NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

