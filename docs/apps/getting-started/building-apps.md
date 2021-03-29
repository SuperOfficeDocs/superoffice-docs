---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: getting_started       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Building apps for SuperOffice # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: concept            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Building apps for SuperOffice

When creating an application for SuperOffice CRM Online, you need to learn about our APIs and follow our implementation guide.

## Workflow from a developer's perspective

1. Register as a developer to get access to our [environment][1]

    * signs you up for a developer user account
    * creates a test [tenant][2] in SOD (can be shared by multiple developers within a company)

2. Register your application idea to get your [client ID and client secret (token)][3]

    * it's essential that you provide us with your [redirect URLs][4] at this point
    * you receive a unique set of keys to identify your application and certificates for authentication

3. Develop your application

4. Test your application

    * **standard application**: [get certified][6] and pass the security evaluation
    * **custom application**: [get validated][7]

5. Deploy your application

    * **standard application:** [launch in the App Store][8]
    * **custom application**: [activate][9] for one specific customer's database

### Upgrade

We take precautions to ensure that no individual upgrade plan compromises data or the availability of services for any customers. This includes informing you about new versions, what's changing, and when it's deployed - with the opportunity to test and update your own offerings in line with the SuperOffice CRM Online services.

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
[2]: ../tenant-status/index.md
[3]: ../client-id-secret.md
[4]: ../redirects/index.md
[6]: ../certification/certify-app.md
[7]: ../activate/validate-app.md
[8]: ../publish/get-listed.md
[9]: ../activate/activate-custom-app.md
[10]: https://github.com/SuperOfficeDocs/data-access/blob/main/docs/tutorials/native-app-quickstart.md
[11]: https://github.com/SuperOfficeDocs/data-access/blob/main/docs/tutorials/auth-code-flow-quickstart.md
