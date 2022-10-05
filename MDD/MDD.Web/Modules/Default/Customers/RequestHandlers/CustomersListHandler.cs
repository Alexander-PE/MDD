using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MDD.Default.CustomersRow>;
using MyRow = MDD.Default.CustomersRow;

namespace MDD.Default
{
    public interface ICustomersListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class CustomersListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICustomersListHandler
    {
        public CustomersListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}