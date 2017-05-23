﻿CREATE TABLE [dbo].[SiteLog] (
    [SiteLogID]                INT             IDENTITY (1, 1) NOT NULL,
    [CreateDate]               DATETIME        NOT NULL,
    [PortalID]                 INT             NOT NULL,
    [UserID]                   INT             NULL,
    [Ajax]                     BIT             NULL,
    [Host]                     NVARCHAR (255)  NULL,
    [FileName]                 NVARCHAR (255)  NULL,
    [RequestRequestType]       NVARCHAR (255)  NULL,
    [RequestUserHostAddress]   NVARCHAR (255)  NULL,
    [RequestUserHostName]      NVARCHAR (255)  NULL,
    [RequestHttpMethod]        NVARCHAR (20)   NULL,
    [ClientHeight]             INT             NULL,
    [ClientWidth]              INT             NULL,
    [Browser]                  NVARCHAR (20)   NULL,
    [BrowserType]              NVARCHAR (20)   NULL,
    [BrowserVersion]           DECIMAL (18, 1) NULL,
    [BrowserMajorVersion]      INT             NULL,
    [BrowserPlatform]          NVARCHAR (20)   NULL,
    [BrowserCrawler]           BIT             NULL,
    [BrowserFrames]            BIT             NULL,
    [BrowserTables]            BIT             NULL,
    [BrowserCookies]           BIT             NULL,
    [BrowserVBScript]          BIT             NULL,
    [BrowserEcmaScriptVersion] DECIMAL (18, 1) NULL,
    [BrowserJavaApplets]       BIT             NULL,
    [BrowserActiveXControls]   BIT             NULL,
    [BrowserJavaScriptVersion] DECIMAL (18, 1) NULL
);

