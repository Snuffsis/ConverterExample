using Newtonsoft.Json;

namespace ConverterExample.WorkingExample.CustomDto
{
	public class DtoString
	{
		[JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
		public string Value { get; set; }
	}
}
