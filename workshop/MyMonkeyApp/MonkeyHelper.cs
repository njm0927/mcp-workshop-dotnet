using System;
using System.Collections.Generic;
using System.Linq;

namespace MyMonkeyApp
{
    public static class MonkeyHelper
    {
        private static readonly List<Monkey> monkeys = new List<Monkey>
        {
            new Monkey("Capuchin", "영리하고 작은 원숭이", "( ͡° ͜ʖ ͡°)"),
            new Monkey("Howler", "큰 소리로 우는 원숭이", "(☉_☉)"),
            new Monkey("Spider", "긴 팔과 다리가 특징", "(¬‿¬)"),
            new Monkey("Squirrel", "작고 민첩한 원숭이", "(ᵔᴥᵔ)"),
            new Monkey("Mandrill", "화려한 얼굴의 대형 원숭이", "(◕‿◕)")
        };

        private static int randomPickCount = 0;

        public static List<Monkey> GetAllMonkeys()
        {
            return monkeys;
        }

        public static Monkey GetRandomMonkey()
        {
            randomPickCount++;
            var rand = new Random();
            return monkeys[rand.Next(monkeys.Count)];
        }

        public static Monkey FindMonkeyByName(string name)
        {
            return monkeys.FirstOrDefault(m => m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public static int GetRandomPickCount()
        {
            return randomPickCount;
        }
    }
}
