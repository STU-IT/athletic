using System;
using Xunit;

using System.IO;
using System.Text.RegularExpressions;

using Basic_1_HelloWorld;

namespace UnitTest_basic_1_HelloWorld
//namespace Basic_1_HelloWorld
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
        public void TestNavn()
        {
            string navn = "Søren";
            input = new StringReader($"{navn}\n");
            Console.SetIn(input);
            Program.Main(new String[] { });

            pattern = $"(?:Hej|Hello),?\\s+{navn}\\s*";
            regex = new Regex(pattern);

            Assert.Matches(regex, this.output.ToString());
        }

        [Fact]
        public void TestUdenNavn()
        {
            Program.Main(new String[] { });

            pattern = $"(?:Hej|Hello),?\\s+";
            regex = new Regex(pattern);

            //    Du skal udskrive enten "Hej" eller "Hello", med stort begynnelsesbogstav
            Assert.Matches(regex, this.output.ToString()); 
        }
    }
}
