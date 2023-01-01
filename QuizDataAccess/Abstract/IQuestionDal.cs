using QuizEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizDataAccess.Abstract
{
    public interface IQuestionDal : IEntityRepository<Question>
    {

    }
}
