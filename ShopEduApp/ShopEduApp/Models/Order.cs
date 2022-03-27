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

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата заказа")]
        public DateTime OrderDate { get; set; }


        [Display(Name = "Состав заказа")]
        public List <String> GoodsOrdered { get; set; }
        [Display(Name = "Способ доставки")]
        public string DeliveryMode { get; set; }
        
        [Display(Name = "Статус доставки")]
        public string DeliveryStatus { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата доставки")]
        public DateTime DeliveryDate { get; set; }

        [Display(Name = "Цена заказа")]
        public decimal Price { get; set; }
    }


}