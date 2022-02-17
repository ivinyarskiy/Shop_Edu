using System.ComponentModel.DataAnnotations;

namespace ShopEduApp
{
    public class Goods
    {
        [Key]
        public int GoodsId { get; set; }
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

    public class Customer
    {
        [Key]
        public int CustomersId { get; set; }
        [Display(Name = "Имя")]
        public string CustomersName { get; set; }
        [Display(Name = "Фамилия")]
        public string CustomersSurname { get; set; }
        [Display(Name = "Отчество (при наличии)")]
        public string CustomersSecondName { get; set; }
        [Display(Name = "Адрес")]
        public string CustomersAddress { get; set; }
        [Display(Name = "Email")]
        public string CustomersEmail { get; set; }
        [Display(Name = "Телефон")] 
        public string CustomersPhone { get; set; }
    }

    public class Payments
    {
        [Key]
        public int PaymentId { get; set; }
        public int OrderId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        
    }

}