using System;

namespace WebAPI.DTOs;

public class OfficeDto
{
	public int Id { get; set; }

	public String Name { get; set; }

	public String FirstAndMiddleNames { get; set; }

	public String LastName { get; set; }

	public uint MaxOccupancy { get; set; }
}

