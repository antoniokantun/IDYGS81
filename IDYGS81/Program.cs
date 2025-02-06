// See https://aka.ms/new-console-template for more information

using IDYGS81;

Menu menu = new Menu();

Persona persona = new Persona();

Console.WriteLine("Ingrese su nombre");
persona.Nombre = Console.ReadLine();

Console.WriteLine("Ingrese su apellido");
persona.Apellido = Console.ReadLine();

    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicacion");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Salir");

Console.WriteLine("Ingrese una opcion");
int opcion = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el primer numero");
decimal num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero");
decimal num2 = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1:
        Console.WriteLine($"La {persona.Nombre} {persona.Apellido} la suma es: {menu.Suma(num1, num2)}");
        break;
    case 2:
        Console.WriteLine($"La {persona.Nombre} {persona.Apellido} la resta es: {menu.resta(num1, num2)}");
        break;
    case 3:
        Console.WriteLine($"La {persona.Nombre} {persona.Apellido} la multiplicacion es: {menu.multiplicacion(num1, num2)}");
        break;
    case 4:
        Console.WriteLine($"La {persona.Nombre} {persona.Apellido} la division es: {menu.division(num1, num2)}");
        break;
    default:
        Console.WriteLine("Opcion no valida");
        break;
}






