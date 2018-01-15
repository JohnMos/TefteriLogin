using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TefteriLoginTest.Models;

namespace TefteriLoginTest.Controllers
{
    
    public class FriendController : Controller
    {
        

        public MyDbContext Context { get; private set; }

        public FriendController()
        {
            this.Context = new MyDbContext();
        }

        public ActionResult FriendDetail()
        {
            MyDbContext myDbContext = new MyDbContext();
            List<FriendDetails> friendetails = myDbContext.FriendsDetails.ToList();
            // return the view
            return View("FriendDetails",friendetails);
        }


        public ActionResult Friends()
        {
            List<Friend> friends = this.Context.Friends.ToList();
            return View("Friends", friends);
        }

        
    }
}