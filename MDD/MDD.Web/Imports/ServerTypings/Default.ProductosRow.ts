namespace MDD.Default {
    export interface ProductosRow {
        ProductId?: number;
        ProductName?: string;
    }

    export namespace ProductosRow {
        export const idProperty = 'ProductId';
        export const nameProperty = 'ProductName';
        export const localTextPrefix = 'Default.Productos';
        export const lookupKey = 'Default.Productos';

        export function getLookup(): Q.Lookup<ProductosRow> {
            return Q.getLookup<ProductosRow>('Default.Productos');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            ProductId = "ProductId",
            ProductName = "ProductName"
        }
    }
}
