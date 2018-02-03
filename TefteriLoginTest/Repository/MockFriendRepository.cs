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
        private readonly List<Friend> friends = new List<Friend>()
        {
            new Friend() { ID = 1, Name = "John" },
            new Friend() { ID = 2, Name = "Anthony" }
        };

        private readonly List<FriendDetails> friendDetails = new List<FriendDetails>()
        {
            new FriendDetails() { ID = 1, Name = "John", City = "Athens", Gender = "Male" },
            new FriendDetails() { ID = 2, Name = "Anthony", City = "Athens", Gender = "Male" }
        };

        public List<Friend> getAllFriends()
        {
            return friends;
        }

        public List<FriendDetails> getFriendDetails(int id)
        {
            return new List<FriendDetails>()
            {
                friendDetails.Find(f => f.ID == id)
            };
        }
    }
}