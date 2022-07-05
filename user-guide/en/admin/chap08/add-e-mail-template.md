---
uid: help-en-add-e-mail-template
title: Add e-mail template
description: Add e-mail template
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Add an e-mail template

E-mail templates can be used when creating new e-mails in the SuperOffice inbox, and when sending quotes, order confirmations and privacy confirmations.

Templates are displayed as items in the **E-mail - Template** list and you can add new templates to SuperOffice CRM by entering it as an item in the list.

To complete the fields in the **Edit list item** dialog when the items are e-mail templates:

1. Enter the required name of the item in the **Template name** field.

2. In the **Template type** field, select the type of template you are creating. Select **Normal** if you want the template to be available in **Inbox**. You also have the option to make the template available as a quote template, an [order confirmation template](Adding-items-to-the-Sale-Sales-type-(for-stages)-list.md), or a [privacy confirmation template](Privacy-Source-add.md).

3. If you wish, you can choose where to store the document template, in the **Store template in** list.

4. You now have three options:

    * **Create a new e-mail template**
    * **Copy an existing e-mail template file**.
        1. Click the **Copy template** list.
        2. Select the required template from the list.
    * **Upload a new e-mail template from disk (.md/.md)**
        1. Click the **Upload** button.
        2. Click **Upload file** in the **Upload file** dialog.
        3. Select the required file and click **Open**. The name of the file will be displayed in the **Edit list item** dialog.

5. Click **Save** in the **Edit list item** dialog. The dialog is updated.

6. Optional: Edit the template name, if required.

7. Click **Edit** to edit the template file itself. If you have created a new e-mail template, you need to add content to the template.

8. Enter the required information in the **Details** and **Languages** tabs. For more information, see below.

9. Click **Save** to save your changes in Settings and maintenance. The template is added as a separate item in the **Items** list. Repeat this procedure to add more templates.

## Details tab

Enter the following information in the **Details** tab:

1. (optional) Edit the name of the template in the **Name** field. You can also add the template name in other languages by clicking ![icon][img1] (see [Translation](../Translate-fields.md)).

2. Enter the title of the e-mail in the **Subject** field. You can also add the subject in other languages by clicking ![icon][img1] (see [Translation](../Translate-fields.md)).

3. Select **Use signature in new e-mail** to add your signature to new e-mails. If you do not have a personal signature, the system signature will be used.

4. Select **Show e-mail dialog** to display the **New e-mail** dialog when you create a new e-mail based on this template. In this dialog you can enter data such as company, contact, project etc, which is needed if the e-mail template contains template variables.

5. Optionally, type in a description of the template in the **Description** field.

6. In the **Direction** field, specify whether the template will be outgoing or incoming, by clicking the arrow (![icon](../media/pil-ned.bmp) ) and choosing from the list box. Select **Outgoing** if you want the template to be available in **Inbox**.

7. In the **Intention** field, click the arrow (![icon](../media/pil-ned.bmp) ) and select one of the predefined options from the list box. These items are used in connection with status monitors in SuperOffice CRM (requires a licence for [Sales Intelligence](../chap06/Status-monitor.md)).

    > [!TIP]
    > You can create new options in addition to the predefined ones by adding them to the **Follow-up - Intention** list in Settings and maintenance.

8. In the **Document stored in** field, you can choose to save the document somewhere other than the default option.

9. Specify the default setting for the **Our reference** field using the template variables, for example *auth* for the sender’s first and last names (see [Template variables](../Template-variables.md)).

> [!NOTE]
> You can open the template to edit it directly by clicking the **Edit** button at the top of the **Edit list item** dialog. Only htm/html files can be edited directly in this editor. The file type is displayed in the **File name** field in the **Details** tab. Click the **Download** button to download other file types and edit them in the relevant application.

## Languages tab

Here you can add translated versions of the document template. To do this:

1. Click **Add**. The **Edit list item** dialog opens.
2. Select the language you require in the **Add language** list.
3. Add the translated document template as described above.
4. Click **Add**. The language is listed in the **Languages** tab.
5. Repeat the steps above to add additional languages.

> [!NOTE]
> As described above, you can add translations of the template name and e-mail subject by clicking ![icon][img1] next to the relevant field. See [Translation](../Translate-fields.md).

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: ../../../media/icons/translate.png