class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[5];
        int suma = 0;

        for (int i = 0; i < 5; i++)
        {
            System.Console.Write("Ingrese un número: ");
            numeros[i] = int.Parse(System.Console.ReadLine());
            suma += numeros[i];
        }