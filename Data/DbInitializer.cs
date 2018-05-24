using System;
using System.Linq;

using IntercityBusService.Data;
using IntercityBusService.Models;

namespace IntercityBusService.Data
{
    public static class DbInitializer
    {
        private static void InitializeUsers(DatabaseContext context)
        {
            var users = new User[]
            {
                new User
                {
                    ID = 0,
                    Name = "admin",
                    Password = "admin",
                    Role = Role.Administrator,
                },
            };
            context.AddRange(users);
            context.SaveChanges();
        }

        public static void Initialize(DatabaseContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            InitializeUsers(context);
        }
    }
}