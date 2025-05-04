using Projects;

var builder = DistributedApplication.CreateBuilder(args);
builder.AddProject<Dafaah_Products_Api>("ProductsApi");
builder.Build().Run();
