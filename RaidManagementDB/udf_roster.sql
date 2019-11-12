CREATE FUNCTION [dbo].[udf_roster]
(
	
)
RETURNS @returntable TABLE
(
	c1 nvarchar(50),
	c2 int,
	c3 decimal(8,4),
	c4 decimal(8,4),
	c5 decimal(8,4)
)
AS
BEGIN
Declare @30cnt decimal(8,4);
declare @60cnt decimal(8,4);
declare @90cnt decimal(8,4);

set @30cnt = (Select count(ScheduleId) from Schedule s inner join Raid r on s.RaidId=r.RaidId where r.CloseTime is not null and s.TimeStamp > DATEADD(day,-30,SYSDATETIME()));
set @60cnt = (Select count(ScheduleId) from Schedule s inner join Raid r on s.RaidId=r.RaidId where r.CloseTime is not null and s.TimeStamp > DATEADD(day,-60,SYSDATETIME()));
set @90cnt = (Select count(ScheduleId) from Schedule s inner join Raid r on s.RaidId=r.RaidId where r.CloseTime is not null and s.TimeStamp > DATEADD(day,-90,SYSDATETIME()));

with x as (Select c.Name, convert(decimal(8,4),count(*)/@30cnt) as pcnt30
from Attendance a inner join Schedule s on a.ScheduleId=s.ScheduleId inner join Raid r on s.RaidId=r.RaidId inner join Character c on a.CharacterId=c.CharacterId
where r.CloseTime is not null and s.TimeStamp > DATEADD(day,-30,SYSDATETIME())
group by c.Name), y as (Select c.Name, convert(decimal(8,4),count(*)/@60cnt) as pcnt60
from Attendance a inner join Schedule s on a.ScheduleId=s.ScheduleId inner join Raid r on s.RaidId=r.RaidId inner join Character c on a.CharacterId=c.CharacterId
where r.CloseTime is not null and s.TimeStamp > DATEADD(day,-60,SYSDATETIME())
group by c.Name), z as (Select c.Name, convert(decimal(8,4),count(*)/@90cnt) as pcnt90
from Attendance a inner join Schedule s on a.ScheduleId=s.ScheduleId inner join Raid r on s.RaidId=r.RaidId inner join Character c on a.CharacterId=c.CharacterId
where r.CloseTime is not null and s.TimeStamp > DATEADD(day,-90,SYSDATETIME())
group by c.Name), currentdkp as (Select Characterid, sum(l.amount) as dkp
from Ledger l inner join Raid r on l.raidID=r.raidid
where r.closeTime is not null or (r.closetime is null and l.amount< 0)
group by characterid)
INSERT INTO @returntable
Select c.Name,dkp, isnull(x.pcnt30,0) as pcnt30, isnull(y.pcnt60,0) as pcnt60, isnull(z.pcnt90,0) as pcnt90
from Character c left outer join x on c.Name=x.Name left outer join y on c.Name=y.Name left outer join z on c.Name=z.Name left outer join currentdkp on c.CharacterId=currentdkp.CharacterId
where c.StatusId < 4
order by c.Name	
		
	RETURN
END
