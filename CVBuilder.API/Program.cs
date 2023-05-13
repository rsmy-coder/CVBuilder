using CVBuilder.API.Data;
using CVBuilder.Data.Models;
using CVBuilder.Infostructure.AutoMapper;
using CVBuilder.Infostructure.Services.AwardService;
using CVBuilder.Infostructure.Services.EducationService;
using CVBuilder.Infostructure.Services.ExperincecService;
using CVBuilder.Infostructure.Services.Files;
using CVBuilder.Infostructure.Services.ProjectService;
using CVBuilder.Infostructure.Services.SkillesService;
using CVBuilder.Infostructure.Services.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<CVBuilderDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentity<User,IdentityRole>(options =>
{
    options.User.RequireUniqueEmail = true;
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
}
).AddEntityFrameworkStores<CVBuilderDbContext>();

builder.Services.AddControllersWithViews();
//.AddNewtonsoftJson(
//    Options => Options.SerializerSettings.PreserveReferencesHandling = (Newtonsoft.Json.PreserveReferencesHandling)Newtonsoft.Json.ReferenceLoopHandling.Ignore
//    )
builder.Services.AddRazorPages();
builder.Services.AddTransient<IFileService, FileService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IEducationService,EducationService>();
builder.Services.AddTransient<IProjectService,ProjectService>();
builder.Services.AddTransient<IExperincecService,ExperincecService>();
builder.Services.AddTransient<ISkillesService,SkillesService>();
builder.Services.AddTransient<IAwardService, AwardService>();



builder.Services.AddCors();

builder.Services.AddSwaggerGen(c =>
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "CVBuilder", Version = "v1" })
    );

builder.Services.AddAutoMapper(typeof(AutomapperProfile).Assembly);

builder.Services.AddControllers()
   .AddNewtonsoftJson(options =>
      options.SerializerSettings.ReferenceLoopHandling =
        Newtonsoft.Json.ReferenceLoopHandling.Ignore);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseCors(c => c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();
app.UseSwagger();

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "CVBuilder");
});  

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
