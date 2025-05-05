using Jcf.AM.Control.Api.Extensions.Constants;
using Jcf.AM.Control.Api.Extensions.Uties;
using Jcf.AM.Control.Api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Jcf.AM.Control.Api.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                    new User
                    (
                        Guid.Parse("08dbd59a-2683-4c67-8e16-689ba2648545"),
                        "Administrador Usuário",
                        "admin@email.com",
                        PasswordUtil.CreateHashMD5("10203040"),
                        "admin@email.com",                        
                        RolesConstants.ADMIN,
                        null
                    ),
                    new User
                    (
                        Guid.Parse("08dbdc08-56e1-4e90-805f-db29361e075e"),
                        "Básico Usuário",
                        "basico@email.com",                        
                        PasswordUtil.CreateHashMD5("10203040"),
                        "basico@email.com",
                        RolesConstants.BASIC,
                        null
                    )
                );
        }
    }
}
