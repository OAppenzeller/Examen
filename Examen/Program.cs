using Examen;

public class Program
{
    public static void Main(string[] args)
    {
        Asignatura asignatura = new Asignatura();

        try
        {
            Console.Write("Ingrese el nombre del alumno: ");
            asignatura.NombreAlumno = Console.ReadLine();

            Console.Write("Ingrese el numero de cuenta: ");
            asignatura.NumeroCuenta = Console.ReadLine();

            Console.Write("Ingrese el email: ");
            asignatura.Email = Console.ReadLine();

            Console.Write("Ingrese el nombre de la asignatura: ");
            asignatura.NombreAsignatura = Console.ReadLine();

            Console.Write("Ingrese el nombre del docente: ");
            asignatura.NombreDocente = Console.ReadLine();

            Console.Write("Ingrese el horario: ");
            asignatura.Horario = Console.ReadLine();


        }catch(FormatException)
        {
            Console.WriteLine("Error de formato");
        }

    }
}