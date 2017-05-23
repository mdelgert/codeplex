CREATE TABLE [dbo].[TaskList] (
    [TaskId]     INT           IDENTITY (1, 1) NOT NULL,
    [TaskName]   NVARCHAR (50) NULL,
    [TaskText]   VARCHAR (MAX) NULL,
    [CreateDate] DATETIME      NULL,
    CONSTRAINT [PK_TaskList] PRIMARY KEY CLUSTERED ([TaskId] ASC)
);

