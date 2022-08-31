using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034"); //Creo libro 1
            Book book2 = new Book("Pro C#","Troelsen","001-035"); //Libro 2
            //Console.WriteLine(book1); //Pequeño check para probar el ToString y que no devuelva SRP.Book
            Shelve shelve1 = new Shelve("A","1"); //Creo mi repisa
            shelve1.AddBook(book1); //Agrego mi libro1 y 2 a la repisa
            shelve1.AddBook(book2);
            Console.WriteLine(shelve1); //Printeo mi shelve1 para ver su información, osea lo que tengo adentro
            shelve1.DelBook(book2);
            Console.WriteLine(shelve1);
        }
    }
}