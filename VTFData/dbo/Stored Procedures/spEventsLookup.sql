CREATE PROCEDURE [dbo].[spEventsLookup]
	@month datetime,
	@status nvarchar(255)
AS
Begin

	set nocount on;

	SELECT e.[event_id], e.[event_name], e.[host_id], e.[short_description], c.[category_name], 
	e.[date_event], e.[price], e.[seats], e.[status], l.[location_name], l.[adress], u.first_name,u.last_name
	from [dbo].[events] as e, [dbo].[locations] as l, [dbo].[categories] as c, [dbo].users as u
	where e.location_id=l.location_id and  e.category_id=c.category_id and e.host_id=u.user_id 
	and e.[status] like @status
	and e.date_event >= EOMONTH(@month,-1)
	and e.date_event <= EOMONTH(@month)
end