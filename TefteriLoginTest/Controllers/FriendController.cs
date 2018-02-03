using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TefteriLoginTest.Repository;

namespace TefteriLoginTest.Controllers
{
    public class FriendController : Controller
    {
        private readonly FriendRepository friendRepository;

        public FriendController(FriendRepository friendRepository)
        {
            this.friendRepository = friendRepository;
        }

        public ActionResult FriendDetail(int ID)
        {
            return View("FriendDetails", friendRepository.getFriendDetails(ID));
        }
        
        public ActionResult Friends()
        {
            List<Models.Friend> friends = friendRepository.getAllFriends();
            return View("Friends", friends);
        }
    }
}
