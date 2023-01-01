using QuizEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizBusiness.Abstract
{
    public interface IQuestionService
    {
        Task<List<Question>> GetAllQuestions();
        Task<Question> GetQuestionById(int id);
        Task<Question> CreateQuestion(Question question);
        Task<Question> UpdateQuestion(Question question);
        Task DeleteQuestion(int id);
    }
}
