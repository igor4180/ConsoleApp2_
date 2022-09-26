using System;


namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //    Console.WriteLine("Введите число:");
            //    int number = 0;
            //    do
            //    {
            //        try
            //        {
            //            number = Int32.Parse(Console.ReadLine());
            //            if (number < 0 || number > 100)
            //            {
            //                throw new Exception();
            //            }
            //        }
            //        catch (Exception)
            //        {
            //            Console.WriteLine("Попробуйте снова!");
            //        }
            //    } while (number < 0 || number > 100);
            //    number = Int32.Parse(Console.ReadLine());
            //    for (int i = 0; i < 100; i++) ;
            //    {
            //        if (number % 3 == 0) Console.WriteLine("Fizz");
            //        if (number % 5 == 0) Console.WriteLine("Buzz");
            //        if (number % 3 != 0 && number % 5 != 0) Console.WriteLine(number);
            //        if (number % 3 == 0 && number % 5 == 0) Console.WriteLine("Fizz Buzz");
            //        return;
            //    }
            #endregion

            #region Task2

            //int number = 0;
            //int percent = 0;

            //Console.WriteLine("Введите число: ");
            //try
            //{
            //    number = Int32.Parse(Console.ReadLine());
            //    Console.WriteLine("Введите число для процента: ");
            //    percent = Int32.Parse(Console.ReadLine());
            //    int result = number * percent / 100;
            //    Console.WriteLine("Результат вычисления: {0}", result);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Вы ввели неверные символы! Введите число");

            //}
            #endregion

            #region Task3
            //double num1, num2, num3, num4;
            //int result; 

            //Console.WriteLine("Введите 1 цифру");
            //num1 = Double.Parse(Console.ReadLine());
            //Console.WriteLine("Введите 2 цифру");
            //num2 = Double.Parse(Console.ReadLine());
            //Console.WriteLine("Введите 3 цифру");
            //num3 = Double.Parse(Console.ReadLine());
            //Console.WriteLine("Введите 4 цифру");
            //num4 = Double.Parse(Console.ReadLine());

            //result = (int)num1 * 1000 + (int)num2 * 100 + (int)num3 * 10 + (int)num4;
            //Console.WriteLine("Полученный результат = {0}", result);
            #endregion


            #region Task6

            //double f, c;
            //Console.WriteLine("Введите значения Цельсия");
            //c = Convert.ToDouble(Console.ReadLine());
            //f = c * 9 / 5 + 32;
            //Console.WriteLine(c + "Градус Цельсия в Фаренгейт" + f + "F");

            //Console.WriteLine("Введите значение Фаренгейта");
            //f = Convert.ToDouble(Console.ReadLine());
            //c = (f - 32) * 5 / 9;
            //Console.WriteLine(f + "Фаренгейт в Цельсий" + c + "C");
            //c = (f - 32) * 5 / 9;
            //Console.WriteLine(f + "f в Цельсий" + c + "C");
            //Console.ReadLine();
            #endregion


        }




    }

}
