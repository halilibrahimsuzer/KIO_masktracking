using System;
namespace Entities.Concrete
{
	public class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public ulong NationalIdentity { get; set; }
		public ushort DateOfBirthYear { get; set; }
	}
}

