using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace MDD.Default
{
    public partial class OrdersDetailsEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "MDD.Default.OrdersDetailsEditor";

        public OrdersDetailsEditorAttribute()
            : base(Key)
        {
        }
    }
}
