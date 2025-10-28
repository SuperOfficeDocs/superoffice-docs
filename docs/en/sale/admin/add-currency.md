---
uid: help-en-currency-add
title: Currency
description: Adding items to the Currency list
keywords: currency, General - Currency list
author: digitaldiina
date: 10.28.2025
version: 10.5
content_type: howto
category: sale
license: salesessentials
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from:
  - /en/admin/lists/learn/adding-items-to-currency-list
  - /en/admin/lists/learn/currency
language: en
---

# Currency

In the Sale screen tabs in SuperOffice CRM, you specify sale amount, costs and profit for the sale. The currency that the amounts are shown in depends on what you specify in the [preferences][2], where you choose your own currency and a base currency, from a list that is defined in the Lists screen.

## Add currency

1. Select <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lists** in the Navigator.

1. Select **General - Currency** from the dropdown menu. The **Items** tab displays all existing currencies.

1. Click **Add** to open the **Edit list item** dialog.

1. Enter the required name of the item in the **Name** field. *(Mandatory)*

1. Specify the rate for the relevant currency by entering a number in the **Rate** field.

    > [!NOTE]
    > This is the rate against the base currency. The base currency is the currency where the rate is set to 1. If the base currency is EUR, the rate for the other currencies is calculated against this currency in terms of the specified unit (see next point). For example, GBP 1 corresponds to EUR 1.562 at the day's rate, while NOK 100 would correspond to EUR 12.677. This calculation is displayed after you specify the exchange rate and unit.

1. Specify the unit to be used in relation to the basic currency in the **Unit** field. For example, the default may be 100 for Norwegian kroner and 1 for British pounds.

1. Optionally, type in a description of the currency in the **Description** field.

1. Click **Save**. The currency is added as a separate item in the **Items** list. Repeat this procedure to add more currencies.

## Change default currency

To change the default currency, open the **Preferences** screen and go to **Global preferences tab** > **System** > **Base currency**.

## Enable use of currency

To allow sales to be recorded in another currency, open the **Preferences** screen and go to the **Preferences tab** > **System** > **Enable use of currency**.

<!-- Referenced links -->
[2]: ../../admin/preferences/index.md
