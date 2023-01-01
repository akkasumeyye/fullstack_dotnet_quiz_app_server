using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuizBusiness.Abstract;
using QuizDataAccess;
using QuizEntities.Concrete;

namespace QuizAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipantsController : Controller
    {
        IParticipantService _participantService;

        public ParticipantsController(IParticipantService participantService)
        {
            _participantService= participantService;
        }

        // GET: Participants
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var participants = await _participantService.GetAllParticipants();
            return Ok(participants);
        }

        [HttpPost]
        [Route("signin")]
        public async Task<IActionResult> CreateParticipant([FromBody] Participant participant)
        {
            var createdParticipant = await _participantService.CreateParticipant(participant);
            return CreatedAtAction("Get", new { id = createdParticipant.ParticipantID }, createdParticipant);
        }

    }
}
