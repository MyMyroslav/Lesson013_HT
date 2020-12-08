using System;
namespace Lesson013_HT_Task4
{
    public class Store : Article
    {
        private Article[] _articles;
        public Article this[int index]
        {
            get { return _articles[index]; }
            set { _articles[index] = value; }
        }
    }
}