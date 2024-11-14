---
uid: help-en-quote-add-products
title: Add products to quote
description: Add products to quote
author: SuperOffice RnD
date: 07.04.2022
keywords: quote
topic: howto
language: en
---

# Add products

In the **Add/edit product** dialog, you can add a product, and specify a quantity, discounts and other product details.

## Add one product

1. Open a quote and click **Add** at the bottom of the **Products** tab (or an alternative you have created).

1. Double-click a product in the quote.

1. To search in a specific price list, you can select it in the list next to the **Product search** field.

1. Start typing the name of the product or product code in the **Product search** field. The hit list is updated automatically. You can search on all or parts of both the product name and product code.

    > [!TIP]
    > If advanced searching is supported, you can click <i class="ph ph-magnifying-glass" aria-label="Search icon"></i> in the **Product search** field to search for and [add several products simultaneously](#add-multiple).

1. Click the product you want in the list. The dialog is updated with product information.

1. Edit the product quantity, discount and total price, if required. See details below.

1. Read and edit any product information in the **Description** and **Details** tabs.

1. Click **Save + new** to save this product and add a new product
    or
    Click **Save** to save and return to the quote.

## <a id="add-multiple"></a>Add several products to a quote

1. Click **Add** at the bottom of the **Products** tab in the **Edit quote** dialog.

2. Start typing a product name in the **Product search** field to search for a product. Click <i class="ph ph-magnifying-glass" aria-label="Search icon"></i> to search for products using a variety of different criteria, for example, by product range, product groups/categories, name, and item codes. The search includes all active price lists with the applicable currency.

3. After you have found the products you want to add to the quote, select them (**Ctrl+click**), and click **OK**. The products are displayed in the **Products** tab (or in the tab for the alternative you have created).

4. Double-click a product to change the quantity, discounts, and so on.

## Edit quantity, discounts and prices for a product

In the area on the left of the **Add/edit product** dialog, the product name/code are shown, and here you can enter a quantity and any discounts for the selected product.

> [!TIP]
> You can display more information about the different fields (field name, editable field and calculations) by holding the mouse pointer over them.

* Figures shown in black can be edited.
* The total amount and discounts are updated as you edit the different fields.
* A discount can be specified either as a percentage rate, a discount amount or a total amount.
  * The discount field you edited is shown *underlined*.
  * The other fields are updated so that they correspond with the discount you defined.
  * Hold the mouse pointer over a discount field to display any system discounts (such as volume discounts that are added automatically).
* If you specified discounts that are not permitted by the system, a warning or other message is displayed.

## Image tab

An image of the product is shown here, if this is defined in Settings and maintenance.

## Description tab

Detailed product information is shown here, if this is defined in Settings and maintenance.

## Details tab

Detailed price calculations are shown here. The content of this tab is defined in Settings and maintenance.

## <a id="warning"></a>Warnings and how to deal with them

In Settings and maintenance, different rules can be defined for what is allowed and not allowed when you add products to a quote. Depending on how these rules are defined, various icons/warnings may be displayed when you add products to a quote. In some cases, the quote must be [approved before sending][1].

> [!NOTE]
> Products are added to and saved in a quote even if warnings and other messages are displayed, but you cannot send the quote while it contains errors and warnings. You must either correct the error or get the quote approved.

[!include[Table showing quote icons](includes/table-quote-icons.md)]

### Where are these warnings and messages displayed?

* In the **Add/Edit product** dialog
* In the **Edit quote** dialog
* On product lines in the **Quote** section tab and the **Products** (and alternatives) tab in a quote

### What causes these warnings and messages?

Warnings and messages may be due to, for example:

* Products not in the range
* Inactive price lists
* Product price is below minimum price or cost price
* Total price is zero or negative
* Total discount is too high
* Total earnings are too low

<!-- Referenced links -->
[1]: approve.md

<!-- Referenced images -->
