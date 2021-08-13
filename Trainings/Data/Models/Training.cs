using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Training : Base
    {
        public Profile profile { get; set; }
        public Content content { get; set; }
        public Schedule schedule { get; set; }
        //public Evaluation evaluation { get; set; }
    }
}
