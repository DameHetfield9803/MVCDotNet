namespace MVCPersonal.Models
{
	public class People
	{
		public int Id { get; set; }
		public string name { get; set; } = null!;
		public int age { get; set; }
		public string address { get; set; } = null!;
		public int postalCode { get; set; }
		public string description { get; set; } = null!;

		public string profile { get; set; } = null!;

		public int phoneNumber { get; set; }

		public int telephoneNumbner { get; set; }

		public string nextOfKin { get; set; } = null!;

		public int nextOfPhoneNumber { get; set; }

		public bool liveWithKin { get; set; }

		// Damien Foo
	}
}
