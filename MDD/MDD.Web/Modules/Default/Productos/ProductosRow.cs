using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace MDD.Default
{
    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[Productos]")]
    [DisplayName("Productos"), InstanceName("Productos")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("Default.Productos")]
    public sealed class ProductosRow : Row<ProductosRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Product Id"), Identity, IdProperty]
        public int? ProductId
        {
            get => fields.ProductId[this];
            set => fields.ProductId[this] = value;
        }

        [DisplayName("Product Name"), Size(60), NotNull, QuickSearch, NameProperty]
        public string ProductName
        {
            get => fields.ProductName[this];
            set => fields.ProductName[this] = value;
        }

        public ProductosRow()
            : base()
        {
        }

        public ProductosRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ProductId;
            public StringField ProductName;
        }
    }
}
