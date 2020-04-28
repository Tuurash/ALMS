using Alpha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Alpha.Repository
{
    public class AdminRepo : Repository<AdminTB>, IAdminRepo
    {


        public IEnumerable<AdminTB> GetHighestPaidEmployees()
        {
            throw new NotImplementedException();
        }
    }
}