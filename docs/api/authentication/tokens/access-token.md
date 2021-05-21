---
title: Access tokens
uid: access_token
description: Access tokens
author: {github-id}
keywords: authentication
so.topic: concept
so.envir: cloud
so.client: online
---

# Access tokens

**Access tokens** are used in token-based authentication to allow an application to access an API.

The SuperOffice access token is **proprietary** and not a standard JWT. It can't be inspected with tools such as [jwt.io][1].

## How is the access token used?

The access token is primarily a means to call a target API. It is:

* used as a **credential** when calling the API
* time-limited and needs to be refreshed periodically

## Where does the access token come from?

You will receive the access token in the authorization response.

It is up to the application to securely store the access token.

## When do I need to get a new access token?

* when the application user signs in for the 1st time
* when the previous token expires

<!-- Referenced links -->
[1]: https://jwt.io/
