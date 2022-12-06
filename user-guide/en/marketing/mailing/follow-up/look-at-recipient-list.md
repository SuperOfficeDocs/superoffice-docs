---
uid: help-en-mailing-recipient-list
title: Work with the recipient list after the mailing
description: Work with the recipient list after the mailing
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Marketing
so.topic: help
language: en
---

# Look at recipient list after the mailing

1. Click the mailing in the **Mailings** tab.

2. In the **View mailing** screen, click the **Recipients** tab. The list shows the 100 first recipients, and you need to click ![icon][img1] to show the next 100.

3. [Filter the list](#filters) by using the checkboxes at the bottom of the list.

    By default all filters are active to show all recipients. Uncheck a filter checkbox to deactivate the filter. Several filters can be combined.

4. Use the checkboxes in the left column to select all or specific recipients.

5. Click the ![icon][img2] menu button. Here you have the following options:
    * Export the selected recipients to an Excel, HTML, or text file.
    * [Add the selected recipients to a new or existing selection or project](#add-recipients-to-selections-or-projects).
    * Resend the mailing to the selected recipients.

6. Click **Close** to close the **View mailing** screen.

If the status is **Ready to send**, you do not have to do anything. SuperOffice will send your mailing to the recipients. The status will be changed to **Sent** once this is done.

## Filters

 ***Sent**: Activate this filter to show all recipients the mailing was sent to.

* **Bounced**: Activate this filter to show all recipients for whom the [mailing has been returned undelivered][3]. This may be due to email address errors, spam filters, Internet problems or inboxes being full.

  * Temporary problems: delivery delays, email server temporarily unavailable
  * Permanent problems: wrong address, unknown domain. Add the recipients to a new selection and try to find the cause of the problem.

* **Read by recipient**: Activate this filter to show all recipients who have opened/read the mailing.

* **Ready to send**: Activate this filter to show all recipients to whom the mailing has not been sent yet.

* **Blocked**: Activate this filter to show the following recipients:

* Recipient who have not given their consent to being contacted.
* Duplicate recipients.
* Recipients without a subscription.

**Recipient complained**: Activate this filter to show recipients who have reported the mailing as spam/junk mail.

If the status is **Ready to send**, you do not have to do anything. SuperOffice will send your mailing to the recipients. The status will be changed to **Sent** once this is done.

## Add recipients to selections or projects

Using the ![icon][img2] menu button you can add recipients and clickers to a selection or project.

> [!NOTE]
> Only contacts already registered in the SuperOffice database will be added to the selection or project. A contact icon ![icon][img3] in the **Type** column indicates that a contact is registered in the SuperOffice database. Recipients imported from external lists will typically not be registered.

## Add clickers to a new selection or project

[!include[Howto](../../includes/howto-add-person-to-selection-new.md)]

## Add clickers to an existing selection or project

[!include[Howto](../../includes/howto-add-person-to-selection-existing.md)]

<!-- Referenced links -->
[3]: manage-bounces.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/arrow-right.png
[img2]: ../../../../media/icons/btn-menu.png
[img3]: ../../../../../common/icons/nav-contact.png
