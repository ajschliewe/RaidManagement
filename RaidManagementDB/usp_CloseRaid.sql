CREATE PROCEDURE [dbo].[usp_CloseRaid]
	@param1 int
AS
	Update Raid
	set CloseTime = SYSDATETIME()
	where RaidId = @param1
RETURN 0
