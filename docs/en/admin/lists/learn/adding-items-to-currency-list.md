---
uid: help-en-adding-items-to-currency-list
title: Adding items to the Currency list
description: Adding items to the Currency list
author: SuperOffice RnD
date: 06.29.2022
keywords: Settings and maintenance
content_type: howto
language: en
---
 
# Add items to the General - Currency list

[!include[Note difference](includes/different-edit-list-item-dialog.md)]

[!include[Edit list item](includes/edit-list-item.md)] when the items are currencies:

1. Enter the required name of the item in the **Name** field.

    > [!NOTE]
    > [!include[Mandatory](includes/note-mandatory-field.md)]

2. Specify the rate for the relevant currency by entering a number in the **Rate** field.

    > [!NOTE]
    > This is the rate against the base currency. The base currency is the currency where the rate is set to 1. If the base currency is EUR, the rate for the other currencies is calculated against this currency in terms of the specified unit (see next point). For example, GBP 1 corresponds to EUR 1.562 at the day's rate, while NOK 100 would correspond to EUR 12.677. This calculation is displayed after you specify the exchange rate and unit.

3. Specify the unit to be used in relation to the basic currency in the **Unit** field. For example, the default may be 100 for Norwegian kroner and 1 for British pounds.

4. Optionally, type in a description of the currency in the **Description** field.

5. Click **Save**. The currency is added as a separate item in the **Items** list. Repeat this procedure to add more currencies.

    > [!NOTE]
    > You must enable currencies and set the default currency in the **Preferences** screen (in the **System** group).
