using System;

namespace Consulta
{
    // SRP: La clase cumple con el patron SRP porque tiene la responsabilidad de crear las clinicas pero también
    // se encarga de verificar que sean válidos los datos de la misma para cumplir con el patron EXPERT.

    // EXPERT: La clase cumple con el patron EXPERT porque conoce todo lo relacionado con las clinicas, por lo que
    // verificar que estos sean válidos es parte de lo que debe hacerse porque para verificar que la clinica sea
    // válida se deben conocer sus datos, y esta es la clase que los conoce.
    public class Clinica
    {
        private string nombre;
        public string Nombre 
        {
            get {return nombre;}
            set
            {
                if (String.IsNullOrEmpty(value)==false)
                {
                    nombre=value;
                }
            }
        }
        private string telefono;
        public string Telefono 
        {
            get {return telefono;}
            set
            {
                if (value.Length==8 && String.IsNullOrEmpty(value)==false)
                {
                    telefono=value;
                }
            }
        }
        private string direccion;
        public string Direccion 
        {
            get {return direccion;}
            set
            {
                if (string.IsNullOrEmpty(value)==false)
                {
                    direccion=value;
                }
            }
        }

        public Clinica(string nombre, string telefono, string direccion)
        {
            this.Nombre=nombre;
            this.Telefono=telefono;
            this.Direccion=direccion;
        }
        public static bool ClinicaValida(Clinica clinica)
        {
            bool valido=true;
            if (string.IsNullOrEmpty(clinica.Direccion) || clinica.Telefono.Length!=8 || String.IsNullOrEmpty(clinica.Telefono) || string.IsNullOrEmpty(clinica.Direccion))
            {
                valido=false;
            }
            return valido;
        }
    }
    }