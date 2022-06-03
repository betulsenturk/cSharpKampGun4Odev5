using System;
using System.Collections.Generic;

namespace Gun4Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> users = new MyDictionary<int, string>();

            users.Add(2, "Merve");
            users.Add(5, "Nurcan");
            users.Add(3, "Betül");

            users.Print();
        }
    }
}
