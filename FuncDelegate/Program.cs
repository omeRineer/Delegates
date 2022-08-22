using System;

namespace FuncDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FuncExamp(Apply);                                       //Send function parameter
            FuncExamp((x, y) => x + y);                             //Send inline function parameter
            FuncExamp(delegate (int x, int y) { return x + y; });   //Send inline delegate parameter
        }

        static void FuncExamp(Func<int, int, int> funcInstance)
        {
            var result = funcInstance(2, 3);
            Console.WriteLine(result);
        }


        static int Apply(int param1, int param2)
        {
            return param1 + param2;
        }

        static int Extraction(int param1, int param2)
        {
            return param1 - param2;
        }
    }
}
