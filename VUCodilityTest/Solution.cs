using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUCodilityTest
{
    public class Solution : ISolution
    {
        private string _checkString;

        public Solution(string failingRule)
        {
            _checkString = failingRule;
        }

        public bool solution(string S)
        {
            if (S.Contains(_checkString))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
