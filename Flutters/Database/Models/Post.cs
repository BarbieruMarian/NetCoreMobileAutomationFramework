using AppiumFramework.Utilities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Flutters.Database.Models
{
    public class Post : FirebaseExtension
    {
        public List<Post> Posts;
        public int PostCount { get; set; }
        public static string PostId { get; set; }
        public string PDown { get; set; }
        public string PId { get; set; }
        public string PImage { get; set; }
        public string PTime { get; set; }
        public string PTitle { get; set; }
        public string Recievers1 { get; set; }
        public string Recievers2 { get; set; }
        public string Recievers3 { get; set; }
        public string Recievers4 { get; set; }
        public string Recievers5 { get; set; }
        public string UDp { get; set; }
        public string UEmail { get; set; }
        public string UName { get; set; }
        public string UId { get; set; }
    }
}
