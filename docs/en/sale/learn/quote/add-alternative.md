---
uid: help-en-quote-alternatives
title: quote add alternative
description: Learn how to create and manage quote alternatives in SuperOffice CRM to offer multiple proposal options.
keywords: quote, quote alternative
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: en
redirect_from: /en/quote/learn/add-alternative
---

# Add alternatives to a quote

Use alternatives to offer different combinations of products, quantities, or pricing within the same quote. Each alternative appears as a separate tab in the **Edit quote** dialog.

You can create a new alternative from scratch or copy an existing one.

> [!NOTE]
> [Alternatives must be enabled][3] for the sale type in Settings and maintenance. If the **+** tab is not visible, choose a different sale type or enable the setting. You can also include only one alternative in the quote.

## Create or copy an alternative

1. In the **Quote** section tab of the sale, click **Open** to edit the quote.

    The quote must be in **Draft** state. If it is already sent, [create a new version][1].

1. Click the **+** tab next to the last alternative.

1. Choose one of the following:

    * **Create new alternative:** Start from scratch
    * **Copy alternative:** Duplicate an existing alternative, including its products

1. In the **Name** field, enter a name for the new alternative. This becomes the tab name.

1. Click **Add**. The new alternative appears as a separate tab.

1. [Add products to the new alternative][2].

1. Optionally, click <i class="ph ph-star" aria-label="Star icon"></i> **Favorite alternative** at the bottom of the tab to set this alternative as the new favorite.

    Estimated sales amounts for the sale (forecast) are obtained from the total amount for the favorite alternative.

## Rename or delete an alternative

1. Select the tab of the alternative you want to update.

1. Click <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> in the lower-left corner to open the task menu.

1. Choose one of the following:

    * **Rename alternative:** Enter a new name and press **Enter**
    * **Delete \[alternative name\]:** Confirm the deletion in the dialog

> [!NOTE]
> The <i class="ph ph-trash" aria-hidden="true"></i> icon below the product list only deletes selected **product lines**, not alternatives.

<!-- Referenced links -->
[1]: send.md#versions
[2]: create.md#add-products
[3]: ../../admin/sale-type.md#quote-fields
