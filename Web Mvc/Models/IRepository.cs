using System.Linq.Expressions;

namespace WebUygulamaProje1.Models
{
	public interface IRepository<T> where T : class
	{
		// T-->YemekTuru

		IEnumerable<T> GetAll();

		T Get(Expression<Func<T, bool>> filtre);
		void Ekle(T entity);

		void Sil(T entity);

		void SilAralık(IEnumerable<T> entities);

	}
}
