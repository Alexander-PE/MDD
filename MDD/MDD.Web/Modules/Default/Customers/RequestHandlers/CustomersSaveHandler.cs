using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<MDD.Default.CustomersRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MDD.Default.CustomersRow;

namespace MDD.Default
{
    public interface ICustomersSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class CustomersSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICustomersSaveHandler
    {
        public CustomersSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}