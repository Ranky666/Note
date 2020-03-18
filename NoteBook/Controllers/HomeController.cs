using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NoteBook.Models;
using Microsoft.EntityFrameworkCore;
using NoteBook.BL.Interfaces;
using NoteBook.DAL.EF;
using NoteBook.Common;
using NUnit.Framework;
using AutoMapper;
using System.Text;

namespace NoteBook.Controllers
{
    public class HomeController : Controller
    {
        private readonly INoteService _noteService;

        private readonly IMapper _mapper;



        public HomeController(INoteService noteService, IMapper mapper)
        {
            _noteService = noteService;
            _mapper = mapper;
        }
      


        public IActionResult Index(string SearchString)
        {

            return View(_mapper.Map<List<Note>>(_noteService.GetNotes(SearchString)));


        }


        public IActionResult Create()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Create(Note noteDTO)
        {

            _noteService.CreateNote(new NoteDTO(){ Task = noteDTO.Task });
            return RedirectToAction("Index");
        }

     

        public IActionResult Edit(int id)
        {
            var editedNote = _noteService.GetNote(id);
            return View(_mapper.Map(editedNote, new Note()));
        }

        [HttpPost]
        public IActionResult Edit(Note model)
        {

            _noteService.EditNote(_mapper.Map(model, new NoteDTO()));

            return RedirectToAction("Index"); 
        }



        [HttpGet]
        [ActionName("Delete")]
        public  IActionResult Delete(int id)
        {
            if (id != null)
            {
                _noteService.DeleteNote(id);
                return RedirectToAction("Index");
            }

            return NotFound();
        }



        public IActionResult Details(int id)
        {
            var detailedNote = _noteService.GetNote(id);
            return View(_mapper.Map(detailedNote, new Note()));
           
        }

        public IActionResult Duplicate(string task)
        {
            _noteService.CreateNote(new NoteDTO() { Task = task });
            return RedirectToAction("Index");
        }


        public IActionResult DuplicateThree(string task)
        {

            for (int i = 1; i <= 2; i++)
            {
                _noteService.CreateNote(new NoteDTO() { Task = task });
               
 
                
            }

            
            return RedirectToAction("Index");

        }

     



    }
}
