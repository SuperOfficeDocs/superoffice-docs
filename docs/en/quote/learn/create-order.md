---
uid: help-en-quote-create-order
title: quote create order
description: In this how-to guide, you will learn how place an order.
author: SuperOffice RnD
date: 02.16.2023
keywords: quote
topic: howto
language: en
---

# Place an order

After the customer accepts the quote, you can place the order, so that it is sent on to order processing or a warehouse for further action.

> [!TIP]
> To place an order for an archived version of the quote, select this version in the **Version** field and click **Make active**. The archived quote will then be copied and made into the current version. Previous versions of the quote will be archived.

1. Click **Place order** in the **Edit quote** dialog. The **Create order based on quote version** dialog appears. The dialog title shows the quote version that the order is based on.

    > [!NOTE]
    > You cannot place the order if the [quote has not been approved][1] or [quote contains errors or warnings][2].

1. If the quote contains multiple alternatives, select the one you want in the **Select alternative to use** field.
1. To send the order by email, check **Send order confirmation via email**, and choose the email template and language.
1. Enter the customer's **PO number** (purchase order number), if any, and an **Order comment**, if desired.
1. Check **Mark sale as sold (100%)** to change the status of the sale.
1. Click **OK**.

    If you opted to send the order via email, the **New email** dialog appears. Here you can edit the text and send the confirmation to the customer.

If SuperOffice CRM is connected to an ERP system (either using the built-in solution in SuperOffice or a 3rd party connector), the order will be registered there and processed automatically. If SuperOffice CRM is not connected to an ERP system, you must register the order manually in the external system.

<!-- Referenced links -->
[1]: approve.md
[2]: create.md#warning

<!-- Referenced images -->
