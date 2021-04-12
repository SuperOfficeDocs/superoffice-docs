---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: auth_user       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: How to authenticate an application user # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# How to authenticate an application user

Let's look at how you can authenticate an application user with OAuth 2.0.

This procedure uses an [Implicit Flow][1] request. The **client ID** is necessary to link the user to an application definition where the redirect URL is specified.

## Pre-requisites

* You have received a unique [client ID and secret][2]
* You have whitelisted your [redirect URL][3] with SuperOffice
* You have set up a web page at your redirect URL
* The application user has a valid username and password

> [!TIP]
> Remember that the sub-domain is different for [development, stage, and production][4]. It is very likely that the client ID differs too.

## To authenticate users

1. Forward the user to the SuperOffice CRM Online **sign-in page** to authenticate.

    ```javascript
    https://{env}.superoffice.com/login/common/oauth/authorize?response_type=id_token token
    &client_id=YOUR-APP-ID&redirect_uri=YOUR-REDIRECT-URL&scope=openid&state=12345
    &nonce=7362CAEA-9CA5-4B43-9BA3-34D7C303EBA7
    ```

2. Receive the **authentication token** when the sign-in page redirects the user back to your application.

3. [Validate the authentication token][5].

> [!WARNING]
> **No application is allowed to ask users for their credentials, ever!

**Next step:** implement your application-specific logic.

<!-- Referenced links -->
[1]: oidc/implicit-flow.md
[2]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/apps/terminology.md
[3]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/apps/redirects/index.md
[4]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/apps/getting-started/app-envir.md
[5]: certificates/validate-security-tokens.md
