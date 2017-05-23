CREATE TABLE [dbo].[morphdef] (
    [morphid] INT          CONSTRAINT [DF__morphdef__morphi__182C9B23] DEFAULT ('0') NOT NULL,
    [lemma]   VARCHAR (70) CONSTRAINT [DF__morphdef__lemma__1920BF5C] DEFAULT ('') NOT NULL,
    CONSTRAINT [PK__morphdef__173876EA] PRIMARY KEY CLUSTERED ([morphid] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [unq_morphdef_lemma]
    ON [dbo].[morphdef]([lemma] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [primary key]
    ON [dbo].[morphdef]([morphid] ASC);

