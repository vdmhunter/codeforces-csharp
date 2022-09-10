using System;
using System.Diagnostics.CodeAnalysis;
using CodeforcesCSharpApp.xUnitTests.Common;
using Xunit;
using Xunit.Abstractions;
using Solution01 = CodeforcesCSharpApp.Ozon.Route256.Sandbox_20220817.ProblemA01;

namespace CodeforcesCSharpApp.xUnitTests.Ozon.Route256.Sandbox_20220817.ProblemA;

[ExcludeFromCodeCoverage]
public class ProblemATests
{
    private const string ProblemName = "ProblemA";
    private const string ProblemDescription = "OZON || Route256 || Sandbox (17.08.2022) - Problem A";
    private readonly ITestOutputHelper _output;

    public ProblemATests(ITestOutputHelper output)
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
