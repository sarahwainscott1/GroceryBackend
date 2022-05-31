using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryBackend {
    public class GroceryItem {
        public int Id { get; set; }
        [StringLength(50)]
        public string Description { get; set; } = string.Empty;
        [Column(TypeName = "decimal(5,2)")]
        public decimal Price { get; set; } = 0;
        public int Quantity { get; set; } = 0;


    }
}
