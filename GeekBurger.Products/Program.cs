var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//var mvcCoreBuilder = builder.Services.AddMvcCore();

//mvcCoreBuilder
//    .AddFormatterMappings()
//    .AddCors();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();