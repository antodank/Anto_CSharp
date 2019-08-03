using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTypesApplication
{
    public class Product
    {
        public decimal Price { get; set; }
    }

    struct Books
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;
    };

    public struct Point
    {
        public int len, bdth;
        public double area;
        public Point(int p1, int p2)
        {
            len = p1;
            bdth = p2;
            area = len * bdth;
        }
    }

    public static class MyExtensions
    {
        public static decimal Discount(this Product product)
        {
            return product.Price * .9M;
        }
    }

    public class Calculator
    {
        public decimal CalculateDiscount(Product p)
        {
            return p.Discount();
        }
    }
}
