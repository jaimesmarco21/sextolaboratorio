using System;
class program
{
    static void Main()
    {
        Console.WriteLine("¡Bienvenido al juego de adivinanzas!");
        bool x = false;
        do
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1,11);
            int intento = 0;
            bool adivinado = false;

            while (!adivinado)
            {
                Console.Write("Adivina el número (entre 1 y 10):");
                intento = int.Parse(Console.ReadLine());
                if (intento == numeroSecreto)
                {
                    Console.WriteLine("¡Felicidades! Has adivinado el númer secreto.");
                    adivinado = true;
                }
                else
                {
                    Console.WriteLine("Intentalo de nueco.");
                }
            }
            Console.WriteLine("¿quieres jugar otra vez? (s/n):");
            char jugarDeNuevo = Console.ReadKey().KeyChar;
            Console.WriteLine();
            switch (jugarDeNuevo)
            {
                case 's':
                case 'S':
                    Console.WriteLine("vamos a jugar otra vez!");
                    break;
                case 'n':
                case 'N':
                    Console.WriteLine("¡gracias por jugar! Hasta la próxima.");
                    x = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Salir del juego.");
                    jugarDeNuevo = 'n';
                    x = true;
                    break;
            }
        }  while(x == false);       
    }
}