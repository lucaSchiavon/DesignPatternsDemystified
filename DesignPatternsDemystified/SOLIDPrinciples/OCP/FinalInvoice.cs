﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.SOLIDPrinciples.OCP
{
    public class FinalInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 50;
        }
    }

}
