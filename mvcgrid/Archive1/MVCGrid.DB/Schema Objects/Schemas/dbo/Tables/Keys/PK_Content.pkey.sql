﻿ALTER TABLE [dbo].[Content]
    ADD CONSTRAINT [PK_Content] PRIMARY KEY CLUSTERED ([ContentID] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

