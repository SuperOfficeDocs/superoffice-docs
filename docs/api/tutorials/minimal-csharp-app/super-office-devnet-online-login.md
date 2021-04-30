---
title: superoffice.devnet.online.login
uid: super_office_devnet_online_login
description: superoffice.devnet.online.login
author: {github-id}
keywords:
so.topic: tutorial
so.envir: cloud
so.client: online
---

# superoffice.devnet.online.login

This project has several helper classes that facilitate common operations such as hosting and providing models for user context and securing access.

Key classes in the Login library and their purpose:

## PartnerHttpContext Class: SuperOffice Context Provider

When SuperOffice API code is run, a context provider is required to supply an authenticated principal to the executing code:

1. During initial authentication, NetServer validates a set of credentials
2. NetServer then delegates to the context provider and lets it determine where to store the session containing the principal.

The default memory storage location options for a SuperOffice session are:

* Process
* Context
* Thread

These defaults don't scale well in web applications. Therefore, we need to create a context provider that stores the session in an ASP.NET web application-friendly way.

This example implementation uses ASP.NET Session state as a storage medium.

Please refer to the code in the *SuperOffice.DevNet.Online.Login.SoPlugins.HttpContextProvider.cs* file for details.

## SuperOfficeAuthorizeAttribute Class: Access Security

Protecting data and resources, and requiring user context, is a necessity.

In this example, the `SuperOfficeAuthorizeAttribute` class is the gatekeeper. Its job is to stand in front of each method containing SuperOffice API code and verify that an authenticated session exists.

* If an authenticated session exists, the method is allowed to proceed.
* If an authenticated session doesn't exist, the user is redirected to the SuperOffice SuperID federated login page. This is defined in the appSettings>SoFederationGateway property.

Upon successful authentication, the user is then redirected from SuperID to the predefined callback URL.

The URL that defines the SuperOffice SuperID login page is defined in the **SoFederationGateway** appSettings value and will change when moving to the [production environment][1].

<!-- Referenced links -->
[1]: ../../../../superoffice-docs/docs/apps/getting-started/app-envir.md
