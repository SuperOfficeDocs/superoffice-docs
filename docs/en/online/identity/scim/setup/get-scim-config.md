---
title: Get SCIM config for Microsoft Entra
uid: get_scim_config
description: Get SCIM config for the Microsoft Entra enterprise application
author: SuperOffice Product and Engineering
date: 01.15.2024
keywords: IdP, SCIM, Microsoft Entra, ME-ID, AAD
content_type: howto
deployment: online
platform: web
index: true
---

# Get SCIM config for the Microsoft Entra enterprise application

When setting up a Microsoft Entra (formerly AAD) enterprise application for SCIM, you need to fetch the admin credentials from the SuperOffice Identity Manager.

## Pre-requisites

* SuperOffice administrator account with access to user admin.

## Procedure

1. [Sign in to the SuperOffice Identity Manager][1].

2. Click **SCIM Sync Config** in the upper right corner.

3. Copy the tenant URL and token from the dialog box.

    ![SCIM sync config -screenshot][img1]

<!-- Referenced links -->
[1]: ../sign-in-to-scim.md

<!-- Referenced images -->
[img1]: media/scim-sync-config.png
