---
uid: enforce-password-policy
title: Enforce a password policy
description: Enforce password policy
keywords: SuperID, password, password policy
author: Bergfrid Dias
date: 03.21.2024
content_type: howto
deployment: online
platform: web
index: true
---

# Enforce a password policy

Password policy is currently handled by SuperID or your identity provider.

## Online

The password policy for SuperOffice CRM **Online** is enforced either by [SuperID][1] or - if you use federated identities - by your [identity provider][2].

With basic SuperID (unfederated), the password must be at least 6 characters and yellow on the password strength indicator (score at least 2 on the [zxcvbn password strength algorithm][4]).

**It is not possible to set customer-specific policies in the Admin client**, because CRM Online, unfortunately, has no way of telling the user what the current policy is, and we would like to avoid that users have to guess.

## Onsite

You can read more about [policies for **onsite** installations][3] in our forums.

<!-- Referenced links -->
[1]: ../superid/overview.md
[2]: ../federated-id-and-identity-providers.md
[3]: https://community.superoffice.com/en/support-faqs/faq/how-do-i-enforce-a-strong-password-policy-in-superoffice-crm-onsite/
[4]: https://github.com/dropbox/zxcvbn
