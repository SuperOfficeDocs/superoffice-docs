---
uid: help-en-add-email-template
title: Add email template
description: Add email template
author: SuperOffice RnD
date: 06.29.2022
keywords: Settings and maintenance
topic: help
language: en
---

# Add an email template

Email templates can be used when creating new emails in the SuperOffice inbox, and when sending quotes, order confirmations and privacy confirmations.

Templates are displayed as items in the **Email - Template** list and you can add new templates to SuperOffice CRM by entering it as an item in the list.

[!include[Edit list item](includes/edit-list-item.md)] when the items are email templates:

1. Enter the required name of the item in the **Template name** field.

2. In the **Template type** field, select the type of template you are creating. Select **Normal** if you want the template to be available in **Inbox**. You can also make the template available as a quote template, an [order confirmation template][3], or a [privacy confirmation template][4].

3. If you wish, you can choose where to store the document template, in the **Store template in** list.

4. You now have three options:

    * **Create a new email template**
    * **Copy an existing email template file**.
        1. Click the **Copy template** list.
        2. Select the required template from the list.
    * **Upload a new email template from disk (.md/.md)**
        1. Click the **Upload** button.
        2. Click **Upload file** in the **Upload file** dialog.
        3. Select the required file and click **Open**. The name of the file is displayed in the **Edit list item** dialog.

5. Click **Save** in the **Edit list item** dialog. The dialog is updated.

6. Optional: Edit the template name, if required.

7. Click **Edit** to edit the template file itself. If you created a new email template, add content to the template.

8. Enter the required information in the **Details** and **Languages** tabs.

9. Click **Save**. The template is added as a separate item in the **Items** list. Repeat this procedure to add more templates.

## Details tab

Enter the following information in the **Details** tab:

1. (optional) Edit the name of the template in the **Name** field. You can also [add the template name in other languages][1] by clicking <i class="ph ph-translate" aria-label="Translate"></i>.

2. Enter the title of the email in the **Subject** field. You can also [add the subject in other languages][1] by clicking <i class="ph ph-translate" aria-label="Translate"></i>.

3. Select **Use signature in new email** to add your signature to new emails. If you do not have a personal signature, the system signature is used.

4. Select **Show email dialog** to display the **New email** dialog when you create a new email based on this template. In this dialog you can enter data such as company, contact, and project, which is needed if the email template contains template variables.

5. Optionally, type in a description of the template in the **Description** field.

6. In the **Direction** field, specify if the template is outgoing or incoming by clicking <i class="ph ph-caret-down" aria-label="Chevron"></i> and choosing from the list box. Select **Outgoing** if you want the template to be available in **Inbox**.

7. In the **Intention** field, click <i class="ph ph-caret-down" aria-label="Chevron"></i> and select one of the predefined options from the list box. These items are used in connection with status monitors (requires a licence for [Sales Intelligence][5]).

    > [!TIP]
    > You can create new options in addition to the predefined ones by adding them to the **Follow-up - Intention** list in Settings and maintenance.

8. In the **Document stored in** field, you can choose to save the document somewhere other than the default option.

9. Specify the default setting for the **Our reference** field using the [template variables][2], for example *auth* for the sender's first and last names.

> [!NOTE]
> You can open the template to edit it directly by clicking the **Edit** button at the top of the **Edit list item** dialog. Only htm/html files can be edited directly in this editor. The file type is displayed in the **File name** field in the **Details** tab. Click the **Download** button to download other file types and edit them in the relevant application.

## Languages tab

Here you can add translated versions of the document template.

1. Click **Add**.
2. In the **Edit list item** dialog, select the language you require from the **Add language** list.
3. Add the translated document template as described above.
4. Click **Add**. The language is listed in the **Languages** tab.
5. Repeat the steps above to add additional languages.

> [!TIP]
> Click <i class="ph ph-translate" aria-label="Translate"></i> next to the relevant field to [add translations][1] of the template name and email subject.

<!-- Referenced links -->
[1]: ../../../globalization-and-localization/learn/translate-fields.md
[2]: ../../../document/templates/learn/template-variables.md
[3]: ../../../sale/admin/sale-type.md
[4]: privacy-source-add.md
[5]: ../../../saint/learn/index.md
