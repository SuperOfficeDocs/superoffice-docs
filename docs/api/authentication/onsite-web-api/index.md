---
title: Authorization
uid: web_api_auth
description: Web API authentication
author: {github-id}
so.date: 
keywords: 
so.topic: concept 
---

## Authorization

You will need to provide some login information to use the SuperOffice WebAPI.

* BASIC authentication: Base64 Encode SuperOffice username:password
* SOTICKET authentication. Pass the SuperOffice ticket (7T:abc123==) without any encoding.
* BEARER authentication. Online only. Pass along an access token (7A:abc123==) from SuperID.
* NEGOTIATE / NTLM authentication. **Onsite only.** Initiates an Active Directory user authentication.

| Auth type | Example | Onsite | Online |
|---|---|:---:|:---:|
| No header | | x | x |
| Basic | YWrtMdo= | x | |
| SOTicket | 7T:xyz123abc== | x | x |
| Bearer | 8A:xyz123abc== | | x |
| Negotiate | | x | |

Basic is not allowed in **Online**, since all usernames and passwords must flow through SuperId to get a bearer access token.

No `Authorize` header on a request means that you either:

* have [IIS configured to handle identity][1] so that you can log in with your Active Directory, or
* that you send [an `X-XSRF-TOKEN` header][2] to prove that you have access to a logged-in session

## Configuration

You must explicitly enable the authentication methods that you want to use in the *web.config* file.

```XML
<WebApi>
  <add key="AuthorizeWithUsername" value="true" />
  <add key="AuthorizeWithTicket" value="true" />
  <add key="AuthorizeWithImplicit" value="true" />
  <add key="CORSEnable" value="true" />
  <add key="CORSOrigin" value="https://mail.google.com" />
</WebApi>
```

* **AuthorizeWithUsername** enables username + password (Basic) authentication. This method is not enabled in the Online environment.

* **AuthorizeWithTicket** enables SOTicket authentication.

* **AuthorizeWithImplicit** enables authentication with IIS identity. It means that your client has authenticated using Active Directory. This method is not enabled in the Online environment.

* **CORSEnable** turns on CORS headers, meaning that external sites must be listed in the CORSOrigin config to call the WebAPI. Default is on.

* **CORSOrigin** a list of space-separated URLs of sites that are allowed to call the WebAPI. If an external site tries to call, and it is not listed here, then the call will fail. You can use "*" to allow all sites to call.

<!-- Referenced links -->
[1]: integrated-with-ad.md
[2]: reuse-session.md
