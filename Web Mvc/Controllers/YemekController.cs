using Microsoft.AspNetCore.Mvc;
using WebUygulamaProje1.Models;
using WebUygulamaProje1.Utility;

namespace WebUygulamaProje1.Controllers
{
    public class YemekController : Controller
    {

        private readonly IYemekRepository _yemekRepository;

        public YemekController(IYemekRepository context)
        {

			_yemekRepository = context;

        }


        public IActionResult Index()
        {

            List<Yemek> objYemekList = _yemekRepository.GetAll().ToList();
            return View(objYemekList);
        }

        public IActionResult Ekle()
        {

            return View();

        }
        [HttpPost]
		public IActionResult Ekle(Yemek yemek)
        {
			

			if (ModelState.IsValid)
            {
                _yemekRepository.Ekle(yemek);
                _yemekRepository.Kaydet(); //SaveChanges yapılmazsa bilgiler veri tabanına aktarılmaz!!
				TempData["basarili"] = "Yeni Yemek başarıyla oluşturuldu!";
				return RedirectToAction("Index", "Yemek");
            }
            return View();

		}

		public IActionResult Guncelle(int? id)
		{
            if (id == null || id==0) 
            {
                return NotFound();
            }

            Yemek? yemekVt= _yemekRepository.Get(u=>u.Id==id);

            if(yemekVt == null)
            {

                return NotFound();

            }

			return View(yemekVt);

		}
		[HttpPost]
		public IActionResult Guncelle(Yemek yemek)
		{


			if (ModelState.IsValid)
			{

				_yemekRepository.Guncelle(yemek);
				_yemekRepository.Kaydet(); //SaveChanges yapılmazsa bilgiler veri tabanına aktarılmaz!!
				TempData["basarili"] = "Yemek başarıyla güncellendi!";
				return RedirectToAction("Index", "Yemek");
			}
			return View();

		}

		public IActionResult Sil(int? id)
		{
			if (id == null || id == 0)
			{
				return NotFound();
			}

			Yemek? yemekVt = _yemekRepository.Get(u => u.Id == id);

			if (yemekVt == null)
			{

				return NotFound();

			}

			return View(yemekVt);

		}

		[HttpPost,ActionName("Sil")]
		public IActionResult SilPOST(int? id)
		{


			Yemek? yemek = _yemekRepository.Get(u => u.Id == id);
			if (yemek == null)
			{

				return NotFound();

			}

			_yemekRepository.Sil(yemek);
			_yemekRepository.Kaydet();
			TempData["basarili"] = "Yemek türü başarıyla silindi";
			return RedirectToAction("Index", "Yemek");


		}

	}
}
