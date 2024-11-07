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

            Console.Write("Ingrese la nota del primer parcial: ");
            asignatura.N1 = int.Parse(Console.ReadLine());
            if (asignatura.N1 > 30)
            {
                Console.WriteLine("La nota del primer parcial no puede ser mayor a 30");
                return;
            }

            Console.Write("Ingrese la nota del segundo parcial: ");
            asignatura.N2 = int.Parse(Console.ReadLine());
            if (asignatura.N2 > 30)
            {
                Console.WriteLine("La nota del segundo parcial no puede ser mayor a 30");
                return;
            }

            Console.Write("Ingrese la nota del tercer parcial: ");
            asignatura.N3 = int.Parse(Console.ReadLine());
            if (asignatura.N3 > 40)
            {
                Console.WriteLine("La nota del tercer parcial no puede ser mayor a 40");
                return;
            }

            asignatura.Imprimir();

        }catch(FormatException)
        {
            Console.WriteLine("Ingrese valores validos para las notas.");
        }

    }
}