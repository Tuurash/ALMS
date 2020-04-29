using Alpha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Alpha.Repository
{
    public class DonationRepo : Repository<DonationTB>, IDonationRepo
    {
        CovidDatacontext context;

        public DonationRepo()
        {
            context = new CovidDatacontext();
        }

        public IEnumerable<DonationTB> GetHighestPaidEmployees()
        {
            throw new NotImplementedException();
        }

        public List<DonationTB> GetDonorContribute(int donorid)
        {
            List<DonationTB> list = context.DonationTBs.Where(x => x.DonorID == donorid).ToList();
            return list;
        }

    }
}