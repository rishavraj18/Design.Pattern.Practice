using Factory.Strategy.Pattern.Factory;
using Factory.Strategy.Pattern.Strategy;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Register all payment strategies
builder.Services.AddScoped<IPaymentStrategy, CreditCardPaymentStrategy>();
builder.Services.AddScoped<IPaymentStrategy, PayPalPaymentStrategy>();
builder.Services.AddScoped<IPaymentStrategy, UpiPaymentStrategy>();

// Register factory
builder.Services.AddScoped<IPaymentFactory, PaymentFactory>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
