using System.ComponentModel.DataAnnotations;

namespace WaliulOnlineShop.Models
{
    public class SpecialTag
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
