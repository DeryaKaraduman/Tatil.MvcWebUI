using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tatil.MvcWebUI.Models
{
    public class OrderDetailsModel
    {

        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public double Total { get; set; }
        public DateTime OrderDate { get; set; }

        public string UserName { get; set; }

        public string TCKimlik { get; set; }

        public string Telefon { get; set; }
        public virtual List<OrderLineModel> OrderLines { get; set; }
    }

    public class OrderLineModel
    {
        public int ProductId { get; set; }
        public string PuroductName { get; set; }
        public double Image { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
       
    }
}