CREATE TABLE [dbo].[events]
(
  [event_id] int NOT NULL PRIMARY KEY,
  [event_name] nvarchar(255) NOT NULL,
  [host_id] nvarchar(255) FOREIGN KEY REFERENCES [dbo].[users](user_id) NOT NULL,
  [short_description] nvarchar(255),
  [category_id] int FOREIGN KEY REFERENCES [dbo].[categories](category_id) NOT NULL,
  [date_event] datetime NOT NULL,
  [time_event] datetime NOT NULL,
  [price] int NOT NULL,
  [seats] int NOT NULL,
  [status] nvarchar(255),
  [location_id] int FOREIGN KEY REFERENCES [dbo].[locations](location_id)
)
