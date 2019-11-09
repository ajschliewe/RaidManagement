CREATE PROCEDURE [dbo].[usp_CreateScheduleEntry]
	@RaidId int,
	@Date datetime2(0)
AS
	IF (Select count(*) from Schedule where TimeStamp=@date) = 0
	BEGIN
		Insert into Schedule(Description,TimeStamp,RaidId) values ('Raid Attendance',@Date,@RaidId)
		Select ScheduleId from Schedule where TimeStamp = @Date
	END	
	ELSE
		Return -1