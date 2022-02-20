using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace ShopEduApp
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        [Display(Name = "Наименование")]
        public string GoodsName { get; set; }
        [Display(Name = "Производитель")]
        public string GoodsBrand { get; set; }
        [Display(Name = "Модель")]
        public string GoodsModel { get; set; }
        [Display(Name = "Страна производства")]
        public string GoodsCountry { get; set; }
        [Display(Name = "Цена")]
        public decimal Price { get; set; }
    }


}