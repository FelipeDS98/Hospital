using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{
    class Program
    {

        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente();
        private static IRepositorioMedico _repoMedico = new RepositorioMedico();

        static void Main(string[] args)
        {
            Console.WriteLine("Working");
            // AddPaciente();
            BuscarPaciente(1);
            // AddMedico();
            // AsignarMedico();
        }

        private static void AddPaciente()
        {
            var paciente = new Paciente{
                Nombre = "Nicolás",
                Apellidos = "Díaz",
                NumeroTelefono = "3185183558",
                Genero = Genero.Masculino,
                Direccion = "Calle 143 B N 127 F 06",
                Longitud = 5.07062F,
                Latitud = -75.52290F,
                Ciudad = "Manizales",
                FechaNacimiento = new DateTime(2000, 02, 19)
            };

            _repoPaciente.AddPaciente(paciente);
        }

        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);

            Console.WriteLine(paciente.Nombre + " " + paciente.Apellidos);
        }

        private static void AsignarMedico()
        {
            var medico = _repoPaciente.AsignarMedico(1, 2);
            Console.WriteLine(medico.Nombre + " " + medico.Apellidos);
        }


        private static void AddMedico()
        {
            var medico = new Medico{
                Nombre = "Felipe",
                Apellidos = "Díaz",
                NumeroTelefono = "3152996854",
                Genero = Genero.Masculino,
                Especialidad = "Cirugía",
                Codigo = "1",
                RegistroRethus = "CR7"
            };

            _repoMedico.AddMedico(medico);
        }
    }
}
