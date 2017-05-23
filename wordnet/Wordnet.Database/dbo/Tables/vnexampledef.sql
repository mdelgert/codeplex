CREATE TABLE [dbo].[vnexampledef] (
    [exampleid] INT           NOT NULL,
    [example]   VARCHAR (256) NOT NULL,
    CONSTRAINT [PK__vnexampledef__398D8EEE] PRIMARY KEY CLUSTERED ([exampleid] ASC)
);


GO
CREATE NONCLUSTERED INDEX [k_vnexampledef_example]
    ON [dbo].[vnexampledef]([example] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [primary key]
    ON [dbo].[vnexampledef]([exampleid] ASC);

