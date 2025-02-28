using System;
using System.Threading;

namespace playWithWords   //命名空间
{

    class Program   //类型 
    {
        static void Main()    //函数，方法
        {
            string PTS1 = "任意键继续......";

            Background(PTS1);

            CharacterCreation();

        }

        // 故事背景
        static void Background(string PTS1)
        {
            //int windowWidth = Console.WindowWidth;
            //string story01 = " 0%-";
            //string story02 = "-----------------";
            //string story03 = "------";
            //string story04 = "------------------------------------100% ";

            //// 计算字符串的长度，加起来正好占满控制台窗口的宽度
            //int totalLength = story01.Length + story02.Length + story03.Length + story04.Length;
            //int remainingLength = windowWidth - totalLength;

            //// 平均分配剩余的长度到每个字符串
            //int extraLengthPerString = remainingLength / 3;
            //story01 = story01.PadRight(story01.Length + extraLengthPerString, '-');
            //story02 = story02.PadRight(story02.Length + extraLengthPerString, '-');
            //story03 = story03.PadRight(story03.Length + extraLengthPerString, '-');

            string story1 =
                "\n\r\n\r“江湖传闻，百年前，一代剑神‘无影剑’独孤绝留下一柄绝世神剑——“宿命之刃”，" +
                "传说得此剑者可号令天下，无人能敌。然而，独孤绝在剑成之日便神秘消失，宿命之刃也随之不知所踪。" +
                "\n\r\n\r" + "百年之后，江湖风云再起，各大门派为争夺宿命之刃，暗流涌动。" +
                "你是一名初入江湖的年轻侠客，名为凌风，自幼习武，心怀侠义。" +
                "某日，你在一次偶然的机会下，得到了一张残缺的藏宝图，图中隐约指向宿命之刃的下落。" +
                "然而，你并不知道，这张藏宝图背后隐藏着一个巨大的阴谋。" +
                "江湖中早已有人暗中布局，意图借宿命之刃的力量一统武林。而你，拿着藏宝图仍在犹豫......" +
                "\n\r\n\r";

           string story2 =
                "\n\r你正欲细看，林中骤然射出三枚毒镖！一道黑影冷笑遁去，地上只留半截断箭，箭镞刻着陌生门派图腾……" +
                "\n\r原来这江湖，从未给过你退路。”\n\r";

           string story3 =
                "\n\r前方的路充满危险与机遇，而你，将如何选择？\n\r\n\r";

            string story4 =
               "沉吟片刻，终是袖中暗扣一枚铜钱，举步踏入古庙。" +
               "残月隐入云层，庙内烛火摇曳，映出半截断裂的神像，" +
               "却见一老乞丐似笑非笑地睨向门外……" +
               "\n\r\n\r\n\r";

            //PrintSlowly(story01, 100);
            //PrintSlowly(story02, 40);
            //PrintSlowly(story03, 120);
            //PrintSlowly(story04, 20);


            PrintSlowlyWithSpaceCheck(story1, 50);
            Console.WriteLine(PTS1);
            Console.ReadKey();

            //删除提示词
            DeleteLastLine(PTS1.Length);

            Console.WriteLine("藏宝图的裂纹忽明忽暗，似与古庙方向共鸣。");

            PrintSlowlyWithSpaceCheck(story2, 120);
            PrintSlowlyWithSpaceCheck(story3, 50);
           
            // 等待一秒
            Thread.Sleep(3000); 
            PrintSlowlyWithSpaceCheck(story4, 80);
            Console.WriteLine(PTS1);
            Console.ReadKey();

            //删除提示词
            DeleteLastLine(PTS1.Length);

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
                string HTS1 = "老乞丐：「恕老夫眼拙，不辨雌雄，敢问少侠？」                  ";
                string HTS2 = "老乞丐：「啰嗦，老夫便是想知道你是男是女，快快简单回复」      ";
                Console.WriteLine(HTS1);
                string xingbie = Console.ReadLine();
                //删除提示词
                Program.DeleteLastLine(HTS1.Length);
                Program.DeleteLastLine(HTS1.Length);

                while (string.IsNullOrWhiteSpace(xingbie) || (xingbie != "男" && xingbie != "女"))
                {
                    Console.WriteLine(HTS2);
                    xingbie = Console.ReadLine();
                    //删除提示词
                    Program.DeleteLastLine(HTS2.Length);
                    Program.DeleteLastLine(HTS2.Length);
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

        // 删除控制台字符
        public static void DeleteLastLine(int length)
        {
            int cursorTop = Console.CursorTop;
            //Console.SetCursorPosition(0, cursorTop - 1);
            Console.Write(new string(' ', length));
            Console.SetCursorPosition(0, cursorTop - 1);
        }

    }
}