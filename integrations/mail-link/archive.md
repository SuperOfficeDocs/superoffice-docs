---
uid: mail-link-archive
title: Archive email to SuperOffice
description: Learn how to archive emails to SuperOffice CRM using Mail Link.
keywords: archive email, check for duplicates
author: digitaldiina
date: 03.17.2026
content_type: howto
category: integration
topic: Mail Link
audience: person
audience_tooltip: SuperOffice CRM
language: en
redirect_from:
  - /en/email/mail-link/learn/archive
  - /da/email/mail-link/learn/archive
  - /de/email/mail-link/learn/archive
  - /nl/email/mail-link/learn/archive
  - /no/email/mail-link/learn/archive
  - /sv/email/mail-link/learn/archive
  - /en/email/mail-link/learn/settings/archive-by-default
  - /da/email/mail-link/learn/settings/archive-by-default
  - /de/email/mail-link/learn/settings/archive-by-default
  - /nl/email/mail-link/learn/settings/archive-by-default
  - /no/email/mail-link/learn/settings/archive-by-default
  - /sv/email/mail-link/learn/settings/archive-by-default
index: true
---

# Archive email to SuperOffice

When you click the **Archive email** button on the mail client toolbar, a menu with archiving options is displayed. This button also appears in the email window when you open an email you received.

## Options

* [Archive emails on companies/contacts][2]
* [Create activity from email][1]
* [Archive attachments][3]
* [Create request from an email][4]

For all the different archiving options, you can select the **Warn me when an email is larger than (in KB)** option in the **General settings** pane of the **SuperOffice CRM options** dialog. When you try to archive an email containing an attachment that is over the specified limit, a dialog will inform you and ask if you want to archive it anyway.

## The email is already archived in SuperOffice CRM

When an email is archived by a user, it is tagged with a unique ID within SuperOffice CRM. This means that next time someone tries to archive the same email, a warning will appear informing them about this; in this way, it is possible to avoid duplicates in the database.

If you open an email that has already been archived, the **Archive email** button ![icon][img1] will appear green with a white check-mark. If you hold the mouse pointer over the button, an info box is displayed, telling you when and by whom the email was archived. This presupposes that you selected the **Check for duplicates when an email is opened** option in the **SuperOffice CRM options** dialog.

## Related content

* [Set default archiving behavior][5]
* [Archive when creating emails from Outlook][6]
* [Archive when creating emails from SuperOffice CRM (legacy)][8]

<!-- Referenced links -->
[1]: archive-as-activity.md
[2]: archive-on-contact.md
[3]: archive-attachment.md
[4]: archive-as-request.md
[5]: settings.md
[6]: create-in-outlook.md
[8]: create-in-superoffice.md#archive

<!-- Referenced images -->
[img1]: media/already-archived.png
