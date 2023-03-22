using Coursera.DBContext;
using Coursera.Repository.CoursesRepo;
using Coursera.Repository.StudentRepo;
using Coursera.Repository.TeacherRepo;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//dependancy Injection between Classes
builder.Services.AddTransient<IStdHelper, StdHelper>();
builder.Services.AddTransient<iTeacherHelper, TeacherHelper>();
builder.Services.AddTransient<iCourseHelper, CourseHelper>();


// DataConnection Services
builder.Services.AddDbContext<DataContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection"));
});
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
