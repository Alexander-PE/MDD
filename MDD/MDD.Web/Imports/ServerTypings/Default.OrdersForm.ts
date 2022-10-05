namespace MDD.Default {
    export interface OrdersForm {
        CustomerId: Serenity.LookupEditor;
        Details: OrderDetailsEditor;
    }

    export class OrdersForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Orders';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!OrdersForm.init)  {
                OrdersForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = OrderDetailsEditor;

                Q.initFormType(OrdersForm, [
                    'CustomerId', w0,
                    'Details', w1
                ]);
            }
        }
    }
}
