using FluentValidation;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddValidatorsFromAssemblyContaining<UserValidator>(); // Auto-discovers validators
builder.Services.AddFluentValidationAutoValidation(); // Enables automatic validation

var app = builder.Build();
app.MapControllers();
app.Run();
