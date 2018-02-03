using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TefteriLoginTest.Models;

namespace TefteriLoginTest.Repository
{
    public class SQLFriendRepository : FriendRepository
    {
        private readonly MyDbContext dbContext = new MyDbContext();
        
        public List<Friend> getAllFriends()
        {
            return dbContext.Friends.ToList();
        }

        public List<FriendDetails> getFriendDetails(int id)
        {
            return new List<FriendDetails>() { dbContext.FriendsDetails.Find(id) };
        }
    }
}