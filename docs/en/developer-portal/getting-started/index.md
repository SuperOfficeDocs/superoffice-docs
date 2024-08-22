---
title: Building apps for SuperOffice
uid: apps-get-started
description: Getting started building apps for SuperOffice
author: Bergfrid Dias
date: 09.14.2023
keywords: developer, app, application, extensibility, integration point, authorization
topic: concept
envir: cloud
client: online
--- 

# Building apps for SuperOffice

SuperOffice CRM Online has great extensibility points that allow vendors to create complimentary applications in and around SuperOffice.

While a great standalone CRM solution, SuperOffice becomes better with complimentary applications. To develop applications in our SOD environment is free. Required licenses apply only in production (live).

> [!TIP]
> **TLDR:** All API communication with the database requires an app! To build one, [follow these 5 steps](#tldr). Sign in to the Developer Portal at [https://dev.superoffice.com][20].

## What are applications?

[!include[Application defined](../includes/def-app.md)]

The key to any integration is that the application is relevant and adds value to customers in their sales, marketing, customer service, and/or business processes.

You can think of an application as a link to another cloud service. The link allows the other service to retrieve, present, or add data to SuperOffice.

If you use the APIs, which you will have to use to communicate with the database, it is an application!

All SuperOffice CRM Online applications get a [unique ID](#client-id) to identify each integration within our environment.

## SuperOffice CRM Online web client at a glance

* An online platform serving thousands of customers
* Distributed and federated platform service
* Client-side JavaScript
* CRM integrations limited to web panels and database access
* Customer Service integrations can be almost everything you want

## Ways your application can extend SuperOffice

Applications can be or do the following:

* An add-on module
  * SuperOffice Web Tools
  * Calendar synchronization
* A configuration
  * Industry-specific categorization
  * Document templates
  * Email templates
* Synchronize data between SuperOffice and an ERP system
* Trigger workflows between systems
* One-way data update (address, financial and similar) between SuperOffice and external data providers

The extensibility points are platform-independent.

Anything a consultant can do inside the SuperOffice Admin application, any application can programmatically do during or after [provisioning][5]:

* Custom lists and list items
* User-defined fields
* Web panels
* Custom buttons
* Sales guide, project guide
* Preferences
* Re-skinned to customer's brand

Applications are either developed by SuperOffice or one of our partners.

### Integration services

Standard and custom applications can incorporate the following external-facing integrations:

* [Database Mirroring][10]
* [ERP Sync Connector][17]
* [Quote Connector][18]

These integration types are referred to as Integration Services.

## <a id="tldr"></a>Workflow from a developer's perspective

![Diagram of onboarding process for app developers][img1]

1. Register as a developer to get access to our [environment][1].

    * Signs you up for a developer user account.
    * Creates a test [tenant](#tenant) in SOD (can be shared by multiple developers within a company).

2. [Register your application idea][2] to get your [client ID and client secret (token)](#terminology).

    * It's essential that you provide us with your [redirect URLs][4] at this point.
    * You receive a unique set of keys to identify your application and certificates for authentication.

3. Develop your application.

4. Test your application.

    * **standard application**: [get certified][6] and pass the security evaluation
    * **custom application**: [get validated][7]

5. Deploy your application.

    Your new standard or custom application has been developed and tested and is now ready to be put to work.

    * **standard application:** [launch in the App Store][8]

    ![Diagram showing workflow for standard apps][img2]

    * **custom application**: [activate][11] for one specific customer's database

    ![Diagram showing workflow for custom apps][img3]

### Upgrade

We take precautions to ensure that no individual upgrade plan compromises data or the availability of services for any customers. This includes informing you about new versions, what's changing, and when it's deployed - with the opportunity to test and update your offerings in line with the SuperOffice CRM Online services.

## Preferred technology stack

All types of technology platforms, including Java, PHP, Python, Ruby, and many more can integrate with NetServer web services.

Any technology stack that supports web services can connect to and exchange data with SuperOffice NetServer via REST or SOAP protocols.

For SOAP SuperOffice supplies .NET proxy assemblies as NuGet packages. All other technology platforms must generate their own proxies, or use raw SOAP/XML, to access the web services.

## <a id ="hosting" />Application hosting

You are responsible for hosting your own applications, regardless of you develop standard applications for the SuperOffice App Store or custom applications for a specific customer.

SuperOffice will not bill, [provision][5], or host partner applications. Instead, the App Store redirects to our partners' websites where customers buy directly from the partner.

As a partner, you will have to host your applications in **your own cloud** environment. This could be in an environment managed by a group of partners or for example in their Azure or Amazon cloud.

In practical terms, this means that you must build and host a page that receives [JWT tokens][16] at the redirect URL. This page must be up and running before you attempt to connect to our APIs and authorize your application.

Before you get to authorization, you must sign up to get your unique [client IDs and client secret](#terminology). You must tell us about your [callback/redirect URLs][4] when you [create an application][2].

## Set up your SuperOffice app development environment

Before you begin coding, the application must be [registered in the Developer Portal][2].

## Confused about where to start?

If you are new to developing for SuperOffice CRM Online, a good place to start is reading up on key concepts such as security, authentication, validation, development environments, provisioning, and user contexts.

All partners creating an application for SuperOffice CRM Online must be comfortable with **federated authentication**. All applications must use **SuperID** for authenticating users.

### Quick-start guides

Creating an application for the SuperOffice App Store is not something to take lightly. There are a few key elements that all application vendors must understand before their creations are released into the wild. Here we guide you through the journey for successfully creating an application ready for SuperOffice CRM Online.

**Before you begin:**

* You must have completed steps 1 and 2 above.
* Be prepared to receive and validate tokens:
  * Build a native or web application that can receive and validate the JSON web token.
  * Sign in to SuperOffice online using OAuth 2.0/OpenID Connect, and then give consent to allow your application to access your tenant resources.

**Available guides:**

* [Create native app][19]

## Terminology

## Standard and custom applications

Applications are either [built to fit many][9] and available in the SuperOffice App Store or [one-off customization][12] for your company or a customer's company only.

[!include[Define app credentials](../includes/def-app-credentials.md)]

### <a id="client-id"></a>Client ID - ApplicationIdentifier

Uniquely identifies the application used, and used by the SuperOffice CRM Online to know where to redirect a user.

### <a id="client-secret"></a>Client secret - ApplicationToken

Must be supplied when invoking any of the SuperOffice CRM Online web services.

## Tenant

A specific SuperOffice installation registered for a specific customer. In other words, the unique combination of customersite/custid. Each application environment [SOD, stage, production][1] has its own set of tenants.

## Application models

How customers will interact with applications, tightly linked to [user contexts][3]. Each application falls into one of the following categories:

* Internal application
* External application
* Hybrid application

<!-- Referenced links -->
[1]: app-envir.md
[3]: user-contexts.md
[5]: ../provisioning/index.md
[2]: ../create-app/index.md
[4]: ../create-app/config/redirects.md
[6]: ../standard-app/certification/certify-app.md
[8]: ../standard-app/publish.md
[9]: ../standard-app/index.md
[7]: ../custom-app/validate.md
[11]: ../custom-app/activate.md
[12]: ../custom-app/index.md
[10]: ../../mirroring/overview.md
[16]: ../../api/authentication/online/validate-security-tokens.md
[17]: ../../api/plugins/erp-connectors/index.md
[18]: ../../api/plugins/quote-connectors/index.md
[19]: ../../api/tutorials/native-app-quickstart.md
[20]: https://dev.superoffice.com/

<!-- Referenced images -->
[img1]: media/soap-onboarding.jpg
[img2]: media/stdapp-publishing.jpg
[img3]: media/custapp-publishing.jpg
