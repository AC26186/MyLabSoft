using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLabSoft
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string IsourceCatalogId { get; set; }
        public string WorkSheetName { get; set; }
        public bool IsActive { get; set; }
        public short EndPoints { get; set; }
        public string ApplicableRules { get; set; }
        public string CreateId { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateId { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
