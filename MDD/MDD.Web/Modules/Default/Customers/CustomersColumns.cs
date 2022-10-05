using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace MDD.Default.Columns
{
    [ColumnsScript("Default.Customers")]
    [BasedOnRow(typeof(CustomersRow), CheckNames = true)]
    public class CustomersColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int CustomerId { get; set; }
        [EditLink]
        public string CustomerName { get; set; }
    }
}