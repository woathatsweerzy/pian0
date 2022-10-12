namespace PIANO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Key();
        }
        static void Key()
        {
            Console.WriteLine("Есть 3 окатвы: 2-я, 3-я и 4-я:");
            Console.WriteLine("Переключение: F2, F3, F4");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.F2)
            {
                Console.WriteLine("Выбрана 2-я октава");
                int[] octava2 = new int[] { 65, 73, 82, 87, 98, 110, 123, 69, 77, 92, 103, 116 };
                Octave(octava2);
            }
            if (key.Key == ConsoleKey.F3)
            {
                Console.WriteLine("Выбрана 3-я октава");
                int[] octava3 = new int[] { 130, 146, 164, 174, 196, 220, 246, 138, 155, 185, 207, 233 };
                Octave(octava3);
            }
            if (key.Key == ConsoleKey.F4)
            {
                Console.WriteLine("Выбрана 4-я октава");
                int[] octava4 = new int[] { 261, 293, 329, 349, 392, 440, 493, 277, 311, 370, 415, 466 };
                Octave(octava4);
            }
        }
        static void Octave(int[] octave)
        {
            ConsoleKeyInfo button = Console.ReadKey();
            while (button.Key != ConsoleKey.Escape)
            {
                if (button.Key == ConsoleKey.Z)
                {
                    Console.Beep(octave[0], 200);
                }
                else if (button.Key == ConsoleKey.X)
                {
                    Console.Beep(octave[1], 200);
                }
                else if (button.Key == ConsoleKey.C)
                {
                    Console.Beep(octave[2], 200);
                }
                else if (button.Key == ConsoleKey.V)
                {
                    Console.Beep(octave[3], 200);
                }
                else if (button.Key == ConsoleKey.B)
                {
                    Console.Beep(octave[4], 200);
                }
                else if (button.Key == ConsoleKey.N)
                {
                    Console.Beep(octave[5], 200);
                }
                else if (button.Key == ConsoleKey.M)
                {
                    Console.Beep(octave[6], 200);
                }
                else if (button.Key == ConsoleKey.S)
                {
                    Console.Beep(octave[7], 200);
                }
                else if (button.Key == ConsoleKey.D)
                {
                    Console.Beep(octave[8], 200);
                }
                else if (button.Key == ConsoleKey.G)
                {
                    Console.Beep(octave[9], 200);
                }
                else if (button.Key == ConsoleKey.H)
                {
                    Console.Beep(octave[10], 200);
                }
                else if (button.Key == ConsoleKey.J)
                {
                    Console.Beep(octave[11], 200);
                }
                Console.Clear();
                button = Console.ReadKey();
            }
        }
    }
}
// я в рот ебал этот ваш гит баш блять просто убить того кто его сделал