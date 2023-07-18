using System.ComponentModel.DataAnnotations;
namespace SPT.Models
{
	public class Bookings
	{
		[Key]
		public int Id { get; set; }

		[Required]

		public int LoginId { get; set; }
		public string? Name { get; set; }
		public float Cost { get; set; }
		public string? Tool { get; set; }
		[DataType(DataType.Date)]
		public DateTime Date { get; set; }
		public int Duration { get; set; }
	}
}

