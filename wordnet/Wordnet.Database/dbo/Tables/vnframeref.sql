CREATE TABLE [dbo].[vnframeref] (
    [wordid]   INT NOT NULL,
    [synsetid] INT CONSTRAINT [DF__vnframere__synse__403A8C7D] DEFAULT ('0') NOT NULL,
    [frameid]  INT NOT NULL,
    [quality]  INT NULL,
    CONSTRAINT [PK__vnframeref__3F466844] PRIMARY KEY CLUSTERED ([wordid] ASC, [synsetid] ASC, [frameid] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [primary key]
    ON [dbo].[vnframeref]([wordid] ASC, [synsetid] ASC, [frameid] ASC);

