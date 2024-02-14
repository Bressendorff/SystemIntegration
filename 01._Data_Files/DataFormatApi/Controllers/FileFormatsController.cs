using FileBonanzaCSharp;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DataFormatApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FileFormatsController : ControllerBase
	{
		// GET api/<FileFormatsController>/csv
		[HttpGet("/csv")]
		public ActionResult<List<Person>> GetCsv()
		{
			return Ok(Parser.ReadCsv());
		}

		[HttpGet("/txt")]
		public ActionResult<string> GetTxt()
		{
			return Ok(Parser.ReadTxt());
		}

		[HttpGet("/json")]
		public ActionResult<List<Person>> GetJson()
		{
			return Ok(Parser.ReadJson());
		}

		[HttpGet("/xaml")]
		public ActionResult<List<Person>> GetXaml()
		{
			return Ok(Parser.ReadCsv());
		}


	}
}
