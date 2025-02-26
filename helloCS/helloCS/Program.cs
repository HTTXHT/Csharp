using System;
using System.Threading;

namespace wodekongjian     //命名空间
{

    class Program   //类型 
    {
        static void Main()    //函数，方法
        {
            Background();

            CharacterCreation();

        }



        // 故事背景
        static void Background()
        {
            int windowWidth = Console.WindowWidth;
            string story01 = " 0%-";
            string story02 = "-----------------";
            string story03 = "------";
            string story04 = "------------------------------------100% ";

            // 计算每个字符串的长度，使它们加起来正好占满控制台窗口的宽度
            int totalLength = story01.Length + story02.Length + story03.Length + story04.Length;
            int remainingLength = windowWidth - totalLength;

            // 平均分配剩余的长度到每个字符串
            int extraLengthPerString = remainingLength / 3;
            story01 = story01.PadRight(story01.Length + extraLengthPerString, '-');
            story02 = story02.PadRight(story02.Length + extraLengthPerString, '-');
            story03 = story03.PadRight(story03.Length + extraLengthPerString, '-');



            string story1 = "\r\n\r\n按空格键跳过" +
                "\r\n\r\n“江湖传闻，百年前，一代剑神“无影剑”独孤绝留下一柄绝世神剑——“宿命之刃”，" +
                "传说得此剑者可号令天下，无人能敌。然而，独孤绝在剑成之日便神秘消失，宿命之刃也随之不知所踪。" +
                "\r\n\r\n" + "百年之后，江湖风云再起，各大门派为争夺宿命之刃，暗流涌动。" +
                "你是一名初入江湖的年轻侠客，名为凌风，自幼习武，心怀侠义。" +
                "某日，你在一次偶然的机会下，得到了一张残缺的藏宝图，图中隐约指向宿命之刃的下落。" +
                "然而，你并不知道，这张藏宝图背后隐藏着一个巨大的阴谋。" +
                "江湖中早已有人暗中布局，意图借宿命之刃的力量一统武林。而你，正是这场阴谋中的关键一环......”";
            string story2 =
                "\r\n\r\n游戏开始：" +
                "\r\n你站在一座破旧的古庙前，手中握着那张残破的藏宝图，耳边传来风声，仿佛在低语着未知的命运。" +
                "前方的路充满危险与机遇，而你，将如何选择？" +
                "是追寻宿命之刃的力量，还是揭开背后的阴谋，守护江湖的和平？" +
                "\r\n\r\n";

            PrintSlowly(story01, 100);
            PrintSlowly(story02, 40);
            PrintSlowly(story03, 120);
            PrintSlowly(story04, 20);
            //PrintSlowly(story1, 50);
            PrintSlowlyWithSpaceCheck(story1, 100);

            Console.WriteLine();
            Console.WriteLine("\n任意键继续......");
            Console.ReadKey();
            PrintSlowly(story2,50);
            Console.WriteLine("\n任意键继续......");
            Console.ReadKey();
            Console.WriteLine();
            
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                PrintSlowly(story1,0); 
            }



        }
        // 逐个字母打印，并检查空格键
        static void PrintSlowlyWithSpaceCheck(string text, int delay)
        {
            foreach (char c in text)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                {
                    Console.Write(text.Substring(text.IndexOf(c)));
                    break;
                }
                Console.Write(c);
                Thread.Sleep(delay);
            }
        }

        // 逐个字母打印
        static void PrintSlowly(string text, int delay)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
        }


        //创建角色
        static void CharacterCreation()
        {
            while (true)
            {
                Console.WriteLine("请选择性别（男/女）：");
                string xingbie = Console.ReadLine();

                while (string.IsNullOrWhiteSpace(xingbie) || (xingbie != "男" && xingbie != "女"))
                {
                    Console.WriteLine("请正确输入（男/女)：");
                    xingbie = Console.ReadLine();
                    Console.WriteLine();
                }

                if (xingbie == "男")
                {
                    //不同类型下的实例，实例化
                    //Hero实例1
                    Hero hr1 = new Hero();
                    hr1.ShowGeneratingShux(xingbie);

                }
                else if (xingbie == "女")
                {

                    Hero hr2 = new Hero();
                    hr2.ShowGeneratingShux(xingbie);

                }
            }
        }

    }


