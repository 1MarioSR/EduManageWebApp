﻿using EduManage.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EduManage.Web.Data
{
    public class EduManageDbContext : DbContext
    {
        public EduManageDbContext()
        {
        }

        public EduManageDbContext(DbContextOptions<EduManageDbContext> options): base(options)
        {
        }
         
        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
    } 
    
}