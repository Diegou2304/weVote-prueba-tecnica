USE [WeVote]
GO

/****** Object:  Table [dbo].[WebViews]    Script Date: 29/11/2023 21:55:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[WebViews](
	[CountryName] [varchar](150) NULL,
	[CountryCode] [varchar](5) NULL,
	[CurrencyName] [varchar](50) NULL,
	[IpAddress] [varchar](150) NULL
) ON [PRIMARY]
GO

