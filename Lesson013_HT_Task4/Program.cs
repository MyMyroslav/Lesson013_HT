using System;

namespace Lesson013_HT_Task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Article article1 = new Article();
            article1.Name = "T-Shirt";
            article1.Shop = "Roksolana";
            article1.Price = 123.2;

            Article article2 = new Article();
            article2.Name = "Hat";
            article2.Shop = "Forum Lviv";
            article2.Price = 87.45;

            Article article3 = new Article();
            article3.Name = "Trousers";
            article3.Shop = "King Cross";
            article3.Price = 15;

            Object[] objs = new Object[3];
            Article[] articles = new Store[3];
            objs[0] = article1;
            objs[1] = article2;
            objs[2] = article3;

            Console.WriteLine("Choose article: 1, 2, 3 ");
            int articleChoosing = int.Parse(Console.ReadLine());
            switch (articleChoosing)
            {
                case 1:
                    {
                        Console.WriteLine($"Name: {article1.Name}, Shop: {article1.Shop}, Price: {article1.Price}");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($"Name: {article2.Name}, Shop: {article2.Shop}, Price: {article2.Price}");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine($"Name: {article3.Name}, Shop: {article3.Shop}, Price: {article3.Price}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Article is not available");
                        break;
                    }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Choose article by Name: T-shirt, Hat, Trousers ");
            string articleChoosingByName = Console.ReadLine();
            switch (articleChoosingByName)
            {
                case "T-shirt":
                    {
                        Console.WriteLine($"Name: {article1.Name}, Shop: {article1.Shop}, Price: {article1.Price}");
                        break;
                    }
                case "Hat":
                    {
                        Console.WriteLine($"Name: {article2.Name}, Shop: {article2.Shop}, Price: {article2.Price}");
                        break;
                    }
                case "Trousers":
                    {
                        Console.WriteLine($"Name: {article3.Name}, Shop: {article3.Shop}, Price: {article3.Price}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Article is not available");
                        break;
                    }
            }
            }
    }
}
