namespace MDD.Default
{
    @Serenity.Decorators.registerEditor()
    export class OrderDetailsEditor extends Serenity.Extensions.GridEditorBase<OrderDetailsRow> {
        protected getColumnsKey() { return "Default.OrderDetails"; }
        protected getDialogType() { return OrderDetailsEditDialog; }
        protected getLocalTextPrefix() { return OrderDetailsRow.localTextPrefix; }
        protected getService() { return OrderDetailsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getAddButtonCaption() {
            return "Add";
        }

        protected validateEntity(row: OrderDetailsRow, id: number) {
            if (!super.validateEntity(row, id))
                return false;

            row.ProductProductName = ProductosRow.getLookup()
                .itemById[row.ProductId].ProductName; 

            return true;
        }
    }
}
