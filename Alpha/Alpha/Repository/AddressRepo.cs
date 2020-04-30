using Alpha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Alpha.Repository
{
    public class AddressRepo : Repository<AddressTB>, IAddressRepo
    {


        public IEnumerable<AddressTB> GetHighestPaidEmployees()
        {
            throw new NotImplementedException();
        }
    }
}