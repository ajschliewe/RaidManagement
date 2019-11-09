CREATE PROCEDURE [dbo].[usp_AddNewAttendance]
	@Name nvarchar(50),
	@SchedID int
AS
	Insert into Attendance values((Select CharacterId from Character where Name=@Name),@SchedID)
RETURN 0
