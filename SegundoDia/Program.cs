Console.WriteLine("Calculador de porcentaje");
Console.WriteLine(" ");
Console.WriteLine("Ingrese el monto a pagar");
double monto = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el porcentaje de descuento que tiene el producto");
int descuento = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese cuantos productos va a comprar");
int cantidad = int.Parse(Console.ReadLine());

Console.WriteLine("El total a pagar antes del descuento es: " + (monto*cantidad));
Console.WriteLine("El monto del descuento es de:");