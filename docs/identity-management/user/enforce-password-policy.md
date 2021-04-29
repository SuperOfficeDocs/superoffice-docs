---
title: Enforce a password policy
uid: enforce_password_policy
description: Enforce password policy
author: {github-id}
keywords:
so.topic: howto
so.envir: cloud
so.client: online
---

# Enforce a password policy

Password policy is currently handled by SuperID or your identity provider.

## Online

The password policy for SuperOffice CRM **Online** is enforced either by [SuperID][1] or - if you use federated identities - by your [identity provider][2].

**It is not possible to set customer-specific policies in the Admin client**, because CRM Online, unfortunately, has no way of telling the user what the current policy is, and we would like to avoid that users have to guess.

## Onsite

You can read more about [policies for **onsite** installations][3] in our forums.

<!-- Referenced links -->
[1]: ../superid/overview.md
[2]: ../federated-id-and-identity-providers.md
[3]: https://community.superoffice.com/en/search/#/faq/113578
