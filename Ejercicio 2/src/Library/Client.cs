using System;
using System.Collections.Generic;
/*
CONSIGNA (Para mi referencia)
1. Se podrían agregar otros datos del paciente como por ejemplo su edad.
2. Se podrían agregar otros datos al Doctor como por ejemplo su especialidad.
3. La consulta debe tener un identificador único
4. Cada dato que se ingrese al sistema debe ser válidado.*/
namespace Library
{
    public class Client //Creo una clase Clients para administrar los clientes como objetos separados
    {
        public string Name {get; set;}
        public int Age {get; set;}
        public string PhoneNumber {get; set;}
        public int Id {get; set;}

        public Client(string name, int age, int id, string phoneNumber)//Agrego también el dato edad
        {
            this.Name = name;
            this.Age = age;
            this.PhoneNumber = phoneNumber;
            this.Id = id;
        }
        public override string ToString()
        {
            return $"Cliente: {this.Name}, ID: {this.Id}, {this.Age} años, TEL: {this.PhoneNumber}";
        }
    }
}