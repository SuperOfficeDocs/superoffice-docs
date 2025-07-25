---
uid: auth-user-legacy
title: How to authenticate an application - legacy
description: How to authenticate an application user with SuperOffice legacy federated authentication
keywords: authentication, authenticate app user, authentication token, SAML
author: Tony Yates, Margrethe Romnes
date: 03.22.2024
content_type: howto
category: api
deployment: online
platform: web
redirect_from: /en/authentication/online/sign-in-user/legacy
---

# How to authenticate an application user with SuperOffice legacy federated authentication

Before introducing OAuth 2.0, our web services used SuperOffice legacy federated authentication. This is no longer the preferred method.

> [!CAUTION]
> This form of authentication is deprecated. **SAML is legacy.** You must use [standard OAuth 2.0 user authentication][1].

**Pre-requisites:**

* You have received a unique [client ID and secret][2]
* You have whitelisted your [redirect URL][3] (GET or POST) with SuperOffice
* You have set up a web page at your redirect URL
* The application user has a valid username and password

**Steps:**

1. Forward users to the SuperOffice online **sign-in page** to authenticate.

    `http://{env}.superoffice.com/login/?app_id=YOUR-APP-ID`

2. Receive the **authentication token** when the sign-in page redirects the user back to your application. The HTTP response contains a form in the body:

    ```html
    <form action="redirecturl" method="post">
      <input type="hidden" name="key" value="<value>" />
    </form>
    ```

    The hidden input type has **name** set to SAML or JWT. The value is set to the security token of the corresponding type.

3. [Validate the authentication token][4]. This is required *each time* a token is received to ensure that no attacks happened between sending the authentication request and receiving the authentication response.

<!-- Referenced links -->
[1]: index.md
[2]: ../../../../developer-portal/getting-started/index.md#terminology
[3]: ../../../../developer-portal/create-app/config/redirects.md
[4]: ../validate-security-tokens.md
