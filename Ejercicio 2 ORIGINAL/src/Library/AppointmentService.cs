using System;
using System.Text;
/*
Para cumplir con SRP y Expert la clase AppointmentService podría tener como colaboradoras las clases de Cliente (para name,id,phonenumber) y la de doctor(para doctorname,appointmentplace).
De esta manera se puede delegar las funcionalidades y que no se necesite modificar la clase AppointmentService cada vez que quiera modificar la forma en la que
almaceno los datos de los clientes o doctores.
*/
namespace Library
{
    public class AppointmentService
    {
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName) //Uso los objetos que voy a crear como parámetros en vez de sobrecargar esta clase con esa info. 
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n"); //El StringBuilder no lo voy a usar, ya que encuentro más facil concatenar los objetos en el ToString
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
