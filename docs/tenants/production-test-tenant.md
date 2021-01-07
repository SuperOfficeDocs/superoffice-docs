---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: production_test_tenant       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Production test tenants # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Production test tenants

Customers and partners can, in addition, buy their own test tenant in production based on a copy of their production data.

The test [tenant][1] may be replaced with a [newer copy][2] of their production database after the initial setup.

To buy your own test environment, please contact your local sale rep. The initial setup is handled by SuperOffice AS / Online Operation.

> [!TIP]
> You don't need the same amount of [user plans][3] in the test environment. We assume most will have just a few test users/developers with access to the test tenant.

The test environment is a **dead end**. We will not make it possible to migrate data back into the production environment from this test environment.

> [!CAUTION]
> **The production test environment is not a backup!** We will clean up in the copied production database and also remove all mailboxes used by Service there.

<!-- Referenced links -->
[1]: index.md
[2]: replace-test-envir.md
[3]: https://community.superoffice.com/en/developer/create-apps/concepts/user-plans-and-subscriptions/