using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nistor_Anamaria_Lab2.Models;

namespace Nistor_Anamaria_Lab2.Data
{
    public class Nistor_Anamaria_Lab2Context : DbContext
    {
        public Nistor_Anamaria_Lab2Context (DbContextOptions<Nistor_Anamaria_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Nistor_Anamaria_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Nistor_Anamaria_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Nistor_Anamaria_Lab2.Models.Author>? Authors { get; set; }
    }
}
