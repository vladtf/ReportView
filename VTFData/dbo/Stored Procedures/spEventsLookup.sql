CREATE PROCEDURE [dbo].[spEventsLookup]
	@month datetime,
	@status varchar
AS
Begin

	set nocount on;

	SELECT e.event_id, e.[event_name], e.[host_id], e.[short_description], c.[category_name], e.[date_event], 
	e.[time_event], e.[price], e.[seats], e.[status], l.[location_name], l.[location_name]
	from [dbo].[events] as e, [dbo].[locations] as l, [dbo].[categories] as c 
	where date_event >= DATEADD(mm, DATEDIFF(mm, 0, @month), 0)
	and date_event <=  DATEADD (dd, -1, DATEADD(mm, DATEDIFF(mm, 0, @month) + 1, 0))
	and date_event >= DATEADD(yy, DATEDIFF(yy, 0, GETDATE()), 0)
	and e.location_id=l.location_id and  e.category_id=c.category_id
	and e.[status] = @status;
end
