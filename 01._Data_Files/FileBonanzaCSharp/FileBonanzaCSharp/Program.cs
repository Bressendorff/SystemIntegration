using CsvHelper;
using CsvHelper.Configuration;
using FileBonanzaCSharp;
using System.Globalization;

var csvFilePath = "C:\\KEA\\System Integration\\SystemIntegrationAssignments\\01._Data_Files\\me.csv";

var csvHelperConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
{
	PrepareHeaderForMatch = args => args.Header.ToLower(),
	Delimiter = ";"
};

using (var reader = new StreamReader(csvFilePath))
using (var csv = new CsvReader(reader, csvHelperConfig))
{
	var records = csv.GetRecords<Person>();
	foreach (var r in records)
	{
		Console.WriteLine(r);
	}
}
