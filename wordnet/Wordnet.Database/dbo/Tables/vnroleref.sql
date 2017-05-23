CREATE TABLE [dbo].[vnroleref] (
    [wordid]        INT NOT NULL,
    [synsetid]      INT CONSTRAINT [DF__vnroleref__synse__44FF419A] DEFAULT ('0') NOT NULL,
    [roleid]        INT CONSTRAINT [DF__vnroleref__rolei__45F365D3] DEFAULT ('0') NOT NULL,
    [selrestrsetid] INT NOT NULL,
    [quality]       INT NULL,
    CONSTRAINT [PK__vnroleref__440B1D61] PRIMARY KEY CLUSTERED ([wordid] ASC, [synsetid] ASC, [roleid] ASC, [selrestrsetid] ASC)
);


GO
CREATE NONCLUSTERED INDEX [fk_vnroleref_roleid]
    ON [dbo].[vnroleref]([roleid] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [primary key]
    ON [dbo].[vnroleref]([wordid] ASC, [synsetid] ASC, [roleid] ASC, [selrestrsetid] ASC);

