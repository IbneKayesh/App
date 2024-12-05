﻿namespace App.Web.Controllers
{
    public class PersonController : BaseController
    {
        private static MemoryCache memoryCache = new MemoryCache(new MemoryCacheOptions());

        string CahceName = "personCache";
        private readonly AppDbContext _context;
        public PersonController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (memoryCache.TryGetValue(CahceName, out var result))
            {
                return View(result);
            }

            var dataSet = _context.Person.ToList();
            foreach (var item in dataSet)
            {
                item.FullAddress = item.PresentAddress + ", " + item.PermanentAddress;
            }

            memoryCache.Set(CahceName, dataSet, TimeSpan.FromSeconds(30));

            return View(dataSet);
        }

        [HttpGet]
        public IActionResult AddOrEdit(int? Id)
        {
            var person = new Person();
            if (Id != null || Id != 0)
            {
                //person = _context.Person.Find(Id);
                person = _context.Person.Where(x => x.Id == Id).FirstOrDefault();
            }
            return View(person);
        }
        [HttpPost]
        public IActionResult AddOrEdit(Person person)
        {
            if (ModelState.IsValid)
            {
                var personEntity = _context.Person.Find(person.Id);
                if (personEntity != null)
                {
                    personEntity.Name = person.Name;
                    personEntity.Gender = person.Gender;
                    personEntity.Height = person.Height;
                    personEntity.Weight = person.Weight;
                    personEntity.DOB = person.DOB;
                    personEntity.HairColor = person.HairColor;
                    personEntity.PresentAddress = person.PresentAddress;
                    personEntity.PermanentAddress = person.PermanentAddress;
                    _context.Entry(personEntity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                else
                {
                    _context.Person.Add(person);
                }
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(person);
        }
        public IActionResult Delete(int? Id)
        {
            if (Id != null || Id != 0)
            {
                var person = _context.Person.Find(Id);
                _context.Person.Remove(person);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
