CREATE TABLE [dbo].[casedword] (
    [wordid] INT          CONSTRAINT [DF__casedword__wordi__7D78A4E7] DEFAULT ('0') NOT NULL,
    [lemma]  VARCHAR (80) CONSTRAINT [DF__casedword__lemma__7E6CC920] DEFAULT ('') NOT NULL,
    CONSTRAINT [PK__casedword__7C8480AE] PRIMARY KEY CLUSTERED ([wordid] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [unq_casedword_lemma]
    ON [dbo].[casedword]([lemma] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [primary key]
    ON [dbo].[casedword]([wordid] ASC);

