using DailyDiary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DailyDiary.Data;
namespace DailyDiary.Controllers
{

	public class DiaryController : Controller
	{
        private readonly DiaryContext _context;

        public DiaryController(DiaryContext context)
        {
            _context = context;
        }

        [HttpGet("/diary")]
        public IActionResult Index()
		{
			return View();
		}

		public IActionResult Create()
		{
			return View();
		}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  async Task<IActionResult> Create(Diary diary)
        {
            if (ModelState.IsValid)
            {
                await _context.Diary.AddAsync(diary);
                await _context.SaveChangesAsync();
                return View("Index");
            }
            return View(diary); // Return the view with the current model if validation fails
        }

        [HttpGet("/diary/Lists")]
        public async Task<IActionResult> ListAsync()
        {
            List<Diary> diaries = await _context.Diary.ToListAsync();
            return View(diaries);
        }

        public ActionResult Delete(int id)
        {
            var item = _context.Diary.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var item = _context.Diary.Find(id);
            if (item == null)
            {
                return NotFound();
            }

            _context.Diary.Remove(item);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var item = _context.Diary.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditConfirmed(Diary diary)
        {
            var id = diary.SrNo;
            var item =  _context.Diary.Find(id);
            if (item == null)
            {
                return NotFound();
            }

            _context.Diary.Remove(item);
            await _context.Diary.AddAsync(diary);
            await _context.SaveChangesAsync();
            return RedirectToAction("List");
        }

        public ActionResult Details(int id)
        {
            var item = _context.Diary.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }
    }
}
