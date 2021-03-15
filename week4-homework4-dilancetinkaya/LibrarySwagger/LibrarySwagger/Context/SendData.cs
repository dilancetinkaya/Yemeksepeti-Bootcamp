using LibrarySwagger.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySwagger.Context
{
    public class SendData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LibraryDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<LibraryDbContext>>()))
            {
                if (context.Library.Any() && context.Books.Any())
                {
                    return;
                }

                context.Library.Add(new LibraryInfo
                {
                    Id = 1,
                    Title = "library",

                    Email = "library@gmail.com",
                    WebSite = "www.library.com"

                });
                context.Books.Add(new BooksInfo
                {
                    Id = 2,
                    Page = 628,
                    Name = "Suc ve Ceza",
                    Writer = "Fyodor Dostoyevski"

                });
                context.SaveChanges();
            }

        }
    }
}
