CREATE TABLE [dbo].[sentenceref] (
    [synsetid]   INT CONSTRAINT [DF__sentencer__synse__31EC6D26] DEFAULT ('0') NOT NULL,
    [wordid]     INT CONSTRAINT [DF__sentencer__wordi__32E0915F] DEFAULT ('0') NOT NULL,
    [sentenceid] INT CONSTRAINT [DF__sentencer__sente__33D4B598] DEFAULT ('0') NOT NULL,
    CONSTRAINT [PK__sentenceref__30F848ED] PRIMARY KEY CLUSTERED ([synsetid] ASC, [wordid] ASC, [sentenceid] ASC)
);


GO
CREATE NONCLUSTERED INDEX [fk_sentenceref_wordid]
    ON [dbo].[sentenceref]([wordid] ASC);


GO
CREATE NONCLUSTERED INDEX [fk_sentenceref_sentenceid]
    ON [dbo].[sentenceref]([sentenceid] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [primary key]
    ON [dbo].[sentenceref]([synsetid] ASC, [wordid] ASC, [sentenceid] ASC);

