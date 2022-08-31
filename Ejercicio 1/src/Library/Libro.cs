using System;
using System.Collections.Generic;

namespace SRP
{
    public class Book
    {
        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
        public override string ToString() //Formateo mi clase para que los libros devuelvan su información al ser nombrados
        {
            return $"Libro: {this.Title}, {this.Author}, CODIGO: {this.Code}";
        }
    }
}
/*
Para que el código se esté en conformidad con el principio SRP cada clase tiene que tener una
reponsabilidad relacionada con una sola funcionalidad del programa.
En este caso teníamos a la clase Shelve dentro de Book, cuando en realidad hacen dos cosas diferentes que,
si bien pueden trabajar en conjunto, no se necesita una para usar la otra.
En caso de que queramos cambiar la forma en la que organizamos las repisas, hubiéramos tenido que modificar
la clase Book también.*/

