CREATE PROCEDURE [dbo].[spInsertNewUser]
	@user_id nvarchar(128),
	@first_name nvarchar(128),
	@last_name@ nvarchar(128),
	@email_adress nvarchar(128),
	@phone_number int
AS
Begin
	Insert into [dbo].[users] ([user_id],[first_name],[last_name],[email_adress],[phone_number])
	values (@user_id,@first_name,@last_name@,@email_adress,@phone_number)
end
