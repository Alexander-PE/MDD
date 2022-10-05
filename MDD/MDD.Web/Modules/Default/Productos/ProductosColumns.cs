using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace MDD.Default.Columns
{
    [ColumnsScript("Default.Productos")]
    [BasedOnRow(typeof(ProductosRow), CheckNames = true)]
    public class ProductosColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int ProductId { get; set; }
        [EditLink]
        public string ProductName { get; set; }
    }
}