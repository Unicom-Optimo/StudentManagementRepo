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




builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();







builder.Services.AddDbContext<StudentaManagementContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//new
builder.Services.AddScoped<AuthInterface, AuthRepository>();
builder.Services.AddScoped<StudentInterface, StudentRepository>();
builder.Services.AddScoped<ManagementInterface, ManagementRepository>();
builder.Services.AddScoped<CourseInterface, CourseRepository>();


builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IManagementService, ManagementService>();
builder.Services.AddScoped<ICourseService, CourseService>();


//new




/*
 * builder.Services.AddTransient<AuthInterface, AuthRepository>();
builder.Services.AddTransient<StudentInterface, StudentRepository>();
builder.Services.AddTransient<ManagementInterface, ManagementRepository>();
builder.Services.AddTransient<CourseInterface, CourseRepository>();


builder.Services.AddTransient<IAuthService, AuthService>();
builder.Services.AddTransient<IStudentService, StudentService>();
builder.Services.AddTransient<IManagementService, ManagementService>();
builder.Services.AddTransient<ICourseService, CourseService>();
 * */

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
