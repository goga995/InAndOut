using System.ComponentModel.DataAnnotations;

namespace InAndOut.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        public string Item { get; set; }
        public int Price { get; set; }

        
    }
}