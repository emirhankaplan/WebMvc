namespace WebUygulamaProje1.Models
{
	public interface IYemekRepository : IRepository<Yemek>
	{
		void Guncelle(Yemek yemek);
		void Kaydet();


	}
}
