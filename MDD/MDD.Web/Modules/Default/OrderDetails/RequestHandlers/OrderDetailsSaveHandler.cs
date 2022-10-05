using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<MDD.Default.OrderDetailsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MDD.Default.OrderDetailsRow;

namespace MDD.Default
{
    public interface IOrderDetailsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class OrderDetailsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IOrderDetailsSaveHandler
    {
        public OrderDetailsSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}