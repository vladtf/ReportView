CREATE TABLE [dbo].[Employees] (
    [id]         NVARCHAR (50) NOT NULL,
    [first_name] NVARCHAR (50) NOT NULL,
    [last_name]  NVARCHAR (50) NOT NULL,
    [email]      NVARCHAR (50) NOT NULL,
    [department] NVARCHAR (50) NOT NULL,
    [salary]     INT           NOT NULL,
    [hire_date]  NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Employees1] PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([department]) REFERENCES [dbo].[Departments] ([Department])
);

