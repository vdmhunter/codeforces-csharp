using System;
using System.Diagnostics.CodeAnalysis;
using CodeforcesCSharpApp.EducationalRound0136.ProblemB;
using CodeforcesCSharpApp.xUnitTests.Common;
using Xunit;
using Xunit.Abstractions;

namespace CodeforcesCSharpApp.xUnitTests.EducationalRound0136.ProblemB;

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
        var result = Utils.RunTest(Solution01.Main, _problemTestsPath, 1);
        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }
}
