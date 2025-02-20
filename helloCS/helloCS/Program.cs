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
            //变量类型 变量名 = 值

            int n = 100;
            int m = 200;
            int sum = 0;
            sum = n + m;
            string name = "你的计算结果是：";

            Console.WriteLine(name);
            Console.WriteLine(sum);
           
            Console.ReadKey();
        }
    }
}
