namespace Consecionaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            bool salir = false;
            while(!salir)
            {
                Console.WriteLine("1.- Nuevo Automovil");
                Console.WriteLine("2.- Quitar Automovil");
                Console.WriteLine("3.- Mostrar Automoviles");
                Console.WriteLine("4.- Salir");

                if(!int.TryParse (Console.ReadLine(), out op))
                {
                    Console.WriteLine("Opcion invalida.");
                    Console.WriteLine();
                }
                
                //op = int.Parse(Console.ReadLine()); // convert.ToInt32(Console.ReadLine());

                switch(op)
                {
                    case 1:
                        Console.WriteLine("Dame la matricula: ");
                        string matricula = Console.ReadLine();
                        Console.WriteLine("Dame")
                        int kilometraje = int.Parse(Console.ReadLine());
                        string modelo = Console.ReadLine();
                        string color = Console.ReadLine();
                        Automovil auto = new Automovil(matricula, kilometraje, modelo, color);
                        break;
                    case 2:

                        break;
                    case 3:

                        break;

                    case 4:

                        break;
                }
            }
        }
    }
}
