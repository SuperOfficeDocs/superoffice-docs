---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: jwt_intro       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Introduction to JWT # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: concept                      # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Introduction to JWT

Completely new to token-based access control? We've got you covered!

## What is JWT anyway?

JWT is short for JSON Web Token:

> A string representing a set of claims as a JSON object that is encoded in a JWS or JWE, enabling the claims to be digitally signed or MACed and/or encrypted. ([RFC7519][1]

A JWT has 3 parts: header, payload, signature.

![ID Token][img1]

### JWT header

The header will show that the token type is JWT and which algorithm that has been used to **sign** it.

```javascript
{
"typ":"JWT",
"alg":"HS256"
}
```

### JWT payload

The payload is the actual data of the JWT. It consists of a list of claims - each claim is a **name-value pair**.

A [claim can be either standard OpenID Connect or custom][2] (with its own namespace).

```javascript
{
  "sub": "tony@superoffice.com",
  "http://schemes.superoffice.net/identity/associateid": "5",
  "http://schemes.superoffice.net/identity/identityprovider": "central-superid",
  "http://schemes.superoffice.net/identity/email": "tony@superoffice.com",
  "http://schemes.superoffice.net/identity/upn": "tony@superoffice.com",
  "http://schemes.superoffice.net/identity/is_administrator": "False",
  "http://schemes.superoffice.net/identity/ctx": "Cust26759",
  "http://schemes.superoffice.net/identity/company_name": "Tonys Developer Network",
  "http://schemes.superoffice.net/identity/serial": "1801550193",
  "http://schemes.superoffice.net/identity/netserver_url": "https://sod.superoffice.com/Cust26759/Remote/Services86/",
  "http://schemes.superoffice.net/identity/webapi_url": "https://sod.superoffice.com/Cust26759/api/",
  "http://schemes.superoffice.net/identity/system_token": "SuperOffice DevNet Node OIDC-8k8Q7DmBgo",
  "iat": "1581665207",
  "http://schemes.superoffice.net/identity/initials": "TY",
  "http://schemes.superoffice.net/identity/so_primary_email_address": "tony@superoffice.com",
  "nonce": "637172620046685267.NmU2ZmRjNTctYjU0ZS00ZDRlLThkNjgtOTBlZmY2N2QyYjc3MzYzZWE1YjctYTUxYS00NDM1LWE1YTEtNDEzYTMxNTgxMzA0",
  "nbf": 1581665147,
  "exp": 1581665507,
  "iss": "https://sod.superoffice.com",
  "aud": "6cf25376616343b38d14ddcd804f2891"
}
```

### JWT signature

**Signatures** verify that the information was sent from the sender and that the information **has not been altered**.

## What does it mean to validate tokens?

1. Is the JWT well-formed (has 3 period-separated sections)?
2. Parse the string and extract and B64 decode the components - are they valid JSON?
3. Is the signature OK?
4. Are the standard claims OK? Check there is a required **sub** claim and other OICD claims.
5. Check the namespace-specific claims.

If any of these tests fail, the JWT should be rejected and not trusted.

## Why should I validate tokens?

Token validation establishes **trust** for the authentication mechanism:

* The token was issued by SuperOffice
* The token was issued to this user
* That user has granted the application access to the listed operation

## Are all tokens used in SuperOffice CRM Online JWTs?

No. Only the [ID token][3] follows the JWT pattern.

Read more: [access tokens][4], [refresh tokens][5], [system user tokens][6], [bearer tokens and SOTickets][7]

<!-- Referenced links -->
[1]: https://tools.ietf.org/html/rfc7519
[2]: ../online/oidc/claims-reference.md
[3]: id-token.md
[4]: access-token.md
[5]: refresh-token.md
[6]: ../online/system-user/system-user-token.md
[7]:../online/auth-header-types.md

<!-- Referenced images -->
[img1]: ../media/id-token.png