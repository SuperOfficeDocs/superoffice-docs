---
title: Primary tenant
uid: primary_tenant
description: Primary tenant
author: SuperOffice Product and Engineering
date:
keywords: 
content_type: concept
deployment: online
platform: web
index: true
---

# Primary tenant

Let's look at what happens to user accounts in a multi-tenant scenario.

In a multi-tenant scenario, 1 of the tenants is designated as the **primary tenant**. The primary tenant is commonly the **1st or oldest tenant**.

> [!WARNING]
> **Changing a person's username in the primary tenant will change the SuperID username!**
>
> The change is applied to each tenant the next time the person signs in to that tenant.
>
> It is not possible to change the username from any other tenant.

## Before SuperID

If a person has access to multiple tenants:

* The person has multiple standard SuperOffice user accounts.

* **If, and only if,** the person has chosen the exact same username and password for different tenants, the person will be asked to select a tenant when signing in. Otherwise, they are silently redirected.

## With SuperID

If a person has access to multiple tenants:

* One superID account is linked to multiple tenants (associate records).

* The person is **always** asked to select a tenant when signing in.
