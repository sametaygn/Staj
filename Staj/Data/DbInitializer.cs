using Staj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Staj.Data
{
    public class DbInitializer
    {
        public static void Initialize(Context context)
        {
            context.Database.EnsureCreated();
            if (context.Users.Any())
            {
                return;
            }
            var users = new User[]
            {
                new User{Name="Samet",Surname="Aygün",Email="samet_aygn@hotmail.com",Password="2317796",RePassword="2317796"},
                new User{Name="Serdar",Surname="Aygün",Email="serdar_aygn@hotmail.com",Password="2317796",RePassword="2317796"}
            };
            foreach (var user in users)
            {
                context.Users.Add(user);
            }
            context.SaveChanges();
        }
    }
}
