CREATE TABLE [dbo].[sentencedef] (
    [sentenceid] INT           CONSTRAINT [DF__sentenced__sente__2F10007B] DEFAULT ('0') NOT NULL,
    [sentence]   VARCHAR (MAX) NULL,
    CONSTRAINT [PK__sentencedef__2E1BDC42] PRIMARY KEY CLUSTERED ([sentenceid] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [primary key]
    ON [dbo].[sentencedef]([sentenceid] ASC);

