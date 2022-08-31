using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    /* Esta clase permite agregar una sola consulta y necesita ingresar sus datos individualmente cada vez que se ejecuta.
    Lo ideal para cumplir con el principio SRP es que hayan clases que gestionen los diferentes datos.
    A su vez, para permitir las modificaciones que permite la consigna, es necesario crear diferentes clases que permitan ser
    modificadas sin necesitar cambiar la clase para crear las consultas.*/
    {
        public static int IdUnico = 0;
        public static void CreateAppointment(Clients cliente, Doctors doctor) //En vez de un string lo paso a void porque no me interesa que retorne nada. Solo que me informe en consola
        {
            IdUnico ++; //Cada vez que se crea un appointment, le asigno un ID de consulta acumulativo
            Console.WriteLine($"CONSULTA {IdUnico} CREADA: {cliente} a la hora {DateTime.Now.ToShortDateString()} con {doctor}");
        }

    }
}
