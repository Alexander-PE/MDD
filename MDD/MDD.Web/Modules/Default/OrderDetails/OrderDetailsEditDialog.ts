namespace MDD.Default
{
    @Serenity.Decorators.registerClass()
    export class OrderDetailsEditDialog extends
        Serenity.Extensions.GridEditorDialog<OrderDetailsRow> {
        protected getFormKey() { return OrderDetailsForm.formKey; }
        protected getNameProperty() { return OrderDetailsRow.nameProperty; }
        protected getLocalTextPrefix() { return OrderDetailsRow.localTextPrefix; }

        protected form: OrderDetailsForm = new OrderDetailsForm(this.idPrefix);

        constructor() {
            super();
        }
    }
}
