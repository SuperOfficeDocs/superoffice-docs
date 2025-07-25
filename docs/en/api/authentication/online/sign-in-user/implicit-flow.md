---
title: OICD Implicit flow
uid: oidc_implicit_flow
description: "Introduction to the OICD Implicit flow."
author: SuperOffice Product and Engineering
keywords: authentication, OAuth 2.0, OIDC, Implicit flow
content_type: concept
category: api
deployment: online
platform: web
redirect_from: /en/authentication/online/sign-in-user/implicit-flow
---

# OICD Implicit flow

[!include[Deprecated OAuth flows](../includes/implicit-hybrid-deprecated.md)]

In the Implicit flow, the client application requests an ID token and possibly also an access token.

## Scenario: client application requests ID token only

1. The user clicks **Sign in**.

2. The client application redirects the user agent to the [authorization endpoint][1] of the identity provider.
    * **Response type** is set to `id_token`, indicating the Implicit flow and that we’re requesting an [ID token][3] only.
    * A nonce value is set to mitigate replay attacks.

    ```http
    GET Request (test in a browser to handle login/redirect)https://sod.superoffice.com/login/common/oauth/authorize?
    response_type=id_token&
    client_id=db1834037c58c02b6bd9898feef19845&
    redirect_uri=http://localhost/openid/index.html&
    scope=openid&
    state=12345&
    nonce=7362CAEA-9CA5-4B43-9BA3-34D7C303EBA7
    ```

    Parameters are described below.

3. The user enters their credentials.

4. An identity provider authenticates the user and asks for consent to access their resources on behalf of the Relying Party.

