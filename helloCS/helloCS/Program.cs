using System;
using System.Runtime.CompilerServices;
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
            Console.WriteLine();

            Console.WriteLine("江湖路远无归客。");
            Console.WriteLine("请按任意键继续");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("少侠，你好！");
            Console.WriteLine("请按任意键继续");
            Console.ReadKey();
            Console.WriteLine();

            //不同类型下的实例，实例化
            //Hero实例1
            Hero hr1 = new Hero();
            Console.WriteLine("请输入名称：");
            hr1.mingzi = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(hr1.mingzi))
            {
                Console.WriteLine("请正确输入名称：");
                hr1.mingzi = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("原来你就是传说中的" + hr1.mingzi + "大侠！");

            Console.ReadKey();
            Console.WriteLine("请按任意键查看属性面板");
            Console.WriteLine();

            hr1.xingbie = "男";
            hr1.nianling = 18;
            hr1.shenggao = 175;
            hr1.gongji = 10;
            hr1.xueliang = 100;
            hr1.jineng1 = "飞沙走石";
            hr1.jineng1gongji = 20;
            hr1.jineng2 = "千里冰封";
            hr1.jineng2gongji = 50;


            Console.WriteLine("┌────────────────────────────┐");
            Console.WriteLine("│        属性面板            │");
            Console.WriteLine("├────────────────────────────┤");
            Console.WriteLine($"│ 姓名:       {hr1.mingzi}          │");
            Console.WriteLine($"│ 性别:       {hr1.xingbie}          │");
            Console.WriteLine($"│ 年龄:       {hr1.nianling}          │");
            Console.WriteLine($"│ 身高:       {hr1.shenggao}          │");
            Console.WriteLine($"│ 攻击力:     {hr1.gongji}          │");
            Console.WriteLine($"│ 血量:       {hr1.xueliang}          │");
            Console.WriteLine($"│ 技能1:      {hr1.jineng1}      │");
            Console.WriteLine($"│ 技能1攻击力: {hr1.jineng1gongji}         │");
            Console.WriteLine($"│ 技能2:      {hr1.jineng2}      │");
            Console.WriteLine($"│ 技能2攻击力: {hr1.jineng2gongji}         │");
            Console.WriteLine("└────────────────────────────┘");


            Console.WriteLine("请按任意键继续");
            Console.ReadKey();
            Console.WriteLine("此时远处传来一个女人的声音");
            Console.ReadKey();

            //Hero实例2
            Hero hr2 = new Hero();

            Console.WriteLine("请输入名称：");
            hr2.mingzi = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(hr2.mingzi))
            {
                Console.WriteLine("请正确输入名称：");
                hr2.mingzi = Console.ReadLine();
            }
            Console.WriteLine("原来你就是" + hr2.mingzi + "大侠！");


            hr2.xingbie = "女";
            hr2.nianling = 18;
            hr2.shenggao = 165;
            hr2.gongji = 10;
            hr2.xueliang = 100;
            hr2.jineng1 = "天山折梅手";
            hr2.jineng1gongji = 30;
            hr2.jineng2 = "       ";
            hr2.jineng2gongji = 70;

            Console.WriteLine("┌────────────────────────────┐");
            Console.WriteLine("│        属性面板            │");
            Console.WriteLine("├────────────────────────────┤");
            Console.WriteLine($"│ 姓名:       {hr2.mingzi}          │");
            Console.WriteLine($"│ 性别:       {hr2.xingbie}          │");
            Console.WriteLine($"│ 年龄:       {hr2.nianling}          │");
            Console.WriteLine($"│ 身高:       {hr2.shenggao}          │");
            Console.WriteLine($"│ 攻击力:     {hr2.gongji}          │");
            Console.WriteLine($"│ 血量:       {hr2.xueliang}          │");
            Console.WriteLine($"│ 技能1:      {hr2.jineng1}      │");
            Console.WriteLine($"│ 技能1攻击力: {hr2.jineng1gongji}         │");
            Console.WriteLine($"│ 技能2:      {hr2.jineng2}      │");
            Console.WriteLine($"│ 技能2攻击力: {hr2.jineng2gongji}         │");
            Console.WriteLine("└────────────────────────────┘");


            Console.WriteLine("请按任意键继续");
            Console.ReadKey();

        }

    }


    class Hero
    {
        public string mingzi;
        public string xingbie ;
        public int nianling ;
        public int shenggao ;
        public int gongji;
        public int xueliang;
        public string jineng1;
        public int jineng1gongji;
        public string jineng2;
        public int jineng2gongji;

        
    }





}