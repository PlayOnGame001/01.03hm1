using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03hm1
{
    #region face
    interface IPlay
    {
        void EnterPlay();
        void PrintPlay();
    }
    interface IShop
    {
        void EnterShop();
        void PrintShop();
    }
    #endregion
    class Play : IPlay, IDisposable
    {
        private string name;
        private string Fulname;
        private string gen;
        private int year;
        public Play() { }
        public Play(string name, string fulname, string gen, int year)
        {
            this.name = name;
            Fulname = fulname;
            this.gen = gen;
            this.year = year;
        }
        public void EnterPlay()
        {
            Console.Write("Enter name game: ");
            name = Console.ReadLine();
            Console.Write("Enter full name: ");
            Fulname = Console.ReadLine();
            Console.Write("Enter playes genre: ");
            gen = Console.ReadLine();
            Console.Write("Enter year of issue: ");
            year = Console.Read();
        }
        public void PrintPlay()
        {
            Console.WriteLine($"Name game: {name}");
            Console.WriteLine($"Full name: {Fulname}");
            Console.WriteLine($"Playes genre: {gen}");
            Console.WriteLine($"Year of issue: {year}");
        }
        public void Dispose()
        {
            Console.WriteLine("Object has been deleted by Dispose!");
        }
        ~Play()
        {
            Console.WriteLine("\nObject has been deleted");
            Console.Beep();
        }
    }

    class Shop : IShop, IDisposable
    {
        private string name;
        private string adress;
        public Shop() { }
        public Shop(string name, string adress)
        {
            this.name = name;
            this.adress = adress;
        }
        public void EnterShop()
        {
            Console.Write("Enter shop's name: ");
            name = Console.ReadLine();
            Console.Write("Enter shop's adress: ");
            adress = Console.ReadLine();
        }
        public void PrintShop()
        {
            Console.WriteLine($"Shop's name: {name}");
            Console.WriteLine($"Shop's adress: {adress}");
        }
        public void Dispose()
        {
            Console.WriteLine("Object has been deleted");
            Console.Beep();
        }
        ~Shop()
        {
            Console.WriteLine("Object has been delete by Destructor!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            shop.EnterShop();
            shop.PrintShop();
            shop.Dispose();
        }
    }
}