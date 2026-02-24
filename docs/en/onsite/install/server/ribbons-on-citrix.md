---
uid: deploy-ribbons-citrix
title: Deploy Ribbons
description: Deploy Ribbons in a Citrix or Terminal Server environment
keywords: ribbons deploy citrix terminal
author: SuperOffice Product and Engineering
date: 02.24.2026
content_type: howto
deployment: onsite
---

# Deployment of SuperOffice Ribbons in a Citrix or Terminal Server environment

When installing SuperOffice in a Citrix or Terminal Server environment, review this information to prevent issues after deployment.

Before you continue, clarify the following: Will SuperOffice Ribbons be deployed to all users in the Citrix or Terminal Server environment?

* If Ribbons will be deployed to all users, no additional configuration is required.
* If Ribbons will be deployed to selected users only, follow the guidance below.

> [!NOTE]
> We're not using the Shadow key system in the registry anymore.

## Ribbons deployment

When deploying Ribbons in a Terminal Server/Citrix environment, we use a registry mechanism called Registry propagation built into Microsoft Office.

[!include[Registry propagation](includes/registry-propagation.md)]

## Supporting groups that should (not) have Ribbons

The correct way to support a scenario where some users/groups should get the Ribbons is to remove the registry keys mentioned below:

[!include[Registry keys](includes/registry-keys.md)]

### Registry scripts to import

Use the following Registry script to deploy Ribbons to those users/groups that should receive these components.
**Remember to substitute the paths with correct filenames for your installation!**

[!include[Registry deploy Ribbons](includes/registry-deploy-ribbons.md)]

## Ribbons language

How to change default Ribbons language is described in this [article][2].

<!-- Referenced links -->
[2]: addins-language.md
