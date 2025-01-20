---
uid: help-en-working-with-sales-guide
title: Example - sales guide
description: Working with sales guide
keywords: sales guide, example
author: SuperOffice RnD
date: 01.07.2025
version: 10.5
topic: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Example - sales guide

Keep in mind that your sales guides may be configured differently in Settings and maintenance.

## Enter a new sale and select a sale type

You record a new sale and select the **Sale to new customer** sale type, which is linked to a sales guide. The sales guide contains the following stages, follow-ups and documents:

| Stage | Follow-ups | Documents |
|---|---|---|
| First meeting | Customer meeting (Meeting (External)) | Meeting confirmation (Email) |
| Quotation | Quotation preparation (Task) | Quotation (Letter) |
| Signing of contract | Set up contract meeting (Phone-Out)<br /> Contract meeting (Meeting (External)) | Signed contract |

## The First meeting stage

1. You have agreed a meeting time and want to create the **Customer meeting** follow-up in the Diary and invite attendees.

    1. In the sales guide, you click **Create** next to the **Customer meeting** follow-up.
        The **Follow-up** dialog opens, with **Meeting (External)** specified as the type and the name of the sale and company prefilled.
    2. Complete the information and [invite attendees][1].
    3. Click **Save**.

2. For the sake of good order, you want to send an email confirming the time and location of the meeting.

    1. Click **Create** next to **Meeting confirmation**.
        The **Document** dialog opens with **Email** already selected as the document type, and the name of the company and sale prefilled.
    2. Complete the rest of the information in the fields in the **Document** dialog.
    3. Click the **Create** button to create and send the email.

3. After the meeting has taken place, you want to confirm this in the sales guide.

    In the sales guide, check the box next to the **Customer meeting** follow-up.

    > [!TIP]
    > You can also do this from the activities list in, for example, the Diary and the Company screens.

## The Quotation stage

1. All of the follow-ups and documents in the **First meeting** stage are completed and you want to go to the next stage in the sales guide.

    1. Click <i class="ph ph-pencil-simple" aria-label="Edit"></i> on the main **Sale** card.
    2. Click the arrow next to the **Stage** field and select **Quotation** from the list.
    3. Click **Save**.
        The follow-ups and documents for this new stage are now displayed in the **Sales guide** section tab.

    > [!TIP]
    > You can also right-click the **Quotation** button on the **Sales guide** section tab and select **Move to this stage**.

2. You want to create a task in your diary to remind you that you need to prepare a quotation.

    1. Click **Create** next to the **Quotation preparation** follow-up.
        The **Task** dialog opens, with **Follow-up** specified as the task type.
    2. Complete the information.
    3. Click **Save**.
    4. After preparing the contents of the quotation, mark the activity as **Completed**.

3. You now want to create the quotation for the company.

    Click **Create** next to the **Quotation** document and [create the document][3].

## The Signing of contract stage

1. After all the follow-ups and documents you want to use in the **Quotation** stage are completed, go to the last stage in the sales guide, which is **Signing of contract**.

    1. Click <i class="ph ph-pencil-simple" aria-label="Edit"></i> on the main **Sale** card.
    2. Click the arrow to the right of the **Stage** field and select **Signing of contract** from the list.
    3. Click **Save**.
        The follow-ups and documents for this stage are now displayed in the **Sales guide** section tab.

2. You want to create and perform the first follow-up in this stage.

    1. Click **Create** next to the **Set up contract meeting** phone call and create the phone call in the usual way.

    2. After completing the phone call, check the box.

    3. In the **Sales guide** dialog you have three options:

        * Click **Create** to create the **Contract meeting** follow-up, which is the next follow-up in the sales guide. This takes you directly to the dialog for follow-ups.

        * Click **Cancel** if you do not want to create the follow-up at the moment. The **Sales guide** dialog closes and you should remember to create the follow-up later on.

        * Check **Always create follow-up? Do not show this dialog again** if, in future, you always want to create the suggested follow-up. The dialog for follow-ups will then open automatically next time.

    > [!NOTE]
    > The **Sales guide** dialog opens because **Automatically suggest this follow-up** is set for the **Contract meeting** follow-up in Settings and maintenance. You can choose to not have this dialog appear, so that the next follow-up is suggested automatically.

3. You want to create the **Contract meeting** follow-up from the **Sales guide** dialog.

    Click **Create** in the **Sales guide** dialog.
    The **Follow-up** dialog opens, where you can create the meeting in the usual way.

4. Then you want to create the contract to take to the meeting.

    1. Click **Create** next to the **Signed contract** document to create the contract.
    2. After the contract meeting and the contract is signed, mark the **Contract meeting** follow-up as completed.

You can now change the stage to **Sold**. After all the required follow-ups and documents for the sale are completed, you can set the sale status to completed.

> [!TIP]
> If you want the sale to remain visible in, for example, the **Activities** section tab in the Sale screen and the **Sales** section tab in the Diary screen, you must not set the sale to completed.

## Related content

* [Set up a sales guide in Settings and maintenance][4]

<!-- Referenced links -->
[1]: ../../diary/learn/invitation/add-attendee.md
[3]: ../../document/learn/edit.md
[4]: ../admin/create-sales-guide.md
