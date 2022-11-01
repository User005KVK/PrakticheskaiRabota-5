using System.Security.Cryptography;

namespace PrakticheskaiRabota_5
{
    internal class sozdau_tort
    {        
        private int cost;
        private string zakaz;

        public void Menu()
        {
            Console.WriteLine(" Добро пожаловать.");
            Console.WriteLine(" Выберете параметр торта");
            Console.WriteLine("   Форма торта");
            Console.WriteLine("   Размер торта");
            Console.WriteLine("   Вкусы коржей");
            Console.WriteLine("   Количество коржей");
            Console.WriteLine("   Глазурь");
            Console.WriteLine("   Внешний вид");
            Console.WriteLine("   Ваш заказ завершен");
            Console.WriteLine("Цена: " + cost);
            Console.WriteLine("Ваш заказ: " + zakaz);
        }

        public List<Podprogramma> Forma()
        {
            Podprogramma krug = new Podprogramma();
            krug.titul = "Круг";
            krug.tsena = 75;
            Podprogramma oval = new Podprogramma();
            oval.titul = "Овал";
            oval.tsena = 80;
            Podprogramma kvadrat = new Podprogramma();
            kvadrat.titul = "Квадрат";
            kvadrat.tsena = 55;

            List<Podprogramma> forma = new List<Podprogramma>();
            forma.Add(krug);
            forma.Add(oval);
            forma.Add(kvadrat);
            return forma;
        }
        public List<Podprogramma> Size()
        {
            Podprogramma big = new Podprogramma();
            big.titul = " Большой";
            big.tsena = 500;
            Podprogramma medile = new Podprogramma();
            medile.titul = " Средний";
            medile.tsena = 250;
            Podprogramma small = new Podprogramma();
            small.titul = " Маленький";
            small.tsena = 200;

            List<Podprogramma> size = new List<Podprogramma>();
            size.Add(big);
            size.Add(medile);
            size.Add(small);
            return size;
        }
        public List<Podprogramma> Taste()
        {
            Podprogramma rasp = new Podprogramma();
            rasp.titul = "Шоколадный";
            rasp.tsena = 250;
            Podprogramma straw = new Podprogramma();
            straw.titul = "Клубничный";
            straw.tsena = 150;
            Podprogramma coffee = new Podprogramma();
            coffee.titul = "Кофейный";
            coffee.tsena = 100;

            List<Podprogramma> taste = new List<Podprogramma>();
            taste.Add(rasp);
            taste.Add(straw);
            taste.Add(coffee);
            return taste;
        }
        public List<Podprogramma> Korge()
        {
            Podprogramma onek = new Podprogramma();
            onek.titul = "1 корж";
            onek.tsena = 200;
            Podprogramma twok = new Podprogramma();
            twok.titul = "2 коржа";
            twok.tsena = 300;
            Podprogramma trek = new Podprogramma();
            trek.titul = "3 коржа";
            trek.tsena = 350;

            List<Podprogramma> korge = new List<Podprogramma>();
            korge.Add(onek);
            korge.Add(twok);
            korge.Add(trek);
            return korge;
        }
        public List<Podprogramma> Glasure()
        {
            Podprogramma vanile = new Podprogramma();
            vanile.titul = "Ванильный";
            vanile.tsena = 200;
            Podprogramma choko = new Podprogramma();
            choko.titul = "Шоколадная";
            choko.tsena = 300;
            
            List<Podprogramma> glasure = new List<Podprogramma>();
            glasure.Add(vanile);
            glasure.Add(choko);
            return glasure;
        }
        public List<Podprogramma> Dekor()
        {
            Podprogramma les = new Podprogramma();
            les.titul = "Лесные ягоды";
            les.tsena = 500;
            Podprogramma shoko_kroshka = new Podprogramma();
            shoko_kroshka.titul = "Шоколадная крошка";
            shoko_kroshka.tsena = 200;
            Podprogramma frykt = new Podprogramma();
            frykt.titul = "Фрукты";
            frykt.tsena = 300;

            List<Podprogramma> glasure = new List<Podprogramma>();
            glasure.Add(les);
            glasure.Add(shoko_kroshka);
            glasure.Add(frykt);
            return glasure;
        }

        public void Output_Pod_Menu(List<Podprogramma> box)
        {
            int position = 1;
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                Console.Clear();
                foreach (Podprogramma podmenu in box)
                {
                    Console.WriteLine("  " + podmenu.titul + " - " + podmenu.tsena);
                }
                position = Arrow(position, key);
                if (key == ConsoleKey.Enter)
                {
                    cost = cost + box[position].tsena;
                    zakaz = zakaz + box[position].titul;
                    break;
                }
                if (key == ConsoleKey.Escape)
                {
                    Menu();
                }
            }
        }
        public int Arrow(int position, ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.DownArrow:
                    position++;

                    break;
                case ConsoleKey.UpArrow:
                    position--;
                    break;
            }


            Console.SetCursorPosition(0, position);
            Console.WriteLine("-> ");
            return position;
        }

        public void ClearOrder()
        {
            zakaz = "";
            cost = 0;
        }
        
        public void Save()
        {
            File.AppendAllText("C:\\Users\\1111\\source\\repos\\практическая_5\\cake_story.txt", cost.ToString());
            File.AppendAllText("C:\\Users\\1111\\source\\repos\\практическая_5\\cake_story.txt", zakaz.ToString());
        }
    }
}
