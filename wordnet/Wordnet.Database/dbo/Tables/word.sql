CREATE TABLE [dbo].[word] (
    [wordid] INT          CONSTRAINT [DF__word__wordid__4CA06362] DEFAULT ('0') NOT NULL,
    [lemma]  VARCHAR (80) CONSTRAINT [DF__word__lemma__4D94879B] DEFAULT ('') NOT NULL,
    CONSTRAINT [PK__word__4BAC3F29] PRIMARY KEY CLUSTERED ([wordid] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [unq_word_lemma]
    ON [dbo].[word]([lemma] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [primary key]
    ON [dbo].[word]([wordid] ASC);

