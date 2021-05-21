---
title: SuperIdToken data type
uid: superid_token
description: SuperIdToken data type
author: {github-id}
keywords:
so.topic: reference
so.envir: cloud
so.client: online
---

# SuperIdToken data type

The `SuperIdToken` is a container for security claims. It is returned after validation of a JWT (or SAML) token and can be used for future authentication.

> [!CAUTION]
> This legacy class pertains to our [old form][1] of authentication. [Use OpenID Connect][2].

SuperIdToken contains:

* individual properties for common claims
* a complete list of [claims][3] returned by SuperOffice CRM Online

```csharp
public class SuperIdToken
{
    public Claim[] Claims { get; }
    public string IdentityProvider { get; }
    public string Ticket { get; }
    public string NetserverUrl { get; }
    public string SystemToken { get; }
    public string Email { get; }
    public string ContextIdentifier { get; }
}
```

**Ticket:** a SuperOffice ticket, representing the current user credential on this particular customer; not included in [OAuth flows][4]

**NetServer_URL:** the SOAP web service endpoint for the current customer site

**WebAPI_URL:** the RESTful endpoints for the current customer site (replaces `NetServer_URL` in class `SuperIdToken`)

**Email:** the current user’s email address

**ContextIdentifier (CTX):** context value (current customer ID).

**System User Token:** a string used to exchange for a system user ticket credential

The **SuperIdToken** data type is located in the `SuperOffice.SuperID.Client.Tokens` namespace in the SuperOffice.Online.Core assembly.

<!-- Referenced links -->
[1]: ../online/auth-user-legacy.md
[2]: ../online/auth-user.md
[3]: ../online/oidc/claims-reference.md
[4]: ../online/oauth-2-intro.md
