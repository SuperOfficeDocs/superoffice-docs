---
title: Introduction to OAuth 2.0
uid: oauth_2_intro
description: Introduction to OAuth 2.0
author: {github-id}
keywords: authorization
so.topic: concept
so.envir: cloud
so.client: online               # online, web, win, pocket, or mobile
---

# Introduction to OAuth 2.0

OAuth is an open, industry-standard specification for token-based authorization. It allows 3rd-party applications to obtain limited access to an HTTP service.

## OAuth terminology

### User

The OAuth 2.0 spec refers to the user as a **resource owner**. Any application that wants to act on behalf of a user must first get permission from them to access their data and services.

### Client

This is your application acting on behalf of the user or accessing the user's data. Needs to [obtain permission][2] before accessing the user's account.

### Authorization server

This server has a dual role:

* Prompts the user to grant the client access to user-tenant resources
* grants access tokens to the client after authorization has been granted

### Access token

The OAuth access token is **proof of authorization**:

* shows that user A has approved client X
* restricts access to a specific duration and scope
* provides other information the server may need

### Authorization code

The OAuth authorization code is an **intermediate token** that is used in server-to-server communication. The client uses this code to obtain access tokens.

## Limitations in OAuth 2.0

With OAuth, the authenticated user proved they were present to the authorization server. However, the sole purpose of this was to create and grant an access token to the client application.

The user does not authenticate directly with an online application itself. OAuth is limited in that it provides a type of pseudo authentication:

* OAuth provides temporary access to resources rather than information about the authentication itself
* OAuth doesn't provide the when, where, and how the authentication actually occurred
* **OAuth doesn’t allow federated single sign-on**

<!-- Referenced links -->
[2]: ../../../../superoffice-docs/docs/apps/provisioning/get-consent.md
