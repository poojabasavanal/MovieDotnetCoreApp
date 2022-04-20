using Microsoft.EntityFrameworkCore;
using MovieCoreApp.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCoreApp.DAL.Data
{
    public class MovieDbContext:DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {

        }
        public DbSet<Movie> movie { get; set; }

        public DbSet<MovieShowTimings> movieShowTimings { get; set; }
        public DbSet<UserInfo> userInfo { get; set; }
    }
}
