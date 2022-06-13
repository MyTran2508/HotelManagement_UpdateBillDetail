using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DTO.Entities;

namespace BUS.Controllers
{
    public class BillDetailController
    {
        // Load Reference
        private void LoadReference(Context c, BillDetail billDetail)
        {
            string[] refs = { "Service", "Bill"};
            foreach (var r in refs)
            {
                c.Entry(billDetail).Reference(r).Load();
            }
        }

        // Get 
        public List<BillDetail> GetAllBillDetail(ref string error)
        {
            try
            {
                using (var context = new Context())
                {
                    var billDetails = context.BillDetails.ToList();
                    foreach (var bi in billDetails)
                    {
                        LoadReference(context, bi);
                    }
                    error = "Get Reservations Success!!!";
                    return billDetails;
                }
            }
            catch
            {
                error = "Something Was Wrong When Get Reservations!!!";
                return null;
            }
        }
        // Insert Bill_detail
        public bool InsertBillDetail
        (
           ref string error,
           string BillId,
           string ServiveId
        )
        {
            try
            {
                using (var context = new Context())
                {
                    var billdetail = new BillDetail
                    {
                        BillId = BillId,
                        ServiceId = ServiveId,

                    };

                    context.BillDetails.Add(billdetail);
                    context.SaveChanges();
                    error = "Add BillDetail Success!!!";
                    return true;
                }
            }
            catch
            {
                error = "Something Was Wrong When Add BillDetail!!!";
                return false;
            }
        }
        // Update Bill_detail
        public bool UpdateBillDetail
        (
           ref string error,
           string BillId,
           string NewServiveId
        )
        {
            try
            {
                using (var context = new Context())
                {
                    var billDetail = context.BillDetails.
                        Where(r => r.BillId == BillId).FirstOrDefault();

                    // Update Room
                    if (billDetail != null)
                    {
                        billDetail.ServiceId = NewServiveId;
                        context.SaveChanges();
                        error = "Billdetail Has Updated!!!";
                        return true;
                    }
                    error = "Room Is Not Exist!!!";
                    return false;
                }
            }
            catch
            {
                error = "Something Was Wrong When Update BillDetail!!!";
                return false;
            }
        }

        // Get Bill by id
        public List<BillDetail> GetBillDetailById(ref string error, string Id)
        {
            try
            {
                using (var context = new Context())
                {
                    var billdetail = context.BillDetails.Where(bi => bi.BillId == Id).ToList();
                    
                    foreach (var bi in billdetail)
                    {
                        LoadReference(context, bi);
                    }
                    if (billdetail != null)
                    {
                        error = "Get BillDetail Success!!!";
                    }
                    return billdetail;

                }
            }
            catch
            {
                error = "Get BillDetail Failure!!!";
                return null;
            }
        }

        // Delete BillDetail
        public bool RemoveBillDetatil(ref string error, string Id)
        {
            try
            {
                using (var context = new Context())
                {
                    // Find Reservation
                    var billDetail = context.BillDetails.
                        Where(r => r.BillId == Id).FirstOrDefault();

                    // Remove if Reservation exit
                    if (billDetail != null)
                    {
                        context.BillDetails.Remove(billDetail);
                        context.SaveChanges();
                        error = "Reservion Has Delete!!!";
                        return true;
                    }
                    error = "Reservation Is Not Exist!!!";
                    return false;
                }
            }
            catch
            {
                error = "Sonmething Was Wrong When Remove Reservation!!!";
                return false;
            }
        }

        // Tính tổng tiền Bill
        public float TotalBillDetailsById(ref string error, string Id)
        {
            try
            {
                float Total = 0;
                using (var context = new Context())
                {
                    var totalBillDetails = GetBillDetailById(ref error, Id);
                    foreach (var bi in totalBillDetails)
                    {
                        Total += bi.Service.Price;
                    }
                    error = "Total Bill Detail Success!!!";
                    return Total;
                }
            }
            catch
            {
                error = "Something Was Wrong When Total Bill Detail!!!";
                return 0;
            }
        }
    }
}
