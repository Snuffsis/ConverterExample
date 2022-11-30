using ConverterExample.WorkingExample.SalesOrder;
using Newtonsoft.Json;

namespace ConverterExample
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region working example
			// Working example code below
			var vSalesOrder = new WorkingExample.SalesOrder.SalesOrder()
			{
				Project = 0,
				PrintDescriptionOnInvoice = true,
				PrintNoteOnExternalDocuments = true,
				PrintNoteOnInternalDocuments = true,
				SoBillingContact = new Contact
				{
					Attention = "attention",
					Email = "email@email.com",
					Fax = "faxnr",
					Name = "Namesson",
					OverrideContact = false,
					Phone1 = "number1",
					Phone2 = "number2",
					Web = "website"
				}
			};

			// When converting the above object into JSON, it should match the output in the file "SalesOrderUpdate.json"
			var jsonString = JsonConvert.SerializeObject(vSalesOrder);

			// When reading a JSON file from the system, it will follow regular convention. So it should be able to read the file in "SalesOrderGet.json"
			// and deserialize it into the corresponding object
			using StreamReader r = new("SalesOrderGet.Json");
			string json = r.ReadToEnd();

			var jsonObject = JsonConvert.DeserializeObject<SalesOrder>(json);

			#endregion

			#region non-working example
			var vSalesOrder1 = new NonWorkingExample.SalesOrder.SalesOrder()
			{
				Project = 0,
				PrintDescriptionOnInvoice = true,
				PrintNoteOnExternalDocuments = true,
				PrintNoteOnInternalDocuments = true,
				SoBillingContact = new NonWorkingExample.SalesOrder.Contact
				{
					Attention = "attention",
					Email = "email@email.com",
					Fax = "faxnr",
					Name = "Namesson",
					OverrideContact = false,
					Phone1 = "number1",
					Phone2 = "number2",
					Web = "website"
				}
			};

			// When converting the above object into JSON, it should match the output in the file "SalesOrderUpdate.json"
			var jsonString1 = JsonConvert.SerializeObject(vSalesOrder1);

			// When reading a JSON file from the system, it will follow regular convention. So it should be able to read the file in "SalesOrderGet.json"
			// and deserialize it into the corresponding object
			using StreamReader r1 = new("SalesOrderGet.Json");
			string json1 = r.ReadToEnd();

			var jsonObject1 = JsonConvert.DeserializeObject<SalesOrder>(json1);
			#endregion
		}
	}
}