---
uid: enforce-password-policy
title: Enforce a password policy
description: Enforce password policy
keywords: SuperID, password, password policy
author: digitaldiina
date: 04.28.2026
content_type: howto
deployment: online
platform: web
index: true
---

# Enforce a password policy

The password policy for SuperOffice CRM is enforced either by [SuperID][1] or - if you use federated identities - by your [identity provider][2].

With basic SuperID (unfederated), the password must be at least 6 characters and yellow on the password strength indicator (score at least 2 on the [zxcvbn password strength algorithm][4]).

**It is not possible to set customer-specific policies in the Admin client**, because SuperOffice, unfortunately, has no way of telling the user what the current policy is, and we would like to avoid that users have to guess.

<!-- Referenced links -->
[1]: ../superid/overview.md
[2]: ../federated-id-and-identity-providers.md
[4]: https://github.com/dropbox/zxcvbn
