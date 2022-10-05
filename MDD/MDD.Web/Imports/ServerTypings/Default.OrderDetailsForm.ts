namespace MDD.Default {
    export interface OrderDetailsForm {
        ProductId: Serenity.LookupEditor;
    }

    export class OrderDetailsForm extends Serenity.PrefixedContext {
        static formKey = 'Default.OrderDetails';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!OrderDetailsForm.init)  {
                OrderDetailsForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;

                Q.initFormType(OrderDetailsForm, [
                    'ProductId', w0
                ]);
            }
        }
    }
}
