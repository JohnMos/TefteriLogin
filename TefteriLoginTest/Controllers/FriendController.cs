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

        public ActionResult FriendDetail(int ID)
        {
            MyDbContext myDbContext = new MyDbContext();
            FriendDetails friendetails = myDbContext.FriendsDetails.Find(ID);
            List<FriendDetails> flist = new List<FriendDetails>();
            flist.Add(friendetails);
            return View("FriendDetails",flist);

        }


        public ActionResult Friends()
        {
            List<Friend> friends = this.Context.Friends.ToList();
            return View("Friends", friends);
        }

        
    }
}