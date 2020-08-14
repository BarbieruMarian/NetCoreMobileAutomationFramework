using System;
using System.Collections.Generic;
using System.Text;

namespace Flutters.Database.Models
{
    public class Like
    {
        public List<Like> Likes;
        public string PostId { get; set; }
        public string UserId { get; set; }
    }
}
