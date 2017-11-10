using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class AbstractClassExample
    {
        static void Main(string[] args)
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }

    abstract class Book
    {
        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            //Console.WriteLine("Base contructor is called");
            title = t;
            author = a;
        }
        public abstract void display();
    }

    class MyBook : Book
    {
        private int price;

        public MyBook(string t, string a, int price) : base(t, a)
        {
            //Console.WriteLine("derived constructor is called");
            this.price = price;
        }

        public override void display()
        {
            Console.Write("Title: {0}\nAuthor: {1}\nPrice: {2}\n", this.title, this.author, this.price);
        }
    }
}
