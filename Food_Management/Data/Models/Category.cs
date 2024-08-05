using System.ComponentModel.DataAnnotations;

namespace Food_Management.Data.Models
{
	public class Category
	{
		
		public int CategoryID {  get; set; }
		[Required(ErrorMessage ="'Category Name' can not bu NULL")]
		public string CategoryName { get; set; }
		public string CategoryDescription { get; set; }
		public List<Food> Foods { get; set; }
	}
}
