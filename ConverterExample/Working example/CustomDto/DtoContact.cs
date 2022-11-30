using ConverterExample.WorkingExample.SalesOrder;
using Newtonsoft.Json;

namespace ConverterExample.WorkingExample.CustomDto
{
	public class DtoContact
	{
		[JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
		public Contact Value { get; set; }
	}
}
