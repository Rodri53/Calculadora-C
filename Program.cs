Console.WriteLine("Introduzca un número");
var primerNumero = Console.ReadLine();
Console.WriteLine("Introduzca otro número");
var segundoNumero = Console.ReadLine();
int x = Int32.Parse(primerNumero);
int y = Int32.Parse(segundoNumero);
Console.WriteLine("El resultado de sumar " + primerNumero + " y " + segundoNumero + " es: " + (x + y));
Console.WriteLine("El resultado de restar " + primerNumero + " y " + segundoNumero + " es: " + (x - y));
Console.WriteLine("El resultado de multiplicar " + primerNumero + " y " + segundoNumero + " es: " + (x * y));
Console.WriteLine("El resultado de dividir " + primerNumero + " y " + segundoNumero + " es: " + (x / y));
suma(x, y);
resta(x, y);
multiplicacion(x, y);
division(x, y);

static void suma(double x, double y)
{
    double resultado = x + y;
}
static void resta(double x, double y)
{
    double resultado = x - y;
}
static void multiplicacion(double x, double y)
{
    double resultado = x * y;
}
static void division(double x, double y)
{
    double resultado = x / y;
}