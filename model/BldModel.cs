using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSystem.model
{
    class BldModel
    {
        public string BLID { get; set; }
        public string BLNO { get; set; }
        public string Number { get; set; }
        public string IsOutput { get; set; }
        public string Code { get; set; }
        public string Qty { get; set; }
        public string Cost { get; set; }
        public string Price { get; set; }
        public string PriceType { get; set; }

        public string Discount { get; set; }
        public string CurrencyId { get; set; }
        public string Rate { get; set; }
        public string BranchId { get; set; }
        public string Profits { get; set; }

        public string EmpNr { get; set; }
        public string ComputerNo { get; set; }
        public string FinalPrice { get; set; }
        public string ReternQty { get; set; }
        public string CurrentPrice { get; set; }
    }
}
