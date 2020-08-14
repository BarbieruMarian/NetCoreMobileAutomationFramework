using AppiumFramework.Utilities;
using System.Collections.Generic;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Flutters.Database.Models
{
    public class User : Firebase
    {
        public List<User> Users { get; set; }
        public string UserId { get; set; }
        public int Counter { get; set; }
        public string ImageURL { get; set; }
        public string Search { get; set; }
        public string Status { get; set; }
        public string Typing { get; set; }
        public string Username { get; set; }

        public void GetUsers()
        {
            FirebaseClient = new FireSharp.FirebaseClient(Config());
            if (FirebaseClient != null)
            {
                var response = FirebaseClient.Get("Users/");
            }
        }
    }
}
