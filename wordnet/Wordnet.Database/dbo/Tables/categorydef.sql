CREATE TABLE [dbo].[categorydef] (
    [categoryid] INT          CONSTRAINT [DF__categoryd__categ__014935CB] DEFAULT ('0') NOT NULL,
    [name]       VARCHAR (32) NULL,
    [pos]        VARCHAR (3)  NULL,
    CONSTRAINT [PK__categorydef__00551192] PRIMARY KEY CLUSTERED ([categoryid] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [primary key]
    ON [dbo].[categorydef]([categoryid] ASC);

