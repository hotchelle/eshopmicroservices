var builder = WebApplication.CreateBuilder(args);

// Add Services to container

var app = builder.Build();


//configure the http request pipeline

app.Run();
