using System;

namespace tower_ting_ting
{
    class Program
    {
        static void Main(string[] args)
        {
         int number;
         bool isParsable =Int32.TryParse(args[0],out number);
         if(isParsable)
         hannoi(number,"A","B","C");
         else
         {
             Console.WriteLine("use a whole number");
         }
         void move(string f,string t)
         {
             Console.WriteLine($"move dsci from {f} to {t}!");
         }
         void hannoi(int n, string f, string h,string t)
         {
             if(n ==0)
             {
                 return;
             }
             else{
                 hannoi(n-1,f,t,h);
                 move(f,t);
                 hannoi(n-1,h,f,t);
             }
         }

        }
    }
}
