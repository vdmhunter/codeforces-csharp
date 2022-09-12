using System;
using System.Diagnostics.CodeAnalysis;
using CodeforcesCSharpApp.xUnitTests.Common;
using Xunit;
using Xunit.Abstractions;
using Solution01 = CodeforcesCSharpApp.Ozon.Route256.Contest_20220910.ProblemD01;

namespace CodeforcesCSharpApp.xUnitTests.Ozon.Route256.Contest_20220910.ProblemD;

[ExcludeFromCodeCoverage]
public class ProblemDTests
{
    private const string ProblemName = "ProblemD";
    private const string ProblemDescription = "OZON || Route256 || Contest (10.09.2022) - Problem D";
    private readonly ITestOutputHelper _output;

    public ProblemDTests(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    [Trait("Category", $"{ProblemDescription}: Solution 01")]
    public void RunForSolution01()
    {
        var result = Utils.RunTests(Solution01.Program.Main,
            $"{AppDomain.CurrentDomain.BaseDirectory}{Constants.Path}\\{ProblemName}\\Tests");

        _output.WriteLine(result.Message);

        Assert.Equal(ResultStatus.Success, result.Status);
    }
}
