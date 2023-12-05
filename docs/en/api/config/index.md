---
uid: nerserver_config
title: NetServer configuration
description: "Introduction to the NetServer configuration file for SuperOffice with explanations and examples for each section."
author: Bergfrid Dias
so.date: 12.07.2021
keywords: config, web.config, NetServer
so.topic: reference
so.envir: onsite
---

# NetServer configuration

## Dependency injection.

Since version 10, SuperOffice uses dependency injection to establish configuration options and parameters.

### Session Mode Changes
The config file setting for Session Mode has been removed. This has been replaced with a session handling implementation to AddNetServerCore. 

```csharp
class Startup
{
    public IConfigurationRoot Configuration { get; set; }

    public virtual void Configure(IServiceCollection services)
    {
        services.AddLogging(a =>
        {
            a.AddConfiguration(Configuration.GetSection("Logging"));
        });
        //services.AddNetServerCore() // v10.0
        services.AddNetServerCore<ThreadContextProvider>( options => { 
          options.UseOnPremAD(); // See config section: ActiveDirectoryCredentialPlugin
        }) // v10.2.1
        .AddSoDatabase()
        .AddServicesImplementation()
    }

    public void ConfigureServices(IServiceProvider serviceProvider)
    {
        var netServerServiceProvider = serviceProvider.RegisterWithNetServer();
    }
}
```

There are several default implementations of ISoContextProvider located in SoCore.

* ThreadContextProvider
* ContextContextProvider
* ProcessContextProvider

Another is HttpContextProvider, located in SuperOffice.DCFWeb.

### Services Mode Changes

The Setting for Services Local or Remote NetServer mode has been removed from the Config.  This has been replaced with extension methods to IServiceCollection.

For Local mode calling Services Implementation, use:

* services.AddDCFServicesImplementation();
* services.AddServicesImplementation();
* services.AddMessagingServicesImplementation();

For remote mode using proxies, use:

* services.AddServicesProxies();

```csharp
class Startup
{
    public IConfigurationRoot Configuration { get; set; }

    public virtual void Configure(IServiceCollection services)
    {
        services.AddLogging(a =>
        {
            a.AddConfiguration(Configuration.GetSection("Logging"));
        });
        services.AddNetServerCore<ThreadContextProvider>()
        .AddServicesProxies();
    }

    public void ConfigureServices(IServiceProvider serviceProvider)
    {
        var netServerServiceProvider = serviceProvider.RegisterWithNetServer();
    }
}
```

## Configuration Files

There are two configuration files of concern. Each application that uses NetServer must contain a well-defined configuration file. This section contains all available settings to configure SuperOffice NetServer and provides explanations and examples for each section.:

* appSettings.json (for logging level)
* Web Application: *web.config* or Windows Application: *MyApp.exe.config*

The appSettings.json file is used to configure logging level using "SuperOffice" as the ILoggerProviderPlugin name.

```json
{
 "Logging": {
    "LogLevel": {
      "Default": "Error",
      "Microsoft": "Error",
      "SuperOffice": "Warning"
    }
  }
}
```

The application configuration file must contain a section group named `SuperOffice`. Under it, additional sections and section groups are required that define NetServer configuration elements needed to operate.

## Configuration sections

Below is a configuration file with only the bare essential SuperOffice sections defined:

[!code-xml[XML](includes/web.config)]

## SuperOffice section group

[!code-xml[the SuperOffice section group](includes/section-group-SuperOffice.xml)]

In between the ending `configSections` and `configuration` element, there must be a `<SuperOffice></SuperOffice>` element that defines the values that set the NetServer runtime behavior.

View one of the available sections to learn more about the property settings available in each one.

> [!TIP]
> Consider using the [ConfigFile utility class][1] to access the SuperOffice section in the config file.

<!-- Referenced links -->
[1]: <xref:SuperOffice.Configuration.ConfigFile>

<!-- Referenced images -->
