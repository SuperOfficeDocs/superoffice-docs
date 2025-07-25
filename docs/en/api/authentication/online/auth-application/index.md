---
title: System user flow
uid: system_user_flow
description: SuperOffice system user flow for non-interactive server-to-server communications
author: SuperOffice Product and Engineering
keywords: authentication, system user, back-channel, non-interactive
content_type: concept
category: api
deployment: online
platform: web
redirect_from: /en/authentication/online/auth-application/index
---

<!-- markdownlint-disable-file MD051 -->
# System user flow (back-channel)

The **System User Flow** offers a method for server-to-server communication, eliminating the need for an interactive user login. This flow returns a JWT token that contains several claims **including a ticket**. The ticket claim is *the* credential, **not** the JWT itself, and is valid for up to 6 hours. Our recommended **best practice** for back-channel communications is to actively manage the system user ticket credential. The ticket credential is good for 6 hours, and has a sliding-expiration behavior that resets the 6 hour window each time it is used. We recommend applications cache the Ticket credential and keep track of the timeout period from when it was issued and last used. Only obtain a new ticket when the current one has expired or is about to expire.

Do not invoke the system user flow before each and every call to a tenant's API, unless there is more than 6 hours between each invocation.

You must for security reasons [Validate every security token][3] sent from SuperOffice CRM Online.

> [!WARNING]
> The ticket credential from the System User flow should be cached. It is valid for 6 hours, with a sliding expiration each time it is used. Therefore, only obtain a new one when necessary, for example when a request results in a 401 Unauthorized or the cache times out.

To better grasp the process, check out our visual walk-through:
<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube-nocookie.com/embed/Tyzm6H50DC8]

## Key concepts

* **System User**: A distinct user category that empowers an application to seamlessly access data without any limitations.

* **System User Token**: This "magic string" is received as a claim in the `id_token` when an administrative user authenticates your application for the first time.

* **System User Ticket**: This is a credential one receives as a claim in a JWT. It's generated when sending a signed version of the System User Token to the [PartnerSystemUser endpoint][8].

## Getting started

Before delving into the System User flow, ensure you meet these two prerequisites:

1. **Activate the System User Option**: While setting up your application in the [Developer Portal][1], choose the **Server to server** option.

    ![create-application-server-to-server.png -screenshot][img3]

2. **Acquire the System User Token**: An administrator needs to sign in to their tenant via [OAuth 2.0/OpenID Connect][10]. Once they approve the application after authentication, the `id_token` claim collection will contain the system user token.

Remember, the system user token:

* Is uniquely formatted: `Application Name-<random-number-of-characters>`.
* Stays constant for each tenant and application combo.
* Will remain unchanged throughout the application's life, unless rescinded by the client or app vendor.

### From Token to Ticket

1. Start by generating a [signed System User token][11].
2. Proceed to [send this signed token][8] to the SuperOffice PartnerSystemUser endpoint.
3. Upon receiving the response, [validate the JSON Web Token (JWT)][3].
4. Derive the Ticket claim from the JWT.

## Implementing the System User Ticket credentials

An application can harness the system user ticket in multiple ways:

* For HTTP requests in the Authorization header:
  * Swap `Authorization Bearer <access_token>` for `Authorization SOTicket <ticket>`.
  * The **SO-AppToken** header *has* to accompany the request, with the value being the OAuth 2.0 client_secret.

* For SOAP API, use the ticket in the **User:Ticket** element, and the client_id in the **User:ApplicationToken** element.

### [REST](#tab/rest)

```http
GET https://sod.superoffice.com/Cust12345/api/v1/User/currentPrincipal HTTP/1.1
Authorization: SOTicket {{ticket}}
SO-AppToken: {{client_secret}}
Accept: application/json
```

### [SOAP](#tab/soap)

See the `<User:Credentials>` and `<User:ApplicationToken>` elements:

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope" ...>
  <User:ApplicationToken>{{client_secret}}</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>{{ticket}}</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:GetUser>
    <User:UserId xsi:type="xsd:int">0</User:UserId>
   </User:GetUser>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>
```

Armed with valid credentials, your application is set to send authenticated requests to the desired customer tenant.

[Continue exploring Server-to-Serve][1] in the Developer Portal documentation.

<!-- Referenced links -->
[1]: ../../../../developer-portal/create-app/server-to-server-app.md
[3]: ../validate-security-tokens.md
[8]: get-system-user-ticket.md
[10]: ../sign-in-user/index.md
[11]: sign-system-user-token.md

<!-- Referenced images -->
[img3]: media/create-application-server-to-server.png
