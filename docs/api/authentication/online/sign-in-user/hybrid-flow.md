---
title: OICD hybrid flow
uid: oicd_hybrid_flow
description: OICD hybrid flow
author: {github-id}
keywords:
so.topic: concept
so.envir: cloud
so.client: online
---

# OICD hybrid flow

The Hybrid flow is a combination of the authorization code and implicit flows. Tokens can be returned by both authorization and token endpoints.

The response type specified in the redirect URI determines where the tokens are returned from:

* `code token`
* `code id_token`
* `code id_token token`

## Scenario: client application uses code id_token

1. The user agent redirects to the identity provider passing the **Response Type** equals  `code id_token` along with the `openid` scope it requires.

2. The end-user signs in and is asked for consent.

3. After consent is given, an authorization message is sent, which redirects the user agent back to the client application.
    * The redirection URI includes the authorization code and ID token.

4. The ID token is validated the same way as described in the [implicit flow][1].

5. The authorization code is available to send to the token endpoint the same way as described in [authorization code flow][2].

6. The access token is validated and sent back, along with another ID token. This ID token can be compared to the previous one for validation.

<!-- Referenced links -->
[1]: implicit-flow.md
[2]: auth-code-flow.md
