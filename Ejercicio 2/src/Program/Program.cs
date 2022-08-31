using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor DrCoco = new Doctor("Dr. Leito Conde","Oftalmología","Sala M101");//Creo los doctores
            Doctor DrNacho = new Doctor("Dr. Ignacio Pérez","Ginecología", "Consultorio C202");
            Client Ale = new Client("Alejandro Lacassy",30,0123,"099000111");//Creo los clientes
            Client Michel = new Client("Michel Sampil",30,0543,"091222333");
            AppointmentService.CreateAppointment(Ale, DrNacho, new DateTime(2022,09,20));
            AppointmentService.CreateAppointment(Ale, DrCoco, new DateTime(2022,09,21));
            AppointmentService.CreateAppointment(Michel, DrNacho, new DateTime(2022,09,22));//Creo tres consultas
            Console.WriteLine(AppointmentService.Reservas[0]); //Chequeo la info de la primer consulta
            
            
            
            //LOS CRC ESTÁN COMO UN PDF EN EL GITHUB
        }
    }
}
