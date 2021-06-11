---
title: How to authenticate an application - legacy
uid: auth_user_legacy
description: How to authenticate an application user with SuperOffice legacy federated authentication
author: {github-id}
keywords:
so.topic: howto
so.envir: cloud
so.client: online
---

# How to authenticate an application user with SuperOffice legacy federated authentication

Before introducing OAuth 2.0, our web services used SuperOffice legacy federated authentication. This is no longer the preferred method.

> [!CAUTION]
> We recommend that you use the [standard OAuth 2.0 user authentication][1].

**Pre-requisites:**

* You have received a unique [client ID and secret][2]
* You have whitelisted your [redirect URL][3] (GET or POST) with SuperOffice
* You have set up a web page at your redirect URL
* The application user has a valid username and password

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
[1]: index.md
[2]: ../../../../../superoffice-docs/docs/apps/terminology.md
[3]: ../../../../../superoffice-docs/docs/apps/redirects/index.md
[4]: ../validate-security-tokens.md
