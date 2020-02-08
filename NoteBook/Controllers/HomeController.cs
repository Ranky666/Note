using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NoteBook.Models;
using Microsoft.EntityFrameworkCore;

namespace NoteBook.Controllers
{
    public class HomeController : Controller
    {
        NoteContext db;
        public HomeController(NoteContext context)
        {
            db = context;
        }


        public async Task<IActionResult> Index(string searchString)
        {
            var notes = from m in db.Notes
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
               notes = notes.Where(s => s.Task.Contains(searchString));
            }

            return View(await notes.ToListAsync());
        }


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Note note)
        {

            db.Notes.Add(note);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Note note = await db.Notes.FirstOrDefaultAsync(p => p.Id == id);
                if (note != null)
                    return View(note);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Note note)
        {
            db.Notes.Update(note);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Note note = await db.Notes.FirstOrDefaultAsync(p => p.Id == id);
                if (note != null)
                    db.Notes.Remove(note);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            return NotFound();
        }



        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                Note note = await db.Notes.FirstOrDefaultAsync(p => p.Id == id);
                if (note != null)
                    return View(note);
            }
            return NotFound();
        }

    }
}
