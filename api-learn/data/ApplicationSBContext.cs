using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_learn.models;
using Microsoft.EntityFrameworkCore;

namespace api_learn.data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Stock> Stocks { get; set; }

        public DbSet<Comment> Comments { get; set; }

    }
}