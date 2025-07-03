---
uid: help-en-quote
title: Work with quotes
description: Learn how to create, manage, and send quotes in SuperOffice CRM to streamline your sales process and minimize errors.
keywords: Quote section tab, Quote tab, sales, proposal, quote alternative, quote-to-order, quote
author: Bergfrid Dias
date: 04.25.2025
version: 10.5.4
content_type: concept
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: en
redirect_from:
  - /en/sale/learn/screen/quote-tab
  - /en/quote/learn/index
  - /en/quote/learn/quote-tab
---

# Work with quotes

SuperOffice Quote helps you create, manage, and send quotes quickly and accurately. By using a predefined product database and automated calculations, you can reduce manual errors and save time. Quotes can include multiple alternatives, making it easier for your customer to choose.

After a quote is accepted, you can generate an order with one click and send it for processing—either manually or automatically via an ERP system, depending on your setup.

SuperOffice Quote supports the entire quote-to-order lifecycle. It helps you deliver new or updated quotes faster and speeds up the transition from a lead to a closed deal.

> [!NOTE]
> This feature requires the Sales Premium user plan.

![Quote screen showing a quotation -screenshot][img1]

## Why use SuperOffice Quote?

* Create professional proposals faster
* Reuse products and prices from predefined lists
* Let SuperOffice handle calculations
* Send multiple quote alternatives
* Convert a quote to an order instantly
* Ensure consistency with quote templates
* Reduce approval bottlenecks and errors

## Quote process overview

1. Open a sale and [create a quote][1].
1. [Add products to the quote][2].
1. [Generate the quote document][3] to send to the customer. This is the letter that accompanies the list of products that are being offered.
1. [Send the quote][4].
1. [Place the order][5] once the customer accepts.

![After clicking the button to create a quote, you can start adding your products and services to the quote (animated) -screenshot][img2]

### <a id="status"></a>Quote statuses

| Icon | Status |
|---|---|
| <i class="ph ph-pencil" aria-label="Draft"></i> <i class="ph ph-calculator" aria-label="Draft – not Calculated"></i> | Draft / Draft – not calculated |
| <i class="ph ph-question" aria-label="Needs approval"></i> | Needs approval |
| <i class="ph ph-check-square" aria-label="Approved"></i> <i class="ph ph-x-square" aria-label="Rejected"></i> | Approved / Rejected |
| <i class="ph ph-envelope-simple" aria-label="Sent"></i> | Sent |
| <i class="ph ph-clock-counter-clockwise" aria-label="Sent – Expired"></i> | Sent – expired |
| <i class="ph ph-currency-dollar" aria-hidden="true"></i> <i class="ph ph-check" aria-label="Sold"></i> | Sold |
| <i class="ph ph-currency-dollar" aria-hidden="true"></i> <i class="ph ph-x" aria-label="Lost"></i> | Rejected |
| <i class="ph ph-shopping-cart-simple" aria-label="Ordered"></i> | Ordered |
| <i class="ph ph-folder-simple" aria-label="Archived"></i> | Archived |

## <a id="quote-tab"></a>Quote section tab

In the **Quote** section tab at the bottom of a sale, you can create, view, and manage quotes.

### If no quote exists

* [Create a new quote][1] from scratch
* [Copy quote from another sale][6] (must have the same currency)

### If a quote exists

* View quote number, version, and [status](#status)
* [Create a quote document][3]
* Select and manage quote alternatives (if enabled for the sale type)
* Click **Open** to view or edit the quote
* Export the product list to a spreadsheet

The product list: If products were added to the quote, they are shown in the list. At the bottom of the list, the total price of the products in it is displayed.

## <a id="alternatives"></a>Alternatives in quotes

A quote can contain one or more **alternatives**, letting you offer different combinations of products, quantities, or discounts. Each alternative appears as a tab in the **Edit quote** dialog and can be renamed. This gives the customer options to choose from without requiring multiple quotes.

By default, the first alternative is marked as the **favorite**. The favorite is marked with a star icon <i class="ph ph-star" aria-label="Favorite alternative"></i> and is included when you [send the quote][4]. It also determines the forecast value shown for the sale. To change the favorite, select another alternative tab and click **Favorite alternative** at the bottom of the dialog.

## Tips

To ensure consistency, use a well-designed quote document template. Administrators can customize templates and set up product rules in **Settings and maintenance**.

## Related content

* [Add/edit a product in the quote][2]
* [Create a quote document][3]
* [Add alternatives to a quote][7]
* [Set up your products and prices in Settings and maintenance][11]

<!-- Referenced links -->
[1]: create.md
[2]: create.md#add-products
[6]: create.md#copy
[3]: create-quote-document.md
[4]: send.md
[5]: place-order.md
[7]: add-alternative.md
[11]: ../../admin/quote/price-list-and-products.md

[img1]: ../../../../media/loc/en/sale/quote-management.png
[img2]: ../../../../media/loc/en/sale/quote-create-send.gif
