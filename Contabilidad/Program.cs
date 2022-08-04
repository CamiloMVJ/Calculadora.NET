int[] socios = new int[3];
int suma = 0; 
for (int i = 0; i < socios.Length; i++)
{
    Console.WriteLine("Ingrese el monto del socio " + (i+1));
    socios[i] = int.Parse(Console.ReadLine());
    suma = suma + socios[i];
}
double[] socioss = new double[3];
socioss[0] = socios[0] * 100 / suma;
socioss[1] = socios[1] * 100 / suma;
socioss[2] = socios[2] * 100 / suma;
Console.WriteLine(" ");
Console.WriteLine("La suma del capital es: " + suma);
Console.WriteLine("El socio 1 aporto " + socioss[0]);
Console.WriteLine("El socio 1 aporto " + socioss[1]);
Console.WriteLine("El socio 1 aporto " + socioss[2]);
