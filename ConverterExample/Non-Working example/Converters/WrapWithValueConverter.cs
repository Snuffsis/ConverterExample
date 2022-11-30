using Newtonsoft.Json;

namespace ConverterExample.NonWorkingExample.Converters
{
	public class WrapWithValueConverter<TValue> : JsonConverter
	{
		// Here we take advantage of the fact that a converter applied to a property has highest precedence to avoid an infinite recursion.
		class DTO
		{
			public TValue Value { get; set; }
			public object GetValue() => Value;
		}

		public override bool CanConvert(Type objectType) => typeof(TValue).IsAssignableFrom(objectType);

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
			=> serializer.Serialize(writer, new DTO { Value = (TValue)value });

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
			=> serializer.Deserialize<DTO>(reader)?.GetValue();
	}

	public class NoConverter : JsonConverter
	{
		// NoConverter taken from this answer https://stackoverflow.com/a/39739105/3744182
		// By https://stackoverflow.com/users/3744182/dbc
		// To https://stackoverflow.com/questions/39738714/selectively-use-default-json-converter
		public override bool CanConvert(Type objectType) { throw new NotImplementedException(); /* This converter should only be applied via attributes */ }
		public override bool CanRead => false;
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotImplementedException();
		public override bool CanWrite => false;
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => throw new NotImplementedException();
	}
}
