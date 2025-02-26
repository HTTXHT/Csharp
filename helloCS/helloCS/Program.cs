using helloCS;
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

            // 计算字符串的长度，加起来正好占满控制台窗口的宽度
            int totalLength = story01.Length + story02.Length + story03.Length + story04.Length;
            int remainingLength = windowWidth - totalLength;

            // 平均分配剩余的长度到每个字符串
            int extraLengthPerString = remainingLength / 3;
            story01 = story01.PadRight(story01.Length + extraLengthPerString, '-');
            story02 = story02.PadRight(story02.Length + extraLengthPerString, '-');
            story03 = story03.PadRight(story03.Length + extraLengthPerString, '-');



            string story1 =
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

            //PrintSlowly(story2, 50);
            PrintSlowlyWithSpaceCheck(story2, 100);
            Console.WriteLine("\n任意键继续......");
            Console.ReadKey();
            Console.WriteLine();

        }
        // 逐个字母打印，并检查空格键
        public static void PrintSlowlyWithSpaceCheck(string text, int delay)
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
        public static void PrintSlowly(string text, int delay)
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
                    hr1.ShowGeneratingShux(hr1, xingbie);

                }
                else if (xingbie == "女")
                {

                    Hero hr2 = new Hero();
                    hr2.ShowGeneratingShux(hr2, xingbie);

                }
            }
        }

    }

    
    //角色类
   
}