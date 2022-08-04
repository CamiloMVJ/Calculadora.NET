int[] notas = new int[3];
String[] alumno = new string[3];
int suma = 0;
for (int i = 0; i < alumno.Length; i++)
{
    Console.Write("Ingrese el nombre del alumno: ");
    alumno[i] = Console.ReadLine();
    Console.Write("Ingrese la nota de " + alumno[i] + ": ");
    notas[i] = int.Parse(Console.ReadLine());
    suma = suma + notas[i];
}

Console.WriteLine("El promedio del aula es: " + suma / alumno.Length);

