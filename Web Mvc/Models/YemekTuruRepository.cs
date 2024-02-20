using Microsoft.IdentityModel.Tokens;
using WebUygulamaProje1.Utility;

namespace WebUygulamaProje1.Models
{
	public class YemekTuruRepository : Repository<YemekTuru>, IYemekTuruRepository
	{

		private UygulamaDbContext _uygulamaDbContext;
		public YemekTuruRepository(UygulamaDbContext uygulamaDbContext) : base(uygulamaDbContext)
		{
			_uygulamaDbContext = uygulamaDbContext;
			
		}

		public void Guncelle(YemekTuru yemekTuru)
		{
			_uygulamaDbContext.Update(yemekTuru);
		}

		public void Kaydet()
		{
			_uygulamaDbContext.SaveChanges();
		}
	}
}
