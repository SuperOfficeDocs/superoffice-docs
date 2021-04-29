---
title: Known challenges
uid: known_challanges_with_superid
description: Known challenges with SuperID
author:
so.date:
keywords: 
so.topic: reference
so.envir: cloud
so.client: online
---

# Known challenges with SuperID

We currently see some challenges where users are unable to sign in after migrating the tenant to SuperID.

## Multiple usernames

**Problem:**

A user might have multiple email addresses on their `person` record. Only 1 of these will become the new SuperID username. Sometimes migration picks the wrong email address.

**Solution:**

> [!NOTE]
> The admin can fix this by editing the **Username** field in the Admin client.

Issues related to multiple associate records pointing to the new/old username apply (see next scenario).

## Users with multiple associate records in the same tenant

**Problem:**

A person might have multiple associate records in the customer database. We observe that often only 1 of these has a valid license.

> [!CAUTION]
> If the primary tenant does **not** have a license and you change the username, the user can no longer sign in.

**Solution:**

Must be resolved manually by R&D services or Operations.

We are working on a stricter naming scheme to prevent this problem: **In the future**, it will not be permitted to create multiple users with identical usernames in the Admin client. Renaming a username also held by another user will create a new SuperID user.

## Consultants assisting multiple customers

**Problem:**

Our consultants typically have users in many tenants. For them, the 1st tenant they got a user account in will be their primary tenant. If the customer's admin renames this user, the **SuperID username of the consultant is changed** and can block all further access.

**Solution:**

When we move SuperOffice One to the cloud, this will become your primary tenant. Until then:

> [!TIP]
> All consultants should contact R&D services or Operations to set up a test/demo tenant in CRM Online as their primary tenant to prevent being locked out.
