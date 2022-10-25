using System;
using System.Reflection;
using System.Text;
namespace Ежедневник
{
    internal class Program
    {
        public static ConsoleKeyInfo put;
        public static int a = 0;
        public static int position = 2;
        public static int w = 0;
        public static int z = 0;
        public static int x = 0;

       
        static void Main(string[] args)
        {
            Perekluchenie_0();
        }
        static void colorconsole()
        {
            System.Console.ForegroundColor = ConsoleColor.Green;
        }
        static void Perekluchenie_1()
        {
            Console.SetCursorPosition(0, position);
            Console.Write("->");
            do
            {
                put = Console.ReadKey();
                if (put.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(0, position--);
                    if (a == 0 && position == 1)
                    {
                        position++;
                    }
                    if (a == 1 && position == 1)
                    {
                        position++;
                    }
                    if (a == 2 && position == 1)
                    {
                        position++;
                    }
                    Console.Write("->");
                }
                else if (put.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(0, position++);
                    if (a == 0 && position == w)
                    {
                        position--;
                    }
                    if (a == 1 && position == z)
                    {
                        position--;
                    }
                    if (a == 2 && position == x)
                    {
                        position--;
                    }
                    Console.Write("->");
                }
                Console.Write("\r" + new string(' ', 2) + "\r");
                Console.SetCursorPosition(0, position);
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
                    case ConsoleKey.RightArrow:
                        a++;
                        if (a == 3)
                            a = 0;
                        break;
                }
                Perekluchenie_0();
            }
            else if (put.Key == ConsoleKey.Enter)
            {
                Perekluchenie_0();
            }
            if (put.Key == ConsoleKey.Escape)
            {
                return;
            }
        }
        public static void zametkaone()
        {
            List<string> zametki = new List<string>();
            zametki.Add("Выбрана дата 25.10.2022");
            zametki.Add("------------------------------------------");
            zametki.Add(" 1. Сходить в магазин");
            zametki.Add(" 2. Покормить кота");
            w = zametki.Count;
            foreach (string item in zametki)
                Console.WriteLine(item);
        }
        public static void zametkatwo()
        {
            List<string> zametki = new List<string>();
            zametki.Add("Выбрана дата 26.10.2022");
            zametki.Add("------------------------------------------");
            zametki.Add(" 1. Убраться в комнате");
            zametki.Add(" 2. Встерить сестру");
            z = zametki.Count;
            foreach (string item in zametki)
                Console.WriteLine(item);
        }
        public static void zametkathree()
        {
            List<string> zametki = new List<string>();
            zametki.Add("Выбрана дата 27.10.2022");
            zametki.Add("------------------------------------------");
            zametki.Add(" 1. Сходить в кино");
            x = zametki.Count;
            foreach (string item in zametki)
                Console.WriteLine(item);
        }
        static void dopolnenie1()
        {
            List<string> podzametki = new List<string>();
            podzametki.Add("Сходить в магазин");
            podzametki.Add("------------------------------------------");
            podzametki.Add("Описание: Сходить в пятерочку и купить:молоко,сметану и хлеб");
            podzametki.Add("Дата: 25.10.2022");
            foreach (string item in podzametki)
                Console.WriteLine(item);
        }
        static void dopolnenie1_1()
        {
            List<string> podzametki = new List<string>();
            podzametki.Add("Покормить кота");
            podzametki.Add("------------------------------------------");
            podzametki.Add("Описание: Покормить Барсика утром, в обед и вечер");
            podzametki.Add("Дата: 25.10.2022");
            foreach (string item in podzametki)
                Console.WriteLine(item);
        }
        static void dopolnenie2()
        {
            List<string> podzametki = new List<string>();
            podzametki.Add("Убраться в комнате");
            podzametki.Add("------------------------------------------");
            podzametki.Add("Описание: Пропылесосить ,вытереть пыль и помыть полы в своей комнате");
            podzametki.Add("Дата: 26.10.2022");
            foreach (string item in podzametki)
                Console.WriteLine(item);
        }
        static void dopolnenie2_1()
        {
            List<string> podzametki = new List<string>();
            podzametki.Add("Встретить сестру");
            podzametki.Add("------------------------------------------");
            podzametki.Add("Описание: Встретить настю в аэропорту в 14:00");
            podzametki.Add("Дата: 26.10.2022");
            foreach (string item in podzametki)
                Console.WriteLine(item);
        }
        static void dopolnenie3()
        {
            List<string> podzametki = new List<string>();
            podzametki.Add("Сходить в кино");
            podzametki.Add("------------------------------------------");
            podzametki.Add("Описание: Сходить в ДК ЧАЙКУ  на фильм Красная шапочка с Денисом и Юлей в 18:30");
            podzametki.Add("Дата: 27.10.2022");
            foreach (string item in podzametki)
                Console.WriteLine(item);
        }
        static void Perekluchenie_0()
        {
            Console.Clear();
            do
            {
                do
                {
                    if (a == 0 && position == 2 && put.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        dopolnenie1();
                        put = Console.ReadKey();
                        if (put.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    else if (a == 0 && position == 3 && put.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        dopolnenie1_1();
                        put = Console.ReadKey();
                        if (put.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    if (a == 1 && position == 2 && put.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        dopolnenie2();
                        put = Console.ReadKey();
                        if (put.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    else if (a == 1 && position == 3 && put.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        dopolnenie2_1();
                        put = Console.ReadKey();
                        if (put.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    if (a == 2 && position == 2 && put.Key == ConsoleKey.Enter)
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
                        zametkaone();
                        Perekluchenie_1();
                        return;
                    case 1:
                        Console.Clear();
                        zametkatwo();
                        Perekluchenie_1();
                        return;
                    case 2:
                        Console.Clear();
                        zametkathree();
                        Perekluchenie_1();
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
                                zametkatwo();
                                break;
                            case 0:
                                Console.Clear();
                                zametkaone();
                                break;
                            case 1:
                                Console.Clear();
                                zametkatwo();
                                break;
                            case 2:
                                Console.Clear();
                                zametkathree();
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
                                zametkaone();
                                break;
                            case 0:
                                Console.Clear();
                                zametkaone();
                                break;
                            case 1:
                                Console.Clear();
                                zametkatwo();
                                break;
                            case 2:
                                Console.Clear();
                                zametkatwo();
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