using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConstraintOfTheGererics
{

    class BaseClass
    {
        public int MyIntProperty { get; set; }
        public string MyStringProperty { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // Task 1



            //ArrayList lst = new ArrayList();
            //lst.Add(1);
            //lst.Add(25);
            //lst.Add("Hi");
            //lst.Add(new BaseClass());

            //for (int i = 0; i < lst.Count; i++)
            //{
            //    Console.WriteLine(lst[i]);
            //}



            // Task 2



            //var collect = new CarCollection<string>();

            //collect.AddCar("Jaguar", new DateTime(2005, 5, 7));
            //collect.AddCar("Mercedes-Benz", new DateTime(2007, 8, 9));
            //collect.AddCar("Ferrari", new DateTime(2021, 4, 5));
            //collect.AddCar("Lamborghini", new DateTime(2022, 4, 6));

            //Console.WriteLine(collect.ToString());

            //Console.WriteLine(collect.Lenght);

            //collect.Clear();



            // Task 3



            //var dict = new Dictionary<string, string>();

            //dict.AddToDictionary("spring", "windy");
            //dict.AddToDictionary("hello", "bye");
            //dict.AddToDictionary("nice", "bad");

            //Console.WriteLine(dict.ToString());

            //string str = "hello";
            //Console.WriteLine(dict[str]);


            // Task 4


            //var ls = new MyList<int>();

            //ls.Add(1);
            //ls.Add(2);
            //ls.Add(3);
            //ls.Add(4);
            //ls.Add(5);

            //Console.WriteLine(ls.ToString());

            //Console.WriteLine(ls.Contains(6));

            //Console.WriteLine(ls.Count);

            //for(int i = 0; i < ls.Count; i++)
            //{
            //    Console.WriteLine(ls[i]);
            //}
        }
    }
}
