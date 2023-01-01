using QuizBusiness.Abstract;
using QuizDataAccess.Abstract;
using QuizEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizBusiness.Concrete
{
    public class ParticipantManager : IParticipantService
    {
        IParticipantDal _participantdal;
        public ParticipantManager(IParticipantDal participantdal) {
            _participantdal= participantdal;
        }
        public async Task<Participant> CreateParticipant(Participant participant)
        {
            return await _participantdal.Add(participant);
        }

        public Task DeleteParticipant(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Participant>> GetAllParticipants()
        {
            return Task.FromResult(_participantdal.GetAll());
        }

        public Task<Participant> GetParticipantById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Participant> UpdateParticipant(Participant participant)
        {
            throw new NotImplementedException();
        }
    }
}
