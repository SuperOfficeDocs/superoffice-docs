---
uid: mail-link-archive-attachment
title: Archive attachments
description: If you want to save an email attachment but not the email itself in SuperOffice CRM, you can archive the attachment as a document.
keywords: archive email, archive attachment
author: digitaldiina
date: 03.17.2026
content_type: howto
category: integration
topic: Mail Link
audience: person
audience_tooltip: SuperOffice CRM
language: en
redirect_from:
  - /en/email/mail-link/learn/archive-attachment
  - /da/email/mail-link/learn/archive-attachment
  - /de/email/mail-link/learn/archive-attachment
  - /nl/email/mail-link/learn/archive-attachment
  - /no/email/mail-link/learn/archive-attachment
  - /sv/email/mail-link/learn/archive-attachment
index: true
---

# Archive attachments

If the attachment is the only part of the email you want to keep for future reference, it is possible to archive an attachment to an email in your mail client inbox to SuperOffice CRM. Follow these steps:

![Use Mail Link in Outlook to archive an email attachment in your inbox to SuperOffice CRM -screenshot][img1]

## Steps

1. Select the email that contains the attachment(s) you want to archive.

1. Click the **Archive email** button on the toolbar, and **Archive attachment(s)** from the dropdown.

1. One of the following situations occurs:

    * If there is only one attachment, the **Archive attachment** dialog opens immediately.
    * If there is more than one attachment, a dialog appears listing the attachments. Select the required attachment and click **OK** to archive it. The **Archive attachment** dialog then opens, and the procedure below is repeated for each attachment.

1. If the sender of the email is not listed in SuperOffice CRM, a warning will appear at the top of the dialog. [How to handle unlisted senders][1].

1. In the **Subject** field, the attachment file name is automatically inserted. Edit it to change how it appears in the **Activities** section tab.

1. In the **Company** field, start typing to search for a company and select from the matches.

1. In the **Contact** field, select a contact from the company, or start typing to search.

1. Optionally, select a **Project** and/or **Sale** to link the attachment to.

1. In the **Type** dropdown, select a document template.

1. In the **Visible for** field, click the arrow next to the field. A list is displayed allowing you to choose if the attachment should be visible to all users, private (visible only to the user defined as owner) or visible to all users in the user group that the owner belongs to.

    > [!NOTE]
    > The **Visible for** field is available only if this right is assigned to you in Settings and maintenance.

1. Click **OK**. The selected attachment is archived to SuperOffice CRM as a new document. You can then open the document by double-clicking it in the **Activities** section tab.

## Related content

* [Archive emails on companies/contacts][2]
* [Archive emails as activities][3]
* [Archive emails as requests][4]

<!-- Referenced links -->
[1]: manage-senders.md
[2]: archive-on-contact.md
[3]: archive-as-activity.md
[4]: archive-as-request.md

<!-- Referenced images -->
[img1]: media/email-maillink-archive-attachment.png
