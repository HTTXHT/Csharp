using System;
using System.Runtime.InteropServices;

namespace wodekongjian     //命名空间
{

    class Program   //类型 
    {

        static void Main()    //函数，方法
        {
            Console.WriteLine("月黑风高杀人夜");
            Console.WriteLine("请按任意键继续");
            Console.ReadKey();

            Console.WriteLine("江湖路远无归客。");
            Console.WriteLine("请按任意键继续");
            Console.ReadKey();

            Console.WriteLine("少侠，你好！");
            Console.WriteLine("请按任意键继续");
            Console.ReadKey();

            Console.WriteLine("请输入名称：");
            string  mingzi= Console.ReadLine();
            Console.WriteLine("原来你就是传说中的" + mingzi + "大侠！");

            Console.WriteLine("请按任意键继续");
            Console.ReadKey();
           
            string xingbie = "男";
            int  nianling = "18";
            int shenggao = "175";
            int gongji = "10";
            int xueliang = "100";
            string jineng1 = "飞沙走石";
            int jineng1gongji = "20";
            string jineng2 = "千里冰封";
            int jineng2gongji = "50";

            Console.WriteLine("属性面板");
            Console.WriteLine( "性别:" + xingbie);
            Console.WriteLine("年龄:" + nianling);
            Console.WriteLine("身高:" + shenggao);
            Console.WriteLine("攻击力:" + gongji);
            Console.WriteLine("血量:" + xueliang);
            Console.WriteLine("技能1:" + jineng1);
            Console.WriteLine("技能1攻击力:" + jineng1gongji);
            Console.WriteLine("技能2:" + jineng2);
            Console.WriteLine("技能2攻击力:" + jineng2gongji);


            Console.WriteLine("请按任意键继续");
            Console.ReadKey();



        }

    }
}