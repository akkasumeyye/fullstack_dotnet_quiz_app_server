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
    public class Question :IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QnID { get; set; }
        [StringLength(250)]
        public string QnInWords { get; set; }
        [StringLength(50)]
        public string QnImage { get; set; }
        [StringLength(50)]
        public string Option1 { get; set; }
        [StringLength(50)]
        public string Option2 { get; set; }
        [StringLength(50)]
        public string Option3 { get; set; }
        [StringLength(50)]
        public string Option4 { get; set; }
        public int Answer { get; set; }
    }
}
