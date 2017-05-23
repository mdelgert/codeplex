CREATE TABLE [dbo].[vnselrestrdef] (
    [selrestrid] INT          NOT NULL,
    [value_]     VARCHAR (32) NOT NULL,
    [type]       VARCHAR (32) NOT NULL,
    CONSTRAINT [PK__vnselrestrdef__47DBAE45] PRIMARY KEY CLUSTERED ([selrestrid] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [primary key]
    ON [dbo].[vnselrestrdef]([selrestrid] ASC);

