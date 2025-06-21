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
            
        }
    }