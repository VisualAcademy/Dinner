using Dinner.Common;
using System;
using System.Diagnostics;

namespace Dinner.Sync
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //[1] 밥 만들기
            Rice rice = (new Cooking()).MakeRice(); 
            Console.WriteLine($"밥 준비 완료 - {rice.GetHashCode()}");

            //[2] 국 만들기
            Soup soup = (new Cooking()).MakeSoup();
            Console.WriteLine($"국 준비 완료 - {soup.GetHashCode()}");

            stopwatch.Stop();
            Console.WriteLine($"시간: {stopwatch.ElapsedMilliseconds}밀리초");

            Console.WriteLine("동기 방식으로 식사 준비 완료");
        }
    }
}
