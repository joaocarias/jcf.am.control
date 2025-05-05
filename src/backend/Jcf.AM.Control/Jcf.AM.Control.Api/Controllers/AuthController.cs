using Jcf.AM.Control.Api.Extensions;
using Jcf.AM.Control.Api.Extensions.Constants;
using Jcf.AM.Control.Api.Extensions.Uties;
using Jcf.AM.Control.Api.Models.Records;
using Jcf.AM.Control.Api.Models.Responses;
using Jcf.AM.Control.Api.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Jcf.AM.Control.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : AppControllerBase
    {
        private readonly ILogger<AuthController> _logger;
        private readonly IAuthService _authService;        
        private readonly ITokenService _tokenService;

        public AuthController(ILogger<AuthController> logger, IAuthService authService, ITokenService tokenService)
        {
            _logger = logger;
            _authService = authService;
            _tokenService = tokenService;
        }

        [HttpPost("Login"), AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] Login login)
        {
            var response = new ApiResponse();
            try
            {
                var user = await _authService.AuthenticateAsync(login.username, PasswordUtil.CreateHashMD5(login.password));
                if (user == null)
                {
                    response.IsBadRequest(ApiResponseConstants.INVALID_LOGIN);
                    return BadRequest(response);
                }

                response.Result = new LoginResponse(true, user.ToUserDTO(), _tokenService.NewToken(user), ApiResponseConstants.SUCCESS);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError($"[{nameof(AuthController)} - {nameof(Login)}] | {ex.Message}");
                response.IsBadRequest(ex.Message);
                return BadRequest(response);
            }
        }
    }
}
