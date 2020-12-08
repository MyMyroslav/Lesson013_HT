using System;
namespace Lesson013_HT_Task4
{
    public class Article 
    {
        private string name;
        private string shop;
        private double price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Shop
        {
            get { return shop; }
            set { shop = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
