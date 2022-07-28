---
uid: help-en-admin-listfilters-listfilters-newfilter
title: admin listFilters listFilters newFilter
description: admin listFilters listFilters newFilter
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Create mailboxes

You can create a mailbox to use for importing e-mail into SuperOffice Service. Before you do that, you need to create a mailbox on the mail server that the e-mail is delivered to.

> [!NOTE]
> Before you set up a mailbox, you need to make sure that there are no old messages in this mailbox on the mail server. SuperOffice Service will import all mail in the mailbox and you risk sending auto-replies to all contacts who have sent e-mail to this address. If you want to import these old e-mails, you should disable the auto-reply function. Above all, this concerns the **Do not auto-reply** option in the **Mailbox properties** screen and the **Do not send e-mail to new contacts** option in the **Settings** tab in the **System** screen in SuperOffice Service.

To create a new mailbox:

1. Click the **Requests** button in the navigator and select the **E-mail** tab.
2. Select the **Mailboxes** tab.
3. Click **New mailbox**. The **Mailbox properties** screen appears, with the **Properties** tab open.
4. Fill in the **Address** field as follows:
    * <!-- onsite-->If you use SuperOffice onsite: In the **Address** field, enter the e-mail address you want to use for the mailbox.

        > [!NOTE]
        > Set up forwarding to this mailbox address if you are going to use your company's e-mail address (for example info@company.com). Use **Forwarding address** in the **Mailboxes** screen.

    * <!-- online --> If you use SuperOffice online: In the **Address** field, enter the name without @domain.xx, and press **TAB** to add the CRM Online settings to the e-mail address.

        > [!NOTE]
        > Friendly e-mail address can be added to the address by adding ("friendly name") at the end of the e-mail address.Example: info@company.com (Customer Ltd.).

5. <!-- onsite--> In the **Protocol** list box, select which protocol to use to communicate with the mail server. Some of the protocols may require further configuration.
6. <!-- onsite--> In the **E-mail server** field, enter the server's host name.
7. <!-- onsite--> In the **User name** and **Password** fields, enter the user name and password for the mailbox.
8. <!-- onsite--> In the **Folder** field, enter the folder name for the mailbox on the server.
9. <!-- onsite--> In the **Port** field, you can change the proposed default port for the selected protocol.
10. In the **Category** list box, select to which category the messages in this mailbox should belong.
11. In the **Priority** list box, select which priority that requests from this mailbox should be given.
12. <!-- onsite--> In the **Interval** list box, select how often SuperOffice Service check for messages in this mailbox.
13. In the **Customer language** list box, specify which language is to be used for the customers who send messages to this mailbox. For more details about this, see [Customer languages][4].
14. Check **Do not auto-reply** to disable the auto-reply function. See the note at the top of this topic.
15. In the **E-mail fields** field, you can enter a comma-separated list of e-mail fields (headers) to be displayed in the request message, for example, To and Cc.
16. In the **Reply template for reply to contact** list box, select which reply template to use when auto-replying to the customer.
17. **Suggest FAQ entries from**: If you check here, the system will suggest FAQ entries based on the text in incoming e-mails. The suggested FAQ entries are available as template variables and can therefore be reused in the selected reply template. You can also specify which branch of the FAQ tree to search in, by specifying the folder you want.
18. <!-- onsite--> Go to the **Alias** tab. Here you can enter any e-mail alias for a mailbox (e.g. if sales@company.com and sale@company.com go to the same mailbox). You add an alias by entering an e-mail address and then clicking ![icon][img1].
19. **Import auto-replies and system messages**: By default, e-mails that contain out of office messages, system messages and other irrelevant messages are not imported. If you do want to import such e-mails, you can check this option.
20. <!-- online--> **AI services**: Here you can select the following options for categorization and text analysis using AI (see [AI services](../ai/index.md)):
    * **Use AI to suggest categories**: Select this option to let the AI suggest a category for requests based on the content of e-mail messages. See [Categorization][3].
    * **Use text analysis**: Select this option to let the AI analyse the text in e-mail messages to detect language (for translation) and perform sentiment analysis. See [Text analysis][2].
21. Click **OK**. The mailbox is created.

## What would you like to do now?

* [Delete mailboxes][1]

<!-- Referenced links -->
[1]: listfilters.deletemailbox.md
[2]: ../../ai/text-analysis.md
[3]: ../../ai/categorization.md
[4]: ../../options/custlangs/index.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/btn-add.png
