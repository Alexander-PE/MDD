using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MDD.Default.CustomersRow;

namespace MDD.Default
{
    public interface ICustomersDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class CustomersDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICustomersDeleteHandler
    {
        public CustomersDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}