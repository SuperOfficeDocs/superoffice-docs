---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: so_on_nuget # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: SuperOffice on NuGet # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Tony Yates # Your GitHub alias.
so.date: 02.29.2016
keywords:
so.topic: article # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud # cloud or onsite
so.client: online # online, web, win, pocket, or mobile
---

# SuperOffice on NuGet

I am pleased to announce SuperOffice now has NuGet packages targeting common development and integration
scenarios! The available packages are only for SuperOffice version 8 and newer; older SuperOffice version integrations must download and use the assemblies provided in the SDK.

SuperOffice packages are creating according to their target use. When you build an application that only uses NetServer Core APIs, i.e. Entities, Rows and OSQL, then your project should use the SuperOffice.NetServer.Core package. When you build an application that uses NetServer web service proxies then your project should use the SuperOffice.NetServer.Services package.

Some of the packages do have SuperOffice package dependencies. SuperOffice.NetServer.Services has a package dependency on SuperOffice.NetServer.Core. Similarly, SuperOffice.Crm.Web has a package reference on SuperOffice.NetServer.Services.

Most SuperOffice packages include configuration transformations. If not already present, the transformations will add the required SuperOffice configuration settings in your project's app/web.config files. Afterward, you only need fill in the appropriate settings; such as database server and database name.

The release plan accommodates both onsite and online customers. Most packages will be inline with onsite releases. However, if SuperOffice publishes a newer package with fixes that target online, onsite releases will not be affected as onsite projects should reference specific versions that are inline with published onsite releases.

All available packages are detailed below, including their public name, install name, description and list of associated assemblies and dependencies.

## NetServer Core

`Install-Package SuperOffice.NetServer.Core`

SuperOffice NetServer Core is SuperOffice's data access technology for new applications. This is for onsite installations
with the same version. This also works with SuperOffice Online.

The assemblies included are:

* Aspose.Words
* ICSharpCode.SharpZipLib
* Ionic.Zip
* SOCore
* SoDatabase
* SoLicense
* SuperOffice.Contracts
* SuperOffice.FeatureToggles
* SuperOffice.Mime
* SuperOffice.Plugins

Framework references are:

System.IdentityModel

## NetServer Services

`Install-Package SuperOffice.NetServer.Services`

SuperOffice NetServer Services is SuperOffice's web service client proxies. This is for onsite installations with the same
version. This also works with SuperOffice Online.

The included assemblies are:

* SoBatchProcessing
* SuperOffice.AAAMock.Services
* SuperOffice.AAAMock.Services.Implementation
* SuperOffice.­Audience.Services
* SuperOffice.Audience.Services.Implementation
* SuperOffice.DCF
* SuperOffice.DCF.Serv­ices
* SuperOffice.DCF.Services.Implementation
* SuperOffice.Messaging
* SuperOffice.Messaging.Services
* Su­perOffice.Messaging.Services.Implementation
* SuperOffice.Services
* SuperOffice.Services.Implementati­­on
* SuperOffice.Services.WcfProxy
* SuperOffice.Services80.Contract
* SuperOffice.Services80
* SuperOffice­.­Services80.Wcf

The package dependencies are:

* SuperOffice.NetServer.Core

## CRM Web

`Install-Package SuperOffice.Crm.Web`

SuperOffice CRM Web is for extending onsite installations with custom dialogs, controls, datahandlers, filters,
Ajax-methods, and so on. This is for onsite integrations only!

Included assemblies are:

* SuperOffice.CRMWeb
* SuperOffice.DCFWeb
* SuperOffice.Web.UI.Controls

Package dependencies are:

* SuperOffice.NetServer.Core
* SuperOffice.NetServer.Services

## CRM Online Core

`Install-Package SuperOffice.Crm.Online.Core`

SuperOffice Online Core assists apps with SuperOffice federated authentication.

Included assemblies are:

* SuperOffice.Online.Core
* SuperOffice.SuperID.Client
* SuperOffice.SuperID.Contracts

Framework assemblies are:

* System.IdentityModel
* System.Configuration

Package dependencies are:

* System.IdentityModel.Tokens.Jwt

## CRM Online WinClient

`Install-Package SuperOffice.Crm.Online.WinClient`

SuperOffice Online WinClient is for WinForms or WPF applications that need support for SuperOffice online federated authentication.

Included assemblies are:

* SuperOffice.SuperId.WinClient

Package dependencies are:

* SuperOffice.Crm.Online.Core

## CRM Online Database Mirroring

`Install-Package SuperOffice.Crm.Online.Mirroring`

SuperOffice Online Mirroring is used to replicate online tenants database for applications.

Included assemblies are:

* SuperOffice.Online.Mirroring.Contract
* SuperOffice.Online.Mirroring.Data
* SuperOffice.Online.Mirroring
* Su­perOffice.Performance.Transmitter

Package dependencies are:

* SuperOffice.Crm.Online.Core

## In Closing

Code examples and walk-throughs will become available very soon! As always, your feedback is welcome!
