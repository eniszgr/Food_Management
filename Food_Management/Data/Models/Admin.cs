using System.ComponentModel.DataAnnotations;

namespace Food_Management.Data.Models
{
	public class Admin
	{
		[Key]
		public int AdminID {  get; set; }
		
		[StringLength(20)]
		public string AdminName { get; set; }

		[StringLength(20)]
		public string Password { get; set; }

		[StringLength(1)]
		public string AdminRole { get; set; }
    }
}
