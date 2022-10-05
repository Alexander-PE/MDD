using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MDD.Default.ProductosRow;

namespace MDD.Default
{
    public interface IProductosDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductosDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IProductosDeleteHandler
    {
        public ProductosDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}