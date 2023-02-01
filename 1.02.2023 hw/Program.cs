using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1._02._2023_hw
{
    internal class Program
    {
        static void EndErr(int code)
        {
            Console.WriteLine("Error Task " + code);
            Console.ReadKey();
            Environment.Exit(code);
        }
        static void EndIfNotInt(string s, out int o, int code)
        {
            if (!(int.TryParse(s, out o))) EndErr(code);
        }

        static void Main(string[] args)
        {
            #region Task 1
            //Console.Write("Write num: ");
            //string num_1 = Console.ReadLine();
            //EndIfNotInt(num_1, out int num_out_1, 1);
            //if (num_out_1 < 0 || num_out_1 > 100) EndErr(1);

            //if ((num_out_1 % 3) == 0) Console.Write("Fizz ");
            //if ((num_out_1 % 5) == 0) Console.Write("Buzz");
            //Console.Write('\n');
            #endregion

            #region Task 2
            //Console.Write("Write num: ");
            //string num_2 = Console.ReadLine();
            //EndIfNotInt(num_2, out int num_out_2, 2);

            //Console.Write("Write proc: ");
            //string proc_1 = Console.ReadLine();
            //EndIfNotInt(proc_1, out int proc_out_1, 2);
            //if (proc_out_1 < 0 || proc_out_1 > 100) EndErr(2);

            //Console.Write("Answer " + num_out_2 * (proc_out_1 / 100.0));
            #endregion

            #region Task 3
            //int ans_2 = 0;
            //const int num_count = 4;

            //for (int i = 1; i < num_count + 1; i++)
            //{
            //    Console.Write($"Write num {i}: ");
            //    string num_2 = Console.ReadLine();
            //    EndIfNotInt(num_2, out int num_out_2, 3);
            //    ans_2 += num_out_2 * (int)Math.Pow(10, i);
            //}

            //Console.Write("Answer: " + ans_2);
            #endregion

            #region Task 4
            const int len = 6;

            //Console.Write("Write num: ");
            //string num_4 = Console.ReadLine();
            //EndIfNotInt(num_4, out int num_out_4, 4);

            //Console.Write("Write first index: ");
            //string left_4 = Console.ReadLine();
            //EndIfNotInt(left_4, out int left_out_4, 4);
            //if (left_out_4 < 0 || left_out_4 > len) EndErr(4);

            //Console.Write("Write second index: ");
            //string right_4 = Console.ReadLine();
            //EndIfNotInt(right_4, out int right_out_4, 4);
            //if (right_out_4 < 0 || right_out_4 > len) EndErr(4);

            //for (int i = 0; i < len; i++)
            //{
            //    if (i == left_out_4) Console.Write(num_4[right_out_4]);
            //    else if (i == right_out_4) Console.Write(num_4[left_out_4]);
            //    else Console.Write(num_4[i]);
            //}
            #endregion

            #region Task 5
            //Console.Write("Write year: ");
            //string year_5 = Console.ReadLine();
            //EndIfNotInt(year_5, out int year_out_5, 5);

            //Console.Write("Write month: ");
            //string month_5 = Console.ReadLine();
            //EndIfNotInt(month_5, out int month_out_5, 5);

            //Console.Write("Write day: ");
            //string day_5 = Console.ReadLine();
            //EndIfNotInt(day_5, out int day_out_5, 5);

            //DateTime date_5 = new DateTime(year_out_5, month_out_5, day_out_5);
            //switch (month_out_5)
            //{
            //    case 1: Console.Write("January"); break;
            //    case 2: Console.Write("February"); break;
            //    case 3: Console.Write("March"); break;
            //    case 4: Console.Write("April"); break;
            //    case 5: Console.Write("May"); break;
            //    case 6: Console.Write("June"); break;
            //    case 7: Console.Write("July"); break;
            //    case 8: Console.Write("August"); break; 
            //    case 9: Console.Write("September"); break; 
            //    case 10: Console.Write("October"); break;
            //    case 11: Console.Write("November"); break; 
            //    case 12: Console.Write("December"); break;
            //}
            //Console.WriteLine(date_5.DayOfWeek);
            #endregion

            #region Task 6
            //Console.Write("Write type system: ");
            //string type = Console.ReadLine();
            //if (type != "Far" && type != "Zhel") EndErr(6);

            //Console.Write("Write month: ");
            //string num_6 = Console.ReadLine();
            //EndIfNotInt(num_6, out int num_out_6, 6);

            //if (type == "Far")
            //{
            //    Console.WriteLine((num_out_6 - 32.0) * 5.0 / 9);
            //}
            //else if (type == "Zhel")
            //{
            //    Console.WriteLine((num_out_6 * 9.0 / 5) + 32);
            //}
            #endregion

            #region Task 7
            //Console.Write("Write num 1: ");
            //string num1_7 = Console.ReadLine();
            //EndIfNotInt(num1_7, out int num1_out_7, 7);

            //Console.Write("Write num 2: ");
            //string num2_7 = Console.ReadLine();
            //EndIfNotInt(num2_7, out int num2_out_7, 7);

            //if (num1_out_7 > num2_out_7) (num1_out_7, num2_out_7) = (num2_out_7, num1_out_7);

            //for (int i = num1_out_7 + num1_out_7 % 2; i < num2_out_7; i += 2) 
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            Console.ReadKey();
        }
    }
}
