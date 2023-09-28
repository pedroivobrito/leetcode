using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Functions
{
    public class StringProblems
    {
        public int MinPartitions(string n)
        {
            char[] ch = n.ToCharArray();

            return (int)Char.GetNumericValue(ch.Max());
        }

        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }

        public int FinalValueAfterOperations(string[] operations)
        {
            int result = 0;
            foreach (string op in operations)
            {
                if (op == "++X" || op == "X++")
                    result++;
                if (op == "--X" || op == "X--")
                    result--;
            }

            return result;
        }

        public int NumJewelsInStones(string jewels, string stones)
        {
            int result = 0;

            foreach (char stone in stones)
            {
                if (jewels.Contains(stone))
                    result++;
            }

            return result;
        }
    }
}
