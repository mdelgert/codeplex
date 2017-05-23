ALTER TABLE [dbo].[Product]
    ADD CONSTRAINT [DF_Product_CreateDate] DEFAULT (getdate()) FOR [CreateDate];

