using System;

namespace Consulta
{
    // SRP: La clase cumple con el patron SRP porque sólo se encarga de crear las citas médicas en caso de 
    // que todos los datos ingresados sean válidos. No se encarga de imprimir el ticket de la consulta pero
    // si se encarga de armarlo para que pueda imprimirse por pantalla cuando el programa lo requiera.

    // EXPERT: La clase cumple con el patron EXPERT porque es la única clase que conoce los datos acerca de las consultas
    public class AppointmentService
    {
        public static string CreateAppointment(Paciente paciente, DateTime date, Clinica clinica, Doctor doctor)
        {
            string a = "Scheduling appointment...\n";
            string b = "Appoinment Scheduled\n";
            string c = "";
            Boolean isValid = true;
            if (isValid==true && Paciente.PacienteValido(paciente)==false)
            {
                b = "El paciente ingresado es inválido. Por favor corrija los datos del mismo";
                isValid = false;
            }
            if(isValid==true && Doctor.DoctorValido(doctor)==false)
            {
                b = "El doctor ingresado es inválido. Por favor corrija los datos del mismo";
                isValid = false;
            }
            if (isValid==true && Clinica.ClinicaValida(clinica))
            {
                b = "El lugar de consulta no es válido.";
                isValid = false;
            }
            if (isValid)
            {
                c = $"{a}{b}La cita del señor {paciente.Nombre}\n con el doctor {doctor.Nombre}\n fue agendada correctamente agendada el {date}\n en {appointmentPlace}";
            }
            else
            {
                c = $"{a}{b}";
            }

            return c;
        }

    }
}
