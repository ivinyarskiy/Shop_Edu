using System.ComponentModel.DataAnnotations;

namespace ShopEduApp
{
    public class Goods
    {
        [Key]
        public int GoodsId { get; set; }
        public string GoodsName { get; set; }
        public string GoodsBrand { get; set; }
        public string GoodsModel { get; set; }
        public string GoodsCountry { get; set; }
        public decimal Price { get; set; }
    }

    public class Customer
    {
        [Key]
        public int CustomersId { get; set; }
        public string CustomersName { get; set; }
        public string CustomersSurname { get; set; }
        public string CustomersSecondName { get; set; }
        public string CustomersAddress { get; set; }
        public string CustomersEmail { get; set; }
        public string CustomersPhone { get; set; }
    }

    public class Payments
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        
    }

}