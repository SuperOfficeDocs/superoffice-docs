---
uid: help-en-adding-items-to-country-list-web
title: Adding items to the Country list web
description: Adding items to the Country list web
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Add items to the General - Country list

When you add an item to the **General - Country** list in Settings and maintenance, the **Edit list item** dialog is not the same as described under [Add items](Adding-items.md).

To complete the fields in the **Edit list item** dialog when the list items are countries:

1. Enter the required name of the item in the **Name** field. This will be the name of the country.

    > [!NOTE]
    > This is a mandatory field and must therefore be filled in.

2. Optionally, enter the English name for the country in the **English name** field.

3. In the **Top-level domain** field, specify which country address will be used in Internet addresses for the relevant country, for example *NO* for Norway or *DE* for Germany.

4. In the **Postal prefix** field, specify the letter(s) used in front of the postcode when you write to the selected country from another country, for example, *N* for Norway.

5. For each of the next three fields, click the arrow ( ![icon](../../../media/icons/admin/pil-ned.bmp) ) and select the required address format from the list. The same format will usually apply for all three fields, but, for some countries, it may be useful to vary the formats, depending on what you are using the address for:
    * **Visual address format**:  
        This is the usual format as it appears on screen in the **Company** screen in SuperOffice CRM. As a rule, it is sufficient to select a format only here.
    * **Printed address format (local)** and **(intl)**:  
        Some countries use different address formats for letters depending on whether they are posted at home or abroad. Specify the format to be used in each of these cases in these fields.

6. The **Company** screen in SuperOffice CRM contains a field labelled **VAT No.**, for recording the company’s VAT number or similar number. You can change this field label in Settings and maintenance. Type in the desired text in the **Organisation number field label** field, for example, *Org. nr* for Norway. When you enter a Norwegian company in SuperOffice CRM, the label for the company’s organisation number will be *Org. nr* instead of *VAT No.*.

7. Click the arrow ( ![icon](../../../media/icons/admin/pil-ned.bmp) ) next to the **Currency** field and select a currency from the list.

    > [!NOTE]
    > These options are defined in the **General - Currency** list (see [General - Currency](Currency.md)).

8. In the **This country's prefix** field, specify the number used to dial the selected country from another country, for example *47* to dial Norway.

9. Enter the international dialling prefix for the country you are in in the **International prefix** field. As a rule this is *00*.

10. Optionally, type in a description of the country in the **Description** field.

11. Click **Save**. The country is added as a separate item in the **Items** list. Repeat this procedure to add more countries.
