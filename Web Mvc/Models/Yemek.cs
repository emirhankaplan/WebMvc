using System.ComponentModel.DataAnnotations;

namespace WebUygulamaProje1.Models
{
	public class Yemek
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string YemekAdi { get; set; }

		public string Tanim { get; set;}

		[Required]
		[Range(10,2000)]
		public double Fiyat {  get; set; }

		
	}
}
