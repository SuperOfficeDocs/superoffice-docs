---
title: Claims and scope (OIDC)
uid: oidc_claims_scope
description: Claims and scope (OIDC)
author: {github-id}
keywords:
so.topic: concept
so.envir: cloud
so.client: online
---

# Claims and scope (OIDC)

OpenID Connect uses claims and scopes to define user information. **Claims** generally provide details about the user's identity. **Scope** is commonly used to define what resources a user has access to.

The OpenID Connect specification contains about 20 standard claims and 4 standard scopes. These are used to supply the client application with consented user details.

SuperOffice Online supports 1 scope only: **openid**. However, this [scope includes additional claims][1] normally obtained at the userInfo endpoint, such as first name, last name, and email address.

**Code example:**

![JWT Claims][img1]

<!-- Referenced links -->
[1]: claims-reference.md

<!-- Referenced images -->
[img1]: media/jwt.png