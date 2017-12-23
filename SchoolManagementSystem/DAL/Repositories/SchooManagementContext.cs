using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using SchoolManagementSystem.Models.Entities;

namespace SchoolManagementSystem.DAL.Repositories
{
    public class SchooManagementContext : DbContext
    {
        public SchooManagementContext() : base()
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Parent_Student_Link> Parent_Student_Links { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
