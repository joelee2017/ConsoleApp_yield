using System;
using System.Collections.Generic;

namespace ConsoleApp_yield
{
    class Program
    {
        static void Main(string[] args)
        {
           private static IEnumerable<int> GetCollection3(IEnumerable<int> NumberSeries)
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
