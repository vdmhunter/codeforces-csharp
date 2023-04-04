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
            var outputLines = sb.ToString().Split(Environment.NewLine);
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
                result.Message = $"Test {(i + 1).ToString("00")} failed on line {j + 1}! " +
                                 $"Output value: {outputLines[j]}. Expected value: {answerLines[j]}";

                return result;
            }
        }

        return new TestsRunResult
        {
            Message = $"Success! All {inputFilePaths.Count} tests passed",
            Status = ResultStatus.Success
        };
    }

    public static TestsRunResult RunTest(Action<string[]> main, string testFilesPath, int testNumber)
    {
        var result = new TestsRunResult();

        var testFilePath = $"{testFilesPath}{testNumber:00}";
        var answerFilePath = $"{testFilesPath}{testNumber:00}.a";
        
        var inputFileText = File.ReadAllText(testFilePath);
        using var reader = new StringReader(inputFileText);
        Console.SetIn(reader);

        using var writer = new StringWriter();
        Console.SetOut(writer);

        main(Array.Empty<string>());

        var sb = writer.GetStringBuilder();
        var outputLines = sb.ToString().Split(Environment.NewLine);
        var answerLines = File.ReadLines(answerFilePath).ToArray();

        for (var i = 0; i < answerLines.Length; i++)
        {
            if (outputLines[i] == answerLines[i])
                continue;

            result.Status = ResultStatus.Fail;
            result.Message = $"Test {testNumber:00} failed on line {i + 1}! " +
                             $"Output value: {outputLines[i]}. Expected value: {answerLines[i]}";

            return result;
        }
        
        return new TestsRunResult
        {
            Message = $"Success! Test {testNumber:00} passed.",
            Status = ResultStatus.Success
        };
    }
}
