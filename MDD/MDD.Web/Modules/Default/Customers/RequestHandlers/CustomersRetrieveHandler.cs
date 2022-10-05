using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MDD.Default.CustomersRow>;
using MyRow = MDD.Default.CustomersRow;

namespace MDD.Default
{
    public interface ICustomersRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class CustomersRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICustomersRetrieveHandler
    {
        public CustomersRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}