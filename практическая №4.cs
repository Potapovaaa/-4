namespace Практическая_работа_4
{
    internal class Program
    {
        public static ConsoleKeyInfo put;
        public static int a = 0;
        public static int poz = 2;
        public static int w = 0;
        public static int z = 0;
        public static int x = 0;
        static void Main(string[] args)
        {
            Switch2();
        }
        public static void zametka1()
        {
            List<string> zametki = new List<string>();
            zametki.Add("Выбрана дата 25.10.2022");
            zametki.Add("------------------------------------------");
            zametki.Add(" 1. Помыть посуду");
            zametki.Add(" 2. Покормить кота");
            w = zametki.Count;
            foreach (string item in zametki)
                Console.WriteLine(item);
        }
        public static void zametka2()
        {
            List<string> zametki = new List<string>();
            zametki.Add("Выбрана дата 26.10.2022");
            zametki.Add("------------------------------------------");
            zametki.Add(" 1. Прибраться в комнате");
            zametki.Add(" 2. Встретить сестру");
            z = zametki.Count;
            foreach (string item in zametki)
                Console.WriteLine(item);
        }
        public static void zametka3()
        {
            List<string> zametki = new List<string>();
            zametki.Add("Выбрана дата 27.10.2022");
            zametki.Add("------------------------------------------");
            zametki.Add(" 1. Сходить по магазинам");
            x = zametki.Count;
            foreach (string item in zametki)
                Console.WriteLine(item);
        }
        static void dopolnenie1()
        {
            List<string> podzametki = new List<string>();
            podzametki.Add("Помыть посуду");
            podzametki.Add("------------------------------------------");
            podzametki.Add("Описание: Помыть посуду до прихода мамы");
            podzametki.Add("Дата: 25.10.2022");
            foreach (string item in podzametki)
                Console.WriteLine(item);
        }
        static void dopolnenie1_1()
        {
            List<string> podzametki = new List<string>();
            podzametki.Add("Покормить кота");
            podzametki.Add("------------------------------------------");
            podzametki.Add("Описание: Покормить кота утром, в обед и вечер");
            podzametki.Add("Дата: 25.10.2022");
            foreach (string item in podzametki)
                Console.WriteLine(item);
        }
        static void dopolnenie2()
        {
            List<string> podzametki = new List<string>();
            podzametki.Add("Прибраться в своей комнате");
            podzametki.Add("------------------------------------------");
            podzametki.Add("Описание: Пропылесосить, помыть полы и вытереть пыль в своей комнате");
            podzametki.Add("Дата: 26.10.2022");
            foreach (string item in podzametki)
                Console.WriteLine(item);
        }
        static void dopolnenie2_1()
        {
            List<string> podzametki = new List<string>();
            podzametki.Add("Встретить сестру");
            podzametki.Add("------------------------------------------");
            podzametki.Add("Описание:Встретить сестру в 14:00 у вокзала");
            podzametki.Add("Дата: 26.10.2022");
            foreach (string item in podzametki)
                Console.WriteLine(item);
        }
        static void dopolnenie3()
        {
            List<string> podzametki = new List<string>();
            podzametki.Add("Сходить по магазинам");
            podzametki.Add("------------------------------------------");
            podzametki.Add("Описание: Сходить в пятерочку и купить молоко,хлеб и сметану");
            podzametki.Add("Дата: 27.10.2022");
            foreach (string item in podzametki)
                Console.WriteLine(item);
        }
        static void Switch()
        {
            Console.SetCursorPosition(0, poz);
            Console.Write("->");
            do
            {
                put = Console.ReadKey();
                if (put.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(0, poz--);
                    if (a == 0 && poz == 1)
                    {
                        poz++;
                    }
                    if (a == 1 && poz == 1)
                    {
                        poz++;
                    }
                    if (a == 2 && poz == 1)
                    {
                        poz++;
                    }
                    Console.Write("->");
                }
                else if (put.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(0, poz++);
                    if (a == 0 && poz == w)
                    {
                        poz--;
                    }
                    if (a == 1 && poz == z)
                    {
                        poz--;
                    }
                    if (a == 2 && poz == x)
                    {
                        poz--;
                    }
                    Console.Write("->");
                }
                Console.Write("\r" + new string(' ', 2) + "\r");
                Console.SetCursorPosition(0, poz);
                Console.Write("->");
            } while (put.Key == ConsoleKey.UpArrow | put.Key == ConsoleKey.DownArrow);
            if (put.Key == ConsoleKey.LeftArrow | put.Key == ConsoleKey.RightArrow)
            {
                switch (put.Key)
                {
                    case ConsoleKey.LeftArrow:
                        a--;
                        if (a == -1)
                            a = 2;
                        break;
                    case
                ConsoleKey.RightArrow:
                        a++;
                        if (a == 3)
                            a = 0;
                        break;
                }
                Switch2();
            }
            else if (put.Key == ConsoleKey.Enter)
            {
                Switch2();
            }
            if (put.Key == ConsoleKey.Escape)
            {
                return;
            }
        }
        static void Switch2()
        {
            Console.Clear();
            do
            {
                do
                {
                    if (a == 0 && poz == 2 && put.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        dopolnenie1();
                        put = Console.ReadKey();
                        if (put.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    else if (a == 0 && poz == 3 && put.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        dopolnenie1_1();
                        put = Console.ReadKey();
                        if (put.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    if (a == 1 && poz == 2 && put.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        dopolnenie2();
                        put = Console.ReadKey();
                        if (put.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    else if (a == 1 && poz == 3 && put.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        dopolnenie2_1();
                        put = Console.ReadKey();
                        if (put.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    if (a == 2 && poz == 2 && put.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        dopolnenie3();
                        put = Console.ReadKey();
                        if (put.Key ==
                        ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                } while (put.Key == ConsoleKey.Escape);
                switch (a)
                {
                    case 0:
                        Console.Clear();
                        zametka1();
                        Switch();
                        return;
                    case 1:
                        Console.Clear();
                        zametka2();
                        Switch();
                        return;
                    case 2:
                        Console.Clear();
                        zametka3();
                        Switch();
                        return;
                }
                put = Console.ReadKey();
                switch (put.Key)
                {
                    case ConsoleKey.LeftArrow:
                        a--;
                        switch (a)
                        {
                            case -1:
                                Console.Clear();
                                a = 2;
                                zametka3();
                                break;
                            case 0:
                                Console.Clear();
                                zametka1();
                                break;
                            case 1:
                                Console.Clear();
                                zametka2();
                                break;
                            case 2:
                                Console.Clear();
                                zametka3();
                                break;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        a++;
                        switch (a)
                        {
                            case 3:
                                Console.Clear();
                                a = 0;
                                zametka1();
                                break;
                            case 0:
                                Console.Clear();
                                zametka1();
                                break;
                            case 1:
                                Console.Clear();
                                zametka2();
                                break;
                            case 2:
                                Console.Clear();
                                zametka3();
                                break;
                        }
                        break;
                }
            } while (put.Key == ConsoleKey.LeftArrow | put.Key == ConsoleKey.RightArrow);
            if (put.Key == ConsoleKey.Escape)
            {
                return;
            }
        }
    }
}