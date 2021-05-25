---
description: nerserver_config      
description: NetServer configuration
author: {github-id}
keywords: web.config
so.date: 06.06.2018
author: {github-id}
keywords: config
so.topic: reference
so.envir: onsite
---

# NetServer configuration

Each application that uses NetServer must contain a well-defined configuration file. This is imperative for both Windows and web applications.

This section contains all available settings to configure SuperOffice NetServer and provides explanations and examples for each section.

* Windows Application: *MyApp.exe.config*
* Web Application: *web.config*

The configuration file must contain a section group named `SuperOffice`. Under it, additional sections and section groups are required that define NetServer configuration elements needed to operate.

## SuperOffice section group

[!code-xml[the SuperOffice section group](includes/section-group-superoffice.xml)]

In between the ending `configSections` and `configuration` element, there must be a `<SuperOffice></SuperOffice>` element that defines the values that set the NetServer runtime behavior.

View one of the available sections to learn more about the property settings available in each one.
