CREATE TABLE [dbo].[preferences]
(
  [user_id] nvarchar(255) FOREIGN KEY REFERENCES [dbo].[users] (user_id),
  [preferenced_event_id] int FOREIGN KEY REFERENCES [dbo].[events] (event_id)
)
