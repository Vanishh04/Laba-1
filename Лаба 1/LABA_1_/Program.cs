using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace LABA_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать");
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - Загрузить последний сохраненный прямоугольник");
            Console.WriteLine("2 - Создать новый");

            int status1 = 1;

            while (status1 != 0)
            {
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        var abcd3 = JsonConvert.DeserializeObject<Rectangle>(File.ReadAllText("Rectangle.json"));

                        Console.WriteLine("Координаты точек прямоугольника:");
                        Console.WriteLine("Точка А(" + abcd3.X + "," + abcd3.Y + ")");
                        Console.WriteLine("Точка B(" + abcd3.X + "," + (abcd3.Y + abcd3.Width) + ")");
                        Console.WriteLine("Точка C(" + (abcd3.X + abcd3.Height) + "," + abcd3.Y + ")");
                        Console.WriteLine("Точка D(" + (abcd3.X + abcd3.Height) + "," + (abcd3.Y + abcd3.Width) + ")");
                        Console.WriteLine();
                        Console.WriteLine("Выберите действие:");
                        Console.WriteLine("1 - Загрузить последний сохраненный прямоугольник");
                        Console.WriteLine("2 - Создать новый");

                        break;
                    case 2: status1 = 0; break;
                    default: Console.WriteLine("Введите корректное значение"); break;
                }
            }



            Console.WriteLine("Для построения прямоугольника введите три параметра: левая нижняя точка, ширина и высота");
            Console.Write("Введите значение координаты Х: ");
            int x = int.Parse(Console.ReadLine()); Console.WriteLine();
            Console.Write("Введите значение координаты У: ");
            int y = int.Parse(Console.ReadLine()); Console.WriteLine();
            Console.Write("Введите значение высоты: ");
            int height = int.Parse(Console.ReadLine()); Console.WriteLine();
            Console.Write("Введите значение ширины: ");
            int width = int.Parse(Console.ReadLine()); Console.WriteLine();

            Rectangle abcd = new Rectangle(x, y, height, width);


            Console.WriteLine("Координаты прямоугольника ABCD: ");
            abcd.Show(x, y, height, width);

            Console.WriteLine("Перед вами список с операциями номерами , относительно прямоугольника ABCD:");
            Console.WriteLine("1 - Передвижение по координатной плоскости ");
            Console.WriteLine("2 - Изменение размеров прямоугольника");
            Console.WriteLine("3 - Построение прямоугольника,что объеденяет два заданных:");
            Console.WriteLine("4 - Сохранить прямоугольник");
            Console.WriteLine("5 - Выход");

            Console.Write("Введите номер действия: ");

            Console.WriteLine();

            int status2 = 1;
            while (status2 != 0)
            {
                int b = int.Parse(Console.ReadLine());
                switch (b)
                {
                    case 1:
                        Console.Write("На сколько единиц хотите поднять/опустить значение параметра Х: ");
                        int l = int.Parse(Console.ReadLine());
                        Console.Write("На сколько единиц хотите поднять/опустить значение параметра Y: ");
                        int h = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        abcd.Moving(l, h,  x,  y);
                        Console.WriteLine();
                        Console.WriteLine("Перед вами список с операциями номерами , относительно прямоугольника ABCD:");
                        Console.WriteLine("1 - Передвижение по координатной плоскости ");
                        Console.WriteLine("2 - Изменение размеров прямоугольника");
                        Console.WriteLine("3 - Построение прямоугольника,что объеденяет два заданных:");
                        Console.WriteLine("4 - Сохранить прямоугольник");
                        Console.WriteLine("5 - Выход");

                        break;
                    case 2:
                        Console.Write("На сколько единиц хотите изменить значение параметра ширины: ");
                        int dx = int.Parse(Console.ReadLine());
                        Console.Write("На сколько единиц хотите изменить значение параметра высоты: ");
                        int dy = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        abcd.Size_change(dx, dy,   height,   width);
                        Console.WriteLine();
                        Console.WriteLine("Перед вами список с операциями номерами , относительно прямоугольника ABCD:");
                        Console.WriteLine("1 - Передвижение по координатной плоскости ");
                        Console.WriteLine("2 - Изменение размеров прямоугольника");
                        Console.WriteLine("3 - Построение прямоугольника,что объеденяет два заданных:");
                        Console.WriteLine("4 - Сохранить прямоугольник");
                        Console.WriteLine("5 - Выход");
                        break;
                    case 3:
                        Console.WriteLine("Для условия надо создать второй прямоугольник: введите параметры нижней левой точки, высоты и ширины");
                        Console.Write("Введите значение координаты Х: ");
                        int x2 = int.Parse(Console.ReadLine()); Console.WriteLine();
                        Console.Write("Введите значение координаты У: ");
                        int y2 = int.Parse(Console.ReadLine()); Console.WriteLine();
                        Console.Write("Введите значение высоты: "); Console.WriteLine();
                        int height2 = int.Parse(Console.ReadLine());
                        Console.Write("Введите значение ширины: "); Console.WriteLine();
                        int width2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Координаты прямоугольника А1B1C1D1:");
                        abcd.Show(x2, y2, height2, width2);
                        abcd.Union_TwoRectangles(x, y, height, width, x2, y2, height2, width2);
                        Console.WriteLine();
                        Console.WriteLine("Перед вами список с операциями номерами , относительно прямоугольника ABCD:");
                        Console.WriteLine("1 - Передвижение по координатной плоскости ");
                        Console.WriteLine("2 - Изменение размеров прямоугольника");
                        Console.WriteLine("3 - Построение прямоугольника,что объеденяет два заданных:");
                        Console.WriteLine("4 - Сохранить прямоугольник");
                        Console.WriteLine("5 - Выход");
                        break;
                    case 4:
                        abcd.Save(x, y, height, width);
                        Console.WriteLine("Вы сохранили прямоугольник");
                        Console.WriteLine();
                        Console.WriteLine("Перед вами список с операциями номерами , относительно прямоугольника ABCD:");
                        Console.WriteLine("1 - Передвижение по координатной плоскости ");
                        Console.WriteLine("2 - Изменение размеров прямоугольника");
                        Console.WriteLine("3 - Построение прямоугольника,что объеденяет два заданных:");
                        Console.WriteLine("4 - Сохранить прямоугольник");
                        Console.WriteLine("5 - Выход");
                        break;
                    case 5:
                        Console.WriteLine("До свидания"); status2 = 0;
                        break;
                    default: Console.WriteLine("Введите корректное значение"); break;
                }

            }

        }
    }

    public class Rectangle
    {
        public int X, Y, Height, Width;
        public static bool brake = false;

        public Rectangle()
        {

        }

        public Rectangle(int x, int y, int height, int width)
        {
            X = x;
            Y = y;
            Height = height;
            Width = width;

        }

        public void Save(int x, int y, int height, int width)
        {
            Rectangle abcd2 = new Rectangle(x, y, height, width);
            File.WriteAllText("Rectangle.json", JsonConvert.SerializeObject(abcd2));
        }

        public void Load()
        {
            JsonConvert.DeserializeObject<Rectangle>(File.ReadAllText("Rectangle.json"));

        }

        public void Moving(int l, int h, int x,  int y)
        {
            x = x + l;
            y = y + h;

            Console.WriteLine("Координаты точек прямоугольника после передвижения вдоль координатной площади:");
            Console.WriteLine("Точка А(" + x + "," + y + ")");
            Console.WriteLine("Точка B(" + x + "," + (y + Width) + ")");
            Console.WriteLine("Точка C(" + (x + Height) + "," + y + ")");
            Console.WriteLine("Точка D(" + (x + Height) + "," + (y + Width) + ")");
        }

        public void Size_change(int x, int y,  int height,  int width)
        {
            height = height - y;
            width = width - x;

            Console.WriteLine("Координаты точек прямоугольника после изменения его размеров:");
            Console.WriteLine("Точка А(" + x + "," + y + ")");
            Console.WriteLine("Точка B(" + x + "," + (y + width) + ")");
            Console.WriteLine("Точка C(" + (x + height) + "," + y + ")");
            Console.WriteLine("Точка D(" + (x + height) + "," + (y + width) + ")");
        }

        public void Show(int x, int y, int height, int width)
        {
            Console.WriteLine("Координаты точек прямоугольника:");
            Console.WriteLine("Точка А(" + x + "," + y + ")");
            Console.WriteLine("Точка B(" + x + "," + (y + width) + ")");
            Console.WriteLine("Точка C(" + (x + height) + "," + y + ")");
            Console.WriteLine("Точка D(" + (x + height) + "," + (y + width) + ")");
        }

        public void Union_TwoRectangles(int x1, int y1, int height1, int width1, int x2, int y2, int height2, int width2)
        {
            if (x1 > x2)
            {
                int a = x1;
                x1 = x2;
                x2 = a;
            }

            if (x1 + width1 < x2 + width2)
            {
                X = x1;
                Width = x2 - x1 + width2;
            }
            else
            {
                X = x1;
                Width = width2;
            }

            if (y1 > y2)
            {
                int a = y1;
                y1 = y2;
                y2 = a;
            }

            if (y1 + height1 < y2 + height2)
            {
                Y = y1;
                Height = y2 - y1 + height2;
            }
            else
            {
                Y = y1;
                Height = height2;
            }
            Console.WriteLine("Координаты объеденяющего прямоугольника:");
            Console.WriteLine("Точка А(" + X + "," + Y + ")");
            Console.WriteLine("Точка B(" + X + "," + (Y + Width) + ")");
            Console.WriteLine("Точка C(" + (X + Height) + "," + Y + ")");
            Console.WriteLine("Точка D(" + (X + Height) + "," + (Y + Width) + ")");

        }

    }

}
