---
uid: help-en-quote-dlg-edit-quote
title: quote dlg edit quote
description: quote dlg edit quote
author: SuperOffice RnD
so.date: 07.04.2022
keywords: CRM
so.topic: help
language: en
---

# The Edit quote dialog

This is a description of the **Edit quote** dialog.

## The top section of the dialog

* [Click to create quote document](quote-create-quote-document.md)
* Message/warning (with <!-- Fix reuse ID=a1 -->): See [Deal with warnings and notices when adding products to a quote](quote-product-warnings.md).

    [!include[Table showing quote icons](../../includes/table-quote-icons.md)]

* **Version**: The current version of the quote is shown here. You can select previous versions from the list.
* **Number**: The quote number.
* **State** / <!-- Fix reuse ID=a2 -->: Shows the status of the quote (for example **Draft**, **Needs Approval**, **Sent** or **Sold**)

    [!include[Table showing quote states](../../includes/table-quote-states.md)]

* **[Send](quote-send.md)**: Click this button to send the quote.
* **[Place order](quote-create-order.md)**: Click this button to place the order.

## Products tab (and any alternatives)

The products in the quote are displayed on this tab.

> [!NOTE]
> If the quote contains several alternatives, the favourite alternative is indicated with ![icon](../media/quote-favourite-active.png) next to the tab name.  
If the alternative contains warnings or messages for one or more products, an <!-- Fix reuse ID=a3 --> is shown next to the tab name.

| Icon | Explanation | Solution |
|:-:|---|---|
| ![icon](../media/Quote-Status-OK.png) | OK | - |
| ![icon](../media/Quote-Status-OKWithInfo.png) | OK with information | A message is displayed for the quote, but the quote can be sent as it is. |
| ![icon](../media/Quote-Status-NeedsApproval.png) | Warning: Needs Approval | The quote must be approved before it can be sent. See [Approve quote before sending](quote-approve.md). |
| ![icon](../media/Quote-Status-Error.png) | Error | The error must be corrected before the quote can be sent. |

A message is also displayed to explain the cause of the error.

* **Discount**: Here you can enter a total discount (discount percent or discount amount) for the whole of the alternative. The total discount is applied in addition to any discounts applied to the different products.

> [!NOTE]
> Total discount must be enabled as an option in SuperOffice Settings and maintenance.

* **Earnings/Total**: This shows the earnings and the total for the whole of the alternative.
* **Add**: Click here to search for and add products. See [Add/edit a product in the quote](quote-add-edit-product.md).
* Double-click a product to edit it. See [Add/edit a product in the quote](quote-add-edit-product.md).
* **Delete**: Click here to delete the selected product(s).
* **Export**: Click here to export the list to a spreadsheet. See [Export section tabs](../chap01/Export-archives.md).
* Sort: Use the arrow keys ( ![icon](../media/Pil-opp.bmp) / ![icon](../media/Pil-ned.bmp) ) to change the order of the products.

> [!TIP]
> You can double-click the tabs to change the names of the alternatives in the quote.

## Details tab

Here you choose the desired options for payment and delivery. You can also choose an invoice address and delivery address here.

## Attachments tab

Here you can select one or more attachments to append to the quote. The attachments displayed here are predefined in SuperOffice Settings and maintenance.

The bottom section of the dialog

**Update prices**: Click here to update the prices in the quote from the price list(s).
