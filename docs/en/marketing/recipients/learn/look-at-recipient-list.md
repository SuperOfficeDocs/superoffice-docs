---
uid: help-en-mailing-recipient-list
title: Work with the recipient list after the mailing
description: Work with the recipient list after the mailing
keywords: Marketing, recipient
author: SuperOffice Product and Engineering
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: mailing
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: en
---

# Look at recipient list after the mailing

After your mailing is sent, it is always exciting to see how well your mailing performed. It is also a great opportunity to check and improve the quality of the information registered in your database. The number of [bounced emails][3], especially, is a key indicator.

After the mailing is sent, SuperOffice Marketing collects data about the status of each sent email. In the **Recipients** tab, you can view the status for each recipient of the mailing. You can also filter the list and export the results to selections and projects for further processing.

![You can see the status of the mailing in the Status field -screenshot][img4]

## Steps

1. Click the mailing in the **Mailings** tab.

2. In the **View mailing** screen, click the **Recipients** tab.

    The list shows the 100 first recipients. Click <i class="ph ph-arrow-right" aria-label="Arrow right"></i> to show the next 100.

3. [Filter the list](#filters) by using the checkboxes at the bottom of the list.

    By default all filters are active to show all recipients. Uncheck a filter checkbox to deactivate the filter. Several filters can be combined.

4. Use the checkboxes in the left column to select all or specific recipients.

5. Click the **Actions** menu button. Here you have the following options:
    * Export the selected recipients to an Excel, HTML, or text file.
    * [Add the selected recipients to a new or existing selection or project](#add-recipients).
    * Resend the mailing to the selected recipients.

6. Click **Close** to close the **View mailing** screen.

If the status is **Ready to send**, you do not have to do anything. SuperOffice will send your mailing to the recipients. The status change to **Sent** after this is done.

## Filters

* **Sent**: Activate this filter to show all recipients the mailing was sent to.

* **Bounced**: Activate this filter to show all recipients for whom the [mailing was returned undelivered][3]. This may be due to email address errors, spam filters, Internet problems or inboxes being full.

* **Read by recipient**: Activate this filter to show all recipients who opened/read the mailing.

* **Ready to send**: Activate this filter to show all recipients to whom the mailing has not been sent yet.

* **Blocked**: Activate this filter to show the following recipients:

  * Recipient who have not given their consent to being contacted
  * Duplicate recipients
  * [Recipients without a subscription][5]

**Recipient complained**: Activate this filter to show recipients who [reported the mailing as spam/junk mail][4].

If the status is **Ready to send**, you do not have to do anything. SuperOffice will send your mailing to the recipients. The status will be changed to **Sent** after this is done.

## <a id="add-recipients"></a>Add recipients to selections or projects

Using the **Action** button you can add recipients and clickers to a selection or project.

> [!NOTE]
> Only contacts already registered in the SuperOffice database will be added to the selection or project. A contact icon (<i class="ph ph-user-circle" aria-hidden="true"></i>) in the **Type** column indicates that a contact is registered in the SuperOffice database. Recipients imported from external lists will typically not be registered.

### Add clickers to a new selection or project

1. Select the relevant contacts in the list.
2. Click the **Action** button.
3. Click **Add to existing selection** or **Add to existing project**.
4. Start writing the name of the selection or project to search.
5. Click the selection or project in the list.
6. Click **OK**.

### Add clickers to an existing selection or project

1. Select the relevant contacts in the list.
2. Click the **Action** menu button.
3. Click **Add to new selection** or **Add to new project**.
4. Write the name of the new selection or project.
5. Click **OK**.

## Related content

* [Work with tracked links after the mailing][1]

<!-- Referenced links -->
[1]: ../../tracked-links/learn/explore-clicks.md
[3]: manage-bounces.md
[4]: spam-complaints.md
[5]: manage-email-subscriptions.md

<!-- Referenced images -->
[img4]: ../../../../media/loc/en/marketing/recipients-tab-status.png
