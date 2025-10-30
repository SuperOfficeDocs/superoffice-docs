---
uid: help-en-add-email-template
title: Add email template
description: Add email template
keywords: Email - Template list, email template
author: digitaldiina
date: 10.29.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from:
  - /en/admin/lists/learn/email-template
  - /en/admin/lists/learn/add-email-template
  - /en/admin/lists/learn/create-email-template
  - /en/email/admin/index
language: en
---

# Add email template

It is important for an organization's profile that emails have a distinctive and consistent appearance. This means that all emails sent out by the organization should use the same fonts, formatting, logos and so on. By creating email templates that are customized to your organization you ensure that your contacts can easily recognize your correspondence. Email templates are also used when sending quotes, order confirmations and privacy confirmations.

SuperOffice CRM is supplied with several standard templates that you can use immediately after installing the program.

You can also create your own templates. You do this by entering [template variables][2] in the email templates, which then retrieve information from corresponding fields in SuperOffice CRM when you write an email using a template you created.

Templates are displayed as items in the **Email - Template** list and you can add new templates to SuperOffice CRM by entering it as an item in the list.

## Steps

1. Select <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lists** in the Navigator.

1. Select **Email - Template** from the dropdown menu. The **Items** tab displays all existing resources.

1. Click **Add** to open the **Edit list item** dialog.

1. Enter the required name of the item in the **Template name** field.

1. In the **Template type** field, select the type of template you are creating. Select **Normal** if you want the template to be available in **Inbox**. You can also make the template available as a quote template, an [order confirmation template][3], or a [privacy confirmation template][4].

1. If you wish, you can choose where to store the document template, in the **Store template in** list.

1. You now have three options:

    * **Create a new email template**
    * **Copy an existing email template file**.
        1. Click the **Copy template** list.
        2. Select the required template from the list.
    * **Upload a new email template from disk (.md/.md)**
        1. Click the **Upload** button.
        2. Click **Upload file** in the **Upload file** dialog.
        3. Select the required file and click **Open**. The name of the file is displayed in the **Edit list item** dialog.

1. Click **Save** in the **Edit list item** dialog. The dialog is updated.

1. Optional: Edit the template name, if required.

1. Click **Edit** to edit the template file itself. If you created a new email template, add content to the template.

1. Enter the required information in the **Details** and **Languages** tabs.

1. Click **Save**. The template is added as a separate item in the **Items** list. Repeat this procedure to add more templates.

1. Make the email template available to the requisite user groups. See [User group filtering][7].

## Details tab

Enter the following information in the **Details** tab:

1. (optional) Edit the name of the template in the **Name** field. You can also [add the template name in other languages][1] by clicking <i class="ph ph-translate" aria-label="Translate"></i>.

1. Enter the title of the email in the **Subject** field. You can also [add the subject in other languages][1] by clicking <i class="ph ph-translate" aria-label="Translate"></i>.

1. Select **Use signature in new email** to add your signature to new emails. If you do not have a personal signature, the system signature is used.

1. Select **Show email dialog** to display the **New email** dialog when you create a new email based on this template. In this dialog you can enter data such as company, contact, and project, which is needed if the email template contains template variables.

1. Optionally, type in a description of the template in the **Description** field.

1. In the **Direction** field, specify if the template is outgoing or incoming by clicking <i class="ph ph-caret-down" aria-label="Chevron"></i> and choosing from the list box. Select **Outgoing** if you want the template to be available in **Inbox**.

1. In the **Intention** field, click <i class="ph ph-caret-down" aria-label="Chevron"></i> and select one of the predefined options from the list box. These items are used in connection with status monitors (requires a licence for [Sales Intelligence][5]).

    > [!TIP]
    > You can create new options in addition to the predefined ones by adding them to the **Follow-up - Intention** list in Settings and maintenance.

1. In the **Document stored in** field, you can choose to save the document somewhere other than the default option.

1. Specify the default setting for the **Our reference** field using the [template variables][2], for example *auth* for the sender's first and last names.

> [!NOTE]
> You can open the template to edit it directly by clicking the **Edit** button at the top of the **Edit list item** dialog. Only htm/html files can be edited directly in this editor. The file type is displayed in the **File name** field in the **Details** tab. Click the **Download** button to download other file types and edit them in the relevant application.

## Languages tab

Here you can add translated versions of the document template.

1. Click **Add**.
1. In the **Edit list item** dialog, select the language you require from the **Add language** list.
1. Add the translated document template as described above.
1. Click **Add**. The language is listed in the **Languages** tab.
1. Repeat the steps above to add additional languages.

> [!TIP]
> Click <i class="ph ph-translate" aria-label="Translate"></i> next to the relevant field to [add translations][1] of the template name and email subject.

## Related content

* [Quote templates][6]

<!-- Referenced links -->
[1]: ../../localization/learn/translate-fields.md
[2]: ../../document/templates/learn/template-variables.md
[3]: ../../sale/admin/sale-type.md
[4]: ../../security/privacy/admin/add-source.md
[5]: ../../saint/learn/index.md
[6]: ../../document/templates/learn/quote-templates.md
[7]: ../../admin/lists/user-group-filtering.md
