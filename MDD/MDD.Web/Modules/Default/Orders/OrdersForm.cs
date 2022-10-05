using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace MDD.Default.Forms
{
    [FormScript("Default.Orders")]
    [BasedOnRow(typeof(OrdersRow), CheckNames = true)]
    public class OrdersForm
    {
        public int CustomerId { get; set; }
        [OrderDetailsEditor, IgnoreName]
        public List<OrderDetailsRow> Details { get; set; }
    }
}