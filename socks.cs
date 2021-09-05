using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    class Program
    {
        static int matching_pairs(List<int> inp_list)   
        {
            int ans = 0;            

            //using Linq
            Dictionary<int, int> pair = inp_list.GroupBy(x => x)
                .Where(c => c.Count() > 1)
                .ToDictionary(x => x.Key, x => x.Count()); 
            foreach (int values in pair.Values)     
            {
                ans += values / 2;
            }
            return ans;
        }
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();                
            string[] inp_list;
            inp_list = inp.Split(' ');                     

            List<int> pairs = new List<int>();             
            foreach (string i in inp_list)
            {
                pairs.Add(Convert.ToInt32(i));              
            }
            int result = matching_pairs(pairs);             
            Console.WriteLine("Matching pair: {0}", result); 

        }
    }
}
