using System;

namespace wodekongjian     //命名空间
{

    class Program   //类型 
    {
        static void Main()    //函数，方法
        {
            Background();

            CharacterCreation();

        }


        //故事背景
        static void Background()
        {
            Console.WriteLine("月黑风高杀人夜");
            Console.WriteLine("按任意键继续……");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("江湖路远无归客。");
            Console.WriteLine("按任意键继续……");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("少侠，你好！");
            Console.WriteLine("按任意键继续……");
            Console.ReadKey();
            Console.WriteLine();
        }


        //创建角色
        static void CharacterCreation()
        {
            while (true)
            {
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
        public int jineng1gongji;
        public string jineng2;
        public int jineng2gongji;

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
                jineng = 2;
                jineng1 = "天山折梅手";
                jineng1gongji = 30;
                jineng2 = "九阴白骨爪";
                jineng2gongji = 70;
                ShowInfo(xingbie);
            }

        }

        //注册
        public void MingZi()
        {

            Console.WriteLine("请输入名称：");
            mingzi = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(mingzi))
            {
                Console.WriteLine("请正确输入名称：");
                mingzi = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("原来你就是传说中的" + mingzi + "大侠！");
        }


        //查看个人面板
        public void ShowInfo(string xingbie)
        {

            Console.WriteLine("按任意键查看个人面板");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("╔══════════════════════════╗");
            Console.WriteLine("║           属性           ║");
            Console.WriteLine("╚══════════════════════════╝");
            Console.WriteLine($" 大侠:       {mingzi}");
            Console.WriteLine($" 性别:       {xingbie}");
            Console.WriteLine($" 年龄:       {nianling}");
            Console.WriteLine($" 身高:       {shenggao}");
            Console.WriteLine($" 攻击:     {gongji}");
            Console.WriteLine($" 血量:       {xueliang}");
            Console.WriteLine($" 技能数量:   {jineng}");
            Console.WriteLine("╔══════════════════════════╗");
            Console.WriteLine("║         技能展示         ║");
            Console.WriteLine("╚══════════════════════════╝");
            Console.WriteLine($" 技能1:      {jineng1}");
            Console.WriteLine($" 伤害:       {jineng1gongji}");
            Console.WriteLine($" 技能2:      {jineng2}");
            Console.WriteLine($" 伤害:       {jineng2gongji}");
            //Console.WriteLine("═══════════════════════════");
            Console.WriteLine();
            Console.WriteLine("按任意键继续……");
            Console.WriteLine();
            Console.ReadKey();
        }
    }





}