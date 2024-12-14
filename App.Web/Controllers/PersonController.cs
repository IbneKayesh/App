using System.Data;

namespace App.Web.Controllers
{
    public class PersonController : BaseController
    {
        //private static MemoryCache memoryCache = new MemoryCache(new MemoryCacheOptions());

        //string CahceName = "personCache";
        //private readonly AppDbContext _context;
        //public PersonController(AppDbContext context)
        //{
        //    _context = context;
        //}
        public IActionResult Index()
        {
            //if (memoryCache.TryGetValue(CahceName, out var result))
            //{
            //    return View(result);
            //}

            //var dataSet = _context.Person.ToList();
            //foreach (var item in dataSet)
            //{
            //    item.FullAddress = item.PresentAddress + ", " + item.PermanentAddress;
            //}

            //memoryCache.Set(CahceName, dataSet, TimeSpan.FromSeconds(30));
            //TempData["msg"] = NotifyService.Success(dataSet.Count + " nos data loaded");
           // return View(dataSet);
            return View();
        }

        [HttpGet]
        public IActionResult AddOrEdit(string? Id)
        {
            var person = new Person();
            if (!string.IsNullOrWhiteSpace(Id))
            {
                //person = _context.Person.Find(Id);
              //  person = _context.Person.Where(x => x.Id == Id).FirstOrDefault();
            }
            return View(person);
        }
        [HttpPost]
        public IActionResult AddOrEdit(Person person)
        {
            if (ModelState.IsValid)
            {
                bool CanSave = false;
                if (person.Id == Guid.Empty.ToString())
                {
                    person.Id = Guid.NewGuid().ToString();
                  //  _context.Person.Add(person);
                    CanSave = true;
                    TempData["msg"] = NotifyService.Success("Successfully saved");
                }
                else
                {
                    //var personEntity = _context.Person.Where(p => p.RowVersion == person.RowVersion && p.Id == person.Id).FirstOrDefault();
                    //if (personEntity != null)
                    //{
                    //    personEntity.Name = person.Name;
                    //    personEntity.Gender = person.Gender;
                    //    personEntity.Height = person.Height;
                    //    personEntity.Weight = person.Weight;
                    //    personEntity.DOB = person.DOB;
                    //    personEntity.HairColor = person.HairColor;
                    //    personEntity.PresentAddress = person.PresentAddress;
                    //    personEntity.PermanentAddress = person.PermanentAddress;
                    //    _context.Entry(personEntity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    //    CanSave = true;
                    //    TempData["msg"] = NotifyService.Success("Successfully edited");
                    //}
                    //else
                    //{
                    //    //ViewData["ErrorMessage"] = "Data not found or edit restricted";
                    //    TempData["msg"] = NotifyService.Error("Data not found or edit restricted");
                    //    return View(person);
                    //}
                }
                if (CanSave)
                {
                   // _context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            else
            {
                string errorMessage = string.Join(" | ", ModelState.Values.SelectMany(e => e.Errors).Select(s => s.ErrorMessage));
                ViewData["ErrorMessage"] = errorMessage;
            }
            return View(person);
        }
        public IActionResult Delete(string? Id)
        {
            if (!string.IsNullOrWhiteSpace(Id))
            {
                //var person = _context.Person.Where(x => x.Id == Id).FirstOrDefault();
                //if (person != null)
                //{
                //    _context.Person.Remove(person);
                //    _context.SaveChanges();
                //    TempData["msg"] = NotifyService.Success("Data Deleted");
                //}
            }
            else
            {
                TempData["msg"] = NotifyService.Error("Data is not found");
            }
            return RedirectToAction("Index");
        }
    }
}
