using QuizDataAccess.Abstract;
using QuizDataAccess.Concrete.EntityFramework;
using QuizEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QuizDataAccess.Concrete
{
    public class EfParticipantDal : EfEntityRepositoryBase<Participant, QuizDbContext>, IParticipantDal
    {
       
    }
}
