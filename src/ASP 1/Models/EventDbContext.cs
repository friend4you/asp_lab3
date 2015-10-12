using ASP_1.Models.Entities;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_1.Models
{
    public class EventDbContext
    {
        public DbSet<Event> Events;
        public DbSet<Person> Persons;
    }
}
