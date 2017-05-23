CREATE TABLE [dbo].[xwnparselft] (
    [synsetid]     INT           NOT NULL,
    [parse]        VARCHAR (MAX) NOT NULL,
    [lft]          VARCHAR (MAX) NOT NULL,
    [parsequality] INT           NULL,
    [lftquality]   INT           NULL
);


GO
CREATE NONCLUSTERED INDEX [k_wnparselft_synsetid]
    ON [dbo].[xwnparselft]([synsetid] ASC);

