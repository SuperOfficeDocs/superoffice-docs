---
uid: help-en-reply-template-create
title: Create reply templates
description: Learn how to create a reply template in this how-to guide.
keywords: create reply template, new reply template, copy reply template, reply template properties, request, reply, template
author: Bergfrid Dias
date: 01.13.2025
version: 10.5
topic: howto
license: serviceessentials
functional_right: knowledge-base
audience: person
audience_tooltip: SuperOffice Service
language: en
---

# Create reply template

A reply template is a ready-made text that can be pasted into a message you are writing to a contact. Using reply templates will save time and allow you to send personalized messages to your contacts.

Reply templates can also include an attachment, which will then be added to the message. Before you send the reply to the contact, you can edit the text and add, or remove attachments.

> [!NOTE]
> You need *Knowledge base* as functional right to create reply templates.

## Steps - create from scratch

1. Go to <i class="ph ph-list" aria-label="Main menu"></i> in the top bar and select **Knowledge base** > **Reply templates**.

1. Go to the folder you want to put the reply template in. If it does not yet exist, you can [create a new folder][2].

1. Click the **New reply template** button.

1. At the top of the **Properties** tab in the **Reply template properties** screen, enter the following:

    * **Name**: A descriptive name for the reply template.
    * **Description**: A short description of the contents of the reply template.
    * **Folder**: By default, the name of the selected folder. You can select a different folder here.
    * **Access**: Here you determine who is to have access to read and edit the reply template.

1. Select the **(Unspecified language)** tab.

1. In the **Properties** tab, enter the following:
    * **Language**: In this list, select which [customer language][7] the reply template is in.
    * **Default**: Check here if you want this to be the default language for this reply template.
    * **Subject**: Enter the title of the reply template. This is normally inserted into the **Subject** field when the reply template is used for an email.
    * **Message headers**: Here you can add predefined content to be displayed in the message header, for example, the **To** and **Subject** fields, in an email. This function is only used in special cases.

1. In the **Plain text** tab, enter the following information:

    * **Include plain text**: When you create an HTML version, it is always a good idea to also create a plain text version for email programs that do not support HTML. The email program then automatically selects the correct format. If you do not check this option, the text below is ignored. It is however saved, so you can choose to include it later.

    > [!NOTE]
    > If you include both plain text and HTML text, the receiving email program chooses the "best" version, which will normally be HTML. Remember that messages sent without a plain text version are readable only by email programs that support HTML.

    * In the large field in the centre of the screen, enter the reply template content itself. It is always this text that is used when you [add reply templates to messages][4].
    * **Spell check**: Starts a spell check of the message in the language specified in the **Language** list.

1. In the **HTML text** tab, enter the following information:

    * **Include HTML text**: Check this option to include the text below in an HTML version of the email. This is used for customers with email programs that can read HTML (such as Outlook). Your message will often come across more clearly if you send the email as HTML, because you can use images and colors in the text.
    * In the large field in the middle of the screen, enter the HTML-formatted text you want to include in the message to the contact. Remember that images linked to here must be on a server accessible by recipients of the email. For example, you can add images that previously uploaded to **External documents**.

1. In the **SMS text** tab, you can add reply template text for sending by SMS. Enter the following information here:

    * **SMS text**: In this field you enter the reply template body text itself.
    * **Number of chars**: Here you can keep track of how many characters you have entered.

1. In the **Attachments** tab, you can add attachments to include in the reply template:

    1. Click **Choose files**.
    2. In the dialog, browse to the document you require.
    3. Click **Add** to add the attachment.
    4. Repeat this procedure to add more attachments.

    > [!TIP]
    > You can delete an attachment by clicking **Delete** to the right of the row.

1. Click **OK** to save the reply template. The **(Unspecified language)** tab changes to the selected language. Click **Back** to go back to the folder structure for reply templates. It is now available for use in [responding to customer enquiries][4].

## <a id="copy"></a>Copy reply template

To create a new reply template based on an existing reply template, you can copy it.

1. Go to <i class="ph ph-list" aria-label="Main menu"></i> in the top bar and select **Knowledge base** > **Reply templates**.
1. Go to the folder where the reply template is located.
1. Click the reply template. This takes you to the **View reply templates** screen.
1. Click the **Copy** button. A copy of the reply template is opened in edit mode.
1. Edit the name of the reply template and make any other changes you want.
1. Click **OK**. The changes are saved.

## Create custom layout for replies using categories

To give each department in your company a custom layout for their correspondence, you can create reply templates with different layouts. Each reply template can be linked to a [category][1] representing a department. All outgoing replies from the categories (departments) are merged with the department specific design.

Apart from the layout/formatting of the reply template, it must contain the following template variables to merge with the reply:

```text
[[IF:message.bodyHtml!=""]]
[[message.bodyHtml]]
[[ELSE]]
[[message.body]]
[[ENDIF]]
```

## <a id="faq"></a>Automatic FAQ reply

SuperOffice Service comes with a set of reply templates. Among these reply templates you will find "Example of an automated FAQ response". This reply template contains an example of automation of replies to the customer, in the **HTML text** tab.

Based on the customer's request, the system searches for corresponding words (including key words) in FAQ entries in SuperOffice Service. Based on the degree of correlation between these, suggested FAQs that could help the customer are included in the reply template that is automatically sent to the customer to confirm receipt of the request.

You can select the degree of correlation between the request from the customer and the FAQ entries in the field **Minimum score for FAQ search result (in percent)** in <i class="ph ph-list" aria-label="Main menu"></i> **System settings** > **System** > **Settings**.

## Related content

* [Create new language version of reply template][5]
* [Edit reply templates][6]

<!-- Referenced links -->
[1]: ../../admin/category/index.md
[4]: ../../learn/reply.md
[2]: manage-folders.md
[5]: new-language.md
[6]: edit.md
[7]: ../../../admin/options/learn/custlang/index.md

<!-- Referenced images -->
