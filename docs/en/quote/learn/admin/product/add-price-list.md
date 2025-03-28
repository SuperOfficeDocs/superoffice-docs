---
uid: help-en-price-list-add
title: Add price list
description: In this how-to guide you will learn how to add and edit a price list in SuperOffice Quote.
author: SuperOffice RnD
date: 02.23.2023
keywords: produdct, price list
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Add a price list

It is not uncommon to use different price lists for different times of the year or for specific campaigns you may want to run.

Customizing price lists helps your salespeople use the correct price details without having to waste time on double checking them. You, as an administrator, can determine when a certain price list should be used by using limited validity.

![You can add and edit all your price lists in the SuperOffice products tab -screenshot][img1]

## Steps

1. [!include[Go to products](../includes/goto-products.md)]

1. Click the **Add** button at the top of the tab. The **Add/Edit price list** dialog appears.

1. Fill in the following fields:

    * **Price list name**: Give the price list a descriptive name to make it easier to distinguish from any other price lists.

    > [!NOTE]
    > You cannot change the currency after you create the price list. To enable currency, go to **Preferences** > **System** > **Enable use of currency**.

    * **Description**: Enter a description of the price list.

    * **Active**: Check here to activate the price list, to make it available for creating quotes. You should not activate the price list until it is completely ready.

    * **Limited validity**: Check here if the price list wil remain valid for a limited period only. For example, during time-limited sales campaign. You can choose a start and end date *OR* just an end date.

1. Do one of the following:

    * Select **Add empty price list** to start with a blank price list and enter all the products manually.
    * Select **Copy existing price list** to copy a price list and all its products.

    1. Select the required price list in the list below.

    2. Select one of the following options:

        * **Convert prices from original price list to &lt;currency&gt;**: Select this option to use the existing prices in the price list. If you copy a price list with a different currency that the price list you are creating, the prices are converted into the right currency.

        * **Set prices to zero &lt;currency&gt;**: Select this option if you do not want to copy the prices from the price list. You must enter the prices of all the products in the price list manually.

1. Click **OK**.

    > [!NOTE]
    > After the price list is created, you may no longer change its currency and validity.

## What would you like to do now?

* [Add products to a price list][1]

<!-- Referenced links -->
[1]: add-product-to-price-list.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/quote/add-price-list.png
