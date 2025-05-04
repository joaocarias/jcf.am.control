using Jcf.AM.Control.Api.Models.Entities;

namespace Jcf.AM.Control.Api.Services.IServices
{
    public interface IAuthService
    {
        Task<User?> AuthenticateAsync(string userName, string password);
    }
}
