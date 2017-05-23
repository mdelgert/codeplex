CREATE TABLE [dbo].[legacy] (
    [synsetid]  INT NOT NULL,
    [synsetid2] INT NOT NULL,
    [score]     INT NULL,
    CONSTRAINT [PK__legacy__0AD2A005] PRIMARY KEY CLUSTERED ([synsetid] ASC, [synsetid2] ASC)
);


GO
CREATE NONCLUSTERED INDEX [k_legacy_synsetid2]
    ON [dbo].[legacy]([synsetid2] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [primary key]
    ON [dbo].[legacy]([synsetid] ASC, [synsetid2] ASC);

