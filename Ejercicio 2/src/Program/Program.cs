using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctors DrCoco = new Doctors("Dr. Leito Conde","Oftalmología","Sala M101");//Creo los doctores
            Doctors DrNacho = new Doctors("Dr. Ignacio Pérez","Ginecología", "Consultorio C202");
            Clients Ale = new Clients("Alejandro Lacassy",30,0123,"099000111");//Creo los clientes
            Clients Michel = new Clients("Michel Sampil",30,0543,"091222333");
            AppointmentService.CreateAppointment(Ale, DrNacho);
            AppointmentService.CreateAppointment(Ale, DrCoco);
            AppointmentService.CreateAppointment(Michel, DrNacho);//Creo tres consultas
        }
    }
}
