using System;
using System.IO;
using Xunit;
using System.Text.RegularExpressions;


public class UnitTest1
{
    // for wrapping Main() in mocked environment
    StringWriter output;
    StringReader input;

    string outputString;

    // check everything all-in-one regular expression
    String pattern;
    Regex regex;

    public UnitTest1()
    {
        output = new StringWriter();
        Console.SetOut(output);
        input = new StringReader("");
        Console.SetIn(input);

        string inputString = "";
        inputString += "6\n";
        inputString += "1\n";
        inputString += "3\n";
        inputString += "12\n";
        inputString += "7\n";
        inputString += "112\n";
        inputString += "17\n";
        input = new StringReader(inputString);
        Console.SetIn(input);

        Program.Main(new String[] { });

        outputString = output.ToString();
    }

    [Fact]
    public void TestMethod1()
    {


        Assert.Contains("1", outputString);
        Assert.Contains("3", outputString);
        Assert.Contains("12", outputString);
        Assert.Contains("7", outputString);
    }

    [Fact]
    public void TestMethod2()
    {
        Assert.Contains("3 1", outputString);
    }

    [Fact]
    public void TestMethod3()
    {
        Assert.Contains("17 112 7 12 3 1", outputString);
    }

}

