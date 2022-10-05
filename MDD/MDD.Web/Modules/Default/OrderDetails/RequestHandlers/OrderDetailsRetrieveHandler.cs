using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MDD.Default.OrderDetailsRow>;
using MyRow = MDD.Default.OrderDetailsRow;

namespace MDD.Default
{
    public interface IOrderDetailsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class OrderDetailsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IOrderDetailsRetrieveHandler
    {
        public OrderDetailsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}