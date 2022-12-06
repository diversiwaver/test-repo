using System;

namespace WebAPI.DTOs;

public class EmployeeDto
{
	public int Id { get; set; }
	
	public string FirstName { get; set; }
	public string MiddleName { get; set; }

	public string LastName { get; set; }

	public DateTime BirthDate { get; set; }

	public int OfficeId { get; set; }
}

