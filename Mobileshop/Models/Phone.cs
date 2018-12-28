

using System.ComponentModel.DataAnnotations;

namespace Mobileshop.Models
{
    public class Phone
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Display(Name = "Цена")]
        public double Price { get; set; }
        [Display(Name = "Производитель")]
        public string Producent { get; set; }
        [Display(Name = "Модель")]
        public string Model { get; set; }
        [Display(Name = "Цвета")]
        public string Colors { get; set; }
        [Display(Name = "Диагональ")]
        public double Diagonal { get; set; }
    }
    
}