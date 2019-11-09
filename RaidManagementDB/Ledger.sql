CREATE TABLE [dbo].[Ledger]
(
	[LedgerId] INT IDENTITY(1,1) NOT NULL,
	[CharacterId] INT NOT NULL,
	[RaidId] INT NOT NULL,
	[ScheduleId] INT NULL,
	[Description] NVARCHAR(50) NOT NULL,
	[Item] NVARCHAR(100) NULL,
	[Amount] SMALLINT NOT NULL,
	[CreatedOn] DATETIME2(0) NOT NULL,
	[CreatedBy] INT NULL,
	[ModifiedOn] DATETIME2(0) NOT NULL,
	[ModifiedBy] INT NULL,
	CONSTRAINT [PK_Ledger] PRIMARY KEY CLUSTERED (LedgerId),
	CONSTRAINT [FK_Character] FOREIGN KEY (CharacterId)
	REFERENCES [Character](CharacterId),
	CONSTRAINT [FK_Raid_Ledger] FOREIGN KEY ([RaidId])
	REFERENCES [Raid] ([RaidId])
)
