using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TefteriLoginTest.Models;

namespace TefteriLoginTest.Repository
{
    /// <summary>
    /// A Mock up repository because Anthony was too lazy to install SQL Server :)
    /// </summary>
    public class MockFriendRepository : FriendRepository
    {
        public List<Friend> getAllFriends()
        {
            return new List<Friend>()
            {
                new Friend() { ID = 1, Name = "John" },
                new Friend() { ID = 2, Name = "Anthony" }
            };
        }

        public List<FriendDetails> getFriendDetails()
        {
            return new List<FriendDetails>()
            {
                new FriendDetails() { ID = 1, City = "Athens", Gender = "Male", Name = "John" },
                new FriendDetails() { ID = 2, City = "Athens", Gender = "Male", Name = "Anthony" },
            };
        }
    }
}