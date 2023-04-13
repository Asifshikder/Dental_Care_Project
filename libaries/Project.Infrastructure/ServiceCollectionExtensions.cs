using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System;
using Project.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Project.Infrastructure.DataAccess;

namespace Project.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ApplicationDbContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("constring"));
                option.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            }, ServiceLifetime.Transient);
            //services.AddIdentity<User, Role>(
            //options =>
            //{
            //    options.Password.RequireDigit = false;
            //    options.Password.RequiredLength = 6;
            //    options.Password.RequireLowercase = false;
            //    options.Password.RequireUppercase = false;
            //    options.Password.RequireNonAlphanumeric = false;
            //    options.SignIn.RequireConfirmedEmail = false;
            //}).AddEntityFrameworkStores<UappContext>().AddDefaultTokenProviders();

            //services.AddAuthentication(auth =>
            //{
            //    auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            //}).AddJwtBearer(options =>
            //{
            //    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
            //    {
            //        ValidateIssuer = false,
            //        ValidateAudience = false,
            //        ValidAudience = configuration["AuthSetting:Audience"],
            //        ValidIssuer = configuration["AuthSetting:Audience"],
            //        RequireExpirationTime = false,
            //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["AuthSetting:Key"])),
            //        ValidateIssuerSigningKey = false,

            //        ClockSkew = TimeSpan.Zero

            //    };
            //});

            //services.AddScoped<IWorkContext, WorkContext>();

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddSingleton<ISqlService, SqlService>();
            //services.AddScoped(typeof(IEnumHelper<>), typeof(EnumHelper<>));

            //services.AddAuthorization(auth =>
            //{
            //    auth.AddPolicy("Bearer", new AuthorizationPolicyBuilder()
            //        .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
            //        .RequireAuthenticatedUser().Build());
            //});

            //builder.Services.AddSingleton<ISqlDataAccess, SqlDataAccess>();            //services.AddHttpContextAccessor();
            //services.AddDistributedMemoryCache();
            //services.AddSession(options =>
            //{
            //    options.Cookie.IsEssential = true;
            //});

            SqlProperties sqlProperties = new SqlProperties()
            {
                DatabaseName = "",
                ConnectionString = configuration.GetConnectionString("constring")
            };
            services.AddSingleton(sqlProperties);
            return services;
        }
    }
}