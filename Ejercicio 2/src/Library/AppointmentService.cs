using System;
using System.Text;
using System.Collections.Generic;

namespace Library
{
    public class AppointmentService
    /* Esta clase permite agregar una sola consulta y necesita ingresar sus datos individualmente cada vez que se ejecuta.
    Lo ideal para cumplir con el principio SRP es que hayan clases que gestionen los diferentes datos.
    A su vez, para permitir las modificaciones que permite la consigna, es necesario crear diferentes clases que permitan ser
    modificadas sin necesitar cambiar la clase para crear las consultas.*/
    {
        public Client Cliente {get; set;}
        public Doctor Doctor1 {get; set;}
        public int IdApp {get; set;}
        public DateTime Date {get; set;}
        public static int IdUnico = 0; //Contador de consultas
        public static List<AppointmentService> Reservas = new List<AppointmentService>(); //Creo una lista donde voy a guardar las consultas
        public AppointmentService(Client cliente, Doctor doctor, int idapp, DateTime date) //Constructor para las consultas
        {
            this.Cliente = cliente;
            this.Doctor1 = doctor;
            this.IdApp = idapp; //Le asigno el valor del contador de consultas a cada consulta
            this.Date = date;
        }
        public static void CreateAppointment(Client capp, Doctor dapp, DateTime date) //En vez de un string lo paso a void porque no me interesa que retorne nada. Solo que me informe en consola
        {
            if(Validate.ValidarConsulta(capp,dapp)) //Valido los datos del doctor y cliente para crear la consulta
            {
                IdUnico ++; //Cada vez que se crea un appointment, le asigno un ID de consulta acumulativo
                AppointmentService r = new AppointmentService(capp,dapp,IdUnico,date); //Creo el objeto consulta con los datos del método CreateAppointment
                Reservas.Add(r); //Agrego el objeto a la lista
                Console.WriteLine($"CONSULTA {r.IdApp} CREADA: {r.Cliente} el día {r.Date} con {r.Doctor1}"); //Devuelvo a la consola que se pudo crear
            }
            else
            {
                Console.WriteLine("Imposible crear la consulta. Los datos son incorrectos."); //En caso de que los datos sean incorrectos
            }
            
        }
        public override string ToString()
        {
            return $"CONSULTA {this.IdApp} CREADA: {this.Cliente} el día {this.Date} con {this.Doctor1}"; //Si quiero chequear la información de una consulta, esto es lo que imprime cuando se llama a la misma
        }

    }
}
