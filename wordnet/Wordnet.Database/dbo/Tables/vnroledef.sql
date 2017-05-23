CREATE TABLE [dbo].[vnroledef] (
    [roleid] INT          NOT NULL,
    [type]   VARCHAR (32) NOT NULL,
    CONSTRAINT [PK__vnroledef__4222D4EF] PRIMARY KEY CLUSTERED ([roleid] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [primary key]
    ON [dbo].[vnroledef]([roleid] ASC);

