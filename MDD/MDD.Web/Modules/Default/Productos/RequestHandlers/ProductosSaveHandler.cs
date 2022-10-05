using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<MDD.Default.ProductosRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MDD.Default.ProductosRow;

namespace MDD.Default
{
    public interface IProductosSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductosSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProductosSaveHandler
    {
        public ProductosSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}