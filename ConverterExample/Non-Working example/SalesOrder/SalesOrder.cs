using ConverterExample.NonWorkingExample.Converters;
using Newtonsoft.Json;

namespace ConverterExample.NonWorkingExample.SalesOrder
{
	public class SalesOrder
	{
		[JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(WrapWithValueConverter<int?>))]
		public int? Project { get; set; }

		[JsonProperty("printDescriptionOnInvoice", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(WrapWithValueConverter<bool>))]
		public bool PrintDescriptionOnInvoice { get; set; }

		[JsonProperty("printNoteOnExternalDocuments", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(WrapWithValueConverter<bool>))]
		public bool PrintNoteOnExternalDocuments { get; set; }

		[JsonProperty("printNoteOnInternalDocuments", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(WrapWithValueConverter<bool>))]
		public bool PrintNoteOnInternalDocuments { get; set; }

		[JsonProperty("soBillingContact", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(WrapWithValueConverter<Contact>))]
		public Contact SoBillingContact { get; set; }
	}
}