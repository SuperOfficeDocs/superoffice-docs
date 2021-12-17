---
title: Authorization
uid: webapi_auth
description: Web API authentication
author: AnthonyYates
so.date: 12.17.2021
keywords: security, authentication, WebAPI, SOTICKET, BEARER
so.topic: concept
so.envir: onsite
so.client: Web
---

# SuperOffice REST / WebAPI web services

To successfully use the REST APIs (introduced in SuperOffice version 8), you must pass along credentials in each request header.

Below is an HTML page that contains a few text boxes for determining where, or what version of, the services reside, user name, and password. With this required information, the user can specify a project ID and click the **Get** button to execute an XMLHttpRequest.

![request-page -screenshot][img1]

## Options

You will need to provide some login information to use the SuperOffice WebAPI.

* BASIC authentication: Base64 Encode SuperOffice username:password
* SOTICKET authentication. Pass the SuperOffice ticket (7T:abc123==) without any encoding.
* BEARER authentication. Online only. Pass along an access token (7A:abc123==) from SuperID.
* NEGOTIATE / NTLM authentication. **Onsite only.** Initiates an Active Directory user authentication.

| Auth type | Example | Onsite | Online |
|---|---|:-:|:-:|
| No header | | x | x |
| Basic | YWrtMdo= | x | |
| SOTicket | 7T:xyz123abc== | x | x |
| Bearer | 8A:xyz123abc== | | x |
| Negotiate | | x | |

No `Authorize` header on a request means that you either:

* have [IIS configured to handle identity][1] so that you can log in with your Active Directory, or
* that you send [an X-XSRF-TOKEN header][2] to prove that you have access to a logged-in session

> [!NOTE]
> You must explicitly [enable the authentication methods][4] that you want to use in the *web.config* file.

### Basic

The `setRequestHeader` method is used to add the Authorization header key entry with a value equal to "Basic " plus a base64 encoded representation of the user name, plus a colon, and password. Note the space following the word *Basic*. In the JavaScript code, we use the built-in DOM `window.btoa(...)` method to convert the value to base64.

> [!NOTE]
> Basic is not allowed in **Online**, since all usernames and passwords must flow through SuperID to get a bearer access token.

### SOTicket

Alternatively, if the HTML page is running in the context of a SuperOffice web panel, and the application passes in the user's `SoCredential.Ticket`, the REST request header also supports SOTicket, instead of Basic. In that case, the Authentication header value is "SOTicket " plus the ticket string. Once again, notice the space following *SOTicket*.

[!code-html[HTML](includes/rest-auth.html)]

> [!NOTE]
> In this case, don't use the `window.btos(...)` method to convert a Ticket to base64 because the **ticket value is already base64 encoded**.

<!-- Referenced links -->
[1]: enable-iis-identity.md
[2]: reuse-session.md
[4]: ../../netserver/config/webapi.md

<!-- Referenced images -->
[img1]: media/simple-rest-page.png
