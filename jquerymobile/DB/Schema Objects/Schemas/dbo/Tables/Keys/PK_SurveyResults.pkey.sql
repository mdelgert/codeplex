﻿ALTER TABLE [dbo].[SurveyResults]
    ADD CONSTRAINT [PK_SurveyResults] PRIMARY KEY CLUSTERED ([ResultID] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

