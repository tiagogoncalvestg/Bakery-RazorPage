using System.ComponentModel.DataAnnotations.Schema;

namespace wwwroot.Models
{
    [Table("product")]
    public class Product
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name", TypeName = "varchar(70)")]
        public string Name { get; set; }
        [Column("description", TypeName = "varchar(70)")]
        public string Description { get; set; }
        [Column("price")]
        public decimal Price { get; set; }
        [Column("image_name", TypeName = "varchar(70)")]
        public string ImageName { get; set; }
    }
}