---
uid: mail-link-create-outlook
title: Creating emails from Microsoft Outlook
description: Creating emails from Microsoft Outlook
keywords: create email, new SuperOffice email, SuperOffice template
author: SuperOffice Product and Engineering
date: 06.29.2022
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

There are two ways of creating an email from Microsoft Outlook. You can use SuperOffice templates, or you can use standard Outlook functionality.

## Create a standard Outlook email

1. Click the **New email** button on the Microsoft Outlook toolbar.

2. In the email window in the **To** field, enter the email addresses of the recipients. You can also use the **Select recipients** dialog (see [Selecting recipients][2]).

3. Write the message.

4. Add any attachments you would like to include. You can also [add documents from SuperOffice CRM][3].

5. Click **Send** to send the message to the specified recipient(s).

## Create an email with SuperOffice templates

1. Click the down arrow to the right of the **New email** button on the Microsoft Outlook toolbar. A menu is displayed.

2. Click **SuperOffice message** and select one of the templates on this submenu. The **New SuperOffice email** dialog opens.

    > [!NOTE]
    > This presupposes that you are logged on to SuperOffice CRM. If not, the menu will only contain one item: **Populate**. If you click **Populate**, you will be asked if you want to start SuperOffice CRM. If you accept, the submenu is populated.

3. In the **Subject** field, enter the text that you would like to be the subject of the email. This will also be shown in the Activities section tab of SuperOffice CRM.

4. In the Company field, you may search for a company by starting to type the company name and then select from the matches that appear.

5. In the Contact field, you may use the dropdown to select one of the contacts belonging to the company you selected in the previous step. You can also search by starting to type the contact name.

6. If you would like to link the email to a certain project, you may select the project in the Project field.

7. If you would like to link the email to a certain sale, you may select the sale in the Sale field.

8. In the Type dropdown, you may select one of the available email templates.

9. In the **Visible for** field, click the arrow next to the field. A list is displayed allowing you to choose if the document should be visible to all users, private (visible only to the user defined as owner) or visible to all users in the user group that the owner belongs to.

    > [!NOTE]
    > The **Visible for** field is only available if this right is assigned to you in Settings and maintenance.

10. Click **OK** in the **New SuperOffice email** dialog. A new email window opens.

11. In the **To** field, enter the email address of any other recipients you would like to add. You can also use the **Select recipients** dialog (see [Selecting recipients][2]).

12. Write the message.

13. Add any attachments you would like to include. You can also [add documents from SuperOffice CRM][3].

14. Click **Send** to send the message to the specified recipient(s).

## Buttons in the email window

| Button | Function | Description |Read more |
|:-:|---|---|---|
| ![icon][img1],![icon][img2] | Archive is ON / Archive is OFF | Indicates if the email will be archived when sent. Click the button to enable or disable this setting. The default setting is specified in the **Archive options** pane of the **SuperOffice CRM options** dialog. | [Archive options][5] |
| ![icon][img3] | Add recipient | Opens the **Select recipients** dialog. | [Select recipients][2] |
| ![icon][img4] | Attach document | Opens the **Include attachments** dialog. | [Add SuperOffice documents as attachments][3] |
| ![icon][img5] | | Click the arrow to the right of the **SuperOffice** button to open the **SuperOffice CRM options** dialog. | [SuperOffice CRM options dialog][5] |

## Related content

* [Create email templates][3]

<!-- Referenced links -->
[2]: select-recipients.md
[3]: add-attachment.md
[5]: settings.md

<!-- referenced images -->
[img1]: media/archive-is-on.png
[img2]: media/archive-is-off.png
[img3]: media/add-recipient.png
[img4]: media/add-document.png
[img5]: media/superoffice-button.png
