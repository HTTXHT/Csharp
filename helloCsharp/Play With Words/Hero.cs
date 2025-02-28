using System;

namespace playWithWords
{
    class Hero
    {
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

        string HTS1_1 = "「江湖风波起，浮萍终有名 —— 少侠可愿留个名号？」";
        string HTS1_2 = "「萍水相逢即是缘，敢问姑娘芳名？」";
        string HTS2 = "   「刀光剑影，快意恩仇，江湖路远，一字足矣。」   ";
        string HTS3 = "「少侠眉宇间英气逼人，敢问已历几度春秋？」";
        string HTS4 = "「老夫年轻时与你一般高挑……咳，少侠如今几尺几寸？」";
        string HTS5 = "任意键继续......";

        private static Random random = new Random();

        // 生成角色面板
        public void ShowGeneratingShux(Hero hero, string xingbie)
        {
            MingZi(xingbie);
            SetAttributes(xingbie);
            ShowInfo.ShowHeroInfo(hero, xingbie);
        }

        // 角色注册，昵称长度为一个字
        public void MingZi(string xingbie)
        {
            if (xingbie == "男")
            {
                //提示输入昵称
                Console.WriteLine(HTS1_1);
                mingzi = Console.ReadLine();
                //删除提示词
                Program.DeleteLastLine(HTS1_1.Length);
                Program.DeleteLastLine(HTS1_1.Length);
            }
            else if (xingbie == "女")
            {
                //提示输入昵称
                Console.WriteLine(HTS1_2);
                mingzi = Console.ReadLine();
                //删除提示词
                Program.DeleteLastLine(HTS1_2.Length);
                Program.DeleteLastLine(HTS1_2.Length);
            }
 
            while (string.IsNullOrWhiteSpace(mingzi) || mingzi.Length > 1)
            {
                //正确输入昵称
                Console.WriteLine(HTS2);
                mingzi = Console.ReadLine();
                //删除提示词
                Program.DeleteLastLine(HTS2.Length);
                Program.DeleteLastLine(HTS2.Length);
            }
            mingzi += "（凌风)";
            //Console.WriteLine("“            一剑风云起，孤影踏江湖；            ");
            string story3 = "“            一剑风云起，孤影踏江湖；            "+
                "\n\r                  宿命藏锋处，侠心照千古。”            " +
                "\n\r\n\r      " + mingzi + " 少侠， " + "欢迎来到《剑影江湖：宿命之刃》";
            string story4 = "\n\r\n\r" + "       你准好了吗？" + "\n\r\n\r";

            Program.PrintSlowlyWithSpaceCheck(story3, 50);
            Program.PrintSlowlyWithSpaceCheck(story4, 200);
        }

        // 设置属性值
        private void SetAttributes(string xingbie)
        {
            Console.WriteLine(HTS5);
            Console.ReadKey();
            Program.DeleteLastLine(HTS3.Length);

            //自定义年龄
            Console.WriteLine(HTS3);
            nianling = int.Parse(Console.ReadLine());
            //删除提示词
            Program.DeleteLastLine(HTS3.Length);
            Program.DeleteLastLine(HTS3.Length);
            //自定义身高
            Console.WriteLine(HTS4);
            shenggao = int.Parse(Console.ReadLine());
            //删除提示词
            Program.DeleteLastLine(HTS4.Length);
            Program.DeleteLastLine(HTS4.Length);

            gongji = random.Next(5, 16); // 随机生成5到15之间的攻击力
            xueliang = random.Next(80, 121); // 随机生成80到120之间的血量

            if (xingbie == "男")
            {
                jineng = 2;
                jineng1 = "「天雷破岳」";
                miaoshu1 = "内力流转凝聚，剑如天雷破山岳";
                jineng2 = "「幽冥无影」";
                miaoshu2 = "身形飘忽不定，剑招无影无形";
            }
            else if (xingbie == "女")
            {
                jineng = 2;
                jineng1 = "「月华倾天」";
                miaoshu1 = "剑光如月华洒落，清冷而凌厉,连绵不绝，如月笼地";
                jineng2 = "「蝶舞翩跹」";
                miaoshu2 = "身姿如彩蝶飞舞，轻盈灵动，步法优雅而难以捉摸";
            }
        }
    }
}
