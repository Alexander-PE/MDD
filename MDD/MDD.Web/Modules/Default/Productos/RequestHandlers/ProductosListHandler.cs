using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MDD.Default.ProductosRow>;
using MyRow = MDD.Default.ProductosRow;

namespace MDD.Default
{
    public interface IProductosListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductosListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProductosListHandler
    {
        public ProductosListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}