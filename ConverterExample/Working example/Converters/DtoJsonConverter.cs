using ConverterExample.WorkingExample.CustomDto;
using Newtonsoft.Json;

namespace ConverterExample.WorkingExample.Converters
{
	public class DtoJsonConverter<T> : JsonConverter<T>
	{
		public override bool CanRead => false;
		public override bool CanWrite => true;

		public override void WriteJson(JsonWriter writer, T value, JsonSerializer serializer)
		{
			serializer.Serialize(writer, new DtoObject<T> { Value = value });
		}

		public override T ReadJson(JsonReader reader, Type objectType, T? existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			throw new NotImplementedException();
		}
	}
}
