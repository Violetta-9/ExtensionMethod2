using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod2
{
     static class Helper
    {
        public static int PutOnTheScore(this int score,int sum)
        {
            return score += sum;
        }
        public static int SendFromScore(this int score, int sum) 
        {
            return score -= sum;
        }
        public static List<Score> FindTheSameAge (this IEnumerable<Score> collection,int age)
        {
            var lst = new List<Score>();
            foreach (var item in collection)
            {
                if(item.Age==age)
                {
                    lst.Add(item);
                }
                
            }
            return lst;
        }
        public static string ConvertToString(this IEnumerable collection) 
        {
            var result = "";
            foreach (var item in collection)
            {
                result += item.ToString() + "\r\n";   
            }
            return result;
        }
    }
}
