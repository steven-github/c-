using System;
using System.Collections.Generic;
using System.Text;

namespace Taller1
{
    public class Article
    {
        public int ID { get; set; }
        public string Body { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Author { get; set; }
        public List<Comment> Comments { get; set; }

        public Comment GetComments(int id)
        {
            foreach (var comment in Comments)
            {
                if (comment.ID == id)
                {
                    return comment;
                }
            }

            return null;

        }


    }
}
