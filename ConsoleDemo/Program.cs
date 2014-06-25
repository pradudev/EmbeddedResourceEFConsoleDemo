using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLib;
using System.Data.Entity;
using System.Reflection;
using System.IO;
using System.Xml;


namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           //Database.SetInitializer(new DropCreateDatabaseAlways<PersonDBContext>());
            
            
            var conn = ResourceManager.ConnectionString;

            //Insert Some data
            using (var db = new PersonDBContext(conn))
            {
                db.Persons.Add(new Person { Id=1, Name="Foo" });
                db.Persons.Add(new Person { Id = 2, Name = "Bar" });
                db.SaveChanges();
            }
            
            
            //Read data
            using (var db = new PersonDBContext(conn))
            {
                var persons = db.Persons;

                foreach (var item in persons)
                {
                    Console.WriteLine("{0} - {1}",item.Id, item.Name);
                }
            }
            
        }
    }
}
