namespace Consecionaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            bool salir = false;
            string matricula;
            int kilometraje;
            string modelo;
            string color;
            Consecionaria consecionaria = new Consecionaria();
            while(!salir)
            {
                Console.Clear();
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
                        matricula = Console.ReadLine();
                        Console.WriteLine("Dame el kilometraje: ");
                        kilometraje = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dame el modelo: ");
                        modelo = Console.ReadLine();
                        Console.WriteLine("Dame el color: ");
                        color = Console.ReadLine();
                        Automovil auto = new Automovil(matricula, kilometraje, modelo, color);
                        consecionaria.agregarAuto(auto);
                        Console.WriteLine("Auto agregado correctamente.");
                        Console.ReadKey();

                        break;
                    case 2:
                        Console.WriteLine("Dame la matricula: ");
                        matricula = Console.ReadLine();
                        consecionaria.eliminarAuto(matricula);
                        Console.ReadKey();
                        break;
                    case 3:
                        consecionaria.mostrarAutos();
                        Console.ReadKey();
                        break;

                    case 4:
                        salir = true;
                        break;
                }
            }
        }
    }
}
