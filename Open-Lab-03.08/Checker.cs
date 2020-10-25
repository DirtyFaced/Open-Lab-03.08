using System;
using System.Linq;

namespace Open_Lab_03._08
{
    public class Checker
    {
        public bool IsPlural(string word)
        {
            bool bubak = false;
            if (word.Last() == 's')
            { bubak = true; };
            return bubak;
        }
    }
}
