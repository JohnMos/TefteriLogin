using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TefteriLoginTest.Models;

namespace TefteriLoginTest.Repository
{
    public interface FriendRepository
    {
        List<Friend> getAllFriends();

        List<FriendDetails> getFriendDetails();
    }
}
