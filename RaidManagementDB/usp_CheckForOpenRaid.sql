CREATE PROCEDURE [dbo].[usp_CheckForOpenRaid]	
AS
	IF(SELECT count(RaidId) from Raid where CloseTime is null) > 0
		Select 1
	Else Select 0;
