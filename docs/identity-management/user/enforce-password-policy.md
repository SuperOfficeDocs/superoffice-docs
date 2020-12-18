---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: enforce_password_policy       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Enforce password policy  # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto                      # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Enforce password policy

Password policy is currently handled by SuperID or your identity provider.

The password policy for SuperOffice CRM **Online** is enforced either by [SuperID][1] or - if you use federated identities - by your [identity provider][2].

**It is not possible to set customer-specific policies in the Admin client**, because CRM Online, unfortunately, has no way of telling the user what the current policy is, and we would like to avoid that users have to guess.

You can read more about [policies for **onsite** installations][3] in our forums.

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/technical/documentation/identity-management/concepts/superid/
[2]: https://community.superoffice.com/en/technical/documentation/identity-management/overview/federated-id/
[3]: https://community.superoffice.com/en/search/#/faq/113578