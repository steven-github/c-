using System;
using System.Collections.Generic;
using System.Text;

namespace Taller1
{
    public class Comment
    {
        public int ID { get; set; }
        public int ArticleID { get; set; }
        public string Body { get; set; }
        public DateTime CommentDate { get; set; }
        public string Author { get; set; }
    }
}
