CREATE TABLE [dbo].[Product] (
    [ProductID]     INT           IDENTITY (1, 1) NOT NULL,
    [CreateDate]    DATETIME      NULL,
    [ProductName]   NVARCHAR (50) NULL,
    [ProductText]   TEXT          NULL,
    [Active]        BIT           NULL,
    [ProductTypeID] INT           NULL,
    [TAGS]          NVARCHAR (50) NULL
);



