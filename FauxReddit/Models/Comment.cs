using System;
using System.Collections.Generic;

namespace FauxReddit.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public DateTime PostTime { get; set; }
        public string Body { get; set; }
        public int UpVotes { get; set; }
        public int DownVotes { get; set; }

        public virtual List< Comment> SubComments { get; set; } = new List<Comment>();
        public virtual Post Post { get; set; }
        public virtual Comment ParentComment { get; set; }

    }
}
