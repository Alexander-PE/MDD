using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<MDD.Default.OrdersRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MDD.Default.OrdersRow;

namespace MDD.Default
{
    public interface IOrdersSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class OrdersSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IOrdersSaveHandler
    {
        public OrdersSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}