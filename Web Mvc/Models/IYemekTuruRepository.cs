namespace WebUygulamaProje1.Models
{
	public interface IYemekTuruRepository : IRepository<YemekTuru>
	{
		void Guncelle(YemekTuru yemekTuru);
		void Kaydet();


	}
}
