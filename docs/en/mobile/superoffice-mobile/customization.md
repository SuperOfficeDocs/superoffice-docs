---
uid: mobile-crm-customization
title: Customization
description: Overview of ways to customize SuperOffice Mobile CRM.
keywords: shown in Mobile CRM, mobile, pocket, customization, CRMScript
author: Bergfrid Dias
date: 06.10.2025
version: 11.1
content_type: concept
platform: mobile
language: en
---

# Customization

[!include[License requirement](../../includes/req-dev-tools.md)]

## React to events with CRMScripts

[Trigger scripts][1] are CRMScripts that are run on user-interface events. The scripts must be defined in Settings and maintenance.

Mobile CRM supports the following triggers:

* Service: new request
* Service: request changed
* CRM: before save
* CRM: after save

### Limitations

Stakeholders, quotes, relations, selections, and selection members cannot be created or updated in Mobile CRM.

**NavigateTo** is not supported (neither custom or soprotocol navigation).

## CRMScript triggered dialogs

With CRMScript, you can define dialogs that can be shown in both SuperOffice CRM and Mobile CRM. This means that you can trigger new customized questions or dialogs to the users tailored to the business logic you want to enforce.

![Mobile CRM custom dialog -app-screen][img1]

## Invoke script from Task menu

With CRMScript, you can add items to the **Task** menu (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) to trigger custom tasks.

To make a custom task available in the app, check **Shown in Mobile CRM** when defining the task in Settings and Maintenance

![Setup of a custom task that runs a CRMScript -screenshot][img5]

After adding new Task menu definition, log out and in again in Mobile CRM to make sure all your caches are cleared.

## Related content

* [About CRMScript][3]
* [Create trigger script][2]
* [Add custom task][1]
* [Tutorial - how to use dialogs in triggers][4]

<!-- Referenced links -->
[1]: ../../automation/trigger/reference/index.md
[2]: ../../automation/trigger/create-trigger-script.md
[3]: ../../automation/crmscript/overview/index.md
[4]: ../../automation/crmscript/tutorials/using-dialogs-in-triggers.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/mobile/custom-dialog.png
[img5]: ../../../media/loc/en/mobile/add-task-menu-item.png
