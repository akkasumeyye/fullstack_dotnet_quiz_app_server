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
    public class QuestionManager : IQuestionService
    {
        IQuestionDal _questiondal;
        public QuestionManager(IQuestionDal questiondal) { 
           _questiondal= questiondal;
        }
        public Task<Question> CreateQuestion(Question question)
        {
            throw new NotImplementedException();
        }

        public Task DeleteQuestion(int id)
        {
            throw new NotImplementedException();
        }

        public  Task<List<Question>> GetAllQuestions()
        {
            return Task.FromResult(_questiondal.GetAll());
        }

        public Task<Question> GetQuestionById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Question> UpdateQuestion(Question question)
        {
            throw new NotImplementedException();
        }
    }
}
