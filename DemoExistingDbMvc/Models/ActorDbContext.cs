﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DemoExistingDbMvc.Models
{
    public partial class ActorDbContext : DbContext
    {
        public virtual DbSet<Actors> Actors { get; set; }

        public ActorDbContext(DbContextOptions<ActorDbContext> options) : base(options)
        {
            // do nothing
        }

        // Replaced with a constructor
//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ActorDb;Trusted_Connection=True;");
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}