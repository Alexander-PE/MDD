using FluentMigrator;

namespace MDD.Migrations.DefaultDB
{
    [Migration(20160511072611)]
    public class DefaultDB_20160511_072611_Tablas : Migration
    {
        public override void Up()
        {
            Create.Table("Productos")
                .WithColumn("ProductId").AsInt32().PrimaryKey().Identity().NotNullable()
                .WithColumn("ProductName").AsString(60);

            Create.Table("Customers")
                .WithColumn("CustomerId").AsInt32().PrimaryKey().Identity().NotNullable()
                .WithColumn("CustomerName").AsString(60);

            Create.Table("Orders")
                .WithColumn("OrderId").AsInt32().PrimaryKey().Identity().NotNullable()
                .WithColumn("CustomerId").AsInt32().ForeignKey("FK_Orders_CustomerId", "Customers", "CustomerId");

            Create.Table("OrderDetails")
                .WithColumn("Id").AsInt32().Identity().NotNullable().PrimaryKey()
                .WithColumn("OrderId").AsInt32().ForeignKey("FK_OrderDetails_OrderId", "Orders", "OrderId")
                .WithColumn("ProductId").AsInt32().ForeignKey("FK_Orders_ProductId", "Productos", "ProductId");
        }

        public override void Down() { }
    }
}
