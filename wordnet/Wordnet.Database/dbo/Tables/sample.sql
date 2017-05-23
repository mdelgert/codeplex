CREATE TABLE [dbo].[sample] (
    [synsetid] INT           CONSTRAINT [DF__sample__synsetid__20C1E124] DEFAULT ('0') NOT NULL,
    [sampleid] INT           CONSTRAINT [DF__sample__sampleid__21B6055D] DEFAULT ('0') NOT NULL,
    [sample]   VARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK__sample__1FCDBCEB] PRIMARY KEY CLUSTERED ([synsetid] ASC, [sampleid] ASC)
);


GO
CREATE NONCLUSTERED INDEX [k_sample_synsetid]
    ON [dbo].[sample]([synsetid] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [primary key]
    ON [dbo].[sample]([synsetid] ASC, [sampleid] ASC);

