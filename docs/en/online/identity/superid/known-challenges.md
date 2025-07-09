---
title: Known challenges
uid: known_challanges_with_superid
description: Known challenges with SuperID
author:
date:
keywords: 
content_type: reference
deployment: online
platform: web
index: true
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

With SuperID, it is not permitted to create multiple users with identical usernames in the Admin client. Renaming a username also held by another user will create a new SuperID user.
