internal class MenuPrincipal
{
    internal static int Mostrar()
    {
        Console.WriteLine("1- Crear Persona");
        Console.WriteLine("2- Eliminar Persona");
        Console.WriteLine("3- Mostrar Persona");
        Console.WriteLine("4- Mostrar Lista de Personas");
        Console.WriteLine("5- Grabar Persona");
        Console.WriteLine("6- Cargar Persona");
        Console.WriteLine("7- Editar Persona");
        Console.WriteLine("0- Salir");

        return Usuario.PedirNumeroEntre(min:0,max:7);
    }
}