CREATE TABLE [dbo].[sense] (
    [wordid]      INT CONSTRAINT [DF__sense__wordid__29572725] DEFAULT ('0') NOT NULL,
    [casedwordid] INT NULL,
    [synsetid]    INT CONSTRAINT [DF__sense__synsetid__2A4B4B5E] DEFAULT ('0') NOT NULL,
    [rank]        INT CONSTRAINT [DF__sense__rank__2B3F6F97] DEFAULT ('0') NOT NULL,
    [lexid]       INT CONSTRAINT [DF__sense__lexid__2C3393D0] DEFAULT ('0') NOT NULL,
    [tagcount]    INT NULL,
    CONSTRAINT [PK__sense__286302EC] PRIMARY KEY CLUSTERED ([synsetid] ASC, [wordid] ASC)
);


GO
CREATE NONCLUSTERED INDEX [k_sense_synsetid]
    ON [dbo].[sense]([synsetid] ASC);


GO
CREATE NONCLUSTERED INDEX [k_sense_wordid]
    ON [dbo].[sense]([wordid] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [primary key]
    ON [dbo].[sense]([synsetid] ASC, [wordid] ASC);

