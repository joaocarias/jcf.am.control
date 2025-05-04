using Jcf.AM.Control.Api.Models.Entities;
using System.Security.Claims;

namespace Jcf.AM.Control.Api.Services.IServices
{
    public interface ITokenService
    {
        ClaimsIdentity GeneratorClaims(User user);
        string NewToken(User user);
    }
}
