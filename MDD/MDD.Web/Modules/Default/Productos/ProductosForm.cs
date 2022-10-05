using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace MDD.Default.Forms
{
    [FormScript("Default.Productos")]
    [BasedOnRow(typeof(ProductosRow), CheckNames = true)]
    public class ProductosForm
    {
        public string ProductName { get; set; }
    }
}