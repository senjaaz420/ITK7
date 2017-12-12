using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tripak
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10; // число эл-тов массива 
            Random rnd = new Random(DateTime.Now.Millisecond);
            double[] array = new double[n];
            for (int i = 0; i < n; i++)
                array[i] = 50 - rnd.NextDouble() * 100; // заполняем случайными числами от -50 до 50 

            double a = 0, b = 5; // здесь сделайте ввод чисел a и b 
            int count = array.Count(x => x >= a && x <= b); // количество элементов массива, лежащих в диапазоне от А до В; 
            int maxIndex = Array.IndexOf(array, array.Max(), 0, array.Count()); // индекс максимального элемента 
            double summ = 0; // переменная под сумму 
            for (int i = maxIndex + 1; i < n; i++)
                summ += array[i]; // считает сумму элементов массива, расположенных после максимального элемента. 

            // Упорядочить элементы массива по убыванию модулей. После этой строки в array будет нужный вам порядок чисел 
            Array.Sort(array, (x1, x2) => -1 * Math.Abs(x1).CompareTo(Math.Abs(x2)));
            Console.WriteLine("Количество элементов от A до Б "+ count);
            Console.WriteLine("Сумма элементов "+summ);
            Console.ReadKey();
        }
    }
}
