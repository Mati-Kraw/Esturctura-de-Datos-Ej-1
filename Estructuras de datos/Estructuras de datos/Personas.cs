internal class Personas
{
    static List<Persona> personas = new List<Persona>();
    internal static void Nuevo()
    {
        Console.Clear();

        var persona = new Persona();

        Console.WriteLine("Ingrese Numero de Documento: ");
        persona.documento = Usuario.PedirNumeroEntre(min: 1_000_000, max: 99_999_999);
        foreach (var pers in personas)
        {
            if (pers.documento == persona.documento)
            {
                Console.WriteLine($"El documento {pers.documento} ya esta creado, no puede haber duplicados");
                Console.WriteLine("Ingrese Cualquier tecla para continuar");
                Console.ReadKey();
                return;
            }
        }
        Console.WriteLine("Ingrese Nombre: ");
        persona.nombre = Usuario.PedirCadena(max: 30);
        Console.WriteLine("Ingrese Apellido: ");
        persona.apellido = Usuario.PedirCadena(max: 30);
        Console.WriteLine("Ingrese Fecha de Nacimiento: ");
        persona.nacimiento = Usuario.PedirFecha(max: DateTime.Now);

        Console.WriteLine($"La Persona {persona.nombre} {persona.apellido} con Documento {persona.documento} fue creado correctamente");
        Console.WriteLine("Ingrese cualquier tecla para continuar");
        Console.ReadKey();
        personas.Add(persona);
    }

    internal static void Eliminar()
    {
        Console.Clear();
        Console.WriteLine("Ingrese el Documento de la persona a eliminar: ");
        int documentoEliminar = Usuario.PedirNumeroEntre(min: 1_000_000, max: 99_999_999);

        foreach (var persona in personas)
        {
            if (persona.documento == documentoEliminar)
            {
                personas.Remove(persona);
                Console.WriteLine($"El documento {documentoEliminar} fue elminado Correctamente");
                return;
            }
        }

        //forma corta de hacerlo
        //personas.Remove(personas.Single(p => p.documento == documentoEliminar));

        Console.WriteLine($"No se Encontro a una Persona con el Documento  {documentoEliminar}");
    }

    internal static void Grabar()
    {
        using var ArchivoPersonas = new StreamWriter("Personas.txt");
        foreach (var persona in personas)
        {
            var linea = $"{persona.nombre}|{persona.apellido}|{persona.nacimiento}|{persona.documento}";
            ArchivoPersonas.WriteLine(linea);

            Console.Clear();
            Console.WriteLine("Archivo Guardado Correctamente");
            Console.WriteLine("Ingrese Cualquier tecla para continuar");
            Console.ReadKey();
        }
    }

    internal static void Cargar()
    {
        personas.Clear();
        using var ArchivoPersonas = new StreamReader("Personas.txt");

        while (!ArchivoPersonas.EndOfStream)
        {
            string proximalinea = ArchivoPersonas.ReadLine();
            string[] datosSeparados = proximalinea.Split("|");

            var persona = new Persona();

            persona.nombre = datosSeparados[0];
            persona.apellido = datosSeparados[1];
            persona.nacimiento = DateTime.Parse(datosSeparados[2]);
            persona.documento = int.Parse(datosSeparados[3]);

            personas.Add(persona);

            Console.Clear();
            Console.WriteLine("Archivo Cargado Correctamente");
            Console.WriteLine("Ingrese Cualquier tecla para continuar");
            Console.ReadKey();
        }
    }

    internal static void Mostrar()
    {
        Console.Clear();
        Console.WriteLine("Ingrese el Documento de la persona a Mostrar: ");
        int documentoMostrar = Usuario.PedirNumeroEntre(min: 1_000_000, max: 99_999_999);


        foreach (var persona in personas)
        {
            if (persona.documento == documentoMostrar)
            {
                Console.WriteLine($"Nombre : {persona.nombre}");
                Console.WriteLine($"Apellido : {persona.apellido}");
                Console.WriteLine($"Fecha de Nacimiento : {persona.nacimiento.ToShortDateString()}");
                Console.WriteLine($"Documento : {persona.documento}");
            }
            else { Console.WriteLine("El documento ingresado no esta dado de alta"); }

        }
        if (personas.Count == 0)
        {
            Console.WriteLine("El documento ingresado no esta dado de alta");
        }

        Console.WriteLine("Ingrese cualquier tecla para continuar");
        Console.ReadKey();
    }
    internal static void MostrarLista()
    {
        Console.Clear();
        foreach (var persona in personas)
        {

            Console.WriteLine($"Nombre : {persona.nombre}");
            Console.WriteLine($"Apellido : {persona.apellido}");
            Console.WriteLine($"Fecha de Nacimiento : {persona.nacimiento.ToShortDateString()}");
            Console.WriteLine($"Documento : {persona.documento}");
            Console.WriteLine("===========================================");

        }

        if (personas.Count == 0)
        {
            Console.WriteLine("No se ha dado de alta ninguna persona aun");
        }
        Console.WriteLine("Ingrese cualquier tecla para continuar");
        Console.ReadKey();
    }
    internal static void Editar()
    {
        Console.Clear();
        Console.WriteLine("Ingrese el Documento de la persona a Editar: ");
        int documentoEditar = Usuario.PedirNumeroEntre(min: 1_000_000, max: 99_999_999);


        foreach (var persona in personas)
        {
            if (persona.documento == documentoEditar)
            {

                Console.WriteLine($"Nombre : {persona.nombre}");
                Console.WriteLine($"Apellido : {persona.apellido}");
                Console.WriteLine($"Fecha de Nacimiento : {persona.nacimiento.ToShortDateString()}");
                Console.WriteLine($"Documento : {persona.documento}");
                Console.WriteLine("===========================================");

                Console.WriteLine("Ingrese Numero de Documento nuevo: ");
                persona.documento = Usuario.PedirNumeroEntre(min: 1_000_000, max: 99_999_999);
                Console.WriteLine("Ingrese Nombre nuevo: ");
                persona.nombre = Usuario.PedirCadena(max: 30);
                Console.WriteLine("Ingrese Apellido nuevo: ");
                persona.apellido = Usuario.PedirCadena(max: 30);
                Console.WriteLine("Ingrese Fecha de Nacimiento nuevo: ");
                persona.nacimiento = Usuario.PedirFecha(max: DateTime.Now);
            }
            else { Console.WriteLine("El documento ingresado no esta dado de alta"); }

        }
        if (personas.Count == 0)
        {
            Console.WriteLine("El documento ingresado no esta dado de alta");
        }

        Console.WriteLine("Ingrese cualquier tecla para continuar");
        Console.ReadKey();
    }
}