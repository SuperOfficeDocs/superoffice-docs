---
title: System user flow
uid: system_user_flow
description: System user flow
author: {github-id}
keywords:
so.topic: concept
so.envir: cloud
so.client: online
---

# System user flow

High-level intro to system user flow for non-interactive server-to-server communications.

![System user flow][img1]

1. A customer tenant administrator must [approve your application][1]. This is a one-time interactive login.

    * Behind the scenes, a system user token is generated and appended to an application authorization record in the Operation Center, and the application authorization record binds the application to the tenant.

2. The administrator is sent (via a POST) to your [redirect URL][2] with a JWT token.

    * Therefore, all applications must have a redirect URL.

3. [Validate the token][3].

    * The application residing at the redirect URL is expected to receive the JWT from the request body, validate the [id\_token][5], and then reliably access the identity [claims][5].
    * Extract the claims (including [system user token][5] from [SuperIdToken][7] and store this information in your application in a multi-tenant fashion.

    * It's up to the application to securely store the system user token

4. [Exchange system user token for system user ticket][8] before each interactive session with the tenant web services. The ticket is short-lived and will only last a few hours.

5. Let the application go about its business chatting with the SuperOffice web services using the ticket as credentials.

<!-- Referenced links -->
[1]: ../../../../../superoffice-docs/docs/apps/provisioning/consent.md
[2]: ../../../../../superoffice-docs/docs/apps/redirects/index.md
[3]: ../../tokens/validate-security-tokens.md
[4]: ../../tokens/id-token.md
[5]: ../oidc/claims-scope.md
[6]: system-user-token.md
[7]: ../../tokens/superid-token.md
[8]: get-system-user-ticket.md

<!-- Referenced images -->
[img1]: media/system-user-flow.jpg
