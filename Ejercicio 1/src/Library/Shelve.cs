using System;
using System.Collections.Generic; //Para que me permita usar listas de objetos sin que me muestre error.

namespace SRP
{
    public class Shelve
        {
            public string LibrarySector{get; set;}
            public string LibraryShelve{get; set;}
            List<Book> ListaBook = new List<Book>(); //Creo una lista de objetos Book para guardar los n libros en mi repisa

            public Shelve(String sector, String shelve) //Cuando creo mi repisa la misma está vacía, por lo que no pongo la lista como parámetro
            {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
            }
            public void AddBook(Book book1) //Creo un método para agregar libros a mi repisa
            {
                this.ListaBook.Add(book1);
            }
            public void DelBook(Book book1)// Método para tirar los libros afuera de mi repisa
            {
                this.ListaBook.Remove(book1);
            }
            public override string ToString() //Formateo mis clase para que los objetos devuelvan un string con la información al ser nombrados
            {
                return $"La librería {this.LibraryShelve} en el sector {this.LibrarySector} tiene los libros:\n{String.Join("\n",this.ListaBook)}";
            }
        }
}