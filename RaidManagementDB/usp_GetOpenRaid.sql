CREATE PROCEDURE [dbo].[usp_GetOpenRaid]
AS
	SELECT RaidId,[Description],StartTime from Raid where CloseTime is null;
