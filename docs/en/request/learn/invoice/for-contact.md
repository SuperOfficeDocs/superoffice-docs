---
uid: help-en-invoice-for-contact
title: View invoice data for contacts
description: View invoice data for contacts
author: Bergfrid Dias
so.date: 03.16.2023
keywords: request, invoice
so.topic: howto
language: en
---

# View invoice data for contacts

When processing requests, you have the option of registering [invoice data][1] as you proceed. When the request is closed, the customer can be invoiced for the work performed.

> [!NOTE]
> The invoice feature is only available if you have registered [invoice types][2] and have the required feature toggle.

## Steps

1. Open the Contact screen.

2. Click the ![icon][img1] **Task** button and select **Invoices**. The **Invoices for ...** screen appears. This contains both requests that include messages with invoiceable hours, and registered invoice items, in chronological order. Note in particular these columns:
    * **Credit**: Shows the total amount for invoicing.
    * **Debit** Shows the total amount invoiced.
    * **Balance**: Shows the running balance (the difference between **Credit** and **Debit**).

3. If you are sending an invoice out to the contact, it is easier to keep an overview in SuperOffice Service if you add an invoice item at the same time.

    [!include[How to add invoice item](includes/howto-add-invoice-to-request.md)]

4. Click **Return to contact** to go back to the Contact screen.

<!-- Referenced links -->
[1]: ../howto/create.md#invoice
[2]: index.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/task.png
