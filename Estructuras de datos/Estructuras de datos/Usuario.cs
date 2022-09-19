internal class Usuario
{
    internal static int PedirNumeroEntre(int min, int max)
    {
        int numero;
        int.TryParse(Console.ReadLine(), out numero);
        while (numero < min || numero > max)
        {
            Console.WriteLine($"El numero debe estar entre {min} y {max}");
            Console.WriteLine("Aprete una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Ingrese un numero nuevamente: ");
            int.TryParse(Console.ReadLine(), out numero);
        }
        return numero;
    }

    internal static string PedirCadena(int max)
    {
        string cadena = Console.ReadLine();
        while (cadena.Length > max)
        {
            Console.WriteLine($"La cadena debe tener como maximo {max} caracteres");
            Console.WriteLine("Aprete una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Ingrese la cadena nuevamente: ");
            cadena = Console.ReadLine();
        }
        return cadena;
    }

    internal static DateTime PedirFecha(DateTime max)
    {
        DateTime tiempo;
        DateTime.TryParse(Console.ReadLine(), out tiempo);

        while (tiempo > max)
        {
            Console.WriteLine($"La fecha debe ser menor a {max}");
            Console.WriteLine("Aprete una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Ingrese Fecha nuevamente: ");
            DateTime.TryParse(Console.ReadLine(), out tiempo);
        }
        return tiempo;
    }
}