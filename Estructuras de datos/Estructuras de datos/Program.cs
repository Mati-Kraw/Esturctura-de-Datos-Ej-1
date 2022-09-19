while (true)
{
    int opcion = MenuPrincipal.Mostrar();

    if (opcion == 1)
    {
        Personas.Nuevo();
        Console.Clear();
    }
    else if (opcion == 2)
    {
        Personas.Eliminar();
        Console.Clear();
    }
    else if (opcion == 3)
    {
        Personas.Mostrar();
        Console.Clear();
    }
    else if (opcion == 4)
    {
        Personas.MostrarLista();
        Console.Clear();
    }
    else if (opcion == 5)
    {
        Personas.Grabar();
        Console.Clear();
    }
    else if (opcion == 6)
    {
        Personas.Cargar();
        Console.Clear();
    }
    else if (opcion == 7)
    {
        Personas.Editar();
        Console.Clear();
    }
    else if (opcion == 0)
    {
        Console.Clear();
        Console.WriteLine("Adios!");
        return;
    }
}
