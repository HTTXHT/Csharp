using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wodekongjian;

namespace helloCS
{
    class ShowInfo
    {
        //查看角色面板

        public static void ShowHeroInfo(Hero hero, String xingbie)
        {
            Console.WriteLine("任意键查看角色面板");
            Console.ReadKey();
            //角色面板
            Console.WriteLine("╔════════════════════════════════╗");
            Console.WriteLine("║            角色面板            ║");
            Console.WriteLine("╠════════════════════════════════╣");
            Console.WriteLine($"║ 大侠:       {hero.mingzi.PadRight(15)}║");
            Console.WriteLine($"║ 性别:       {xingbie.PadRight(18)}║");
            Console.WriteLine($"║ 年龄:       {hero.nianling.ToString().PadRight(19)}║");
            Console.WriteLine($"║ 身高:       {hero.shenggao.ToString().PadRight(19)}║");
            Console.WriteLine($"║ 攻击:       {hero.gongji.ToString().PadRight(19)}║");
            Console.WriteLine($"║ 血量:       {hero.xueliang.ToString().PadRight(19)}║");
            Console.WriteLine($"║ 技能数量:   {hero.jineng.ToString().PadRight(19)}║");
            Console.WriteLine("╚════════════════════════════════╝");
            Console.WriteLine($" 武学                   ");
            Console.WriteLine();
            Console.WriteLine($" 剑法: {hero.jineng1}");
            Console.WriteLine($" 描述: {hero.miaoshu1}");
            Console.WriteLine($" 身法: {hero.jineng2}");
            Console.WriteLine($" 描述: {hero.miaoshu2}");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("任意键继续......");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
