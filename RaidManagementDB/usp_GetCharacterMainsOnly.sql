CREATE PROCEDURE [dbo].[usp_GetCharacterMainsOnly]
AS
	SELECT c.Name from Character c inner join Status s on c.StatusId=s.StatusId where s.Name != 'Alt'
RETURN 0
