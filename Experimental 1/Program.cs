// Aquí definimos la estructura del turno como si fuera un registro
class Turno
{
    public string nombre;   // Nombre del paciente
    public string cedula;   // Cédula del paciente
    public string fecha;    // Fecha del turno
    public string hora;     // Hora del turno
}

// Esta clase maneja la lógica de la agenda usando un vector
class AgendaTurnos
{
    Turno[] turnos = new Turno[100]; // Vector para turnos
    int contador = 0; // Contador para saber cuántos turnos hemos registrado

    // Método para agendar un nuevo turno
    public void AgendarTurno()
    {
        // Validamos si aún hay espacio en el vector
        if (contador < turnos.Length)
        {
            Turno nuevo = new Turno();

            Console.Write("Ingrese nombre del paciente: ");
            nuevo.nombre = Console.ReadLine();

            Console.Write("Ingrese cédula: ");
            nuevo.cedula = Console.ReadLine();

            Console.Write("Ingrese fecha (dd/mm/aaaa): ");
            nuevo.fecha = Console.ReadLine();

            Console.Write("Ingrese hora (hh:mm): ");
            nuevo.hora = Console.ReadLine();

            turnos[contador] = nuevo;
            contador++;

            Console.WriteLine("Turno registrado correctamente.\n");
        }
        else
        {
            Console.WriteLine("No hay espacio para más turnos.\n");
        }
    }

    // Método para mostrar los turnos registrados
    public void MostrarTurnos()
    {
        Console.WriteLine("\nTurnos registrados:");

        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine("Paciente: " + turnos[i].nombre);
            Console.WriteLine("Cédula: " + turnos[i].cedula);
            Console.WriteLine("Fecha: " + turnos[i].fecha);
            Console.WriteLine("Hora: " + turnos[i].hora);
            Console.WriteLine("---------------------------");
        }

        if (contador == 0)
        {
            Console.WriteLine("No hay turnos registrados.\n");
        }
    }
}

//Clase principal con el método Main (punto de entrada del programa)
class MainApp
{
    static void Main()
    {
        //Creamos una isntancia en la agenda
        AgendaTurnos agenda = new AgendaTurnos();
        int opcion;

        //Menú primcipal del sistema
        do
        {
            Console.WriteLine("---- MENÚ ----");
            Console.WriteLine("1. Agendar nuevo turno");
            Console.WriteLine("2. Ver turnos agendados");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");

            //Conversion de la entrada del usuario a número
            string entrada = Console.ReadLine();
            int.TryParse(entrada, out opcion);
            Console.WriteLine();

            // Según la opción elegida, llamamos al método correspondiente
            if (opcion == 1)
            {
                agenda.AgendarTurno(); // Llamamos al método para agendar
            }
            else if (opcion == 2)
            {
                agenda.MostrarTurnos(); // Llamamos al método para mostrar
            }
            else if (opcion == 3)
            {
                Console.WriteLine("Saliendo del sistema...");
            }
            else
            {
                Console.WriteLine("Opción no válida.\n");
            }

        } while (opcion != 3); // Repetimos mientras no elija salir
    }
}