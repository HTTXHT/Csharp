using System;
using System.Security.Permissions;
using System.Xml.Linq;

namespace helloCS     //命名空间
{
 
    class Program   //类型 
    {
        
        static void Main()    //函数，方法
        {

            GetUserInfo();



            Console.ReadKey();
        }




        static void GetUserInfo()
        {
            //名称收集
            Console.WriteLine("请输入你的姓名");
            string name = Console.ReadLine();
            Console.WriteLine();

            //家乡收集
            Console.WriteLine("请输入你的故乡");
            string address = Console.ReadLine();
            Console.WriteLine();

            //收集爱好
            Console.WriteLine("请输入你的爱好");
            string aihao = Console.ReadLine();
            Console.WriteLine();


            name = ChangeData(name);


            //按格式输出
            Console.WriteLine("你的名字是:" + name);
            Console.WriteLine("你的故乡是:" + address);
            Console.WriteLine("你的爱好是:" + aihao);
        }




        static string  ChangeData(string name)
        {
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

            return name;
        }


    }
}



