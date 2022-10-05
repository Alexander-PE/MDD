using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace MDD.Default
{
    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[Orders]")]
    [DisplayName("Orders"), InstanceName("Orders")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("Default.Orders")]
    
    public sealed class OrdersRow : Row<OrdersRow.RowFields>, IIdRow
    {
        [DisplayName("Order Id"), Identity, IdProperty]
        public int? OrderId
        {
            get => fields.OrderId[this];
            set => fields.OrderId[this] = value;
        }

        [DisplayName("Customer"), NotNull, ForeignKey("[dbo].[Customers]", "CustomerId"), LeftJoin("jCustomer"), TextualField("CustomerCustomerName")]
        [LookupEditor("Default.Customers")]
        public int? CustomerId
        {
            get => fields.CustomerId[this];
            set => fields.CustomerId[this] = value;
        }

        [DisplayName("Customer"), Expression("jCustomer.[CustomerName]")]
        public string CustomerCustomerName
        {
            get => fields.CustomerCustomerName[this];
            set => fields.CustomerCustomerName[this] = value;
        }

        [MasterDetailRelation(foreignKey: "OrderId", IncludeColumns = "OrderId")]
        [DisplayName("Details"), NotMapped]
        public List<OrderDetailsRow> Details
        {
            get => fields.Details[this];
            set => fields.Details[this] = value;
        }

        public OrdersRow()
            : base()
        {
        }

        public OrdersRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field OrderId;
            public Int32Field CustomerId;

            public StringField CustomerCustomerName;

            public RowListField<OrderDetailsRow> Details;
        }
    }
}
