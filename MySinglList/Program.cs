using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySinglList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglList MyList = new SinglList(3, new SinglList(5, new SinglList(9)));
            Console.WriteLine("Список:");
            MyList.ShowList();

            Console.Write("Значение нового элемента для вставки: "); int NewValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Позиция нового элемента для вставки: "); int Pos = Convert.ToInt32(Console.ReadLine());
            MyList.PastIn(NewValue, Pos);

            Console.WriteLine("Список:");
            MyList.ShowList();

            Console.Write("Позиция элемента для удаления: "); Pos = Convert.ToInt32(Console.ReadLine());
            MyList.Delete(Pos);

            Console.WriteLine("Список:");
            MyList.ShowList();

            Console.Write("Позиция элемента для получения: "); Pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MyList.GetValue(Pos));

            Console.ReadKey();
        }
    }
}
