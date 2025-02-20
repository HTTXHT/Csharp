using System;
using System.Security.Permissions;
//命名空间
namespace helloCS
{
    //类型 
    class Program
    {
        //函数，方法
        static void Main()
        {
            //名称收集
            Console.WriteLine("请输入你的姓名");
            string name = Console.ReadLine();
            //家乡收集
            Console.WriteLine("请输入你的故乡");
            string address = Console.ReadLine();
            //收集爱好
            Console.WriteLine("请输入你的爱好");
            string aihao = Console.ReadLine();
            //按格式输出
        
            Console.WriteLine("你的名字是:" + name);
            Console.WriteLine("你的故乡是:" + address);
            Console.WriteLine("你的爱好是:" + aihao);


            Console.ReadKey();

        }
    }
}
