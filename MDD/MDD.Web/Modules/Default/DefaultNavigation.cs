using Serenity.Navigation;
using MyPages = MDD.Default.Pages;

[assembly: NavigationLink(int.MaxValue, "Default/Customers", typeof(MyPages.CustomersController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Orders", typeof(MyPages.OrdersController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Productos", typeof(MyPages.ProductosController), icon: null)]