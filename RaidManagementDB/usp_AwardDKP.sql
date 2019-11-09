CREATE PROCEDURE [dbo].[usp_AwardDKP]
	@Name nvarchar(50),
	@RaidId int,
	@Amount smallint,
	@Description nvarchar(50),
	@SchedId int NULL
AS
	Insert into Ledger(CharacterId,RaidId,ScheduleId,Description,Amount,CreatedOn,ModifiedOn) 
	values((Select CharacterId from Character where Name=@Name),@RaidId,@SchedId,@Description,@Amount,SYSDATETIME(),SYSDATETIME())
RETURN 0
