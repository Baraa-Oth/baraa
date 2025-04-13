using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp120
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            Console.WriteLine("أدخل 10 أرقام:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"رقم {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("إدخال غير صحيح، يرجى إدخال رقم صحيح.");
                }
            }

            // العمليات الحسابية
            int sum = numbers.Sum();
            double average = numbers.Average();
            int max = numbers.Max();
            int min = numbers.Min();

            // ترتيب المصفوفة تصاعديًا
            Array.Sort(numbers);

            // طباعة النتائج
            Console.WriteLine("\n--- النتائج ---");
            Console.WriteLine($"المجموع: {sum}");
            Console.WriteLine($"المتوسط: {average}");
            Console.WriteLine($"أكبر عدد: {max}");
            Console.WriteLine($"أصغر عدد: {min}");
            Console.WriteLine("الأرقام مرتبة تصاعديًا: " + string.Join(", ", numbers));
        }

    }
}
}
