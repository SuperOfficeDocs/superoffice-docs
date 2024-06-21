---
uid: help-en-mail-link-archive
title: Archive emails to SuperOffice
description: Archive emails to SuperOffice
author: SuperOffice RnD
date: 06.29.2022
keywords: Mail Link
topic: howto
language: en
---

# Archive an email

When you click the **Archive email** button on the mail client toolbar, a menu with archiving options is displayed.

> [!NOTE]
> This button also appears in the email window when you open an email you received.

**Options:**

* [Archiving emails on companies/contacts][2]
* [Archiving emails as activities][1]
* [Archiving attachments][3]
* [Archiving emails as requests][4]

For all the different archiving options, you may select the **Warn me when an email is larger than (in KB)** option in [the **General settings** pane][5] of the **SuperOffice CRM options** dialog. Thus, when you try to archive an email containing an attachment that is over the specified limit, a dialog will inform you of this and ask you if you would like to archive it anyway.

## Differences between Outlook, Notes, and SuperOffice CRM

You can create emails in several different ways, both [from Outlook][6] and [from SuperOffice CRM][8]. If the **Document** dialog appears, the email is treated as a SuperOffice document and will be archived. If the **Document** dialog does not appear, the email is archived based on the settings in the **SuperOffice CRM options** dialog.

The **Document** dialog opens automatically if you:

* Click the **Write** button in SuperOffice CRM.

* Click the down arrow to the right of the **New email** button on the Microsoft Outlook toolbar and select one of the templates on the **SuperOffice message** submenu.

The **Document** dialog will not open automatically if you:

* Click the **New email** button in the mail client. The emails will, however, be archived if the **Archive email by default when: created from email client** option in the **SuperOffice CRM options** dialog is selected.

* Click the **Email** button in SuperOffice CRM. The emails will, however, be archived if the **Archive email by default when: created from SuperOffice CRM** option in the **SuperOffice CRM options** dialog is selected.

* When you create an email using the **Email** button in SuperOffice CRM, it is possible to use a predefined email body template by default if the **Use SuperOffice email body** option in the **SuperOffice CRM options** dialog is selected.

> [!NOTE]
> This also applies if you click an email address in SuperOffice CRM, send an email from the **Contacts** section tab, or reply to/forward an email from the **Activities** section tab.

## The email is already archived in SuperOffice CRM

When an email is archived by a user, it is tagged with a unique ID within SuperOffice CRM. This means that next time someone tries to archive the same email, a warning will appear informing them about this; in this way, it is possible to avoid duplicates in the database.

If you open an email that has already been archived, the **Archive email** button ![icon][img1] will appear green with a white check-mark. If you hold the mouse pointer over the button, an info box is displayed, telling you when and by whom the email was archived. This presupposes that you selected the **Check for duplicates when an email is opened** option in the **SuperOffice CRM options** dialog.

## Related content

* [Archive options][9]
* [General settings][5]

<!-- Referenced links -->
[1]: archive-as-activity.md
[2]: archive-on-contact.md
[3]: archive-attachment.md
[4]: archive-as-request.md
[5]: settings/general.md
[9]: settings/default.md
[6]: create-in-outlook.md
[8]: create-in-superoffice.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/mail-link/already-archived.png
