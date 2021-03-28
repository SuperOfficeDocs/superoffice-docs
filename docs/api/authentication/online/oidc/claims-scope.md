---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: oidc_claims_scope       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Claims and scope (OIDC) # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: concept               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
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