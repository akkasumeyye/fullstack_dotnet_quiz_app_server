using QuizEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizBusiness.Abstract
{
    public interface IParticipantService
    {
        Task<List<Participant>> GetAllParticipants();
        Task<Participant> GetParticipantById(int id);
        Task<Participant> CreateParticipant(Participant participant);
        Task<Participant> UpdateParticipant(Participant participant);
        Task DeleteParticipant(int id);
    }
}
