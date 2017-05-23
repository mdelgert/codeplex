CREATE TABLE [dbo].[linkdef] (
    [linkid]   INT          CONSTRAINT [DF__linkdef__linkid__145C0A3F] DEFAULT ('0') NOT NULL,
    [name]     VARCHAR (50) NULL,
    [recurses] VARCHAR (3)  CONSTRAINT [DF__linkdef__recurse__15502E78] DEFAULT ('N') NOT NULL,
    CONSTRAINT [PK__linkdef__1367E606] PRIMARY KEY CLUSTERED ([linkid] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [primary key]
    ON [dbo].[linkdef]([linkid] ASC);

