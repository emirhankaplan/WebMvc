using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebUygulamaProje1.Models
{
    public class YemekTuru
    {
        [Key]    //primary key
        public int Id { get; set; }

        [Required(ErrorMessage ="Yemek Türü Adı Boş Bırakılamaz!!!")] //not null
        [MaxLength(25)]
        [DisplayName("Yemek İsmi:")]
        public string Ad { get; set; }

    }
}
