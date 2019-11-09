CREATE PROCEDURE [dbo].[usp_GetAllCharacterNames]
AS
	SELECT a.Name,b.Name as ClassName
	from Character a inner join  Class b on a.ClassId=b.ClassId;
