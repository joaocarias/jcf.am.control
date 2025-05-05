using Jcf.AM.Control.Api.Models.DTOs;
using Jcf.AM.Control.Api.Models.Entities;

namespace Jcf.AM.Control.Api.Extensions
{
    public static class UserExterions
    {
        public static UserDTO ToUserDTO(this User user)
        {
            var dto = new UserDTO
            {
                Id = user.Id,

                Name = user.Name,
                Email = user.Email,
                Role = user.Role,
                Login = user.Login,

                UserCreate = user.UserCreate,
                UserCreateId = user.UserCreateId,

                UserUpdate = user.UserUpdate,
                UserUpdateId = user.UserUpdateId,

                UpdateAt = user.UpdateAt,
                CreateAt = user.CreateAt,
                IsActive = user.IsActive
            };

            return dto;
        }
    }
}
