using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
/*builder.Services.AddDbContext<UploadImage.Data.ImagesContext>(
    options =>
    {
        options.UseSqlServer(connectionString: builder.Configuration.GetConnectionString("ImageDb"));

    });*/
builder.Services.AddSwaggerGen(o => o.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
{
    Title = "Image-API",
    Version = "v1",
    Description = "Des1"
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();
app.UseSwaggerUI(o => o.SwaggerEndpoint("/swagger/v1/swagger.json", "Image API V1"));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
