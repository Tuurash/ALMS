using Alpha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Alpha.Repository
{
    public class ReliefRepo : Repository<ReliefTB>, IReliefRepo
    {


        public IEnumerable<ReliefTB> GetHighestPaidEmployees()
        {
            throw new NotImplementedException();
        }
    }
}