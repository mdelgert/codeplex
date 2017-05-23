CREATE TABLE [dbo].[frameref] (
    [synsetid] INT CONSTRAINT [DF__frameref__synset__07020F21] DEFAULT ('0') NOT NULL,
    [wordid]   INT CONSTRAINT [DF__frameref__wordid__07F6335A] DEFAULT ('0') NOT NULL,
    [frameid]  INT CONSTRAINT [DF__frameref__framei__08EA5793] DEFAULT ('0') NOT NULL,
    CONSTRAINT [PK__frameref__060DEAE8] PRIMARY KEY CLUSTERED ([synsetid] ASC, [wordid] ASC, [frameid] ASC)
);


GO
CREATE NONCLUSTERED INDEX [fk_frameref_wordid]
    ON [dbo].[frameref]([wordid] ASC);


GO
CREATE NONCLUSTERED INDEX [fk_frameref_frameid]
    ON [dbo].[frameref]([frameid] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [primary key]
    ON [dbo].[frameref]([synsetid] ASC, [wordid] ASC, [frameid] ASC);

