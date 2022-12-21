---
uid: help-en-reply-template-create
title: Create reply templates
description: Create reply templates
author: SuperOffice RnD
so.date: 06.29.2022
keywords: request
so.topic: howto
language: en
---

# Create reply template

1. Select **Knowledge Base** > **Reply templates**.

2. Go to the folder you want to put the reply template in. If it does not yet exist, you can [create a new folder][2].

3. Click the **New reply template** button. This takes you to the **Properties** tab in the **Reply template properties** screen.

4. At the top of this screen you enter the following:

    * **Name**: Enter a descriptive name for the reply template.
    * **Description**: Add a short description of the contents of the reply template.
    * **Folder**: By default, the name of the selected folder. You can select a different folder here.
    * **Access**: Here you determine who is to have access to read and edit the reply template.

5. Select the **(Unspecified language)** tab.

6. In the **Properties** tab, enter the following:
    * **Language**: In this list, select which language the reply template is in. The list box contains the languages registered under ![icon][img2] > **Customer languages**.
    * **Default**: Check here if you want this to be the default language for this reply template.
    * **Subject**: Enter the title of the reply template. This is normally inserted into the **Subject** field when the reply template is used for an email.
    * **Message headers**: Here you can add predefined content to be displayed in the message header, for example, the **To** and **Subject** fields, in an email. This function is only used in special cases.

7. In the **Plain text** tab, enter the following information:

    * **Include plain text**: When you create an HTML version, it is always a good idea to also create a plain text version for email programs that do not support HTML. The email program then automatically selects the correct format. If you do not check this option, the text underneath is ignored. It is however saved, so you can choose to include it later.

    > [!NOTE]
    > If you include both plain text and HTML text, the receiving email program chooses the "best" version, which will normally be HTML. Remember that messages sent without a plain text version are readable only by email programs that support HTML.

    * In the large field in the centre of the screen, enter the reply template content itself. It is always this text that is used when you [add reply templates to messages][4].
    * **Spell check**: Click here to spell check the message in the language specified in the **Language** list.

8. In the **HTML text** tab, enter the following information:

    * **Include HTML text**: Check this option to include the text underneath in an HTML version of the email. This is used for customers with email programs that can read HTML (such as Outlook). Your message will often come across more clearly if you send the email as HTML, since you can use images and colors in the text.
    * In the large field in the middle of the screen, enter the HTML-formatted text you want to include in the message to the customer. Remember that images linked to here must be on a server accessible by recipients of the email. For example, you can add images that previously uploaded to **External documents**.

9. In the **SMS text** tab, you can add reply template text for sending by SMS. Enter the following information here:

    * **SMS text**: In this field you enter the reply template body text itself.
    * **Number of chars**: Here you can keep track of how many characters you have entered.

10. In the **Attachments** tab, you can add attachments to include in the reply template.

    <details><summary>How?</summary>
    1. Click **Choose files**.
    2. Browse to the document you require in the dialog box that appears.
    3. Click **Add** to add the attachment.
    4. Repeat this procedure to add more attachments.

    > [!TIP]
    > You can delete an attachment by clicking **Delete** ( ![icon][img1] ) to the right of the row.

    </details>

11. Click **OK** to save the reply template. The **(Unspecified language)** tab changes to the selected language. Click **Back** to go back to the folder structure for reply templates. It is now available for use in [responding to customer enquiries][4].

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

## <a id="faq" />Automatic FAQ reply

SuperOffice Service comes with a set of reply templates. Among these reply templates you will find "Example of an automated FAQ response". This reply template contains an example of automation of replies to the customer, in the **HTML text** tab.

Based on the customer's request, the system searches for corresponding words (including key words) in FAQ entries in SuperOffice Service. Based on the degree of correlation between these, suggested FAQs that could help the customer are included in the reply template that is automatically sent to the customer to confirm receipt of the request.

You can select the degree of correlation between the request from the customer and the FAQ entries in the field **Minimum score for FAQ search result (in percent)** in ![icon][img2] **System settings > System > Settings**.

## What would you like to do now?

* [Create new language version of reply template][5]
* [Edit reply templates][6]
* [Copy reply templates][7]

<!-- Referenced links -->
[1]: ../../../request/learn/category/index.md
[2]: manage-folders.md
[4]: ../../../request/learn/howto/reply.md
[5]: new-language.md
[6]: edit.md
[7]: copy.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/delete-red.png
[img2]: ../../../../media/icons/settings-small.png
