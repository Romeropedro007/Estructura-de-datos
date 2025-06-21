// Aquí definimos la estructura del turno como si fuera un registro
class Turno
{
    public string nombre;   // Nombre del paciente    public string cedula;   // Cédula del paciente
    public string fecha;    // Fecha del turno
    public string hora;     // Hora del turno
}

// Esta clase maneja la lógica de la agenda usando un vector
class AgendaTurnos
{
    Turno[] turnos = new Turno`[100];
    // Contador para saber cuántos turnos hemos registrado
    int contador = 0;

    // Método para agendar un nuevo turno
    public void AgendaTurnos()
    {
        //Validamos si aún hay espacio en el vector
        if (contador < turnos.Length)
        {
            //Nuevo objeto tipo turno
            Turno nuevo = new Turno();

            //Solicitamos ingreso de datos del paciente
            Console.Write("Ingrese nombre del paciente: ");
            nuevo.nombre = Console.ReadLine();

            Console.Write("Ingrese cédula: ");
            nuevo.cedula = Console.ReadLine();

            Console.Write("Ingrese fecha (dd/mm/aaaa): ");
            nuevo.fecha = Console.ReadLine();

            Console.Write("Ingrese hora (hh:mm): ");
            nuevo.hora = Console.ReadLine();

            //Guardamos el turno en el vector
            turnos[contador] = nuevo;

            //Aumentamos el contador en 1
            contador++;

            //Mensaje mostrando resueltado exitoso
            Console.WriteLine("Turno registrado correctamente.\n";
        }
    }
    else
    {
        //Si se llena el vector, mostramos el siguiente mensaje
        Console.WriteLine("No hay espacio para mas turnos. \n");
    }
//Muestra de turnos que se van agendando
public void Mostrarturnos()
{
    Console.WriteLine("\nTurnos registrados: ");

    //Recorremos el vector desde el inicio hasta donde hay datos 
}