5. With consent given, the authentication server sends an authorization response message from its authorization endpoint. This redirects the user-agent back to the Relying Party using the redirection URI provided earlier. This URI includes an ID token in a URI fragment (host address and `id_token` separated by hash (#)). This ID token contains the standard claims, including some claims normally found in the profile and email scopes.

    ```http
    Response:http://localhost/openid/index.html#
    id_token=eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6IkZyZjdqRC1hc0dpRnFBREdUbVRKZkVxMTZZdyJ9.eyJzdWIiOiJ0b255LnlhdGVzQHN1cGVyb2ZmaWNlLmNvbSIsImh0dHA6Ly9zY2hlbWVz
    LnN1cGVyb2ZmaWNlLm5ldC9pZGVudGl0eS9hc3NvY2lhdGVpZCI6IjUiLCJodHRwOi8vc2NoZW1lcy5zdXBlcm9mZmljZS5uZXQvaWRlbnRpdHkvZmlyc3RuYW1lIjoiVG9ueSIsImh0dHA6Ly9zY2hlbWVzLnN1cGVyb2ZmaWNlLm5ldC9pZGVudGl0eS9sYXN0bmFtZI6IllhdGVzIiwiaHR0cDovL3NjaGVtZXMuc3VwZXJvZmZpY2UubmV0L2lkZW50aXR5L2lkZW50aXR5cHJvdmlkZXIiOiJzdXBlcm9mZmljZS1vbmxpbmUiLCJodHRwOi8vc2NoZW1lcy5zdXBlcm9mZmljZS5uZXQvaWRlbnRpdHkvZW1haWwiOiJ0b255LnlhdGVzQHNcGVyb2ZmaWNlLmNvbSIsImh0dHA6Ly9zY2hlbWVzLnN1cGVyb2ZmaWNlLm5ldC9pZGVudGl0eS91cG4iOiJ0b255LnlhdGVzQHN1cGVyb2ZmaWNlLmNvbSIsImh0dHA6Ly9zY2hlbWVzLnN1cGVyb2ZmaWNlLm5ldC9pZGVudGl0eS9jdHgiOiJDdXN0MTIwMjAiLCJodRwOi8vc2NoZW1lcy5zdXBlcm9mZmljZS5uZXQvaWRlbnRpdHkvaXNfYWRtaW5pc3RyYXRvciI6IlRydWUiLCJodHRwOi8vc2NoZW1lcy5zdXBlcm9mZmljZS5uZXQvaWRlbnRpdHkvc2VyaWFsIjoiMTUwMTE3ODU4NCIsImh0dHA6Ly9zY2hlbWVzLnN1cGVyb2ZmaWNLm5ldC9pZGVudGl0eS9yZW1lbWJlcl9tZV9leHBpcmVzIjoiIiwiaHR0cDovL3NjaGVtZXMuc3VwZXJvZmZpY2UubmV0L2lkZW50aXR5L25ldHNlcnZlcl91cmwiOiJodHRwczovL3NvZC5zdXBlcm9mZmljZS5jb20vQ3VzdDEyMDIwL1JlbW90ZS9TZXJ2aWNlczgyLIsImh0dHA6Ly9zY2hlbWVzLnN1cGVyb2ZmaWNlLm5ldC9pZGVudGl0eS93ZWJhcGlfdXJsIjoiaHR0cHM6Ly9zb2Quc3VwZXJvZmZpY2UuY29tL0N1c3QxMjAyMC9hcGkvIiwiaWF0IjoiMTUxNjE5Mjk0NSIsImF0X2hhc2giOiJIcEtPejlhaUpKN3d6XzVkRE04QU5Iiwibm9uY2UiOiI3MzYyQ0FFQS05Q0E1LTRCNDMtOUJBMy0zNEQ3QzMwM0VCQTciLCJpc3MiOiJodHRwczovL3NvZC5zdXBlcm9mZmljZS5jb20iLCJhdWQiOiJkYjE4MzQwMzdjNThjMDJiNmJkOTg5OGZlZWYxOTg0NSIsImV4cCI6MTUxNjE5MzI0NSwibmJmIjoxNE2MTkyODg1fQDGHBggHTJ2mhsPePeHA5KFP0DLIhadBa64ZGHo7xYYdyS3rTfaUvlaGNdpaS4A1m3lBX6wafvSI8ib9IyrSURLQ7wMLzgfW8W1n3P4tiHB0XfPQc9Nf1nNhA7fz93_jZgnrmOb1rCZDuuBd4E_fAPC_k1Rd9Z0iWBV_Sylx48qdK8D7_FE3buKdfo4ZeeBeRxsEIAHADsNIE4d_lirs-UvCJRBKkN3ZZg4CqnEdUutbZ73c_qCU3T-RhAQhK6sqeki0ywgK_8OS1TUsRQd4oz5aT_9DDcstYnVGHBZOSiwB-yKV9-zJ0SSqQSs1fe-PsEyaomSKMLieRWzoTDnnKQ
    ```

6. The user agent needs to parse the ID token encoded values that were returned in the URI fragment, and then pass them to the client’s processing logic.
    * The application will likely contain a script that extracts the ID token from the full redirect URI.

7. It’s then up to the client application to validate the ID token before accessing and trusting the claims it contains.

### Parameters

| Parameter | Required | Description |
|-----------|:--------:|-------------|
| `response_type` | yes | Value is `id_token token` or `id_token`. |
| `client_id` | yes | The client ID (application ID) assigned to your app when you registered with SuperOffice. |
| `redirect_uri` | yes | The [redirection endpoint][4] of your app, where authentication responses are sent and received.<br>It must exactly match one of the URLs registered with SuperOffice. |
| `nonce` | yes | String value used to associate a client session with an ID token, and to mitigate replay attacks.<br>Client must verify value. |
| [`scope`][3] | yes | Must be `openid`. |
| `state` | recommended | A value set by the Relying Party to maintain state between the request and the callback itself.<br>Included in the request and also returned in the token response. |

## Scenario: client application requests both ID token and access token

This scenario is almost the same as the [ID token][3] only scenario, except here we set **response type** to `token id_token`.

```http
GET Request (test in a browser to handle the login/redirect)https://sod.superoffice.com/login/common/oauth/authorize?
response_type=token id_token&
client_id=db1834037c58c02b6bd9898feef19845&
redirect_uri=http://localhost/openid/index.html&
scope=openid&
state=12345&
nonce=7362CAEA-9CA5-4B43-9BA3-34D7C303EBA7
```

After user authentication and consent is given, instead of just an ID token, the identity provider **also sends an [access token][1] in a URI fragment**.

```http
Response:http://localhost/openid/index.html#
access_token=8A%3aCust12020.AUiamiHxsOxM%2bdLC47fudkTQAQAAGbFJt8NXapaIa%2f354f2e2de2bxj8EkRCacoaJ%2fCBeUhiL1FFxw0XFZCl4AZDP3HWSSEIhDWQwxDzlDRzgecSGC4dEZXk8VsmsgqDVoG4cUQFQwxQWlx1FwfwbftxM%2f7ztl%2bIxEfU1UmqsGR5M9Zh8L65mN%2bY5w4T08YJB%2f2kYjVJPIA%2bVPLgLOKX3ck8KkmgCCmTCP%2fpMULOWWnAXxFrrwIAPGKnV6B9wda8DtDprIgtFksw%2fsoZLL%2bhbd2IcJQ1Y9T4xHMROyfFN0%2bV%2ftg1h3%2bYIkWaxRYRjfX0Ybu31qws1Jwo9CcaVeY7aEHzaW2QZieUeETy%2bACxLeScVBOqzbVIcCt0xRdoEfAySllQn2Ty0yam9bVIlv6B6VX9ugLLfG24hxSMWrU05vN3v%2bnbsPr5OnQXNNffYbkI8aeqooF1aGMZlaySo8WXLxWUfUWEgEzTBaWVgLlbIZhE9YeggttfMvdASEYHl808s6SiGUAH5DTPdjjIKXrWWMuXJSA1XkVV3EpS%2f5%2bdZhPq4ENVUmGzMifUDYpd6F74%2fcgrbE6%2fXjuv8K6j3pY9NcO1L6kdoK7StApzVJcYNtT6nu4364EQm2ievwxh1sQOKjcVUK%2bbpcqAIA73uT%2b4%2bfXBUcqJvsq%2fl2oMcKnWjpVf%2f9JmBA%3d%3d&
token_type=bearer&
state=12345
&expires_in=3600&
id_token=eyJ0eXAiO...1QiLCJ...iJSUzI1N...ng1dC...DnnKQ
```

### Parameters

| Parameter | Description |
|-----------|-------------|
| `access_token` | The access token issued by the Authorization Server. |
| `token_type` | Provides the client with the information required to successfully utilize the access token to make a protected resource request. |
| `state` | String value used to associate a client session with an ID token, and to mitigate replay attacks. |
| `expires_in` | The lifetime in seconds of the access token. |
| `id_token` | JWT, which consists of a Header, Payload, and Signature. The claims in the token form part of the payload. |

The client application can validate the ID token, and use the access token and token type to access the tenant's web services.

<!-- Referenced links -->
[1]: ../api.md
[3]: ../index.md
[4]: ../../../../developer-portal/create-app/config/redirects.md
