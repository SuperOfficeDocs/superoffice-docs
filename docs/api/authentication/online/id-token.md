---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: id_token       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: ID tokens          # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: authentication
so.topic: concept                  # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# ID tokens

Identity tokens are JWTs used in token-based authentication to cache user-profile information of an application user who has signed in.

So how does the OpenID Connect identity provider provide the relying party information about the identity of the end-user? The answer is through an identity token.

The **identity token** is similar to an ID card or a passport. It contains a number of required attributes or claims about that user, including how the user was authenticated:

* **Subject:** a unique identifier assigned to a user by the identity provider, for example, a username
* **Issuing authority:** the identity provider that issued the token
* **Audience:** identifies the relying party, or partner application, that can use the token
* **Issue date:** the date and time the token was issued
* **Expiration date:** the date and time the token will expire

There are also optional claims that help the relying party validate the ID token. For example:

* authentication time, which shows the time the user was authenticated
* Nonce values, which mitigate replay attacks

The ID token is encoded as a [JSON Web Token (JWT)][1]. It consists of 3 elements separated by a period:

`HEADER.PAYLOAD.SIGNATURE`

## How is the ID token used?

The ID token is primarily a means to access information about the currently signed in application user. It:

* is typically used for UI display
* can be used to personalize and enhance the user experience
* is time-limited and needs to be refreshed periodically

## Where does the ID token come from?

You will receive the ID token in the authorization response.

The contents should not be trusted until the token has been validated.

It is up to the application to securely store the ID token.

<!-- Referenced links -->
[1]: jwt-intro.md