CREATE PROCEDURE [dbo].[spInsertNewUser]
	@Id nvarchar(128),
	@FirstName nvarchar(128),
	@LastName nvarchar(128),
	@EmailAdress nvarchar(128)
AS
Begin
	Insert into [dbo].[User] (Id,FirstName,LastName,EmailAdress)
	values (@Id,@FirstName,@LastName,@EmailAdress)
end
