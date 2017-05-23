CREATE TABLE [dbo].[lexlinkref] (
    [synset1id] INT CONSTRAINT [DF__lexlinkre__synse__0DAF0CB0] DEFAULT ('0') NOT NULL,
    [word1id]   INT CONSTRAINT [DF__lexlinkre__word1__0EA330E9] DEFAULT ('0') NOT NULL,
    [synset2id] INT CONSTRAINT [DF__lexlinkre__synse__0F975522] DEFAULT ('0') NOT NULL,
    [word2id]   INT CONSTRAINT [DF__lexlinkre__word2__108B795B] DEFAULT ('0') NOT NULL,
    [linkid]    INT CONSTRAINT [DF__lexlinkre__linki__117F9D94] DEFAULT ('0') NOT NULL,
    CONSTRAINT [PK__lexlinkref__0CBAE877] PRIMARY KEY CLUSTERED ([word1id] ASC, [synset1id] ASC, [word2id] ASC, [synset2id] ASC, [linkid] ASC)
);


GO
CREATE NONCLUSTERED INDEX [fk_lexlinkref_linkid]
    ON [dbo].[lexlinkref]([linkid] ASC);


GO
CREATE NONCLUSTERED INDEX [fk_lexlinkref_word2id]
    ON [dbo].[lexlinkref]([word2id] ASC);


GO
CREATE NONCLUSTERED INDEX [k_lexlinkref_synset2id_word2id]
    ON [dbo].[lexlinkref]([synset2id] ASC, [word2id] ASC);


GO
CREATE NONCLUSTERED INDEX [k_lexlinkref_synset1id_word1id]
    ON [dbo].[lexlinkref]([synset1id] ASC, [word1id] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [primary key]
    ON [dbo].[lexlinkref]([word1id] ASC, [synset1id] ASC, [word2id] ASC, [synset2id] ASC, [linkid] ASC);

