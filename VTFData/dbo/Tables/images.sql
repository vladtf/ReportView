CREATE TABLE [dbo].[images]
(
  [image] IMAGE,
  [linked_event_id] int FOREIGN KEY REFERENCES [dbo].[events] (event_id)
)
