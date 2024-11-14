using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  misal9
            //Misal9 m9 = new Misal9();
            //foreach (var item in m9.number3(120))
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            #region misal13
            //Misal13 m13 = new Misal13();           
            //Console.WriteLine(m13.ConvertWord("Salam Azerbaycan") );
            #endregion
            #region Misal1
            //int[] arr = { 1, 23, 454, 67, 788, 45, 34, 23, 23, 245, 5665, 7878, 78 };
            //Misal1 misal1 = new Misal1();
            //var a = misal1.GetList1(arr, 3);
            //foreach (int i in a)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion
            #region Misal3
            //Misal3<int, string> m3 = new Misal3<int, string>()
            //{First=125,
            //Second="QARABAQ AZERBAYCANDIR"
            //};
            //Misal3<string, double> mi3 = new Misal3<string, double>()
            //{
            //    First = "noutbook",
            //    Second = 1234.56
            //};
            //m3.Print();
            //mi3.Print();

            #endregion
            #region Misal4  
            //Misal4<int> m4 = new Misal4<int>();
            //var x = m4.GetCount3<int>(3);
            //Console.WriteLine(x);
            #endregion
            #region Misal6
            //Misal6 m6 = new Misal6();
            //m6.Print();
            #endregion
            #region Misal7
            //Misal7 m7 = new Misal7();
            //m7.Print();
            #endregion
            #region Misal8
            //MIsal8 m8 = new MIsal8();
            //m8.Print();
            #endregion
            #region Misal16
            //Misal16 m16 = new Misal16();
            //m16.elementsAdd(14);
            #endregion
            #region Misal5
            //CollectionWrapper<int> col = new CollectionWrapper<int>();
            //col.Add(13);
            //col.Add(14);
            //col.Add(16);
            //col.displyall();
            #endregion
            #region Misal19
            //object obj1 = 123;
            //int a=(int)obj1;
            #endregion
            #region Misal15;
            //int count = 0;
            //int[,] array = new int[3, 3]
            //{
            //    { 1, 2, 3 }
            //    ,{2,3,4 },
            //    {4,5,6 }
            //};
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        count += array[i, j];
            //    }
            //}

            //Console.WriteLine(count);

            #endregion
            #region Misal20
            //int count = 0;
            //int[] _arr = { 1, 25, 57, 32, 46, 68 };
            //for (int i = 0; i < _arr.Length; i++)
            //{
            //    if (_arr[i] % 2 == 0)
            //    {
            //        count++;
            //        if (count == 2)
            //        {
            //            Console.WriteLine(_arr[i]);
            //            break;
            //        }
            //    }
            //}

            #endregion
            #region Misal17
            //int i = (int)'a';
            //do
            //{
            //    Console.WriteLine((char)i);
            //    i++;
            //}while (i<(int)'z');
            #endregion
            #region Misal10
            Stack fn = new Stack();
            fn.Push("Altun");
            fn.Push("Miri");
            fn.Push("Ehmed");
            fn.Push("Qismet");

            foreach (var item in fn)
            {
                Console.WriteLine(item);
            }
            fn.Pop(); 
            fn.Peek();
            #endregion

        }
    }
}

