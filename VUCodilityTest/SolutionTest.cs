using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace VUCodilityTest
{
    [TestFixture]
    public class SolutionTest
    {
        private string _checkString = string.Empty;
        private ISolution _solution;

        [OneTimeSetUpAttribute]
        public void OneTimeSetUp()
        {
            _checkString = "ba";
        }

        [SetUp]
        public void SetUp()
        {
            _solution = new Solution(_checkString); 
        }

        [TestCase("aabbb")]
        [TestCase("b")]
        public void PerformSolutionTest_ReturnTrueResults(string s)
        {
            bool result = _solution.solution(s);

            Assert.IsTrue(result);
        }

        [TestCase("abba")]
        [TestCase("ba")]
        public void PerformSolutionTest_ReturnFalseResults(string s)
        {
            bool result = _solution.solution(s);

            Assert.IsFalse(result);
        }
    }
}
