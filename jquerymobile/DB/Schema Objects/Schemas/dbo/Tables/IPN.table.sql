﻿CREATE TABLE [dbo].[IPN] (
    [IPNID]                  INT             IDENTITY (1, 1) NOT NULL,
    [CreateDate]             DATETIME        NOT NULL,
    [LastUpdated]            DATETIME        NULL,
    [Environment]            VARCHAR (20)    NOT NULL,
    [ResponseIN]             TEXT            NOT NULL,
    [ResponseParsed]         BIT             NULL,
    [txn_id]                 NVARCHAR (50)   NULL,
    [mc_gross]               DECIMAL (18, 2) NULL,
    [tax]                    DECIMAL (18, 2) NULL,
    [protection_eligibility] NVARCHAR (50)   NULL,
    [address_status]         NVARCHAR (50)   NULL,
    [payer_id]               NVARCHAR (50)   NULL,
    [first_name]             NVARCHAR (50)   NULL,
    [last_name]              NVARCHAR (50)   NULL,
    [address_street]         NVARCHAR (50)   NULL,
    [payment_date]           NVARCHAR (50)   NULL,
    [payment_status]         NVARCHAR (50)   NULL,
    [charset]                NVARCHAR (50)   NULL,
    [address_zip]            NUMERIC (18)    NULL,
    [mc_fee]                 DECIMAL (18, 2) NULL,
    [address_country_code]   NVARCHAR (50)   NULL,
    [address_name]           NVARCHAR (50)   NULL,
    [notify_version]         DECIMAL (18, 2) NULL,
    [custom]                 NVARCHAR (256)  NULL,
    [payer_status]           NVARCHAR (50)   NULL,
    [business]               NVARCHAR (200)  NULL,
    [address_country]        NVARCHAR (50)   NULL,
    [address_city]           NVARCHAR (50)   NULL,
    [quantity]               INT             NULL,
    [verify_sign]            NVARCHAR (256)  NULL,
    [payer_email]            NVARCHAR (200)  NULL,
    [payment_type]           NVARCHAR (50)   NULL,
    [address_state]          NVARCHAR (50)   NULL,
    [receiver_email]         NVARCHAR (200)  NULL,
    [payment_fee]            DECIMAL (18, 2) NULL,
    [receiver_id]            NVARCHAR (50)   NULL,
    [txn_type]               NVARCHAR (50)   NULL,
    [item_name]              NVARCHAR (50)   NULL,
    [mc_currency]            NVARCHAR (50)   NULL,
    [item_number]            NVARCHAR (50)   NULL,
    [residence_country]      NVARCHAR (50)   NULL,
    [test_ipn]               NVARCHAR (50)   NULL,
    [handling_amount]        DECIMAL (18, 2) NULL,
    [transaction_subject]    NVARCHAR (256)  NULL,
    [payment_gross]          DECIMAL (18, 2) NULL,
    [shipping]               DECIMAL (18, 2) NULL,
    [ipn_track_id]           NVARCHAR (50)   NULL
);

