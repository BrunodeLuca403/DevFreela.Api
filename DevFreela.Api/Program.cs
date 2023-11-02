using DevFreela.Api.Filters;
using DevFreela.Application.Commands.CreateProject;
using DevFreela.Application.Validators;
using DevFreela.Core.Repositores;
using DevFreela.Infrastructure.Persistense;
using DevFreela.Infrastructure.Persistense.Repositores;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options => options.Filters.Add(typeof(ValidatorsFilter))).AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreateUserCommandValidator>());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddSingleton<DevFreelaDbContext>();

builder.Services.AddDbContext<DevFreelaDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DevFreelaCs")));

//builder.Services.AddScoped<IProjectService, ProjectService>();
//builder.Services.AddScoped<IUserService, UserService>();
//builder.Services.AddScoped<ISkillService, SkillService>();

builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
builder.Services.AddScoped<ISkillRepository, SkillRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddMediatR(typeof(CreateProjectCommand));

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
