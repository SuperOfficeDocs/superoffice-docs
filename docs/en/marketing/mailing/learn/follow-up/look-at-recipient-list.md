---
uid: help-en-mailing-recipient-list
title: Work with the recipient list after the mailing
description: Work with the recipient list after the mailing
author: SuperOffice RnD
so.date: 02.21.2023
keywords: Marketing, recipient
so.topic: howto
language: en
---

# Look at recipient list after the mailing

After your mailing is sent, it is always exciting to see how well your mailing performed. It is also a great opportunity to check and improve the quality of the information registered in your database. The number of bounced emails, especially, is a key indicator. Learn how to filter your recipients list in this how-to guide.

The first few times you sent out your mailing, you might get a large number of bounced emails. This is good news, because it means you can update every email address that is misspelled or no longer in use.

Updating bounced email addresses will help increase the success rate of your future mailings.

After the mailing is sent, SuperOffice Marketing collects data about the status of each sent email. In the Recipients tab, you can view the status for each recipient of the mailing. You can also filter the list and export the results to selections and projects in SuperOffice CRM for further processing.

![You can see the status of the mailing in the Status field -screenshot][img4]

## Steps

1. Click the mailing in the **Mailings** tab.

2. In the **View mailing** screen, click the **Recipients** tab.

    The list shows the 100 first recipients. Click ![icon][img1] to show the next 100.

3. [Filter the list](#filters) by using the checkboxes at the bottom of the list.

    By default all filters are active to show all recipients. Uncheck a filter checkbox to deactivate the filter. Several filters can be combined.

4. Use the checkboxes in the left column to select all or specific recipients.

5. Click the ![icon][img2] menu button. Here you have the following options:
    * Export the selected recipients to an Excel, HTML, or text file.
    * [Add the selected recipients to a new or existing selection or project](#add-recipients-to-selections-or-projects).
    * Resend the mailing to the selected recipients.

6. Click **Close** to close the **View mailing** screen.

If the status is **Ready to send**, you do not have to do anything. SuperOffice will send your mailing to the recipients. The status change to **Sent** once this is done.

## Filters

* **Sent**: Activate this filter to show all recipients the mailing was sent to.

* **Bounced**: Activate this filter to show all recipients for whom the [mailing was returned undelivered][3]. This may be due to email address errors, spam filters, Internet problems or inboxes being full.

  * Temporary problems: delivery delays, email server temporarily unavailable
  * Permanent problems: wrong address, unknown domain. Add the recipients to a new selection and try to find the cause of the problem.

* **Read by recipient**: Activate this filter to show all recipients who opened/read the mailing.

* **Ready to send**: Activate this filter to show all recipients to whom the mailing has not been sent yet.

* **Blocked**: Activate this filter to show the following recipients:

* Recipient who have not given their consent to being contacted.
* Duplicate recipients.
* Recipients without a subscription.

**Recipient complained**: Activate this filter to show recipients who reported the mailing as spam/junk mail.

If the status is **Ready to send**, you do not have to do anything. SuperOffice will send your mailing to the recipients. The status will be changed to **Sent** once this is done.

## Add recipients to selections or projects

Using the ![icon][img2] menu button you can add recipients and clickers to a selection or project.

> [!NOTE]
> Only contacts already registered in the SuperOffice database will be added to the selection or project. A contact icon ![icon][img3] in the **Type** column indicates that a contact is registered in the SuperOffice database. Recipients imported from external lists will typically not be registered.

### Add clickers to a new selection or project

[!include[How to](../../../learn/includes/howto-add-person-to-selection-new.md)]

### Add clickers to an existing selection or project

[!include[How to](../../../learn/includes/howto-add-person-to-selection-existing.md)]

## Related topics

* [Work with tracked links after the mailing][1]

<!-- Referenced links -->
[1]: ../../../tracked-links/learn/explore-clicks.md
[3]: manage-bounces.md

<!-- Referenced images -->
[img1]: ../../../../../media/icons/arrow-right.png
[img2]: ../../../../../media/icons/btn-menu.png
[img3]: ../../../../../../common/icons/nav-contact.png
[img4]: media/recipients-tab-status.png
