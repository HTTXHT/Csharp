﻿using System;
using System.Security.Permissions;
using System.Xml.Linq;

namespace helloCS     //命名空间
{
 
    class Program   //类型 
    {
        
        static void Main()    //函数，方法
        {
            string name = "";
            PanDuan(name);
            Console.WriteLine("录入结束");
        }


        static void PanDuan(string name)
        {
            //bool bool1 = (name != "法外狂徒张三");
            for (int i=0; i<1;i++)
            {
                GetUserInfo(name);
                Console.WriteLine("继续下一个录入");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
           
        }


        static string  GetUserInfo(string name)
        {
            //名称收集
            Console.WriteLine("请输入你的姓名");
            name = Console.ReadLine();

            //家乡收集
            Console.WriteLine("请输入你的故乡");
            string address = Console.ReadLine();

            //收集爱好
            Console.WriteLine("请输入你的爱好");
            string aihao = Console.ReadLine();
            Console.WriteLine();
          

            name = ChangeData(name);


            //按格式输出
            Console.WriteLine("故乡:" + address);
            Console.WriteLine("爱好:" + aihao);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            return name;


        }




        static string  ChangeData(string name)
        {
            if (name == "张三")
            {
                name = "法外狂徒张三";
                Console.WriteLine("姓名:" + name);
            }
            else if (name == "李四")
            {
                name = "李四大傻逼";
                Console.WriteLine("姓名:" + name);
            }
            else
            {
                Console.WriteLine("姓名:" + name);
            }
            

            return name;
        }


    }
}



