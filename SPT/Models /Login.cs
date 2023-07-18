using System;
using System.ComponentModel.DataAnnotations;
namespace SPT.Models
{
	public class Login
	{
		[Key]
		public int Id { get; set; }

		[Required]

		public string? Username { get; set; }
		public string? Password { get; set; }
	}
}

