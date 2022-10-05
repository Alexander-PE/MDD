using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MDD.Default.OrdersRow>;
using MyRow = MDD.Default.OrdersRow;

namespace MDD.Default
{
    public interface IOrdersRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class OrdersRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IOrdersRetrieveHandler
    {
        public OrdersRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}