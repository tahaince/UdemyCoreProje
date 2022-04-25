using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<WrriterUser,WriterRole,int> 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-SA0L80K7;database=UdemyProjeDB;integrated security=true");

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        
        public DbSet<Experience> Experiences { get; set; }

        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Service> Services { get; set; }

        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimional> Testimionals { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserMessage> UserMessages{ get; set; }
        public DbSet<ToDoList> ToDoLists{ get; set; }
        public DbSet<Test1> Test1s { get; set; }










    }
}
