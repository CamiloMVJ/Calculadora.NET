Console.WriteLine("Bienvenidos al convertor de medidas");
Console.WriteLine("Ingrese cuantos metros de tela tiene");
int tela = int.Parse(Console.ReadLine());
int cicle = 0;
int opcion = 0;
double yardas= 0;
while (cicle < 100)
{
    Console.WriteLine("Ingrese que a que medida lo quiere transformar");
    Console.WriteLine("1. Pies");
    Console.WriteLine("2. Yarda");
    Console.WriteLine("3. Pulgada");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            {
                Console.WriteLine("Calculando...");
                Thread.Sleep(1000);
                Console.WriteLine("Usted tiene " + tela + " metros de tela, que son " + (tela*3.28) + " pies");
                cicle = 101;
                break;
            }
        case 2:
            {
                Console.WriteLine("Calculando...");
                Thread.Sleep(1000);
                yardas = tela * 1.09;
                Console.Write("Usted Tiene " + tela + " metros de tela, que son");
                Console.Write(" " + yardas.ToString("0.00"));
                cicle = 101;
                break;
            }
        case 3:
            {
                Console.WriteLine("Calculando...");
                Thread.Sleep(1000);
                Console.WriteLine("Usted tiene " + tela + " metros de tela, que son " + (tela*39.37));
                cicle = 101;
                break;
            }
        default:
            {
                Console.WriteLine("Ingrse una opcion valida");
                break;
            }
    }
}
