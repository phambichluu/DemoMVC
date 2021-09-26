using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoMVC.Models;
using Microsoft.EntityFrameworkCore;


namespace DemoMVC.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Student> Student{ get; set; }

    }
}