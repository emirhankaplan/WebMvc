using Microsoft.AspNetCore.Mvc;
using WebUygulamaProje1.Models;
using WebUygulamaProje1.Utility;

namespace WebUygulamaProje1.Controllers
{
    public class YemekTuruController : Controller
    {

        private readonly IYemekTuruRepository _yemekTuruRepository;

        public YemekTuruController(IYemekTuruRepository context)
        {

			_yemekTuruRepository = context;

        }


        public IActionResult Index()
        {

            List<YemekTuru> objYemekTuruList = _yemekTuruRepository.GetAll().ToList();
            return View(objYemekTuruList);
        }

        public IActionResult Ekle()
        {

            return View();

        }
        [HttpPost]
		public IActionResult Ekle(YemekTuru yemekTuru)
        {
			

			if (ModelState.IsValid)
            {
                _yemekTuruRepository.Ekle(yemekTuru);
                _yemekTuruRepository.Kaydet(); //SaveChanges yapılmazsa bilgiler veri tabanına aktarılmaz!!
				TempData["basarili"] = "Yeni Yemek Türü başarıyla oluşturuldu!";
				return RedirectToAction("Index", "YemekTuru");
            }
            return View();

		}

		public IActionResult Guncelle(int? id)
		{
            if (id == null || id==0) 
            {
                return NotFound();
            }

            YemekTuru? yemekTuruVt=_yemekTuruRepository.Get(u=>u.Id==id);

            if(yemekTuruVt == null)
            {

                return NotFound();

            }

			return View(yemekTuruVt);

		}
		[HttpPost]
		public IActionResult Guncelle(YemekTuru yemekTuru)
		{


			if (ModelState.IsValid)
			{

				_yemekTuruRepository.Guncelle(yemekTuru);
				_yemekTuruRepository.Kaydet(); //SaveChanges yapılmazsa bilgiler veri tabanına aktarılmaz!!
				TempData["basarili"] = "Yemek Türü başarıyla güncellendi!";
				return RedirectToAction("Index", "YemekTuru");
			}
			return View();

		}

		public IActionResult Sil(int? id)
		{
			if (id == null || id == 0)
			{
				return NotFound();
			}

			YemekTuru? yemekTuruVt = _yemekTuruRepository.Get(u => u.Id == id);

			if (yemekTuruVt == null)
			{

				return NotFound();

			}

			return View(yemekTuruVt);

		}

		[HttpPost,ActionName("Sil")]
		public IActionResult SilPOST(int? id)
		{


			YemekTuru? yemekTuru = _yemekTuruRepository.Get(u => u.Id == id);
			if (yemekTuru == null)
			{

				return NotFound();

			}

			_yemekTuruRepository.Sil(yemekTuru);
			_yemekTuruRepository.Kaydet();
			TempData["basarili"] = "Yemek türü başarıyla silindi";
			return RedirectToAction("Index", "YemekTuru");


		}

	}
}
