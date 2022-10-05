using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MDD.Default.OrdersRow;

namespace MDD.Default
{
    public interface IOrdersDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class OrdersDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IOrdersDeleteHandler
    {
        public OrdersDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}