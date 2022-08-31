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
    public class Doctors //Creo una clase Clients para administrar los clientes como objetos separados
    {
        public string Name {get; set;}
        public string Especialidad {get; set;}
        public string Consultorio {get; set;}

        public Doctors(string name, string especialidad, string consultorio)//Agrego también el dato edad
        {
            this.Name = name;
            this.Especialidad = especialidad;
            this.Consultorio = consultorio;
        }
        public override string ToString()
        {
            return $"Doctor: {this.Name}, {this.Especialidad}, Consultorio: {this.Consultorio}";
        }
    }
}