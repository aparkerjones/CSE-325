using System.Globalization;
using System.Text;

var inputDirectory = Path.Combine(AppContext.BaseDirectory, "sales-data");
var outputPath = Path.Combine(AppContext.BaseDirectory, "sales-summary.txt");

Directory.CreateDirectory(inputDirectory);
var summary = SalesReport.Create(inputDirectory);
await File.WriteAllTextAsync(outputPath, summary);
Console.WriteLine($"Sales summary written to {outputPath}");

public static class SalesReport
{
    public static string Create(string directoryPath)
    {
        var fileTotals = new Dictionary<string, decimal>();

        foreach (var filePath in Directory.EnumerateFiles(directoryPath, "*.txt").Order())
        {
            var total = File.ReadLines(filePath)
                .Where(line => decimal.TryParse(line, NumberStyles.Currency, CultureInfo.InvariantCulture, out _))
                .Select(line => decimal.Parse(line, NumberStyles.Currency, CultureInfo.InvariantCulture))
                .Sum();

            fileTotals[Path.GetFileName(filePath)] = total;
        }

        var grandTotal = fileTotals.Values.Sum();
        var report = new StringBuilder()
            .AppendLine("Sales Summary")
            .AppendLine("----------------------------")
            .AppendLine($"Total Sales: {grandTotal:C}")
            .AppendLine()
            .AppendLine("Details:");

        foreach (var fileTotal in fileTotals)
        {
            report.AppendLine($"{fileTotal.Key}: {fileTotal.Value:C}");
        }

        return report.ToString();
    }
}