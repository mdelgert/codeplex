CREATE TABLE [dbo].[synset] (
    [synsetid]   INT           CONSTRAINT [DF__synset__synsetid__36B12243] DEFAULT ('0') NOT NULL,
    [pos]        VARCHAR (3)   NULL,
    [categoryid] INT           CONSTRAINT [DF__synset__category__37A5467C] DEFAULT ('0') NOT NULL,
    [definition] VARCHAR (MAX) NULL,
    CONSTRAINT [PK__synset__35BCFE0A] PRIMARY KEY CLUSTERED ([synsetid] ASC)
);


GO
CREATE NONCLUSTERED INDEX [fk_synset_categoryid]
    ON [dbo].[synset]([categoryid] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [primary key]
    ON [dbo].[synset]([synsetid] ASC);

