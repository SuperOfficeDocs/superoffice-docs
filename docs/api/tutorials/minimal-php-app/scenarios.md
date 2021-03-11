---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: minimal_php_app_scenarios # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Scenarios # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id} # Your GitHub alias.
keywords:
so.topic: # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud # cloud or onsite
so.client: online # online, web, win, pocket, or mobile
---

# Scenarios

These scenarios walk you through the [nuSoapSample][1] code and what happens when you run the sample.

These sequence diagrams were built using an online resource `www.websequencediagrams.com`. The text used to generate these diagrams is located at the end of this document.

## Create a new company as the current application user

The following diagram describes how the first link works, how to create a company using the signed-in user account.

![x][img1]

There are several helper classes to make things easier and are described in subsequent sections of this document.

## Create a new company as a system user

The following diagram describes how create a company using the [system user token][2]. The key thing to understand here is that the system user token is not a usable credential. It is used in exchange for a system user ticket. The system user ticket is the usable credential for passing into web service methods.

![x][img2]

As stated before, there are several helper classes to make things easier. An important one is the `SystemUserHelper` class. It's used to look up the current user context, get the stored system user token, sign the token, call the tenant service and it returns a server signed token containing claims.

The web application must then validated the new server token, then extract the system user ticket.

[!include[ALT](./includes/system-user-helper-class.md)]

The application must validate the new JWT token using the public SuperOffice certificates. Once validated as an authentic token, the application uses another helper class, **ClaimNames**, to convert the token into an SoContext class – containing properties such as name, company, ticket, and NetServerUrl.

With the new **SoContext** available, containing the ticket credentials for a system user, the application proceeds to call the **ContactEnitityHelper** to create a new company.

[!include[ALT](./includes/create-contact-entity.md)]

## More advanced scenario

This sequence represents a common scenario where a service exists that communicates with a tenant on a revolving interval.

1. User navigates to the partner application.
2. User is not authenticated for access to SuperOffice functionality and is therefore redirected.
3. User is redirected to SuperID with client ID for authentication.
4. User is successfully authenticated and redirected to the partner applications redirect URL.
5. Partner application receives SuperID request and JWT token. Validated using certificates.
6. Partner application processes/configures user and stored system user token in the database.
7. Partner service polls database for new tenant user tokens.
8. Partner service signs user token with its private key and sends to SuperID for exchange of system user ticket.
9. Partner service validates system user token using certificates.
10. Partner service calls tenant web services using a system user ticket.

![x][img3]

<!-- Referenced links -->
[1]: overview.md
[2]: ../../authentication/system-user/system-user-token.md

<!-- Referenced images -->
[img1]: media/image005.png
[img2]: media/image007.png
[img3]: media/image009.png
