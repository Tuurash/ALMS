using Alpha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Alpha.Repository
{
    public class DonationRepo : Repository<DonationTB>, IDonationRepo
    {


        public IEnumerable<DonationTB> GetHighestPaidEmployees()
        {
            throw new NotImplementedException();
        }
    }
}