using Alpha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Alpha.Repository
{
    public class DonorRepo : Repository<DonorTB>, IDonorRepo
    {


        public IEnumerable<DonorTB> GetHighestPaidEmployees()
        {
            throw new NotImplementedException();
        }
    }
}