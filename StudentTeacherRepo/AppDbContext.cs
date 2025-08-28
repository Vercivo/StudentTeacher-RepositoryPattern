﻿using Microsoft.EntityFrameworkCore;
namespace StudentTeacherRepo
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
