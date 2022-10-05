using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace MDD.Default.Forms
{
    [FormScript("Default.OrderDetails")]
    [BasedOnRow(typeof(OrderDetailsRow), CheckNames = true)]
    public class OrderDetailsForm
    {
        public int ProductId { get; set; }
    }
}