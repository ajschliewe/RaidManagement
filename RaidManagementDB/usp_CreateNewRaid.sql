CREATE PROCEDURE [dbo].[usp_CreateNewRaid]
	@Description nvarchar(50)
AS
	Insert into Raid(Description,StartTime) Values(@Description,Convert(datetime2(0),SysDatetime()))
RETURN 0
