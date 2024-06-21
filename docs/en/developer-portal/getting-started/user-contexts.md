---
title: User contexts
uid: user-context
description: "Learn the difference of and requirements for an interactive user session and non-interactive background services."
author: Bergfrid Dias
date: 09.14.2023
keywords: user context, session, application user, system user
topic: concept
envir: cloud
client: online
---

# User contexts

An application can have three types of interaction with a tenant: interactive user sessions; non-interactive background services; or hybrid.

SuperOffice CRM Online supports both types of interactions. The first as an **application user** context and the second as a **system user** context.

**Internal applications** have tight integration with user interface components inside SuperOffice. Applications that add a navigator button, a menu button, or a web panel commonly follow this model.

**External applications** are hidden integrations where most or all interaction happens at the partner's website or cloud.

| Requirement | SOAP | REST | Comments |
|---|---|---|---|
| User-interactive | X | X | Default workflow. |
| Non-interactive| X | | System-user workflow. |
| Semi-interactive | X | X | `refresh_token` workflow. |

## Application user (interactive)

This is the typical case when a **person** is signed in to SuperOffice.

**Requirements:**

* Application is interactive/reactive
* Application has UI in SuperOffice
* Users have their own sign-in credentials
* Users have their own options

Applications are **not allowed to directly ask users for their credentials**, and therefore must use SuperOffice [federated authentication][1] to sign SuperOffice CRM Online users into their applications.

Interactive authentication is facilitated by the [SuperOffice Online sign-in page][10]. This is discussed in the [Authentication section][3].

## System user (non-interactive)

All applications that run as background tasks, without user interaction, must receive a [system user token][2] and use the [system-user flow][2] for interacting with our web services. None of the [OpenID Connect flows][4] are supported.

The system user has unlimited access to the [tenant][6] and is not restricted by functional rights or data rights.

**Requirements:**

* The application runs in the background
* The application must bypass the sentry
* No UI elements in SuperOffice
* Runs as a service

To conduct true background processing, applications must use the system user **token** that was issued to them during the installation process. Applications use the SOAP-based `PartnerSystemUserService` endpoint to exchange a system user token for a system-user **ticket**.

When used in a **SOAP** request, the system-user ticket is used as credentials, placed inside each SOAP header as seen in the `ContactAgent.GetContactEntity` method.

```XML
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope namespaces left out for brevity>
  <Contact:ApplicationToken>1234567-1234-9876</Contact:ApplicationToken>
  <Contact:Credentials>
    <Contact:Ticket>7T:1234abcxyzExample==</Contact:Ticket>
  </Contact:Credentials>
 <SOAP-ENV:Body>
   <Contact:GetContactEntity>
    <Contact:ContactEntityId xsi:type="xsd:int">0</Contact:ContactEntityId>
   </Contact:GetContactEntity>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>
```

When used in a **REST** request, the system-user ticket is placed in the Authorization header as an SOTICKET.

```http
Authorization: SOTicket 7T:1234abcxyzExample==
SO-AppToken: Application_Token_Value
```

System users have unlimited access to the database and are not subject to any security or sentry constraints. System users cannot impersonate other users in the online environment.

See also the [system user MVC example][7].

## Semi-interactive scenario

**Hybrid applications** can, as the name suggests, have some UI components inside SuperOffice CRM Online and can operate or be configured on a partner web portal. The majority of applications are hybrids.

Applications that use OAuth2/OpenID Connect to authenticate users via the [Authorization Code flow][4], or Native App Flow, do receive a refresh token. The refresh token is (as of this writing) good for as long as the user is authorized to access the application, and can be securely stored on behalf of that user for subsequent API interaction.

To use a refresh token, the application must issue a POST request to the **tokens** endpoint with the following details:

* Client ID
* Client secret
* Redirect URI
* Grant type specified as `refresh_token`
* The actual refresh token

An example POST request:

```http
POST Request (can be tested in a client such as Postman or Fiddler)
Content-Type: application/x-www-form-urlencoded

https://sod.superoffice.com/login/common/oauth/tokens?
client_id=f123b7d98f3c496fb5aaa4b1f54cawe6&
client_secret=09d5f3bdf0afbc3bv9d0682e9b86lk89&
redirect_uri=http://partner-app/callback&
grant_type=refresh_token&
refresh_token=t6XaHSHkTbB1234abcxyzExample
```

The response contains the `access_token` necessary to issue in subsequent REST or SOAP requests.

When used in RESTful requests, the `access_token` is placed in each request Authorization header using the Bearer prefix.

```http
Accept: application/json
Authorization: Bearer 8A:Cust12345.abcxyzExample==
```

Supported in version **Services86** and higher, when used in SOAP requests, the `access_token` is placed in each SOAP header.

```XML
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope namespaces left out for brevity>
  <Contact:ApplicationToken>1234567-1234-9876</Contact:ApplicationToken>
  <Contact:Credentials>
    <Contact:Ticket>8A:Cust12345.abcxyzExample==</Contact:Ticket>
  </Contact:Credentials>
 <SOAP-ENV:Body>
   <Contact:GetContactEntity>
    <Contact:ContactEntityId xsi:type="xsd:int">0</Contact:ContactEntityId>
   </Contact:GetContactEntity>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>
```

<!-- Referenced links -->
[6]: index.md#tenant
[3]: what-api-to-use.md#authentication-scenarios
[1]: ../../identity-management/federated-auth.md
[2]: ../../api/authentication/online/auth-application/index.md
[4]: ../../api/authentication/online/index.md
[7]: ../../api/tutorials/minimal-csharp-app/overview.md
[10]: https://online.superoffice.com/login/
