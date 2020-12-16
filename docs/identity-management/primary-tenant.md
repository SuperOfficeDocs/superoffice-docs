---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: primary_tenant       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Primary tenant                   # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: concept                    # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Primary tenant

Let's look at what happens to user accounts in a multi-tenant scenario.

In a multi-tenant scenario, 1 of the tenants is designated as the **primary tenant**. The primary tenant is commonly the **1st or oldest tenant**.

>[!WARNING] 
**Changing a person's username in the primary tenant will change the SuperID username!** 
>
>The change is applied to each tenant the next time the person signs in to that tenant.  
It is not possible to change the username from any other tenant.

## Before SuperID

If a person has access to multiple tenants:

* The person has multiple standard SuperOffice user accounts.

* **If, and only if,** the person has chosen the exact same username and password for different tenants, the person will be asked to select a tenant when signing in. Otherwise, they are silently redirected.


## With SuperID

If a person has access to multiple tenants:

* One superID account is linked to multiple tenants (associate records).

* The person is **always** asked to select a tenant when signing in.
