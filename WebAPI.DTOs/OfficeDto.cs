using System;

namespace WebAPI.DTOs;

public class OfficeDto
{
	public int Id { get; set; }

	public string Name { get; set; }

	public string FirstName { get; set; }

	public string MiddleName { get; set; }

	public string LastName { get; set; }

	public uint MaxOccupancy { get; set; }
	
}
