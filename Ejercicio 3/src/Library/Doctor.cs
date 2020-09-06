using System;

namespace Consulta
{
    // SRP: La clase cumple con el patron SRP porque tiene la responsabilidad de crear los doctores pero también
    // se encarga de verificar que sean válidos los datos del mismo para cumplir con el patron EXPERT.

    // EXPERT: La clase cumple con el patron EXPERT porque conoce todo lo relacionado con los doctores, por lo que
    // verificar que estos sean válidos es parte de lo que debe hacerse porque para verificar que el doctor sea
    // válido se deben conocer sus datos, y esta es la clase que los conoce.
    public class Doctor
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
        private string id;
        public string Id 
        {
            get {return id;}
            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    id=value;
                }
            }
        }
        private string especialidad;
        public string Especialidad 
        {
            get {return especialidad;}
            set
            {
                if (string.IsNullOrEmpty(value)==false)
                {
                    especialidad=value;
                }
            }
        }

        public Doctor(string nombre, string especialidad, string id)
        {
            this.Nombre=nombre;
            this.Id=id;
            this.Especialidad=especialidad;
        }
        public static bool DoctorValido(Doctor doctor)
        {
            bool valido=true;
            if (string.IsNullOrEmpty(doctor.nombre) || IdUtils.IdIsValid(doctor.id)==false || String.IsNullOrEmpty(doctor.especialidad))
            {
                valido=false;
            }
            return valido;
        }
    }
}