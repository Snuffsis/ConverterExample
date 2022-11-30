using Newtonsoft.Json;

namespace ConverterExample.WorkingExample.CustomDto
{
	public class DtoObject<T>
	{
		[JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
		public T Value { get; set; }

	}
}
