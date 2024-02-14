using CsvHelper;
using CsvHelper.Configuration;
using FileBonanzaCSharp;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

//var filePath = "C:\\KEA\\System Integration\\SystemIntegrationAssignments\\01._Data_Files\\me.";

//var filePaths = new List<string>() { filePath + "csv", filePath + "json", filePath + "xml", filePath + "yaml", filePath + "txt" };

//var rand = new Random();
//var selectedFilePath = filePaths[rand.Next(0, filePaths.Count - 1)];

//List<Person> people = Parser.ReadJson();

//switch (selectedFilePath.Replace(filePath, ""))
//{
//	case "csv":
//		var csvHelperConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
//		{
//			PrepareHeaderForMatch = args => args.Header.ToLower(),
//			Delimiter = ";"
//		};

//		using (var reader = new StreamReader(selectedFilePath))
//		using (var csv = new CsvReader(reader, csvHelperConfig))
//		{
//			people = csv.GetRecords<Person>().ToList();
//		}
//		break;
//	case "json":
//		using (var reader = new StreamReader(selectedFilePath))
//		{
//			string json = reader.ReadToEnd();
//			dynamic array = JsonConvert.DeserializeObject(json);
//			people = new List<Person>();
//			foreach (var item in array)
//			{
//				Person person = new() { Age = item.Age, Country = item.Country, Name = item.Name, Hobbies = item.Hobbies.ToString() };
//				people.Add(person);
//			}
//		}
//		break;
//	case "xml":
//		var doc = new XmlDocument();
//		doc.Load(selectedFilePath);
//		Person p = new();
//		foreach (XmlNode node in doc.DocumentElement.ChildNodes)
//		{
//			if (node.Name == "hobbies")
//			{
//				var hobbiesString = "";
//				foreach (XmlNode hobby in node.ChildNodes)
//				{
//					hobbiesString += hobby.InnerText + ", ";
//				}
//				hobbiesString = hobbiesString.TrimEnd().TrimEnd(',');
//				p.Hobbies = hobbiesString;
//			}
//			else if (node.Name == "age")
//			{
//				p.Age = int.Parse(node.InnerText);
//			}
//			else if (node.Name == "name")
//			{
//				p.Name = node.InnerText;
//			}
//			else if (node.Name == "country")
//			{
//				p.Country = node.InnerText;
//			}
//		}
//		people.Add(p);
//		break;
//	case "yaml" or "txt":
//		using (var reader = new StreamReader(selectedFilePath))
//		{
//			var yaml = reader.ReadToEnd();
//			Console.WriteLine(yaml);
//		}
//		break;
//	default:
//		break;
//}


//foreach (var person in people)
//{
//	Console.WriteLine(person);
//}

Console.WriteLine();
