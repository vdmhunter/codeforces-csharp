using System;
using System.Diagnostics.CodeAnalysis;
using CodeforcesCSharpApp.xUnitTests.Common;
using Xunit;
using Xunit.Abstractions;
using Solution01 = CodeforcesCSharpApp.Round0863.ProblemA01;

namespace CodeforcesCSharpApp.xUnitTests.Round0863.ProblemA;

[ExcludeFromCodeCoverage]
public class Tests
{
    private const string ProblemLetter = "A";
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
}
