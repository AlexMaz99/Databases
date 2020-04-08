﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AMazurProductEF
{
    class InvoiceProduct
    {
        public int ProductID { get; set; }

        public Product Product { get; set; }

        public int InvoiceID { get; set; }

        public Invoice Invoice { get; set; }
    }
}
