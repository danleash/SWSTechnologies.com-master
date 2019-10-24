 using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using SWSTechnologies1.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using SWSTechnologies1.Models;

namespace SWSTechnologies1.Models
{
    public class SWSTechDBContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        

        public SWSTechDBContext(DbContextOptions<SWSTechDBContext> options)
            : base(options)
        {
        }
        public virtual DbSet<ApplicationUser> AspNetUsers { get; set; }
        public  virtual DbSet<ContactClientModel> ClientContactInfo { get; set; }
        public virtual DbSet<TestimonyModel> Testimonials { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ContactClientModel>(entity =>
            {
                entity.Property(e => e.EmailAddress).IsRequired();

                entity.Property(e => e.Message).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50);

            });
            modelBuilder.Entity<TestimonyModel>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Message).IsRequired();

                entity.Property(e => e.Company).IsRequired();

            });
            //modelBuilder.Entity<ApplicationUser>(entity =>
            //{
            //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
            //    entity.Property(e => e.Email).IsRequired();
            //    entity.Property(e => e.EmailConfirmed).IsRequired();
            //    entity.Property(e => e.PasswordHash).IsRequired();

            //});
            ////modelBuilder.Entity<SignUpModel>(entity =>
            ////{
            ////    entity.Property(e => e.EmployeeId).IsRequired();

            ////    entity.Property(e => e.FirstName).IsRequired();

            ////    entity.Property(e => e.LastName).IsRequired();

            ////    entity.Property(e => e.EmailAddress).IsRequired();
            ////});
        }

        public DbSet<SWSTechnologies1.Models.RegisterViewModel> RegisterViewModel { get; set; }


    }
}
