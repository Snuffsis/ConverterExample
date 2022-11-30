using ConverterExample.WorkingExample.CustomDto;
using ConverterExample.WorkingExample.SalesOrder;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ConverterExample.WorkingExample.Converters
{
	public class ContactDtoJsonConverter : JsonConverter<Contact>
	{
		public override bool CanRead => false;

		public override bool CanWrite => true;

		public override Contact ReadJson(JsonReader reader, Type objectType, Contact existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			throw new NotImplementedException();
		}

		public override void WriteJson(JsonWriter writer, Contact value, JsonSerializer serializer)
		{
			var dtoContact = new DtoContact
			{
				Value = value
			};
			JToken t = JToken.FromObject(dtoContact);

			JObject o = (JObject)t;
			o.WriteTo(writer);
		}
	}
}
