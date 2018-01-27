using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TefteriLoginTest.Repository;
using TefteriLoginTest.Models;

namespace TefteriLoginTest.Controllers
{
    public class GroupController : Controller
    {
        private readonly FriendRepository friendRepository;

        public GroupController(FriendRepository friendRepository)
        {
            this.friendRepository = friendRepository;
        }

        // GET: Group
        public ActionResult CreateGroup()
        {
            List<Friend> friends = friendRepository.getAllFriends();
            return View("CreateGroup", friends);
        }

        public ActionResult EditGroup()
        {
            return View("EditGroup");
        }
    }
}