using dl;

var controller = new Controller();
int opcion = 0;

do
{
    Console.WriteLine("Escoga una opcion:");
    Console.WriteLine("1- Agregar elemento");
    Console.WriteLine("2- Mostar arbol en pre-orden");
    Console.WriteLine("3- Mostar arbol en in-orden");
    Console.WriteLine("4- Mostar arbol en post-orden");
    Console.WriteLine("5- Salir");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            controller.Add(ReadNumber());
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Dibujando el arbol");
            Console.WriteLine("\n\n\n");
            Console.WriteLine(controller.DrawTree());
            Console.WriteLine("\n\n\n");
            break;

        case 2:
            Console.WriteLine(controller.ShowPreOrder());
            break;

        case 3:
            Console.WriteLine(controller.ShowInOrder());
            break;

        case 4:
            Console.WriteLine(controller.ShowPostOrder());
            break;

        case 5:
            Console.WriteLine("Adios");
            Console.WriteLine(controller.ShowTree());
            break;

        default:
            Console.WriteLine("Opcion no valida");
            break;
    }
} while (opcion != 5);

static int ReadNumber()
{
    Console.WriteLine("Digite el numero");
    var number = Convert.ToInt32(Console.ReadLine());
    return number;
}