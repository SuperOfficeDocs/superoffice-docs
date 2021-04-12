---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: auth_user_legacy       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: How to authenticate an application user with SuperOffice legacy federated authentication # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# How to authenticate an application user with SuperOffice legacy federated authentication

Before introducing OAuth 2.0, our web services used SuperOffice legacy federated authentication. This is no longer the preferred method.

> [!CAUTION]
> We recommend that you use the [standard OAuth 2.0 user authentication][1].

**Pre-requisites:**

* You have received a unique [client ID and secret][2]
* You have whitelisted your [redirect URL][3] (GET or POST) with SuperOffice
* You have set up a web page at your redirect URL
* the application user has a valid username and password

1. Forward users to the SuperOffice online **sign-in page** to authenticate.

    `http://{env}.superoffice.com/login/?app_id=YOUR-APP-ID`

2. Receive the **authentication token** when the sign-in page redirects the user back to your application. The HTTP response contains a form in the body:

    ```csharp
    <form action="redirecturl" method="post">
       <input type="hidden" name="key" value="<value>" />
    </form>
    ```

    The hidden input type has **name** set to SAML or JWT. The value is set to the security token of the corresponding type.

3. [Validate the authentication token][4]. This is required *each time* a token is received to ensure that no attacks happened between sending the authentication request and receiving the authentication response.

<!-- Referenced links -->
[1]: auth-user.md
[2]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/apps/terminology.md
[3]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/apps/redirects/index.md
[4]: certificates/validate-security-tokens.md
