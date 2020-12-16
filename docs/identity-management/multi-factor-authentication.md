---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: multi_factor_authentication       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description:  Multi-factor authentication                  # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: MFA,2FA
so.topic: concept                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
so.client: online                    # online, web, win, pocket, or mobile
---

# Multi-factor authentication

**Multi-factor authentication (MFA) means that a user must prove their identity in 2 or more ways (factors) before they are successfully signed in.** This adds an extra layer of security.

## What is the difference between MFA and 2FA?

Two-factor authentication (2FA) is simply a subset of MFA. You combine exactly 2 factors to authenticate the user.

For example, when you enter a PIN to pay with your credit card at the store, you are using 2FA!

## Can I use MFA with SuperOffice CRM Online?

Multi-factor authentication is a feature offered by some [identity providers][1] (IDP).

If your 3rd-party provider supports it - you get it.

In the SuperOffice sphere, this means that yes - you can use MFA **if you register your IDP and your registered IDP supports MFA.**

If you use the [built-in standard password-based sign-in service][2], you can **not** get MFA!

But: if your organization has an identity provider that offers MFA and switching to federated sign-in is a viable option for you, simply follow this [guide to federated identity management][3].

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/technical/documentation/identity-management/overview/federated-id/
[2]: https://community.superoffice.com/en/technical/documentation/identity-management/overview/sign-in-services/
[3]: https://community.superoffice.com/en/technical/documentation/identity-management/how-to/federated-sign-in-guide/
