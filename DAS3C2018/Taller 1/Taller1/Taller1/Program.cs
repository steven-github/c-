using System;
using System.Collections.Generic;

namespace Taller1
{
    class Program
    {
        //Default publication
        static Publications publication = new Publications
        {
            Articles = new List<Article>()
            {
                new Article {
                    ID = 1,
                    Body = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",
                    PublishedDate = new DateTime().Date,
                    Author = "John Smith",
                    Comments = new List<Comment>()
                    {
                        new Comment {
                            ID = 2,
                            ArticleID = 1,
                            Body = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",
                            CommentDate = new DateTime().Date,
                            Author = "Juan Perez",
                        }

                    }
                }
            }
        };
        static User user;
        static Article article;
        static Comment comment;

        static void Main(string[] args)
        {
            int opt1;
            do
            {
                opt1 = DisplayMenu();
                switch (opt1.ToString())
                {
                    case "1":
                        //1 for Publisher
                        createUser(1);
                        System.Console.Write("\nWelcome " + user.Name + "\n");
                        int opt2;
                        do
                        {
                            opt2 = DisplayPublisherMenu();
                            switch (opt2.ToString())
                            {
                                case "1":
                                    createArticle();
                                    publication.AddArticle(article);
                                    break;
                                case "2":
                                    Console.WriteLine(publication.GetArticles());
                                    break;
                            }
                        } while (opt2 != 3);
                        break;
                    case "2":
                        //2 for Guest
                        createUser(1);
                        System.Console.Write("\nWelcome " + user.Name + "\n");
                        int opt3;
                        do
                        {
                            opt3 = DisplayGuestMenu();
                            switch (opt3.ToString())
                            {
                                case "1":
                                    createComment();
                                    break;
                                case "2":
                                    Console.WriteLine(publication.GetArticles());
                                    break;
                            }
                        } while (opt3 != 3);
                        break;
                }
            } while (opt1 != 3);
        }

        private static void createComment()
        {

            Console.Write("\nArticle id: ");
            int ArticleID = int.Parse(System.Console.ReadLine());

            if (publication.canCreateComment(ArticleID, user))
            {
                Console.Write("\nComment succesfully added!\n");
            } else {
                Console.Write("\nSelected article doesn't exist! Try again...\n");
            }
        }

        private static void createArticle()
        {

            System.Console.Write("\n1. Article Body: ");
            string Body = System.Console.ReadLine();

            article = new Article
            {
                ID = publication.Articles.Count + 1,
                Body = Body,
                PublishedDate = new DateTime().Date,
                Author = user.Name,
                Comments = null
            };

        }

        private static void createUser(int role)
        {
            System.Console.Write("\nWhat's your name: ");
            string Name = System.Console.ReadLine();
            user = new User
            {
                Name = Name,
                UserRole = role
            };
        }

        public static int DisplayMenu()
        {
            System.Console.Write("\nMenu: \n1.Publisher \n2.Guest \n3.Quit \nOption: ");

            return int.Parse(System.Console.ReadLine());
        }

        public static int DisplayGuestMenu()
        {
            System.Console.Write("\n1. New comment \n2. List publications \n3. Back \nOption: ");
            return int.Parse(System.Console.ReadLine());
        }

        public static int DisplayPublisherMenu()
        {
            System.Console.Write("\n1. New publication \n2. List publications \n3. Back \nOption: ");
            return int.Parse(System.Console.ReadLine());
        }

    }
}
