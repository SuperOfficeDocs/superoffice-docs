---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: scimsetup_guide       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Guide to initial SCIM configuration # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto                # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud             # cloud or onsite
so.client: online             # online, web, win, pocket, or mobile
---

# Guide to initial SCIM configuration

This guide will take you briefly through the steps to set up automatic user provisioning from Azure AD and map these users to accounts in SuperOffice CRM Online.

## Pre-requisites

* Two different browsers to set up both the SuperOffice and Azure clients at the same time. Referred to here as **browser-SO** and **browser-AD** respectively.

* A SuperOffice admin account linked to an Azure AD account (AAD admin not required).

* An Azure AD admin account.

* Access to Azure AD with permissions to create an enterprise application of type **non-gallery application**.

  * You need **Azure Active Directory Premium** (P1 or P2) to support it.

## Guide

1. [Register Azure AD as the **identity provider**][1] for your domain on this tenant.

2. In browser-SO, [**sign in** to SuperOffice Identity Manager][2].

3. In browser-AD, [sign in to Azure AD and create an enterprise application][3].

4. In browser-SO, define the mapping between Azure AD and SuperOffice by [creating SCIM rules][4].

5. [Preview sync][5] and then [sync users to SuperOffice][6].

6. When everything works as expected, [enable automatic sync][7].

<!-- Referenced links -->
[1]: ../superid/howto/register-idp.md
[2]: sign-in-to-scim.md
[3]: create-azure-enterprise-app.md
[4]: add-scim-rule.md
[5]: preview-sync.md
[6]: sync-company.md
[7]: enable-auto-sync.md
