---
uid: sofo-deploy
title: Centralized deployment
description: How to deploy SuperOffice for Outlook through the Microsoft 365 Admin Center or PowerShell.
keywords: SuperOffice for Outlook, Outlook, email, deploy, add-in, PowerShell, Microsoft 365 Admin Center, SOFO
author: Frode B, Martin Pavlas
date: 05.05.2026
version_sofo: 6.3.0
content_type: howto
category: integration
topic: SuperOffice for Outlook
language: en
redirect_from: 
  - /en/email/superoffice-for-outlook/deploy-centrally
  - /en/email/superoffice-for-outlook/it/deploy
  - /da/email/superoffice-for-outlook/it/deploy
  - /de/email/superoffice-for-outlook/it/deploy
  - /nl/email/superoffice-for-outlook/it/deploy
  - /no/email/superoffice-for-outlook/it/deploy
  - /sv/email/superoffice-for-outlook/it/deploy
---

# Centralized deployment

You can perform centralized deployment through the Microsoft 365 Admin Center.

> [!TIP]
> Install for a single user instead? [Go to the user guide][5].

## Deploy via Microsoft 365 admin center

To deploy SuperOffice for Outlook using the Microsoft 365 admin center, see [Microsoft's documentation][3].

## Approve shared mailbox permissions for users

Shared mailbox support requires additional Microsoft 365 permissions. A Microsoft 365 Global Administrator must grant consent for the add-in before users can access shared mailbox features.

Consent can be granted in three ways:

* Using a generic authorisation URL (recommended - can be done before users encounter any prompts)
* Using a URL that a user copies from the permission dialog they encounter
* Directly from the add-in in Outlook, using a Global Administrator account

If a user does not have admin rights, they can select "Return to the application without granting consent" in the dialog, then copy a link to share with their Microsoft 365 Global Administrator.

For full step-by-step instructions, see [SuperOffice for Outlook: Authorisation guide][6].

> [!NOTE]
> When an update to an add-in increases the scope of data access, Microsoft may require the update to be re-approved before it is deployed.

<!-- Referenced links -->
[3]: https://learn.microsoft.com/en-us/microsoft-365/admin/manage/manage-deployment-of-add-ins?view=o365-worldwide
[5]: get.md
[6]: https://community.superoffice.com/en/support-faqs/faq/superoffice-for-outlook-authorisation-guide/
