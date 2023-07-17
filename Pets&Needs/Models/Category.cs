using System.ComponentModel.DataAnnotations;

namespace Pets_Needs.Models
{
	public class Category
	{
		[Key]
        public int Id { get; set; }                                          /// this a row and column name
		[Required]
		public string Name { get; set; }
		public int DisplayOrder { get; set; }
    }
}
