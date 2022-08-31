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
            AppointmentService.CreateAppointment(Ale, DrNacho);
            AppointmentService.CreateAppointment(Ale, DrCoco);
            AppointmentService.CreateAppointment(Michel, DrNacho);//Creo tres consultas
        }
    }
}
