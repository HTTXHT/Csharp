using System;

namespace playWithWords
{
    class ShowInfo
    {

        //查看角色面板
        public static void ShowHeroInfo(Hero hero, string xingbie)
        {
            string tishi = "\n任意键继续......";
            string tishi2 = "任意键查看角色面板";
            Console.WriteLine(tishi2);
            Console.ReadKey();
            Program.DeleteLastLine(tishi2.Length);
            // 角色面板
            PrintPanelLine("╔════════════════════════════════╗");
            PrintPanelLine("║            角色面板            ║");
            PrintPanelLine("╠════════════════════════════════╣");
            PrintPanelLine($"║ 大侠:       {hero.mingzi.PadRight(15)}║");
            PrintPanelLine($"║ 性别:       {xingbie.PadRight(18)}║");
            PrintPanelLine($"║ 年龄:       {hero.nianling.ToString().PadRight(19)}║");
            PrintPanelLine($"║ 身高:       {hero.shenggao.ToString().PadRight(19)}║");
            PrintPanelLine($"║ 攻击:       {hero.gongji.ToString().PadRight(19)}║");
            PrintPanelLine($"║ 血量:       {hero.xueliang.ToString().PadRight(19)}║");
            PrintPanelLine($"║ 技能数量:   {hero.jineng.ToString().PadRight(19)}║");
            PrintPanelLine("╚════════════════════════════════╝");

            Console.WriteLine(" 武学" + "\n\r");
            PrintSkill("剑法", hero.jineng1, hero.miaoshu1);
            PrintSkill("身法", hero.jineng2, hero.miaoshu2);
            Console.WriteLine(tishi);
            Console.ReadKey();
            Program.DeleteLastLine(tishi.Length);
        }

        // 打印面板行
        private static void PrintPanelLine(string line)
        {
            Console.WriteLine(line);
        }

        // 打印技能信息
        private static void PrintSkill(string skillType, string skillName, string skillDescription)
        {
            Console.WriteLine($" {skillType}: {skillName}");
            Console.WriteLine($" 描述: {skillDescription}");
        }
    }
}

