namespace MDD.Default {
    export interface ProductosForm {
        ProductName: Serenity.StringEditor;
    }

    export class ProductosForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Productos';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProductosForm.init)  {
                ProductosForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(ProductosForm, [
                    'ProductName', w0
                ]);
            }
        }
    }
}
