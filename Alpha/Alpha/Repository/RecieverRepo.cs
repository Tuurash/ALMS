using Alpha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Alpha.Repository
{
    public class RecieverRepo : Repository<RecieverTB>, IRecieverRepo
    {
        CovidDatacontext context=new CovidDatacontext();

        public IEnumerable<RecieverTB> GetHighestPaidEmployees()
        {
            throw new NotImplementedException();
        }

        public List<RecieverTB> GetReciverAccordingArea(int addressID)
        {
            List<RecieverTB> list = context.RecieverTBs.Where(x => x.AddressID == addressID).ToList();
            return list;
        }
    }
}