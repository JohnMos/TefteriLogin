using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TefteriLoginTest.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base(@"Data Source=localhost\sqlexpress;Initial Catalog=Tefteri;Persist Security Info=True;User ID=sa;Password=Mosxolios!@#$56")
        {

        }
            public DbSet<Friend> Friends { get; set; }
            public DbSet<FriendDetails> FriendsDetails { get; set; }
            }
}