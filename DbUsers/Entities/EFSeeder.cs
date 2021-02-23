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
            SeedCategory(context);
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
        private static void SeedCategory(EFContext context)
        {
            if (context.Categories.Count() == 0)
            {
                string urlSlug = "avtotovari";
                AddParent(context, urlSlug, "Все для автомобіля");
                AddChildToParent(context, urlSlug, "avtomagnitoli", "Автомагнітоли");
                AddChildToParent(context, urlSlug, "videoregistratori", "Відеореєстратори");
                AddChildToParent(context, urlSlug, "gps-trekeri", "GPS-трекери");

                urlSlug = "bitovaya_tehnika";
                AddParent(context, urlSlug, "Побутова техніка");
                AddChildToParent(context, urlSlug, "klimaticheskaye_tehnika", "кліматична техніка");
                AddChildToParent(context, urlSlug, "tehnika_dlya_kuhni", "Техніка для кухні");

                urlSlug = "klimaticheskaye_tehnika";
                AddChildToParent(context, urlSlug, "konditsioneri", "Кондиціонери");
                AddChildToParent(context, urlSlug, "obigrivachi", "Обігрівачі");

            }
        }

        private static void AddParent(EFContext context, string urlSlug, string name)
        {
            context.Categories.Add(new Category
            {
                Name = name,
                ParentId = null,
                UrlSlug = urlSlug
            });
            context.SaveChanges();
        }

        private static void AddChildToParent(EFContext context, string parentSlug, string urlSlug, string name)
        {
            var parent = context.Categories.SingleOrDefault(x => x.UrlSlug == parentSlug);
            context.Categories.Add(new Category
            {
                Name = name,
                ParentId = parent.Id,
                UrlSlug = urlSlug
            });
            context.SaveChanges();
        }
    }
}
