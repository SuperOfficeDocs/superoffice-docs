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

# System user flow

The system user flow is used to authenticate applications in **non-interactive server-to-server** communications.

![System user flow][img1]

## Overview

A **system user token** is a String formatted as `NAME_OF_APP-<some_random_characters>` and represents a contract between an application and a [tenant][6]

It is generated when an administrator signs in to SuperID with the application and is returned in the `id_token` JWT.

The system user token is:

* is unique for each combination of tenant and application
* will exist for the lifetime of the application
* is included in the `id_token` JWT claim collection

A system user token remains the same and will not change for the lifetime of the application, unless the application vendor requests it be revoked.

### How is the system user token used?

The system user token is primarily a means to perform **non-interactive operations** on the APIs. It is:

* used to [obtain a valid system user ticket][8] credential from SuperID
* used by the application for all background processing

The system user **token** is **not** used for direct access to any customer tenant web services. For that, you need the system user **ticket**. Therefore, you must use the token to obtain a valid ticket credential.

In the future, system user functionality will be replaced with OAuth 2.0 Client Credentials flow, which will not have the sliding expiration behavior.

![Non-interactive token flow][img2]

### Where does the system user token come from?

1. A customer tenant administrator must [approve your application][1]. This is a one-time interactive login.

    * Behind the scenes, a system user token is generated and appended to an application authorization record in the Operation Center, and the application authorization record binds the application to the tenant.

2. The successful interactive login is then redirected via a POST request to the application [redirect URL][2]. The POST request body contains, in addition to other things, the `id_token` JWT.

    * Therefore, all applications must have a redirect URL.
    * Smaller organizations or consultants without the facilities to host a website can use our helper [DevNet-Tokens](https://devnet-tokens.azurewebsites.net) website to help perform the administrative login and displays the system user token.

3. [Validate the token][3].

    * The redirect URL destination is expected to receive the JWT from the request body, validate the [id_token][4], and then reliably access the identity [claims][5].
    * Extract the claims including **system user token** from [SuperIdToken][3] and store this information in your application in a multi-tenant fashion.
      * The system user claim key is: http://schemes.superoffice.net/identity/system_token
    * It's up to the application to securely store the system user token for future use.

4. [Exchange system user token for system user ticket][8] for each request session with the tenant web services. The ticket is short-lived and will only last 6 hours. Do use caching. Do not unnecessarily obtain a new system user ticket more than one an hour.

5. Send requests to SuperOffice web services using the ticket as credentials.

The system user token is only generated and included in the `id_token` if system user token functionality is requested during application registration.

![imagecxe1.png][img3]

## System user ticket

The system user ticket is used for access to the customer tenant. It is used as an **authentication token** when the application submits web service requests to the tenant APIs.

## How is the system user ticket used?

An application can use the ticket string to set the credential:

* as an **SOTicket** header in the REST API, which must also include the SO-AppToken header, or
* as an **SoCredential** ticket property in SOAP API

# [REST](#tab/rest)

See the Authorization header:

```http
GET https://sod.superoffice.com/Cust12345/api/v1/User/currentPrincipal HTTP/1.1
Authorization: SOTicket {{ticket}}
SO-AppToken: {{client_secret}}
Accept: application/json
```

# [SOAP](#tab/soap)

See the `<NS:Credentials>` element:

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

With a valid credential set, the application can connect to and process data with the customer tenant.


<!-- Referenced links -->
[1]: ../../../../../superoffice-docs/docs/apps/provisioning/consent.md
[2]: ../../../../../superoffice-docs/docs/apps/redirects/index.md
[3]: ../validate-security-tokens.md
[4]: ../api.md
[5]: ../index.md
[6]: ../../../../../superoffice-docs/docs/apps/tenant-status/index.md
[8]: get-system-user-ticket.md

<!-- Referenced images -->
[img1]: media/system-user-flow.jpg
[img2]: media/non-interactive-token-flow.jpg
[img3]: media/imagecxe1.png
