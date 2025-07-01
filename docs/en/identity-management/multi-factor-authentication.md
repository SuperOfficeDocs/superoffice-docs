---
title: MFA
uid: multi_factor_authentication
description:  Multi-factor authentication
author: SuperOffice Product and Engineering
date:
keywords: MFA,2FA
content_type: concept
platform: web
index: true
---

# Multi-factor authentication

**Multi-factor authentication (MFA) means that a user must prove their identity in 2 or more ways (factors) before they are successfully signed in.** This adds an extra layer of security.

## What is the difference between MFA and 2FA?

Two-factor authentication (2FA) is simply a subset of MFA. You combine exactly 2 factors to authenticate the user.

For example, when you enter a PIN to pay with your credit card at the store, you are using 2FA!

## Can I use MFA with SuperOffice CRM Online?

Multi-factor authentication is a feature offered by some [identity providers][1] (IDP).

> [!TIP]
> If your 3rd-party provider supports it - you get it.

In the SuperOffice sphere, this means that yes - you can use MFA **if you register your IDP and your registered IDP supports MFA.**

If you use the [built-in standard password-based sign-in service][2], you can **not** get MFA!

But: if your organization has an identity provider that offers MFA and switching to federated sign-in is a viable option for you, simply follow this [guide to federated identity management][3].

<!-- Referenced links -->
[1]: federated-id-and-identity-providers.md
[2]: superid/sign-in-services.md
[3]: superid/howto/federated-sign-in-guide.md
