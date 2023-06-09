﻿using EduConnect.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduConnect.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Statistics> Statistics { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Enrolment> Enrolments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Tutor>().ToTable("Tutor");
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrolment>().ToTable("Enrolment");
            modelBuilder.Entity<Appointment>().ToTable("Appointment");
            modelBuilder.Entity<Bill>().ToTable("Bill");
            modelBuilder.Entity<Statistics>().ToTable("Statistics");
            modelBuilder.Entity<Reviews>().ToTable("Reviews");

            modelBuilder.Entity<User>().Property(e => e.Loginname);
            modelBuilder.Entity<User>().Property(e => e.Password);
            modelBuilder.Entity<User>().Property(e => e.Name);
            modelBuilder.Entity<User>().Property(e => e.Surname);
            modelBuilder.Entity<User>().Property(e => e.EmailAddress);
            modelBuilder.Entity<User>().Property(e => e.CellPhoneNumber);
            modelBuilder.Entity<User>().Property(e => e.City);


            base.OnModelCreating(modelBuilder);
        }
    }
}
