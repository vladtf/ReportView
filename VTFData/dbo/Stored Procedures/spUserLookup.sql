CREATE PROCEDURE [dbo].[spUserLookup]
	@user_id nvarchar(128)
AS
Begin

	set nocount on;

	SELECT [user_id],[first_name],[last_name],[email_adress],[phone_number],[verfied_status],[created_at]
	from [dbo].[users]
	where user_id=@user_id;
end
