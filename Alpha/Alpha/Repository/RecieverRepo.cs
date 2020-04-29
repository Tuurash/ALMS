using Alpha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Alpha.Repository
{
    public class RecieverRepo : Repository<RecieverTB>, IRecieverRepo
    {


        public IEnumerable<RecieverTB> GetHighestPaidEmployees()
        {
            throw new NotImplementedException();
        }
    }
}