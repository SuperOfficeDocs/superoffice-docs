---
title: Online authentication
uid: webapi_auth_online
description: WebAPI authentication CRM Online; introduction to OAuth 2.0 and OpenID Connect
author: {github-id}
so.date: 
keywords: authentication, OIDC, OAuth, claim, terminology, ID token
so.topic: concept
so.envir: cloud
so.client: online
---

# SuperOffice Online and SuperID

For front-channel API access, when users are present and interactive, SuperOffice Online supports OAuth 2.0 and OpenID Connect identity protocols.

For back-channel communications SuperOffice provides the proprietary [System User flow][2].

## Prerequisites

Access to tenant web services requires a registered application. If your not already registered as an app developer with us, please [submit this developer registration form][3] to create your developer account.

If you already have a developer account, and just want to create a new application, [use the Developer Portal][1] to register your new application. Read the [Developer Portal docs][12] to become more familiar with how to create and manage your application.

Once registered, you will receive 2 application identifiers:

* Application ID - this is the OAuth client_id: `4e5e6f90f529fede129bd25ad`
* Application token - this is the OAuth client_secret, do not share this. `74252df1e0119f1913f64c6d8d`

## <a name="oauth"></a>Introduction to OAuth 2.0

OAuth is an open, industry-standard specification for token-based authorization. It allows 3rd-party applications to obtain limited access to an HTTP service.

### User

The OAuth 2.0 spec refers to the user as a **Resource Owner**. Any application that wants to act on behalf of a user must first get permission from them to access their data and services.

### Client

This is your application acting on behalf of the user or accessing the user's data. Needs to [obtain permission][5] before accessing the user's account.

### Authorization Server

This server has a dual role:

* Prompts the user to grant the client access to user-tenant resources
* grants access tokens to the client after authorization has been granted

SuperOffice has two, `superid` and `central-superid`. Each interacts with the roles above, respectively.

### Access token

The OAuth access token is **proof of authorization**:

* shows that user A has approved client X
* restricts access to a specific duration and scope
* provides other information the server may need

### Authorization Code

The OAuth Authorization Code is an **intermediate token** issued to the Client during [Authorization Code flow][9]. The client uses this code to obtain an access token.

## Limitations in OAuth 2.0

With an OAuth access_token, the user proved they were presented to the Authorization Server. However, the sole purpose of this was to create and grant an access token to the client application.

The user does not authenticate directly with an online application itself. OAuth is limited in that it provides a type of pseudo authentication:

* OAuth provides temporary access to resources rather than information about the authentication itself.
* OAuth doesn't provide the when, where, and how the authentication occurred.
* **OAuth doesn’t allow federated single sign-on.**

## <a name="oidc"></a>OpenID Connect

To understand how OpenID Connect (OIDC) works, we’ll review basic concepts such as participants, ID tokens, claims and scopes, and endpoints.

**Open ID Connect** is a thin layer that sits on top of the OAuth 2.0 protocol. It extends OAuth so that online applications can get identity information and retrieve details about the authentication event.

* OIDC enables clients to verify the identity of a (human) user based on the authentication done by an Authorization Server
* **OIDC allows federated single sign-on to the application**, [with one possible exception][6]
* OIDC is required because OAuth provides authorization only, not authentication

![OpenID Connect][img3]

| SuperOffice term | Role | OpenID Connect term |
|------------------|------|---------------------|
| Tenant end-user | Resource Owner | Resource Owner |
| SuperOffice SuperID | Identity provider | OAuth 2.0 Authorization Server |
| Partner application | Relying Party | OAuth 2.0 client |

### User

This is the tenant user for whom we are requesting identity information. Also known as the **OAuth Resource Owner**. One of the resources they own is their own identity.

### Client

This is your application. It relies on the identity provider to authenticate users and request claims about that user. Also known as the **Relying Party**.

### Identity provider (IdP)

This is the OAuth 2.0 **Authorization Server**:

* offers authentication as a service
* ensures the user is authenticated
* provides claims about the user and the authentication event to the Relying Party
* has multiple [endpoints][7]

