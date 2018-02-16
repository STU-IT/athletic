using System;
using System.Linq;
using Xunit;

using System.IO;
using System.Text.RegularExpressions;

using Basic_2_sum;

namespace UnitTest_Basic_2
{
    public class UnitTest1
    {
        StringWriter output;
        StringReader input;

        String pattern;
        Regex regex;

        public UnitTest1()
        {
            output = new StringWriter();
            Console.SetOut(output);

            input = new StringReader("");
            Console.SetIn(input);
        }

        [Fact]
        public void TestMethodEtTal()
        {
            Program.Main(new String[] { });

            pattern = $"\\d+(?:\\.\\d+)?\\s+";
            regex = new Regex(pattern);

            //    Du skal udskrive resultatet af beregningen 
            Assert.Matches(regex, this.output.ToString());
        }
    }
}
