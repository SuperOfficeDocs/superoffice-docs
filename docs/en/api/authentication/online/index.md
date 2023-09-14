---
title: SuperOffice Online authentication
uid: webapi_auth_online
description: WebAPI authentication CRM Online; introduction to OAuth 2.0 and OpenID Connect
author: AnthonyYates
so.date: 03.21.2023
keywords: authentication, OIDC, OAuth, claim, terminology, ID token
so.topic: concept
so.envir: cloud
so.client: online
---

# SuperOffice Online OAuth 2.0 and OpenID Connect

SuperOffice Online offers OAuth 2.0 and OpenID Connect identity protocols for front-channel API access, where users are interactive and present. For back-channel communications, it employs the proprietary [System User flow][2].

## Prerequisites

To access tenant web services, a registered application is necessary. If you haven't registered as an app developer yet, [submit this developer registration form][3] to create your developer account. For those with a developer account wanting to create a new application, [use the Developer Portal][1] and read the [Developer Portal docs][12] for guidance.

Upon registered, you will receive 2 application identifiers:

* Application ID - this is the OAuth client_id: `4e5e6f90f529fede129bd25ad`
* Application token - this is the OAuth client_secret, do not share this. `74252df1e0119f1913f64c6d8d`

## OAuth 2.0 vs OpenID Connect

OAuth 2.0 and OpenID Connect are related but serve different purposes. OAuth 2.0 is an authorization framework, while OpenID Connect is an authentication protocol built on top of OAuth 2.0.

## <a name="oauth"></a>OAuth 2.0 overview

**Purpose**: OAuth 2.0 is designed for authorization, allowing users to [grant third-party applications access][5] to their resources on another service without sharing their credentials.

### Key components

* Resource Owner (User): The user who grants access to their resources.

* Resource Server: The server hosting the resources.

* Client: Your application acts on behalf of the user or accesses their data after obtaining permission. The client is also known as the Relying Party (RP).

* Authorization Server: The server that issues `access tokens` to the client after authenticating the resource owner. Responsible for prompting to [grant access][5] to the client.

SuperOffice uses two authorization servers, `superid` and `central-superid`.

### Main features

* Delegated access to resources through access tokens.

* Multiple grant types to support various use cases (for example, implicit, hybrid and authorization code). SuperOffice **does not support** `client credentials`, and `resource owner password` credentials.

* Token-based communication between components for security.

* Revocable and time-limited access tokens.

## <a name="oidc"></a>OpenID Connect

**Purpose**: [OpenID Connect][7] extends OAuth 2.0 to provide authentication, allowing users to securely authenticate with a single identity provider (IdP) and use their identity to access various applications and services.

### Key components

* Identity Provider (IdP): A service that securely stores and manages user identities and authentication (e.g., Google, Facebook, Microsoft).

* Relying Party (RP) or Client: An application or service that relies on the IdP for user authentication.

* End-User: The person who wants to access the RP using their identity from the IdP.

### Main Features

* Authentication built on top of OAuth 2.0.

* Uses ID Tokens (JSON Web Tokens) to communicate user authentication information between the IdP and the RP.

* Standardized user profile data using UserInfo endpoint. SuperOffice does not support the standardized OIDC endpoint, instead clients must use the `https://{env}.superoffice.com/{tenantId}/api/v1/User/currentPrincipal` endpoint.

* Supports single sign-on (SSO) and single logout (SLO) across multiple applications and services. SuperOffice allows federated single sign-on to the application, [with one possible exception - in a web panels (iframe)][6]

![OpenID Connect][img3]

### Access Tokens and Authorization Codes

Access tokens demonstrate proof of authorization, showing that a user has approved client access, restricting it to a specific duration and scope. Authorization codes are intermediate tokens issued during the Authorization Code flow, used by the client to obtain an access token.

### ID tokens

ID tokens are encoded [JSON web tokens (JWTs)][8] containing user-profile information. They consist of three elements: `HEADER.PAYLOAD.SIGNATURE`. These tokens include required claims like subject, issuing authority, audience, issue date, and expiration date, as well as optional claims for validation purposes.

ID tokens are used to [access information][4] about the signed-in user, personalizing and enhancing their experience. They are time-limited and must be validated upon receipt.

### Claims and scopes

OpenID Connect uses claims and scopes to define user information. **Claims** provide identity details, while **scopes** define resource access. SuperOffice Online supports one scope, 'openid,' which grants access to all APIs and claims.

### OIDC flows

OIDC defines 3 authentication flows:

1. [Authorization Code flow][9]: The recommended flow for interactive applications, where the client receives an authorization code to obtain access and refresh tokens.

2. [Hybrid flow][11]: Combines the Authorization Code and Implicit flows, offering flexibility but less security.

3. [Implicit flow][10]: A less secure flow where the client receives an ID token and access token directly.

[!include[Deprecated OAuth flows](includes/implicit-hybrid-deprecated.md)]

## Integrating SuperOffice Online and SuperID

With a solid understanding of OAuth 2.0 and OpenID Connect, you can now effectively integrate SuperOffice Online and SuperID into your application. By using the recommended Authorization Code flow, you can ensure that your application is secure and compliant with industry standards.

To successfully implement SuperOffice Online and SuperID, follow these steps:

1. [Register your application][3] and obtain the necessary credentials (Application ID and Application token).

2. Set up your application to use the appropriate OAuth 2.0 and OIDC components and flows.

3. Ensure your application securely stores ID tokens and [validates][8] them upon receipt.

4. Utilize claims and scopes to access user information and enhance the user experience in your application.

By following these guidelines, you can create a seamless, secure, and user-friendly experience for your application users while adhering to industry standards and best practices.

<!-- Referenced links -->
[1]: https://dev.superoffice.com
[2]: ./auth-application/index.md
[3]: ../../../developer-portal/create-app/index.md
[4]: https://jwt.io/
[5]: ../../../developer-portal/provisioning/get-consent.md
[6]: troubleshooting/iframe-idp-auth.md
[7]: api.md
[8]: validate-security-tokens.md
[9]: sign-in-user/auth-code-flow.md
[10]: sign-in-user/implicit-flow.md
[11]: sign-in-user/hybrid-flow.md
[12]: ../../../developer-portal/index.yml

<!-- Referenced images -->
[img3]: media/keyplayers.jpg
