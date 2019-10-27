using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Dinner.Common
{
    public class Cooking
    {
        /// <summary>
        /// 동기 방식의 밥 만들기 메서드 
        /// </summary>
        /// <returns>밥</returns>
        public Rice MakeRice()
        {
            Console.WriteLine("밥 생성중...");
            Thread.Sleep(1001);
            return new Rice();
        }

        /// <summary>
        /// 동기 방식의 국 만들기 메서드
        /// </summary>
        /// <returns>국</returns>
        public Soup MakeSoup()
        {
            Console.WriteLine("국 생성중...");
            Thread.Sleep(1001);
            return new Soup(); 
        }

        /// <summary>
        /// 동기 방식의 달걀 만들기 메서드
        /// </summary>
        /// <returns>달걀</returns>
        public Egg MakeEgg()
        {
            Console.WriteLine("달걀 생성중...");
            Thread.Sleep(1001);
            return new Egg();
        }
    }

    public class Rice
    { 
        // Pass
    }

    public class Soup
    { 
        // Pass
    }

    public class Egg
    { 
        // Pass
    }
}
