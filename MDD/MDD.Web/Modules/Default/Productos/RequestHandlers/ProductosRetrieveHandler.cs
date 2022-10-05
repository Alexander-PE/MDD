using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MDD.Default.ProductosRow>;
using MyRow = MDD.Default.ProductosRow;

namespace MDD.Default
{
    public interface IProductosRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductosRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProductosRetrieveHandler
    {
        public ProductosRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}