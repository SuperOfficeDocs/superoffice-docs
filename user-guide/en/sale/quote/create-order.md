---
uid: help-en-quote-create-order
title: quote create order
description: quote create order
author: SuperOffice RnD
so.date: 07.04.2022
keywords: quote
so.topic: help
language: en
---

# Place an order

Once the customer has accepted the quote, you can place the order, so that it is sent on to order processing or a warehouse for further action.

> [!TIP]
> If you want to place an order for an archived version of the quote, you need to select this version in the **Version** field and click **Make active**. The archived quote will then be copied and made into the current version. Previous versions of the quote will be archived.

1. Click **Place order** in the **Edit quote** dialog. The **Create order based on quote version** dialog appears. The dialog title shows the quote version that the order is based on.

    > [!NOTE]
    > You cannot place the order if the quote has not been approved (see [Approve quote before sending][1]) or contains errors or warnings (see [Deal with warnings and messages when adding products to a quote][2]).

1. If the quote contains a number of alternatives, select the one you want in the **Select alternative to use** field.
1. If you want to send the order by email, check **Send order confirmation via email**, and choose the email template and language in the lists underneath.
1. Enter the customer's **PO number** (purchase order number), if any, and an **Order comment**, if desired.
1. Check **Mark sale as sold (100%)** if you want to change the status of the sale.
1. Click **OK** when you have finished. If you opted to send the order via email, the **New email** dialog appears. Here you can edit the text and send the confirmation to the customer.

If SuperOffice CRM is connected to an ERP system (either using the built-in solution in SuperOffice or a 3rd party connector), the order will be registered there and processed automatically. If SuperOffice CRM is not connected to an ERP system, you need to register the order manually in the external system.

<!-- Referenced links -->
[1]: approve.md
[2]: add-product.md#warning

<!-- Referenced images -->
