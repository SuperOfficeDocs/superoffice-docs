---
uid: help-en-quote-create
title: Create a quote
description: Learn how to create a quote in SuperOffice CRM, including how to add products, edit quote details, and resolve common issues.
keywords: create quote, copy quote, add product, Add/edit product dialog, quote
author: Bergfrid Dias
date: 04.09.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: en
redirect_from:
  - /en/quote/learn/add-product
  - /en/quote/learn/copy
  - /en/quote/learn/create
  - /en/quote/learn/screen/edit-quote-dialog
---

# Create a quote

In SuperOffice CRM, you can create a quote from scratch or copy one from another sale. After creating the quote, you can add products, adjust pricing, and prepare the proposal for the customer.

## Create a new quote

1. [Create a new sale][1] or open an existing sale (one that is not marked as Sold or Lost).

1. Go to the **Quote** section tab.

1. Click **Create a new quote**.

1. The **Edit quote** dialog opens. From here, you can [add products](#add-products) and edit the quote details.

![Edit quote dialog -screenshot][img1]

## <a id="copy"></a>Copy a quote from another sale

To save time, you can reuse an existing quote from another sale that uses the same currency.

1. Open a sale without a quote and go to the **Quote** section tab.

1. Click **Copy quote from another sale**.

1. In the **Create new quote by copying an existing quote** dialog:

    * Select a sale from the list (must contain a quote in the same currency).
    * Or, start typing to search by sale name.

1. Click **OK**. The quote and all its alternatives are copied to the current sale and shown in the **Quote** section tab with status **Draft**.

1. Click **Open** to view or edit the quote in the **Edit quote** dialog.

## <a id="add-products"></a>Add products to the quote

### Add one product

1. In the **Products** tab of the quote, click **Add**.
    The **Add/edit product** dialog opens.

1. Start typing in the **Product search** field to find a product by name or code.

1. Select a product from the list.

    Product fields are filled in automatically based on the selected price list.

1. Enter the **quantity** (required).

1. Optionally, adjust pricing using any of the following:

    * **Discount percentage**
    * **Discount amount**
    * **Total price**

    Hold the mouse pointer over a discount field to display any system discounts (such as volume discounts that are added automatically).

1. Go to the **Details** tab to:

    * View or adjust **earnings** (percentage or amount)
    * Optionally set **VAT**

    > [!NOTE]
    > Discount, total price, and earnings are interconnected. Changing one field will update the others automatically. The last edited field is highlighted.
    >
    > If you specify a discount that is not permitted by the system, a warning or other message is displayed.

1. Optional: View product info in the **Description** or **Image** tab.

1. Click **Save** to add the product to the quote, or click **Save + new** to add another product immediately.

![Add/edit product dialog -screenshot][img2]

### Add several products

To add multiple products at once, you must use the advanced search.

1. In the **Products** tab, click **Add**.

1. Click <i class="ph ph-magnifying-glass" aria-label="Search icon"></i> to open the **Find products** dialog.

1. Use one or more criteria to narrow down the list. Click **Add criterion** to include additional filters.

    The search includes all active price lists with the sale's currency.

1. Select the products you want to add: **Ctrl+click** (Windows) or **Cmd+click** (Mac) to select multiple products.

1. Click **OK**. All selected products are added to the quote.

    You return to the **Edit quote** dialog.

1. To set quantity (and optionally update discount, price, or earnings), double-click each product line.

## Set payment and delivery options

Before you send the quote or generate the quote document, go to the **Details** tab in the quote.

Here you can set:

* **Payment terms** and **payment type**
* **Delivery terms** and **delivery type**
* **Invoice address** and **delivery address**

These fields are included in the quote document and used when placing the order.

## Troubleshooting

### Why do I see the "Select ERP connection" dialog?

This dialog appears if:

* No price list exists for the selected currency
* Multiple ERP connections are available

**Solution:** Choose another currency or make sure a valid price list exists. Then select the appropriate ERP connection.

> [!NOTE]
> To enable currency selection in a sale, go to **Settings and maintenance** > **Preferences** and enable **Use of currency**.

### Why can I not find the sale I want to copy from?

When copying a quote, the **Sales** list only shows sales that:

* Contain an existing quote
* Use the same currency as the current sale

**Solution:**

* Check that the sale you want to copy from includes a quote.
* Confirm that both sales use the same currency.
* If needed, change the currency on the current sale to match.

If the list is still empty, no matching sales are available for copying.

### Why is the OK button disabled when copying?

You may not have access to the ERP connection used in the quote.
Hold your pointer over the **OK** button to see which connection is restricted.

### <a id="warning"></a>Why do I see warnings or errors?

When you add or edit products in a quote, SuperOffice may display a message if something is outside the allowed limits.

Common causes include:

* Products not in assortment
* Inactive price lists
* The discount is too high
* The earnings are too low
* The price is too low or zero

The system shows one of the following icons:

| Icon | Message type | Description | What to do |
|:-:|---|---|---|
| <i class="ph ph-info" aria-label="Info icon"></i> | Info | The quote contains a message, but it can still be sent. | Optional: Read and resolve if needed |
| <i class="ph ph-warning" aria-label="Warning icon"></i> | Warning | The quote must be approved before it can be sent. | [Approval is required][7] |
| <i class="ph ph-circle-wavy-warning" aria-label="Error icon"></i> | Error | The quote cannot be sent due to an error. | Correct the error before sending |

These messages may be displayed in the following places:

* In the **Add/edit product** dialog
* In the **Edit quote** dialog
* On product lines in the **Quote** section tab
* In the **Products** tab and alternative tabs in the quote
* When trying to send or place an order.

## Related content

* [Add alternatives to a quote][5]
* [Create a quote document][6]
* [Send a quote][7]
* [Create an order][8]
* [Set up your products and prices in Settings and maintenance][9]

<!-- Referenced links -->
[1]: ../create.md
[5]: add-alternative.md
[6]: create-quote-document.md
[7]: send.md
[8]: place-order.md
[9]: ../../admin/quote/price-list-and-products.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/edit-quote-dialog-empty.png
[img2]: ../../../../media/loc/en/sale/add-edit-product-dialog.png
