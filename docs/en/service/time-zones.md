---
title: Time zones
description: Time zones in Service
author: {github-id}
keywords:
topic: concept
version: 8.4 R02
---

# Time zones in Service

Earlier, there was a setting on the users in Service enabling to set a time zone and was used when displaying and inputting datetimes.

In 8.4 R02, this setting has been removed. Instead, we use the *Preferred time zone* preference in Web Admin, found under **Default values**.

Existing settings on the users in Service will NOT be migrated to the *Preferred time zone* preference.

So this results in 2 scenarios:

* If you have set a time zone in Service but not a *Preferred time zone* in Web Admin then you will have to add it manually for the user.
* If you have NOT set a time zone in Service but a user has a *Preferred time zone* set then Service dates will now start respecting this.
