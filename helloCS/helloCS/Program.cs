using System;
//命名空间
namespace helloCS
{
    //类型 
    class Program
    {
        //函数，方法
        static void Main()
        {


         Console.WriteLine("请输入一个数字：");
            string str = Console.ReadLine();
                                             
            int num = int.Parse(str) + 20;
            Console.WriteLine(num);

            Console.ReadKey();   
          
        }
    }
}
