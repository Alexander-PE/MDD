using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace MDD.Default
{
    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[Customers]")]
    [DisplayName("Customers"), InstanceName("Customers")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("Default.Customers")]
    public sealed class CustomersRow : Row<CustomersRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Customer Id"), Identity, IdProperty]
        public int? CustomerId
        {
            get => fields.CustomerId[this];
            set => fields.CustomerId[this] = value;
        }

        [DisplayName("Customer Name"), Size(60), NotNull, QuickSearch, NameProperty]
        public string CustomerName
        {
            get => fields.CustomerName[this];
            set => fields.CustomerName[this] = value;
        }

        public CustomersRow()
            : base()
        {
        }

        public CustomersRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field CustomerId;
            public StringField CustomerName;
        }
    }
}
