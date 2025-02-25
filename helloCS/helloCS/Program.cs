using System;

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

            Console.WriteLine("请输入性别：");
            string xingbie = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(xingbie) || (xingbie != "男" && xingbie != "女"))
            {
                Console.WriteLine("请正确输入性别（男/女)：");
                xingbie = Console.ReadLine();
                Console.WriteLine();
            }

            if (xingbie == "男")
            {
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
                hr1.ShowGeneratingShux(xingbie);

                //hr1.xingbie = "男";
                //hr1.nianling = 18;
                //hr1.shenggao = 175;
                //hr1.gongji = 10;
                //hr1.xueliang = 100;
                //hr1.jineng1 = "飞沙走石";
                //hr1.jineng1gongji = 20;
                //hr1.jineng2 = "千里冰封";
                //hr1.jineng2gongji = 50;

                //hr1.ShowInfo();
            }
            else if (xingbie == "女")
            {
                
                Hero hr2 = new Hero();
                Console.WriteLine("请输入名称：");
                hr2.mingzi = Console.ReadLine();

                while (string.IsNullOrWhiteSpace(hr2.mingzi))
                {
                    Console.WriteLine("请正确输入名称：");
                    hr2.mingzi = Console.ReadLine();
                }

                Console.WriteLine("原来你就是" + hr2.mingzi + "大侠！");
                hr2.ShowGeneratingShux(xingbie);
                //hr2.xingbie = "女";
                //hr2.nianling = 18;
                //hr2.shenggao = 165;
                //hr2.gongji = 10;
                //hr2.xueliang = 100;
                //hr2.jineng1 = "天山折梅手";
                //hr2.jineng1gongji = 30;
                //hr2.jineng2 = "       ";
                //hr2.jineng2gongji = 70;

                //hr2.ShowInfo();
            }
        }
    }


    class Hero
    {
        public string mingzi;
        public int nianling;
        public int shenggao;
        public int gongji;
        public int xueliang;
        public string jineng1;
        public int jineng1gongji;
        public string jineng2;
        public int jineng2gongji;


        public void ShowGeneratingShux(string xingbie)
        {

            if (xingbie == "男")
            {
 
                xingbie = "男";
                nianling = 18;
                shenggao = 175;
                gongji = 10;
                xueliang = 100;
                jineng1 = "飞沙走石";
                jineng1gongji = 20;
                jineng2 = "千里冰封";
                jineng2gongji = 50;
                ShowInfo(xingbie);
            }
            else if (xingbie == "女")
            {
                xingbie = "女";
                nianling = 18;
                shenggao = 165;
                gongji = 10;
                xueliang = 100;
                jineng1 = "天山折梅手";
                jineng1gongji = 30;
                jineng2 = "九阴白骨爪";
                jineng2gongji = 70;
                ShowInfo( xingbie);
            }



        }

        public void ShowInfo(string xingbie)
        {

            Console.WriteLine("请按任意键查看属性");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("────────────────────────────");
            Console.WriteLine("         属性             ");
            Console.WriteLine("────────────────────────────");
            Console.WriteLine($" 姓名:       {mingzi}");
            Console.WriteLine($" 性别:       {xingbie}");
            Console.WriteLine($" 年龄:       {nianling}");
            Console.WriteLine($" 身高:       {shenggao}");
            Console.WriteLine($" 攻击力:     {gongji}");
            Console.WriteLine($" 血量:       {xueliang}");
            Console.WriteLine("────────────────────────────");
            Console.WriteLine("         技能             ");
            Console.WriteLine("────────────────────────────");
            Console.WriteLine($" 技能1:      {jineng1}");
            Console.WriteLine($" 技能1攻击力: {jineng1gongji}");
            Console.WriteLine($" 技能2:      {jineng2}");
            Console.WriteLine($" 技能2攻击力: {jineng2gongji}");
            Console.WriteLine("────────────────────────────");

            Console.WriteLine("请按任意键继续");
            Console.ReadKey();
            Console.WriteLine();
        }


    }





}