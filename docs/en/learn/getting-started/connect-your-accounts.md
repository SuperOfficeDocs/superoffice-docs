---
uid: help-en-connect-your-accounts
title: Connect your accounts
description: How to use the User setup wizard to connect your email account and document handler to SuperOffice CRM.
keywords: user setup, email connectivity, document handler, WebTools, connect email, email account, wizard, personal settings
author: digitaldiina
date: 03.17.2026
version: 11.11
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Connect your accounts

*Available for new customers from 11.11, available for all customers from 11.13.*

As a new user, or when setting up a new computer, you should connect your email account and document handler to SuperOffice. This lets you:

* Send emails and automatically archive outgoing messages in SuperOffice, making all customer communication available to your colleagues.
* Send meeting invitations to external recipients and receive invitations from others.
* Create, open, and edit documents directly from SuperOffice.

## Open the wizard

1. Click <i class="ph ph-user-circle" aria-label="Personal settings"></i> **Personal settings** in the upper-right corner.
1. Select **User setup**.

The wizard guides you through three steps.

## Step 1: Overview

The first screen summarizes what the wizard will help you set up. Click **Next** to proceed.

![SuperOffice User setup - overview of first screen of wizard -screenshot][img1]

## Step 2: Connect your email account

Click **Connect** and follow the prompts to validate your login credentials.

![SuperOffice User setup - connect to your email account -screenshot][img2]

Connecting your email account enables you to send emails from SuperOffice and archive outgoing messages automatically. You can also send and accept meeting invitations.

> [!NOTE]
> To work with **incoming** emails and access SuperOffice features from within your email client, install [SuperOffice for Outlook][3] (Microsoft 365) or [SuperOffice Gmail Link][4] (Google Workspace) after completing the wizard.

## Step 3: Connect your document handler

Your document handler controls how you create, open, and edit documents in SuperOffice.

Click **Download WebTools**, run the installer, and follow the on-screen instructions. WebTools connects your SuperOffice tenant to your local Office applications.

![SuperOffice User setup - download WebTools for handling documents -screenshot][img3]

> [!NOTE]
> The installer is selected automatically for your operating system. If you download WebTools directly from the SuperOffice download service, choose the correct installer for your OS (Windows or macOS) and version.

### Other document handler options

WebTools with the SuperOffice document library is the default. Your administrator may have configured a different option:

| Option | Requires |
|---|---|
| SuperOffice document library (WebTools) | — |
| Microsoft 365 / SharePoint | Microsoft 365 subscription + [admin setup][5] |
| Google Workspace | Google Workspace subscription + [admin setup][6] |

* **Microsoft 365 / SharePoint:** Stores documents in SharePoint Online. You can open them in SuperOffice CRM or in SharePoint and share them with people who do not use SuperOffice CRM via a SharePoint link.

* **Google Workspace:** Stores documents in Google Workspace. You can open, edit, and store documents from any computer.

## Synchronize your calendar

Synchronizing your calendar is not part of the wizard. If you want to keep appointments and follow-ups in sync between SuperOffice and your Outlook or Google calendar, set up [Synchronizer for SuperOffice][8] (available from the App Store).

## Related content

* [Install SuperOffice for Outlook][3]
* [Install SuperOffice Gmail Link][4]
* [Set up SuperOffice Inbox][2]
* [Install WebTools][7]
* [Connect email, document, and calendar (version 11.10 and earlier)][1]

<!-- Referenced links -->
[1]: connect-email-doc/index.md
[2]: ../../email/inbox/learn/setup.md
[3]: ../../../../integrations/superoffice-for-outlook/index.md
[4]: ../../../../integrations/gmail-link/index.md
[5]: ../../../../integrations/sharepoint-documents/set-up.md
[6]: ../../../../integrations/g-suite/index.md
[7]: ../../../../integrations/webtools/install.md
[8]: https://appstore.superoffice.com/infobridge-software-b-v-/synchronizer-for-superoffice

<!-- Referenced images -->
[img1]: ../../../media/loc/en/learn/superoffice-user-setup-1.png
[img2]: ../../../media/loc/en/learn/superoffice-user-setup-2-connect-email.png
[img3]: ../../../media/loc/en/learn/superoffice-user-setup-3-webtools.png
