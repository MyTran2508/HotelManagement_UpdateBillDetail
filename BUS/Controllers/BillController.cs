using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DTO.Entities;

namespace BUS.Controllers
{
    public class BillController
    {
        public List<Bill> GetAllBills(ref string error)
        {
            using (var context = new Context())
            {
                try
                {
                    var bills = context.Bills.ToList();
                    error = "Get Bills Success!!!";
                    return bills;
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return null;
                }
            }
        }

       
    }
}
