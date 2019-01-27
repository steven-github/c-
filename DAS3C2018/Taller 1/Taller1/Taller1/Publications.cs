using System;
using System.Collections.Generic;
using System.Text;

namespace Taller1
{
    public class Publications
    {
        public Comment comment;

        public List<Article> Articles { get; set; }

        public string GetArticles()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var article in Articles)
            {
                if (article.ID != 0)
                {
                    stringBuilder.AppendLine();
                    stringBuilder.Append("Publicación el " + article.PublishedDate.ToShortDateString());
                    stringBuilder.AppendLine();
                    stringBuilder.Append(article.Body);
                    stringBuilder.AppendLine();
                    stringBuilder.Append("Por: " + article.Author);
                    stringBuilder.AppendLine();

                    if (article.Comments != null)
                    {
                        stringBuilder.Append("--------------------------");
                        foreach (var comment in article.Comments)
                        {
                            if (comment.ArticleID == article.ID)
                            {
                                stringBuilder.AppendLine();
                                stringBuilder.Append("--- Comentario el " + comment.CommentDate.ToShortDateString());
                                stringBuilder.AppendLine();
                                stringBuilder.Append("--- " + comment.Body);
                                stringBuilder.AppendLine();
                                stringBuilder.Append("--- Por: Invitado " + comment.Author);
                            }
                        }
                        stringBuilder.AppendLine();
                        stringBuilder.Append("--------------------------");
                    }

                }
                stringBuilder.AppendLine();
            }

            return stringBuilder.ToString();

        }

        public Article GetArticleBtID(int id)
        {
            foreach (var art in Articles)
            {
                if (art.ID == id)
                {
                    return art;
                }
            }

            return null;
        }

        public void AddArticle(Article art)
        {
            Articles.Add(art);
        }

        public bool canCreateComment(int id, User user)
        {
            bool isCreated = false;

            Article selectedArticle = GetArticleBtID(id);

            if (selectedArticle != null)
            {

                Console.Write("\nYour comment: ");
                string Body = System.Console.ReadLine();

                comment = new Comment
                {
                    ID = (selectedArticle.Comments != null) ? selectedArticle.Comments.Count + 1 : 1,
                    ArticleID = id,
                    Body = Body,
                    CommentDate = new DateTime().Date,
                    Author = user.Name
                };

                foreach (var article in Articles)
                {
                    if (article.ID == id)
                    {
                        if (article.Comments == null)
                        {
                            article.Comments = new List<Comment>() {
                            comment
                        };
                        }
                        else
                        {
                            article.Comments.Add(comment);
                        }

                        isCreated = true;

                    }
                }
            }

            return isCreated;

        }

        public void AddComment(int articleID, Comment comment)
        {
            foreach (var article in Articles)
            {
                if (article.ID == articleID)
                {
                    if (article.Comments == null)
                    {
                        article.Comments = new List<Comment>() {
                            comment
                        };
                    }  else {
                        article.Comments.Add(comment);
                    }
                }
            }
        }
    }
}
