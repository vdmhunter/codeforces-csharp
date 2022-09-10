using System.Diagnostics.CodeAnalysis;

namespace CodeforcesCSharpApp.xUnitTests.Common;

[ExcludeFromCodeCoverage]
public class TestsRunResult
{
    public ResultStatus Status { get; set; }
    
    public string? Message { get; set; }
}