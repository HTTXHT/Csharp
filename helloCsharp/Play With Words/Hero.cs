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

        // 生成角色面板
        public void ShowGeneratingShux(Hero hero, string xingbie)
        {
            MingZi();
            SetAttributes(xingbie);
            ShowInfo.ShowHeroInfo(hero, xingbie);
        }

        // 角色注册，昵称长度为一个字
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
            string story3 = "“一剑风云起，孤影踏江湖；" +
                "\n\r\n\r      宿命藏锋处，侠心照千古。”" +
                "\n\r\n\r" + mingzi + " 少侠， " + "欢迎来到《剑影江湖：宿命之刃》";
            string story4 = "\n\r\n\r" + " 你准好了吗？" + "\n\r\n\r";

            Program.PrintSlowlyWithSpaceCheck(story3, 50);
            Program.PrintSlowlyWithSpaceCheck(story4, 200);
        }


        // 设置属性值
        private void SetAttributes(string xingbie)
        {
            if (xingbie == "男")
            {
                nianling = 18;
                shenggao = 175;
                gongji = 10;
                xueliang = 100;
                jineng = 2;
                jineng1 = "「天雷破岳」";
                miaoshu1 = "内力流转凝聚，剑如天雷破山岳";
                jineng2 = "「幽冥无影」";
                miaoshu2 = "身形飘忽不定，剑招无影无形";
            }
            else if (xingbie == "女")
            {
                nianling = 18;
                shenggao = 165;
                gongji = 10;
                xueliang = 100;
                jineng = 2;
                jineng1 = "「月华倾天」";
                miaoshu1 = "剑光如月华洒落，清冷而凌厉,连绵不绝，如月笼地";
                jineng2 = "「蝶舞翩跹」";
                miaoshu2 = "身姿如彩蝶飞舞，轻盈灵动，步法优雅而难以捉摸";
            }
        }
    }
}

