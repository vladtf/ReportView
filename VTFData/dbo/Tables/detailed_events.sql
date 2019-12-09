CREATE TABLE [dbo].[detailed_events]
(
	[event_id] int FOREIGN KEY REFERENCES [dbo].[events] (event_id) NOT NULL,
	[long_description] nvarchar(255),
	[contact_phone_number] int
)
