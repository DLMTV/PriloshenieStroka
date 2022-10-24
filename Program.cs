

namespace UnitApp;

public class Program
{
    public static void Main()
    {
        string text;
        string a;
        string b;
        double Number;
        double Result; 
        int intLenght = Int32.MaxValue.ToString().Length;

        do
        {
            Console.WriteLine("Введите строку: ");
            text = Console.ReadLine();
            if (text is null || text == "") Console.WriteLine("Вы ничего не ввели!!");
        } while (text is null || text == "");

        if (text != null || text != "")
        {
            Console.WriteLine("Вы ввели: " + text);
        }

        if (text == "ololo")
        {
            do
            {
                Console.WriteLine("Введите два числа мы рассчитаем их сумму.");
                Console.WriteLine("Введите первое число: ");
                a = Console.ReadLine();
                if (a is null || a == "") Console.WriteLine("Вы ничего не ввели!!");
                else if (false == double.TryParse(a, out Number)) Console.WriteLine("Вы ввели не цифры!!");
                else
                {
                    var tryParse = (double.TryParse(a, out Number));
                }

                if (a.Length >= intLenght - 1)
                    Console.WriteLine($"Вы ввели очень длинное значение. Больше, чем {intLenght - 1}");
            } while (a == "" || false == double.TryParse(a, out Number) || (a.Length >= intLenght - 1));

            do
            {
                Console.WriteLine("Введите второе число: ");
                b = Console.ReadLine();
                if (b is null || b == "") Console.WriteLine("Вы ничего не ввели!!");
                else if (false == double.TryParse(b, out Number)) Console.WriteLine("Вы ввели не цифры!!");
                else
                {
                    var tryParse = (double.TryParse(b, out Number));
                }

                if (b.Length >= intLenght - 1)
                    Console.WriteLine($"Вы ввели очень длинное значение. Больше, чем {intLenght - 1}");
            } while (b == "" || false == double.TryParse(b, out Number) || (b.Length >= intLenght - 1));

            Result = Convert.ToDouble(a) + Convert.ToDouble(b);
            Console.WriteLine("Сумма двух чисел равна: " + Result);
        }
    }