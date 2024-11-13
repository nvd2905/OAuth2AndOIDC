using Dar.IDP.DbContexts;
using Dar.IDP.Services;
using Duende.IdentityServer;
using Duende.IdentityServer.Test;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace Dar.IDP;

internal static class HostingExtensions
{
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
        // configures IIS out-of-proc settings 
        builder.Services.Configure<IISOptions>(iis =>
        {
            iis.AuthenticationDisplayName = "Windows";
            iis.AutomaticAuthentication = false;
        });
        // ..or configures IIS in-proc settings
        builder.Services.Configure<IISServerOptions>(iis =>
        {
            iis.AuthenticationDisplayName = "Windows";
            iis.AutomaticAuthentication = false;
        });

        // uncomment if you want to add a UI
        builder.Services.AddRazorPages();

        builder.Services.AddScoped<IPasswordHasher<Entities.User>,
            PasswordHasher<Entities.User>>();
        builder.Services.AddScoped<ILocalUserService, LocalUserService>();
        builder.Services.AddDbContext<IdentityDbContext>(options =>
        {
            options.UseSqlServer(
                builder.Configuration.GetConnectionString("DarIdentityDBConnectionString"));
        });

        builder.Services.AddIdentityServer(options =>
            {
                // https://docs.duendesoftware.com/identityserver/v6/fundamentals/resources/api_scopes#authorization-based-on-scopes
                options.EmitStaticAudienceClaim = true;
            })
            .AddInMemoryIdentityResources(Config.IdentityResources)
            .AddInMemoryApiScopes(Config.ApiScopes)
            .AddInMemoryApiResources(Config.ApiResources)
            .AddInMemoryClients(Config.Clients)
            .AddProfileService<LocalUserProfileService>();

        builder.Services
             .AddAuthentication()
             .AddOpenIdConnect("AAD", "Azure Active Directory", options =>
             {
                 options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;
                 options.Authority = "https://login.microsoftonline.com/325864d9-95ed-40d1-8e75-6090cbe5e443/v2.0";
                 options.ClientId = "29b6cb0d-3b91-47d5-a57c-9ee164a636e9";
                 options.ClientSecret = "VYo8Q~ZFU6nsYX3mWtlwkNW_bVSkxffWbDezJbty";
                 options.ResponseType = "code";
                 options.CallbackPath = new PathString("/signin-aad/");
                 options.SignedOutCallbackPath = new PathString("/signout-aad/");
                 options.Scope.Add("email");
                 options.Scope.Add("offline_access");
                 options.SaveTokens = true;
             });

        return builder.Build();
    }
    
    public static WebApplication ConfigurePipeline(this WebApplication app)
    { 
        app.UseSerilogRequestLogging();
    
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        // uncomment if you want to add a UI
        app.UseStaticFiles();
        app.UseRouting();

        app.UseIdentityServer();

        // uncomment if you want to add a UI
        app.UseAuthorization();
        app.MapRazorPages().RequireAuthorization();

        return app;
    }
}
