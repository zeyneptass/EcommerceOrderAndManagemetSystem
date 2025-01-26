using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProductDetailDto : IDto
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public int StockQuantity { get; set; }
    }
}