### ID token

So how does the OpenID Connect identity provider give the Relying Party information about the identity of the end-user? The answer is through an ID token.

ID tokens are encoded [JSON web tokens (JWTs)][8] used in token-based authentication to cache user-profile information for the signed in user. Each JWT consists of 3 elements separated by a period: `HEADER.PAYLOAD.SIGNATURE`

The **ID token** is similar to an ID card or a passport. It contains multiple claims about the user, including which identity provider authenticated the user. The following claims are required:

* **Subject:** a unique identifier assigned to a user by the identity provider, for example, a username
* **Issuing authority:** the identity provider that issued the token
* **Audience:** identifies the Relying Party or partner application, that can use the token
* **Issue date:** the date and time the token was issued
* **Expiration date:** the date and time the token will expire

There are also optional claims that help the Relying Party validate the ID token. For example:

* Authentication time, which shows the time the user was authenticated
* Nonce values, which mitigate replay attacks

#### How is the ID token used?

The ID token is primarily a means to access information about the currently signed-in application user. It:

* is typically used for UI display
* can be used to personalize and enhance the user experience
* is time-limited and needs to be verified upon receipt

#### Where does the ID token come from?

You will receive the ID token in the final response of the [Authorization Code flow][9].

The contents should not be trusted until the [token has been validated][8].

It is up to the application to securely store the ID token.

### Claims and scope

OpenID Connect uses claims and scopes to define user information. **Claims** generally provide details about the user's identity. **Scope** is commonly used to define what resources a user has access to.

The OpenID Connect specification contains about 20 standard claims and 4 standard scopes. These are used to supply the client application with consented user details.

**OpenID Connect standard ID token claims:**

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

SuperOffice Online supports 1 scope only: **openid**. The access granted by this one scope include access to all APIs, and all [claims][7] normally obtained at the userInfo endpoint - which isn't supported. Profile claims are in the ID token, and listed in the [JWT validation][8] documentation.

### OpenID Connect flows

Now let’s look at the authentication flows available in OpenID Connect, and how ID tokens and user information are exchanged.

OpenID Connect defines 3 authentication flows:

1. [Authorization Code flow][9]

2. [Implicit flow][10]

3. [Hybrid flow][11]

The **Authorization Code** and **Implicit** OpenID Connect flows are based on the OAuth flow with the same name. The main difference between the OpenID Connect and OAuth counterparts is the [ID token][5]. If the implicit OAuth flow is best suited for your application, you can assume that the Implicit OIDC flow is also the best choice. Similarly for the Authorization Code flows.

![Implicit and Authentication Code flow][img4]

In this illustration, *application I* users the Implicit flow while *application A* uses the Authorization Code flow.

The **Hybrid** flow is a combination of the Authorization Code and Implicit flow. In this flow, the client can request ID tokens, [access tokens][7], or both from the [authorization endpoint][4], along with an Authorization Code.

* The code can be exchanged at the token endpoint for the remaining tokens. This is useful in situations such as single sign-on, where the partner application needs to immediately use an ID token to access the user’s identity.
* The code is used to request access and the [refresh token][7] to get long-lived access to resources.

The Hybrid flow offers more flexibility with this token flow, but it’s **less secure than the Authorization Code flow** because some tokens are exposed directly to the user agent.

[!include[Deprecated OAuth flows](includes/implicit-hybrid-deprecated.md)]

<!-- Referenced links -->
[1]: https://dev.superoffice.com
[2]: ./auth-application/index.md
[3]: ../../../apps/getting-started/developer-registration-form.md
[4]: https://jwt.io/
[5]: ../../../apps/provisioning/get-consent.md
[6]: troubleshooting/iframe-idp-auth.md
[7]: api.md
[8]: validate-security-tokens.md
[9]: sign-in-user/auth-code-flow.md
[10]: sign-in-user/implicit-flow.md
[11]: sign-in-user/hybrid-flow.md
[12]: ../../../developer-portal/index.yml

<!-- Referenced images -->
[img3]: media/keyplayers.jpg
[img4]: media/token-flow-web-user.jpg
