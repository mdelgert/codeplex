CREATE TABLE [dbo].[ContactsTestData] (
    [ContactID]     INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]     NVARCHAR (50) NULL,
    [MiddleName]    NVARCHAR (50) NULL,
    [LastName]      NVARCHAR (50) NULL,
    [EmailAddress]  NVARCHAR (50) NULL,
    [Phone]         NVARCHAR (25) NULL,
    [AddressLine]   NVARCHAR (60) NULL,
    [City]          NVARCHAR (30) NULL,
    [StateProvince] NVARCHAR (50) NULL,
    [PostalCode]    NVARCHAR (15) NULL
);





