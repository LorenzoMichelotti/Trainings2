using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    class TrainingsContext : DbContext
    {
        public TrainingsContext():base(@"Data Source=192.168.0.194;Initial Catalog=Trainings;Persist Security Info=True;User ID=Trainings;Password=T@1234")
        {

        }
    }
}
