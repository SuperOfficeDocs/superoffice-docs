---
title: Deploy Ribbons
uid: deploy_ribbons_on_citrix
description: Deploy Ribbons in a Citrix or Terminal Server environment
author: {github-id}
keywords: ribbons deploy citrix terminal
topic: howto
envir: onsite
# client:
---

# Deployment of SuperOffice Ribbons in a Citrix or Terminal Server environment

When installing SuperOffice in a Citrix environment, consider this to avoid problems when the customer starts to use our software.

## Ribbons on Citrix or Terminal server

Ask: Will the customer deploy Ribbons to ALL users running in the Citrix/Terminal Server environment?

**If all users want Ribbons, you can skip reading this document.**

> [!NOTE]
> We’re not using the Shadow key system in the registry anymore.

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
