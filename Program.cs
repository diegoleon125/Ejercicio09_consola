Console.WriteLine("Ingrese 3 numeros enteros diferentes:");
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());
if (n1 > n2 && n1 > n3)
{
    Console.WriteLine("El mayor es: " + n1);
}
else if (n2 > n1 && n2 > n3)
{
    Console.WriteLine("El mayor es: " + n2);
}
else if (n3 > n1 && n3 > n2)
{
    Console.WriteLine("El mayor es: " + n3);
}