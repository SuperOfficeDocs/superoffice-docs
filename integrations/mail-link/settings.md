---
uid: mail-link-settings
title: SuperOffice CRM options dialog
description: The SuperOffice CRM options dialog allows you to set archive, general and account options and show version information about SuperOffice Mail Link.
keywords: Mail Link settings, SuperOffice CRM options dialog
author: SuperOffice Product and Engineering
date: 06.29.2022
content_type: reference
category: integration
topic: Mail Link
audience: person
audience_tooltip: SuperOffice CRM
language: en
redirect_from:
  - /en/email/mail-link/learn/settings/index
  - /da/email/mail-link/learn/settings/index
  - /de/email/mail-link/learn/settings/index
  - /nl/email/mail-link/learn/settings/index
  - /no/email/mail-link/learn/settings/index
  - /sv/email/mail-link/learn/settings/index
  - /en/email/mail-link/learn/settings/default
  - /da/email/mail-link/learn/settings/default
  - /de/email/mail-link/learn/settings/default
  - /nl/email/mail-link/learn/settings/default
  - /no/email/mail-link/learn/settings/default
  - /sv/email/mail-link/learn/settings/default
  - /en/email/mail-link/learn/settings/general
  - /da/email/mail-link/learn/settings/general
  - /de/email/mail-link/learn/settings/general
  - /nl/email/mail-link/learn/settings/general
  - /no/email/mail-link/learn/settings/general
  - /sv/email/mail-link/learn/settings/general
  - /en/email/mail-link/learn/settings/invitations
  - /da/email/mail-link/learn/settings/invitations
  - /de/email/mail-link/learn/settings/invitations
  - /nl/email/mail-link/learn/settings/invitations
  - /no/email/mail-link/learn/settings/invitations
  - /sv/email/mail-link/learn/settings/invitations
  - /en/email/mail-link/learn/settings/superoffice-account
  - /da/email/mail-link/learn/settings/superoffice-account
  - /de/email/mail-link/learn/settings/superoffice-account
  - /nl/email/mail-link/learn/settings/superoffice-account
  - /no/email/mail-link/learn/settings/superoffice-account
  - /sv/email/mail-link/learn/settings/superoffice-account
index: true
---

# SuperOffice CRM options dialog

Open the **SuperOffice CRM options** dialog by clicking the small arrow to the right of the **SuperOffice** button in the email window or the inbox.

Alternatively, you may select **SuperOffice CRM Options** on the **Tools** menu in Outlook or the **Actions** menu in Notes.

This dialog allows you to set archive, general and account options and show version information about SuperOffice Mail Link.

## Archive options

| Option | Description |
|---|---|
| Archive email by default when | For each checked option, **Archive is ON** is set by default for the situation the option refers to. If you uncheck an option, **Archive is OFF** is set by default. |
| Created from SuperOffice CRM | When you send an email, it is archived in SuperOffice CRM by default. |
| Written to associates from SuperOffice CRM | If selected, *all* outgoing emails written to associates are archived. Otherwise, emails to people registered as associates in SuperOffice CRM are *not* be archived by default. This option only applies to [emails composed in SuperOffice CRM][4] and if the **created from SuperOffice CRM** box is checked. |
| Created from email client | [Enables default archiving][5] of emails you compose in your mail client by clicking the **New email** button. When you send an email, it is archived in SuperOffice CRM by default. If you select **Archive is OFF** in the email window of the mail client, the email will not be archived to SuperOffice CRM. |
| Replying to emails from SuperOffice CRM | Enable default archiving of emails you reply to in SuperOffice CRM. |
| Forwarding emails from SuperOffice CRM | Enable default archiving of emails you forward in SuperOffice CRM. |
| Sending appointments from SuperOffice CRM | By default, archive follow-ups sent as emails from SuperOffice CRM. |
| Sending documents from SuperOffice CRM | Archive documents sent as emails from SuperOffice CRM. |
| Default template when archiving email | In these two dropdowns you may select the default incoming and outgoing email template. |

You can override the default options by using the [buttons in your mail client][2].

## General settings

### Actions when archiving an email

These options determine how SuperOffice CRM and the mail client behave in response to various operations.

| Option | Description |
|---|---|
| Close email after archiving to SuperOffice CRM | Check this box if you want the email window in the mail client to close automatically after you archive the email to SuperOffice CRM. |
| Delete the email after it has been archived to SuperOffice CRM | Check this box to remove the selected emails from the mail client inbox after they are archived in SuperOffice CRM. The emails are moved to the **Deleted items** folder. |

> [!NOTE]
> If the sender of the email is not listed as a company/contact in SuperOffice CRM, the email(s) will still be moved to the **Deleted items** folder.

### Settings for new emails

| Option | Description |
|---|---|
| Use SuperOffice email body | You can predefine an email body that uses data from SuperOffice CRM. To use this template, select this option. |
| Use default body from email client | If you would like to use the default body from the mail client, you may select this option. |

### Warnings

These options determine when you receive warnings.

| Option | Description |
|---|---|
| Warn me when an email is larger than (in KB): | If you check this box, you will receive a warning whenever you try to archive an email or attachment larger than a given size. Enter the size (in KB) in the field to the right. |
| Check for duplicates when an email is opened | If you check this box and open an email that has already been [archived][5], the **Archive email** button will appear green with a white check-mark. If you hold the mouse pointer over the button, an info box is displayed, telling you when and by whom the email was archived. |

## Invitations

In the **Invitations** pane, you can define how invitations are handled.

| Option | Description |
|---|---|
| Incoming invitations | When you respond to an invitation in Outlook (accepted or tentative), you can also create or update a meeting in SuperOffice. Select this option: **Add / update appointment in SuperOffice when responding to invitations in Outlook** |

## SuperOffice account

These options appear in the **SuperOffice account** pane of the **SuperOffice CRM options** dialog.

| Option | Description |
|---|---|
| Preferred SuperOffice client | Which SuperOffice client to use when [searching for senders][3]: **SuperOffice CRM** (Windows client), **SuperOffice CRM** (Web client) or **Service**. |
| User name | Enter your user name for the selected client and click **Test connection** to confirm that you can log in to the client in question, and consequently that the connection between the mail client and the SuperOffice client works. |

## Advanced settings

If you click the down arrow to the right of **Advanced settings**, the following options will appear:

| Option | Description |
|---|---|
| Enable debug logging | This option should be activated when debugging if requested by customer support at SuperOffice. |
| View log file | Open the log file for SuperOffice Mail Link. Also relevant when debugging. |
| URL | This field contains the address of the SuperOffice client where emails are archived. Relevant only for SuperOffice CRM for Web and SuperOffice Service. |

## About pane

The **About** pane of the dialog contains information about the current version of SuperOffice Mail Link and about installed components.

<!-- Referenced links -->
[2]: index.md
[3]: manage-senders.md
[4]: create-in-superoffice.md
[5]: archive.md

<!-- Referenced images -->
