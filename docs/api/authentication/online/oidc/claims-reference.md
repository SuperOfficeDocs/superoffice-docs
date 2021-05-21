---
title: SuperOffice OpenID Connect claims
uid: oidc_claims_reference
description: SuperOffice OpenID Connect claims
author: {github-id}
keywords:
so.topic: reference
so.envir: cloud
so.client: online
---

# SuperOffice OpenID Connect claims

SuperOffice offers a set of claims.

## Standard claims

OpenID Connect standard claims

| Claim name | Federated ID | OpenID Connect | Description |
|---|:-:|:-:|---|
| `aud` | X | X | The service principal name (SPN) claim identifier followed by the tenant database serial number. |
| `exp` | X| X | Expiration time on or after which the ID token **must not** be accepted for processing. |
| `c_hash` | | X | Code hash value. |
| `iat` | | X | Time at which the JWT was issued.<br>Its value is a JSON number representing the number of seconds from 1970-01-01T0:0:0Z as measured in UTC until the date/time. |
| `iss` | X | X | An identifier for the issuer of the response. Options:<br>SuperOffice AS (federated ID)<br>`https://sod.superoffice.com` (OpenID Connect) |
| `nbf` | X | X | The time before which the JWT **must not** be accepted for processing. |
| `nonce` | | X | A string used to associate a client session with an ID token and to mitigate replay attacks. |
| `sub` | X | X | Subject Identifier.<br>Always the same as the claim: `http://schemes.superoffice.net/identity/upn` |

## SuperOffice-specific claims

> [!NOTE]
> The claims in the following table are all prefixed with `http://schemes.superoffice.net/identity/`

SuperOffice-specific OICD claims

| Claim name | Federated ID | OpenID Connect | Description |
|---|:-:|:-:|---|
| `associateid` | X | X | The current user's associate ID. |
| `company_name` | X | X | The current user's company name. |
| `ctx` | X | X | The tenant identifier. |
| `email` | X | X | The current user's email address. |
| `firstname` | X | | The current user's first name. |
| `identityprovider` | X | X | The identity provider responsible for authentication. Options:<br>SuperOffice AS (federated ID)<br>`https://sod.superoffice.com` (OpenID Connect) |
| `initials` | X | X | The current user's full name initials. (added June 2019) |
| `is_administrator` | X | X | Determine whether the current user is an administrator. |
| `lastname` | X | | The current user's last name. |
| `netserver_url` | X | X | The URL to a tenant SOAP web service.<br>Often used in conjunction with SuperOffice [.NET NuGet proxies][1].<br>New applications should always use the latest. |
| `remember_me_expires` | X | X | Unused. |
| `serial` | X | X | The tenant database serial number. |
| `so_primary_email_address` | X | X | The current user's primary email address. (added June 2019) |
| `system_token` | X | X | A unique identifier used to exchange for a system ticket.<br>Used for background processing, back-channel communications. |
| `ticket` | X | | A current user's unique identifier, used for authentication. |
| `upn` | X | X | Specifies a user principal name (UPN). |
| `webapi_url` | X | X | The URL to a tenant REST web services. |

<!-- Referenced links -->
[1]: https://www.nuget.org/packages/SuperOffice.NetServer.Services
