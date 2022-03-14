using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnMatch.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnMatch.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Club> Clubs { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<ServerName> serverNames { get; set; }
        public DbSet<ServerLink> serverLinks { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Match>().HasOne(c => c.club1).WithMany().OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Match>().HasOne(c => c.club2).WithMany().OnDelete(DeleteBehavior.Restrict);
        }
       
    }
}
