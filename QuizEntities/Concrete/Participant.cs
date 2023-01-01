using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizEntities.Abstract;

namespace QuizEntities.Concrete
{
    public class Participant :IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ParticipantID { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public int Score { get; set; }
        public int TimeTaken { get; set; }
    }
}
