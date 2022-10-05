namespace MDD.Default {
    export interface OrdersRow {
        OrderId?: number;
        CustomerId?: number;
        CustomerCustomerName?: string;
        Details?: OrderDetailsRow[];
    }

    export namespace OrdersRow {
        export const idProperty = 'OrderId';
        export const localTextPrefix = 'Default.Orders';
        export const lookupKey = 'Default.Orders';

        export function getLookup(): Q.Lookup<OrdersRow> {
            return Q.getLookup<OrdersRow>('Default.Orders');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            OrderId = "OrderId",
            CustomerId = "CustomerId",
            CustomerCustomerName = "CustomerCustomerName",
            Details = "Details"
        }
    }
}
