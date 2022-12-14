using System;
using System.Diagnostics.CodeAnalysis;
using CodeforcesCSharpApp.xUnitTests.Common;
using Xunit;
using Xunit.Abstractions;
using Solution01 = CodeforcesCSharpApp.Ozon.Route256.Contest_20220910.ProblemB01;

namespace CodeforcesCSharpApp.xUnitTests.Ozon.Route256.Contest_20220910.ProblemB;

[ExcludeFromCodeCoverage]
public class Tests
{
    private const string ProblemLetter = "B";
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
        var result = Utils.RunTest(Solution01.Program.Main, _problemTestsPath, 1);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }
    
    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test02()
    {
        var result = Utils.RunTest(Solution01.Program.Main, _problemTestsPath, 2);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }
    
    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test03()
    {
        var result = Utils.RunTest(Solution01.Program.Main, _problemTestsPath, 3);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }
    
    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test04()
    {
        var result = Utils.RunTest(Solution01.Program.Main, _problemTestsPath, 4);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }
    
    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test05()
    {
        var result = Utils.RunTest(Solution01.Program.Main, _problemTestsPath, 5);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }
    
    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test06()
    {
        var result = Utils.RunTest(Solution01.Program.Main, _problemTestsPath,6);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }
    
    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test07()
    {
        var result = Utils.RunTest(Solution01.Program.Main, _problemTestsPath, 7);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }
    
    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test08()
    {
        var result = Utils.RunTest(Solution01.Program.Main, _problemTestsPath, 8);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }
    
    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test09()
    {
        var result = Utils.RunTest(Solution01.Program.Main, _problemTestsPath, 9);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }
    
    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test10()
    {
        var result = Utils.RunTest(Solution01.Program.Main, _problemTestsPath, 10);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }
    
    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test11()
    {
        var result = Utils.RunTest(Solution01.Program.Main, _problemTestsPath, 11);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }
    
    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test12()
    {
        var result = Utils.RunTest(Solution01.Program.Main, _problemTestsPath, 12);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }
    
    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test13()
    {
        var result = Utils.RunTest(Solution01.Program.Main, _problemTestsPath, 13);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }
    
    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test14()
    {
        var result = Utils.RunTest(Solution01.Program.Main, _problemTestsPath, 14);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }
    
    [Fact]
    [Trait($"{ProblemDescription}", "Solution 01")]
    public void Solution01_Test15()
    {
        var result = Utils.RunTest(Solution01.Program.Main, _problemTestsPath, 15);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }
}
