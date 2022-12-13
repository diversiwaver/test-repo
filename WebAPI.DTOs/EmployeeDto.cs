using System;

namespace WebAPI.DTOs
{
	public class EmployeeDto
	{
		public int Id { get; set; }
		
		public String FirstAndMiddleNames { get; set; }

		public String LastName { get; set; }

		public DateTime BirthDate { get; set; }


		public int OfficeId { get; set; }
	}
}

