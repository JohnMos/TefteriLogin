using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TefteriLoginTest.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=cns")
        {

        }
            public DbSet<Friend> Friends { get; set; }
            public DbSet<FriendDetails> FriendsDetails { get; set; }
            }
}