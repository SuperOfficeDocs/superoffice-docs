---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: access_token       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Access tokens # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: authentication
so.topic: concept               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
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