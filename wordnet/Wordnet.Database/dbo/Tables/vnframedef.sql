CREATE TABLE [dbo].[vnframedef] (
    [frameid]      INT           NOT NULL,
    [number]       VARCHAR (16)  NOT NULL,
    [xtag]         VARCHAR (16)  NOT NULL,
    [description1] VARCHAR (64)  NOT NULL,
    [description2] VARCHAR (64)  NULL,
    [syntax]       VARCHAR (MAX) NOT NULL,
    [semantics]    VARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK__vnframedef__3D5E1FD2] PRIMARY KEY CLUSTERED ([frameid] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [primary key]
    ON [dbo].[vnframedef]([frameid] ASC);

