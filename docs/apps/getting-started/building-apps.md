---
title: Getting started
uid: apps_get_started
description: Getting started building apps for SuperOffice
author: {github-id}
keywords:
so.topic: getting-started
so.envir: cloud
so.client: online
---

# Building apps for SuperOffice

When creating an application for SuperOffice CRM Online, there are several key elements that all partners must understand. Explore our documentation to learn about security, authentication, validation, development environment, provisioning, and application models.

Partners building applications for SuperOffice CRM Online must be comfortable with **federated authentication**. All applications must use **SuperID** for authenticating users.

![soap-onboarding.jpg][img1]

To develop applications in our SOD environment is free. Required licenses apply only in production (live).

## Workflow from a developer's perspective

1. Register as a developer to get access to our [environment][1].

    * Signs you up for a developer user account.
    * Creates a test [tenant][3] in SOD (can be shared by multiple developers within a company).

2. Register your application idea to get your [client ID and client secret (token)][3].

    * It's essential that you provide us with your [redirect URLs][4] at this point.
    * You receive a unique set of keys to identify your application and certificates for authentication.

3. Develop your application.

4. Test your application.

    * **standard application**: [get certified][6] and pass the security evaluation
    * **custom application**: [get validated][7]

5. Deploy your application.

    Your new standard or custom application has been developed and tested and is now ready to be put to work.

    * **standard application:** [launch in the App Store][8]

    ![stdapp-publishing.jpg][img2]

    * **custom application**: [activate][9] for one specific customer's database

    ![custapp-publishing.jpg][img3]

### Upgrade

We take precautions to ensure that no individual upgrade plan compromises data or the availability of services for any customers. This includes informing you about new versions, what's changing, and when it's deployed - with the opportunity to test and update your offerings in line with the SuperOffice CRM Online services.

## Preferred technology stack

All types of technology platforms, including Java, PHP, Python, Ruby, and many more can integrate with NetServer web services.

Any technology stack that supports web services can connect to and exchange data with SuperOffice NetServer via REST or SOAP protocols.

For SOAP SuperOffice supplies .NET proxy assemblies as NuGet packages. All other technology platforms must generate their own proxies, or use raw SOAP/XML, to access the web services.

## Set up your SuperOffice app development environment

Before you begin coding...

Some platform capabilities must be explicitly enabled for the application:

* System user token
* Database mirroring
* Webhooks
* ERP Sync
* Quote Connectors

You may later change these settings, but these changes will revoke the current access to the tenants and require the customer administrator to re-approve the application.

When we set up the application and send the client ID, client secret, and system user private key to you, we will also specify which web service endpoints your application will receive back by default. These endpoints are not changed unless you specifically ask for them. The same goes for any of the other capabilities or whitelisted URLs.

## Confused about where to start?

If you are new to developing for SuperOffice CRM Online, a good place to start is reading up on key concepts.

### Quick-start guides

Creating an application for the SuperOffice App Store is not something to take lightly. There are a few key elements that all application vendors must understand before their creations are released into the wild. Here we guide you through the journey for successfully creating an application ready for SuperOffice CRM Online.

**Before you begin:**

* You must have completed steps 1 and 2 above.
* Be prepared to receive and validate tokens:
  * Build a native or web application that can receive and validate the JSON web token.
  * Sign in to SuperOffice online using OAuth 2.0/OpenID Connect, and then give consent to allow your application to access your tenant resources.

**Available guides:**

* [Create native app][10]
* [Create ASP.NET Core app][11]

<!-- Referenced links -->
[1]: app-envir.md
[3]: ../terminology.md
[4]: ../redirects/index.md
[6]: ../certification/certify-app.md
[7]: ../activate/validate-app.md
[8]: ../publish/get-listed.md
[9]: ../activate/activate-custom-app.md
[10]: ../../../../data-access/docs/tutorials/native-app-quickstart.md
[11]: ../../../../data-access/docs/tutorials/auth-code-flow-quickstart.md

<!-- Referenced images -->
[img1]: media/soap-onboarding.jpg
[img2]: media/stdapp-publishing.jpg
[img3]: media/custapp-publishing.jpg
