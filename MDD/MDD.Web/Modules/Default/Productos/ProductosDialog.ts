
namespace MDD.Default {

    @Serenity.Decorators.registerClass()
    export class ProductosDialog extends Serenity.EntityDialog<ProductosRow, any> {
        protected getFormKey() { return ProductosForm.formKey; }
        protected getIdProperty() { return ProductosRow.idProperty; }
        protected getLocalTextPrefix() { return ProductosRow.localTextPrefix; }
        protected getNameProperty() { return ProductosRow.nameProperty; }
        protected getService() { return ProductosService.baseUrl; }
        protected getDeletePermission() { return ProductosRow.deletePermission; }
        protected getInsertPermission() { return ProductosRow.insertPermission; }
        protected getUpdatePermission() { return ProductosRow.updatePermission; }

        protected form = new ProductosForm(this.idPrefix);

    }
}