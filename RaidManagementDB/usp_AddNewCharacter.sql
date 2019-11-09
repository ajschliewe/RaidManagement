CREATE PROCEDURE [dbo].[usp_AddNewCharacter]
	@Name nvarchar(50),
	@Parent nvarchar(50),
	@Class nvarchar(15),
	@Status nvarchar(25)
AS
	Insert into Character(ParentId,Name,ClassId,StatusId) 
	Values( case When @Parent = '' Then null Else (Select CharacterId from Character where Name = @Parent) END, @Name,(Select ClassId from Class where Name=@Class)
	, (Select StatusId from Status where Name=@Status))
RETURN 0
