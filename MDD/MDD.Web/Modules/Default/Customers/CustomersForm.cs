using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace MDD.Default.Forms
{
    [FormScript("Default.Customers")]
    [BasedOnRow(typeof(CustomersRow), CheckNames = true)]
    public class CustomersForm
    {
        public string CustomerName { get; set; }
    }
}