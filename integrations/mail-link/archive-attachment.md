---
uid: mail-link-archive-attachment
title: Archive attachments
description: If you would like to save an email attachment but not the email itself in SuperOffice CRM, you can archive the attachment as a document.
keywords: archive email, archive attachment
author: SuperOffice Product and Engineering
date: 06.29.2022
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

If the attachment is the only part of the email you would like to keep for future reference, it is possible to archive an attachment to an email in your mail client inbox to SuperOffice CRM. Follow these steps:

![Use Mail Link in Outlook to archive an email attachment in your inbox to SuperOffice CRM -screenshot][img1]

## Steps

1. Select the email that contains the attachment(s) you want to archive.

2. Click the **Archive email** button on the toolbar, and **Archive attachment(s)** from the dropdown.

3. One of the following situations occurs:

    * If there is only one attachment, the **Archive attachment** dialog opens immediately.
    * If there is more than one attachment, a dialog appears listing the attachments. Select the required attachment and click **OK** to archive it. The **Archive attachment** dialog then opens, and the procedure below is repeated for each attachment.

4. If the sender of the email is not listed in SuperOffice CRM, a warning will appear at the top of the dialog. [How to handle unlisted senders][1].

5. In the **Subject** field, the file name of the attachment is automatically inserted. However, you may enter any subject text that you would like to be shown in the **Activities** section tab of SuperOffice CRM.

6. In the **Company** field, you may search for a company by starting to type the company name and then select from the matches that appear.

7. In the **Contact** field, you may use the dropdown to select one of the contacts belonging to the company you selected in the previous step. You can also search by starting to type the contact name.

8. If you would like to link the attachment to a certain project, you may select the project in the **Project** field.

9. If you would like to link the attachment to a certain sale, you may select the sale in the **Sale** field.

10. In the **Type** dropdown, you may select one of the available document templates.

11. In the **Visible for** field, click the arrow next to the field. A list is displayed allowing you to choose if the attachment should be visible to all users, private (visible only to the user defined as owner) or visible to all users in the user group that the owner belongs to.

    > [!NOTE]
    > The **Visible for** field is available only if this right is assigned to you in Settings and maintenance.

12. Click **OK**. The selected attachment is archived to SuperOffice CRM as a new document. You can then open the document by double-clicking it in the **Activities** section tab.

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
[img1]: ../../docs/media/loc/en/email/email-maillink-archive-attachment.png
