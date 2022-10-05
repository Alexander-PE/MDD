namespace MDD.Default {
    export interface OrderDetailsRow {
        Id?: number;
        OrderId?: number;
        ProductId?: number;
        OrderCustomerId?: number;
        ProductProductName?: string;
    }

    export namespace OrderDetailsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'ProductProductName';
        export const localTextPrefix = 'Default.OrderDetails';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            OrderId = "OrderId",
            ProductId = "ProductId",
            OrderCustomerId = "OrderCustomerId",
            ProductProductName = "ProductProductName"
        }
    }
}
