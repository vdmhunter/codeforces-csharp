using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeforcesCSharpApp.xUnitTests.Common;

[ExcludeFromCodeCoverage]
public static class Utils
{
    public static TestsRunResult RunTests(Action<string[]> main, string testFilesPath)
    {
        var result = new TestsRunResult();

        var inputFilePaths = Directory.GetFiles(testFilesPath)
            .Where(file => Regex.IsMatch(file, "\\d\\d$", RegexOptions.IgnoreCase))
            .ToList();

        var answerFilePaths = Directory.GetFiles(testFilesPath)
            .Where(file => Regex.IsMatch(file, "\\d\\d.a$", RegexOptions.IgnoreCase))
            .ToList();

        if (inputFilePaths.Count != answerFilePaths.Count)
        {
            result.Status = ResultStatus.Fail;
            result.Message = "Test failed. Number of test input files and number of files with answers not match!";

            return result;
        }

        for (var i = 0; i < inputFilePaths.Count; i++)
        {
            var inputFileText = File.ReadAllText(inputFilePaths[i]);
            using var reader = new StringReader(inputFileText);
            Console.SetIn(reader);

            using var writer = new StringWriter();
            Console.SetOut(writer);

            main(Array.Empty<string>());

            var sb = writer.GetStringBuilder();
            var outputLines = sb.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            var answerLines = File.ReadLines(answerFilePaths[i]).ToArray();

            if (outputLines.Length != answerLines.Length)
            {
                result.Status = ResultStatus.Fail;
                result.Message = "Test failed. Number of lines in solution response and test file does not match!";

                return result;
            }

            for (var j = 0; j < outputLines.Length; j++)
            {
                if (outputLines[j] == answerLines[j])
                    continue;

                result.Status = ResultStatus.Fail;
                result.Message = $"Test failed on line {j + 1}! Output value: {outputLines[j]}. " +
                                 $"Expected value: {answerLines[j]}";

                return result;
            }
        }

        return new TestsRunResult
        {
            Message = $"Success! All {inputFilePaths.Count} tests passed",
            Status = ResultStatus.Success
        };
    }
}
