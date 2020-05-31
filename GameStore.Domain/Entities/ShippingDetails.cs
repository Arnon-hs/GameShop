using System.ComponentModel.DataAnnotations;

namespace GameStore.Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Укажите как вас зовут")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Укажите email")]
        [Display(Name = "Email")]
        public string Line2 { get; set; }

        [Required(ErrorMessage = "Вставьте первый адрес доставки")]
        [Display(Name="Первый адрес")]
        public string Line1 { get; set; }

        [Required(ErrorMessage = "Укажите город")]
        [Display(Name = "Город")]
        public string City { get; set; }

        [Required(ErrorMessage = "Укажите страну")]
        [Display(Name = "Страна")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }
    }
}
