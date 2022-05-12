using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Tatil.MvcWebUI.Entity
{
    public class Category
    {
        public int Id { get; set; }

        [DisplayName("Ülke Adı")]
        public string Name { get; set; }
        [DisplayName("Tur Adı")]
        public string Description { get; set; }

        public List<Product> Products { get; set; }

    }
}