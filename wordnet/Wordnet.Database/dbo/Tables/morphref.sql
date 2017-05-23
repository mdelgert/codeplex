CREATE TABLE [dbo].[morphref] (
    [wordid]  INT         CONSTRAINT [DF__morphref__wordid__1BFD2C07] DEFAULT ('0') NOT NULL,
    [pos]     VARCHAR (3) CONSTRAINT [DF__morphref__pos__1CF15040] DEFAULT ('n') NOT NULL,
    [morphid] INT         CONSTRAINT [DF__morphref__morphi__1DE57479] DEFAULT ('0') NOT NULL,
    CONSTRAINT [PK__morphref__1B0907CE] PRIMARY KEY CLUSTERED ([morphid] ASC, [pos] ASC, [wordid] ASC)
);


GO
CREATE NONCLUSTERED INDEX [k_morphref_morphid]
    ON [dbo].[morphref]([morphid] ASC);


GO
CREATE NONCLUSTERED INDEX [k_morphref_wordid]
    ON [dbo].[morphref]([wordid] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [primary key]
    ON [dbo].[morphref]([morphid] ASC, [pos] ASC, [wordid] ASC);

