using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbUsers.Entities
{
    public static class EFSeeder
    {
        public static void SeedDatabase(EFContext context)
        {
            SeedRole(context);
            SeedUser(context);
            SeedUserRole(context);
        }

        private static void SeedRole(EFContext context)
        {
            if(context.Roles.Count() == 0)
            {
                context.Roles
                    .Add(new Role { 
                        Name = "Gamlet ",
                        NormalizedName = " Принц Йоркський",
                        ConcurrencyStamp = "ConcurrencyStamp - шо це?"
                    });
                context.SaveChanges();
            }

        }
        private static void SeedUser(EFContext context)
        {
            if(context. Users.Count() == 0)
            {
                context.Users
                    .Add(new User { 
                    UserName = "Павло",
                    NormalizedUserName = "Зелений",
                    Email = "pavlozelenuy@gmail.com",
                    PasswordHash = "123"
                    });
                context.SaveChanges();
            }
        }

        private static void SeedUserRole(EFContext context)
        {
            if(context.UserRoles.Count() == 0)
            {
                context.UserRoles
                    .Add(new UserRole
                    {
                        UserId = 1,
                        RoleId = 1
                    });
                context.SaveChanges();
            }
        }
    }
}
