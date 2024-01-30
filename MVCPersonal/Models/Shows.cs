using Microsoft.AspNetCore.Mvc;

namespace MVCPersonal.Models
{
	public class Shows
	{
		public int id { get; set; }
		public string showName { get; set; } = ""!;
		public string description { get; set; } = ""!;
	}
}
