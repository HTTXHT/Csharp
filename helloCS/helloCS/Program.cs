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
            Console.WriteLine();

            if (name == "张三")
            {
                Console.WriteLine("你输入的是张三");
                name = "法外狂徒张三";

            }
            else if (name == "李四")
            {
                Console.WriteLine("你输入的是李四");
                name = "李四大傻逼";
            }  
            else
            {
                Console.WriteLine("你输入的是" + name);
            }
            Console.WriteLine();
        

            //家乡收集
            Console.WriteLine("请输入你的故乡");
            string address = Console.ReadLine();
            Console.WriteLine();

            //收集爱好
            Console.WriteLine("请输入你的爱好");
            string aihao = Console.ReadLine();
            Console.WriteLine();

            //按格式输出
            Console.WriteLine("你的名字是:" + name);
            Console.WriteLine("你的故乡是:" + address);
            Console.WriteLine("你的爱好是:" + aihao);

            Console.ReadKey();

        }
    }
}



