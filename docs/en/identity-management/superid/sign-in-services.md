---
title: Sign-in services
uid: sign_in_services
description: "Learn about SuperOffice sign-in services."
author: Bergfrid Dias
keywords: SuperID, sign-in, user account
date: 02.02.2022
content_type: concept
deployment: online
platform: web
index: true
---

# Sign-in services

The sign-in service determines **how** you get access to SuperOffice CRM Online and **who** manages your credentials.

We currently support 2 models:

* The **SuperID** sign-in service with password (standard)
* The **SuperID** sign-in service with an IDP registered

Each provides the administrator and the end-user with a set of features to administer the users. SuperOffice CRM Online will send users to the correct place to authenticate.

## The SuperID sign-in service

The [SuperID][1] sign-in service has 2 levels - basic and federated. Each CRM Online user account can belong to 1 SuperID user account. One CRM Online user account + password can belong to 1 or more sites.

If you would like to use **SuperID - federated** features, you need to register an [identity provider][2].

### SuperID - basic

The basic level of the SuperID sign-in service uses a password to authenticate like the standard sign-in service. However, this centralized model doesn't store passwords in the CRM Online database. It actually uses SuperID as the identity provider.

**Sign-in sequence:**

* The user opens `online.superoffice.com` in a browser and enters their email address or username.
* The username is inspected and forwarded to `id.superoffice.com`.
* The user is asked for a password, which is verified by authenticating towards SuperID.
* The user is signed in to the correct site (pick site if the user is connected to multiple sites).

### SuperID - federated

SuperID supports using 3rd-party federated sign-in services as an add-on. You can choose either Microsoft or Google to authenticate.

To use federated sign-in, [register your domain name][3] (so the sign-in service knows which identity provider to send your users to).

**Sign-in sequence:**

1. The user opens `online.superoffice.com` in a browser and enters their email address or username.
2. The username is inspected and forwarded to `id.superoffice.com`.
3. The user is verified by **delegating authenticating to Microsoft or Google**.
4. SuperID receives and **stores the sign-in session**.
5. The user is signed in to the correct site (pick site if the user is connected to multiple sites).

<!-- Referenced links -->
[1]: overview.md
[2]: ../federated-id-and-identity-providers.md
[3]: howto/register-idp.md
