using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MDD.Default.OrdersRow>;
using MyRow = MDD.Default.OrdersRow;

namespace MDD.Default
{
    public interface IOrdersListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class OrdersListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IOrdersListHandler
    {
        public OrdersListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}