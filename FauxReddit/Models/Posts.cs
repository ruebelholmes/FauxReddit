using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FauxReddit.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PostTime { get; set; }
        public int UpVotes { get; set; }
        public int DownVotes { get; set; }
        public string PicURL { get; set; }
        public string Body { get; set; }

        public virtual List<Comment> Comments { get; set; } = new List<Comment>();
    }
}