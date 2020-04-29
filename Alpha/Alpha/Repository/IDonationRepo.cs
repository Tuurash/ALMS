using Alpha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Alpha.Repository
{
    interface IDonationRepo : IRepository<DonationTB>
    {
        IEnumerable<DonationTB> GetHighestPaidEmployees();
        List<DonationTB> GetDonorContribute(int donorid);
    }
}
