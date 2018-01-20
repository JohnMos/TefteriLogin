namespace TefteriLoginTest.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TefteriLoginTest.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<TefteriLoginTest.Models.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        public string Name { get; private set; }

        protected override void Seed(TefteriLoginTest.Models.MyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Friends.Add(new Models.Friend() {ID = 1, Name = "Ioannis Moscholios" });
            context.Friends.Add(new Models.Friend() {ID = 2, Name = "Stathis Chrysikos" });
            context.Friends.Add(new Models.Friend() {ID = 3, Name = "George Prokopakis" });
            context.FriendsDetails.Add(new Models.FriendDetails() {ID=1, Name = "Ioannis", Gender = "Male" , City = "Piraeus" });
            context.FriendsDetails.Add(new Models.FriendDetails() {ID=2, Name = "Stathis", Gender = "Male", City = "N.Philadelphia" });
            context.FriendsDetails.Add(new Models.FriendDetails() {ID=3, Name = "George", Gender = "Male", City = "N.Ionia" });
            context.SaveChanges();
        }
    }
}
