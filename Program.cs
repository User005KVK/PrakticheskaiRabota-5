using System.Diagnostics;

namespace PrakticheskaiRabota_5
{
    internal class Program
    {

        static void Main()
        {

            sozdau_tort cake_Created = new sozdau_tort();
            int position = 3;

            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                Console.Clear();
                cake_Created.Menu();
                position = cake_Created.Arrow(position, key);

                if (key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    if (position == 3)
                    {
                        Console.WriteLine("Выберите форму торта");
                        cake_Created.Output_Pod_Menu(cake_Created.Forma());
                    }
                    else if (position == 4)
                    {
                        Console.WriteLine("Выберите размер торта");
                        cake_Created.Output_Pod_Menu(cake_Created.Size());
                    }
                    else if (position == 5)
                    {
                        Console.WriteLine("Выберите вкус торта");
                        cake_Created.Output_Pod_Menu(cake_Created.Taste());
                    }
                    else if (position == 6)
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите количество коржей в торте");
                        cake_Created.Output_Pod_Menu(cake_Created.Korge());
                    }
                    else if (position == 7)
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите вкус глазури");
                        cake_Created.Output_Pod_Menu(cake_Created.Glasure());
                    }
                    else if (position == 8)
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите декор тортика");
                        cake_Created.Output_Pod_Menu(cake_Created.Dekor());
                    }
                    else if (position == 9)
                    {
                        Console.Clear();
                        Console.WriteLine("Спасибо за заказ! \n Нажмите F1, что-бы заказать еще тортик");
                        cake_Created.Save();

                        if (key == ConsoleKey.F1)
                        {
                            cake_Created.Menu();
                            cake_Created.ClearOrder();
                        }

                    }
                }
            }
        }
    }
}