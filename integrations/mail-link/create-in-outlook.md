---
uid: mail-link-create-outlook
title: Create email from Microsoft Outlook
description: Learn how to create emails from Microsoft Outlook using SuperOffice Mail Link, with standard Outlook functionality or SuperOffice templates.
keywords: create email, new SuperOffice email, SuperOffice template
author: digitaldiina
date: 03.17.2026
content_type: howto
category: integration
topic: Mail Link
audience: person
audience_tooltip: SuperOffice CRM
language: en
redirect_from:
  - /en/email/mail-link/learn/create-in-outlook
  - /da/email/mail-link/learn/create-in-outlook
  - /de/email/mail-link/learn/create-in-outlook
  - /nl/email/mail-link/learn/create-in-outlook
  - /no/email/mail-link/learn/create-in-outlook
  - /sv/email/mail-link/learn/create-in-outlook
index: true
---

# Create email from Microsoft Outlook

There are two ways of creating an email from Microsoft Outlook. You can use SuperOffice templates, or you can use standard Outlook functionality. When using a SuperOffice template, the email is automatically archived as a SuperOffice document. For standard Outlook emails, archiving depends on the **Archive email by default when: created from email client** setting in the [SuperOffice CRM options dialog][5].

## Create a standard Outlook email

1. Click the **New email** button on the Microsoft Outlook toolbar.

1. In the email window in the **To** field, enter the email addresses of the recipients. You can also use the **Select recipients** dialog (see [Selecting recipients][2]).

1. Write the message.

1. Add any attachments you want to include. You can also [add documents from SuperOffice CRM][3].

1. Click **Send** to send the message to the specified recipient(s).

    The email is archived if **Archive email by default when: created from email client** is enabled in the [SuperOffice CRM options dialog][5].

## Create an email with SuperOffice templates

1. Click the down arrow to the right of the **New email** button on the Microsoft Outlook toolbar. A menu is displayed.

1. Click **SuperOffice message** and select one of the templates on this submenu. The **New SuperOffice email** dialog opens.

    > [!NOTE]
    > This presupposes that you are logged on to SuperOffice CRM. If not, the menu will only contain one item: **Populate**. If you click **Populate**, you will be asked if you want to start SuperOffice CRM. If you accept, the submenu is populated.

1. In the **Subject** field, enter the email subject. This is also shown in the **Activities** section tab in SuperOffice CRM.

1. Fill in **Company**, **Contact**, **Project**, and **Sale** as needed. Start typing to search and select from the results.

1. In the **Type** dropdown, select an email template.

1. In the **Visible for** field, click the arrow next to the field. A list is displayed allowing you to choose if the document should be visible to all users, private (visible only to the user defined as owner) or visible to all users in the user group that the owner belongs to.

    > [!NOTE]
    > The **Visible for** field is only available if this right is assigned to you in Settings and maintenance.

1. Click **OK** in the **New SuperOffice email** dialog. A new email window opens.

1. In the **To** field, enter the email address of any other recipients you want to add. You can also use the **Select recipients** dialog (see [Selecting recipients][2]).

1. Write the message.

1. Add any attachments you want to include. You can also [add documents from SuperOffice CRM][3].

1. Click **Send** to send the message to the specified recipient(s).

    Because you selected a SuperOffice template, the email is automatically archived to SuperOffice CRM.

## <a id="archive"></a>Archive to SuperOffice

* To archive all sent emails by default, enable **Archive email by default when: created from email client** in the [SuperOffice CRM options dialog][5].

* To enable or disable archiving for an individual email, click the **Archive is ON/OFF** button in the email window before sending.

## Related content

* [Archive email to SuperOffice][6]

## Buttons in the email window

| Button | Function | Description |Read more |
|:-:|---|---|---|
| ![icon][img1],![icon][img2] | Archive is ON / Archive is OFF | Indicates if the email will be archived when sent. Click the button to enable or disable this setting. The default setting is specified in the **Archive options** pane of the **SuperOffice CRM options** dialog. | [Archive options][5] |
| ![icon][img3] | Add recipient | Opens the **Select recipients** dialog. | [Select recipients][2] |
| ![icon][img4] | Attach document | Opens the **Include attachments** dialog. | [Add SuperOffice documents as attachments][3] |
| ![icon][img5] | | Click the arrow to the right of the **SuperOffice** button to open the **SuperOffice CRM options** dialog. | [SuperOffice CRM options dialog][5] |

<!-- Referenced links -->
[2]: select-recipients.md
[3]: add-attachment.md
[5]: settings.md
[6]: archive.md

<!-- referenced images -->
[img1]: media/archive-is-on.png
[img2]: media/archive-is-off.png
[img3]: media/add-recipient.png
[img4]: media/add-document.png
[img5]: media/superoffice-button.png
