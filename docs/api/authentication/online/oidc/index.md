---
title: oidc       
description: OpenID Connect 
author: {github-id}             # Your GitHub alias.
keywords:
---

# OpenID Connect

To understand how OpenID Connect (OIDC) works, we’ll review basic concepts such as participants, identity tokens, claims and scopes, and endpoints.

**Open ID Connect** is a thin layer that sits on top of the [OAuth 2.0][1] protocol. It extends OAuth so that online applications can get identity information and retrieve details about the authentication event.

* OIDC enables clients to verify the identity of a (human) user based on the authentication done by an authorization server
* **OIDC allows federated single sign-on to the application**, [with an exception][2]
* OIDC is required because OAuth provides authorization only, not authentication

![OpenID Connect][img1]

**OIDC terminology:**

| SuperOffice term | Role | OpenID Connect term |
|------------------|------|---------------------|
| Tenant end user | Resource owner | Resource owner |
| SuperOffice SuperID | Identity provider | OAuth 2.0 authorization server |
| Partner application | Relying party | OAuth 2.0 client |

## OpenID Connect terminology

### User

This is the tenant user for whom we are requesting identity information. Also known as the **OAuth resource owner**. One of the resources they own is their own identity.

### Client

This is your [application][3]. It relies on the identity provider to authenticate users and request claims about that user. Also known as the **relying party**.

### Identity provider (IdP)

This is the OAuth 2.0 **authorization server**:

* offers authentication as a service
* ensures the user is authenticated
* provides claims about the user and the authentication event to the relying party
* has multiple [endpoints][4]

### [Identity token][5]

[JSON web token (JWT)][6] that contains [claims][7] about the authentication event.

## OpenID Connect flows

Now let’s look at the authentication flows available in OpenID Connect, and how ID tokens and user information are exchanged.

OpenID Connect defines 3 authentication flows:

1. [Authorization Code flow][8]

2. [Implicit flow][9]

3. [Hybrid flow][10]

The **Authorization Code** and **Implicit** OpenID Connect flows are based on the OAuth flow with the same name. The main difference between the  OpenID Connect and OAuth counterparts is that an [ID token][5] is issued in the OIDC flows. If the implicit OAuth flow is best suited for your application, you can assume that the Implicit OIDC flow is also the best choice. Similarly for the authorization code flows.

![Implicit and authentication code flow][img2]

In this illustration, *application I* users the implicit flow while *application A* uses the authorization code flow.

The **Hybrid** flow is a combination of the authorization code and implicit flow. In this flow, the client can request ID tokens, [access tokens][11], or both from the [authorization endpoint][4], along with an authorization code.

* The code can be exchanged at the token endpoint for the remaining tokens. This is useful in situations such as single sign-on, where the partner application needs to immediately use an identity token to access the user’s identity.
* The code is used to request access and the [refresh token][12] to get long-lived access to resources.

The hybrid flow offers more flexibility with this token flow, but it’s **less secure than the authorization code flow** because some tokens are exposed directly to the user agent.

<!-- Referenced links -->
[1]: ../oauth-2-intro.md
[2]: iframe-idp-auth.md
[3]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/apps/overview.md
[4]: endpoints.md
[5]: ../id-token.md
[6]: ../jwt-intro.md
[7]: claims-scope.md
[8]: auth-code-flow.md
[9]: implicit-flow.md
[10]: hybrid-flow.md
[11]: ../access-token.md
[12]: ../refresh-token.md

<!-- Referenced images -->
[img1]: media/keyplayers.jpg
[img2]: media/token-flow-web-user.jpg
