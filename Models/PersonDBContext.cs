using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CFM.Models
{
    public class PersonDBContext : DbContext
    {
        public PersonDBContext (DbContextOptions<PersonDBContext> options)
            : base(options)
        {
        }

        public DbSet<CFM.Models.Person> Person { get; set; }
        public DbSet<CFM.Models.Address> Address { get; set; }
    }
}
