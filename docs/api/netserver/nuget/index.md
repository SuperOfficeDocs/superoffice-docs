---
title: so_nuget
description: SuperOffice on NuGet
author: Tony Yates
so.date: 02.29.2016
keywords:
so.topic: article # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: # cloud or onsite
so.client: # online, web, win, pocket, or mobile
---

# Overview

I am pleased to announce SuperOffice now has NuGet packages targeting common development and integration
scenarios! The available packages are only for SuperOffice version 8 and newer. Older SuperOffice version integrations must download and use the assemblies provided in the SDK.

## Target usage

SuperOffice packages are created according to their target usage.

* When you build an application that only uses NetServer Core APIs (Entities, Rows, and OSQL), your project should use the **SuperOffice.NetServer.Core** package.

* When you build an application that uses NetServer web service proxies, your project should use the **SuperOffice.NetServer.Services** package.

## Package dependencies

Some of the packages have SuperOffice package dependencies:

* SuperOffice.NetServer.Services depends on SuperOffice.NetServer.Core.
* SuperOffice.Crm.Web depends on SuperOffice.NetServer.Services.

## Configuration

Most SuperOffice packages include configuration transformations. If not already present, the transformations will add the required SuperOffice configuration settings in your project's *app/web.config* files. Afterward, you only need to fill in the appropriate settings, such as database server and database name.

## Releases

The release plan accommodates both onsite and online customers. Most packages will be in line with onsite releases. However, if SuperOffice publishes a newer package with fixes that target online, onsite releases will not be affected as onsite projects should reference specific versions that are in line with published onsite releases.

## Available packagers

All available packages including their public name, install name, description, and list of associated assemblies and dependencies are detailed on the following pages:

* [NetServer Core][1]
* [NetServer Services][2]
* [CRM Web][3]
* [CRM Online Core][4]
* [CRM Online WinClient][5]
* [CRM Online Database Mirroring][6]

<!-- Referenced links -->
[1]: netserver-core.md
[2]: netserver-services.md
[3]: crm-web.md
[4]: crm-online-core.md
[5]: crm-online-winclient.md
[6]: crm-online-mirroring.md

<!-- Referenced images -->
