using System;
using System.Collections.Generic;

namespace Library
{
    public class Validate //Creo una clase para validar
    {
        public static bool ValidarConsulta(Doctor doctor, Client cliente)
        {
            if(ValidarCliente(cliente) && ValidarDoctor(doctor))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool ValidarDoctor(Doctor doc)//Clase privada porque no me interesa que se sepa fuera de la clase
        {
            if(String.IsNullOrEmpty(doc.Name) || String.IsNullOrEmpty(doc.Especialidad) || String.IsNullOrEmpty(doc.Consultorio))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool ValidarCliente(Client cli)
        {
            if(String.IsNullOrEmpty(cli.Name) || cli == null || String.IsNullOrEmpty(cli.PhoneNumber))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}