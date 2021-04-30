---
title: minimal_csharp_app_overview       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Minimal C# application # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: guide            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Minimal C# application

So - you want to build applications that work in the SuperOffice Online Development (SOD) environment. Let's look at how to use a system user when interacting with SuperOffice Online tenant web services.

This example is based on C# ASP.NET MVC and a console application.

## Assumptions

We assume that you understand what SuperOffice CRM Online is and that you have a working knowledge of programming in C#, certificates, and JWT tokens.

## Prerequisites

* Visual Studio 2013 (or later)
* .Net 4.8 framework
* You have [configured certificates][1] on your SOD machine
* You have a *Temp* folder on the C:\\ drive to store system user tokens.

> [!TIP]
> [Run Visual Studio as administrator][2]. If the *SuperOffice.Online.SuperIdDemoApp* project fails to load, it is probably because your Visual Studio is not run as administrator.

## Functional components

There are 4 projects in the *SystemUserApps.sln* solution:

* SuperOffice.DevNet.Online.SystemUser.Mvc
* SuperOffice.DevNet.[SystemUser.PartnerDbLibrary][3]
* SuperOffice.DevNet.[Online.Login][4]
* SuperOffice.DevNet.Online.[SystemUser.ServiceConsole][5]

### ASP.NET MVC application

This is an application that represents the minimum an App Store application is required to handle. The essentials include:

* authenticating an administrator installing the application
* obtaining a system user ticket

### Console application

This is a [mock-up of a partner service][5] that periodically checks the file for new tenants. It demonstrates how to obtain a system user ticket from a system user token.

### Shared partner data source

This example uses an XML file to store system user tokens for SuperOffice online tenants.

CustomerDataSource is located in the [SuperOffice.DevNet.Online.SystemUser.PartnerDBLibrary][3] project.

## Application overview

The 1st time the web application runs, the default page will detect that the current user hasn't signed in to this application and it will redirect the user to the SuperOffice federation gateway (SuperID) for authentication.

The client ID is added to the URL that is passed to SuperID. The ID is registered in SuperID’s Operation Center (OC). By looking up the ID, SuperID can learn the redirect URLs of your application.

![x][img1]

### Application approval page

After successful authentication, the application approval page is presented to the user. This page displays an **I approve** button, which must be clicked to allow the application to access to the customers’ web services and database.

In the future, the approval page may expose additional controls such as checkboxes for more specific rights.

![x][img2]

### HomeController

*HomeController.cs* is the default action and its responsibility is to check if the current user is signed in. If the current user is not signed in, the home controller will redirect the user to the SuperID sign-in URL (SuperOffice Federation Gateway).

The home controller uses a security attribute class defined in *SuperOfficeAuthorizeAttribute.cs*, located in the [SuperOffice.Online.PartnerLogin][4] project.

> [!TIP]
> The URL for SuperID is located in the *appSettings* section of the *App.Config* file and [Web.Config][6] file.

The client ID is appended to the URL when redirected to SuperID. This is done so that SuperID knows what application sent the user to sign in, and where SuperID must redirect the user once the user has been successfully authenticated.

### CallbackController

The responsibility of *CallbackController.cs* is to validate the JWT token issued by SuperID and establish a user context. It is called after a user is successfully authenticated by SuperID.

The *token* contains all of the claims a partner's application needs to connect to and communicate with the user tenant in SuperOffice Online.

The *user context* will be used by the web application for all successive calls to the tenant web services. It is managed in the *PartnerHttpContext* class defined in the [SuperOffice.Online.PartnerLogin][4] project.

1. SuperID will use the [client ID][7] to determine where the user is redirected. The default [redirect URL][8] of the example application is `http://localhost/SuperOffice.Online.SuperIdDemoWeb/Callback`

2. SuperID passes the JWT token with claims in the redirect response.

3. The callback controller establishes the current user context.

4. It also adds the system user token to a database.

5. The user is redirected to the application default page after completion.

> [!NOTE]
> The redirect URL can be changed if requested. Future capabilities will enable you to change it yourself, but for now, you must send an email to have it changed for you. Redirect URL change requests can be sent to sdk@superoffice.com.

### ContactEntityController

*ContactEntityController.cs* is used to demonstrate how to [create a new company using the current user][9].

### SystemUserController

*SystemUserController.cs* is used to demonstrate how to create a new company using the system user.

This controller leverages the `SystemUserHelper` class and then redirects the results to the *ContactEntityController* for displaying the new company details.

### SystemUserHelper

*SystemUserHelper.cs* contains the code that demonstrates the key aspects of this example:

1. Sign a system user token with a private key
2. Exchange a system user token for a security token that contains a system user ticket
3. Validate a security token
4. Use the security token to establish a tenant context (Database Context)
5. Authenticate as a system user using the system user ticket

### Private key

The private key (*partnerprivatekey.xml*) is responsible for signing the system user token before sending a request to receive a system user ticket from SuperID.

This happens in step 8 of [our scenario][9].

When a user clicks **Install SuperOffice Maps**, the application checks to see if you are already logged into SuperID:

* If logged in, the user is redirected to the *LoginRedirect.aspx* page.
* If not, the application redirects to the SuperID login page.

<!-- Referenced links -->
[1]: ../../authentication/online/certificates/configure.md
[2]: ../../../../superoffice-docs/docs/apps/getting-started/run-website-on-iis-localhost.md
[3]: partner-db-library.md
[4]: super-office-devnet-online-login.md
[5]: system-user-service-console.md
[6]: web-config.md
[7]: ../../../../superoffice-docs/docs/apps/terminology.md
[8]: ../../../../superoffice-docs/docs/apps/redirects/index.md
[9]: scenarios.md

<!-- Referenced images -->
[img1]: media/image011.png
[img2]: media/image012.png
