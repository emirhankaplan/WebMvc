using Microsoft.IdentityModel.Tokens;
using WebUygulamaProje1.Utility;

namespace WebUygulamaProje1.Models
{
	public class YemekRepository : Repository<Yemek>, IYemekRepository
	{

		private UygulamaDbContext _uygulamaDbContext;
		public YemekRepository(UygulamaDbContext uygulamaDbContext) : base(uygulamaDbContext)
		{
			_uygulamaDbContext = uygulamaDbContext;
			
		}

		public void Guncelle(Yemek yemek)
		{
			_uygulamaDbContext.Update(yemek);
		}

		public void Kaydet()
		{
			_uygulamaDbContext.SaveChanges();
		}
	}
}
