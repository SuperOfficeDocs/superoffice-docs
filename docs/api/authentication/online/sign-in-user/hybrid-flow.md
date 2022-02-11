---
title: OICD Hybrid flow
uid: oicd_hybrid_flow
description: OICD Hybrid flow
author: {github-id}
keywords: authentication, OIDC, Hybrid flow
so.topic: concept
so.envir: cloud
so.client: online
---

# OICD Hybrid flow

The Hybrid flow is a combination of the Authorization Code and Implicit flows. Tokens can be returned by both authorization and token endpoints.

The response type specified in the redirect URI determines where the tokens are returned from:

* `code token`
* `code id_token`
* `code id_token token`

## Scenario: client application uses code id_token

1. The user agent redirects to the identity provider passing the **Response Type** equals  `code id_token` along with the `openid` scope it requires.

2. The end-user signs in and is asked for consent.

3. After consent is given, an authorization message is sent, which redirects the user agent back to the client application.
    * The redirection URI includes the Authorization Code and ID token.

4. The ID token is validated the same way as described in the [Implicit flow][1].

5. The Authorization Code is available to send to the token endpoint the same way as described in [Authorization Code flow][2].

6. The access token is validated and sent back, along with another ID token. This ID token can be compared to the previous one for validation.

<!-- Referenced links -->
[1]: implicit-flow.md
[2]: auth-code-flow.md
