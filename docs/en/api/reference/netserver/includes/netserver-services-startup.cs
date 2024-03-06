```csharp
public interface IStartup
{
    IConfigurationRoot Configuration { get; set; }
    void Configure(IServiceCollection services);
    void ConfigureServices(IServiceProvider serviceProvider);
}

public class Startup : IStartup
{
    public IConfigurationRoot Configuration { get; set; }

    public virtual void Configure(IServiceCollection services)
    {
        services.AddLogging(a =>
        {
            a.AddConfiguration(Configuration.GetSection("Logging"));
            a.ClearProviders();
            a.AddConsole();
        });
        services.AddNetServerCore<ThreadContextProvider>(options => OnConfigureNetServerCore(options));
        services.AddSoDatabase(options => OnConfigureNetServerLocal(options));
        
        // Add the services implementation for local network use
        services.AddServicesImplementation();
        
        // OR.......................
        // Add the services proxies for distributed network use
        // services.AddServicesProxies();
    }

    protected virtual void OnConfigureNetServerCore(NetServerCoreOptionsBuilder options)
    {
        // this option is required for on-premises installations and
        // requires that the SuperOffice.Online.dll is added in the 
        // declared in the SuperOffice Factory DynamicLoad section 
        // of the configuration file.
        /*  
        See: https://docs.superoffice.com/en/api/netserver/config/factory.html
            <Factory>
                <DynamicLoad>
                    <add key="Onsite" value="SuperOffice.Onsite.dll" />
                </DynamicLoad>
            </Factory>
        */
        options.UseOnPremAD();
    }
    protected virtual void OnConfigureNetServerLocal(NetServerLocalOptionsBuilder options)
    {
    }
    public virtual void ConfigureServices(IServiceProvider serviceProvider)
    {
        var netServerServiceProvider = serviceProvider.RegisterWithNetServer();
    }
}
```