using System;
using System.Collections.Generic;
using System.Text;

namespace Flutters.Database.Models
{
    public class Dislike
    {
        public List<Dislike> Dislikes;
        public string PostId { get; set; }
        public string UserId { get; set; }
    }
}
