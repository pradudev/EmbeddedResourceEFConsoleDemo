using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLib
{
    public class PersonDBContext : DbContext
    {
        public PersonDBContext(string conn) : base(conn)
        {

        }

        public DbSet<Person> Persons { get; set; }

    }
}
