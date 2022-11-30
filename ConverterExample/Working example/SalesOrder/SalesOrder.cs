using ConverterExample.WorkingExample.Converters;
using Newtonsoft.Json;

namespace ConverterExample.WorkingExample.SalesOrder
{
	public class SalesOrder
	{
		[JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(DtoJsonConverter<int?>))]
		public int? Project { get; set; }

		[JsonProperty("printDescriptionOnInvoice", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(DtoJsonConverter<bool>))]
		public bool PrintDescriptionOnInvoice { get; set; }

		[JsonProperty("printNoteOnExternalDocuments", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(DtoJsonConverter<bool>))]
		public bool PrintNoteOnExternalDocuments { get; set; }

		[JsonProperty("printNoteOnInternalDocuments", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(DtoJsonConverter<bool>))]
		public bool PrintNoteOnInternalDocuments { get; set; }

		[JsonProperty("soBillingContact", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ContactDtoJsonConverter))]
		public Contact SoBillingContact { get; set; }
	}
}