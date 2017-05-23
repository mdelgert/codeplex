CREATE TABLE [dbo].[semlinkref] (
    [synset1id] INT CONSTRAINT [DF__semlinkre__synse__24927208] DEFAULT ('0') NOT NULL,
    [synset2id] INT CONSTRAINT [DF__semlinkre__synse__25869641] DEFAULT ('0') NOT NULL,
    [linkid]    INT CONSTRAINT [DF__semlinkre__linki__267ABA7A] DEFAULT ('0') NOT NULL,
    CONSTRAINT [PK__semlinkref__239E4DCF] PRIMARY KEY CLUSTERED ([synset1id] ASC, [synset2id] ASC, [linkid] ASC)
);


GO
CREATE NONCLUSTERED INDEX [fk_semlinkref_linkid]
    ON [dbo].[semlinkref]([linkid] ASC);


GO
CREATE NONCLUSTERED INDEX [k_semlinkref_synset2id]
    ON [dbo].[semlinkref]([synset2id] ASC);


GO
CREATE NONCLUSTERED INDEX [k_semlinkref_synset1id]
    ON [dbo].[semlinkref]([synset1id] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [primary key]
    ON [dbo].[semlinkref]([synset1id] ASC, [synset2id] ASC, [linkid] ASC);

