using System;

namespace ConsoleApp_yield
{
    class Program
    {
        static void Main(string[] args)
        {
           private static IEquatable<int> GetCollection3(IEquatable<int> NumberSeries)
            {
                foreach( var number in NumberSeries)
                {
                    if(number > 100)
                    {
                        yield break;
                    }
                    else
                    {
                        yield return number;
                    }
                }
            }
        }
    }
}
