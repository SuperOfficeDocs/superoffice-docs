---
uid: nerserver_config
title: NetServer configuration
description: "Introduction to the NetServer configuration file for SuperOffice with explanations and examples for each section."
author: Bergfrid Dias
date: 12.07.2021
keywords: config, web.config, NetServer
content_type: reference
deployment: onsite
redirect_from: /en/api/netserver/config/index
---

# NetServer configuration

NetServer is a multi-tiered database access layer that bridges communication between clients and the SuperOffice database. It contains both low-level classes for managing data access in onsite domain environments as well as high-level web services for access from anywhere in the world.

For API consumers using either the SuperOffice.NetServer.Core or SuperOffice.NetServer.Services assembly, it is important to understand the configuration requirements and options. This article provides an introduction to the NetServer configuration file for SuperOffice with explanations and examples for each section.

Bootstrapping NetServer in your application required some dependency injection (DI) configuration. See the appropriate DI section for your application type:

* SuperOffice.NetServer.Core: [Dependency injection configuration][2]
* SuperOffice.NetServer.Services: [Dependency injection configuration][3]

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
[2]: <xref:netserver_core_api>
[3]: <xref:netserver_services_api>

<!-- Referenced images -->
