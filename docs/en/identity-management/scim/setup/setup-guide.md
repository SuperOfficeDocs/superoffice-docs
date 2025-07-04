---
title: Guide to initial SCIM configuration
uid: scimsetup_guide
description: Guide to initial SCIM configuration
author: SuperOffice Product and Engineering
date: 01.15.2024
keywords: IdP, SCIM, Microsoft Entra, ME-ID, AAD
content_type: howto
deployment: online
platform: web
index: true
---

# Guide to initial SCIM configuration

This guide will take you briefly through the steps to set up automatic user provisioning from Microsoft Entra ID and map these users to accounts in SuperOffice CRM Online.

## Pre-requisites

* Two different browsers to set up both the SuperOffice and Azure clients at the same time. Referred to here as **browser-SO** and **browser-AD** respectively.

* A SuperOffice admin account linked to a Microsoft Entra account (Microsoft Entra admin not required).

* A Microsoft Entra admin account.

* Access to Microsoft Entra admin center with permissions to create an enterprise application of type **non-gallery application**.

  * You need **Microsoft Entra ID Premium** (P1 or P2) to support it.

## Guide

1. [Register Microsoft Entra ID as the **identity provider**][1] for your domain on this tenant.

2. In browser-SO, [**sign in** to SuperOffice Identity Manager][2].

3. In browser-AD, [sign in to Microsoft Entra and create an enterprise application][3].

4. In browser-SO, define the mapping between Microsoft Entra ID and SuperOffice by [creating SCIM rules][4].

5. [Preview sync][5] and then [sync users to SuperOffice][6].

6. When everything works as expected, [enable automatic sync][7].

<!-- Referenced links -->
[1]: ../../superid/howto/register-idp.md
[2]: ../sign-in-to-scim.md
[3]: create-azure-enterprise-app.md
[4]: ../provisioning/add-scim-rule.md
[5]: ../provisioning/preview-sync.md
[6]: ../provisioning/sync-company.md
[7]: enable-auto-sync.md
