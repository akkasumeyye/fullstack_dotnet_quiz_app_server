using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuizBusiness.Abstract;
using QuizBusiness.Concrete;
using QuizDataAccess;
using QuizEntities.Concrete;

namespace QuizAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : Controller
    {
        IQuestionService _questionservice;

        public QuestionsController(IQuestionService questionservice)
        {
            _questionservice = questionservice;
        }

        [HttpGet]
        // GET: Questions
        public async Task<IActionResult> GetAll()
        {
            var questions = await _questionservice.GetAllQuestions();
            return Ok(questions);
        }

        //// GET: Questions/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    return Ok();
        //}

        //// GET: Questions/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Questions/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("QnID,QnInWords,QnImage,Option1,Option2,Option3,Option4,Answer")] Question question)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(question);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(question);
        //}

        //// GET: Questions/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.Questions == null)
        //    {
        //        return NotFound();
        //    }

        //    var question = await _context.Questions.FindAsync(id);
        //    if (question == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(question);
        //}

        //// POST: Questions/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("QnID,QnInWords,QnImage,Option1,Option2,Option3,Option4,Answer")] Question question)
        //{
        //    if (id != question.QnID)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(question);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!QuestionExists(question.QnID))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(question);
        //}

        //// GET: Questions/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.Questions == null)
        //    {
        //        return NotFound();
        //    }

        //    var question = await _context.Questions
        //        .FirstOrDefaultAsync(m => m.QnID == id);
        //    if (question == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(question);
        //}

        //// POST: Questions/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.Questions == null)
        //    {
        //        return Problem("Entity set 'QuizDbContext.Questions'  is null.");
        //    }
        //    var question = await _context.Questions.FindAsync(id);
        //    if (question != null)
        //    {
        //        _context.Questions.Remove(question);
        //    }
            
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool QuestionExists(int id)
        //{
        //  return _context.Questions.Any(e => e.QnID == id);
        //}
    }
}
