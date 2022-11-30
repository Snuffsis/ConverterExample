using ConverterExample.NonWorkingExample.Converters;
using Newtonsoft.Json;

namespace ConverterExample.NonWorkingExample.SalesOrder
{
	public class Contact
	{
		[JsonProperty("overrideContact", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(WrapWithValueConverter<bool>))]
		public bool OverrideContact { get; set; }

		[JsonProperty("attention", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(WrapWithValueConverter<string>))]
		public string Attention { get; set; }

		[JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(WrapWithValueConverter<string>))]
		public string Email { get; set; }

		[JsonProperty("fax", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(WrapWithValueConverter<string>))]
		public string Fax { get; set; }

		[JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(WrapWithValueConverter<string>))]
		public string Name { get; set; }

		[JsonProperty("phone1", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(WrapWithValueConverter<string>))]
		public string Phone1 { get; set; }

		[JsonProperty("phone2", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(WrapWithValueConverter<string>))]
		public string Phone2 { get; set; }

		[JsonProperty("web", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(WrapWithValueConverter<string>))]
		public string Web { get; set; }
	}
}