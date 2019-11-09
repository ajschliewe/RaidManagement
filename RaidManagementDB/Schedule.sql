CREATE TABLE [dbo].[Schedule]
(
	[ScheduleId] INT NOT NULL,
	[Description] NVARCHAR(50) NOT NULL,
	[TimeStamp] DATETIME2(0) NOT NULL,
	[RaidId] INT NOT NULL,
	CONSTRAINT [PK_Schedule] PRIMARY KEY CLUSTERED (ScheduleId),
	CONSTRAINT [FK_Raid] FOREIGN KEY ([RaidId])
	REFERENCES [Raid]([RaidId])
)
