
namespace MDD.Default {

    @Serenity.Decorators.registerClass()
    export class ProductosGrid extends Serenity.EntityGrid<ProductosRow, any> {
        protected getColumnsKey() { return ProductosColumns.columnsKey; }
        protected getDialogType() { return ProductosDialog; }
        protected getIdProperty() { return ProductosRow.idProperty; }
        protected getInsertPermission() { return ProductosRow.insertPermission; }
        protected getLocalTextPrefix() { return ProductosRow.localTextPrefix; }
        protected getService() { return ProductosService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}