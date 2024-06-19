using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBLET.ViewModels
{
    public class BOOKING_VIEW_MODEL
    {
        public string MEMBER_NAME { get; set; }
        public string MEMBER_TITLE { get; set; }
        public string MEMBER_FATHER_NAME { get; set; }
        public string MEMBER_CNIC { get; set; }
        public string MEMBER_ADDRESS { get; set; }
        public DateTime MEMBER_DOB { get; set; }
        public string MEMBER_PIC { get; set; }
        public string MEMBER_CITY { get; set; }
        public string MEMBER_COUNTRY { get; set; }
        public int BOK_ID { get; set; }
        public DateTime BOK_DATE { get; set; }
        public int BLOCK_ID { get; set; }
        public int PLOT_ID { get; set; }
        public decimal PLOT_PRICE { get; set; }
        public decimal BOOKING_AMOUNT { get; set; }
        public decimal MEMBERSHIP_FEE { get; set; }
        public decimal DISCOUNT_AMOUNT { get; set; }
        public decimal TOTALAMOUNT { get; set; }
        public decimal PAYABLE { get; set; }
        public decimal NETPAYABLE { get; set; }
        public string NOMINEECNIC { get; set; }
        public string SIZE_NAME { get; set; }
        public int SIZE_CODE { get; set; }
        public string SIZE_SQ_YRDS { get; set; }
        public string BLK_CODE { get; set; }
        public string BLK_NAME { get; set; }
        public int MEMBER_ID { get; set; }
        public int BLK_PJ_CODE { get; set; }
        public string VENDOR_CODE { get; set; }
    }
}
