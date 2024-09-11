using JWT_Auth_Web_API.Models;

namespace JWT_Auth_Web_API.Services;

public interface IUserService
{
    string Login(User user);
}
