CREATE TABLE [dbo].[vnselrestrref] (
    [selrestrsetid] INT         NOT NULL,
    [selrestrid]    INT         NOT NULL,
    [logic]         VARCHAR (3) NULL,
    CONSTRAINT [PK__vnselrestrref__49C3F6B7] PRIMARY KEY CLUSTERED ([selrestrsetid] ASC, [selrestrid] ASC)
);


GO
CREATE NONCLUSTERED INDEX [fk_vnselrestrref_selrestrid]
    ON [dbo].[vnselrestrref]([selrestrid] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [primary key]
    ON [dbo].[vnselrestrref]([selrestrsetid] ASC, [selrestrid] ASC);

