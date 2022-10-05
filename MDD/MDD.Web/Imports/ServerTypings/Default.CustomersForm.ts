namespace MDD.Default {
    export interface CustomersForm {
        CustomerName: Serenity.StringEditor;
    }

    export class CustomersForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Customers';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CustomersForm.init)  {
                CustomersForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(CustomersForm, [
                    'CustomerName', w0
                ]);
            }
        }
    }
}
