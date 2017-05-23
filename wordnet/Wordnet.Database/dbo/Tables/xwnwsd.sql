CREATE TABLE [dbo].[xwnwsd] (
    [synsetid] INT           NOT NULL,
    [wsd]      VARCHAR (MAX) NOT NULL,
    [text]     VARCHAR (MAX) NULL,
    CONSTRAINT [PK__xwnwsd__5535A963] PRIMARY KEY CLUSTERED ([synsetid] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [primary key]
    ON [dbo].[xwnwsd]([synsetid] ASC);

