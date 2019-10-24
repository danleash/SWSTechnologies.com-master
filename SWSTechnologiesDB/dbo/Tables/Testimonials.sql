CREATE TABLE [dbo].[Testimonials]
(
	[Id] INT NOT NULL identity, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Company] NVARCHAR(50) NOT NULL, 
    [Message] NVARCHAR(MAX) NOT NULL, 
    [DatePublished] DATETIME NOT NULL, 
    [Publish] BIT NULL, 
    CONSTRAINT [PK_Testimonials] PRIMARY KEY ([Company])
)
