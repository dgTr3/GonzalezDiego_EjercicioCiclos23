Console.WriteLine("Cuantos notas va a ingresar?");
int n=int.Parse(Console.ReadLine());
double notas = 0;
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Ingrese la nota:");
    notas += double.Parse(Console.ReadLine());
}
