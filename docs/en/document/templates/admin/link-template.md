---
uid: help-en-document-template-link
title: Link a document template
description: In this how-to guide, you will learn how to add a new document template to SuperOffice CRM.
keywords: document, template
author: Bergfrid Dias
date: 07.11.2024
version: 10
topic: howto
language: en
audience: settings
audience_tooltip: Settings and maintenance
---

# Link a document template

If you create new templates or change a standard template and saved it with a different file name, you must link the templates to SuperOffice CRM, so that the program can find them when you write documents using SuperOffice CRM.

Templates are displayed as items in the **Document - Template** list and you link a template to SuperOffice CRM by entering it as an item in the list.

Watch this video or follow the guided steps below to learn how you can add a document template (video length - 2:30):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/FnhcmjP-TgE]

## Steps

1. In Settings and maintenance, select **Lists** in the Navigator.

1. Choose the **Items** tab, click the arrow, and select **Document - Template**.

1. Click the **Add** button ![icon][img2] below the **Items** list.

1. Enter the required name of the item in the **Name** field.

1. Optionally, choose where to store the document template, in the **Store template in** list.

1. You now have two options:

    * Upload a new document template:

        1. Click **Copy an existing document template file**.
        2. Click the **Copy template** list.
        3. Select the required template from the list.

    * Copy an existing template in SuperOffice:

        1. Select **Upload a new document template from disk**.
        2. Click the **Upload** button.
        3. Click **Upload file** in the **Upload file** dialog.
        4. Select the required file and click **Open**. The name of the file is displayed in the **Edit list item** dialog.

1. Click **Save** in the **Edit list item** dialog. The dialog is updated.

1. Optionally, change the template name and, if required, click **Edit** to edit the template file itself.

1. Enter the required information in the **Details** and **Languages** tabs.

1. Click **Save**. The template is added as a separate item in the **Items** list. Repeat this procedure to add more templates.

## Details tab

Enter the following information in the **Details** tab:

1. In the **Direction** field, specify if the template is outgoing or incoming, by clicking the ![icon][img1] arrow and choosing from the list box.

2. In the **Document type** field, choose either **Document** or **Fax** as the template type.

3. In the **Document stored in** field, you can choose to save the document somewhere other than the default option.

4. In the **Intention** field, click ![icon][img1] and select one of the predefined options from the list. These items are used in connection with status monitors (requires a licence for [Sales Intelligence][4]).

    > [!TIP]
    > You can create new options in addition to the predefined ones by adding them to the **Follow-up - Intention** list in Settings and maintenance.

5. Onsite: Check the **Publish** option if you want it to be possible to specify, in the Document screen, that the document template in question should be made available to external users.

6. Onsite: Check the **Save to database** option to specify that documents that you create using this template are saved in the document database. If you checked this option, the document is displayed on the **Activities** section tab. If not, the document is not displayed in SuperOffice after you created it and you cannot access it from the program.

7. Check the **Quote document type** option if the document should be available as a [quote template][2] or order confirmation template. You select the quote document type in the list below.

8. Specify the default setting for the **Our reference (default)** field using the template variables, for example *auth* for the sender's first and last names.

9. Optionally, type in a description of the template in the **Description** field.

    > [!TIP]
    > You can open the template to edit it directly by clicking the **Edit** button at the top of the **Edit list item** dialog.

## Languages tab

Here you can add translated versions of the document template.

1. Click **Add**.
2. In the **Edit list item** dialog, select the language you require in the **Add language** list.
3. Add the translated document template as described above.
4. Click **Add**. The language is listed in the **Languages** tab.
5. Repeat the steps above to add additional languages.

## Related topics

* [How do I upload and use document templates?][3] - FAQ
* [Replace existing template][1]

<!-- Referenced links -->
[1]: update-template.md
[2]: ../../../../en/document/templates/quote/index.md
[3]: https://community.superoffice.com/en/support-faqs/faq/how-do-i-upload-and-use-document-templates-in-superoffice-crm/
[4]: ../../../sale/saint/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/arrow-down.png
[img2]: ../../../../media/icons/btn-add.png
