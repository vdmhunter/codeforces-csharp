using System;
using System.Diagnostics.CodeAnalysis;
using CodeforcesCSharpApp.Ozon.Route256.Sandbox_20230116.ProblemE01;
using CodeforcesCSharpApp.xUnitTests.Common;
using Xunit;
using Xunit.Abstractions;

namespace CodeforcesCSharpApp.xUnitTests.Ozon.Route256.Sandbox_20230116.ProblemE;

[ExcludeFromCodeCoverage]
public class Tests
{
    private const string ProblemLetter = "E";
    private const string ProblemName = $"Problem{ProblemLetter}";
    private const string ProblemDescription = Constants.DescriptionPattern + ProblemLetter;

    private readonly string _problemTestsPath =
        $"{AppDomain.CurrentDomain.BaseDirectory}{Constants.Path}\\{ProblemName}\\Tests\\";

    private readonly ITestOutputHelper _output;

    public Tests(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test01()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 1);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test02()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 2);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test03()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 3);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test04()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 4);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test05()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 5);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test06()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 6);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test07()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 7);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test08()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 8);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test09()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 9);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test10()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 10);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test11()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 11);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test12()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 12);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test13()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 13);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test14()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 14);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test15()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 15);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test16()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 16);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test17()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 17);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test18()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 18);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test19()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 19);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test20()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 20);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test21()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 21);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test22()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 22);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test23()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 23);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test24()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 24);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test25()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 25);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test26()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 26);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test27()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 27);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test28()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 28);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test29()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 29);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test30()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 30);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test31()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 31);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test32()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 32);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test33()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 33);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test34()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 34);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test35()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 35);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test36()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 36);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test37()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 37);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test38()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 38);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test39()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 39);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }

    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test40()
    {
        var result = Utils.RunTest(Program.Main, _problemTestsPath, 40);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }
}
