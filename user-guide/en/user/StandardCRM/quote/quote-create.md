---
uid: help-en-quote-create
title: quote create
description: quote create
author: SuperOffice RnD
so.date: 07.04.2022
keywords: CRM
so.topic: help
language: en
---

# Create a quote

To create a quote:

1. Create a new sale (see [Create a sale](../sale/creating-sales.md)).  
    or  
    Open an existing sale (one which is not sold or lost).

2. Go to the **Quote** section tab.

3. Click **Create a new quote** or **Copy quote from another sale**. The **Edit quote** dialog appears.

    <!-- Fix reuse ID=a1 -->

    If the **Select ERP connection** dialog is displayed when you are creating a quote, this may be due to:

    * No price lists being available for the currency of the sale. You need to select another currency for the sale, or create a price list with the desired currency in SuperOffice Settings and maintenance.

    > [!NOTE]
    > If the list of currencies is not displayed next to the sale amount, you may have to enable use of currency. You can do this from **Preferences** &gt; **Enable use of currency** in SuperOffice Settings and maintenance.

    * SuperOffice CRM is connected to one or more ERP systems, and there are several relevant ERP connections to choose between. The ERP connection determines where the product information and prices are obtained from.

You can now start adding products to the quote. See [Add/edit a product in the quote](quote-add-edit-product.md).

See also

[Edit a sent quote (versions)](quote-sent-edit.md)

[The Edit quote dialog](quote-dlg-edit-quote.md)

[Add alternatives to a quote](quote-add-alternative.md)

[Create a quote document](quote-create-quote-document.md)

[Send a quote](quote-send.md)

[Create an order](quote-create-order.md)
