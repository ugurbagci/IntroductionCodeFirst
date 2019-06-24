using CodeFirstExample.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.DAL.ORM.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "Server=.;DataBase=302;UID=burak;PWD=112358;";
        }
        //BaseEntity dbset olmak zorunda değildir...

            //DbSet sınıfı create,update,read ve delete işlemlerinde kullanılan entity setlerini temsil eder...
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        /*
         1.Nuget Package Manager ile Entity Framework projeye eklenir.
         2.DAL(Data Access Layer) klasörü içeriisnde ORM onun içine Entity ve Context kalsörü açılır.
         3.Entity klasörü altına tablo olacak class'lar yazılır.
         4.Context klasörü altına ProjectContext class'ı açılır.
         5.Project Context Class'ı DbContext'den miras alır. (System.Data.Entity)
         6.Tablo olmasını istediğimiz class'lar public DBSet<> Entities {get; set;} formatında yazılır.
         7.Nuget Console açılarak "enable-migrations yada enableautomaticmigrations" yazılır. Eğer enableautomaticmigrations yapmazsanız migrations sonrasında açılan configuration classında "false" kısmını "true" yapınız.
         8.Açık olan console ekranında "update-database" işemini yapınız

         */
    }
}
