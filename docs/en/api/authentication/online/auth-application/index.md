---
title: System user flow
uid: system_user_flow
description: SuperOffice system user flow for non-interactive server-to-server communications
author: {github-id}
keywords: authentication, system user, back-channel, non-interactive
so.topic: concept
so.envir: cloud
so.client: online
---

<!-- markdownlint-disable-file MD051 -->
# System user flow

The system user flow is how to obtain a Ticket credential to perform **non-interactive server-to-server** communications.

> [!NOTE]
> In the future, system user functionality will be replaced with OAuth 2.0 Client Credentials flow.

Watch the walk-through on YouTube:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube-nocookie.com/embed/Tyzm6H50DC8]

## Overview

There are two prerequisites before one can begin using the System User flow:

1. The application has the System User option enabled.

   It is enabled by selecting the **Server to server** option when creating an application in the [Developer Portal][1].

   ![create-application-server-to-server.png -screenshot][img3]

2. The application has been issued a **system user token**.

A **system user token** is only available after someone with administrator rights uses the application to signs in to their tenant using [OAuth 2.0/OpenID Connect][10]. When the individual gives consent to the application, by clicking the **I Approve** button after authentication, the system user token is generated and issued as a claim in the `id_token`.

The system user token is:

* formatted as: `Application Name-<random-number-of-characters>`
* is unique for each tenant and application combination
* will exist for the lifetime of the application
* is included in the `id_token` claim collection

A system user token remains the same and will not change for the lifetime of the application, unless the customer or application vendor revokes it.

### How to use the system user token to obtain a Ticket

The following procedure outline the steps necessary to use the system user **token** to obtain a **Ticket** credential.

1. Generate a [signed System User token][11] signature.
1. [Send the signed system user token][8] to the SuperOffice PartnerSystemUser endpoint.
1. In the response, [validate the JSON Web Token (JWT)][3].
1. Extract the Ticket claim from the JWT.

## How to use the system user ticket credentials

An application can use the system user ticket credential in:

* an Authorization header in HTTP requests
  * Instead of `Authorization Bearer <access_token>`, use
    `Authorization SOTicket <ticket>`
  * The **SO-AppToken** header *must* be included in the headers with the request.
    * The SO-AppToken value is the OAuth 2.0 client_secret.
* an **SoCredential** ticket property in SOAP API

### [REST](#tab/rest)

See the Authorization header:

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
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
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

***

With a valid credential set, the application can send authenticated requests to the customer tenant.

<!-- Referenced links -->
[1]: ../../../../developer-portal/create-app/server-to-server-app.md
[3]: ../validate-security-tokens.md
[8]: get-system-user-ticket.md
[10]: ../sign-in-user/index.md
[11]: sign-system-user-token.md
<!-- Referenced images -->
[img3]: media/create-application-server-to-server.png
