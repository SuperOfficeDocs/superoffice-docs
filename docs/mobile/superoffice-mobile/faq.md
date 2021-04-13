---
title: FAQ
uid: mobile_crm_faq
description: FAQ for SuperOffice Mobile CRM
author: {github-id}
so.date: 03.22.2021
keywords:
so.topic: reference
so.envir: cloud
so.client: mobile
---

# FAQ

## Session timeout

Q: **Can we set a session timeout and where can it be set?**

A: Yes, set a value in SuperOffice Admin preference **autologout time** (minutes)

## Read-only mode

Q: **Can Mobile CRM be set up to be strictly read-only?**

A: The access rights are set via Roles in Admin, and will apply as same as Web client access

## Phone is stolen

Q: **In the scenario of the phone is stolen - do they have access to the CRM data?**

A: SuperOffice Admin preference **disable autologin** can be set to force users to log in each time.

If not set, they still need to first be able to unlock the phone to start Mobile CRM. The user must change their SuperOffice CRM Online password to ensure to avoid possible data theft.

## Don't allow any software on mobile clients to cache customer data

Q: My Enterprise Security team will not allow any software on mobile clients that can show or cache customer data unless the software **uses Two Factor Authentication (2FA) or access over VPN only**

A: Enable IdP for all users, and enable 2FA for the IdP provider. No option to support VPN to CRM Online.
