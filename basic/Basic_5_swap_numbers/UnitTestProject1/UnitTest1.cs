using System;
using System.Linq;
using Xunit;

using System.IO;
using System.Text.RegularExpressions;

using Basic_5_swap_numbers;

namespace UnitTest_Basic_5
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
        public void TestMethodToTal()
        {

            string number1 = "1";
            string number2 = "2";
            input = new StringReader($"{number1}\n{number2}\n");
            Console.SetIn(input);

            Program.Main(new String[] { });

            pattern = $"First Number\\s*:\\s+{number2}\\s+";
            regex = new Regex(pattern);

            //    Først det andet tal
            Assert.Matches(regex, this.output.ToString());

            pattern = $"Second Number\\s*:\\s+{number1}\\s*";
            regex = new Regex(pattern);

            //    Først det andet tal
            Assert.Matches(regex, this.output.ToString());
        }
    }
}
