using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EfAddressBook.Models
{
    public class AddressBookContext : DbContext
    {
        public AddressBookContext()
        {
            Database.EnsureCreated(); //means create if database does not exist 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDb; Database=AdressBookEFDb; Trusted_Connection=True");
        }

        public DbSet<Person> Persons { get; set; }

    }
}
