---
title: primary_tenant
description: Primary tenant
author: {github-id}             # Your GitHub alias.
so.date:
keywords: 
so.topic: concept                    # article, howto, reference, concept, guide
so.envir: cloud           # cloud or onsite
so.client: online             # online, web, win, pocket, or mobile
---

# Primary tenant

Let's look at what happens to user accounts in a multi-tenant scenario.

In a multi-tenant scenario, 1 of the tenants is designated as the **primary tenant**. The primary tenant is commonly the **1st or oldest tenant**.

> [!WARNING]
> **Changing a person's username in the primary tenant will change the SuperID username!**<br>The change is applied to each tenant the next time the person signs in to that tenant.<br>It is not possible to change the username from any other tenant.

## Before SuperID

If a person has access to multiple tenants:

* The person has multiple standard SuperOffice user accounts.

* **If, and only if,** the person has chosen the exact same username and password for different tenants, the person will be asked to select a tenant when signing in. Otherwise, they are silently redirected.

## With SuperID

If a person has access to multiple tenants:

* One superID account is linked to multiple tenants (associate records).

* The person is **always** asked to select a tenant when signing in.
