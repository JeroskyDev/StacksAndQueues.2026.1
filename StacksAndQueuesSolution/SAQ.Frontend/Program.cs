using SAQ.Backend;

//var stack = new StackUsingArray<string>(5);
//var stack = new StackUsingList<string>(); //Lists doesn´t have a size, they just get values in them, so that´s why we don´t put any number in the parenthesis.
var stack = new Stack<string>(); //built-in stack of C#, it is implemented using a linked list, so it is dynamic and can grow as needed, but it has a maximum capacity of memory.
var option = string.Empty;

do
{
    option = Menu();
    switch (option)
    {
        case "1":
            Console.Write("Digite el elemento a apilar: ");
            var element = Console.ReadLine() ?? string.Empty;
            stack.Push(element);
            Console.WriteLine($"Elemento '{element}' apilado.");
            break;
        case "2":
            try
            {
                var poppedElement = stack.Pop();
                Console.WriteLine($"Elemento '{poppedElement}' ha sido desapilado.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
        case "3":
            try
            {
                var topElement = stack.Peek();
                Console.WriteLine($"El tope de la pila es: '{topElement}'.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
        case "0":
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción no válida. Por favor, intentelo de nuevo...");
            break;
    }
} while (option != "0");

string Menu()
{
    Console.WriteLine("--- PILAS ---");
    Console.WriteLine("1. Apilar");
    Console.WriteLine("2. Desapilar");
    Console.WriteLine("3. Ver tope");
    Console.WriteLine("0. Salir");
    Console.Write("Digite su opción: ");
    return Console.ReadLine() ?? string.Empty;
}