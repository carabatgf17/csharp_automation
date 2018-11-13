using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Shape
    {
        internal protected void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }

    // Derived class
    class Rectangle : Shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }

    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();

            Rect.setWidth(5);
            Rect.setHeight(7);

            // Print the area of the object.
            Console.WriteLine("Total area: {0}", Rect.getArea());
            Console.ReadKey();
        }
    }

    public class Shape2
    {
        public virtual int Perimeter()
        {
            return 0;
        }
    }
    public class Rectangle2 : Shape2
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public override int Perimeter()
        {
            return (Height + Width) * 2;
        }
    }
    public class Triangle2 : Shape2
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }

        public override int Perimeter()
        {
            return Side1 + Side2 + Side3;
        }
    }

    class Parent
    {
        private int a;
        private int b;
        public Parent(int a, int b)
        {
            Console.WriteLine("I am in Parent constructor");
            Console.WriteLine("Setting the value for instance variable  a and b");
            //“this” means the current object
            this.a = a;
            this.b = b;
            Console.WriteLine("a={0}", this.a);
            Console.WriteLine("b={0}", this.b);
        }
    }
    class Child : Parent
    {
        private int c;
        public Child(int a, int b, int c) : base(a, b)
        {
            Console.WriteLine("I am in Child constructor");
            Console.WriteLine("Setting the value for instance variable c");
            this.c = c;
            Console.WriteLine("c={0}", this.c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Testing the use of base keyword. Example-1***\n\n");
            Child obChild = new Child(1, 2, 3);
            //Console.WriteLine("a in ObB2={0}", obChild.a);// a is private,
            //so Child.a is inaccessible
            Console.ReadKey();
        }
    }
}

