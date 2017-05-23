CREATE TABLE [dbo].[framedef] (
    [frameid] INT          CONSTRAINT [DF__framedef__framei__0425A276] DEFAULT ('0') NOT NULL,
    [frame]   VARCHAR (50) NULL,
    CONSTRAINT [PK__framedef__03317E3D] PRIMARY KEY CLUSTERED ([frameid] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [primary key]
    ON [dbo].[framedef]([frameid] ASC);

