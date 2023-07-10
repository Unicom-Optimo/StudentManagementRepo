using DataAccess.EFCore;
using DataAccess.EFCore.Interfaces;
using DataAccess.EFCore.Repository;
using Microsoft.EntityFrameworkCore;
using StudentDomain.Interfaces;
using StudentDomain.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
/*builder.Services.AddDbContext<StudentaManagementContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly(
        typeof(StudentaManagementContext).Assembly.FullName)));*/


builder.Services.AddDbContext<StudentaManagementContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//new
builder.Services.AddTransient<StudentInterface, StudentRepository>();
builder.Services.AddTransient<ManagementInterface, ManagementRepository>();
builder.Services.AddTransient<CourseInterface, CourseRepository>();

builder.Services.AddTransient<IStudentService, StudentService>();
builder.Services.AddTransient<IManagementService, ManagementService>();
builder.Services.AddTransient<ICourseService, CourseService>();


//new

builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

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
