using System;

namespace L01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Boolean
            //bool r1 = 123 < 456;
            //bool r2 = "mama" != "papa";

            //Console.WriteLine(r1);
            //Console.WriteLine(r2);

            //bool flag = false;

            //Console.WriteLine($"flag = {flag} !flag = {!flag}");

            /*
            & И
            | ИЛИ
            ^ Исключающее ИЛИ
            && Укороченное И
            || Укороченное ИЛИ
            ! НЕ
            */

            Console.WriteLine("Конъюнкция истина только когда оба истина");
            Console.WriteLine($"true && true = {true && true}");
            Console.WriteLine($"true && false = {true && false}");
            Console.WriteLine($"false && true = {false && true}");
            Console.WriteLine($"false && false = {false && false}\n");

            Console.WriteLine("Дизюнкция ложное только когда оба ложные");
            Console.WriteLine($"true || true = {true || true}");
            Console.WriteLine($"true || false = {true || false}");
            Console.WriteLine($"false || true = {false || true}");
            Console.WriteLine($"false || false = {false ||  false}\n");

            Console.WriteLine("Разделительная дизюнкция истина когда строго одно истина");
            Console.WriteLine($"true ^ true = {true ^ true}");
            Console.WriteLine($"true ^ false = {true ^ false}");
            Console.WriteLine($"false ^ true = {false ^ true}");
            Console.WriteLine($"false ^ false = {false ^ false}\n");
            int a = Convert.ToInt32(Console.ReadLine());

            float numb = 123.456789f;
            #endregion

            #region Primer 02
            //Console.Write("Enter number: ");
            //int valueA = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter number: ");
            //int valueB = int.Parse(Console.ReadLine());

            //int result = valueA + valueB;

            //Console.WriteLine(result);
            #endregion

            #region  Primer 01
            //var name1 = "Sergey";
            //var name2 = "Evgeni";
            //var name3 = "Vladimir";
            //var name4 = "Gosha";

            //Console.WriteLine(name1 + "!");
            //Console.WriteLine("{0}, {1}, {2}, {3}!", name1, name2, name3, name4);
            //Console.WriteLine($"{name1} {name2} {name3} {name4}");
            //Console.ReadKey();
            #endregion
        }
    }
}
