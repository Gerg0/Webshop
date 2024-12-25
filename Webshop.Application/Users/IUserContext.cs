namespace Webshop.Application.Users;

public interface IUserContext
{
    CurrentUser? GetCurrentUser();
}