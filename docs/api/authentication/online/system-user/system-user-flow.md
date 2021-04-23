---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: system_user_flow       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: System user flow # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: concept              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
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
[3]: ../certificates/validate-security-tokens.md
[4]: ../id-token.md
[5]: ../oidc/claims-scope.md
[6]: system-user-token.md
[7]: ../superid-token.md
[8]: get-system-user-ticket.md

<!-- Referenced images -->
[img1]: media/system-user-flow.jpg
