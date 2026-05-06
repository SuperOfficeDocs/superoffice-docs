---
uid: help-en-service-mailbox-create
title: Create mailboxes
description: Create mailboxes
keywords: email
author: digitaldiina
date: 05.04.2026
version: 11.13
content_type: howto
category: email
topic: Service mailbox
license: serviceessentials
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: en
---

# Create mailboxes

You can create a mailbox to use for importing email into SuperOffice Service. Before you do that, you must create a mailbox on the mail server that the email is delivered to.

> [!NOTE]
> Before you set up a mailbox, make sure that there are no old messages in this mailbox on the mail server. SuperOffice Service will import all mail in the mailbox and you risk sending auto-replies to all contacts who have sent email to this address. To import these old emails, you should disable the auto-reply function. Above all, this concerns the **Do not auto-reply** option in the **Mailbox properties** screen and the **Do not send email to new contacts** option in the **Settings** tab in the **System** screen in SuperOffice Service.

## Steps

1. [!include[Go to email](includes/goto-email.md)]

1. Click **New mailbox**. The **Mailbox properties** screen appears, with the **Properties** tab open.

1. In the **Address** field, enter the name without @domain.xx, and press **TAB** to add the CRM Online settings to the email address.

    > [!NOTE]
    > Friendly email address can be added to the address by adding ("friendly name") at the end of the email address. Example: `<info@company.com> (Customer Ltd.)`.

1. Select category, priority, and request type:

    * In the **Category** list box, select the category the messages in this mailbox belong to.

    * In the **Priority** list box, select the priority to give requests from this mailbox.

    * In the **Request type** list box, select the type the messages in this mailbox belong to.

1. [!include[Set customer language](includes/step-set-language.md)]

1. Set reply:

    1. Check **Do not auto-reply** to disable the auto-reply function. See the note at the top of this topic.

    1. In the **Email fields** field, you can enter a comma-separated list of email fields (headers) to be displayed in the request message, for example, To and Cc.

    1. In the **Reply template for reply to contact** list box, select which reply template to use when auto-replying to the customer.

    1. **Suggest FAQ entries from**: If checked, the system will suggest FAQ entries based on the text in incoming emails. The suggested FAQ entries are available as template variables and can therefore be reused in the selected reply template. You can also specify which branch of the FAQ tree to search in, by specifying the folder you want.

1. **Import auto-replies and system messages**: By default, emails that contain out of office messages, system messages and other irrelevant messages are not imported. If you do want to import such emails, you can check this option.

1. **AI services**: Here you can select the following options for categorization and text analysis using [AI][4]:

    * **Use AI to suggest categories**: Select this option to [let the AI suggest a category][3] for requests based on the content of email messages.
    * **Use text analysis**: Select this option to [let the AI analyze the text][2] in email messages to detect language (for translation) and perform sentiment analysis.

1. Click **OK**. The mailbox is created.

## Related content

* [Delete mailboxes][1]
* [Email in Service and Marketing][5]
* [Create mailbox (onsite)][6]

<!-- Referenced links -->
[1]: delete-mailbox.md
[2]: ../../../ai/learn/text-analysis.md
[3]: ../../../ai/learn/categorization.md
[4]: ../../../ai/learn/index.md
[5]: ../../../../en/online/mail-services/curl/index.md
[6]: https://help.superoffice.com/docs/11/en/email/admin/mailbox/create-mailbox.html
