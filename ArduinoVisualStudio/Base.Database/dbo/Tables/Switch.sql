CREATE TABLE [dbo].[Switch] (
    [RecordID]          INT           IDENTITY (1, 1) NOT NULL,
    [InsertDT]          DATETIME      NULL,
    [LastUpdated]       DATETIME      NULL,
    [SwitchDescription] NVARCHAR (50) NULL,
    [SwitchStatus]      BIT           NULL,
    CONSTRAINT [PK_Switch] PRIMARY KEY CLUSTERED ([RecordID] ASC)
);

