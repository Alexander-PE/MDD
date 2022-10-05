using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace MDD.Default
{
    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[OrderDetails]")]
    [DisplayName("Order Details"), InstanceName("Order Details")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class OrderDetailsRow : Row<OrderDetailsRow.RowFields>, IIdRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Order"), NotNull, ForeignKey("[dbo].[Orders]", "OrderId"), LeftJoin("jOrder")]
        [LookupEditor("Default.Orders")]
        public int? OrderId
        {
            get => fields.OrderId[this];
            set => fields.OrderId[this] = value;
        }

        [DisplayName("Product"), NotNull, ForeignKey("[dbo].[Productos]", "ProductId"), LeftJoin("jProduct"), TextualField("ProductProductName")]
        [LookupEditor("Default.Productos", InplaceAdd = true)]
        public int? ProductId
        {
            get => fields.ProductId[this];
            set => fields.ProductId[this] = value;
        }

        [DisplayName("Order Customer Id"), Expression("jOrder.[CustomerId]")]
        public int? OrderCustomerId
        {
            get => fields.OrderCustomerId[this];
            set => fields.OrderCustomerId[this] = value;
        }

        [DisplayName("Product Product Name"), Expression("jProduct.[ProductName]"), NameProperty]
        public string ProductProductName
        {
            get => fields.ProductProductName[this];
            set => fields.ProductProductName[this] = value;
        }

        public OrderDetailsRow()
            : base()
        {
        }

        public OrderDetailsRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field OrderId;
            public Int32Field ProductId;

            public Int32Field OrderCustomerId;

            public StringField ProductProductName;
        }
    }
}
