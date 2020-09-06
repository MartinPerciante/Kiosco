using System;

namespace Consulta
{
    // SRP: La clase cumple con el patron SRP porque tiene la responsabilidad de crear las paciente pero también
    // se encarga de verificar que sean válidos los datos del mismo para cumplir con el patron EXPERT.

    // EXPERT: La clase cumple con el patron EXPERT porque conoce todo lo relacionado con los pacientes, por lo que
    // verificar que estos sean válidos es parte de lo que debe hacerse porque para verificar que el paciente sea
    // válido se deben conocer sus datos, y esta es la clase que los conoce.
    public class Paciente
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
        private int edad;
        public int Edad 
        {
            get {return edad;}
            set
            {
                if (value>=0)
                {
                    edad=value;
                }
            }
        }
        private string phoneNumber;
        public string PhoneNumber 
        {
            get {return phoneNumber;}
            set
            {
                if (value.Length==9 && String.IsNullOrEmpty(value)==false)
                {
                    phoneNumber=value;
                }
            }
        }
        private string id;
        public string Id
        {
            get{return id;}
            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    id=value;
                }
            }
        }

        public Paciente(string nombre, int edad, string phoneNumber, string id)
        {
            this.Nombre=nombre;
            this.Edad=edad;
            this.PhoneNumber=phoneNumber;
            this.Id=id;
        }
        public static bool PacienteValido(Paciente paciente)
        {
            bool valido=true;
            if (string.IsNullOrEmpty(paciente.nombre) || paciente.edad<0 || IdUtils.IdIsValid(paciente.id)==false || paciente.phoneNumber.Length!=9 || String.IsNullOrEmpty(paciente.phoneNumber))
            {
                valido=false;
            }

            return valido;
        }
    }
}