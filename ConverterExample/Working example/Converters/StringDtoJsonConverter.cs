using ConverterExample.WorkingExample.CustomDto;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ConverterExample.WorkingExample.Converters
{
	public class StringDtoJsonConverter : JsonConverter<string>
    {
		public override string ReadJson(JsonReader reader, Type objectType, string existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			return (string)reader.Value;
		}

		public override void WriteJson(JsonWriter writer, string value, JsonSerializer serializer)
		{
			JToken t = JToken.FromObject(value);

			if (t.Type != JTokenType.Object)
			{
				var dtoValue = new DtoString
				{
					Value = value
				};

				serializer.Serialize(writer, dtoValue);
			}
		}
	}
}