//角色类
    class Hero
    {
        //角色属性
        public string mingzi;
        public int nianling;
        public int shenggao;
        public int gongji;
        public int xueliang;
        public int jineng;
        public string jineng1;
        public string miaoshu1;
        public string jineng2;
        public string miaoshu2;

        //生成属性值
        public void ShowGeneratingShux(string xingbie)
        {
            MingZi();
            if (xingbie == "男")
            {
                xingbie = "男";
                nianling = 18;
                shenggao = 175;
                gongji = 10;
                xueliang = 100;
                jineng = 2;
                jineng1 = "「天雷破岳」";
                miaoshu1 = "内力流转凝聚，剑如天雷破山岳";
                jineng2 = "「幽冥无影」";
                miaoshu2 = "身形飘忽不定，剑招无影无形。";
                ShowInfo(xingbie);
            }
            else if (xingbie == "女")
            {
                xingbie = "女";
                nianling = 18;
                shenggao = 165;
                gongji = 10;
                xueliang = 100;
                jineng = 2;
                jineng1 = "「月华倾天」";
                miaoshu1 = "剑光如月华洒落，清冷而凌厉,连绵不绝，如月笼地";
                jineng2 = "「蝶舞翩跹」";
                miaoshu2 = "身姿如彩蝶飞舞，轻盈灵动，步法优雅而难以捉摸";
                ShowInfo(xingbie);
            }

        }

        //注册
        //限制昵称长度为一个字
        public void MingZi()
        {
            Console.WriteLine("请输入昵称（一个字）：");
            mingzi = Console.ReadLine();
        

            while (string.IsNullOrWhiteSpace(mingzi) || mingzi.Length > 1)
            {
                Console.WriteLine("请正确输入昵称（一个字）：");
                mingzi = Console.ReadLine();
            }
            mingzi += "（凌风)";
            Console.WriteLine();
            Console.WriteLine();
            string story3 = "“一剑风云起，孤影踏江湖；宿命藏锋处，侠心照千古。”" +
                "\r\n" + mingzi + " 少侠， " + "欢迎来到《剑影江湖：宿命之刃》";
            string story4 = "\r\n\r\n" + " 你准好了吗？"+"\r\n\r\n";

            PrintSlowly(story3, 50);
            PrintSlowly(story4, 200);

        }
        //public void MingZi()
        //{
        ////不限制昵称长度
        //    Console.WriteLine("请输入昵称：");
        //    mingzi = Console.ReadLine();

        //    while (string.IsNullOrWhiteSpace(mingzi))
        //    {
        //        Console.WriteLine("请正确输入昵称：");
        //        mingzi = Console.ReadLine();
        //    }

        //    Console.WriteLine();
        //    Console.WriteLine("原来你就是传说中的" + mingzi + "大侠！");
        //}

        // 逐个字母打印
        static void PrintSlowly(string text, int delay)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
        }

        //查看角色面板
        public void ShowInfo(string xingbie)
        {
            //一个字昵称长度界面
            Console.WriteLine("任意键查看个人面板");
            Console.ReadKey();
            Console.WriteLine("╔════════════════════════════════╗");
            Console.WriteLine("║            属性面板            ║");
            Console.WriteLine("╠════════════════════════════════╣");
            Console.WriteLine($"║ 大侠:       {mingzi.PadRight(14)}║");
            Console.WriteLine($"║ 性别:       {xingbie.PadRight(18)}║");
            Console.WriteLine($"║ 年龄:       {nianling.ToString().PadRight(19)}║");
            Console.WriteLine($"║ 身高:       {shenggao.ToString().PadRight(19)}║");
            Console.WriteLine($"║ 攻击:       {gongji.ToString().PadRight(19)}║");
            Console.WriteLine($"║ 血量:       {xueliang.ToString().PadRight(19)}║");
            Console.WriteLine($"║ 技能数量:   {jineng.ToString().PadRight(19)}║");
            Console.WriteLine("╚════════════════════════════════╝");

            Console.WriteLine($" 武学                   ");
            Console.WriteLine();
            Console.WriteLine($" 剑法: {jineng1.PadRight(20)}");
            Console.WriteLine($" 描述: {miaoshu1.ToString().PadRight(19)}");
            Console.WriteLine($" 身法: {jineng2.PadRight(15)}");
            Console.WriteLine($" 描述: {miaoshu2.ToString().PadRight(19)}");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("任意键继续......");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadKey();

            ////不限制昵称长度界面
            //Console.WriteLine("按任意键查看角色面板");
            //Console.ReadKey();
            //Console.WriteLine();
            //Console.WriteLine("╔══════════════════════════╗");
            //Console.WriteLine("║           属性           ║");
            //Console.WriteLine("╚══════════════════════════╝");
            //Console.WriteLine($"大侠:       {mingzi}║");
            //Console.WriteLine($"性别:       {xingbie}║");
            //Console.WriteLine($"年龄:       {nianling} ║");
            //Console.WriteLine($"身高:       {shenggao} ║");
            //Console.WriteLine($"攻击:       {gongji} ║");
            //Console.WriteLine($"血量:       {xueliang}  ║");
            //Console.WriteLine($"技能数量:   {jineng}  ║");
            //Console.WriteLine("╔══════════════════════════╗");
            //Console.WriteLine("║           武学         ║");
            //Console.WriteLine("╚══════════════════════════╝");
            //Console.WriteLine($"技能1:      {jineng1}  ║");
            //Console.WriteLine($"伤害:       {jineng1gongji}  ║");
            //Console.WriteLine($"技能2:      {jineng2}  ║");
            //Console.WriteLine($"伤害:       {jineng2gongji}  ║");
            //Console.WriteLine("═══════════════════════════");
            //Console.WriteLine();
            //Console.WriteLine("按任意键继续------");
            //Console.WriteLine();
            //Console.ReadKey();
        }
    }





}