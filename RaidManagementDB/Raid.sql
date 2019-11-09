﻿CREATE TABLE [dbo].[Raid]
(
	[RaidId] INT NOT NULL,
	[Description] NVARCHAR (50) NOT NULL,
	[StartTime] DATETIME2(0) NOT NULL,
	[CloseTime] DATETIME2(0) NULL,
	[CreatedBy] INT NULL,
	CONSTRAINT [PK_Raid] PRIMARY KEY CLUSTERED ([RaidId])
)
