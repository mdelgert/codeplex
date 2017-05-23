CREATE TABLE [dbo].[vnexampleref] (
    [frameid]   INT NOT NULL,
    [exampleid] INT NOT NULL,
    CONSTRAINT [PK__vnexampleref__3B75D760] PRIMARY KEY CLUSTERED ([frameid] ASC, [exampleid] ASC)
);


GO
CREATE NONCLUSTERED INDEX [fk_vnexampleref_exampleid]
    ON [dbo].[vnexampleref]([exampleid] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [primary key]
    ON [dbo].[vnexampleref]([frameid] ASC, [exampleid] ASC);

