---
title: Authorization
uid: webapi_auth
description: "Authentication options for the SuperOffice WebAPI."
author: AnthonyYates
date: 12.17.2021
keywords: security, authentication, WebAPI, SOTICKET, BEARER
content_type: concept
deployment: onsite
platform: web
redirect_from: /en/api/netserver/web-services/webapi/index
---

# SuperOffice WebApi

NetServer web services proide both SOAP and RESTful endpoints. SuperOffice.WebApi represents the RESTful side and comes in two **flavors**:

* RESTful endpoints
* HTTP RPC Agent endpoints

Each request needs credentials to verify your identity.

## Authorization header options

You must provide one of the following types of credential.

* BASIC authentication: Base64 Encode SuperOffice username:password
* SOTICKET authentication. Pass the SuperOffice ticket (7T:abc123==) without any encoding.
* BEARER authentication. Pass along an access token (7A:abc123==) from SuperID.
* NEGOTIATE / NTLM authentication. Initiates an Active Directory user authentication.

| Auth type | Example | Onsite | Online |
|-----------|---------|:------:|:------:|
| No header |         | x      | x      |
| Basic     | YWrtMdo=| x      |        |
| SOTicket  | 7T:xyz123abc== | x | x    |
| Bearer    | 8A:xyz123abc== |   | x    |
| Negotiate |                | x |      |

No `Authorize` header on a request means that you either:

* have [IIS configured to handle identity][1] so that you can log in with your Active Directory, or
* that you send an **X-XSRF-TOKEN** header to prove that you have access to a logged-in session

> [!NOTE]
> You must explicitly [enable the authentication methods][4] that you want to use in the *web.config* file.

### Basic

This Authorization header is a key entry of "Basic ", and a value equal to a base64 encoded representation of the user name, plus a colon, and password. Note the space following the word *Basic*. In the JavaScript code, we use the built-in DOM `window.btoa(...)` method to convert the value to base64.

> [!NOTE]
> Basic is not allowed in **Online**, since all usernames and passwords must flow through SuperID to get a bearer access token.

### Bearer

### SOTicket

Alternatively, if the HTML page is running in the context of a SuperOffice web panel, and the application passes in the user's `SoCredential.Ticket`, the REST request header also supports SOTicket, instead of Basic. In that case, the Authentication header value is "SOTicket " plus the ticket string. Once again, notice the space following *SOTicket*.

When used in online, the SO-AppToken must accompany the SoTicket and set to the application secret (client_secret) in the SO-AppToken header.

```http
Authorization: SoTicket 7A:adasd098098sdfs0df8KJHSKh230...123dsa==
SO-AppToken: qw123f4c56770bc278017796cd16bd11
```

> [!NOTE]
> In this case, don't use the `window.btos(...)` method to convert a Ticket to base64 because the **ticket value is already base64 encoded**.

### X-XSRF-TOKEN

With [requests][1] without an **Authorization** header, the API will try to log in using the current user's SuperOffice session. To avoid 3rd-party pages calling the API and piggy-backing off the current session, the API requires that a special HTTP header is added to these requests.

The SuperOffice pages contain an INPUT field `XSRF_TOKEN`. This field contains a random value identifying the current session. You must add an X-XSRF-TOKEN header with the random value from the input field.

The XSRF-TOKEN is also stored in a cookie for convenience. HTTP libraries like AXIOS will automatically pick up the XSRF-TOKEN cookie from the browser and add the X-XSRF-TOKEN header to your HTTP requests.

```http
GET /api/v1/Contact/2
Accept: application/json
```

will return HTTP error 401 Unauthorized.

```http
GET /api/v1/Contact/2
Accept: application/json
X-XSRF-TOKEN: abc1234
```

will work, and use the current user's session to read the data.

> [!NOTE]
> The user must be logged in. After the user logs out, the XSRF-TOKEN is not valid, and there is no existing session for you to re-use.

<!-- Referenced links -->
[1]: ../../../onsite/install/netserver/setup-rest.md#integrated-with-active-directory
[4]: ../../config/webapi.md

<!-- Referenced images -->
