CREATE TABLE [dbo].[wordposition] (
    [synsetid]   INT         CONSTRAINT [DF__wordposit__synse__5070F446] DEFAULT ('0') NOT NULL,
    [wordid]     INT         CONSTRAINT [DF__wordposit__wordi__5165187F] DEFAULT ('0') NOT NULL,
    [positionid] VARCHAR (4) CONSTRAINT [DF__wordposit__posit__52593CB8] DEFAULT ('a') NOT NULL,
    CONSTRAINT [PK__wordposition__4F7CD00D] PRIMARY KEY CLUSTERED ([synsetid] ASC, [wordid] ASC)
);


GO
CREATE NONCLUSTERED INDEX [fk_wordposition_wordid]
    ON [dbo].[wordposition]([wordid] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [primary key]
    ON [dbo].[wordposition]([synsetid] ASC, [wordid] ASC);

