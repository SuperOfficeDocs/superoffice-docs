---
uid: help-en-adding-template-web
title: Adding a template web
description: Adding a template web
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Add a document template

Before you can use templates you have created, you need to link them to SuperOffice CRM. Once you have linked the templates, it is very easy to write letters, faxes and other documents you have created templates using the **Document** function in SuperOffice CRM. More information about the **Document** function is available in the user help.

[Do you want to replace existing template][1]

If you have created new templates or have changed a standard template and saved it with a different file name, you must link the templates to SuperOffice CRM, so that the program can find them when you write documents using SuperOffice CRM.

Templates are displayed as items in the **Document - Template** list and you link a template to SuperOffice CRM by entering it as an item in the list. For more details, see below.

[!include[Edit list item](../../includes/edit-list-item.md)] when the items are document templates:

1. Enter the required name of the item in the **Name** field.
2. If you wish, you can choose where to store the document template, in the **Store template in** list.
3. You now have two options:

    * <details><summary>Upload a new document template</summary>

    1. Click **Copy an existing document template file**.
    2. Click the **Copy template** list.
    3. Select the required template from the list.

    </details>

    * <details><summary>Copy an existing template in SuperOffice</summary>

    1. Select **Upload a new document template from disk**.
    2. Click the **Upload** button.
    3. Click **Upload file** in the **Upload file** dialog.
    4. Select the required file and click **Open**. The name of the file will be displayed in the **Edit list item** dialog.

    </details>

4. Click **Save** in the **Edit list item** dialog. The dialog is updated.
5. Optional: Edit the template name, if required, and click **Edit** to edit the template file itself.
6. Enter the required information in the **Details** and **Languages** tabs. For more information, see below.
7. Click **Save**. The template is added as a separate item in the **Items** list. Repeat this procedure to add more templates.

## Details tab

Enter the following information in the **Details** tab:

1. In the **Direction** field, specify whether the template will be outgoing or incoming, by clicking the arrow (![icon][img1] ) and choosing from the list box.

2. In the **Document type** field, specify the type of template by clicking the arrow (![icon][img1] ). You can choose from **Document** and **Fax**.

3. In the **Document stored in** field, you can choose to save the document somewhere other than the default option.

4. In the **Intention** field, click the arrow (![icon][img1] ) and select one of the predefined options from the list box. These items are used in connection with status monitors in SuperOffice CRM (requires a licence for [Sales Intelligence][4]).

    > [!TIP]
    >You can create new options in addition to the predefined ones by adding them to the **Follow-up - Intention** list in Settings and maintenance.

5. <!-- onsite-->Check the **Publish** option if you want it to be possible to specify, in the **Document** dialog in SuperOffice CRM, that the document template in question should be made available to external users.

6. <!-- onsite-->Check the **Save to database** option to specify that documents that you create using this template will be saved in the document database. If you checked this option, the document is displayed on the **Activities** section tab in SuperOffice CRM. If not, the document is not displayed in SuperOffice CRM once you have created it and you cannot access it from the program.

7. Check the **Quote document type** option if the document is to be available as a quote template or order confirmation template. You select the quote document type in the list below.

    [!include[Link to quote template docs](../includes/learn-quote-templates.md)]

8. Specify the default setting for the **Our reference (default)** field using the template variables, for example *auth* for the sender’s first and last names (see [Template variables][2]).

9. Optionally, type in a description of the template in the **Description** field.

    > [!TIP]
    > You can open the template to edit it directly by clicking the **Edit** button at the top of the **Edit list item** dialog.

## Languages tab

Here you can add translated versions of the document template. [!include[To do this](../../includes/to-do-this.md)]

1. Click **Add**. The **Edit list item** dialog opens.
2. Select the language you require in the **Add language** list.
3. Add the translated document template as described above.
4. Click **Add**. The language is listed in the **Languages** tab.
5. Repeat the steps above to add additional languages.

<!-- Referenced links -->
[2]: ../../diary/template-variables.md
[1]: replace-existing-template.md
[4]: ../../sale/saint/index.md

<!-- Referenced images -->
[img1]: ../../../media/icons/admin/pil-ned.bmp
