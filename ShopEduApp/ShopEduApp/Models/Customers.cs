using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace ShopEduApp
    {
        public class Customer
        {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
}
