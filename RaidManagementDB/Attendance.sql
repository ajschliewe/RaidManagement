CREATE TABLE [dbo].[Attendance]
(
	[CharacterId] INT NOT NULL,
	[ScheduleId] INT NOT NULL,
	CONSTRAINT PK_Attendance PRIMARY KEY CLUSTERED (CharacterId,ScheduleId),
	CONSTRAINT FK_Attend_Char FOREIGN KEY (CharacterId)
	REFERENCES [Character](CharacterId),
	CONSTRAINT FK_Sched_Attend FOREIGN KEY (ScheduleId)
	REFERENCES Schedule(ScheduleId)
)
